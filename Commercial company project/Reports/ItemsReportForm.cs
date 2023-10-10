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
    public partial class ItemsReportForm : Form
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

        /* private void populate()
         {
             try
             {
                 reportStoredDataGridView.Rows.Clear();
                 int iddd = int.Parse(comboBox2.SelectedValue.ToString());
                 DateTime fromDate = Convert.ToDateTime(FromTimePicker1.Text);
                 DateTime toDate = Convert.ToDateTime(ToTimePicker.Value);
                 // MessageBox.Show(iddd + "  "  + fromDate + "  "+ toDate);
                 var x = db.StoreItemIn(1, fromDate, toDate).ToList();
                 foreach (var item in x)
                 {
                     reportStoredDataGridView.Rows.Add(item.ItemName, item.StoreName, item.SupplierName, item.Quantity, item.Price);

                 }
             }
             catch
             {

             }
         }
 */
        public ItemsReportForm()
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

        private void storeReportEditButton_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void ToTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ItemsReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'itemNameItemIDDataSet.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.itemNameItemIDDataSet.Items);

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            int[] checks = checkedStores();
            gunaLabel10.Text = "";
            gunaLabel4.Text = DateTime.Now.ToShortDateString().ToString();


            reportStoredDataGridView.Rows.Clear();
            int iddd = int.Parse(comboBox2.SelectedValue.ToString());
            var merUnitsResu = db.getMesaringUnits(iddd).ToList(); 

            var itemNameee = db.Items.Find(iddd);
            gunaLabel5.Text = itemNameee.ItemName.ToString();

            foreach (var item in merUnitsResu)
            {
                gunaLabel10.Text +=   item.UnitName.ToString() + " - ";
            }

            gunaLabel8.Text = itemNameee.ItemCode.ToString();


            DateTime fromDate = Convert.ToDateTime(FromTimePicker1.Text);
            DateTime toDate = Convert.ToDateTime(ToTimePicker.Value);
            // MessageBox.Show(iddd + "  "  + fromDate + "  "+ toDate);

            var result = db.itemInStoresIn(iddd, fromDate, toDate).ToList();

            foreach (var item in result)
            {
                for (int i = 0; i < checks.Length; i++)
                {
                    if (item.StoreID == checks[i])
                    reportStoredDataGridView.Rows.Add(item.ItemName, item.StoreName, item.SupplierName, item.Quantity, item.Price);
                }
            }

        }

        private void checkedListBox2_ItemCheck(object sender, ItemCheckEventArgs e)
        {

        }
    }
}
