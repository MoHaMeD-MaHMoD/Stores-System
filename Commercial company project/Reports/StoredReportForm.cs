using Commercial_company_project.DB;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Commercial_company_project.Reports.Models
{
    public partial class StoredReportForm : Form
    {
        MOhamedEntities3 db = new MOhamedEntities3();

        private void populate()
        {
            
        }
        public StoredReportForm()
        {
            InitializeComponent();
        }

        private void StoredReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storesIDNAME.Stores' table. You can move, or remove it, as needed.
            this.storesTableAdapter.Fill(this.storesIDNAME.Stores);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            populate();

        }

        private void storeReportEditButton_Click(object sender, EventArgs e)
        {

            gunaLabel4.Text = DateTime.Now.ToShortDateString().ToString();


            reportStoredDataGridView.Rows.Clear();
                int iddd = int.Parse(comboBox2.SelectedValue.ToString());
                var resName = db.ResponsiblePersons.Find(iddd);
                var stres = db.Stores.Find(iddd);

            gunaLabel5.Text = stres.StoreName.ToString();

            gunaLabel10.Text = resName.PersonName.ToString();
            gunaLabel8.Text = stres.StoreAddress.ToString();


            DateTime fromDate = Convert.ToDateTime(FromTimePicker1.Text);
                DateTime toDate = Convert.ToDateTime(ToTimePicker.Value);
            // MessageBox.Show(iddd + "  "  + fromDate + "  "+ toDate);
       
                var result = db.StoreItemIn(iddd, fromDate, toDate).ToList();

                foreach (var item in result)
            {
                    reportStoredDataGridView.Rows.Add(item.ItemName, item.SupplierName, item.Quantity, item.UnitName, item.Price);

            }


           





        }


    }
    
}
