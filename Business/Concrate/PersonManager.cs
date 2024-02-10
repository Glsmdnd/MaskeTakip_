using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrate
{
    //Çıplak class kalmasın
    public class PersonManager:IApplicantService
    {
        //public void ApplyforMask(String ad, String soyad,long TC)Bu şekilde kullamak sakıncalı buraya yarın doğum gününü eklesek
        //bir alttaki kayıt örneklerini tekrar düzeltmemiz gerekecek çünkü onlarda dgünü yok
        //ApplyforMask(ad "gül", soyad döndü,TC 54574857)
        //ApplyforMask(ad "fatma", soyad döndü,TC 54574857)
        //Aşağıdaki gibi paramatreyi clas olarak vermek --------->ENCAPSULATİON<----------
        public void ApplyforMask(Person person)
        {

        }
        public List<Person> GetList() {
            return null;

        }
        public bool CheckPerson(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(person.NationalIdentity,person.FirstName,person.LastName,person.DateOfBirthDay))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
