using System;
using System.Text;

namespace Library
{
    public class CrearConsultas
    {
        public string DatosDoctor {get;}
        public string DatosPersona {get;}
        public string AppointmentService {get;}
        public static int cont = 0;
        public int NumeroConsulta {get;}
        public CrearConsultas(string appointmentService, string medico, string datosPersona)
        {
            this.DatosDoctor = medico;
            this.DatosPersona = datosPersona;
            this.AppointmentService = appointmentService;
            incrementarCont();
            this.obtenerCont = cont;
        }
        public static void incrementarCont()
        {
            cont++;
        }
        public int obtenerCont{get;}
    }
}

    