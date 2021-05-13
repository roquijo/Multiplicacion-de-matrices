using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionTestMatriz.logica
{
    class Experimentacion
    {
        private int matriz;
        private Stopwatch particion;
        private Stopwatch strassen;
        private Stopwatch winograd;

        public Experimentacion(int pMatriz, Stopwatch pParticion, Stopwatch pStrassen, Stopwatch pWinograd)
        {
            matriz = pMatriz;
            particion = pParticion;
            strassen = pStrassen;
            winograd = pWinograd;
        }

        public int getMatriz()
        {
            return matriz;
        }

        public Stopwatch getParticion()
        {
            return particion;
        }

        public Stopwatch getStrassen()
        {
            return strassen;
        }

        public Stopwatch getWinograd()
        {
            return winograd;
        }


    }
}
