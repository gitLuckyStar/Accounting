using Accounting.DataLayer;
using Accounting.DataLayer.Context;
using Accounting.utility.Convertor;
using Accounting.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting.App
{
    public partial class frmReport : Form
    {
        public int TypeId;
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                List<ListCustomerViewModel> list = new List<ListCustomerViewModel>();
                list.Add(new ListCustomerViewModel()
                {
                    CustomerID = 0,
                    FullName = "همه",
                });
                list.AddRange(db.CustomerRepository.GetNameCustomers());
                cbCustomer.DataSource = list;
                cbCustomer.DisplayMember = "FullName";
                cbCustomer.ValueMember = "CustomerID";
            }
            if (TypeId == 1)
            {
                this.Text = "گزارش دریافتی ها";
            }
            else
            {
                this.Text = "گزارش پرداختی ها";
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            Filter();
        }

        void Filter()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                List<DataLayer.Accounting> result = new List<DataLayer.Accounting>();
                DateTime? StartDate;
                DateTime? EndDate;
                if ((int)cbCustomer.SelectedValue != 0)
                {
                    int customerId = int.Parse(cbCustomer.SelectedValue.ToString());
                    result.AddRange(db.AccountingRepository.Get(a => a.TypeID == TypeId && a.CustomerID == customerId));
                }
                else
                {
                    result.AddRange(db.AccountingRepository.Get(a => a.TypeID == TypeId));
                }
                if (txtFromDate.Text != "    /  /")
                {
                    StartDate = Convert.ToDateTime(txtFromDate.Text);
                    if (System.Globalization.CultureInfo.CurrentCulture.Calendar.ToString() != "System.Globalization.PersianCalendar")
                    {
                        StartDate = DateConvertor.ToMiladi(StartDate.Value);
                    }
                    result = result.Where(d => d.DateTime >= StartDate.Value).ToList();
                }
                if (txtToDate.Text != "    /  /")
                {
                    EndDate = Convert.ToDateTime(txtToDate.Text);
                    if (System.Globalization.CultureInfo.CurrentCulture.Calendar.ToString() != "System.Globalization.PersianCalendar")
                    {
                        EndDate = DateConvertor.ToMiladi(EndDate.Value);
                    }
                    result = result.Where(d => d.DateTime <= EndDate.Value).ToList();
                }

                dgReport.Rows.Clear();
                foreach (var accounting in result)
                {
                    string customerName = db.CustomerRepository.GetCustomerNameById(accounting.CustomerID);
                    dgReport.Rows.Add(accounting.ID, customerName, accounting.Amount, accounting.DateTime.ToShamsi(), accounting.Description);
                }
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgReport.CurrentRow != null)
            {
                int Id = int.Parse(dgReport.CurrentRow.Cells[0].Value.ToString());
                if (RtlMessageBox.Show("آیا از حذف مطمئن هستید؟", "هشدار", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        db.AccountingRepository.Delete(Id);
                        db.Save();
                        Filter();
                    }

                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgReport.CurrentRow != null)
            {
                int Id = int.Parse(dgReport.CurrentRow.Cells[0].Value.ToString());
                frmNewTransaction frmNewTransaction = new frmNewTransaction();
                frmNewTransaction.FormBorderStyle = FormBorderStyle.FixedToolWindow;               
                frmNewTransaction.AccountId = Id;
                if (frmNewTransaction.ShowDialog() == DialogResult.OK)
                {
                    Filter();
                }
            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataTable dtPrint = new DataTable();
            dtPrint.Columns.Add("Customer");
            dtPrint.Columns.Add("Amount");
            dtPrint.Columns.Add("Date");
            dtPrint.Columns.Add("Description");
            foreach (DataGridViewRow item in dgReport.Rows)
            {
                dtPrint.Rows.Add(
                    item.Cells[0].Value.ToString(),
                    item.Cells[1].Value.ToString(),
                    item.Cells[2].Value.ToString(),
                    item.Cells[3].Value.ToString()
                    );
            }
            if (TypeId == 1)
            {
                stiPrint.Load(Path.GetFileName(Application.StartupPath + "/ReportRecive.mrt"));
            }
            else
            {
                stiPrint.Load(Path.GetFileName(Application.StartupPath + "/ReportPay.mrt"));
            }
            stiPrint.RegData("DT", dtPrint);
            stiPrint.Show();

        }
    }
}
