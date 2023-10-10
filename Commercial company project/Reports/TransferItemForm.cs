using Commercial_company_project.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Commercial_company_project.Reports
{
    public partial class TransferItemForm : Form
    {
        MOhamedEntities3 db = new MOhamedEntities3();

        public int[] checkedStores()
        {
            // Initialize an empty list to store checked values
            List<int> checkedValues = new List<int>();

            // Iterate through the items in the CheckedListBox
            for (int i = 0; i < checkedListBox2.Items.Count; i++)
            {
                if (checkedListBox2.GetItemChecked(i))
                {
                    // If the item at index i is checked, add its value to the list
                    int itemValue = ((Store)checkedListBox2.Items[i]).StoreID;
                    checkedValues.Add(itemValue);
                }
            }

            // Convert the list to an array if needed
            int[] checkedValuesArray = checkedValues.ToArray();
            return checkedValuesArray;

        }
        public TransferItemForm()
        {
            InitializeComponent();

            var ite = db.Items.ToList();

            foreach (var item in ite)
            {
                // checkedListBox1.Items.Add(item.ItemName);

            }
            var sto = db.Stores.ToList();


            //list for store in db 
            List<Store> iiItems = new List<Store>();


            foreach (var item in sto)
            {
                iiItems.Add(new Store { StoreID = item.StoreID, StoreName = item.StoreName });

            }

            checkedListBox2.DataSource = iiItems;
            checkedListBox2.ValueMember = "StoreID";
            checkedListBox2.DisplayMember = "StoreName";

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {

            int[] checks = checkedStores();

            gunaLabel4.Text = DateTime.Now.ToShortDateString().ToString();


            reportStoredDataGridView.Rows.Clear();




            DateTime fromDate = Convert.ToDateTime(FromTimePicker1.Text);
            DateTime toDate = Convert.ToDateTime(ToTimePicker.Value);
            // MessageBox.Show(iddd + "  "  + fromDate + "  "+ toDate);

            var resultin = db.supplyin( fromDate, toDate).ToList();
            var resultout = db.supplyin(fromDate, toDate).ToList();


            foreach (var item in resultin)
            {
                for (int i = 0; i < checks.Length; i++)
                {
                    if (item.StoreID == checks[i])
                    {
                        reportStoredDatdddGridView.Rows.Add(item.StoreName, item.ItemName, item.Quantity, item.UnitName, item.Price, "وارد");
                    }
                }
            }
            foreach (var item in resultout)
            {
                for (int i = 0; i < checks.Length; i++)
                {
                    if (item.StoreID == checks[i])
                    {
                        reportStoredDatdddGridView.Rows.Add(item.StoreName, item.ItemName, item.Quantity, item.UnitName, item.Price, "صادر");
                    } }
            }


            //------------------------------------
            gunaLabel4.Text = DateTime.Now.ToShortDateString().ToString();

            reportStoredDataGridView.Rows.Clear();

            DateTime fromDate2 = Convert.ToDateTime(FromTimePicker1.Text);
            DateTime toDate2 = Convert.ToDateTime(ToTimePicker.Value);
            // MessageBox.Show(iddd + "  "  + fromDate + "  "+ toDate);

            var result = db.getTransferItems(fromDate2, toDate2).ToList();

            foreach (var item in result)
            {
                for (int i = 0; i < checks.Length; i++)
                {
                    if (item.FromStoreID == checks[i])
                    {
                        reportStoredDataGridView.Rows.Add(item.ItemName, item.FromStoreName, item.ToStoreName, item.Quantity);
                    }
                    if (item.ToStoreID == checks[i])
                    {
                        reportStoredDataGridView.Rows.Add(item.ItemName, item.FromStoreName, item.ToStoreName, item.Quantity);
                    }
                }
            }
        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel6_Click(object sender, EventArgs e)
        {

        }

        private void FromTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void reportStoredDatdddGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
