
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
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.btnOpen = new System.Windows.Forms.Button();
            this.cmbbxNames = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ofd1
            // 
            this.ofd1.FileName = "flData";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(341, 32);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(94, 29);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open File";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbbxNames
            // 
            this.cmbbxNames.FormattingEnabled = true;
            this.cmbbxNames.Location = new System.Drawing.Point(274, 67);
            this.cmbbxNames.Name = "cmbbxNames";
            this.cmbbxNames.Size = new System.Drawing.Size(236, 28);
            this.cmbbxNames.TabIndex = 1;
            // 
            // cntcttrcfrmReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbbxNames);
            this.Controls.Add(this.btnOpen);
            this.Name = "cntcttrcfrmReader";
            this.Text = "Contact Tracing Data";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofd1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ComboBox cmbbxNames;
    }
}

