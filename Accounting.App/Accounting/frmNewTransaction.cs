using Accounting.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationComponents;

namespace Accounting.App
{
    public partial class frmNewTransaction : Form
    {
        private UnitOfWork db;
        public int AccountId = 0;
        public frmNewTransaction()
        {
            InitializeComponent();
        }

        private void frmNewTransaction_Load(object sender, EventArgs e)
        {
            Rectangle rectangle = Screen.PrimaryScreen.WorkingArea;
            this.Size = new Size(Convert.ToInt32(0.5 * rectangle.Width), Convert.ToInt32(0.5 * rectangle.Height));
            this.Location = new Point(10, 10);
            db = new UnitOfWork();
            dgvCustomers.AutoGenerateColumns = false;
            dgvCustomers.DataSource = db.CustomerRepository.GetNameCustomers();
            if (AccountId != 0)
            {
                var account = db.AccountingRepository.GetById(AccountId);
                txtAmount.Text = account.Amount.ToString();
                txtDescription.Text = account.Description.ToString();
                txtName.Text = db.CustomerRepository.GetCustomerNameById(account.CustomerID);
                txtId.Text = account.CustomerID.ToString();
                if (account.TypeID == 1)
                {
                    rbRecive.Checked = true;
                }
                else
                {
                    rbPay.Checked = true;
                }
                this.Text = "ویرایش";
                btnSave.Text = "ثبت ویرایش";
                db.Dispose();
            }            
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            dgvCustomers.AutoGenerateColumns = false;
            dgvCustomers.DataSource = db.CustomerRepository.GetNameCustomers(txtFilter.Text);
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dgvCustomers.CurrentRow.Cells[0].Value.ToString();
            txtId.Text = dgvCustomers.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            if (BaseValidator.IsFormValid(this.components))
            {
                if (rbPay.Checked || rbRecive.Checked)
                {
                    db = new UnitOfWork();
                    DataLayer.Accounting accounting = new DataLayer.Accounting()
                    {
                        Amount = int.Parse(txtAmount.Value.ToString()),
                        CustomerID = int.Parse(txtId.Text),
                        TypeID = (rbRecive.Checked) ? 1 : 2,
                        DateTime = DateTime.Now,
                        Description = txtDescription.Text,
                    };
                    if (AccountId == 0)
                    {
                        db.AccountingRepository.Insert(accounting);
                    }
                    else
                    {
                        accounting.ID = AccountId;
                        db.AccountingRepository.Update(accounting);

                    }
                    db.Save();
                    db.Dispose();
                    DialogResult = DialogResult.OK;
                    
                }
                else
                {
                    RtlMessageBox.Show("لطفا نوع تراکنش را انتخاب کنید");
                }
            }
        }
    }
}
