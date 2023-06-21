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
        public List<User> Leader
        {
           get {return _leader; }
           set {_leader =value;}
        }
        public LeaderBoard()
        {
            InitializeComponent();
            //user_repo.Load_users();
            _leader = user_repo.Get_leader_board();
            Leaderlist.DataContext = this ;
        }

        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Mainmenu());
        }
    }
}
