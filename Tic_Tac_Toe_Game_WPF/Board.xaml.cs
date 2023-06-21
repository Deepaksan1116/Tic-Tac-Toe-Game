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
    /// Interaction logic for Board.xaml
    /// </summary>
    public partial class Board : Page
    {
        Coin[] coins = new Coin[9];
        board board1;
         char current_coin = 'X';
        static char winning_symbol = ' ';
        User user1;
        User user2;

        User x_user;
        User user;
        
        static int count = 0;
        int round_count = 0;
        int temp_round_count = 1;
        int total_rounds = Mainmenu.Round_Count;
        static int user1_winning_count = 0;
        static int user2_winning_count = 0;

        Round temp_round;
        Game new_game;

        UserRepositry user_repo = new UserRepositry();
        public Board()
        {
            InitializeComponent();
            user1 = Mainmenu.user1;
            user2 = Mainmenu.user2;

            txt_username_1.Text = user1.Username;
            txt_username_2.Text = user2.Username;

          

            txt_winning_username1.Text = user1.Username;
            txt_winning_username2.Text = user2.Username;

            txt_round_count.Text = "1";
            diagonal1.Visibility = Visibility.Hidden;
            diagonal2.Visibility = Visibility.Hidden;
            Columnlevel_1.Visibility = Visibility.Hidden;
            Columnlevel_2.Visibility = Visibility.Hidden;
            Columnlevel_3.Visibility = Visibility.Hidden;
            Rowlevel_1.Visibility = Visibility.Hidden;
            Rowlevel_2.Visibility = Visibility.Hidden;
            Rowlevel_3.Visibility = Visibility.Hidden;
        }

        private void Move_indication(int count)
        {
            if (x_user.Username == user1.Username)
            {
                if (count % 2 != 0)
                {
                    border_txt_username_1.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#14bdac"));
                    border_txt_username_2.BorderBrush = Brushes.White;
                }
                else
                {
                    border_txt_username_2.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#14bdac"));
                    border_txt_username_1.BorderBrush = Brushes.White;
                }
            }
            else
            {
                if (count % 2 != 0)
                {
                    border_txt_username_2.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#14bdac"));
                    border_txt_username_1.BorderBrush = Brushes.White;
                }
                else
                {
                    border_txt_username_1.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#14bdac"));
                    border_txt_username_2.BorderBrush = Brushes.White;
                }
            }
        }
        private void Get_Current_coin()
        {
            if (current_coin == 'X')
            {
                current_coin = 'O';
            }
            else
            {
                current_coin = 'X';
            }
        }

        private void load_chars()
        {
            for (int i = 0; i < 9; i++)
            {
                coins[i] = new Coin('-', i);
            }
        }

        private void Check_Winning_statement()
        {
            if (count >= 5)
            {
                board1 = new board(coins);
                winning_symbol = board1.Winning_statement();
                if (count == 9 && winning_symbol == 'D')
                {
                    temp_round = new Round(user1, user2, board1, x_user);
                    MessageBox.Show("Match is draw");
                    Game_rounds(temp_round);
                }
                else if (winning_symbol == 'X' || winning_symbol == 'O')
                {
                    temp_round = new Round(user1, user2, board1, x_user);
             
                    if (winning_symbol=='X')
                    {
                        if (x_user.Username == user1.Username)
                        {
                            user1_winning_count++;
                            txt_winning_count_user1.Text = user1_winning_count.ToString();
                        }
                        else
                        {
                            user2_winning_count++;
                            txt_winning_count_user2.Text = user2_winning_count.ToString();
                        }
                    }
                    else if (winning_symbol == 'O')
                    {
                        if (x_user.Username != user1.Username)
                        {
                            user1_winning_count++;
                            txt_winning_count_user1.Text = user1_winning_count.ToString();
                        }
                        else
                        {
                            user2_winning_count++;
                            txt_winning_count_user2.Text = user2_winning_count.ToString();
                        }
                       
                    }

                    line_visibility(board.Winning_position);
                    MessageBox.Show(winning_symbol + " Win the game");
                    Game_rounds(temp_round);
                }
            }
        }

        private void line_visibility(int win_position)
        {
            if (win_position == 1)
            {
                Rowlevel_1.Visibility = Visibility.Visible;
            }
            else if (win_position == 2)
            {
                Rowlevel_2.Visibility = Visibility.Visible;
            }
            else if (win_position == 3)
            {
                Rowlevel_3.Visibility = Visibility.Visible;
            }
            else if (win_position == 4)
            {
                Columnlevel_1.Visibility = Visibility.Visible;
            }
            else if (win_position == 5)
            {
                Columnlevel_2.Visibility = Visibility.Visible;
            }
            else if (win_position == 6)
            {
                Columnlevel_3.Visibility = Visibility.Visible;
            }
            else if (win_position == 7)
            {
                diagonal1.Visibility = Visibility.Visible;
            }
            else if (win_position == 8)
            {
                diagonal2.Visibility = Visibility.Visible;
            }
        }

        private void Game_rounds(Round tempround)
        {
            if (round_count <= total_rounds)
            {
                new_game = new Game();
                new_game.Add_round(temp_round);

                diagonal1.Visibility = Visibility.Hidden;
                diagonal2.Visibility = Visibility.Hidden;
                Columnlevel_1.Visibility = Visibility.Hidden;
                Columnlevel_2.Visibility = Visibility.Hidden;
                Columnlevel_3.Visibility = Visibility.Hidden;
                Rowlevel_1.Visibility = Visibility.Hidden;
                Rowlevel_2.Visibility = Visibility.Hidden;
                Rowlevel_3.Visibility = Visibility.Hidden;

                text1.Text = string.Empty;
                text2.Text = string.Empty;
                text3.Text = string.Empty;
                text4.Text = string.Empty;
                text5.Text = string.Empty;
                text6.Text = string.Empty;
                text7.Text = string.Empty;
                text8.Text = string.Empty;
                text9.Text = string.Empty;
                count = 0;
                current_coin = 'X';
                load_chars();
                round_count++;
                temp_round_count++;
                txt_round_count.Text = temp_round_count.ToString();
                Give_coin();

            }
            if (round_count == total_rounds)
            {
                User winner_user = new User();
                winner_user = new_game.Get_game_winner();
                txt_round_count.Text = "";
                if (user1.Username == winner_user.Username)
                {

                    Score enum_score = (Score)Enum.Parse(typeof(Score), "win");
                    int score = user_repo.get_user_score(user1.Username) + Convert.ToInt32(enum_score);
                    int total_match = user_repo.get_user_total_match_count(user1.Username) + 1;
                    int winning_match = user_repo.get_user_winning_match_count(user1.Username) + 1;
                    User new_user = new User(user1.Username, user1.User_pin, user1.Email_id, score, total_match, winning_match, user1.Losing_matches, user1.Draw_matches);
                    new_user.Edit_match_detail(new_user);

                    Score enum_score_lose = (Score)Enum.Parse(typeof(Score), "lose");
                    int lose_score = user_repo.get_user_score(user2.Username) + Convert.ToInt32(enum_score_lose);
                    int lose_total_match = user_repo.get_user_total_match_count(user2.Username) + 1;
                    int lose_match = user_repo.get_user_losing_match_count(user2.Username) + 1;
                    User lose_user = new User(user2.Username, user2.User_pin, user2.Email_id, lose_score, lose_total_match, user2.Winning_matches, lose_match, user2.Draw_matches);
                    lose_user.Edit_match_detail(lose_user);
                }
                else if (user2.Username == winner_user.Username)
                {
                    Score enum_score = (Score)Enum.Parse(typeof(Score), "win");
                    int score = user_repo.get_user_score(user2.Username) + Convert.ToInt32(enum_score);
                    int total_match = user_repo.get_user_total_match_count(user2.Username) + 1;
                    int winning_match = user_repo.get_user_winning_match_count(user2.Username) + 1;
                    User new_user = new User(user2.Username, user2.User_pin, user2.Email_id, score, total_match, winning_match, user2.Losing_matches, user2.Draw_matches);
                    new_user.Edit_match_detail(new_user);

                    Score enum_score_lose = (Score)Enum.Parse(typeof(Score), "lose");
                    int lose_score = user_repo.get_user_score(user1.Username) + Convert.ToInt32(enum_score_lose);
                    int lose_total_match = user_repo.get_user_total_match_count(user1.Username) + 1;
                    int lose_match = user_repo.get_user_losing_match_count(user1.Username) + 1;
                    User lose_user = new User(user1.Username, user1.User_pin, user1.Email_id, lose_score, lose_total_match, user1.Winning_matches, lose_match, user1.Draw_matches);
                    lose_user.Edit_match_detail(lose_user);
                }
                else
                {
                    Score enum_score = (Score)Enum.Parse(typeof(Score), "draw");
                    int user1_score = user_repo.get_user_score(user1.Username) + Convert.ToInt32(enum_score);
                    int user1_total_match = user_repo.get_user_total_match_count(user1.Username) + 1;
                    int user1_draw_match = user_repo.get_user_winning_match_count(user1.Username) + 1;
                    User draw_user1 = new User(user1.Username, user1.User_pin, user1.Email_id, user1_score, user1_total_match, user1.Winning_matches, user1.Losing_matches, user1_draw_match);
                    draw_user1.Edit_match_detail(draw_user1);


                    int user2_score = user_repo.get_user_score(user2.Username) + Convert.ToInt32(enum_score);
                    int user2_total_match = user_repo.get_user_total_match_count(user2.Username) + 1;
                    int user2_draw_match = user_repo.get_user_losing_match_count(user2.Username) + 1;
                    User draw_user2 = new User(user2.Username, user2.User_pin, user2.Email_id, user2_score, user2_total_match, user2.Winning_matches, user2.Losing_matches, user2_draw_match);
                    draw_user2.Edit_match_detail(draw_user2);
                }

                Grid_panel.Visibility = Visibility.Hidden;
                MessageBox.Show(winner_user.Username.ToString());
                this.NavigationService.Navigate(new Mainmenu());
            }
        }

        private void Give_coin()
        {
            if (x_user.Username == user1.Username)
            {
                x_user = user2;
                txt_user2_symbol.Text = "X";
                txt_user1_symbol.Text = "O";
            }
            else
            {
                x_user = user1;
                txt_user2_symbol.Text = "O";
                txt_user1_symbol.Text = "X";
            }
        }

        private void Border1_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

            if (text1.Text == string.Empty)
            {
                if (current_coin == 'X')
                { 

                    text1.Foreground = Brushes.Black;
                }
                else
                {
                   text1.Foreground = Brushes.White;
                }
                text1.Text = current_coin.ToString();
                coins[0] = new Coin(current_coin, 0);
                count++;
                Move_indication(count);
                Get_Current_coin();
                Check_Winning_statement();

            }
        }

        private void Border2_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

            if (text2.Text == string.Empty)
            {
                if (current_coin == 'X')
                {

                    text2.Foreground = Brushes.Black;
                }
                else
                {
                    text2.Foreground = Brushes.White;
                }
                text2.Text = current_coin.ToString();
                    coins[1] = new Coin(current_coin, 1);
                    count++;
                Move_indication(count);
                Get_Current_coin();
                    Check_Winning_statement();

            }
        }

        private void Border3_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (text3.Text == string.Empty)
            {

                if (current_coin == 'X')
                {

                    text3.Foreground = Brushes.Black;
                }
                else
                {
                    text3.Foreground = Brushes.White;
                }
                text3.Text = current_coin.ToString();
                coins[2] = new Coin(current_coin, 2);
                count++;
                Move_indication(count);
                Get_Current_coin();
                Check_Winning_statement();

            }
        }

        private void Border4_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

            if (current_coin == 'X')
            {

                text4.Foreground = Brushes.Black;
            }
            else
            {
                text4.Foreground = Brushes.White;
            }

            if (text4.Text == string.Empty)
            {
                
                text4.Text = current_coin.ToString();
                coins[3] = new Coin(current_coin, 3);
                count++;
                Move_indication(count);
                Get_Current_coin();
                Check_Winning_statement();

            }
        }

        private void Border5_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

            if (current_coin == 'X')
            {

                text5.Foreground = Brushes.Black;
            }
            else
            {
                text5.Foreground = Brushes.White;
            }

            if (text5.Text == string.Empty)
            { 

                text5.Text = current_coin.ToString();
                coins[4] = new Coin(current_coin, 4);
                count++;
                Move_indication(count);
                Get_Current_coin();
                Check_Winning_statement();
            }
                
            
        }

        private void Border6_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

            if (text6.Text == string.Empty)
            {
                if (current_coin == 'X')
                {

                    text6.Foreground = Brushes.Black;
                }
                else
                {
                    text6.Foreground = Brushes.White;
                }

                text6.Text = current_coin.ToString();
                coins[5] = new Coin(current_coin, 5);
                count++;
                Move_indication(count);
                Get_Current_coin();
                Check_Winning_statement();
            }
        }

        private void Border7_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

            if (text7.Text == string.Empty)
            {

                if (current_coin == 'X')
                {

                    text7.Foreground = Brushes.Black;
                }
                else
                {
                    text7.Foreground = Brushes.White;
                }

                text7.Text = current_coin.ToString();
                coins[6] = new Coin(current_coin, 6);
                count++;
                Move_indication(count);
                Get_Current_coin();
                Check_Winning_statement();

            }
        }

        private void Border8_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

            if (text8.Text == string.Empty)
            {
                if (current_coin == 'X')
                {

                    text8.Foreground = Brushes.Black;
                }
                else
                {
                    text8.Foreground = Brushes.White;
                }
                text8.Text = current_coin.ToString();
                coins[7] = new Coin(current_coin, 7);
                count++;
                Move_indication(count);
                Get_Current_coin();
                Check_Winning_statement();
            }
        }

        private void Border9_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

            if (text9.Text == string.Empty)
            {
                if (current_coin == 'X')
                {

                    text9.Foreground = Brushes.Black;
                }
                else
                {
                    text9.Foreground = Brushes.White;
                }
                text9.Text = current_coin.ToString();
                coins[8] = new Coin(current_coin, 8);
                count++;
                Move_indication(count);
                Get_Current_coin();
                Check_Winning_statement();
            }
        }

        private void btn_toss_Click(object sender, RoutedEventArgs e)
        {
            
            Random rand = new Random();
            int number = rand.Next(1, 3);
            if (number == 1)
            {
                x_user = user1;
                border_txt_username_1.BorderBrush= new SolidColorBrush((Color)ColorConverter.ConvertFromString("#14bdac"));

            }
            else
            {
                x_user = user2;
                border_txt_username_1.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#14bdac"));
            }
            if (x_user.Username == user1.Username)
            {
                txt_user1_symbol.Text = "X";
            }
            else
            {
                txt_user2_symbol.Text = "X";
            }
            if (txt_user1_symbol.Text == "X")
            {
                txt_user2_symbol.Text = "O";
            }
            else
            {
                txt_user1_symbol.Text = "O";
            }
            btn_toss.Visibility = Visibility.Hidden;
        }

        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Mainmenu());
        }
    }
}
