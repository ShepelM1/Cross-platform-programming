namespace LW4
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Hello_user(object sender, EventArgs e)
        {
            resultLabel.Text = "Hello, " + inputEntry.Text;
        }
    }
}
