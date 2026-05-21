using ood_june_exam.Data;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ood_june_exam
{
    /// <summary>
    /// Interaction logic for NewSession.xaml
    /// </summary>
    public partial class NewSession : Window
    {
        public NewSession()
        {
            InitializeComponent();
        }

        public void NewSessionCreation()
        {
            using(var db = new ClubData())
            {
                TrainingSession newtrainingS = new TrainingSession
                {


                };
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

       
    }
}
