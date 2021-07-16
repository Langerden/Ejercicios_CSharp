using System;

namespace Entidades
{
    [Serializable]
    public class Salidas
    {
        private DateTime fechaFin;
        private DateTime fechaInicio;

        public Salidas()
        {
            FechaInicio = DateTime.Now;
        }

        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }

        public int TiempoTotal
        {
            get { return fechaInicio.DiferenciaEnMinutos(FechaFin); }
        }

        public void FinalizarSalida() {
            FechaFin = DateTime.Now;
        }

       

    }
}