
using HospitalApp.Entity;

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

            foreach (var item in clinic.List())
            {
                Console.Write(item.Id+"-");
                Console.Write(item.Name + "-");
                //Console.Write(item.CreatorId + "-");
               // Console.Write(item.CreateDate );
                Console.Write(item.CreaterInfo(10) );
                Console.WriteLine();
            }


            Console.Read();

        }
    }
}
