using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tubes_Software_Construction_BEN_ID
{
    class Parsing
    {

        public string NamaPenggguna { get; set; }
        public string Nomortelepon { get; set; }
        public string Email { get; set; }
    }
    public sealed partial class MainPage : Page
    {
        public object JsonConvert { get; private set; }
        public object email { get; private set; }
        public object namapengg { get; private set; }
        public object notelp { get; private set; }

        public MainPage()
        {
            NewMethod();
        }

        private void NewMethod()
        {
            NewMethod1();
        }

        private void NewMethod1()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Person person = new Person();
            person.NamaPengguna = namapengg.Text;
            person.Nomortelepon = notelp.Text;
            person.Email = email.Text;
            string json = JsonConvert.SerializeObject(
                person, Formatting.Indented);
        }
    }

}
