using System.ComponentModel.Design.Serialization;
using System.Security.Policy;

namespace shoppingnewprojectgatnew
{
    public partial class POS : Form
    {
        public POS()
        {
            InitializeComponent();

            if (!chbCoffee.Checked)
            {
                CoffeePrice.Enabled = false;
                CoffeeQuantity.Enabled = false;
            }
            if (!chbgreetea.Checked)
            {
                GreenTeaPrice.Enabled = false;
                GreeTeaQuantity.Enabled = false;
            }
            if (!chbnoodle.Checked)
            {
                NoodlePrice.Enabled = false;
                NoodleQuantity.Enabled = false;
            }
            if (!chbpizza.Checked)
            {
                PizzaPrice.Enabled = false;
                PizzaQuantity.Enabled = false;
            }
            if (!chall.Checked)
            {
                tball.Enabled = false;
            }
            if (!checkbeverage.Checked)
            {
                tbbeverage.Enabled = false;
            }
            if (!chcekfood.Checked)
            {
                tbfood.Enabled = false;
            }
            tbtotal.Text = "0";
            tbcash.Text = "0";
            change.Text = "0";
            textBox1000.Text = "0";
            textBox500.Text = "0";
            textBox100.Text = "0";
            textBox50.Text = "0";
            textBox20.Text = "0";
            textBox20.Text = "0";
            textBox10.Text = "0";
            textBox5.Text = "0";
            textBox1.Text = "0";


        }



        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void check_out_Click(object sender, EventArgs e)
        {
            string strcoffeep = CoffeePrice.Text;
            string strcoffeeq = CoffeeQuantity.Text;
            string strgreenteap = GreenTeaPrice.Text;
            string strgreenteaq = GreeTeaQuantity.Text;
            string strnoodlep = NoodlePrice.Text;
            string strnoodleq = NoodleQuantity.Text;
            string strpizzap = PizzaPrice.Text;
            string strpizzaq = PizzaQuantity.Text;
            string strcash = tbcash.Text;
            string strchange = change.Text;

            int icoffeep = 0;
            int icoffeeq = 0;
            int igreenteap = 0;
            int igreenteaq = 0;
            int cashh = 0;
            int Changee = 0;
            int noodlep = 0;
            int noodleq = 0;
            int pizzap = 0;
            int pizzaq = 0;
            double allf_b = 0, dev = 0, food = 0;

            try
            {
                if (chbCoffee.Checked)
                {
                    icoffeep = int.Parse(strcoffeep);
                    icoffeeq = int.Parse(strcoffeeq);
                }
                if (chbgreetea.Checked)
                {
                    igreenteap = int.Parse(strgreenteap);
                    igreenteaq = int.Parse(strgreenteaq);
                }
                if (chbnoodle.Checked)
                {
                    noodlep = int.Parse(strnoodlep);
                    noodleq = int.Parse(strnoodleq);
                }
                if (chbpizza.Checked)
                {
                    pizzap = int.Parse(strpizzap);
                    pizzaq = int.Parse(strpizzaq);
                }
                if (tbcash.Created)
                {
                    cashh = int.Parse(strcash);
                }
                if (change.Created)
                {
                    Changee = int.Parse(strchange);
                }
                if (chcekfood.Checked)
                {
                    tball.Enabled = true;
                    tball.Enabled = true;
                }
                if (!chcekfood.Checked)
                {
                    tball.Enabled = false;
                    tball.Enabled = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());

                icoffeep = 0;
                icoffeeq = 0;
                igreenteap = 0;
                igreenteaq = 0;
                cashh = 0;
                Changee = 0;
                noodlep = 0;
                noodleq = 0;
                pizzap = 0;
                pizzaq = 0;


            }
            int coff = icoffeep * icoffeeq;
            int greetea = igreenteap * igreenteaq;
            int noodlee = noodlep * noodleq;
            int pizza = pizzap * pizzaq;
            int sum = coff + greetea + noodlee + pizza;
            int chage = cashh - sum;
            double discountAmount = 0;
            try
            {
                if (chall.Checked)
                {
                    allf_b = double.Parse(tball.Text) / 100.0;
                }
                if (checkbeverage.Checked)
                {
                    dev = double.Parse(tbbeverage.Text) / 100.0;
                }
                if (chcekfood.Checked)
                {
                    food = double.Parse(tbfood.Text) / 100.0;
                }
            }
            catch
            {
                MessageBox.Show("ส่วนลดของลูกค้าไม่ถูกต้อง");
                return;
            }
            if (chall.Checked)
            {
                discountAmount = sum * allf_b;
            }
            else
            {
                discountAmount += (coff + greetea) * dev;
                discountAmount += (noodlee + pizza) * food;
            }
            sum = (int)(sum - discountAmount);
            if (sum < 0) sum = 0;

            tbtotal.Text = sum.ToString();

            int changeAmount = cashh - sum;
            change.Text = changeAmount.ToString();


            int thousand = 0;
            int five_hundred = 0;
            int one_hunred = 0;
            int fifty = 0;
            int twenty = 0;
            int ten = 0;
            int five = 0;
            int one = 0;

            if (chage >= 1000)
            {
                thousand = chage / 1000;
                chage = chage % 1000;
                textBox1000.Text = thousand.ToString();
            }
            if (chage >= 500)
            {
                five_hundred = chage / 500;
                chage = chage % 500;
                textBox500.Text = five_hundred.ToString();
            }
            if (chage >= 100)
            {
                one_hunred = chage / 100;
                chage = chage % 100;
                textBox100.Text = one_hunred.ToString();
            }
            if (chage >= 50)
            {
                fifty = chage / 50;
                chage = chage % 50;
                textBox50.Text = fifty.ToString();
            }
            if (chage >= 20)
            {
                twenty = chage / 20;
                chage = chage % 20;
                textBox20.Text = twenty.ToString();
            }
            if (chage >= 10)
            {
                ten = chage / 10;
                chage = chage % 10;
                textBox10.Text = ten.ToString();
            }
            if (chage >= 5)
            {
                five = chage / 5;
                chage = chage % 5;
                textBox10.Text = five.ToString();
            }
            if (chage >= 1)
            {
                one = chage / 1;
                chage = chage % 1;
                textBox1.Text = one.ToString();
            }


        }

