//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Linq;

//namespace Service.Services
//{
//    public class EmployeeServices
//    {

//        public Employee GetById(int id)
//        {
//            var employees = GetAll();
//            foreach (var item in employees)
//            {
//                if (employees.Id == id)
//                {
//                    return employee;
//                }
//            }

//            return null;

//        }
//        public Employee[] GetAll()
//        {
//            Employee[] employees =
//            {
//                new Employee
//                {
//                    Id = 1,
//                    Name = "Ismayil1",
//                    Surname = "Efendizade1",
//                    Age = 29,
//                    Salary = 1200
//                },

//                new Employee
//                {
//                    Id = 2,
//                    Name = "Ismayil2",
//                    Surname = "Efendizade2",
//                    Age = 25,
//                    Salary = 1500
//                },

//                new Employee
//                {
//                    Id = 3,
//                    Name = "Ismayil3",
//                    Surname = "Efendizade3",
//                    Age = 28,
//                    Salary = 100
//                },
//            };
//            return employees;
//        }

//    }
//}
