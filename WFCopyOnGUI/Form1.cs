using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFCopyOnGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
            
            string tempText = endPointLbl.Text;

            endPointLbl.Text = sourceLbl.Text;

            sourceLbl.Text = tempText;

            //Copy from ComboBox

            sourceLbl.Text = comboBox1.SelectedItem.ToString();

            //Copy from End Point to List box


            listBox1.Items.Add(endPointLbl.Text);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
