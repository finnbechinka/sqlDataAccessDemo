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
    public partial class FensterWohnungen : Form
    {

        List<Wohnung> wohnungen = new List<Wohnung>();

        public FensterWohnungen()
        {
            InitializeComponent();

            UpdateBinding();
        }

        private void UpdateBinding()
        {
            WohnungenFoundListBox.DataSource = wohnungen;
            WohnungenFoundListBox.DisplayMember = "FullInfoWohnung";
        }

        private void SearchButtonWohn_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            wohnungen = db.GetWohnung(HausIDText.Text);

            UpdateBinding();
        }

        private void InsertRecordButtonWohn_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            db.InsertWohnung(HausIDInsText.Text, StockwerkInsText.Text, GrößeInsText.Text);

            HausIDInsText.Text = "";
            StockwerkInsText.Text = "";
            GrößeInsText.Text = "";
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (WohnungsIDText.Text == "" || HausIDInsText.Text == "" || StockwerkInsText.Text == "" || GrößeInsText.Text == "")
            {
                UpdateFelderFüllenFehler newUpdateFelderFüllenFehler = new UpdateFelderFüllenFehler();
                newUpdateFelderFüllenFehler.ShowDialog();
            }
            else
            {
                DataAccess db = new DataAccess();

                db.UpdateWohnung(WohnungsIDText.Text, HausIDInsText.Text, StockwerkInsText.Text, GrößeInsText.Text);
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

                db.DeletWohnung(WohnungsIDText.Text);
            }
            else if (de.Delete == false)
            {
                LöschvorgangAbgebrochen newLöschvorgangAbgebrochen = new LöschvorgangAbgebrochen();
                newLöschvorgangAbgebrochen.ShowDialog();
            }
        }
    }
}
