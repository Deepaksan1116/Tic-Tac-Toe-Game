using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Tic_Tac_Toe_Game_WPF
{
    public class User
    {
        string _username;
        int _user_pin;
        string _email_id;
        int _score;
        int _total_matches;
        int _winning_matches;
        int _losing_matches;
        int _draw_matches;

        string _image;


        public string Username
        {
            get { return _username; }
        }
        public int User_pin
        {
            get { return _user_pin; }
        }
        public string Email_id
        {
            get { return _email_id; }
        }

        public int Score
        {
            get { return _score; }
        }
        public int Total_matches
        {
            get { return _total_matches; }
        }
        public int Winning_matches
        {
            get { return _winning_matches; }
        }
        public int Losing_matches
        {
            get { return _losing_matches; }
        }
        public int Draw_matches
        {
            get { return _draw_matches; }
        }

        public string Image
        {
            get { return _image; }
        }
        public User()
        {

        }
        public User(string _Username, int _userpin, string _Emailid, int score, int total_matches, int winning_matches, int losing_matches, int draw_matches,string image)
        {
            if (_Username.Length >= 5 && _Username.Length <= 15)
            {
                this._username = _Username;
            }
            else
            {
                throw new ArgumentException("Invalid Username. Username must be between 5 and 15");
            }
            if (_userpin >= 1000 && _userpin <= 9999)
            {
                this._user_pin = _userpin;
            }
            else
            {
                throw new ArgumentException("Invalid Pin. Pin must be in 4");

            }
            this._email_id = _Emailid;
            this._score = score;
            this._total_matches = total_matches;
            this._winning_matches = winning_matches;
            this._losing_matches = losing_matches;
            this._draw_matches = draw_matches;
            this._image = image;

        }

        public User(string _Username)
        {
            this._username = _Username;
        }

        public User(string _Username, int _userpin, string _Emailid, int score, int total_matches, int winning_matches, int losing_matches, int draw_matches)
        {
            this._username = _Username;
            this._user_pin = _userpin;
            this._email_id = _Emailid;
            this._score = score;
            this._total_matches = total_matches;
            this._winning_matches = winning_matches;
            this._losing_matches = losing_matches;
            this._draw_matches = draw_matches;
        }
        public void Edit_Photo(User temp_user)
        {
            User alter_user = new User();
            UserRepositry user_repo = new UserRepositry();
            alter_user = user_repo.Get_user(temp_user);

        }

        public void Edit_match_detail(User temp_user)
        {
            User alter_user = new User();

            foreach (var user in UserRepositry.User_list)
            {
                if (user.Username == temp_user.Username)
                {
                    alter_user = new User(user.Username, user.User_pin, user.Email_id, temp_user.Score, temp_user.Total_matches, temp_user.Winning_matches, temp_user.Losing_matches, temp_user.Draw_matches,temp_user.Image);
                    break;
                }
            }
            UserRepositry user_repo = new UserRepositry();
            user_repo.Edit_user(alter_user);

        }
    }
}
