namespace fruitshop
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
            tbAppleJuice = new CheckBox();
            tbMixedfruitjuice = new CheckBox();
            tbBananajuice = new CheckBox();
            checkout = new Button();
            AppleJuice = new TextBox();
            Mixedfruitjuice = new TextBox();
            Bananajuice = new TextBox();
            label1 = new Label();
            tbtotal = new Label();
            tbchange = new Label();
            label4 = new Label();
            label5 = new Label();
            total = new TextBox();
            Change = new TextBox();
            label6 = new Label();
            label2 = new Label();
            label3 = new Label();
            Money = new TextBox();
            SuspendLayout();
            // 
            // tbAppleJuice
            // 
            tbAppleJuice.AutoSize = true;
            tbAppleJuice.Location = new Point(46, 60);
            tbAppleJuice.Name = "tbAppleJuice";
            tbAppleJuice.Size = new Size(92, 24);
            tbAppleJuice.TabIndex = 0;
            tbAppleJuice.Text = "น้ำแอปเปิ้ล";
            tbAppleJuice.UseVisualStyleBackColor = true;
            // 
            // tbMixedfruitjuice
            // 
            tbMixedfruitjuice.AutoSize = true;
            tbMixedfruitjuice.Location = new Point(46, 110);
            tbMixedfruitjuice.Name = "tbMixedfruitjuice";
            tbMixedfruitjuice.Size = new Size(97, 24);
            tbMixedfruitjuice.TabIndex = 1;
            tbMixedfruitjuice.Text = "น้ำผลไม้รวม";
            tbMixedfruitjuice.UseVisualStyleBackColor = true;
            // 
            // tbBananajuice
            // 
            tbBananajuice.AutoSize = true;
            tbBananajuice.Location = new Point(46, 161);
            tbBananajuice.Name = "tbBananajuice";
            tbBananajuice.Size = new Size(79, 24);
            tbBananajuice.TabIndex = 2;
            tbBananajuice.Text = "น้ำกล้วย";
            tbBananajuice.UseVisualStyleBackColor = true;
            // 
            // checkout
            // 
            checkout.Location = new Point(343, 55);
            checkout.Name = "checkout";
            checkout.Size = new Size(94, 29);
            checkout.TabIndex = 3;
            checkout.Text = "คิดเงิน";
            checkout.UseVisualStyleBackColor = true;
            checkout.Click += button1_Click;
            // 
            // AppleJuice
            // 
            AppleJuice.Location = new Point(166, 57);
            AppleJuice.Name = "AppleJuice";
            AppleJuice.Size = new Size(125, 27);
            AppleJuice.TabIndex = 4;
            // 
            // Mixedfruitjuice
            // 
            Mixedfruitjuice.Location = new Point(166, 107);
            Mixedfruitjuice.Name = "Mixedfruitjuice";
            Mixedfruitjuice.Size = new Size(125, 27);
            Mixedfruitjuice.TabIndex = 5;
            // 
            // Bananajuice
            // 
            Bananajuice.Location = new Point(166, 159);
            Bananajuice.Name = "Bananajuice";
            Bananajuice.Size = new Size(125, 27);
            Bananajuice.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(169, 32);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 7;
            label1.Text = "จำนวน";
            // 
            // tbtotal
            // 
            tbtotal.AutoSize = true;
            tbtotal.Location = new Point(457, 62);
            tbtotal.Name = "tbtotal";
            tbtotal.Size = new Size(72, 20);
            tbtotal.TabIndex = 8;
            tbtotal.Text = "รวททั้งหมด";
            // 
            // tbchange
            // 
            tbchange.AutoSize = true;
            tbchange.Location = new Point(468, 163);
            tbchange.Name = "tbchange";
            tbchange.Size = new Size(54, 20);
            tbchange.TabIndex = 9;
            tbchange.Text = "เงินทอน";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(675, 61);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 10;
            label4.Text = "บาท";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(675, 159);
            label5.Name = "label5";
            label5.Size = new Size(34, 20);
            label5.TabIndex = 11;
            label5.Text = "บาท";
            // 
            // total
            // 
            total.Location = new Point(535, 58);
            total.Name = "total";
            total.Size = new Size(125, 27);
            total.TabIndex = 12;
            // 
            // Change
            // 
            Change.Location = new Point(533, 158);
            Change.Name = "Change";
            Change.Size = new Size(125, 27);
            Change.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(352, 9);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 14;
            label6.Text = "Fruit Shop";
            label6.Click += label6_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(466, 114);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 15;
            label2.Text = "เงินลูกค้า";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(675, 114);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 16;
            label3.Text = "บาท";
            // 
            // Money
            // 
            Money.Location = new Point(535, 114);
            Money.Name = "Money";
            Money.Size = new Size(125, 27);
            Money.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Money);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(Change);
            Controls.Add(total);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tbchange);
            Controls.Add(tbtotal);
            Controls.Add(label1);
            Controls.Add(Bananajuice);
            Controls.Add(Mixedfruitjuice);
            Controls.Add(AppleJuice);
            Controls.Add(checkout);
            Controls.Add(tbBananajuice);
            Controls.Add(tbMixedfruitjuice);
            Controls.Add(tbAppleJuice);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox tbAppleJuice;
        private CheckBox tbMixedfruitjuice;
        private CheckBox tbBananajuice;
        private Button checkout;
        private TextBox AppleJuice;
        private TextBox Mixedfruitjuice;
        private TextBox Bananajuice;
        private Label label1;
        private Label tbtotal;
        private Label tbchange;
        private Label label4;
        private Label label5;
        private TextBox total;
        private TextBox Change;
        private Label label6;
        private Label label2;
        private Label label3;
        private TextBox Money;
    }
}
