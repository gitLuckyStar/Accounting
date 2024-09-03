using Accounting.Business;
using Accounting.utility.Convertor;
using Accounting.ViewModels.Accounting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            Report();
            lblDate.Text = DateTime.Now.ToShamsi();
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            FrmCustomers frmCustomers = new FrmCustomers();
            frmCustomers.Dock = DockStyle.Fill;
            frmCustomers.TopLevel = false;
            panel.Controls.Clear();
            panel.Controls.Add(frmCustomers);
            frmCustomers.Show();
        }

        private void btnNewAccounting_Click(object sender, EventArgs e)
        {
            frmNewTransaction frmNewTransaction = new frmNewTransaction();
            frmNewTransaction.Dock = DockStyle.Fill;
            frmNewTransaction.TopLevel = false;
            panel.Controls.Clear();
            panel.Controls.Add(frmNewTransaction);
            frmNewTransaction.Show();
        }

        private void btnReportPay_Click(object sender, EventArgs e)
        {
            frmReport frmReport = new frmReport();
            frmReport.TypeId = 2;
            frmReport.Dock = DockStyle.Fill;
            frmReport.TopLevel = false;
            panel.Controls.Clear();
            panel.Controls.Add(frmReport);
            frmReport.Show();
        }

        private void btnReportRecive_Click(object sender, EventArgs e)
        {
            frmReport frmReport = new frmReport();
            frmReport.TypeId = 1;
            frmReport.Dock = DockStyle.Fill;
            frmReport.TopLevel = false;
            panel.Controls.Clear();
            panel.Controls.Add(frmReport);
            frmReport.Show();
        }        

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        void Report()
        {
            ReportViewModel report = Account.ReportFormMain();
            lblPay.Text = report.Pay.ToString("n0");
            lblRecive.Text = report.Recive.ToString("n0");
            lblBalance.Text = report.AccountBalance.ToString("n0");
        }

        private void btnUpdateReport_Click(object sender, EventArgs e)
        {
            Report();
        }
    }
}
