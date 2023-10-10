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

namespace Commercial_company_project.Screens.Clients
{
    public partial class ClientManagement : Form
    {

        MOhamedEntities3 db = new MOhamedEntities3();

        public ClientManagement()
        {
            InitializeComponent();
            clientDataGridView.DataSource = db.Customers.ToList();

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (clientNameTextBox.Text == "")
                clientDataGridView.DataSource = db.Customers.Where(x => x.Phone.Contains(clientTextBoxPhone.Text)).ToList();
            else
                clientDataGridView.DataSource = db.Customers.Where(x => x.Phone.Contains(clientTextBoxPhone.Text) || x.CustomerName.Contains(clientNameTextBox.Text)).ToList();


        }

        private void SaveItemButton_Click(object sender, EventArgs e)
        {
            if (clientNameTextBox.Text == "" || clientTextBoxPhone.Text == "" )
            {
                MessageBox.Show("برجاء إستكمال البيانات ");
            }
            else if (db.Suppliers.Where(x => x.Phone == clientTextBoxPhone.Text).Count() > 0)
            {
                MessageBox.Show("عميل مكرر أو رقم تلفون مكرر");


            }
            else
            {
                var dialogResult = MessageBox.Show("هل ترغب بإضافة عميل جديد", "", MessageBoxButtons.YesNo);
                if( dialogResult == DialogResult.Yes) {
                    Customer customer = new Customer();
                    customer.CustomerName = clientNameTextBox.Text;
                    customer.Phone = clientTextBoxPhone.Text;
                    customer.Mobile = clientTextBoxMobile.Text;
                    customer.Fax = clientTextBoxFax.Text;
                    customer.Email = clientTextBoxEmail.Text;
                    customer.Website = clientTextBoxWebSite.Text;
                    db.Customers.Add(customer);
                    db.SaveChanges();
                    clientDataGridView.DataSource = db.Customers.ToList();

                    MessageBox.Show("تم الإضافة بنجاح");
                }


                
            }
        }

        private void clientDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            clientNameTextBox.Text = clientDataGridView.CurrentRow.Cells[1].Value.ToString();
            clientTextBoxPhone.Text = clientDataGridView.CurrentRow.Cells[2].Value.ToString();
            clientTextBoxFax.Text = clientDataGridView.CurrentRow.Cells[3].Value.ToString();
            clientTextBoxMobile.Text = clientDataGridView.CurrentRow.Cells[4].Value.ToString();
            clientTextBoxEmail.Text = clientDataGridView.CurrentRow.Cells[5].Value.ToString();
            clientTextBoxWebSite.Text = clientDataGridView.CurrentRow.Cells[6].Value.ToString();


        }

        private void clientButtonDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(clientDataGridView.CurrentRow.Cells[0].Value.ToString());
            var result = db.Customers.Find(id);
            var deleteOption = MessageBox.Show("ترغب بالفعل فى حذف العميل ؟", " ", MessageBoxButtons.YesNo);
            if (deleteOption == DialogResult.Yes)
            {
                db.Customers.Remove(result);
                db.SaveChanges();
                clientDataGridView.DataSource = db.Customers.ToList();
                MessageBox.Show("تم حذف العميل بنجاح ");

            }
        }

        private void clientEditButton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(clientDataGridView.CurrentRow.Cells[0].Value.ToString());

            int x = 0;
            int.TryParse(clientTextBoxPhone.Text, out x);

            if (clientNameTextBox.Text == "" || x == 0)
            {
                MessageBox.Show("أدخل بيانات أولا  ");
            }
            else if (db.Suppliers.Where(s => s.Phone == clientTextBoxPhone.Text && s.SupplierID != id).Count() > 0)
            {
                MessageBox.Show(" رقم تلفون مكرر");
            }

            else
            {
                var result = db.Customers.SingleOrDefault(w => w.CustomerID == id);

                result.CustomerName = clientNameTextBox.Text;

                result.Phone = clientTextBoxPhone.Text;
                result.Fax = clientTextBoxFax.Text;
                result.Mobile = clientTextBoxMobile.Text;
                result.Email = clientTextBoxEmail.Text;
                result.Website = clientTextBoxWebSite.Text;
                db.SaveChanges();
                MessageBox.Show("تم التعديل بنجاح");
            }

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            clientDataGridView.DataSource = db.Customers.ToList();
        }


    }
}
