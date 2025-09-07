namespace HospitalApp.Entity;

public class Employee:BaseEntity
{
    public int Id;//Field
    public long TC;//Field
    public string Name;
    public string Lastname;
    public string Address;
    // public string Email;
    public DateTime Birthdate;
    public string Phone;

    //Property=> 
    //get=> Oku
    //set=> Kapsülleme

    //Encapsulation => Kapsülleme
    //1.yapı kapsülleme
    private string _email;//Field


    //2.yapı kapsülleme
    public string Email
    {
        //sadece alma işleminde 
        get { return _email; }//oku

        //set kuralları tanımlamak için değeri alır
       set {
            //value=> atanan değer
            _email= value;

        }//değer atarken çalışacak
    }

    public override string GetInfo()
    {
        throw new NotImplementedException();
    }
}
