using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB3SPZ
{
    public class Process
    {
        public string Name { set; get; }
        public string User { set; get; }
        public float CPUTime { set; get; }
        public float Memory { set; get; }
        public string Location { set; get; }
        private int priority;
        public int Priority { get { return priority; } set { setPriority(value); } }

        public void setPriority(int value)
        {
            priority = (value > 4) ? 4 : (value < 0) ? 0 : value;
        }
        public Process(string initName,string initUser,float initCPU=0, float initMem=0, string initLoc="root", int initPriority = 0)
        {
            Name = initName;
            User = initUser;
            CPUTime = initCPU;
            Memory = initMem;
            Location = initLoc;
            Priority = initPriority;
            Priority = (Priority > 4) ? 4 : (Priority < 0) ? 0 : Priority;
        }
        public Process(Process instance)
        {
            Name = instance.Name;
            User = instance.User;
            CPUTime = instance.CPUTime;
            Memory = instance.Memory;
            Location = instance.Location;
            Priority = instance.Priority;
        }
        public static Process operator ++(Process instance)
        {
            var newInst =  new Process(instance);
            newInst.Priority++;
            return newInst;
        }
        public static Process operator --(Process instance)
        {
            var newInst = new Process(instance);
            newInst.Priority--;
            return newInst;
        }
    }
}
