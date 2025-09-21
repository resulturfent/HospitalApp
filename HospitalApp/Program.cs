
using HospitalApp.Entity;
using HospitalApp.Service;
using System.Linq;

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

            Console.WriteLine("ID:" + employee.Id);
            Console.WriteLine("TC:" + employee.TC);
            Console.WriteLine("Adı:" + employee.Name);
            Console.WriteLine("Soyadı:" + employee.Lastname);
            Console.WriteLine("E-mail:" + employee.Email);//kapsülleme içinde get kısmını kullanır
            //***************************************

            Doctor doctor = new Doctor();//instance=> örnekleme
            doctor.Id = 1;
            doctor.TC = 12345678901;
            doctor.Name = "resül";
            doctor.Email = "resul.turfent";
            //// create => resul.turfent@communitydeveloper.com
            doctor.IsActive = true;//inherit edilen class üzerinde property çağrıldı

            Console.WriteLine(doctor.Email);
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
            Console.WriteLine(clinic.CreateInfo());
            //---------------------------------------------------
            //interface, abstract 
            Employee employee1 = new Employee();
            Clinic clinic1 = new Clinic();
            // BaseEntity baseEntity = new BaseEntity();//instance alınabiliyor??

            //IDoctor doctor1 = new IDoctor();
            //Interface class türü new lwnip örnek alınamaz(instance alınamaz). Tek bir amacı var o da Implemet etmek 

            doctor.GetInfo(1);//
            clinic.GetInfo(1);
            Console.Clear();

            Appointment appointment = new Appointment();

            Console.WriteLine("Randevu için tarih yazınız");
            DateTime appointmentDate = Convert.ToDateTime(Console.ReadLine());
            appointment.CreateDate = DateTime.Now;
            appointment.CreatorId = 1;

            Console.WriteLine("Randevu için saat giriniz");
            string appointmentHour = Console.ReadLine();

            Console.WriteLine("{0} tarihinda {1} saatinde yapacağınız randevu için klinik seçiniz?", appointmentDate.ToShortDateString(), appointmentHour);


            while (true)
            {
                var listClinics = clinic.List();

                foreach (var item in listClinics)
                {
                    Console.WriteLine("Id:{0} Adı:{1}", item.Id, item.Name);
                }
                int secilenKlinikId = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("Seçilen Klinik için doktor seçimini yapınız!");

                var doctors = doctor.List();
                int countAppointment = 0;
                int appointmentId = 0;

                foreach (var item in doctors)
                {
                    if (secilenKlinikId == item.ClinicId)
                    {
                        countAppointment++;
                        Console.WriteLine("Id:{0} Adı-Soyadı:{1}-{2} ", item.Id, item.Name, item.Lastname);
                    }
                }

                if (countAppointment == 0)
                {
                    Console.WriteLine("Seçilen Klinik için uygun doktor bulunamadı");
                    Console.WriteLine("-----------------------------------------------");

                    Console.WriteLine("Lütfen uygun bir klinik seçiniz");
                    continue;
                }

                int secileDoktorId = Convert.ToInt32(Console.ReadLine());

                var selectClinic = clinic.List().Where(c => c.Id == secilenKlinikId).FirstOrDefault();
                var selectDoctor = doctor.List().Where(d => d.Id == secileDoktorId).FirstOrDefault();

                Console.WriteLine("{0} tarihinda {1} saatinde yapacağınız randevu için klinik {2} için {3} doktorona randevunuz başarılı bir şekilde oluşturuldu", appointmentDate.ToShortDateString(), appointmentHour, selectClinic.Name, selectDoctor.Name);
                appointmentId++;
                appointment.Id = appointmentId;
                appointment.PatientId = 1;
                appointment.DoctorId = secileDoktorId;
                appointment.ClinicId = secilenKlinikId;
                appointment.AppointmentDate = appointmentDate;
                appointment.Hour = appointmentHour;
                appointment.CreateDate = DateTime.Now;
                appointment.CreatorId = 1;
                Console.WriteLine(appointment.GetInfo(appointmentId));//abstract method kullanıldı
                break;
            }

            Console.Read();

        }
    }
}
