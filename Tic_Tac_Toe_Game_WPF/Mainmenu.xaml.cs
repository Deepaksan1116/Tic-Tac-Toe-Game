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
    /// Interaction logic for Mainmenu.xaml
    /// </summary>
    public partial class Mainmenu : Page
    {
        public static User user1;
        public static User user2;
        public static int Round_Count=0;
        public static int count = 0;
        public static int temp_count=0;
        public Mainmenu()
        {
            InitializeComponent();

            if (count == 0)
            {
                user1 = MainWindow.new_user;
                txt_playername_1.Text = user1.Username;
                btn_Userprofile_1.Content = user1.Username;
                count++;
                //btn_Resume.Visibility = Visibility.Collapsed;
                //btn_play.Margin = new Thickness(0, 80, 0, 0);
            }
            else if (count == 1)
            {
                btn_login.Visibility = Visibility.Hidden;
                user2 = Login_Page.second_user;
                txt_playername_1.Text = user1.Username;
                txt_playername_2.Text = user2.Username;
                btn_Userprofile_1.Content = user1.Username;
                btn_Userprofile_2.Content = user2.Username;
               // btn_Resume.Visibility = Visibility.Collapsed;
               // btn_play.Margin = new Thickness(0,80,0,0);
            }
            else if (count == 3)
            {
                btn_login.Visibility = Visibility.Hidden;
                user2 = Login_Page.second_user;
                txt_playername_1.Text = user1.Username;
                txt_playername_2.Text = user2.Username;
                btn_Userprofile_1.Content = user1.Username;
                btn_Userprofile_2.Content = user2.Username;
                //btn_Resume.Visibility = Visibility.Visible;
            }

        }

        private void btn_login_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Login_Page());
        }

        private void btn_play_Click(object sender, RoutedEventArgs e)
        {
            if (user2 != null)
            {
                int round=3;

                if (combobox1.SelectedItem == null)
                {

                    combobox1.Text = round.ToString();
                    Round_Count = round;
                    this.NavigationService.Navigate(new Board());
                }
                else
                {
                    string temp = combobox1.Text;
                    Round_Count = Convert.ToInt32(temp);
                    this.NavigationService.Navigate(new Board());
                }
            }
            else
            {
                MessageBox.Show("Please Login Player 2 After You Will Play");
            }
        }

        private void btn_Userprofile_1_Click(object sender, RoutedEventArgs e)
        {
            temp_count++;
            this.NavigationService.Navigate(new User_Profile());
        }

        private void btn_Userprofile_2_Click(object sender, RoutedEventArgs e)
        {
            temp_count++;
            this.NavigationService.Navigate(new User_Profile());
        }

        private void btn_Leaderboard_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new LeaderBoard());
        }

        private void btn_Resume_Click(object sender, RoutedEventArgs e)
        {

        }

      
    }
}
