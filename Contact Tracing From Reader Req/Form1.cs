using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
namespace Contact_Tracing_From_Reader_Req
{
    public partial class cntcttrcfrmReader : Form
    {
        public cntcttrcfrmReader()
        {
            InitializeComponent();
        }
       
        private void cmbbxNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            StreamReader inptFile = File.OpenText(ofd1.FileName);
            while (inptFile.EndOfStream == false)
            {
                if (inptFile.ReadLine() == cmbbxNames.SelectedItem.ToString())
                {
                    grpbxPersonal.Visible = grpbxContact.Visible = grpbxDate.Visible = true;
                    txtbxName.Text = cmbbxNames.SelectedItem.ToString();
                    txtbxAge.Text = inptFile.ReadLine();
                    txtbxSex.Text = inptFile.ReadLine();
                    txtbxTemp.Text = inptFile.ReadLine();
                    txtbxEmail.Text = inptFile.ReadLine();
                    txtbxPhone.Text = inptFile.ReadLine();
                    txtbxAddress.Text = inptFile.ReadLine();
                    txtbxDate.Text = inptFile.ReadLine();
                    txtbxTimeI.Text = inptFile.ReadLine();
                    txtbxTimeO.Text = inptFile.ReadLine();
                }
                else if (cmbbxNames.SelectedItem.ToString() == "Name/s")
                {
                    grpbxPersonal.Visible = grpbxContact.Visible = grpbxDate.Visible = false;
                }
            }
            inptFile.Close();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                lblNames.Visible = cmbbxNames.Visible = true;
                cmbbxNames.Items.Clear();
                txtbxName.Text = txtbxAge.Text = txtbxSex.Text = txtbxTemp.Text = txtbxEmail.Text = txtbxPhone.Text = txtbxAddress.Text = txtbxDate.Text = txtbxTimeI.Text = txtbxTimeO.Text = "";
                StreamReader inptFile = File.OpenText(ofd1.FileName);
                while (inptFile.EndOfStream == false)
                {
                    if (inptFile.ReadLine() == "=====")
                    {
                        cmbbxNames.Items.Add(inptFile.ReadLine());
                    }
                }
            }
        }
    }
}
