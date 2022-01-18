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

namespace KYKY
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            manager.MainFrame = MainFrame;
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (BDKYKYEntities db = new BDKYKYEntities())
            {
                var users = db.Polzovat;
                foreach (Polzovat u in users)
                {
                    if (login.Text == Convert.ToString(u.log) && password.Text == Convert.ToString(u.pass))
                    {
                        MessageBox.Show("Вы вошли в систему");
                        if(u.znach == 3)
                        manager.MainFrame.Navigate(new PageStud(null));
                        if (u.znach == 1)
                            manager.MainFrame.Navigate(new PageDir());
                        if (u.znach == 2)
                            manager.MainFrame.Navigate(new PagePre());
                    }
                }
            }






            //manager.MainFrame.Navigate(new PageStud());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
