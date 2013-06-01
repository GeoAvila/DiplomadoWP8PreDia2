using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class MiClase
    {
        int campo;

            public int CampoComoPropiedad
            {
                get { return campo; }
                set { campo = value; }
            }
            const int constante = 5;

            public MiClase()
            {
                campo = 10;
            }

            public MiClase(int valor)
            {
                campo = valor;
            }

            int miPropiedadInterna;
            public int miPropiedad
            {
                get {
                    return miPropiedadInterna;
                }
                set
                {
                    miPropiedadInterna = value;
                }
            }
            public int MiMetodo(ref int parametro,string otroParemetro,out double parametro3)
            {
                parametro = 10;
                parametro3 = 99.1;
                return 0;
            }
            int[] indexador;
            public static event EventHandler MiEvento;
            public int this[int valor]
            {
                get { return indexador[valor]; }
            }

            public int Metodo()
            {
                return 0;
            }
            public int Metodo(int valor)
            {
                return 1;
            }
            public int MetodoDiferente(int valor, string a, double y)
            {
                return 5;
            }
               
    }   
}
