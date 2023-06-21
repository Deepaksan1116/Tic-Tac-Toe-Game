using Microsoft.Win32;
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
    /// Interaction logic for Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        User new_user = new User();
        UserRepositry user_repo = new UserRepositry();

        string file_path = string.Empty;
        public Registration()
        {
            InitializeComponent();
        }

      

        private void Open_File_MouseLeftButtonUp_1(object sender, MouseButtonEventArgs e)
        {
          
            OpenFileDialog openFileDlg = new OpenFileDialog();
            openFileDlg.Filter = "Image Files (*.png *.jpg *.bmp) |*.png; *.jpg;; *jpeg; *.bmp|All Files(*.*) |*.*";
            openFileDlg.Title = "Choose Image";
            openFileDlg.InitialDirectory = @"C:\";
            Nullable<bool> result = openFileDlg.ShowDialog();
            if (result == true)
            {
                string FileFrom = openFileDlg.FileName;
                var FilePath = FileFrom.Split('\\');

                file_path =openFileDlg.FileName;
             
                string FileName = FilePath[FilePath.Length - 1];

                Profile_picture.Source = new BitmapImage(new Uri(openFileDlg.FileName));
                //tempimg.BeginInit();
                //tempimg.UriSource = new Uri(FileFrom);
                //tempimg.EndInit();
                //CapImg.Source = tempimg;
                //SavedImage = tempimg;
                
            }
        }

        private void btn_save_Click(object sender, RoutedEventArgs e)
        {
            string name = Txtbox_Name.Text;
            string gmail = Txtbox_Gmail.Text;
            int password =Convert.ToInt32(Txtbox_Password.Text);
            string image = file_path;
            new_user = new User(name, password, gmail, 0, 0, 0, 0, 0, image);
            user_repo.Add_user(new_user);
        }
    }
}
