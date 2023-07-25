//using Repeatclasswork.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection.Metadata.Ecma335;
//using System.Text;
//using System.Threading.Tasks;

//namespace Repeatclasswork.Services
//{
//    internal class Doctorservise
//    {
//        public void FilterByDate(DateTime start, DateTime end)
//        {
//            var doctors = GetDoctors();

//            foreach (Doctor doctor in doctors)
//            {
//                if (doctor.Birthday > start && doctor.Birthday < end)
//                {
//                    string result = $"{doctor.Id} , {doctor.Name} , {doctor.Surname} , {doctor.Address} , {DateTime.Now.Year - doctor.Birthday.Year}";
//                }
//            }
//        }




//        private Doctor[] GetDoctors()
//        {
//            Doctor[] Doctors =
//            {
//                new Doctor
//                {
//                    Id = 1,
//                    Name = "Vuqar1",
//                    Surname = "Israfilov1",
//                    Address = "Ecemi1",
//                    Birthday = new DateTime(1999 , 05 , 06)
//                }
//            };



//               new Doctor
//               {
//                   Id = 2,
//                   Name = "Vuqar2",
//                   Surname = "Israfilov2",
//                   Address = "Ecemi2",
//                   Birthday = new DateTime(1993, 09, 06)
//               };


//            new Doctor
//            {
//                Id = 3,
//                Name = "Vuqar3",
//                Surname = "Israfilov3",
//                Address = "Ecemi3",
//                Birthday = new DateTime(1995, 11, 24)
//            };
//             return Doctors;
            
//        }
        
//    }
//}
