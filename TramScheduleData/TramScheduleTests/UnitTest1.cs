using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Linq;
using TramScheduleData.Context;
using TramScheduleData.UngenericRepository;
using TramScheduleLogic;

namespace TramScheduleTests
{
    public class Tests
    {
        private RouteRepository? routeRepository;
        private StopRepository? stopRepository;
        private TramRepository? tramRepository;
        private MockedInputSystem? mockedInput;
        TramContext? context;

        [SetUp]
        public void Setup()
        {
            var dbContextOptions = new DbContextOptionsBuilder<TramContext>()
                .UseInMemoryDatabase(databaseName: "TramDb")
                .Options;
            context = new TramContext(dbContextOptions, isTest: true);
            routeRepository = new RouteRepository(context);
            stopRepository = new StopRepository(context);
            tramRepository = new TramRepository(context);
            mockedInput = new MockedInputSystem();
        }

        [Test]
        public void CreatingAndAddingRouteToDatabase()
        {
            string routeName = "South";
            AddRoute(routeName);

            var route = context.Routes.FirstOrDefault(x => x.Name == routeName);
            Assert.IsNotNull(route);
        }

        [Test]
        public void CreatingRouteWithEmptyNameToDatabaseReturnsArgumentException()
        {
            string routeName = "";
            Assert.Throws<ArgumentException>(() => AddRoute(routeName));
        }

        [Test]
        public void CreatingStopWithEmptyNameToDatabaseReturnsArgumentException()
        {
            string stopName = "";
            Assert.Throws<ArgumentException>(() => AddStop(stopName));
        }

        [Test]
        public void CreatingAndAddingStopToDatabase()
        {
            string stopName = "AWF";
            AddStop(stopName);

            var stop = context.Stops.FirstOrDefault(x => x.Name == stopName);

            Assert.IsNotNull(stop);
        }

        [Test]
        public void AddingStopToRoute()
        {
            string routeName = "North";
            string stopName = "Orzechowa";
            AddRoute(routeName);
            AddStop(stopName);
            
            var route = context.Routes.Include(x => x.Stops).FirstOrDefault(x => x.Name == routeName);
            var stop = context.Stops.FirstOrDefault(x => x.Name == stopName);

            RouteHandler routeHandler = new RouteHandler(routeRepository, mockedInput);
            routeHandler.AddStop(route, stop);
            Assert.IsNotEmpty(route.Stops);
        }

        [Test]
        public void CreatingAndAddingTramToDatabase()
        {
            string tramName = "57";
            TramHandler tramHandler = new TramHandler(tramRepository, mockedInput);
            mockedInput.Text = tramName;
            tramHandler.Add();

            var tram = context.Trams.FirstOrDefault(x => x.Name == tramName);
            Assert.IsNotNull(tram);
        }

        private void AddRoute(string routeName)
        {
            RouteHandler routeHandler = new RouteHandler(routeRepository, mockedInput);
            mockedInput.Text = routeName;
            routeHandler.Add();
        }

        private void AddStop(string stopName)
        {
            StopHandler stopHandler = new StopHandler(stopRepository, mockedInput);
            mockedInput.Text = stopName;
            stopHandler.Add();
        }
    }
}