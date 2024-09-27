namespace McDonalds
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.burgerInput = new System.Windows.Forms.TextBox();
            this.fryInput = new System.Windows.Forms.TextBox();
            this.drinkInput = new System.Windows.Forms.TextBox();
            this.burgerLabel = new System.Windows.Forms.Label();
            this.fryLabel = new System.Windows.Forms.Label();
            this.drinkLabel = new System.Windows.Forms.Label();
            this.calculateTotalButton = new System.Windows.Forms.Button();
            this.calculateChangeButton = new System.Windows.Forms.Button();
            this.printReceiptButton = new System.Windows.Forms.Button();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.receiptOutput = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.changeLabel = new System.Windows.Forms.Label();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.subtotalOutput = new System.Windows.Forms.Label();
            this.taxAmountOutput = new System.Windows.Forms.Label();
            this.totalAmountOutput = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.changeOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // burgerInput
            // 
            this.burgerInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burgerInput.Location = new System.Drawing.Point(138, 22);
            this.burgerInput.Name = "burgerInput";
            this.burgerInput.Size = new System.Drawing.Size(34, 22);
            this.burgerInput.TabIndex = 0;
            // 
            // fryInput
            // 
            this.fryInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fryInput.Location = new System.Drawing.Point(138, 48);
            this.fryInput.Name = "fryInput";
            this.fryInput.Size = new System.Drawing.Size(34, 22);
            this.fryInput.TabIndex = 1;
            // 
            // drinkInput
            // 
            this.drinkInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkInput.Location = new System.Drawing.Point(138, 73);
            this.drinkInput.Name = "drinkInput";
            this.drinkInput.Size = new System.Drawing.Size(34, 22);
            this.drinkInput.TabIndex = 2;
            // 
            // burgerLabel
            // 
            this.burgerLabel.AutoSize = true;
            this.burgerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burgerLabel.ForeColor = System.Drawing.Color.White;
            this.burgerLabel.Location = new System.Drawing.Point(13, 25);
            this.burgerLabel.Name = "burgerLabel";
            this.burgerLabel.Size = new System.Drawing.Size(119, 16);
            this.burgerLabel.TabIndex = 3;
            this.burgerLabel.Text = "Number of Burgers";
            // 
            // fryLabel
            // 
            this.fryLabel.AutoSize = true;
            this.fryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fryLabel.ForeColor = System.Drawing.Color.White;
            this.fryLabel.Location = new System.Drawing.Point(13, 51);
            this.fryLabel.Name = "fryLabel";
            this.fryLabel.Size = new System.Drawing.Size(102, 16);
            this.fryLabel.TabIndex = 4;
            this.fryLabel.Text = "Number of Fries";
            // 
            // drinkLabel
            // 
            this.drinkLabel.AutoSize = true;
            this.drinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkLabel.ForeColor = System.Drawing.Color.White;
            this.drinkLabel.Location = new System.Drawing.Point(13, 76);
            this.drinkLabel.Name = "drinkLabel";
            this.drinkLabel.Size = new System.Drawing.Size(110, 16);
            this.drinkLabel.TabIndex = 5;
            this.drinkLabel.Text = "Number of Drinks";
            // 
            // calculateTotalButton
            // 
            this.calculateTotalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateTotalButton.Location = new System.Drawing.Point(16, 107);
            this.calculateTotalButton.Name = "calculateTotalButton";
            this.calculateTotalButton.Size = new System.Drawing.Size(117, 25);
            this.calculateTotalButton.TabIndex = 6;
            this.calculateTotalButton.Text = "Calculate Total";
            this.calculateTotalButton.UseVisualStyleBackColor = true;
            this.calculateTotalButton.Click += new System.EventHandler(this.calculateTotalButton_Click);
            // 
            // calculateChangeButton
            // 
            this.calculateChangeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateChangeButton.ForeColor = System.Drawing.Color.Black;
            this.calculateChangeButton.Location = new System.Drawing.Point(16, 250);
            this.calculateChangeButton.Name = "calculateChangeButton";
            this.calculateChangeButton.Size = new System.Drawing.Size(117, 23);
            this.calculateChangeButton.TabIndex = 7;
            this.calculateChangeButton.Text = "Calculate Change";
            this.calculateChangeButton.UseVisualStyleBackColor = true;
            this.calculateChangeButton.Visible = false;
            this.calculateChangeButton.Click += new System.EventHandler(this.calculateChangeButton_Click);
            // 
            // printReceiptButton
            // 
            this.printReceiptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printReceiptButton.Location = new System.Drawing.Point(16, 311);
            this.printReceiptButton.Name = "printReceiptButton";
            this.printReceiptButton.Size = new System.Drawing.Size(117, 23);
            this.printReceiptButton.TabIndex = 8;
            this.printReceiptButton.Text = "Print Receipt";
            this.printReceiptButton.UseVisualStyleBackColor = true;
            this.printReceiptButton.Visible = false;
            this.printReceiptButton.Click += new System.EventHandler(this.printReceiptButton_Click);
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalLabel.ForeColor = System.Drawing.Color.White;
            this.subtotalLabel.Location = new System.Drawing.Point(16, 150);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(56, 16);
            this.subtotalLabel.TabIndex = 9;
            this.subtotalLabel.Text = "Subtotal";
            this.subtotalLabel.Visible = false;
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.ForeColor = System.Drawing.Color.White;
            this.taxLabel.Location = new System.Drawing.Point(16, 181);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(30, 16);
            this.taxLabel.TabIndex = 10;
            this.taxLabel.Text = "Tax";
            this.taxLabel.Visible = false;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.Color.White;
            this.totalLabel.Location = new System.Drawing.Point(16, 207);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(38, 16);
            this.totalLabel.TabIndex = 11;
            this.totalLabel.Text = "Total";
            this.totalLabel.Visible = false;
            // 
            // receiptOutput
            // 
            this.receiptOutput.AutoSize = true;
            this.receiptOutput.BackColor = System.Drawing.Color.Red;
            this.receiptOutput.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptOutput.ForeColor = System.Drawing.Color.White;
            this.receiptOutput.Location = new System.Drawing.Point(196, 36);
            this.receiptOutput.Name = "receiptOutput";
            this.receiptOutput.Size = new System.Drawing.Size(31, 13);
            this.receiptOutput.TabIndex = 12;
            this.receiptOutput.Text = "    ";
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLabel.ForeColor = System.Drawing.Color.White;
            this.tenderedLabel.Location = new System.Drawing.Point(16, 234);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(67, 16);
            this.tenderedLabel.TabIndex = 13;
            this.tenderedLabel.Text = "Tendered";
            this.tenderedLabel.Visible = false;
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.ForeColor = System.Drawing.Color.White;
            this.changeLabel.Location = new System.Drawing.Point(16, 286);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(54, 16);
            this.changeLabel.TabIndex = 14;
            this.changeLabel.Text = "Change";
            this.changeLabel.Visible = false;
            // 
            // tenderedInput
            // 
            this.tenderedInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedInput.ForeColor = System.Drawing.Color.Black;
            this.tenderedInput.Location = new System.Drawing.Point(114, 227);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(34, 22);
            this.tenderedInput.TabIndex = 15;
            this.tenderedInput.Visible = false;
            // 
            // newOrderButton
            // 
            this.newOrderButton.Location = new System.Drawing.Point(225, 311);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(107, 23);
            this.newOrderButton.TabIndex = 16;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = true;
            this.newOrderButton.Visible = false;
            this.newOrderButton.Click += new System.EventHandler(this.newOrderButton_Click);
            // 
            // subtotalOutput
            // 
            this.subtotalOutput.AutoSize = true;
            this.subtotalOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalOutput.ForeColor = System.Drawing.Color.White;
            this.subtotalOutput.Location = new System.Drawing.Point(114, 150);
            this.subtotalOutput.Name = "subtotalOutput";
            this.subtotalOutput.Size = new System.Drawing.Size(16, 16);
            this.subtotalOutput.TabIndex = 17;
            this.subtotalOutput.Text = "   ";
            // 
            // taxAmountOutput
            // 
            this.taxAmountOutput.AutoSize = true;
            this.taxAmountOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxAmountOutput.ForeColor = System.Drawing.Color.White;
            this.taxAmountOutput.Location = new System.Drawing.Point(114, 181);
            this.taxAmountOutput.Name = "taxAmountOutput";
            this.taxAmountOutput.Size = new System.Drawing.Size(22, 16);
            this.taxAmountOutput.TabIndex = 18;
            this.taxAmountOutput.Text = "     ";
            // 
            // totalAmountOutput
            // 
            this.totalAmountOutput.AutoSize = true;
            this.totalAmountOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmountOutput.ForeColor = System.Drawing.Color.White;
            this.totalAmountOutput.Location = new System.Drawing.Point(114, 207);
            this.totalAmountOutput.Name = "totalAmountOutput";
            this.totalAmountOutput.Size = new System.Drawing.Size(19, 16);
            this.totalAmountOutput.TabIndex = 19;
            this.totalAmountOutput.Text = "    ";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.BackColor = System.Drawing.Color.Yellow;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.Black;
            this.welcomeLabel.Location = new System.Drawing.Point(-1, -2);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(390, 21);
            this.welcomeLabel.TabIndex = 20;
            this.welcomeLabel.Text = "Welcome to McDonalds";
            // 
            // changeOutput
            // 
            this.changeOutput.AutoSize = true;
            this.changeOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeOutput.ForeColor = System.Drawing.Color.White;
            this.changeOutput.Location = new System.Drawing.Point(101, 286);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(0, 16);
            this.changeOutput.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(388, 336);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.totalAmountOutput);
            this.Controls.Add(this.taxAmountOutput);
            this.Controls.Add(this.subtotalOutput);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.receiptOutput);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.printReceiptButton);
            this.Controls.Add(this.calculateChangeButton);
            this.Controls.Add(this.calculateTotalButton);
            this.Controls.Add(this.drinkLabel);
            this.Controls.Add(this.fryLabel);
            this.Controls.Add(this.burgerLabel);
            this.Controls.Add(this.drinkInput);
            this.Controls.Add(this.fryInput);
            this.Controls.Add(this.burgerInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "McDonalds";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox burgerInput;
        private System.Windows.Forms.TextBox fryInput;
        private System.Windows.Forms.TextBox drinkInput;
        private System.Windows.Forms.Label burgerLabel;
        private System.Windows.Forms.Label fryLabel;
        private System.Windows.Forms.Label drinkLabel;
        private System.Windows.Forms.Button calculateTotalButton;
        private System.Windows.Forms.Button calculateChangeButton;
        private System.Windows.Forms.Button printReceiptButton;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label receiptOutput;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.Label subtotalOutput;
        private System.Windows.Forms.Label taxAmountOutput;
        private System.Windows.Forms.Label totalAmountOutput;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label changeOutput;
    }
}

