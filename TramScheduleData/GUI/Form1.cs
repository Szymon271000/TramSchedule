using TramScheduleData.Context;
using TramScheduleData.Model;
using TramScheduleData.UngenericRepository;

namespace GUI
{
    public partial class Form1 : Form
    {
        private RouteRepository _routeRepository;
        private StopRepository _stopRepository;
        private TramRepository _tramRepository;
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = String.Empty;
            listBox2.Items.Clear();
            var selectedIndex = listBox1.SelectedIndex + 2; // w bazie pierwszy element ma id 2
            if (listBox1.SelectedItem is Route)
            {
                label2.Text = "Stop details";
                List<Stop> stops = _routeRepository.GetAllTramStop(selectedIndex).ToList();
                foreach (Stop stop in stops)
                {
                    listBox2.Items.Add(stop);
                }
            }
            if (listBox1.SelectedItem is Tram)
            {
                label2.Text = "Route details";
                selectedIndex = listBox1.SelectedIndex + 3; // w bazie pierwszy element ma id 3
                Tram tram = _tramRepository.GetRouteOfTram(selectedIndex);
                listBox2.Items.Add(tram.Route.Name);
            }
            if (listBox1.SelectedItem is Stop)
            {
                label2.Text = "Stop details";
                selectedIndex = listBox1.SelectedIndex + 5; // w bazie pierwszy element ma id 5
                Stop stop = _stopRepository.GetStop(selectedIndex);
                listBox2.Items.Add(stop.Name);
                listBox2.Items.Add(stop.Details);
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
    }
}