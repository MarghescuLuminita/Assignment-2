using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurnitureManufacturer.Model;
using FurnitureManufacturer.Presenter;
using FurnitureManufacturer.Exporter;

namespace FurnitureManufacturer.Presenter
{
    public class UserOperations
    {
        public User Login(string userName, string password)
        {
            DataAccess dal = new DataAccess();
            User user = dal.GetUser(userName);
            if (user != null)
            {
                Security secure = new Security();
                if (secure.VerifyHash(password, user.Password))
                {
                    Console.WriteLine("User " + user.UserName + " credentials are right");
                }
                else
                {
                    Console.WriteLine("User " + user.UserName + "credentials are wrong");
                    user = null;
                    //TO-DO
                }
            }
            
            return user;
        }

        public IList<User> RetrieveUsers()
        {
            IList<User> listUser = new List<User>();
            DataAccess dal = new DataAccess();
            listUser = dal.RetrieveUsers();

            return listUser;
        }

        public void AddUser(User user)
        {
            Security secure = new Security();
            user.Password = secure.HashSHA1(user.Password);

            DataAccess dal = new DataAccess();
            dal.AddUser(user);
        }

        public void UpdateUser(User user)
        {
            DataAccess dal = new DataAccess();
            dal.UpdateUser(user);
        }

        public void DeleteUser(User user)
        {
            DataAccess dal = new DataAccess();
            dal.DeleteUser(user);
        }
        
    }
}
