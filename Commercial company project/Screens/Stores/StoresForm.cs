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

namespace Commercial_company_project.Screens.Stores
{
    public partial class StoresForm : Form
    {
        MOhamedEntities3 db = new MOhamedEntities3();

        public StoresForm()
        {
            InitializeComponent();
            storeDataGridView.DataSource = db.Stores.ToList();

        }

        private void StoresForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'progDBDataSet1.Stores' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'progDBDataSet.ResponsiblePerson' table. You can move, or remove it, as needed.

        }

        private void storeButtonDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(storeDataGridView.CurrentRow.Cells[0].Value.ToString());
            var result = db.Stores.Find(id);
            var deleteOption = MessageBox.Show("ترغب بالفعل فى حذف المخزن ؟", " ", MessageBoxButtons.YesNo);
            if (deleteOption == DialogResult.Yes)
            {
                db.Stores.Remove(result);
                db.SaveChanges();
                storeDataGridView.DataSource = db.Stores.ToList();
                MessageBox.Show("تم حذف المخزن بنجاح ");

            }
        }

        private void storeEditButton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(storeDataGridView.CurrentRow.Cells[0].Value.ToString());
          

            if (storeNameTextBox.Text == "" || storeAddressTextBox.Text=="")
            {
                MessageBox.Show("أدخل بيانات أولا  ");
            }
        
            else
            {
                var result = db.Stores.SingleOrDefault(w => w.StoreID == id);

                result.StoreName = storeNameTextBox.Text;

                result.StoreAddress = storeAddressTextBox.Text;
                result.Responsible =(int) storecomboBox.SelectedValue;
                db.SaveChanges();
                MessageBox.Show("تم التعديل بنجاح");
            }
        }

        private void storeSaveButton_Click(object sender, EventArgs e)
        {
            if (storeNameTextBox.Text == "" || storeAddressTextBox.Text == "" || storecomboBox.SelectedValue == null)
            {
                MessageBox.Show("برجاء إستكمال البيانات ");
            }

            else
            {
                var dialogResult = MessageBox.Show("هل ترغب بإضافة مخزن جديد", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Store st  = new Store();
                    st.Responsible = int.Parse(storecomboBox.SelectedValue.ToString());
                    st.StoreName = storeNameTextBox.Text;
                    st.StoreAddress = storeAddressTextBox.Text;

                    db.Stores.Add(st);
                    db.SaveChanges();
                    storeDataGridView.DataSource = db.Stores.ToList();

                    MessageBox.Show("تم الإضافة بنجاح");
                }



            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            storeDataGridView.DataSource = db.Stores.ToList();

        }

        private void storeDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // responsible
            int iddd = int.Parse( storeDataGridView.CurrentRow.Cells[3].Value.ToString());
            var respon = db.ResponsiblePersons.Find(iddd);
            storecomboBox.Text = respon.PersonName;
            //Store NAme
            storeNameTextBox.Text = storeDataGridView.CurrentRow.Cells[1].Value.ToString();
            //Store Address
            storeAddressTextBox.Text = storeDataGridView.CurrentRow.Cells[2].Value.ToString();

        }

        private void StoresForm_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mOhamedDataSet6.ResponsiblePerson' table. You can move, or remove it, as needed.
            this.responsiblePersonTableAdapter.Fill(this.mOhamedDataSet6.ResponsiblePerson);
            storecomboBox.DataSource = db.ResponsiblePersons.ToList();
            storecomboBox.DisplayMember = "PersonName";
            storecomboBox.ValueMember = "PersonID";

        }
    }
    }

