namespace HospitalApp.Entity;

internal class User:BaseEntity
{
    public int Id { get; set; }
    public string UserName { get; set; }
    public string  Password { get; set; }
    public int  EmployeeId { get; set; }

}
