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
            textBox10.Text = "0";
            textBox5.Text = "0";
            textBox1.Text = "0";
            textBox0_50.Text = "0";
            textBox0_25.Text = "0";
            textBox0_10.Text = "0";
            textBox0_1.Text = "0";
            


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

            double icoffeep = 0;
            double icoffeeq = 0;
            double igreenteap = 0;
            double igreenteaq = 0;
            double cashh = 0;
            double Changee = 0;
            double noodlep = 0;
            double noodleq = 0;
            double pizzap = 0;
            double pizzaq = 0;
            double allf_b = 0, dev = 0, food = 0;

            try
            {
                if (chbCoffee.Checked)
                {
                    icoffeep = double.Parse(strcoffeep);
                    icoffeeq = double.Parse(strcoffeeq);
                }
                if (chbgreetea.Checked)
                {
                    igreenteap = double.Parse(strgreenteap);
                    igreenteaq = double.Parse(strgreenteaq);
                }
                if (chbnoodle.Checked)
                {
                    noodlep = double.Parse(strnoodlep);
                    noodleq = double.Parse(strnoodleq);
                }
                if (chbpizza.Checked)
                {
                    pizzap = double.Parse(strpizzap);
                    pizzaq = double.Parse(strpizzaq);
                }
                if (tbcash.Created)
                {
                    cashh = double.Parse(strcash);
                }
                if (change.Created)
                {
                    Changee = double.Parse(strchange);
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
            double coff = icoffeep * icoffeeq;
            double greetea = igreenteap * igreenteaq;
            double noodlee = noodlep * noodleq;
            double pizza = pizzap * pizzaq;
            double sum = coff + greetea + noodlee + pizza;
            double chage = cashh - sum;
            double discountAmount = 0;
            try
            {
                if (chall.Checked)
                {
                    allf_b = int.Parse(tball.Text);
  
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

            double changeAmount = cashh - sum;
            change.Text = changeAmount.ToString("F2");


            double thousand = 0;
            double five_hundred = 0;
            double one_hunred = 0;
            double fifty = 0;
            double twenty = 0;
            double ten = 0;
            double five = 0;
            double one = 0;
            double fiftyCents = 0, twentyFiveCents = 0, tenCents = 0, oneCent = 0;

            if (chage >= 1000)
            {
                thousand = (int)chage / 1000;
                chage = chage % 1000;
                textBox1000.Text = thousand.ToString();
            }
            if (chage >= 500)
            {
                five_hundred = (int)chage / 500;
                chage = chage % 500;
                textBox500.Text = five_hundred.ToString();
            }
            if (chage >= 100)
            {
                one_hunred = (int)chage / 100;
                chage = chage % 100;
                textBox100.Text = one_hunred.ToString();
            }
            if (chage >= 50)
            {
                fifty = (int)chage / 50;
                chage = chage % 50;
                textBox50.Text = fifty.ToString();
            }
            if (chage >= 20)
            {
                twenty = (int)chage / 20;
                chage = chage % 20;
                textBox20.Text = twenty.ToString();
            }
            if (chage >= 10)
            {
                ten = (int)chage / 10;
                chage = chage % 10;
                textBox10.Text = ten.ToString();
            }
            if (chage >= 5)
            {
                five = (int)chage / 5;
                chage = chage % 5;
                textBox5.Text = five.ToString();
            }
            if (chage >= 1)
            {
                one = (int)chage / 1;
                chage = chage % 1;
                textBox1.Text = one.ToString();
            }
            if (chage >= 0.50)
            {
                fiftyCents = (int)(chage / 0.50);
                chage %= 0.50;
                textBox0_50.Text = fiftyCents.ToString();
            }
            if (chage >= 0.25)
            {
                twentyFiveCents = (int)(chage / 0.25);
                chage %= 0.25;
                textBox0_25.Text = twentyFiveCents.ToString();
            }
            if (chage >= 0.10)
            {
                tenCents = (int)(chage / 0.10);
                chage %= 0.10;
                textBox0_10.Text = tenCents.ToString();
            }
            if (chage >= 0.01)
            {
                oneCent = (int)(chage / 0.01);
                chage %= 0.01;
                textBox0_1.Text = oneCent.ToString();
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
                
            }
            if (!chall.Checked)
            {
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
