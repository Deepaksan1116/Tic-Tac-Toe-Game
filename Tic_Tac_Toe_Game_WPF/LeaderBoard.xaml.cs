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
    /// Interaction logic for LeaderBoard.xaml
    /// </summary>
    public partial class LeaderBoard : Page
    {
        UserRepositry user_repo = new UserRepositry();
         List<User> _leader = new List<User>();

         static int temp = 0;
        
        public List<User> Leader
        {
           get {return _leader; }
           set {_leader =value;}
        }
        public LeaderBoard()
        {
            InitializeComponent();
          
            _leader = user_repo.Get_leader_board();
            Leaderlist.ItemsSource = Leader;
        }

        

        private void btn_back_Click_1(object sender, RoutedEventArgs e)
        {
           
            if (temp==0)
            {
                Mainmenu.count = 0;
                temp = 1;
                this.NavigationService.Navigate(new Mainmenu());
            }
            else if (Mainmenu.count==1)
            {
                Mainmenu.count = 1;
                this.NavigationService.Navigate(new Mainmenu());
            }
        }
    }
}
