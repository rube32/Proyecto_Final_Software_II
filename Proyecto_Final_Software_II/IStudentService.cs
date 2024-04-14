using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;

[ServiceContract]
public interface IStudentService
{
    [OperationContract]
    void AddStudent(Estudiante student);

    [OperationContract]
    void UpdateStudent(Student student);

    [OperationContract]
    void DeleteStudent(int studentId);

    [OperationContract]
    List<Student> GetAllStudents();

    [OperationContract]
    Student GetStudentById(int studentId);

    [OperationContract]
    void AddPayment(int studentId, Payment payment);

    [OperationContract]
    List<Payment> GetPaymentsByStudentId(int studentId);
}

public class Estudiante
{
}

[DataContract]
public class Student
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
public class Payment
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