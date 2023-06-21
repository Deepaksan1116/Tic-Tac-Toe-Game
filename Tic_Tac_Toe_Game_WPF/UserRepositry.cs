using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_Game_WPF
{
    public class UserRepositry
    {

        public static Dictionary<string, User> Users = new Dictionary<string, User>();
        public static List<User> User_list = new List<User>();
        string filepath = @"D:\Tic_Tac_Toe_Game\Users\user.txt";
        public void Load_users()
        {
            string[] filecontent = File.ReadAllLines(filepath);
            foreach (var item in filecontent)
            {
                string[] item_value = item.Split('|');
                User temp_user = new User(item_value[0], Convert.ToInt32(item_value[1]), item_value[2], Convert.ToInt32(item_value[3]),
                Convert.ToInt32(item_value[4]), Convert.ToInt32(item_value[5]), Convert.ToInt32(item_value[6]), Convert.ToInt32(item_value[7]),item_value[8]);
                Users.Add(item_value[0], temp_user);
                User_list.Add(temp_user);
            }
        }
        public void Add_user(User temp_user)
        {
            string content = string.Empty;
            StreamWriter sw = new StreamWriter(filepath, true);
            content = temp_user.Username + "|" + temp_user.User_pin + "|" + temp_user.Email_id + "|"
           + temp_user.Score + "|" + temp_user.Total_matches + "|" + temp_user.Winning_matches + "|" + temp_user.Losing_matches + "|" + temp_user.Draw_matches + "|" +temp_user.Image;
            sw.WriteLine(content);
            sw.Close();
            User_list.Add(temp_user);
            Users.Add(temp_user.Username, temp_user);
        }
        public void Edit_user(User temp_user)
        {
            int temp_index = 0;
            foreach (var user in User_list)
            {
                if (temp_user.Username == user.Username)
                {
                    User_list.RemoveAt(temp_index);
                    User_list.Insert(temp_index, temp_user);
                    Write_all_users();
                    Users.Clear();
                    User_list.Clear();
                    Load_users();
                    break;
                }
                temp_index++;
            }
        }

        public User Get_user(User temp_user)
        {
            User user = new User();
            if (Users.ContainsKey(temp_user.Username))
            {
                user = Users[temp_user.Username];
            }
            return user;
        }
        public void Write_all_users()
        {
            string content = string.Empty;
            StreamWriter sw = new StreamWriter(filepath);
            foreach (var user in User_list)
            {
                content = user.Username + "|" + user.User_pin + "|" + user.Email_id +
                          "|" + user.Score + "|" + user.Total_matches + "|" + user.Winning_matches + "|" + user.Losing_matches + "|" + user.Draw_matches;
                sw.WriteLine(content);
            }
            sw.Close();
        }

        public int get_user_score(string username)
        {
            User user = new User();
            int score = 0;
            if (Users.ContainsKey(username))
            {
                user = Users[username];
                score = user.Score;
            }
            return score;
        }

        public int get_user_total_match_count(string username)
        {
            User user = new User();
            int total_match_count = 0;
            if (Users.ContainsKey(username))
            {
                user = Users[username];
                total_match_count = user.Total_matches;
            }
            return total_match_count;
        }
        public int get_user_winning_match_count(string username)
        {
            User user = new User();
            int winning_match_count = 0;
            if (Users.ContainsKey(username))
            {
                user = Users[username];
                winning_match_count = user.Winning_matches;
            }
            return winning_match_count;
        }

        public int get_user_losing_match_count(string username)
        {
            User user = new User();
            int losing_match_count = 0;
            if (Users.ContainsKey(username))
            {
                user = Users[username];
                losing_match_count = user.Losing_matches;
            }
            return losing_match_count;
        }
        public int get_user_draw_match_count(string username)
        {
            User user = new User();
            int draw_match_count = 0;
            if (Users.ContainsKey(username))
            {
                user = Users[username];
                draw_match_count = user.Draw_matches;
            }
            return draw_match_count;
        }

        public string Make_Leader_Board()
        {
            string str = string.Empty;
            int count = 0;
            int temp_count = 0;
            int min_score = Get_min_score();
            int highest_score = min_score;
            int temp_score = 0;
            User new_user = new User();
            str = "Rank" + "\t" + "User Name" + "\t" + "score" + "\n" + "\n";

            while (count != User_list.Count)
            {
                if (temp_count == 0)
                {
                    foreach (var user in User_list)
                    {
                        if (user.Score > highest_score)
                        {
                            highest_score = user.Score;
                            temp_score = highest_score;
                            temp_count++;
                            new_user = user;
                        }

                    }
                }
                else if (temp_count > 0)
                {
                    highest_score = min_score;
                    foreach (var user in User_list)
                    {
                        if (user.Score >= highest_score && user.Score < temp_score)
                        {
                            highest_score = user.Score;
                            temp_score = highest_score;
                            new_user = user;
                        }
                    }
                }

                str += count + "\t" + new_user.Username + "\t" + "\t" + new_user.Score + "\n";
                count++;
            }
            return str;
        }

        public int Get_min_score()
        {
            int min_score = 2147483647;
            foreach (var user in User_list)
            {
                if (user.Score < min_score)
                {
                    min_score = user.Score;
                }
            }

            return min_score;
        }

        public List<User> Get_leader_board()
        {
            var sortlist = User_list.OrderByDescending(o => o.Score).ToList();
            //var descending = sortlist.OrderByDescending(i => i);


            return sortlist;
        }
    }
}
