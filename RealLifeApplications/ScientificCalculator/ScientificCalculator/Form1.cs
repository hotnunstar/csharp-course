namespace ScientificCalculator
{
    public partial class Form1 : Form
    {
        double resultValue = 0;
        string operationPerform = "";
        bool isOperationPerform = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((result.Text == "0") || (isOperationPerform)) result.Clear();

            isOperationPerform = false;
            Button button = (Button)sender;
            result.Text = result.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            isOperationPerform = true;
            operationPerform = button.Text;
            resultValue = Double.Parse(result.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            resultValue = 0;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            switch (operationPerform)
            {
                case "+":
                    result.Text = (resultValue + Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (resultValue - Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (resultValue * Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (resultValue / Double.Parse(result.Text)).ToString();
                    break;
                case "%":
                    double percentageValue = Double.Parse(result.Text);
                    result.Text = (resultValue * (percentageValue / 100)).ToString();
                    break;
                case "x^2":
                    result.Text = (Math.Pow(Double.Parse(result.Text), 2)).ToString();
                    break;
                case "log":
                    result.Text = Math.Log(Double.Parse(result.Text)).ToString();
                    break;
                case "e":
                    result.Text = Math.Exp(Double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
