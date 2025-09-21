namespace HospitalApp.Entity;

public abstract class BaseEntity
{
    public bool IsActive { get; set; }
    public DateTime CreateDate { get; set; }
    public int CreatorId { get; set; }
    public DateTime UpdateDate { get; set; }
    public int UpdaterId { get; set; }



    public virtual string  CreateInfo()
    {
        CreateDate = DateTime.Now;// kayıt tarihi=> 2 +- gün değişebilir. Eğer değişmesi gerekirse kalıtım alan class içinde override edilmesi gereklidir.
        CreatorId = 1;
        
        return "Kayıt Tarihi:" + CreateDate + " Kayıt Eden Kullanıcı ID:" + CreatorId;
    }
    //abstract class içinde method tanımlama yapılabilir
    public string Bul()
    {
        return "BaseEntity Sınıfından Bul Metodu Çalıştı";
    }

    public abstract string GetInfo(int Id);//sözleşme++

}
