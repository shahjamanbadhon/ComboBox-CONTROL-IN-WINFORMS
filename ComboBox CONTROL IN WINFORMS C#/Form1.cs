using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox_CONTROL_IN_WINFORMS_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Remove(comboBox1.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int count = comboBox1.Items.Count;
            MessageBox.Show("Item Number is : " + count);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1.Sorted = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
        }
    }
}
