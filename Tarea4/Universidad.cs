using System.Collections.Generic;

namespace Tarea4
{
    public class Universidad
    {
        public List<Estudiante> estudiantes;

        public Universidad()
        {
            estudiantes = new List<Estudiante>();
        }

        public void RegistrarEstudiante(Estudiante estudiante)
        {
            estudiantes.Add(estudiante);
        }

        // Clase anidada Estudiante
        public class Estudiante
        {
            public string Nombre { get; set; }
            public int NumeroSesionesTotales { get; set; }
            public int NumeroSesionesAsistidas { get; set; }

            public Estudiante(string nombre, int sesionesTotales, int sesionesAsistidas)
            {
                Nombre = nombre;
                NumeroSesionesTotales = sesionesTotales;
                NumeroSesionesAsistidas = sesionesAsistidas;
            }
        }

        // Clase  Asistencia
        public static class Asistencia
        {
            // Método estático para calcular el porcentaje de asistencia
            public static double CalcularPorcentajeAsistencia(int sesionesTotales, int sesionesAsistidas)
            {
                if (sesionesTotales == 0) return 0; // Evitar división por cero
                return (double)sesionesAsistidas / sesionesTotales * 100;
            }

            // Método estático para verificar si cumple con el mínimo requerido de asistencia
            public static bool CumpleConMinimo(double porcentajeAsistencia)
            {
                return porcentajeAsistencia >= 75; // Mínimo del 75% de asistencia
            }
        }
    }
}