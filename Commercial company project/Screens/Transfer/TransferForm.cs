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

namespace Commercial_company_project.Screens.Transfer
{
    public partial class TransferForm : Form
    {
        MOhamedEntities3 db = new MOhamedEntities3();

        private void populate()
        {
            transferDataGridView.Rows.Clear();
            var x = db.TransferItems.ToList();
            foreach (TransferItem item in x)
            {
                int itemidd = (int)item.ItemID;  //int.Parse(SPermissionDataGridView.CurrentRow.Cells[6].Value.ToString());
                var itemmm = db.Items.Find(itemidd);
                int fidd = (int)item.FromStoreID;
                var fromstore = db.Stores.Find(fidd);
                int tidd = (int)item.FromStoreID;
                var tostore = db.Stores.Find(tidd);
                transferDataGridView.Rows.Add(itemmm.ItemName, fromstore.StoreName, tostore.StoreName, item.TransferDate.Value.ToString("yyyy/MM/dd"), item.Quantity, item.ProductionDate.Value.ToString("yyyy/MM/dd"), item.ExpiryDate.Value.ToString("yyyy/MM/dd"));
            }
        }

        public TransferForm()
        {
            InitializeComponent();
            populate();

        }

        private void TransferForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mOhamedDataSet24.Stores' table. You can move, or remove it, as needed.
            this.storesTableAdapter2.Fill(this.mOhamedDataSet24.Stores);
            // TODO: This line of code loads data into the 'mOhamedDataSet23.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.mOhamedDataSet23.Items);
            // TODO: This line of code loads data into the 'mOhamedDataSet22.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.mOhamedDataSet22.Suppliers);
            // TODO: This line of code loads data into the 'mOhamedDataSet21.Stores' table. You can move, or remove it, as needed.
            this.storesTableAdapter1.Fill(this.mOhamedDataSet21.Stores);
            // TODO: This line of code loads data into the 'mOhamedDataSet20.Stores' table. You can move, or remove it, as needed.
            this.storesTableAdapter.Fill(this.mOhamedDataSet20.Stores);

        }

        private void transferutton_Click(object sender, EventArgs e)
        {
            int x = 0;
            int.TryParse(QuantityTextBox.Text, out x);
            if ( QuantityTextBox.Text == "")
            {
                MessageBox.Show("برجاء إستكمال البيانات ");
            }

            else if ( x == 0 )
            {
                MessageBox.Show("أدخل بيانات صحيحة ");
            }
            else if (FromStorecomboBox.Text == ToStorecomboBox.Text)
            {
                MessageBox.Show("لا يمكن التحويل بين نفس المخزن");
            }


            else
            {
                var dialogResult = MessageBox.Show("هل ترغب بالتحويل ", "تأكيد التحويل", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    TransferItem per = new TransferItem();
                    per.FromStoreID = int.Parse(FromStorecomboBox.SelectedValue.ToString());
                    per.TransferDate= DateTime.Now;
                    per.ToStoreID = int.Parse(ToStorecomboBox.SelectedValue.ToString());
                    per.ItemID = int.Parse(storecomboBox.SelectedValue.ToString());
                    per.Quantity = int.Parse(QuantityTextBox.Text);
                    per.SupplierID = int.Parse(SPermissionSuppliercomboBox.SelectedValue.ToString());
                    per.ProductionDate = SPermissionProductionTimePicker1.Value.Date;
                    per.ExpiryDate = SPermissionSAlahiaDateTimePicker.Value.Date;
                    db.TransferItems.Add(per);
                    db.SaveChanges();
                    populate();
                    MessageBox.Show("تم الإضافة بنجاح");
                }
            }
        }

    }
}