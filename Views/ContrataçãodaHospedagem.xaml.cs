namespace Hotel.Views
{
    public partial class ContrataçãodaHospedagem : ContentPage
    {
        public ContrataçãodaHospedagem()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Sobre());
        }
    }
}