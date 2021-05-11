using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo
{
    partial class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Customer { DateOfBirth = new System.DateTime(1990, 24, 11), FirsName = "Nil", LastName = "Nadirler", NationalityID = "2345", Id = 1 });

            BaseCustomerManager customer = new StarbucksCustomerManager();
            customer.Save(new Customer
            {

            });
        }
    }
}
