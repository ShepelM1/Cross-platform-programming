namespace LW3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public int Fibonacci(int n)
        {
            if (n < 2) return n;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        private void CalculateFibonacci(object sender, EventArgs e)
        {
            if (int.TryParse(inputEntry.Text, out int n))
            {
                int result = Fibonacci(n);
                resultLabel.Text = $"Fibonacci({n}) = {result}";
            }
            else
            {
                resultLabel.Text = "Please enter a valid number.";
            }
            SemanticScreenReader.Announce("Hi");
        }
    }
}


