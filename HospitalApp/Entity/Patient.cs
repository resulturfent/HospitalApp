namespace HospitalApp.Entity;

internal class Patient:BaseEntity
{//Scope
    //...

    public int Id { get; set; }
    public long TC { get; set; }
    public string Name { get; set; }
    public string Lastname { get; set; }
    public DateTime Birthdate { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }

    public string City { get; set; }
    public string District { get; set; }



}
