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

namespace Commercial_company_project.Screens.Items
{
    public partial class EditItem : Form
    {
        MOhamedEntities3 db = new MOhamedEntities3();

        public EditItem()
        {
            InitializeComponent();
            populate();
        }
        private void populate()
        {
            itemDataGridView.DataSource = db.Items.ToList();
        }



        private void gunaButton1_Click(object sender, EventArgs e)
        {
            itemDataGridView.DataSource = db.Items.ToList();

        }

        private void SearchItemButton_Click(object sender, EventArgs e)
        {
            itemDataGridView.DataSource = db.Items.Where(x => x.ItemCode == int.Parse(BarCodeTextBox.Text) || x.ItemName == NameTextBox1.Text).ToList();

        }

        private void itemDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            BarCodeTextBox.Text = itemDataGridView.CurrentRow.Cells[1].Value.ToString();
            NameTextBox1.Text = itemDataGridView.CurrentRow.Cells[2].Value.ToString();


        }


        private void EditItemButton_Click(object sender, EventArgs e)
        {
            int x = 0;
            int.TryParse(BarCodeTextBox.Text, out x);

            if (NameTextBox1.Text == "" || BarCodeTextBox.Text == "" || ItemcheckedListBox.CheckedItems.Count == 0 || x == 0)
            {
                MessageBox.Show("رجاء إدخال إسم المنتج والباركود ووحدة القياس ");
            }
            else
            {
                int id = int.Parse(itemDataGridView.CurrentRow.Cells[0].Value.ToString());
            var result  =  db.Items.SingleOrDefault(w => w.ItemID == id);

                result.ItemName = NameTextBox1.Text;

                result.ItemCode = int.Parse(BarCodeTextBox.Text);

       /*         int c = ItemcheckedListBox.CheckedItems.Count;

                result.MeasurementUnit1 = ItemcheckedListBox.CheckedItems[0].ToString() + "\n";

                if (c > 1)
                    result.MeasurementUnit2 = ItemcheckedListBox.CheckedItems[1].ToString() + "\n";
                if (c > 2)
                    result.MeasurementUnit3 = ItemcheckedListBox.CheckedItems[2].ToString() + "\n";*/

                db.SaveChanges();
                MessageBox.Show("تم التعديل بنجاح");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(itemDataGridView.CurrentRow.Cells[0].Value.ToString());
            var result = db.Items.Find(id);
            var deleteOption = MessageBox.Show("ترغب بالفعل فى الحذف ؟", " ", MessageBoxButtons.YesNo);
            if (deleteOption == DialogResult.Yes)
            {
                db.Items.Remove(result);
                db.SaveChanges();
                populate();
                MessageBox.Show("تم حذف الصنف ");

            }




        }

    }
}
