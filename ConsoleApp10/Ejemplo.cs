using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Ejemplo
    {
        // C# easy mode
        public int id;
        public string name;


        //agnostic
        public int getId()
        {
            return this.id;
        }

        public void setId(int id)
        {
            this.id = id;
        }
    }
}
