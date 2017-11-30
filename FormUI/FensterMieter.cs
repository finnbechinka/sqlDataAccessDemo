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
    public partial class FensterMieter : Form
    {
        List<Mieter> mieter = new List<Mieter>();

        public FensterMieter()
        {
            InitializeComponent();

            UpdateBinding();
        }

        private void UpdateBinding()
        {
            MieterFoundListBox.DataSource = mieter;
            MieterFoundListBox.DisplayMember = "FullInfoMieter";
        }

        private void SearchButtonMieter_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            mieter = db.GetMieter(NachnameText.Text);

            UpdateBinding();
        }

        private void InsertRecordButtonMieter_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            db.InsertMieter(NachnameInsText.Text, VornameInsText.Text, TelInsText.Text, WohnungsIDInsText.Text);

            NachnameInsText.Text = "";
            VornameInsText.Text = "";
            TelInsText.Text = "";
            WohnungsIDInsText.Text = "";
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (MieterIDText.Text == "" || NachnameInsText.Text == "" || VornameInsText.Text == "" || TelInsText.Text == "" || WohnungsIDInsText.Text == "")
            {
                UpdateFelderFüllenFehler newUpdateFelderFüllenFehler = new UpdateFelderFüllenFehler();
                newUpdateFelderFüllenFehler.ShowDialog();
            }
            else
            {
                DataAccess db = new DataAccess();

                db.UpdateMieter(MieterIDText.Text, NachnameInsText.Text, VornameInsText.Text, TelInsText.Text, WohnungsIDInsText.Text);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteSicherFrage newDeleteSicherFrage = new DeleteSicherFrage();
            newDeleteSicherFrage.ShowDialog();

            DeleteEntscheidung de = new DeleteEntscheidung();

            if (de.Delete == true)
            {
                DataAccess db = new DataAccess();

                db.DeleteMieter(MieterIDText.Text);
            }
            else if (de.Delete == false)
            {
                LöschvorgangAbgebrochen newLöschvorgangAbgebrochen = new LöschvorgangAbgebrochen();
                newLöschvorgangAbgebrochen.ShowDialog();
            }
        }
    }
}
