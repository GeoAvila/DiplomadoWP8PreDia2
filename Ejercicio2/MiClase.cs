using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class MiClase
    {
            int campo;
            const int constante = 5;
            public MiClase()
            {
                campo = 10;
            }
            int miPropiedadInterna;
            int miPropiedad
            {
                get {
                    return miPropiedadInterna;
                }
                set
                {
                    miPropiedadInterna = value;
                }
            }
            private int MiMetodo(int parametro,string otroParemetro)
            {
                return 0;
            }
            int[] indexador;
            public event EventHandler MiEvento;
            public int this[int valor]
            {
                get { return indexador[valor]; }
            }
               
    }   
}
