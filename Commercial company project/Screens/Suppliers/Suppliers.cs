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

namespace Commercial_company_project.Screens.Suppliers
{
    public partial class Suppliers : Form
    {
        MOhamedEntities3 db = new MOhamedEntities3();

        public Suppliers()
        {
            InitializeComponent();
            supplierDataGridView.DataSource = db.Suppliers.ToList();

        }




        private void supplierButtonDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(supplierDataGridView.CurrentRow.Cells[0].Value.ToString());
            var result = db.Suppliers.Find(id);
            var deleteOption = MessageBox.Show("ترغب بالفعل فى حذف المورد ؟", " ", MessageBoxButtons.YesNo);
            if (deleteOption == DialogResult.Yes)
            {
                db.Suppliers.Remove(result);
                db.SaveChanges();
                supplierDataGridView.DataSource = db.Suppliers.ToList();
                MessageBox.Show("تم حذف المورد بنجاح ");

            }
        }

        private void supplierDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            clientNameTextBox.Text = supplierDataGridView.CurrentRow.Cells[1].Value.ToString();
            clientTextBoxPhone.Text = supplierDataGridView.CurrentRow.Cells[2].Value.ToString();
            clientTextBoxFax.Text = supplierDataGridView.CurrentRow.Cells[3].Value.ToString();
            clientTextBoxMobile.Text = supplierDataGridView.CurrentRow.Cells[4].Value.ToString();
            clientTextBoxEmail.Text = supplierDataGridView.CurrentRow.Cells[5].Value.ToString();
            clientTextBoxWebSite.Text = supplierDataGridView.CurrentRow.Cells[6].Value.ToString();
        }

        private void supplierSaveButton_Click(object sender, EventArgs e)
        {
            if (clientNameTextBox.Text == "" || clientTextBoxPhone.Text == "")
            {
                MessageBox.Show("برجاء إستكمال البيانات ");
            } else if (db.Suppliers.Where(x=>x.Phone==clientTextBoxPhone.Text).Count() > 0)
            {
                MessageBox.Show("مورد مكرر أو رقم تلفون مكرر");


            }
            else

            {
                var dialogResult = MessageBox.Show("هل ترغب بإضافة مورد جديد", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Supplier supplier = new Supplier();
                    supplier.SupplierName = clientNameTextBox.Text;
                    supplier.Phone = clientTextBoxPhone.Text;
                    supplier.Mobile = clientTextBoxMobile.Text;
                    supplier.Fax = clientTextBoxFax.Text;
                    supplier.Email = clientTextBoxEmail.Text;
                    supplier.Website = clientTextBoxWebSite.Text;
                    db.Suppliers.Add(supplier);
                    db.SaveChanges();
                    supplierDataGridView.DataSource = db.Suppliers.ToList();

                    MessageBox.Show("تم الإضافة بنجاح");
                }



            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            supplierDataGridView.DataSource=db.Suppliers.ToList();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (clientNameTextBox.Text == "")
               supplierDataGridView.DataSource = db.Suppliers.Where(x => x.Phone.Contains(gunaTextBox1.Text)).ToList();
            else
                supplierDataGridView.DataSource = db.Suppliers.Where(x => x.Phone.Contains(gunaTextBox1.Text) || x.SupplierName.Contains(gunaTextBox2.Text)).ToList();


        }

        private void clientEditButton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(supplierDataGridView.CurrentRow.Cells[0].Value.ToString());
            int x = 0;
            int.TryParse(clientTextBoxPhone.Text, out x);

            if (clientNameTextBox.Text == "" || x == 0)
            {
                MessageBox.Show("أدخل بيانات أولا  ");
            }
            else if (db.Suppliers.Where(s => s.Phone == clientTextBoxPhone.Text && s.SupplierID != id).Count() > 0     )    {
                MessageBox.Show(" رقم تلفون مكرر");

            }
            else
            {
                var result = db.Suppliers.SingleOrDefault(w => w.SupplierID == id);

                result.SupplierName = clientNameTextBox.Text;

                result.Phone = clientTextBoxPhone.Text;
                result.Fax = clientTextBoxFax.Text;
                result.Mobile = clientTextBoxMobile.Text;
                result.Email = clientTextBoxEmail.Text;
                result.Website = clientTextBoxWebSite.Text;
                db.SaveChanges();
                MessageBox.Show("تم التعديل بنجاح");
            }
        }
    }
}
