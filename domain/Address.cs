using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace domain
{
    public class Address
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Street { get; set; }
    }
    public class AdressService
    {
        public List<Address> list()
        {
            List<Address> list = new List<Address>();
            list.Add(new Address());
            list.Add(new Address());

            list[0].Id = 1;
            list[0].Number = 143;
            list[0].Street = "Calle 1";

            list[1].Id = 2;
            list[1].Number = 566;
            list[1].Street = "Calle 65";

            return list;
        }
        //public void delete(int id)
        //{
        //    AdressService service = new AdressService();
        //    Session.Add("addressList", service.list());

        //    list.RemoveAt(id);
        //}
    }
}
