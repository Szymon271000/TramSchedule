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
    public partial class AddStopWindow : Form
    {
        private StopRepository _stopRepository;

        public AddStopWindow()
        {
            _stopRepository = new StopRepository();
            InitializeComponent();
        }

        private void AddStop_Click(object sender, EventArgs e)
        {
            if (NameOfStoptextBox.Text != string.Empty && DetailsOfTheStopBox.Text != string.Empty
                && NameOfStoptextBox.Text.Length > 5 && DetailsOfTheStopBox.Text.Length > 5)
            {
                var existingStop = _stopRepository.GetStopByName(NameOfStoptextBox.Text);
                if (existingStop != null)
                {
                    MessageBox.Show("This stop already exists");
                }
                else
                {
                    CreatingAndAddingStopToDatabase();
                }
                NameOfStoptextBox.Text = String.Empty;
                DetailsOfTheStopBox.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("Pola zle uzupelnione, pola nie moga byc puste i maja miec co najmniej 5 znakow");
                NameOfStoptextBox.Text = String.Empty;
                DetailsOfTheStopBox.Text = String.Empty;
            }
        }

        private void CreatingAndAddingStopToDatabase()
        {
            Stop stop = new Stop(NameOfStoptextBox.Text, DetailsOfTheStopBox.Text);
            _stopRepository.Insert(stop);
            _stopRepository.Save();
            MessageBox.Show($"{stop.Name} has been added");
        }
    }
}
