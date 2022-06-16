using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TramScheduleData.Model;
using TramScheduleData.UngenericRepository;

namespace GUI
{
    public partial class EditRouteWindow : Form
    {
        private readonly RouteRepository _routeRepository;
        private readonly StopRepository _stopRepository;

        public EditRouteWindow()
        {
            InitializeComponent();
            _routeRepository = new RouteRepository();
            _stopRepository = new StopRepository();
            AddingRoutesToListBox();
            AddingStopToListBox();
        }

        private void AddingStopToListBox()
        {
            List<Stop> stops = _stopRepository.GetAll();
            foreach (Stop stop in stops)
            {
                ListStopBox.Items.Add(stop);
            }
        }

        private void AddingRoutesToListBox()
        {
            List<Route> routes = _routeRepository.GetAll();
            foreach (Route route in routes)
            {
                ListRouteBox.Items.Add(route);
            }
        }

        private void ListRouteBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndex = ListRouteBox.SelectedIndex + 2; // w bazie pierwszy element ma id 2
            if (ListRouteBox.SelectedItem is Route)
            {
                DisplayStopsAfterClickingRoute(selectedIndex);
            }
        }
        private void DisplayStopsAfterClickingRoute(int selectedIndex)
        {
            UpdatedRouteList.Items.Clear();
            List<Stop> stops = _routeRepository.GetAllTramStop(selectedIndex).ToList();
            foreach (Stop stop in stops)
            {
                UpdatedRouteList.Items.Add(stop);
            }
        }

        private void DeleteAStopButton_Click(object sender, EventArgs e)
        {
            if (ListRouteBox.SelectedItem is Route route && UpdatedRouteList.SelectedItem is Stop stop)
            {
                if(_routeRepository.RemoveStop(route.RouteId, stop.StopId))
                {
                    _routeRepository.Save();
                    UpdatedRouteList.Items.Remove(stop);
                }
            }
            else
            {
                MessageBox.Show("Musisz zaznaczyc najpierw route i potem przystanek do skasowania");
            }
        }

        private void AddAStopButton_Click(object sender, EventArgs e)
        {
            if (ListRouteBox.SelectedItem is Route route && ListStopBox.SelectedItem is Stop stop)
            {
                if (_routeRepository.AddStop(route.RouteId, stop.StopId))
                {
                    _routeRepository.Save();
                    UpdatedRouteList.Items.Add(stop);
                }
                else
                {
                    MessageBox.Show("Dodanie nie zostalo zrealizowane, czy ten route nie ma juz tego przystanka?");
                }
            }
            else
            {
                MessageBox.Show("Musisz zaznaczyc najpierw route i potem przystanek do dodania");
            }
        }
    }
}
