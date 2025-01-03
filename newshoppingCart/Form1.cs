using System.ComponentModel;

namespace newshoppingCart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!chbcoffee.Checked)
            {
                tbCoffeePrice.Enabled = false;
                tbCoffeeQuantity.Enabled = false;

            }
            if (!chbgreentea.Checked)
            {
                tbGreenTeaPrice.Enabled = false;
                tbGreeTeaQuantity.Enabled = false;
            }

            //tbCoffeePrice.Text = "0";
            //tbCoffeeQuantity.Text = "0";
            //tbGreenTeaPrice.Text = "0";
            //tbGreeTeaQuantity.Text = "0";
            tbcash.Text = "0";
            tbchange.Text = "0";

        }
        private void Check_out_Click(object sender, EventArgs e)
        {
            string strcoffeep =  tbCoffeePrice.Text;
            string strcoffeeq =  tbCoffeeQuantity.Text;
            string strgreeteap = tbGreenTeaPrice.Text;
            string strgreeteaq = tbGreeTeaQuantity.Text;
            string strcash =     tbcash.Text;
            string strchange =   tbchange.Text;

            int icooffeep = 0;
            int icooffq = 0;
            int igreenteap = 0;
            int igreenteaq = 0;
            int icash = 0;
            int icchange = 0;

            try
            {
                if (chbcoffee.Checked)
                {
                    chbcoffee.Enabled = true;
                    icooffeep = int.Parse(strcoffeep);
                    icooffq = int.Parse(strcoffeeq);

                }
                else
                {
                    tbCoffeePrice.Enabled = false;
                }
                if (chbgreentea.Checked)
                {
                    igreenteap = int.Parse(strgreeteap);
                    igreenteaq = int.Parse(strgreeteaq);

                }
                if (tbcash.Created)
                {
                    icash = int.Parse(strcash);
                }
                if (tbchange.Created)
                {
                    icchange = int.Parse(strchange);
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

                icooffeep = 0;
                icooffq = 0;
                igreenteap = 0;
                igreenteaq = 0;
                icash = 0;
                icchange = 0;
            }

            int coff = icooffeep * icooffq;
            int greetea = igreenteaq * igreenteap;
            int sum = coff + greetea;
            total.Text = sum.ToString();
            int chage = icash - sum;
            tbchange.Text = chage.ToString();

            ///เก็บค่าเป็นศุนย์
            int thousand = 0;
            int five_hundred = 0;
            int one_hunred = 0;
            int fifty = 0;
            int twenty = 0;
            int ten = 0;
            int five = 0;
            int one = 0;
            // หารไม่เอาเศษ
            if (chage >= 1000)
            {
                thousand = chage / 1000;
                chage = chage % 1000;
                textBox1.Text = thousand.ToString();
            }
            if (chage >= 500)
            {
                five_hundred = chage / 500;
                chage = chage % 500;
                textBox9.Text = five_hundred.ToString();
            }
            if (chage >= 100)
            {
                one_hunred = chage / 100;
                chage = chage % 100;
                textBox10.Text = one_hunred.ToString();
            }
            if (chage >= 50)
            {
                fifty = chage / 50;
                chage = chage % 50;
                textBox11.Text = fifty.ToString();
            }
            if (chage >= 20)
            {
                twenty = chage / 20;
                chage = chage % 20;
                textBox12.Text = twenty.ToString();
            }
            if (chage >= 10)
            {
                ten = chage / 10;
                chage = chage % 10;
                textBox13.Text = ten.ToString();
            }
            if (chage >= 5)
            {
                five = chage / 5;
                chage = chage % 5;
                textBox14.Text = five.ToString();
            }
            if (chage >= 1)
            {
                one = chage / 1;
                chage = chage % 1;
                textBox15.Text = one.ToString();
            }







        }

        private void tbcash_TextChanged(object sender, EventArgs e)
        {



        }

        private void chbcoffee_CheckedChanged(object sender, EventArgs e)
        {
            if (chbcoffee.Checked)
            {
                tbCoffeePrice.Enabled = true;
                tbCoffeeQuantity.Enabled = true;
            }
        }

        private void chbgreentea_CheckedChanged(object sender, EventArgs e)
        {
            if (chbgreentea.Checked)
            {
                tbGreenTeaPrice.Enabled = true;
                tbGreeTeaQuantity.Enabled = true;
            }
        }

        private void tbGreenTeaPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCoffeePrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