        private void chbCoffee_CheckedChanged(object sender, EventArgs e)
        {
            if (chbCoffee.Checked)
            {
                CoffeePrice.Enabled = true;
                CoffeeQuantity.Enabled = true;
            }
            if (!chbCoffee.Checked)
            {
                CoffeePrice.Enabled = false;
                CoffeeQuantity.Enabled = false;
            }

        }

        private void chbgreetea_CheckedChanged(object sender, EventArgs e)
        {
            if (chbgreetea.Checked)
            {
                GreenTeaPrice.Enabled = true;
                GreeTeaQuantity.Enabled = true;
            }
            if (!chbgreetea.Checked)
            {
                GreenTeaPrice.Enabled = false;
                GreeTeaQuantity.Enabled = false;
            }

        }

        private void chbnoodle_CheckedChanged(object sender, EventArgs e)
        {
            if (chbnoodle.Checked)
            {
                NoodlePrice.Enabled = true;
                NoodleQuantity.Enabled = true;
            }
            if (!chbnoodle.Checked)
            {
                NoodlePrice.Enabled = false;
                NoodleQuantity.Enabled = false;
            }
        }

        private void chbpizza_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chbpizza_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chbpizza.Checked)
            {
                PizzaPrice.Enabled = true;
                PizzaQuantity.Enabled = true;
            }
            if (!chbpizza.Checked)
            {
                PizzaPrice.Enabled = false;
                PizzaQuantity.Enabled = false;
            }
        }

        private void chall_CheckedChanged(object sender, EventArgs e)
        {

            if (chall.Checked)
            {
                tball.Enabled = true;
                tball.Enabled = true;
            }
            if (!chall.Checked)
            {
                tball.Enabled = false;
                tball.Enabled = false;
            }
        }

        private void checkbeverage_CheckedChanged(object sender, EventArgs e)
        {

            if (checkbeverage.Checked)
            {
                tbbeverage.Enabled = true;
                tbbeverage.Enabled = true;
            }
            if (!checkbeverage.Checked)
            {
                tbbeverage.Enabled = false;
                tbbeverage.Enabled = false;
            }
        }

        private void chcekfood_CheckedChanged(object sender, EventArgs e)
        {
            if (chcekfood.Checked)
            {
                tbfood.Enabled = true;
                tbfood.Enabled = true;
            }
            if (!chcekfood.Checked)
            {
                tbfood.Enabled = false;
                tbfood.Enabled = false;
            }
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }
    }
}
