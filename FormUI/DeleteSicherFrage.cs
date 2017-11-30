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
    public partial class DeleteSicherFrage : Form
    {
        DeleteEntscheidung de = new DeleteEntscheidung();
        public DeleteSicherFrage()
        {
            InitializeComponent();
        }

        public void ButtonJa_Click(object sender, EventArgs e)
        {
            de.cEntscheidung(true);
            Close();
        }

        private void ButtonNein_Click(object sender, EventArgs e)
        {
            de.cEntscheidung(false);
            Close();
        }
    }
}
