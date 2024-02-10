using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    //interface kullanımında metodlar sadece imza olarak yazılır, bağımlılık azaltımı için interface kullanımı elzemdir
    public interface IApplicantService
    {
        //public void ApplyforMask(String ad, String soyad,long TC)Bu şekilde kullamak sakıncalı buraya yarın doğum gününü eklesek
        //bir alttaki kayıt örneklerini tekrar düzeltmemiz gerekecek çünkü onlarda dgünü yok
        //ApplyforMask(ad "gül", soyad döndü,TC 54574857)
        //ApplyforMask(ad "fatma", soyad döndü,TC 54574857)
        //Aşağıdaki gibi paramatreyi clas olarak vermek --------->ENCAPSULATİON<----------
        void ApplyforMask(Person person)
        {

        }
        List<Person> GetList()
        {
            return null;

        }
        bool CheckPerson(Person person)
        {
            return true;
        }
    }
}
