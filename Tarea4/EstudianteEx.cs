using System;

namespace Tarea4
{
    public static class EstudianteEx
    {
        public static void MostrarResumen(this Universidad.Estudiante estudiante)
        {
            double porcentajeAsistencia = Universidad.Asistencia.CalcularPorcentajeAsistencia(
                estudiante.NumeroSesionesTotales, estudiante.NumeroSesionesAsistidas);

            bool aprobado = Universidad.Asistencia.CumpleConMinimo(porcentajeAsistencia);

            string estado = aprobado ? "Aprobado" : "No Aprobado";

            Console.WriteLine(".............................................");
            Console.WriteLine($"Estudiante: {estudiante.Nombre}");
            Console.WriteLine($"Asistencias: {estudiante.NumeroSesionesAsistidas} / {estudiante.NumeroSesionesTotales}");
            Console.WriteLine($"Porcentaje de Asistencia: {porcentajeAsistencia:F2}%"); // Formato a dos decimales
            Console.WriteLine($"Estado: {estado}");
            Console.WriteLine(".............................................\n");
        }
    }
}