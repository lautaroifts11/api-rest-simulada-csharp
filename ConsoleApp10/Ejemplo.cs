using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Ejemplo
    {
        //standard
        private int id;
        // defino props
        private string name;
        // uso las props
        public string Name {  get; set; }


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
