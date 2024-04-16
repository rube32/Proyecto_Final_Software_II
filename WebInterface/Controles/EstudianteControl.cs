using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebInterface.Controles
{
    public class EstudianteControl
    {
        // StudentController.cs
        public class StudentController : Controller
        {
            private readonly EstudianteControl _studentService;

            public StudentController(EstudianteControl studentService)
            {
                _studentService = studentService;
            }

            public IActionResult GetStudent(int studentId)
            {
                var student = _studentService.GetStudent(studentId);
                return View(student); // Ejemplo de retorno de una vista con el estudiante obtenido
            }
        }
    }
}