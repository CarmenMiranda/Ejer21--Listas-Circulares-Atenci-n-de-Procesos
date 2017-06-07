﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer21__LiCirc_AtenProcesos
{
    class Proceso
    {
        static Random aleatorio;
        private int _cicloAleatorio; //Requiere entre 4 y 12 ciclos para ser atendido(totalmente aleatorio).
        public int cicloAleatorio
        {
            get { return _cicloAleatorio; }
            set { _cicloAleatorio = value; }
        }

        public Proceso()
        {
            aleatorio = new Random(DateTime.Now.Millisecond);
            _cicloAleatorio = aleatorio.Next(4, 13);
            _procesoSiguiente = null;
        }

        private Proceso _procesoSiguiente;
        public Proceso procesoSiguiente
        {
            get { return _procesoSiguiente; }
            set { _procesoSiguiente = value; }
        }
    }
}
