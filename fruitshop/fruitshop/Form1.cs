namespace fruitshop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            total.Text = "0";
            Money.Text = "0";
            Change.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int apple = 0;
            int mixed = 0;
            int banana = 0;
            int money = 0;

            try
            {
                if (tbAppleJuice.Checked)
                {
                    apple = 20;
                }
                if (tbMixedfruitjuice.Checked)
                {
                    mixed = 20;
                }
                if (tbBananajuice.Checked)
                {
                    banana = 25;
                }
                if (!string.IsNullOrWhiteSpace(Money.Text) && int.TryParse(Money.Text, out money))
                {

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                apple = 0;
                mixed = 0;
                banana = 0;

            }

            int sum = apple + mixed + banana;
            total.Text = sum.ToString();
            int changee = sum - money;
            int changeee = changee;            Change.Text = changee.ToString();


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
