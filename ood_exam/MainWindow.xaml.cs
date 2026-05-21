using ood_june_exam.Data;
using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ood_june_exam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadMember();
        }

        public void LoadMember()
        {
            using (var db = new ClubData())
            {
                var allMember = db.Members
                    .OrderBy(m => m.Surname)
                    .ToList();
                ListBoxMembers.ItemsSource = allMember;
            }
        }

        public void ListBoxMembers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var SelectedMember = ListBoxMembers.SelectedItem as Member;
            if (SelectedMember != null)
            {
                using (var db = new ClubData())
                {
                    ListBoxSessions.ItemsSource = db.TrainingSessions
                        .Where(t => t.MemberId == SelectedMember.MemberId)
                        .OrderBy(t => t.SessionDate)
                        .ToList();
                }


                MemberId.Text = $"ID : {SelectedMember.MemberId}";
                MemberName.Text = $"First Name : {SelectedMember.FirstName}";
                MemberSurname.Text = $"Last Name : {SelectedMember.Surname}";
                MemberContactNumber.Text = $"Contact Number : {SelectedMember.ContactNumber}";
                Membership.Text = $"Membership Type : {SelectedMember.MembershipType}";
                MemberDOB.Text = $"DOB : {SelectedMember.DateOfBirth}";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var NewSessionWindow = new NewSession();
                NewSessionWindow.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("couldnt open the window");
            }
        }
    }
}