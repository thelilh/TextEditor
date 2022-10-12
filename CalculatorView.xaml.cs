using System.Windows;
using System.Windows.Controls;

namespace TextEditor
{
    /// <summary>
    /// Interaction logic for CalculatorView.xaml
    /// </summary>
    public partial class CalculatorView : UserControl
    {
        public CalculatorView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button button)
            {
                MinText.Text += button.Content;
            }
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            if (e.Source is Button button)
            {
                MinText.Text = "";
            }
        }

        private void SumButton_Click(object sender, RoutedEventArgs e)
        {
            var expression = MinText.Text;

            var numbers = expression.Split('+');
            var num1 = int.Parse(numbers[0]);
            var num2 = int.Parse(numbers[1]);

            var sum = num1 + num2;

            MinText.Text = $"{sum}";
        }
    }
}
