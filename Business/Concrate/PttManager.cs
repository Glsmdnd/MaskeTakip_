using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrate
{
    public class PttManager:ISupplierService
    {
        //PttManager olarak applicant service isimli clasa ihtiyaç duyuyorum.Bunu new lemek yerine onun interface ini yazıyorum.
        //bu class başladığında lazım olduğu için cons da aiht vardır.
        private IApplicantService _applicantService;
        //consractor=oluşturucu.cons new edildiğinde ilk burayı çalıştır.
        public PttManager(IApplicantService applicantService)//Parantez içi ben pttManager olarak IapplicationService bağımlıyım
        {
            _applicantService=applicantService; 
        }
        public void GiveMask(Person person)
        {
            if(_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName+" için maske verildi!");
            }
            else
            {
                Console.WriteLine(person.FirstName + " için maske verilemedi!");
            }
                
        }
    }
}
 