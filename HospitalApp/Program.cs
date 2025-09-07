
using HospitalApp.Entity;
using HospitalApp.Service;

namespace HospitalApp
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /*
             OOP
            1-Encapsulation=> Property
            2-Inheritance=>Kalıtım
            3-Polymorphism=>Overloading,Overriding
            4-Abstraction=>Soyutlama
            5-Interfaces=>Arayüzler
            //static, Enum,??
             
             */


            Employee employee = new Employee();
            employee.Id = 1;
            employee.TC = 12345678901;
            employee.Name = "Resül";
            employee.Lastname = "Türfent";
            employee.Email = "resul.turfent@gmail.com";

            Console.WriteLine("ID:"+employee.Id);
            Console.WriteLine("TC:"+employee.TC);
            Console.WriteLine("Adı:"+employee.Name);
            Console.WriteLine("Soyadı:"+employee.Lastname);
            Console.WriteLine("E-mail:"+employee.Email);//kapsülleme içinde get kısmını kullanır
            //***************************************

            Doctor doctor = new Doctor();//instance=> örnekleme
            doctor.Id = 1;
            doctor.TC = 12345678901;
            doctor.Name = "resül";
            doctor.Email = "resul.turfent";
           //// create => resul.turfent@communitydeveloper.com
           doctor.IsActive = true;//inherit edilen class üzerinde property çağrıldı

            Console.WriteLine(  doctor.Email);
            //Console.WriteLine(doctor._email);
            //bir Role adında bir class oluşturun ve BaseEntity den inherit edin ve Id,Name,Description alanlarını ekleyin
            Console.Clear();

            Clinic clinic = new Clinic();

            var clinics = clinic.List();

            foreach (var item in clinics)
            {
                if (item.IsActive)//sadece aktif olanları listele
                {
                    Console.WriteLine(item.Id + " " + item.Name + " " + item.IsActive + " " + item.CreateDate);
                }
            }

            //**************************************
            //interface, abstract
            //virtual=> Sanal, override=> ezmek
            Console.WriteLine("Doktor Create Info");
            Console.WriteLine(doctor.CreateInfo());

            Console.WriteLine("Clinic Create Info");
            Console.WriteLine( clinic.CreateInfo());
            //---------------------------------------------------
            //interface, abstract 
            Employee employee1 = new Employee();
            Clinic clinic1 = new Clinic();
            // BaseEntity baseEntity = new BaseEntity();//instance alınabiliyor??

            //IDoctor doctor1 = new IDoctor();
            //Interface class türü new lwnip örnek alınamaz(instance alınamaz). Tek bir amacı var o da Implemet etmek 

            doctor.GetInfo();//
            clinic.GetInfo();

            Console.Read();

        }
    }
}
