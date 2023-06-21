using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_Game_WPF
{
    public class Coin
    {
        char _face_value;
        int _location;
        public char Face_value
        {
            get { return _face_value; }
        }
        public int Location
        {
            get { return Location; }
        }

        public Coin(char facevalue, int location)
        {
            this._face_value = facevalue;
            this._location = location;
        }
    }
}
