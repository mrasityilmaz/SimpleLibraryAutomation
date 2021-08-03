using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Controller
{
    class UserController
    {

        public void UserAdd()
        {
            using (MyContext _context = new MyContext())
            {
                if (_context.Users.FirstOrDefault() == null)
                {
                    Users SingleUser = new Users()
                    {
                        ID = 1,
                        Username = "rasit",
                        Password = "yilmaz"
                    };
                    _context.Users.Add(SingleUser);
                    _context.SaveChanges();
                }
            }






        }
        public string GetUsername()
        {
            using (MyContext _context = new MyContext())
            {
                return _context.Users.Select(x => x.Username).FirstOrDefault().ToString();

            }

        }
        public string GetPassword()
        {
            using (MyContext _context = new MyContext())
            {
                return _context.Users.Select(x => x.Password).FirstOrDefault().ToString();

            }

        }
    }
}
