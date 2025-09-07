namespace HospitalApp.Entity;

//internal class Appointment
//internal class Appointment: BaseEntity//inheritance
internal class Appointment: DeleteBaseEntity//inheritance
{
    public int Id { get; set; }
    public int PatientId { get; set; }
    public int DoctorId { get; set; }
    public DateTime AppointmentDate { get; set; }
    public string Hour { get; set; }

    //public override string GetInfo()
    //{
    //    return $"Id: {Id}, PatientId: {PatientId}, DoctorId: {DoctorId}, AppointmentDate: {AppointmentDate}, Hour: {Hour}";
    //}
}
