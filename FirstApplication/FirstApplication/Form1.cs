using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstApplication
{
    public partial class GroupName : Form
    {
        List<string> groupList;

        public GroupName()
        {
            groupList = new List<string>();

            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text + " " + textBox2.Text);
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SplitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string groupName = textBox3.Text;
            if (groupName.Length != 0)
            {
                groupList.Add(groupName);
                cmbGrop.Items.Clear();
                foreach (var item in groupList)
                {
                    cmbGrop.Items.Add(item);
                }
                MessageBox.Show("Group add Succesfully");
            }
            else
            {
                label4.Text = "Qrup adini bos buraxmiyin";
                label4.Visible = true;
            }

        }
    }
}
