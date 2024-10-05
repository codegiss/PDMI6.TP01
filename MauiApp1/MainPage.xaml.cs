using System.Text;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        // Giselle Souza - CB3020339
        // Lucas Gomes - CB3021777

        private async void Login(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EntryID.Text) || string.IsNullOrWhiteSpace(EntryPassword.Text))
            {
                await DisplayAlert("Aviso", "Insira o login e a senha", "OK");
                return;
            }                

            if (EntryID.Text == "admin" && EntryPassword.Text == "senha@dmin")
                await DisplayAlert("Sucesso", "Login realizado com sucesso", "OK");
            else
                await DisplayAlert("Falha", "Login não autorizado", "OK");
        }
        private void Clean(object sender, EventArgs e)
        {
            EntryID.Text = "";
            EntryPassword.Text = "";
            EntryID.Focus();
        }
        private async void Credits(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Giselle Souza - CB3020339 \n");
            sb.Append("Lucas Gomes - CB3021777");

            await DisplayAlert("Créditos", sb.ToString(), "OK");
        }
    }

}
