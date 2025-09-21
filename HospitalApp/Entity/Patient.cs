namespace HospitalApp.Entity;

internal class Patient : BaseEntity
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

    public override string GetInfo(int Id)
    {
        throw new NotImplementedException();
    }


    public List<Patient> List()
    {
        var patients = new List<Patient>
                    {
                        new Patient
                        {
                            Id = 1, TC = 12345678901, Name = "Ali", Lastname = "Kara",
                            Birthdate = new DateTime(1990, 5, 12), Phone = "05321234567", PhoneNumber = "05321234567",
                            Address = "Atatürk Mah. 12. Sok. No:5", Email = "ali.kara@example.com",
                            City = "İstanbul", District = "Kadıköy",
                            IsActive = true, CreateDate = DateTime.Now, CreatorId = 1, UpdateDate = DateTime.Now, UpdaterId = 1
                        },
                        new Patient
                        {
                            Id = 2, TC = 23456789012, Name = "Ayşe", Lastname = "Demir",
                            Birthdate = new DateTime(1985, 8, 24), Phone = "05349876543", PhoneNumber = "05349876543",
                            Address = "Cumhuriyet Cad. No:45", Email = "ayse.demir@example.com",
                            City = "Ankara", District = "Çankaya",
                            IsActive = true, CreateDate = DateTime.Now, CreatorId = 2, UpdateDate = DateTime.Now, UpdaterId = 2
                        },
                        new Patient
                        {
                            Id = 3, TC = 34567890123, Name = "Mehmet", Lastname = "Yıldız",
                            Birthdate = new DateTime(1978, 3, 15), Phone = "05431231234", PhoneNumber = "05431231234",
                            Address = "Gazi Mah. İnönü Sok. No:7", Email = "mehmet.yildiz@example.com",
                            City = "İzmir", District = "Konak",
                            IsActive = true, CreateDate = DateTime.Now, CreatorId = 3, UpdateDate = DateTime.Now, UpdaterId = 3
                        },
                        new Patient
                        {
                            Id = 4, TC = 45678901234, Name = "Elif", Lastname = "Şahin",
                            Birthdate = new DateTime(1992, 1, 30), Phone = "05551239876", PhoneNumber = "05551239876",
                            Address = "Barbaros Mah. Atatürk Cad. No:88", Email = "elif.sahin@example.com",
                            City = "Bursa", District = "Nilüfer",
                            IsActive = true, CreateDate = DateTime.Now, CreatorId = 4, UpdateDate = DateTime.Now, UpdaterId = 4
                        },
                        new Patient
                        {
                            Id = 5, TC = 56789012345, Name = "Hasan", Lastname = "Çelik",
                            Birthdate = new DateTime(1980, 11, 5), Phone = "05324445566", PhoneNumber = "05324445566",
                            Address = "Yıldırım Mah. 3. Cad. No:21", Email = "hasan.celik@example.com",
                            City = "Adana", District = "Seyhan",
                            IsActive = true, CreateDate = DateTime.Now, CreatorId = 5, UpdateDate = DateTime.Now, UpdaterId = 5
                        },
                        new Patient
                        {
                            Id = 6, TC = 67890123456, Name = "Zeynep", Lastname = "Aydın",
                            Birthdate = new DateTime(1995, 6, 14), Phone = "05556667788", PhoneNumber = "05556667788",
                            Address = "Mimar Sinan Mah. 2. Sok. No:13", Email = "zeynep.aydin@example.com",
                            City = "Antalya", District = "Muratpaşa",
                            IsActive = true, CreateDate = DateTime.Now, CreatorId = 6, UpdateDate = DateTime.Now, UpdaterId = 6
                        },
                        new Patient
                        {
                            Id = 7, TC = 78901234567, Name = "Ahmet", Lastname = "Koç",
                            Birthdate = new DateTime(1975, 9, 20), Phone = "05447778899", PhoneNumber = "05447778899",
                            Address = "Zafer Mah. Kule Sk. No:33", Email = "ahmet.koc@example.com",
                            City = "Konya", District = "Selçuklu",
                            IsActive = true, CreateDate = DateTime.Now, CreatorId = 7, UpdateDate = DateTime.Now, UpdaterId = 7
                        },
                        new Patient
                        {
                            Id = 8, TC = 89012345678, Name = "Fatma", Lastname = "Arslan",
                            Birthdate = new DateTime(1988, 12, 1), Phone = "05337776655", PhoneNumber = "05337776655",
                            Address = "Hürriyet Mah. 4. Sk. No:56", Email = "fatma.arslan@example.com",
                            City = "Gaziantep", District = "Şahinbey",
                            IsActive = true, CreateDate = DateTime.Now, CreatorId = 8, UpdateDate = DateTime.Now, UpdaterId = 8
                        },
                        new Patient
                        {
                            Id = 9, TC = 90123456789, Name = "Merve", Lastname = "Polat",
                            Birthdate = new DateTime(1999, 7, 19), Phone = "05553334422", PhoneNumber = "05553334422",
                            Address = "İnönü Mah. 5. Cd. No:9", Email = "merve.polat@example.com",
                            City = "Trabzon", District = "Ortahisar",
                            IsActive = true, CreateDate = DateTime.Now, CreatorId = 9, UpdateDate = DateTime.Now, UpdaterId = 9
                        },
                        new Patient
                        {
                            Id = 10, TC = 91234567890, Name = "Mustafa", Lastname = "Güneş",
                            Birthdate = new DateTime(1983, 4, 27), Phone = "05446665544", PhoneNumber = "05446665544",
                            Address = "Yenişehir Mah. Atatürk Bulv. No:99", Email = "mustafa.gunes@example.com",
                            City = "Mersin", District = "Yenişehir",
                            IsActive = true, CreateDate = DateTime.Now, CreatorId = 10, UpdateDate = DateTime.Now, UpdaterId = 10
                        }
                    };

        return patients;

    }
}
