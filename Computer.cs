using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB3SPZ
{
    public class Computer
    {
        public string Name { get; set; }
        public int RAM { get; set; }
        public float CPUFrequency { get; set; }
        public int CPUCount { get; set; }
        private Dictionary<string, Process> processes;

        public void addProcess(Process inst)
        {
            processes.Add(inst.Name, inst);
        }
        public void removeProcess(string procName)
        {
            processes.Remove(procName);
        }
    }
}
