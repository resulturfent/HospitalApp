namespace HospitalApp.Entity;

internal class Role:BaseEntity
{
    public int Id { get; set; }

    public string Name { get; set; }
    public string Description { get; set; }

    public override string GetInfo()
    {
        throw new NotImplementedException();
    }


    public List<Role> List()
    {
        var roles = new List<Role>
        {
            new Role { Id = 1, Name = "Admin", Description = "Yönetici Rolü", IsActive = true, CreateDate = DateTime.Now },
            new Role { Id = 2, Name = "Doctor", Description = "Doktor Rolü", IsActive = true, CreateDate = DateTime.Now },
            new Role { Id = 3, Name = "Nurse", Description = "Hemşire Rolü", IsActive = true, CreateDate = DateTime.Now },
            new Role { Id = 4, Name = "Receptionist", Description = "Resepsiyonist Rolü", IsActive = true, CreateDate = DateTime.Now },
            new Role { Id = 5, Name = "Patient", Description = "Hasta Rolü", IsActive = true, CreateDate = DateTime.Now }
        };
        return roles;
    }
}
