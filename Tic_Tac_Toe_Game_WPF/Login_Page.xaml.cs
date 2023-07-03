using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tic_Tac_Toe_Game_WPF
{
    /// <summary>
    /// Interaction logic for Login_Page.xaml
    /// </summary>
    public partial class Login_Page : Page
    {
        public static User second_user;
        public Login_Page()
        {
            InitializeComponent();
        }

        

        private void btn_Login1_Click(object sender, RoutedEventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Password;

            foreach (var user in UserRepositry.User_list)
            {
                if (username == user.Username && Convert.ToInt32(password) == user.User_pin)
                {
                    second_user = user;
                    this.NavigationService.Navigate(new Mainmenu());

                }
            }
        }
    }
}
