using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Reptil : Animal
    {
        public string cambiarPiel()
        {
            return Nombre + " cambio de piel.";
        }
        override public string desplazar()
        {
            return Nombre + " está arrastrandose.";
        }
    }
}
