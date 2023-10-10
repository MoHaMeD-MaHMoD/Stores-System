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
    public partial class AddItem : Form
    {
        MOhamedEntities3 db = new MOhamedEntities3();

        public AddItem()
        {
            InitializeComponent();

        }

        private void SaveItemButton_Click(object sender, EventArgs e)
        {
            try
            {
                MeasruingUnit mes = new MeasruingUnit();
                Item item = new Item();

                item.ItemName = ItemTextBox.Text;

                item.ItemCode = int.Parse(BarCodeTextBox.Text);
                if (comboBox1.SelectedIndex != -1)
                {
                    var measuringUnit = db.MeasruingUnits.Find(int.Parse(comboBox1.SelectedValue.ToString()));
                    item.MeasruingUnits.Add(measuringUnit);
                }
                if (comboBox2.SelectedIndex != -1)
                {
                    var measuringUnit = db.MeasruingUnits.Find(int.Parse(comboBox2.SelectedValue.ToString()));
                    item.MeasruingUnits.Add(measuringUnit);
                }
                if (comboBox3.SelectedIndex != -1)
                {
                    var measuringUnit = db.MeasruingUnits.Find(int.Parse(comboBox2.SelectedValue.ToString()));
                    item.MeasruingUnits.Add(measuringUnit);
                }

                db.Items.Add(item);
                db.SaveChanges();
                MessageBox.Show("تم الإضافة بنجاح");


            }
            catch
            {
                MessageBox.Show("رجاء إدخال إسم المنتج والباركود  ");

            }



        }
        


        private void AddItem_Load_1(object sender, EventArgs e)
        {


            // TODO: This line of code loads data into the 'mOhamedDataSet14.MeasruingUnit' table. You can move, or remove it, as needed.
            this.measruingUnitTableAdapter7.Fill(this.mOhamedDataSet14.MeasruingUnit);
            // TODO: This line of code loads data into the 'mOhamedDataSet13.MeasruingUnit' table. You can move, or remove it, as needed.
            this.measruingUnitTableAdapter6.Fill(this.mOhamedDataSet13.MeasruingUnit);
            // TODO: This line of code loads data into the 'mOhamedDataSet12.MeasruingUnit' table. You can move, or remove it, as needed.
            this.measruingUnitTableAdapter5.Fill(this.mOhamedDataSet12.MeasruingUnit);
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;

        }
    } }

        