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
    /// Interaction logic for User_Profile.xaml
    /// </summary>
    public partial class User_Profile : Page
    {

        UserRepositry user_repo = new UserRepositry();
       
        public User_Profile()
        {
            InitializeComponent();

            Show_user(Mainmenu.temp_count);

        }

        private void Show_user( int temp)
        {
            foreach (var user in UserRepositry.User_list)
            {
                if (temp == 1)
                {
                    if (MainWindow.new_user.Username == user.Username)
                    {
                        Grid1.DataContext = user;
                    }
                }
                else if (temp == 2)
                {
                    if (Login_Page.new_user.Username == user.Username)
                    {
                        Grid1.DataContext = user;
                    }
                }
            }
        }

        private void txt_back_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Mainmenu.count = 0;
            this.NavigationService.Navigate(new Mainmenu());
        }
    }
}
