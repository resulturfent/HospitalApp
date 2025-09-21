namespace HospitalApp.Entity;

internal class Clinic:BaseEntity
{
    public int Id { get; set; }
    public string Name { get; set; }

    public override string GetInfo()
    {
        string clinicName = "Klinik Adı: " + Name;
        return clinicName;
    }

    public List<Clinic> List()
    {
        var clinics = new List<Clinic>
        {
            new Clinic { Id = 1, Name = "KBB",IsActive=true,CreateDate=DateTime.Now },
            new Clinic { Id = 2, Name = "Göz",IsActive=true },
            new Clinic { Id = 3, Name = "Nöroloji",IsActive=true },
            new Clinic { Id = 4, Name = "Embriyoloji" , IsActive = false},
            new Clinic { Id = 5, Name = "Dahiliye" , IsActive = true}
        };


        return clinics;

    }



}
