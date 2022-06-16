using TramScheduleData.Context;
using TramScheduleData.Model;
using TramScheduleData.UngenericRepository;

namespace GUI
{
    public partial class Form1 : Form
    {
        private readonly RouteRepository _routeRepository;
        private readonly StopRepository _stopRepository;
        private readonly TramRepository _tramRepository;
        public Form1()
        {
            InitializeComponent();
            _routeRepository = new RouteRepository();
            _stopRepository = new StopRepository();
            _tramRepository = new TramRepository();
        }

        private void DisplayRoutesButton_Click(object sender, EventArgs e)
        {
            label2.Text = String.Empty;
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            label1.Text = "Routes in the system";
            List<Route> routes = _routeRepository.GetAll();
            foreach (Route route in routes)
            {
                listBox1.Items.Add(route);
            }
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = String.Empty;
            listBox2.Items.Clear();
            if (listBox1.SelectedItem is Route route)
            {
                DisplayStopsAfterClickingRoute(route.RouteId);
            }
            if (listBox1.SelectedItem is Tram tram)
            { 
                DisplayRouteAfterClickingTram(tram.TramId);
            }
            if (listBox1.SelectedItem is Stop stop)
            {
                DisplayStopDescriptionAfterClickingStop(stop.StopId);
            }
        }

        private void DisplayStopDescriptionAfterClickingStop(int selectedIndex)
        {
            label2.Text = "Stop details";
            Stop stop = _stopRepository.GetStop(selectedIndex);
            listBox2.Items.Add(stop.Name);
            listBox2.Items.Add(stop.Details);
        }

        private void DisplayRouteAfterClickingTram(int selectedIndex)
        {
            label2.Text = "Route details";
            Tram tram = _tramRepository.GetRouteOfTram(selectedIndex);
            listBox2.Items.Add(tram.Route.Name);
        }

        private void DisplayStopsAfterClickingRoute(int selectedIndex)
        {
            label2.Text = "Stop details";
            List<Stop> stops = _routeRepository.GetAllTramStop(selectedIndex).ToList();
            foreach (Stop stop in stops)
            {
                listBox2.Items.Add(stop);
            }
        }

        private void DisplayTramsButton_Click(object sender, EventArgs e)
        {
            label2.Text = String.Empty;
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            label1.Text = "Trams in the system";
            List<Tram> trams = _tramRepository.GetAll();
            foreach (Tram tram in trams)
            {
                listBox1.Items.Add(tram);
            }
        }

        private void DisplayStopsButton_Click(object sender, EventArgs e)
        {
            label2.Text = String.Empty;
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            label1.Text = "Stops in the system";
            List<Stop> stops = _stopRepository.GetAll();
            foreach (Stop stop in stops)
            {
                listBox1.Items.Add(stop);
            }
        }

        private void AddAStopButton_Click(object sender, EventArgs e)
        {
            var addStopWindow = new AddStopWindow();
            addStopWindow.ShowDialog();
        }

        private void AddARouteButton_Click(object sender, EventArgs e)
        {
            var addRouteWindow = new AddARouteWindow();
            addRouteWindow.ShowDialog();
        }

        private void EditARouteButton_Click(object sender, EventArgs e)
        {
            var editRouteWindow = new EditRouteWindow();
            editRouteWindow.ShowDialog();
        }
    }
}