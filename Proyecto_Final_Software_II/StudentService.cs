using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Proyecto_Final_Software_II
{
    interface StudentService
    {
        public class StudentService : Estudiante;
            public class StudentService : Estudiante
        {
            public void AgregaEstudiante(Estudiante estudiante)
            {
                // agregar un estudiante 
            }

            public void ActualizarEstudiante(Estudiante estudiante)
            {
                // actualizar un estudiante
            }

            public void Eliminar_Estudiantes(int Estudiante)
            {
                // eliminar un estudiante 
            }

            public List<Estudiante > Obtener_todos_los_estudiantes()
            {
                // obtener todos los estudiantes
                return new List<Estudiante>();
            }

            public Estudiante Estudiante_por_Id(int IdEstudiante)
            {
                // obtener un estudiante por su ID 
                return null;
            }

            public void AñadirPago(int IdEstudiante, Pago payment)
            {
                // agregar un pago a un estudiante
            }

            public List<Pago> Obtener_pagos_IdEstudiante(int IdEstudiante)
            {
                // obtener todos los pagos de un estudiante
                return new List<Pago>();
            }
        }

    }
}
