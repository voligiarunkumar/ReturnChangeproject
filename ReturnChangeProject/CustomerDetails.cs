using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ReturnChangeProject
{
    //using abstaction and overiding concepts
    abstract class CustomerDetails
    {
        public abstract void CheckcustomerDetails(int EmployeeID);

    }
    class Customers:CustomerDetails
    {
        public override void CheckcustomerDetails(int EmployeeID)
        {
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee()
            {
                Id = 1,
                Name = "Shreeshyadav",
                Rentalagency = "automobile",
                PostalCode = 1234,
                DateofBith = 09011999,
                Location = "USA"
            });

            empList.Add(new Employee()
            {
                Id = 2,
                Name = "Shreeshyadav",
                Rentalagency = "SpeedX",
                PostalCode = 509214,
                DateofBith = 01092001,
                Location = "USA"
            });
            empList.Add(new Employee()
            {
                Id = 3,
                Name = "Suresh",
                Rentalagency = "SpeedX",
                PostalCode = 509321,
                DateofBith = 08041999,
                Location = "USA"
            });

            for (int index = 0; index <= empList.Count - 1; index = index + 1)
            {
                if (empList[index].Id == EmployeeID)
                {
                    Console.WriteLine("Your Id is {0}\nName {1}\nRentalagency {2}", empList[index].Id, empList[index].Name, empList[index].Rentalagency, empList[index].Location);
                }
            }

        }

    }
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PostalCode { get; set; }
        public int DateofBith { get; set; }
        public string Rentalagency { get; set; }
        public string Location { get; set; }
     }
  
}
