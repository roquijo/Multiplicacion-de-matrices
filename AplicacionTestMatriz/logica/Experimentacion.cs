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
        private double particion;
        private double strassen;
        private double winograd;

        public Experimentacion(int pMatriz, double pParticion, double pStrassen, double pWinograd)
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

        public double getParticion()
        {
            return particion;
        }

        public double getStrassen()
        {
            return strassen;
        }

        public double getWinograd()
        {
            return winograd;
        }


    }
}
