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
        board _temp_board;
        User _x_user;
        User round_winner;


        public User User_1
        {
            get { return _user_1; }
        }

        public User User_2
        {
            get { return _user_2; }
        }
        public board Temp_board
        {
            get { return _temp_board; }
        }
        public User X_user
        {
            get { return _x_user; }
        }

        public User Round_Winner
        {
            get { return round_winner; }
        }

        public Round()
        {

        }
        public Round(User user1, User user2, board _board, User x_user)
        {
            this._user_1 = user1;
            this._user_2 = user2;
            this._temp_board = _board;
            this._x_user = x_user;
            this.round_winner = Get_round_winner();
        }


        public User Get_round_winner()
        {
            if (Temp_board.Winning_statement() == 'X')
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
            else if (Temp_board.Winning_statement() == 'O')
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
