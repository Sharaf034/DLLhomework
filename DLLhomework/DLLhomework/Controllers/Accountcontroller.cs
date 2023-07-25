//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DLLhomework.Controllers
//{
//    internal class Accountcontroller
//    {
//        private readonly AccountService _accountService;

//        public Accountcontroller()
//        {
//            _accountService = new AccountService();
//        }

//        public void Login()
//        {
//            Console.WriteLine("Username: ");
//            Username: string username = Console.ReadLine();

//            Console.WriteLine("Password: ");
//            string password = Console.ReadLine();

//            bool isLogin = _accountService.Login(username, password);

//            if (isLogin)
//            {
//                Console.WriteLine(AccountMessages.Login.Failed);

//                goto Username;
//            }
//        }
//    }
//}
