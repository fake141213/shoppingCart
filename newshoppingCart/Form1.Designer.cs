namespace newshoppingCart
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbCoffeePrice = new TextBox();
            tbGreenTeaPrice = new TextBox();
            tbCoffeeQuantity = new TextBox();
            tbGreeTeaQuantity = new TextBox();
            Check_out = new Button();
            chbcoffee = new CheckBox();
            chbgreentea = new CheckBox();
            total = new TextBox();
            Totalb = new Label();
            cash = new Label();
            change = new Label();
            tbcash = new TextBox();
            tbchange = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            textBox12 = new TextBox();
            textBox13 = new TextBox();
            textBox14 = new TextBox();
            textBox15 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // tbCoffeePrice
            // 
            tbCoffeePrice.Location = new Point(214, 23);
            tbCoffeePrice.Name = "tbCoffeePrice";
            tbCoffeePrice.Size = new Size(125, 27);
            tbCoffeePrice.TabIndex = 0;
            tbCoffeePrice.TextChanged += tbCoffeePrice_TextChanged;
            // 
            // tbGreenTeaPrice
            // 
            tbGreenTeaPrice.Location = new Point(214, 56);
            tbGreenTeaPrice.Name = "tbGreenTeaPrice";
            tbGreenTeaPrice.Size = new Size(125, 27);
            tbGreenTeaPrice.TabIndex = 1;
            tbGreenTeaPrice.TextChanged += tbGreenTeaPrice_TextChanged;
            // 
            // tbCoffeeQuantity
            // 
            tbCoffeeQuantity.Location = new Point(345, 23);
            tbCoffeeQuantity.Name = "tbCoffeeQuantity";
            tbCoffeeQuantity.Size = new Size(125, 27);
            tbCoffeeQuantity.TabIndex = 2;
            tbCoffeeQuantity.TextChanged += textBox3_TextChanged;
            // 
            // tbGreeTeaQuantity
            // 
            tbGreeTeaQuantity.Location = new Point(345, 56);
            tbGreeTeaQuantity.Name = "tbGreeTeaQuantity";
            tbGreeTeaQuantity.Size = new Size(125, 27);
            tbGreeTeaQuantity.TabIndex = 3;
            // 
            // Check_out
            // 
            Check_out.Location = new Point(476, 23);
            Check_out.Name = "Check_out";
            Check_out.Size = new Size(94, 358);
            Check_out.TabIndex = 4;
            Check_out.Text = "Check out";
            Check_out.UseVisualStyleBackColor = true;
            Check_out.Click += Check_out_Click;
            // 
            // chbcoffee
            // 
            chbcoffee.AutoSize = true;
            chbcoffee.Location = new Point(107, 26);
            chbcoffee.Name = "chbcoffee";
            chbcoffee.Size = new Size(75, 24);
            chbcoffee.TabIndex = 5;
            chbcoffee.Text = "Coffee";
            chbcoffee.UseVisualStyleBackColor = true;
            chbcoffee.CheckedChanged += chbcoffee_CheckedChanged;
            // 
            // chbgreentea
            // 
            chbgreentea.AutoSize = true;
            chbgreentea.Location = new Point(107, 59);
            chbgreentea.Name = "chbgreentea";
            chbgreentea.Size = new Size(97, 24);
            chbgreentea.TabIndex = 6;
            chbgreentea.Text = "Green Tea";
            chbgreentea.UseVisualStyleBackColor = true;
            chbgreentea.CheckedChanged += chbgreentea_CheckedChanged;
            // 
            // total
            // 
            total.Location = new Point(642, 24);
            total.Name = "total";
            total.Size = new Size(125, 27);
            total.TabIndex = 7;
            // 
            // Totalb
            // 
            Totalb.AutoSize = true;
            Totalb.Location = new Point(588, 27);
            Totalb.Name = "Totalb";
            Totalb.Size = new Size(42, 20);
            Totalb.TabIndex = 8;
            Totalb.Text = "Total";
            // 
            // cash
            // 
            cash.AutoSize = true;
            cash.Location = new Point(591, 59);
            cash.Name = "cash";
            cash.Size = new Size(40, 20);
            cash.TabIndex = 9;
            cash.Text = "Cash";
            // 
            // change
            // 
            change.AutoSize = true;
            change.Location = new Point(575, 93);
            change.Name = "change";
            change.Size = new Size(59, 20);
            change.TabIndex = 10;
            change.Text = "Change";
            // 
            // tbcash
            // 
            tbcash.Location = new Point(642, 57);
            tbcash.Name = "tbcash";
            tbcash.Size = new Size(125, 27);
            tbcash.TabIndex = 11;
            tbcash.TextChanged += tbcash_TextChanged;
            // 
            // tbchange
            // 
            tbchange.Location = new Point(642, 90);
            tbchange.Name = "tbchange";
            tbchange.Size = new Size(125, 27);
            tbchange.TabIndex = 12;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(642, 156);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(125, 27);
            textBox9.TabIndex = 14;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(642, 189);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(125, 27);
            textBox10.TabIndex = 15;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(642, 222);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(125, 27);
            textBox11.TabIndex = 16;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(642, 255);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(125, 27);
            textBox12.TabIndex = 17;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(642, 288);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(125, 27);
            textBox13.TabIndex = 18;
            // 
            // textBox14
            // 
            textBox14.Location = new Point(642, 321);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(125, 27);
            textBox14.TabIndex = 19;
            // 
            // textBox15
            // 
            textBox15.Location = new Point(642, 354);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(125, 27);
            textBox15.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(593, 126);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 22;
            label4.Text = "1000";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(601, 159);
            label5.Name = "label5";
            label5.Size = new Size(33, 20);
            label5.TabIndex = 23;
            label5.Text = "500";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(602, 192);
            label6.Name = "label6";
            label6.Size = new Size(33, 20);
            label6.TabIndex = 24;
            label6.Text = "100";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(609, 225);
            label7.Name = "label7";
            label7.Size = new Size(25, 20);
            label7.TabIndex = 25;
            label7.Text = "50";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(607, 258);
            label8.Name = "label8";
            label8.Size = new Size(25, 20);
            label8.TabIndex = 26;
            label8.Text = "20";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(607, 291);
            label9.Name = "label9";
            label9.Size = new Size(25, 20);
            label9.TabIndex = 27;
            label9.Text = "10";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(613, 324);
            label10.Name = "label10";
            label10.Size = new Size(17, 20);
            label10.TabIndex = 28;
            label10.Text = "5";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(612, 357);
            label11.Name = "label11";
            label11.Size = new Size(17, 20);
            label11.TabIndex = 29;
            label11.Text = "1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(642, 123);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 30;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox15);
            Controls.Add(textBox14);
            Controls.Add(textBox13);
            Controls.Add(textBox12);
            Controls.Add(textBox11);
            Controls.Add(textBox10);
            Controls.Add(textBox9);
            Controls.Add(tbchange);
            Controls.Add(tbcash);
            Controls.Add(change);
            Controls.Add(cash);
            Controls.Add(Totalb);
            Controls.Add(total);
            Controls.Add(chbgreentea);
            Controls.Add(chbcoffee);
            Controls.Add(Check_out);
            Controls.Add(tbGreeTeaQuantity);
            Controls.Add(tbCoffeeQuantity);
            Controls.Add(tbGreenTeaPrice);
            Controls.Add(tbCoffeePrice);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbCoffeePrice;
        private TextBox tbGreenTeaPrice;
        private TextBox tbCoffeeQuantity;
        private TextBox tbGreeTeaQuantity;
        private Button Check_out;
        private CheckBox chbcoffee;
        private CheckBox chbgreentea;
        private TextBox total;
        private Label Totalb;
        private Label cash;
        private Label change;
        private TextBox tbcash;
        private TextBox tbchange;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox textBox12;
        private TextBox textBox13;
        private TextBox textBox14;
        private TextBox textBox15;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox textBox1;
    }
}
