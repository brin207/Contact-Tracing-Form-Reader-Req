
namespace Contact_Tracing_From_Reader_Req
{
    partial class cntcttrcfrmReader
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cntcttrcfrmReader));
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.btnOpen = new System.Windows.Forms.Button();
            this.cmbbxNames = new System.Windows.Forms.ComboBox();
            this.grpbxPersonal = new System.Windows.Forms.GroupBox();
            this.lblTempd = new System.Windows.Forms.Label();
            this.lblNamed = new System.Windows.Forms.Label();
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtbxAge = new System.Windows.Forms.TextBox();
            this.txtbxTemp = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.txtbxSex = new System.Windows.Forms.TextBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.grpbxContact = new System.Windows.Forms.GroupBox();
            this.lblResidd = new System.Windows.Forms.Label();
            this.txtbxEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxPhone = new System.Windows.Forms.TextBox();
            this.txtbxAddress = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblResidence = new System.Windows.Forms.Label();
            this.grpbxDate = new System.Windows.Forms.GroupBox();
            this.txtbxDate = new System.Windows.Forms.TextBox();
            this.txtbxTimeO = new System.Windows.Forms.TextBox();
            this.txtbxTimeI = new System.Windows.Forms.TextBox();
            this.lblTimeO = new System.Windows.Forms.Label();
            this.lblTimeI = new System.Windows.Forms.Label();
            this.lblNames = new System.Windows.Forms.Label();
            this.grpbxPersonal.SuspendLayout();
            this.grpbxContact.SuspendLayout();
            this.grpbxDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofd1
            // 
            this.ofd1.FileName = "flData";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(365, 35);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(94, 29);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open File";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbbxNames
            // 
            this.cmbbxNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbxNames.FormattingEnabled = true;
            this.cmbbxNames.Location = new System.Drawing.Point(301, 70);
            this.cmbbxNames.MaxDropDownItems = 100;
            this.cmbbxNames.Name = "cmbbxNames";
            this.cmbbxNames.Size = new System.Drawing.Size(236, 28);
            this.cmbbxNames.TabIndex = 1;
            this.cmbbxNames.Visible = false;
            this.cmbbxNames.SelectedIndexChanged += new System.EventHandler(this.cmbbxNames_SelectedIndexChanged);
            // 
            // grpbxPersonal
            // 
            this.grpbxPersonal.Controls.Add(this.lblTempd);
            this.grpbxPersonal.Controls.Add(this.lblNamed);
            this.grpbxPersonal.Controls.Add(this.txtbxName);
            this.grpbxPersonal.Controls.Add(this.lblName);
            this.grpbxPersonal.Controls.Add(this.txtbxAge);
            this.grpbxPersonal.Controls.Add(this.txtbxTemp);
            this.grpbxPersonal.Controls.Add(this.lblAge);
            this.grpbxPersonal.Controls.Add(this.lblTemp);
            this.grpbxPersonal.Controls.Add(this.txtbxSex);
            this.grpbxPersonal.Controls.Add(this.lblSex);
            this.grpbxPersonal.Location = new System.Drawing.Point(34, 109);
            this.grpbxPersonal.Name = "grpbxPersonal";
            this.grpbxPersonal.Size = new System.Drawing.Size(371, 210);
            this.grpbxPersonal.TabIndex = 24;
            this.grpbxPersonal.TabStop = false;
            this.grpbxPersonal.Text = "Personal Info.";
            this.grpbxPersonal.Visible = false;
            // 
            // lblTempd
            // 
            this.lblTempd.AutoSize = true;
            this.lblTempd.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblTempd.Location = new System.Drawing.Point(288, 135);
            this.lblTempd.Name = "lblTempd";
            this.lblTempd.Size = new System.Drawing.Size(41, 15);
            this.lblTempd.TabIndex = 18;
            this.lblTempd.Text = "(in °C)";
            // 
            // lblNamed
            // 
            this.lblNamed.AutoSize = true;
            this.lblNamed.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblNamed.Location = new System.Drawing.Point(97, 74);
            this.lblNamed.Name = "lblNamed";
            this.lblNamed.Size = new System.Drawing.Size(157, 15);
            this.lblNamed.TabIndex = 17;
            this.lblNamed.Text = "(Last Name, First Name M.I.)";
            // 
            // txtbxName
            // 
            this.txtbxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbxName.Location = new System.Drawing.Point(97, 46);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.ReadOnly = true;
            this.txtbxName.Size = new System.Drawing.Size(246, 20);
            this.txtbxName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 46);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name\r\n";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtbxAge
            // 
            this.txtbxAge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbxAge.Location = new System.Drawing.Point(97, 105);
            this.txtbxAge.Name = "txtbxAge";
            this.txtbxAge.ReadOnly = true;
            this.txtbxAge.Size = new System.Drawing.Size(66, 20);
            this.txtbxAge.TabIndex = 3;
            this.txtbxAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbxTemp
            // 
            this.txtbxTemp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbxTemp.Location = new System.Drawing.Point(276, 105);
            this.txtbxTemp.Name = "txtbxTemp";
            this.txtbxTemp.ReadOnly = true;
            this.txtbxTemp.Size = new System.Drawing.Size(67, 20);
            this.txtbxTemp.TabIndex = 16;
            this.txtbxTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(30, 105);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(36, 20);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Age";
            this.lblAge.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(177, 109);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(93, 20);
            this.lblTemp.TabIndex = 15;
            this.lblTemp.Text = "Temperature";
            this.lblTemp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtbxSex
            // 
            this.txtbxSex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbxSex.Location = new System.Drawing.Point(97, 155);
            this.txtbxSex.Name = "txtbxSex";
            this.txtbxSex.ReadOnly = true;
            this.txtbxSex.Size = new System.Drawing.Size(144, 20);
            this.txtbxSex.TabIndex = 13;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(30, 155);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(32, 20);
            this.lblSex.TabIndex = 14;
            this.lblSex.Text = "Sex";
            this.lblSex.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grpbxContact
            // 
            this.grpbxContact.Controls.Add(this.lblResidd);
            this.grpbxContact.Controls.Add(this.txtbxEmail);
            this.grpbxContact.Controls.Add(this.label1);
            this.grpbxContact.Controls.Add(this.txtbxPhone);
            this.grpbxContact.Controls.Add(this.txtbxAddress);
            this.grpbxContact.Controls.Add(this.lblPhone);
            this.grpbxContact.Controls.Add(this.lblResidence);
            this.grpbxContact.Location = new System.Drawing.Point(423, 109);
            this.grpbxContact.Name = "grpbxContact";
            this.grpbxContact.Size = new System.Drawing.Size(365, 333);
            this.grpbxContact.TabIndex = 25;
            this.grpbxContact.TabStop = false;
            this.grpbxContact.Text = "Contact Info.";
            this.grpbxContact.Visible = false;
            // 
            // lblResidd
            // 
            this.lblResidd.AutoSize = true;
            this.lblResidd.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblResidd.Location = new System.Drawing.Point(33, 175);
            this.lblResidd.Name = "lblResidd";
            this.lblResidd.Size = new System.Drawing.Size(81, 75);
            this.lblResidd.TabIndex = 18;
            this.lblResidd.Text = "(Bldg, Street,\r\nBarangay, \r\nCity, Province,\r\nRegion, \r\nPostal Code)";
            // 
            // txtbxEmail
            // 
            this.txtbxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbxEmail.Location = new System.Drawing.Point(136, 46);
            this.txtbxEmail.Name = "txtbxEmail";
            this.txtbxEmail.ReadOnly = true;
            this.txtbxEmail.Size = new System.Drawing.Size(188, 20);
            this.txtbxEmail.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "E-mail \r\nAddress";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtbxPhone
            // 
            this.txtbxPhone.BackColor = System.Drawing.SystemColors.Window;
            this.txtbxPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbxPhone.Location = new System.Drawing.Point(136, 103);
            this.txtbxPhone.Name = "txtbxPhone";
            this.txtbxPhone.ReadOnly = true;
            this.txtbxPhone.Size = new System.Drawing.Size(188, 20);
            this.txtbxPhone.TabIndex = 7;
            // 
            // txtbxAddress
            // 
            this.txtbxAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbxAddress.Location = new System.Drawing.Point(138, 155);
            this.txtbxAddress.Multiline = true;
            this.txtbxAddress.Name = "txtbxAddress";
            this.txtbxAddress.ReadOnly = true;
            this.txtbxAddress.Size = new System.Drawing.Size(186, 156);
            this.txtbxAddress.TabIndex = 9;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(25, 97);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(63, 40);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Phone\r\nNumber";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblResidence
            // 
            this.lblResidence.AutoSize = true;
            this.lblResidence.Location = new System.Drawing.Point(25, 155);
            this.lblResidence.Name = "lblResidence";
            this.lblResidence.Size = new System.Drawing.Size(76, 20);
            this.lblResidence.TabIndex = 8;
            this.lblResidence.Text = "Residence";
            this.lblResidence.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grpbxDate
            // 
            this.grpbxDate.Controls.Add(this.txtbxDate);
            this.grpbxDate.Controls.Add(this.txtbxTimeO);
            this.grpbxDate.Controls.Add(this.txtbxTimeI);
            this.grpbxDate.Controls.Add(this.lblTimeO);
            this.grpbxDate.Controls.Add(this.lblTimeI);
            this.grpbxDate.Location = new System.Drawing.Point(34, 325);
            this.grpbxDate.Name = "grpbxDate";
            this.grpbxDate.Size = new System.Drawing.Size(371, 160);
            this.grpbxDate.TabIndex = 22;
            this.grpbxDate.TabStop = false;
            this.grpbxDate.Text = "Date";
            this.grpbxDate.Visible = false;
            // 
            // txtbxDate
            // 
            this.txtbxDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbxDate.Location = new System.Drawing.Point(30, 26);
            this.txtbxDate.Name = "txtbxDate";
            this.txtbxDate.ReadOnly = true;
            this.txtbxDate.Size = new System.Drawing.Size(169, 20);
            this.txtbxDate.TabIndex = 21;
            // 
            // txtbxTimeO
            // 
            this.txtbxTimeO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbxTimeO.Location = new System.Drawing.Point(126, 108);
            this.txtbxTimeO.Name = "txtbxTimeO";
            this.txtbxTimeO.ReadOnly = true;
            this.txtbxTimeO.Size = new System.Drawing.Size(217, 20);
            this.txtbxTimeO.TabIndex = 20;
            // 
            // txtbxTimeI
            // 
            this.txtbxTimeI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbxTimeI.Location = new System.Drawing.Point(126, 75);
            this.txtbxTimeI.Name = "txtbxTimeI";
            this.txtbxTimeI.ReadOnly = true;
            this.txtbxTimeI.Size = new System.Drawing.Size(217, 20);
            this.txtbxTimeI.TabIndex = 19;
            // 
            // lblTimeO
            // 
            this.lblTimeO.AutoSize = true;
            this.lblTimeO.Location = new System.Drawing.Point(21, 108);
            this.lblTimeO.Name = "lblTimeO";
            this.lblTimeO.Size = new System.Drawing.Size(70, 20);
            this.lblTimeO.TabIndex = 18;
            this.lblTimeO.Text = "Time Out";
            this.lblTimeO.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTimeI
            // 
            this.lblTimeI.AutoSize = true;
            this.lblTimeI.Location = new System.Drawing.Point(21, 75);
            this.lblTimeI.Name = "lblTimeI";
            this.lblTimeI.Size = new System.Drawing.Size(58, 20);
            this.lblTimeI.TabIndex = 17;
            this.lblTimeI.Text = "Time In";
            this.lblTimeI.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNames
            // 
            this.lblNames.AutoSize = true;
            this.lblNames.Location = new System.Drawing.Point(231, 73);
            this.lblNames.Name = "lblNames";
            this.lblNames.Size = new System.Drawing.Size(64, 20);
            this.lblNames.TabIndex = 26;
            this.lblNames.Text = "Name/s:";
            this.lblNames.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblNames.Visible = false;
            // 
            // cntcttrcfrmReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 525);
            this.Controls.Add(this.lblNames);
            this.Controls.Add(this.grpbxDate);
            this.Controls.Add(this.grpbxContact);
            this.Controls.Add(this.grpbxPersonal);
            this.Controls.Add(this.cmbbxNames);
            this.Controls.Add(this.btnOpen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cntcttrcfrmReader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Tracing Data Reader";
            this.grpbxPersonal.ResumeLayout(false);
            this.grpbxPersonal.PerformLayout();
            this.grpbxContact.ResumeLayout(false);
            this.grpbxContact.PerformLayout();
            this.grpbxDate.ResumeLayout(false);
            this.grpbxDate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofd1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ComboBox cmbbxNames;
        private System.Windows.Forms.GroupBox grpbxPersonal;
        private System.Windows.Forms.Label lblTempd;
        private System.Windows.Forms.Label lblNamed;
        private System.Windows.Forms.TextBox txtbxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtbxAge;
        private System.Windows.Forms.TextBox txtbxTemp;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.TextBox txtbxSex;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.GroupBox grpbxContact;
        private System.Windows.Forms.Label lblResidd;
        private System.Windows.Forms.TextBox txtbxEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbxPhone;
        private System.Windows.Forms.TextBox txtbxAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblResidence;
        private System.Windows.Forms.GroupBox grpbxDate;
        private System.Windows.Forms.TextBox txtbxTimeO;
        private System.Windows.Forms.TextBox txtbxTimeI;
        private System.Windows.Forms.Label lblTimeO;
        private System.Windows.Forms.Label lblTimeI;
        private System.Windows.Forms.TextBox txtbxDate;
        private System.Windows.Forms.Label lblNames;
    }
}

