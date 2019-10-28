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
    public partial class Form1 : Form
    {
        private readonly List<Computer> computers;
        private BindingSource bindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            using (var form = new Form2())
            {
                var result = form.ShowDialog();
                var pc = form.pc;
                computers.Add(new Computer
                {
                    Name = pc.Name,
                    CPUCount = pc.CPUCount,
                    CPUFrequency = pc.CPUFrequency,
                    RAM = pc.RAM
                }) ;
            }
        }
    }
}
