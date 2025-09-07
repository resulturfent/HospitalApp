namespace HospitalApp.Service;

public interface IDoctor
{
    //interface class türüdür
    //kesinlikle method kod yapısını barındıran method gövdesi içermez
    //implement etmek için oluşturulur
    public void Kaydet();
    public void Guncelle();
    public void Liste();
    public void Sil();
    public void Bul();
    public void Getir();


}
