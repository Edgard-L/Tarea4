using System;
using System.Collections.Generic;

namespace Tarea4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(".............................................");
            Console.WriteLine(" Sistema de registro y control de asistencia");
            Console.WriteLine(".............................................");
            Console.WriteLine("");

            Universidad universidad = new Universidad();

            List<Universidad.Estudiante> estudiantesPredefinidos = new List<Universidad.Estudiante>
            {
                //Nombres 
                new Universidad.Estudiante("Edgard Jose Lopez Guido", 20, 20),
                new Universidad.Estudiante("Jose Rodrigo Piñeda ", 20, 17),
                new Universidad.Estudiante("Michael Jackson", 20, 19),
                new Universidad.Estudiante("Nanu Rosas Mora", 20, 18),
                new Universidad.Estudiante("Miku Nakano Waifu", 20, 10),
                new Universidad.Estudiante("Goku Rochi Sayan", 20, 15),
                new Universidad.Estudiante("Gohan G Martinez", 20, 3),
                new Universidad.Estudiante("Vegueta Vazquez Principe", 20, 18),
                new Universidad.Estudiante("Luffy Rey", 20, 11),
                new Universidad.Estudiante("Eren Villajo", 20, 16),
                new Universidad.Estudiante("Mikasa Akerman", 20, 20),
                new Universidad.Estudiante("Levis Akerman atk", 20, 8),
                new Universidad.Estudiante("Leonel Messi", 20, 7),
                new Universidad.Estudiante("Lana Rohades", 20, 19),
                new Universidad.Estudiante("Maria Khalifa", 20, 16),
                new Universidad.Estudiante("Homelamder V", 20, 14),
                new Universidad.Estudiante("William Butcher", 20, 8),
                new Universidad.Estudiante("Miles Morales Spid", 20, 7),
                new Universidad.Estudiante("Petter Parker", 20, 13),
                new Universidad.Estudiante("Cristiano Ronaldo", 20, 0)
            };

            // Registrar los estudiantes predefinidos en la universidad
            foreach (var estudiante in estudiantesPredefinidos)
            {
                universidad.RegistrarEstudiante(estudiante);
            }

            // Mostrar la información de los estudiantes y su estado utilizando el método de extensión
            foreach (var estudiante in universidad.estudiantes)
            {
                estudiante.MostrarResumen();
            }
        }
    }
}