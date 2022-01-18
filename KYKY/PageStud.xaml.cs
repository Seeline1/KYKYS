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
    /// Логика взаимодействия для PageStud.xaml
    /// </summary>
    public partial class PageStud : Page
    {
        private stud _currentstud = new stud();

        public PageStud(stud selectedstud)
        {
            InitializeComponent();
            if (selectedstud != null)
                _currentstud = selectedstud;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtnome.Text = BDKYKYEntities.GetContext().stud.ToString();
        }
    }
}
