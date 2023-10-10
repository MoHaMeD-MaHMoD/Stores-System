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
    public partial class ExpairyDateReportForm : Form
    {
        MOhamedEntities3 db = new MOhamedEntities3();

        public ExpairyDateReportForm()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {

            gridviewwww.Rows.Clear();

            try
            {

                int day = int.Parse(daytext.Text.ToString());
                int mounth = int.Parse(mounthtext.Text.ToString()) * 30;
                int yearsss = int.Parse(yearss.Text.ToString()) * 365;
                int TotalTime = day + mounth + yearsss;



                var resultss = db.GetExpairyDate(TotalTime).ToList();


                foreach (var item in resultss)
                {

                    gridviewwww.Rows.Add( item.ItemName, item.StoreName,item.Quantity, item.UnitName, item.ExpiryDate.Value.ToShortDateString(), item.RemainingDays);

                }

            }
            catch
            {
                MessageBox.Show("أدخل مدة زمنية صحيحة ");

            }



        }
    }
}
