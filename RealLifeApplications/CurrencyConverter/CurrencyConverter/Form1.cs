namespace CurrencyConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            from.SelectedIndex = 0;
            to.SelectedIndex = 0;
        }

        private void convert_Click(object sender, EventArgs e)
        {
            if (from.Text == "Select Unit:" || to.Text == "Select Unit:") MessageBox.Show("Please select unit for conversion");
            else
            {
                if (from.Text == "USA" && to.Text == "Japan") result.Text = (double.Parse(amount.Text) * 109.86).ToString();
                else if (from.Text == "USA" && to.Text == "Brazil") result.Text = (double.Parse(amount.Text) * 5.36).ToString();
                else if (from.Text == "Japan" && to.Text == "USA") result.Text = (double.Parse(amount.Text) * 0.0091).ToString();
                else if (from.Text == "Japan" && to.Text == "Brazil") result.Text = (double.Parse(amount.Text) * 0.049).ToString();
                else if (from.Text == "Brazil" && to.Text == "USA") result.Text = (double.Parse(amount.Text) * 0.186).ToString();
                else if (from.Text == "Brazil" && to.Text == "Japan") result.Text = (double.Parse(amount.Text) * 20.52).ToString();
                else MessageBox.Show("Conversion not supported");
            }
        }
    }
}
