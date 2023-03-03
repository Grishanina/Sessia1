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

namespace Sessia1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public static string kod;
        public MainWindow()
        {
            InitializeComponent();
            ClassBase.BD = new Sessia_1Entities2();
        }

        private void Vhod_Click(object sender, RoutedEventArgs e)
        {
            Users UsersObject = ClassBase.BD.Users.FirstOrDefault(z => Convert.ToString(z.Phone) == number.Text);
            if (UsersObject == null)
            {
                MessageBox.Show("Не верно введен Номер телефона!");
            }
            else
            {
                Users UsersObject_1 = ClassBase.BD.Users.FirstOrDefault(z => z.Pass == pass.Text);
                if (UsersObject_1 == null)
                {
                    MessageBox.Show("Не верно введен Пароль!");

                    Random x = new Random();
                    int n = x.Next(1000, 9999);
                    kod = n.ToString();
                    MessageBox.Show(Convert.ToString(n));

                    if (kode.Text == kod)
                    {

                        switch (UsersObject.ID_role)
                        {
                            case 1:
                                MessageBox.Show("Здравствуйте, Руководитель отдела по работе с клиентами!");
                                break;
                            case 2:
                                MessageBox.Show("Здравствуйте, Менеджер по работе с клиентами!");
                                break;
                            case 3:
                                MessageBox.Show("Здравствуйте, Руководитель отдела технической поддержки!");
                                break;
                            case 4:
                                MessageBox.Show("Здравствуйте, Специалист технической поддержки!");
                                break;
                            case 5:
                                MessageBox.Show("Здравствуйте, Бухгалтер!");
                                break;
                            case 6:
                                MessageBox.Show("Здравствуйте, Директор по развитию!");
                                break;
                            case 7:
                                MessageBox.Show("Здравствуйте, Сотрудник технического департамента!");
                                break;
                            default:
                                break;
                        }
                    }
                }
                else
                {
                    switch (UsersObject.ID_role)
                    {
                        case 1:
                            MessageBox.Show("Здравствуйте, Руководитель отдела по работе с клиентами!");
                            break;
                        case 2:
                            MessageBox.Show("Здравствуйте, Менеджер по работе с клиентами!");
                            break;
                        case 3:
                            MessageBox.Show("Здравствуйте, Руководитель отдела технической поддержки!");
                            break;
                        case 4:
                            MessageBox.Show("Здравствуйте, Специалист технической поддержки!");
                            break;
                        case 5:
                            MessageBox.Show("Здравствуйте, Бухгалтер!");
                            break;
                        case 6:
                            MessageBox.Show("Здравствуйте, Директор по развитию!");
                            break;
                        case 7:
                            MessageBox.Show("Здравствуйте, Сотрудник технического департамента!");
                            break;
                        default:
                            break;
                    }
                }  
            }
        }

        private void Otmena_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
