using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class Class1
    {
        public int Wallet { get; set; }
        public string Name { get; set; }

        public Class1(string name, int wallet)
        {
            Wallet = wallet;
            Name = name;
        }

        public Class1(string name) : this(name, 50)
        {
        }
    }
}
