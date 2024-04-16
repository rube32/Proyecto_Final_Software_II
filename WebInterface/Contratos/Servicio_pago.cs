using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;


namespace WebInterface.Contratos
{
    public class Servicio_pago
    {
        {
    [OperationContract]
        void ProcesarPago(Pago pago);
    }

// IStudentService.cs
using System.ServiceModel;

[ServiceContract]
    public interface IStudentService
    {
        [OperationContract]
        Estudiante ObtenerEstudiante(int idEstudiante);
    }
}
}