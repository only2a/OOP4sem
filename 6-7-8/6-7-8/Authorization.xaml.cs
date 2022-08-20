using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Resources;
using _6_7_8.Controllers;
using _6_7_8.Models;

namespace _6_7_8
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        public static UserControl userController;
        public static User CurrentUser;
        public static bool IsAdmin;
        public Authorization()
        {
            InitializeComponent();
            StreamResourceInfo sri = Application.GetResourceStream(
            new Uri("Pictures/rock.cur", UriKind.Relative));
            Cursor customCursor = new Cursor(sri.Stream);
            this.Cursor = customCursor;
        }
      
        private void WindowBinding_Opened(object sender, RoutedEventArgs e)
        {
            userController = new UserControl(login.Text, password.Password);
            CurrentUser = userController.GetCurrent();
            IsAdmin = userController.IsAdmin;
            this.Close();
          
        }
    }
}
