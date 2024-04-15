using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;

[ServiceContract]
public interface IStudentService
{
    [OperationContract]
    void AddStudent(Estudiante student);

    [OperationContract]
    void UpdateStudent(Estudiante student);

    [OperationContract]
    void DeleteStudent(int studentId);

    [OperationContract]
    List<Estudiante> GetAllStudents();

    [OperationContract]
    Estudiante GetStudentById(int studentId);

    [OperationContract]
    void AddPayment(int studentId, Pago payment);

    [OperationContract]
    List<Pago> GetPaymentsByStudentId(int studentId);
}

public class Estudiante
{
}

[DataContract]
public class Estudiante
{
    [DataMember]
    public int IdEstudiante { get; set; }

    [DataMember]
    public string Nombre { get; set; }

    [DataMember]
    public string Apellido { get; set; }

    [DataMember]
    public string Grado { get; set; }

    [DataMember]
    public string Celular { get; set; }
}

[DataContract]
public class Pago
{
    [DataMember]
    public int IdPago { get; set; }

    [DataMember]
    public int IdEstidiante { get; set; }

    [DataMember]
    public decimal Cantidad { get; set; }

    [DataMember]
    public System.DateTime Fecha_de_pago { get; set; }
}