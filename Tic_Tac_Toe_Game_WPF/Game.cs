using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_Game_WPF
{
    public class Game
    {
        int _game_id;
        static List<Round> Rounds = new List<Round>();
        

        User user1 = new User();
        User user2 = new User();

        public int Game_id
        {
            get { return _game_id; }
        }

       

        public Game()
        {

        }
        public Game(int game_id)
        {
            this._game_id = game_id;
        }


        public User Get_game_winner()
        {
            User winner_user;
            int user_1_count = 0;
            int user_2_count = 0;
            int Draw_count = 0;
            foreach (var item in Rounds)
            {
                if (item.Round_Winner.Username == item.User_1.Username)
                {
                    user_1_count++;
                    break;
                }
                else if (item.Round_Winner.Username == item.User_2.Username)
                {
                    user_2_count++;
                    break;
                }
                else
                {
                    Draw_count++;
                    break;

                }
            }
            Get_users();
            if (user_1_count > user_2_count)
            {
                winner_user = user1;
            }
            else if (user_1_count < user_2_count)
            {
                winner_user = user2;
            }
            else if (user_1_count == user_2_count)
            {
                winner_user = null;
            }
            else
            {
                winner_user = null;
            }
            return winner_user;
        }

        public void Get_users()
        {
            foreach (var item in Rounds)
            {
                user1 = item.User_1;
                user2 = item.User_2;
                break;
            }
        }
        public void Add_round(Round temp_round)
        {
            Rounds.Add(temp_round);
        }
    }

    public enum Score
    {
        win = 50,
        lose = -50,
        draw = 25,
    }

}
