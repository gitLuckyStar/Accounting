
namespace Accounting.App
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btnCustomer = new System.Windows.Forms.ToolStripButton();
            this.btnNewAccounting = new System.Windows.Forms.ToolStripButton();
            this.btnReportPay = new System.Windows.Forms.ToolStripButton();
            this.btnReportRecive = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdateReport = new System.Windows.Forms.Button();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblPay = new System.Windows.Forms.Label();
            this.lblRecive = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.toolStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCustomer,
            this.btnNewAccounting,
            this.btnReportPay,
            this.btnReportRecive});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.MinimumSize = new System.Drawing.Size(0, 70);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(0, 3, 1, 0);
            this.toolStrip.Size = new System.Drawing.Size(1182, 70);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip2";
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.SystemColors.Control;
            this.btnCustomer.Image = global::Accounting.App.Properties.Resources.People;
            this.btnCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(64, 64);
            this.btnCustomer.Text = "اشخاص";
            this.btnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnNewAccounting
            // 
            this.btnNewAccounting.Image = global::Accounting.App.Properties.Resources.Transaction;
            this.btnNewAccounting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewAccounting.Name = "btnNewAccounting";
            this.btnNewAccounting.Size = new System.Drawing.Size(101, 64);
            this.btnNewAccounting.Text = "تراکنش جدید";
            this.btnNewAccounting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNewAccounting.Click += new System.EventHandler(this.btnNewAccounting_Click);
            // 
            // btnReportPay
            // 
            this.btnReportPay.Image = global::Accounting.App.Properties.Resources._out;
            this.btnReportPay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReportPay.Name = "btnReportPay";
            this.btnReportPay.Size = new System.Drawing.Size(132, 64);
            this.btnReportPay.Text = "گزارش پرداختی ها";
            this.btnReportPay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReportPay.Click += new System.EventHandler(this.btnReportPay_Click);
            // 
            // btnReportRecive
            // 
            this.btnReportRecive.Image = global::Accounting.App.Properties.Resources.In;
            this.btnReportRecive.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReportRecive.Name = "btnReportRecive";
            this.btnReportRecive.Size = new System.Drawing.Size(127, 64);
            this.btnReportRecive.Text = "گزارش دریافتی ها";
            this.btnReportRecive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReportRecive.Click += new System.EventHandler(this.btnReportRecive_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDate,
            this.lblTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 642);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1182, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblDate
            // 
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 20);
            this.lblDate.Text = "Date";
            // 
            // lblTime
            // 
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(42, 20);
            this.lblTime.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdateReport);
            this.groupBox1.Controls.Add(this.lblBalance);
            this.groupBox1.Controls.Add(this.lblPay);
            this.groupBox1.Controls.Add(this.lblRecive);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(0, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 572);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "گزارش این ماه";
            // 
            // btnUpdateReport
            // 
            this.btnUpdateReport.Image = global::Accounting.App.Properties.Resources._1371476394_refresh_red;
            this.btnUpdateReport.Location = new System.Drawing.Point(6, 25);
            this.btnUpdateReport.Name = "btnUpdateReport";
            this.btnUpdateReport.Size = new System.Drawing.Size(37, 36);
            this.btnUpdateReport.TabIndex = 6;
            this.btnUpdateReport.UseVisualStyleBackColor = true;
            this.btnUpdateReport.Click += new System.EventHandler(this.btnUpdateReport_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.Location = new System.Drawing.Point(12, 124);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(176, 26);
            this.lblBalance.TabIndex = 5;
            this.lblBalance.Text = "0";
            // 
            // lblPay
            // 
            this.lblPay.Location = new System.Drawing.Point(12, 98);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(176, 26);
            this.lblPay.TabIndex = 4;
            this.lblPay.Text = "0";
            // 
            // lblRecive
            // 
            this.lblRecive.Location = new System.Drawing.Point(12, 72);
            this.lblRecive.Name = "lblRecive";
            this.lblRecive.Size = new System.Drawing.Size(176, 26);
            this.lblRecive.TabIndex = 3;
            this.lblRecive.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "مانده :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "پرداختی ها :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "دریافتی ها :";
            // 
            // panel
            // 
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(290, 70);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(892, 572);
            this.panel.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1182, 668);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip);
            this.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " حسابداری";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton btnCustomer;
        private System.Windows.Forms.ToolStripButton btnNewAccounting;
        private System.Windows.Forms.ToolStripButton btnReportPay;
        private System.Windows.Forms.ToolStripButton btnReportRecive;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblDate;
        private System.Windows.Forms.ToolStripStatusLabel lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblPay;
        private System.Windows.Forms.Label lblRecive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdateReport;
        private System.Windows.Forms.Panel panel;
    }
}

