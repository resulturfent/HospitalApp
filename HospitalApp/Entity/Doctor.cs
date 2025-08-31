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





}
