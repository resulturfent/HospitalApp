namespace HospitalApp.Entity;

internal class Doctor:BaseEntity
{

    //RESÜL
    //prop+tab +tab
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string  Lastname { get; set; }
    public string  Title { get; set; }
    public int ClinicId { get; set; }
    //public string  Email { get; set; }//Kapsülleme 
    public long TC { get; set; }


    public override string CreateInfo()
    {
        Id = 25090701;
        CreateDate = Convert.ToDateTime("09-05-2025");// kayıt tarihi=> 2 +- gün değişebilir
        CreatorId = 10;
        return "Doktor ID:" + Id + " Kayıt Tarihi:" + CreateDate + " Kayıt Eden Kullanıcı ID:" + CreatorId;
    }

 

    private string  _email { get; set; }

    public string Email
    {
        get { return _email; }//oku

        set {
            //value

            if (!string.IsNullOrWhiteSpace(value))//dolu ise
            {
            _email=value+ "@communitydeveloper.com";

            }
        }
    }

    //girilen mail (hasan.derli) için sonuna communitydeveloper.com ekleyen bir kapsülleme yapısı ekleyiniz (hasan.derlik@communitydeveloper.com)
    //her yeni doktor eklendiğinde ekleme tarafında doktor ekleme tarihi(CreateDate) kapsülleme ile bugünün tarihi olarak gelsin
    //kullanıcı adı ve soyadı girildiğinde ad ve soyadı büyük harf ile başlatan ve ad soyadı Name altında veren kapsülleme yapısı ekleyiniz


    public List<Doctor> Lİst()
    {

        var doctors = new List<Doctor>
            {
                new Doctor { Id = 1, Name = "Ahmet", Lastname = "Yılmaz", Title = "Prof. Dr.", ClinicId = 1, TC = 12345678901 },
                new Doctor { Id = 2, Name = "Ayşe", Lastname = "Demir", Title = "Uzm. Dr.", ClinicId = 2, TC = 23456789012 },
                new Doctor { Id = 3, Name = "Mehmet", Lastname = "Kara", Title = "Op. Dr.", ClinicId = 1, TC = 34567890123 },
                new Doctor { Id = 4, Name = "Elif", Lastname = "Çelik", Title = "Doç. Dr.", ClinicId = 3, TC = 45678901234 },
                new Doctor { Id = 5, Name = "Burak", Lastname = "Şahin", Title = "Dr.", ClinicId = 2, TC = 56789012345 }
            };
        return doctors;
    }

    public override string GetInfo()
    {
        return "Doktor Adı:" + Name + " Doktor Soyadı:" + Lastname + " Ünvanı:" + Title + " Klinik ID:" + ClinicId;
    }
}
