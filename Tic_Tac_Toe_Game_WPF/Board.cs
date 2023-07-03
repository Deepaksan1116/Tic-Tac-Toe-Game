using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_Game_WPF
{
    public class board
    {
        Coin[] coins = new Coin[9];
        public static int Winning_position = 0;
        char _current_player;

        public char Current_player
        {
            get { return _current_player; }
           
        }

        public Coin[] Coins
        {
            get { return coins; }
        }
        public board()
        {

        }
        public board(Coin[] temp_coins,char currentplayer)
        {
            this.coins = temp_coins;
            this._current_player = currentplayer;
        }

       

        public char Winning_statement()
        {
            char winning_symbol = 'D';
          

            if (coins[0].Face_value == Current_player && coins[1].Face_value == Current_player && coins[2].Face_value==Current_player)
            {
                winning_symbol = coins[0].Face_value;
                Winning_position = 1;
            }
            else if (coins[3].Face_value == Current_player && coins[4].Face_value == Current_player &&  coins[5].Face_value ==Current_player)
            {
                winning_symbol = coins[3].Face_value;
                Winning_position = 2;

            }
            else if (coins[6].Face_value == Current_player && coins[7].Face_value==Current_player && coins[8].Face_value ==Current_player)
            {
                winning_symbol = coins[6].Face_value;
                Winning_position = 3;

            }
            else if (coins[0].Face_value == Current_player && coins[3].Face_value== Current_player && coins[6].Face_value==Current_player)
            {
                winning_symbol = coins[0].Face_value;
                Winning_position = 4;

            }
            else if (coins[1].Face_value == Current_player && coins[4].Face_value == Current_player && coins[7].Face_value == Current_player)
            {
                winning_symbol = coins[1].Face_value;
                Winning_position = 5;

            }
            else if (coins[2].Face_value == Current_player && coins[5].Face_value==Current_player &&coins[8].Face_value ==Current_player)
            {
                winning_symbol = coins[2].Face_value;
                Winning_position = 6;
            }
            else if (coins[0].Face_value == Current_player && coins[4].Face_value==Current_player && coins[8].Face_value ==Current_player)
            {
                winning_symbol = coins[0].Face_value;
                Winning_position = 7;

            }
            else if (coins[2].Face_value == Current_player && coins[4].Face_value == Current_player &&coins[6].Face_value ==Current_player)
            {
                winning_symbol = coins[2].Face_value;
                Winning_position = 8;
            }

            return winning_symbol;
        }
    }
}
