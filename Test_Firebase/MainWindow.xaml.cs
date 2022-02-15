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
using FireSharp.Config;
using FireSharp;
using FireSharp.Response;

namespace Test_Firebase
{
    public class Zombie 
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Type { get; set; }
        public string LastKnownLocation { get; set; }
        public string Speciality { get; set; }
        public bool EatsBrains { get; set; }

    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        FirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "2rqh7TO2CYxfLdEU6GmoTGvko2dOdblxyf4M5sOb",
            BasePath = "https://test-1b80e-default-rtdb.firebaseio.com/"
        };
        FirebaseClient client;
        public MainWindow()
        {
            InitializeComponent();
            client = new FirebaseClient(config);
        }

        private async void BTN_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //SET DATA
                //await client.SetAsync("BrycesMom/data2", TXT.Text);
                //await client.PushAsync("BrycesMom/PushData", TXT.Text);
                //FirebaseResponse response = await client.GetAsync("Test/SetData");
                //string st = response.ResultAs<string>();
                Zombie zombie = new Zombie { Name = "Phil", Age = 234, Type = "Walking", LastKnownLocation = "Janitors Closet", Speciality = "Tank", EatsBrains = true};
                await client.SetAsync("DATA/Z2", zombie);
                MessageBox.Show("done.");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
