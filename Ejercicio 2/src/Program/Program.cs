using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string appointment1 = AppointmentService.CreateAppointment(DateTime.Now, "Wall Street");
            string medico1 = DatosDoctor.crearDoctor("Alfredo", "Cirujano Plástico");
            string persona1 = Persona.crearPersona("María", "12345678", "099887788", "23");

            string appointment2 = AppointmentService.CreateAppointment(DateTime.Now, "Wall Street");
            string medico2 = DatosDoctor.crearDoctor("Alfredo", "Cirujano Plástico");
            string persona2 = Persona.crearPersona("María", "12345678", "099887788", "23");

            CrearConsultas consulta1 = new CrearConsultas(appointment1, medico1, persona1);
            Console.WriteLine(consulta1.obtenerCont);
            CrearConsultas consulta2 = new CrearConsultas(appointment2, medico2, persona2);
            Console.WriteLine(consulta2.obtenerCont);

        }
    }
}
