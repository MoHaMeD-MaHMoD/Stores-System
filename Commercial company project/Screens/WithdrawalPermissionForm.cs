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

namespace Commercial_company_project.Screens
{
    public partial class WithdrawalPermissionForm : Form
    {
        MOhamedEntities3 db = new MOhamedEntities3();
        private void populate()
        {
            SPermissionDataGridView.Rows.Clear();
            var x = db.WithdrawPermissions.ToList();
            foreach (WithdrawPermission item in x)
            {

                int itemidd = (int)item.ItemID;  //int.Parse(SPermissionDataGridView.CurrentRow.Cells[6].Value.ToString());
                var itemmm = db.Items.Find(itemidd);

                int sidd = (int)item.SupplierID;
                var sp = db.Suppliers.Find(sidd);

                SPermissionDataGridView.Rows.Add(item.OrderNumber, item.OrderDate.Value.ToString("yyyy/MM/dd"), itemmm.ItemName, sp.SupplierName, item.MeasruingUnit.UnitName, item.Quantity);

            }
        }
        public WithdrawalPermissionForm()
        {
            InitializeComponent();
            populate();

        }

        private void WithdrawalPermissionForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mOhamedDataSet17.Stores' table. You can move, or remove it, as needed.
            this.storesTableAdapter.Fill(this.mOhamedDataSet17.Stores);
            // TODO: This line of code loads data into the 'mOhamedDataSet16.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.mOhamedDataSet16.Items);
            // TODO: This line of code loads data into the 'mOhamedDataSet15.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.mOhamedDataSet15.Suppliers);

        }

        private void SaveSPermissionButton_Click(object sender, EventArgs e)
        {
            int x = 0;
            int.TryParse(QuantityTextBox.Text, out x);

            int y = 0;
            int.TryParse(QuantityTextBox.Text, out y);

            if (SPermissionPriceBox.Text == "" || QuantityTextBox.Text == "")
            {
                MessageBox.Show("برجاء إستكمال البيانات ");
            }

            else if (y == 0 || x == 0)
            {
                MessageBox.Show("أدخل بيانات صحيحة ");
            }



            else
            {
                var dialogResult = MessageBox.Show("هل ترغب بإضافة تصريح جديد", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    WithdrawPermission per = new WithdrawPermission();
                    per.StoreID = int.Parse(comboBox2.SelectedValue.ToString());
                    per.OrderDate = DateTime.Now;
                    per.SupplierID = int.Parse(SPermissionSuppliercomboBox.SelectedValue.ToString());
                    per.MeasreuingUnit = int.Parse(SPermissionMeasureUnit.SelectedValue.ToString());

                    per.ItemID = int.Parse(storecomboBox.SelectedValue.ToString());
                    per.Quantity = int.Parse(QuantityTextBox.Text);
                    per.Price = int.Parse(SPermissionPriceBox.Text);

                    db.WithdrawPermissions.Add(per);
                    db.SaveChanges();
                    populate();
                    MessageBox.Show("تم الإضافة بنجاح");
                }
            }
        }

        private void SPermissionEditButton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(SPermissionDataGridView.CurrentRow.Cells[0].Value.ToString());

            int x = 0;
            int.TryParse(QuantityTextBox.Text, out x);

            int y = 0;
            int.TryParse(SPermissionPriceBox.Text, out y);

            if (y == 0 || x == 0)
            {
                MessageBox.Show("أدخل بيانات صحيحة");
            }


            else
            {
                var result = db.WithdrawPermissions.SingleOrDefault(w => w.OrderNumber == id);


                result.StoreID = int.Parse(comboBox2.SelectedValue.ToString());
                result.OrderDate = SPermissionDateTimePicker3.Value.Date;
                result.SupplierID = int.Parse(SPermissionSuppliercomboBox.SelectedValue.ToString());
                result.MeasreuingUnit = int.Parse(SPermissionMeasureUnit.SelectedValue.ToString());

                result.ItemID = int.Parse(storecomboBox.SelectedValue.ToString());
                result.Quantity = int.Parse(QuantityTextBox.Text);
                result.Price = int.Parse(SPermissionPriceBox.Text);

                populate();
                db.SaveChanges();
                MessageBox.Show("تم التعديل بنجاح");
            }
        }

        private void SPermissionButtonDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(SPermissionDataGridView.CurrentRow.Cells[0].Value.ToString());
            var result = db.WithdrawPermissions.Find(id);
            var deleteOption = MessageBox.Show("ترغب بالفعل فى حذف التصريح ؟", "تأكيد الحذف", MessageBoxButtons.YesNo);
            if (deleteOption == DialogResult.Yes)
            {
                db.WithdrawPermissions.Remove(result);
                db.SaveChanges();
                populate();
                MessageBox.Show("تم حذف التصريح بنجاح ");
            }
        }

        private void SPermissionDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int wpID = int.Parse(SPermissionDataGridView.CurrentRow.Cells[0].Value.ToString());
                var withdrawalPermissionll = db.WithdrawPermissions.Find(wpID);
                SPermissionOrderNUm.Text = withdrawalPermissionll.OrderNumber.ToString();
                //storeID
                int idd = int.Parse(withdrawalPermissionll.StoreID.Value.ToString());
                var st = db.Stores.Find(idd);
                comboBox2.Text = st.StoreName;
                //orderDate
                SPermissionDateTimePicker3.Value = Convert.ToDateTime(withdrawalPermissionll.OrderDate); // SPermissionDataGridView.CurrentRow.Cells[2].Value.ToString();
                                                                                                         //supplier ID
                int sidd = (int)withdrawalPermissionll.SupplierID;//int.Parse(SPermissionDataGridView.CurrentRow.Cells[3].Value.ToString());
                var sp = db.Suppliers.Find(sidd);
                SPermissionSuppliercomboBox.Text = sp.SupplierName;
                // item id
                int itemidd = (int)withdrawalPermissionll.ItemID;  //int.Parse(SPermissionDataGridView.CurrentRow.Cells[6].Value.ToString());
                var itemmm = db.Items.Find(itemidd);
                storecomboBox.Text = itemmm.ItemName;

                // quan
                QuantityTextBox.Text = withdrawalPermissionll.Quantity.ToString();// SPermissionDataGridView.CurrentRow.Cells[8].Value.ToString();
                                                                                  //price
                SPermissionPriceBox.Text = withdrawalPermissionll.Price.ToString(); // SPermissionDataGridView.CurrentRow.Cells[9].Value.ToString(); ;
            }
            catch { }
        }

        private void storecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int idd = int.Parse(storecomboBox.SelectedValue.ToString());
                //MessageBox.Show(idd.ToString());
                var x = db.Items.Find(idd);

                SPermissionMeasureUnit.DataSource = x.MeasruingUnits.ToList();
                SPermissionMeasureUnit.DisplayMember = "UnitName";
                SPermissionMeasureUnit.ValueMember = "UnitID";
            }
            catch
            {

            }
        }
    }
}
