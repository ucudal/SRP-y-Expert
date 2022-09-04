using System;
using System.Text;

namespace Library
{
    public class DatosDoctor
    {
        public static string crearDoctor(string doctorName, string especialidadDoctor)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            if (string.IsNullOrEmpty(doctorName))
            {
                stringBuilder.Append("Unable to schedule appointment, 'doctor name' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(especialidadDoctor))
            {
                stringBuilder.Append("Unable to schedule appointment, 'doctor especiality' is required\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Appoinment scheduled");
            }

            return stringBuilder.ToString();
        }

    }
}
