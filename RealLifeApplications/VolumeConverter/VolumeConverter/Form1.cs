namespace VolumeConverter
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
                if (from.SelectedItem.ToString() == "Cubic meter" && to.SelectedItem.ToString() == "Liter") result.Text = (double.Parse(amount.Text) * 1000).ToString();
                else if (from.SelectedItem.ToString() == "Cubic meter" && to.SelectedItem.ToString() == "Millimeter") result.Text = (double.Parse(amount.Text) * 1000000).ToString();

                else if (from.SelectedItem.ToString() == "Liter" && to.SelectedItem.ToString() == "Cubic meter") result.Text = (double.Parse(amount.Text) / 1000).ToString();
                else if (from.SelectedItem.ToString() == "Liter" && to.SelectedItem.ToString() == "Millimeter") result.Text = (double.Parse(amount.Text) * 1000).ToString();

                else if (from.SelectedItem.ToString() == "Millimeter" && to.SelectedItem.ToString() == "Cubit meter") result.Text = (double.Parse(amount.Text) / 1000000).ToString();
                else if (from.SelectedItem.ToString() == "Millimeter" && to.SelectedItem.ToString() == "Liter") result.Text = (double.Parse(amount.Text) / 1000).ToString();
                else MessageBox.Show("Conversion not supported");
            }
        }
    }
}
