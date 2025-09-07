using HospitalApp.Entity;

namespace HospitalApp.Service;

public interface IEmployee
{
    public string Kaydet();
    public string Guncelle();
    public List<string> Liste();
    public int Sil();
    public object Bul();
    public Employee Getir();
}
