//using Service.Services;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DLLhomework.Controllers
//{
//    internal class Employeecontrollers
//    {
//        private EmployeeServices _employeeServices;

//        public Employeecontrollers()
//        {
//            _employeeServices = new EmployeeServices();
//        }

//        public void GetAllEmployees()
//        {
//            var emplloyees = _employeeServices.GetAll();

//            foreach (var item in emplloyees)
//            {
//                string result = $"{employee.Id} , {employee.Name} , {employee.Surname} , {employee.Age}, {employee.Salary}$";

//                Console.WriteLine(result);
//            }
//        }

//        public void GetEmployeeById()
//        {
//            int id = 2;
//            var result =_employeeServices.GetById(id);
//            Console.WriteLine(employee.Id + "--" + Employee.Name);
//        }
//    }

//}
