using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_33
{
    public class Libro
    {
        private List<string> paginas;

        public Libro()
        {
            this.paginas = new List<string>();
        }

        public string this[int i]
        {
            get
            {
                if (i < this.paginas.Count && i >= 0)
                    return this.paginas[i];
                else
                    return "VACIO";
            }
            set
            {
                if (i < this.paginas.Count && i >= 0)
                    this.paginas[i] = value;
                else
                    this.paginas.Add(value);
            }
        }
    }

}
