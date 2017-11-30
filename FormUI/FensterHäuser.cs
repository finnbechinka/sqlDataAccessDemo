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
    public partial class FensterHäuser : Form
    {

        List<Haus> häuser = new List<Haus>();

        public FensterHäuser()
        {
            InitializeComponent();

            UpdateBinding();
        }

        private void UpdateBinding()
        {
            HäuserFoundListBox.DataSource = häuser;
            HäuserFoundListBox.DisplayMember = "FullInfo";
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            häuser = db.GetHäuser(BezeichnungText.Text);

            UpdateBinding();
        }

        private void InsertRecordButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            db.InsertHaus(bezeichnungInsText.Text, adresseInsText.Text, hausmeisterTelInsText.Text);

            bezeichnungInsText.Text = "";
            adresseInsText.Text = "";
            hausmeisterTelInsText.Text = "";
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (HausIDText.Text == "" || bezeichnungInsText.Text == "" || adresseInsText.Text == "" || hausmeisterTelInsText.Text == "")
            {
                UpdateFelderFüllenFehler newUpdateFelderFüllenFehler = new UpdateFelderFüllenFehler();
                newUpdateFelderFüllenFehler.ShowDialog();
            }
            else
            {
                DataAccess db = new DataAccess();

                db.UpdateHaus(HausIDText.Text, bezeichnungInsText.Text, adresseInsText.Text, hausmeisterTelInsText.Text);
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

                db.DeleteHaus(HausIDText.Text);
            }
            else if (de.Delete == false)
            {
                LöschvorgangAbgebrochen newLöschvorgangAbgebrochen = new LöschvorgangAbgebrochen();
                newLöschvorgangAbgebrochen.ShowDialog();
            }
        }
    }
}
