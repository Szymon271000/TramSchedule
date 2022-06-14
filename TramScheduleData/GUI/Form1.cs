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
            listBox1.Items.Clear();
            label1.Text = "Routes in the system";
            List<Route> routes = _routeRepository.GetAll();
            foreach (Route route in routes)
            {
                listBox1.Items.Add(route.Name);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TO DO!
        }

        private void DisplayTramsButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            label1.Text = "Trams in the system";
            List<Tram> trams = _tramRepository.GetAll();
            foreach (Tram tram in trams)
            {
                listBox1.Items.Add(tram.Name);
            }
        }

        private void DisplayStopsButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            label1.Text = "Stops in the system";
            List<Stop> stops = _stopRepository.GetAll();
            foreach (Stop stop in stops)
            {
                listBox1.Items.Add(stop.Name);
            }
        }
    }
}