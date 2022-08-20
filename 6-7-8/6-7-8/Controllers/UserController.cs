using _6_7_8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _6_7_8.Controllers
{
    public class UserControl
    {
        private const string USERS_FILE_NAME = "users.json";


        public List<User> Users { get; }
        public User CurrentUser { get; }
        public bool IsAdmin { get; } = false;



        public UserControl(string userName, string userPassword)
        {
            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(userPassword))
            {
                throw new ArgumentNullException("Неверное имя пользователя или пароль", nameof(userName));
            }
            Users = GetUsersData();

            CurrentUser = Users.SingleOrDefault(u => u.Name == userName && u.Password == userPassword);


            if (CurrentUser == null)
            {
                if (userName != "Admin" || userName != "admin")
                {
                    CurrentUser = new User(userName, userPassword, true);
                    Users.Add(CurrentUser);

                    Save();
                    MessageBox.Show("Вы успешно зарегистрировались", "Региcтрация");
                }
                else MessageBox.Show("У нас только один администратор!", "Попытка регистрации администратора");
            }
            else if (CurrentUser.IsAdmin()) MessageBox.Show("Вы авторизировались как 'Admin'", "Авторизация");
            else MessageBox.Show("Вы успешно авторизировались", "Авторизация");
            IsAdmin = CurrentUser.IsAdmin();
            if (Users.Count != 0)
            {
                CurrentCheck();
            }
        }

        public User GetCurrent()
        {
            return CurrentUser;
        }

        public void CurrentCheck()
        {
            foreach (var el in Users)
            {
                if (CurrentUser.Name == el.Name && CurrentUser.Password == el.Password)
                {
                    el.IsCurrent = true;
                }
                else el.IsCurrent = false;
            }
        }
        public UserControl()
        {

        }


        private List<User> GetUsersData()
        {
            return JsonSerializer.Deserialize<List<User>>(USERS_FILE_NAME) ?? new List<User>();
        }


        public void Save()
        {
            JsonSerializer.Serialize<List<User>>(Users, USERS_FILE_NAME);
        }



    }

}
