using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void buttonMieter_Click(object sender, EventArgs e)
        {
            FensterMieter newFensterMieter = new FensterMieter();
            newFensterMieter.ShowDialog();
        }

        private void buttonWohnungen_Click(object sender, EventArgs e)
        {
            FensterWohnungen newFensterWohnungen = new FensterWohnungen();
            newFensterWohnungen.ShowDialog();
        }

        private void buttonHäuser_Click(object sender, EventArgs e)
        {
            FensterHäuser newFensterHäuser = new FensterHäuser();
            newFensterHäuser.ShowDialog();
        }
    }
}
