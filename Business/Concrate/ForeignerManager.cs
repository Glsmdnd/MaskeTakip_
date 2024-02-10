using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
namespace Business.Concrate
{
     public class ForeignerManager:IApplicantService
    {
        public void ApplyforMask(Person person)
        {
            throw new NotImplementedException();
        }
        public List<Person> GetList()
        {
            throw new NotImplementedException();

        }
        public bool CheckPerson(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
