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
    public partial class AddARouteWindow : Form
    {
        private RouteRepository _routeRepository;
        public AddARouteWindow()
        {
            _routeRepository = new RouteRepository();
            InitializeComponent();
        }

        private void AddStop_Click(object sender, EventArgs e)
        {
            if (NameOfRouteBox.Text != string.Empty && NameOfRouteBox.Text.Length > 4)
            {
                var existingStop = _routeRepository.GetRouteByName(NameOfRouteBox.Text);
                if (existingStop != null)
                {
                    MessageBox.Show("This route already exists");
                }
                else
                {
                    Route route = new Route(NameOfRouteBox.Text);
                    _routeRepository.Insert(route);
                    _routeRepository.Save();
                }
                NameOfRouteBox.Text = String.Empty;

            }
            else
            {
                MessageBox.Show("Pola zle uzupelnione, pole nie moze byc puste i ma miec co najmniej 5 znakow");
                NameOfRouteBox.Text = String.Empty;
            }
        }
    }
}
