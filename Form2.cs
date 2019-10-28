using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB3SPZ
{
    public partial class Form2 : Form
    {
        public Computer pc = new Computer();
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Computer comp)
        {
            InitializeComponent();
            textBox1.Text = pc.Name;
            textBox2.Text = pc.RAM.ToString();
            textBox3.Text = pc.CPUFrequency.ToString();
            textBox4.Text = pc.CPUCount.ToString();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            pc.Name = textBox1.Text;
            pc.RAM = int.Parse(textBox2.Text);
            pc.CPUFrequency = float.Parse(textBox3.Text);
            pc.CPUCount = int.Parse(textBox4.Text);
            Close();
        }
    }
}
