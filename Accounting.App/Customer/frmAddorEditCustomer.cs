using Accounting.DataLayer;
using Accounting.DataLayer.Context;
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
using ValidationComponents;

namespace Accounting.App
{
    public partial class frmAddorEditCustomer : Form
    {
        public int customerId = 0;
        UnitOfWork db = new UnitOfWork();
        public frmAddorEditCustomer()
        {
            InitializeComponent();
        }

        private void frmAddorEditCustomer_Load(object sender, EventArgs e)
        {
            if (customerId != 0)
            {
                this.Text = "ویرایش شخص";
                btnSave.Text = "ثبت ویرایش";
                var customer = db.CustomerRepository.GetCustomerbyId(customerId);
                txtEmail.Text = customer.Email;
                txtAddress.Text = customer.Address;
                txtName.Text = customer.FullName;
                txtMobile.Text = customer.Mobile;
                if (customer.CustomerImage != null)
                {
                    pcCustomer.ImageLocation = Application.StartupPath + "/Images/" + customer.CustomerImage;
                }

            }
        }

        private void btnSelectPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pcCustomer.ImageLocation = openFile.FileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                if (pcCustomer.ImageLocation != null)
                {
                    string imageName = Guid.NewGuid().ToString() + Path.GetExtension(pcCustomer.ImageLocation);
                    string path = Application.StartupPath + "/Images/";
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    pcCustomer.Image.Save(path + imageName);
                    
                    if (customerId != 0)
                    {
                        var customerImage = db.CustomerRepository.GetCustomerImageById(customerId);
                        if (customerImage != null)
                        {
                            System.IO.File.Delete(path + customerImage);
                        }
                    }
                    Customers customer = new Customers()
                    {
                        Address = txtAddress.Text,
                        Email = txtEmail.Text,
                        FullName = txtName.Text,
                        Mobile = txtMobile.Text,
                        CustomerImage = imageName,
                    };
                    if (customerId == 0)
                    {
                        db.CustomerRepository.InsertCustomer(customer);
                    }
                    else
                    {
                        customer.CustomerID = customerId;
                        db.CustomerRepository.UpdateCustomer(customer);
                    }
                    db.Save();
                }
                else
                {
                    Customers customer = new Customers()
                    {
                        Address = txtAddress.Text,
                        Email = txtEmail.Text,
                        FullName = txtName.Text,
                        Mobile = txtMobile.Text,
                        CustomerImage = null,
                    };
                    if (customerId == 0)
                    {
                        db.CustomerRepository.InsertCustomer(customer);
                    }
                    else
                    {
                        customer.CustomerID = customerId;
                        db.CustomerRepository.UpdateCustomer(customer);
                    }
                    db.Save();
                }
                DialogResult = DialogResult.OK;
            }
        }
    }
}
