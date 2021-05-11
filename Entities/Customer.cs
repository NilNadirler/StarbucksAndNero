using InterfaceAbstractDemo.Abstract;
using System;

namespace InterfaceAbstractDemo
{


    public class Customer : IEntity
        {
            public int Id  { get; set; }
            public string FirsName { get; set; }
            public string LastName { get; set; }
            public DateTime DateOfBirth { get; set; }
            public string NationalityID { get; set; }

        }
    
}
