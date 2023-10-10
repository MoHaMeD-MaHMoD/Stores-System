using Commercial_company_project.Reports;
using Commercial_company_project.Reports.Models;
using Commercial_company_project.Screens;
using Commercial_company_project.Screens.Clients;
using Commercial_company_project.Screens.Items;
using Commercial_company_project.Screens.Stores;
using Commercial_company_project.Screens.Suppliers;
using Commercial_company_project.Screens.Transfer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Commercial_company_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void المواردToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void إضافةToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddItem addItem = new AddItem();
            addItem.Show();

        }

        private void إغلاقToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void تعديلصنفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditItem edi = new EditItem();
            edi.Show();

        }

        private void التحكمفىالعملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientManagement client = new ClientManagement();
            client.Show();

        }

        private void التحكمفىالموردينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Suppliers sup = new Suppliers();
            sup.Show();
        }

        private void إضافةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StoresForm sto = new StoresForm();
            sto.Show();
        }

        private void تصريحToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupllyPermissionForm supPerm = new SupllyPermissionForm();
            supPerm.Show();
        }

        private void تصريحصرفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WithdrawalPermissionForm withdrPerm = new WithdrawalPermissionForm();
            withdrPerm.Show();
        }

        private void نقلالأصنافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransferForm transferForm = new TransferForm();
            transferForm.Show();
        }

        private void تقاريرالمخازنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StoredReportForm repoData = new StoredReportForm();
            repoData.Show();
        }

        private void تقاريرالأصنافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemsReportForm itemData = new ItemsReportForm();
            itemData.Show();
        }

        private void تقريرحركةاالصنافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransferItemForm transferItemForm = new TransferItemForm();
            transferItemForm.Show();
        }

        private void تقريرمدةصلاحيةالأصنافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimeINStoreReportForm timeINStoreReportForm = new TimeINStoreReportForm();
            timeINStoreReportForm.Show();
        }

        private void تقريرمدةصلاحيةالأصنافToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ExpairyDateReportForm expairyDateReportForm = new ExpairyDateReportForm();
            expairyDateReportForm.Show();
        }
    }
}
