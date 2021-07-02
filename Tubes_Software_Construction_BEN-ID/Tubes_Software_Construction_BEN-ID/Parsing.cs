using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Newtonsoft.Json;
using System.Xml;
using Tubes_Software_Construction_BEN_ID;

namespace Tubes_Software_Construction_BEN_ID
{
    class parsing
    {
        public string NamaPengguna { get; set; }
        public string Email { get; set; }
        public string NomorTelepon { get; set; }
    }
}
public sealed partial class MainPage : Page
{
    private object email;

    public MainPage()
    {
        this.InitializeComponent();
    }

    private void InitializeComponent()
    {
        throw new NotImplementedException();
    }

    public object notelp { get; private set; }
    public object JsonConvert { get; private set; }
    public object namapengg { get; private set; }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        Person person = new Person();
        person.NamaPengguna = namapengg.Text;
        person.Email = email.Text;
        person.NomorTelepon = notelp.Text;
        string json = JsonConvert.SerializeObject(person, Formatting.Indented);
    }
}
