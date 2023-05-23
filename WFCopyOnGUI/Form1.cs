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

        //seting index of list box and combo box to 0
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            listBox1.SelectedIndex = 0;

        }

        

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            string tempText = endPointLbl.Text;

            endPointLbl.Text = sourceLbl.Text;

            sourceLbl.Text = tempText;

            //Copy from ComboBox

            sourceLbl.Text = comboBox1.SelectedItem.ToString();

            //Copy from End Point to List box


            listBox1.Items.Add(endPointLbl.Text);
            
            
            
        }

        //Closes whole program
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCtoL_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox1.SelectedItem);
        }
    }
}
