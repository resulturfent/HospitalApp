namespace HospitalApp.Entity;

internal class User:BaseEntity
{
    public int Id { get; set; }
    public string UserName { get; set; }
    public string  Password { get; set; }
    public int  EmployeeId { get; set; }

    public List<User> List()
    {
        var users = new List<User>
            {
                new User
                {
                    Id = 1,
                    UserName = "admin",
                    Password = "Admin@123",   // 🔑 demo şifre
                    EmployeeId = 1001,
                    IsActive = true,
                    CreateDate = DateTime.Now,
                    CreatorId = 1,
                    UpdateDate = DateTime.Now,
                    UpdaterId = 1
                },
                new User
                {
                    Id = 2,
                    UserName = "dr.ahmet",
                    Password = "Doctor@456",
                    EmployeeId = 1002,
                    IsActive = true,
                    CreateDate = DateTime.Now,
                    CreatorId = 1,
                    UpdateDate = DateTime.Now,
                    UpdaterId = 1
                },
                new User
                {
                    Id = 3,
                    UserName = "nurse.elif",
                    Password = "Nurse@789",
                    EmployeeId = 1003,
                    IsActive = true,
                    CreateDate = DateTime.Now,
                    CreatorId = 1,
                    UpdateDate = DateTime.Now,
                    UpdaterId = 1
                },
                new User
                {
                    Id = 4,
                    UserName = "reception.fatma",
                    Password = "Recp@321",
                    EmployeeId = 1004,
                    IsActive = true,
                    CreateDate = DateTime.Now,
                    CreatorId = 1,
                    UpdateDate = DateTime.Now,
                    UpdaterId = 1
                },
                new User
                {
                    Id = 5,
                    UserName = "technician.murat",
                    Password = "Tech@654",
                    EmployeeId = 1005,
                    IsActive = true,
                    CreateDate = DateTime.Now,
                    CreatorId = 1,
                    UpdateDate = DateTime.Now,
                    UpdaterId = 1
                }
            };

        return users;

    }

    public override string GetInfo(int Id)
    {
        throw new NotImplementedException();
    }
}
