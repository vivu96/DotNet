using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class cars
    {
        private int age;
        private string name;
        public void setage(int age)
        {
            this.age = age;
        }
        public void setName(string name) { this.name = name; }
        public int getage(int a) {
            age = a;
            return age;
        }
    }
}
