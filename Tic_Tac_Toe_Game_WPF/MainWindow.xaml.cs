﻿using System;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static User new_user;
        static int count = 0;
        UserRepositry user_repo = new UserRepositry();
        public MainWindow()
        {
            InitializeComponent();
            if (count == 0)
            {
                count++;
                user_repo.Load_users();
            }
        }

        public object NavigationService { get; private set; }

        private void btn_Login_Click(object sender, RoutedEventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Password;

            foreach (var user in UserRepositry.User_list)
            {
                if (username == user.Username && Convert.ToInt32(password) == user.User_pin)
                {
                    new_user = user;
                    stk_login_panel.Visibility = Visibility.Hidden;
                    Mainframe.NavigationService.Navigate(new Mainmenu());

                }
            }



        }

        private void btn_Registration_Click(object sender, RoutedEventArgs e)
        {
            stk_login_panel.Visibility = Visibility.Hidden;
            Mainframe.NavigationService.Navigate(new Registration());
        }

        private void btn_home_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
        }
    }
}
