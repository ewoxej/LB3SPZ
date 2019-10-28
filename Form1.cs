using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//TODO: add ram and cpu percentage
//TODO: fix issues with add/delete computers
namespace LB3SPZ
{
    public partial class Form1 : Form
    {
        private readonly Dictionary<string,Computer> computers = new Dictionary<string,Computer>();
        private BindingSource bindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private string MakeComputerString(Computer comp)
        {
            return comp.Name + ": CPU: " + comp.CPUFrequency.ToString() + " x" + comp.CPUCount.ToString() + ", RAM: " + comp.RAM;
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            using (var form = new Form2())
            {
                var result = form.ShowDialog();
                var pc = form.pc;
                computers.Add(MakeComputerString(pc), new Computer
                {
                    Name = pc.Name,
                    CPUCount = pc.CPUCount,
                    CPUFrequency = pc.CPUFrequency,
                    RAM = pc.RAM
                });
                comboBox1.Items.Add(MakeComputerString(pc));
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = comboBox1.SelectedItem.ToString();
            Computer element;
            computers.TryGetValue(str,out element);
            label2.Text = "Total: "+element.processes.Count.ToString();
            dataGridView1.DataSource = bindingSource;
            bindingSource.DataSource = element.processes;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string str = comboBox1.SelectedItem.ToString();
            Computer element;
            computers.TryGetValue(str, out element);
            using (var form = new Form2(element))
            {
                var result = form.ShowDialog();
                var pc = form.pc;
                computers.Remove(MakeComputerString(element));
                var index = comboBox1.Items.IndexOf(MakeComputerString(element));
                comboBox1.Items.RemoveAt(index);
                computers.Add(MakeComputerString(pc), new Computer
                {
                    Name = pc.Name,
                    CPUCount = pc.CPUCount,
                    CPUFrequency = pc.CPUFrequency,
                    RAM = pc.RAM
                });
                comboBox1.Items.Add(MakeComputerString(pc));
                comboBox1.Text = "";
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string str = comboBox1.SelectedItem.ToString();
            Computer element;
            computers.TryGetValue(str, out element);
            computers.Remove(MakeComputerString(element));
            var index = comboBox1.Items.IndexOf(MakeComputerString(element));
            comboBox1.Items.RemoveAt(index);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
        }
    }
}
