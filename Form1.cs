namespace listbox.task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void addbtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(countryTextbox.Text))
            {
                if (!countriesListbox.Items.Contains(countryTextbox.Text))
                {
                    countriesListbox.Items.Add(countryTextbox.Text);
                }
                else
                {
                    MessageBox.Show("This item already exists.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a country name.");
            }
        }

        private void removesinglebtn_Click(object sender, EventArgs e)
        {
            countriesListbox.Items.Remove(countriesListbox.SelectedItem);
        }
        private void countBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(countriesListbox.Items.Count.ToString());
        }
        private void clearlistBtn_Click(object sender, EventArgs e)
        {
            countriesListbox.Items.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
