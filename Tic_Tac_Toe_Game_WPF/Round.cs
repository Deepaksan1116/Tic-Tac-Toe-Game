using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_Game_WPF
{
    public class Round
    {
        User _user_1;
        User _user_2;
       
        User _x_user;
        User round_winner;

        char _symbol;

       


        public User User_1
        {
            get { return _user_1; }
        }

        public User User_2
        {
            get { return _user_2; }
        }
       
        public User X_user
        {
            get { return _x_user; }
        }

        public User Round_Winner
        {
            get { return round_winner; }
        }

        public char Symbol
        {
            get { return _symbol; }
           
        }

        public Round()
        {

        }
        public Round(User user1, User user2, User x_user,char symbol)
        {
            this._user_1 = user1;
            this._user_2 = user2;
           
            this._x_user = x_user;
            this.round_winner = Get_round_winner();
            this._symbol = symbol;
        }


        public User Get_round_winner()
        {
            if (Symbol == 'X')
            {
                if (X_user.Username == User_1.Username)
                {
                    round_winner = User_1;
                }
                else
                {
                    round_winner = User_2;
                }

            }
            else if (Symbol == 'O')
            {
                if (X_user.Username != User_1.Username)
                {
                    round_winner = User_1;
                }
                else
                {
                    round_winner = User_2;
                }
            }

            return round_winner;
        }
    }
}
