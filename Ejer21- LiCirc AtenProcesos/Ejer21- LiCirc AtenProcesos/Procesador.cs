using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer21__LiCirc_AtenProcesos
{
    class Procesador
    {
        public Proceso _inicio;
        public bool primerProceso = false;
        public Proceso _final;
        private Proceso actualAtender;

        private int _procesosPendientes;
        public int procesosPendientes { get { return _procesosPendientes; } }

        private int _procesosAtendidos;
        public int procesosAtendidos { get { return _procesosAtendidos; } }

        private int _sumaCiclosPendientes;

        private int _máximoProcesosFormados;
        public int máximoProcesosFormados { get { return _máximoProcesosFormados; } }

        private int _colaVacía;
        public int colaVacía { get { return _colaVacía; } }

        public Procesador(){
            _inicio = null;
            _final = null;
            _procesosPendientes = 0;
            _colaVacía = 0;
            _procesosAtendidos = 0;
            _sumaCiclosPendientes = 0;
            _máximoProcesosFormados = 0;
        }

        static Random aleatorio = new Random(DateTime.Now.Millisecond);

        private int generadorDeProbabilidad(){
            return aleatorio.Next(1, 5); //1=proceso nuevo. 2,3,4=Ningún proceso.
        }

        public void generarCiclo(){
            if (generadorDeProbabilidad() == 1){
                Proceso nuevo = new Proceso();
                agregarProceso(nuevo);
            }
            else{
                if (_inicio == null)
                    _colaVacía++;
                primerProceso = false;
            }
        }

        private void agregarProceso(Proceso nuevo) {
            if (_inicio == null){
                _inicio = nuevo;
                primerProceso = true;
            }
            else {
                _final.procesoSiguiente = nuevo;
                primerProceso = false;
            }
            _final = nuevo;
            _final.procesoSiguiente = _inicio;
            _procesosPendientes++;
            actualAtender = _final;

            if (_máximoProcesosFormados < _procesosPendientes)
                _máximoProcesosFormados = procesosPendientes;
        }


        public void atenderProceso(){
            if (_inicio != null){
                if (actualAtender.cicloAleatorio != 0)
                    actualAtender.cicloAleatorio--;

                if (actualAtender.cicloAleatorio == 0){
                    _procesosPendientes--;
                    _procesosAtendidos++;
                    if (procesosPendientes != 0){
                        if (actualAtender == _inicio)
                            _inicio = _inicio.procesoSiguiente;
                    }
                    else{
                        _inicio = null;
                        _final = null;
                    }
                }
                actualAtender = actualAtender.procesoSiguiente;
            }
        }

        public int obtenerSumaDeCiclosPendientes(){
            if (procesosPendientes != 0){
                Proceso actual = _inicio;
                while (actual.procesoSiguiente != _inicio){
                    _sumaCiclosPendientes += actual.cicloAleatorio;
                    actual = actual.procesoSiguiente;
                }
                _sumaCiclosPendientes += actual.cicloAleatorio;   
            }
            return _sumaCiclosPendientes;
        }

    }
}
