namespace BlockchainAssignment
{
    partial class BlockchainApp
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
            this.mainConsoleTB = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.printBlockBtn = new System.Windows.Forms.Button();
            this.publicKeyTB = new System.Windows.Forms.TextBox();
            this.privateKeyTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.generateWalletBtn = new System.Windows.Forms.Button();
            this.validateKeysBtn = new System.Windows.Forms.Button();
            this.createTransactionBtn = new System.Windows.Forms.Button();
            this.amountTB = new System.Windows.Forms.TextBox();
            this.feeTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.receiverKeyTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.generateBlockBtn = new System.Windows.Forms.Button();
            this.validateChainBtn = new System.Windows.Forms.Button();
            this.checkBalanceBtn = new System.Windows.Forms.Button();
            this.readAllBtn = new System.Windows.Forms.Button();
            this.readPendingTransactionsBtn = new System.Windows.Forms.Button();
            this.transactionPreferenceCB = new System.Windows.Forms.ComboBox();
            this.miningPreferenceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainConsoleTB
            // 
            this.mainConsoleTB.BackColor = System.Drawing.SystemColors.InfoText;
            this.mainConsoleTB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mainConsoleTB.Location = new System.Drawing.Point(18, 18);
            this.mainConsoleTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainConsoleTB.Name = "mainConsoleTB";
            this.mainConsoleTB.Size = new System.Drawing.Size(984, 481);
            this.mainConsoleTB.TabIndex = 0;
            this.mainConsoleTB.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 513);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 26);
            this.textBox1.TabIndex = 1;
            // 
            // printBlockBtn
            // 
            this.printBlockBtn.Location = new System.Drawing.Point(20, 509);
            this.printBlockBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.printBlockBtn.Name = "printBlockBtn";
            this.printBlockBtn.Size = new System.Drawing.Size(112, 30);
            this.printBlockBtn.TabIndex = 2;
            this.printBlockBtn.Text = "Print Block";
            this.printBlockBtn.UseVisualStyleBackColor = true;
            this.printBlockBtn.Click += new System.EventHandler(this.printBlockBtnClick);
            // 
            // publicKeyTB
            // 
            this.publicKeyTB.Location = new System.Drawing.Point(517, 508);
            this.publicKeyTB.Name = "publicKeyTB";
            this.publicKeyTB.Size = new System.Drawing.Size(331, 26);
            this.publicKeyTB.TabIndex = 5;
            // 
            // privateKeyTB
            // 
            this.privateKeyTB.Location = new System.Drawing.Point(517, 540);
            this.privateKeyTB.Name = "privateKeyTB";
            this.privateKeyTB.Size = new System.Drawing.Size(331, 26);
            this.privateKeyTB.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(430, 511);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Public Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(424, 540);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Private Key";
            // 
            // generateWalletBtn
            // 
            this.generateWalletBtn.Location = new System.Drawing.Point(854, 507);
            this.generateWalletBtn.Name = "generateWalletBtn";
            this.generateWalletBtn.Size = new System.Drawing.Size(158, 59);
            this.generateWalletBtn.TabIndex = 9;
            this.generateWalletBtn.Text = "Generate Wallet";
            this.generateWalletBtn.UseVisualStyleBackColor = true;
            this.generateWalletBtn.Click += new System.EventHandler(this.generateWalletBtnClick);
            // 
            // validateKeysBtn
            // 
            this.validateKeysBtn.Location = new System.Drawing.Point(854, 572);
            this.validateKeysBtn.Name = "validateKeysBtn";
            this.validateKeysBtn.Size = new System.Drawing.Size(158, 35);
            this.validateKeysBtn.TabIndex = 10;
            this.validateKeysBtn.Text = "Validate Keys";
            this.validateKeysBtn.UseVisualStyleBackColor = true;
            this.validateKeysBtn.Click += new System.EventHandler(this.validateKeysBtnClick);
            // 
            // createTransactionBtn
            // 
            this.createTransactionBtn.Location = new System.Drawing.Point(18, 706);
            this.createTransactionBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.createTransactionBtn.Name = "createTransactionBtn";
            this.createTransactionBtn.Size = new System.Drawing.Size(108, 61);
            this.createTransactionBtn.TabIndex = 11;
            this.createTransactionBtn.Text = "Create Transaction";
            this.createTransactionBtn.UseVisualStyleBackColor = true;
            this.createTransactionBtn.Click += new System.EventHandler(this.createTransactionBtnClick);
            // 
            // amountTB
            // 
            this.amountTB.Location = new System.Drawing.Point(224, 702);
            this.amountTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.amountTB.Name = "amountTB";
            this.amountTB.Size = new System.Drawing.Size(148, 26);
            this.amountTB.TabIndex = 12;
            // 
            // feeTB
            // 
            this.feeTB.Location = new System.Drawing.Point(224, 735);
            this.feeTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.feeTB.Name = "feeTB";
            this.feeTB.Size = new System.Drawing.Size(148, 26);
            this.feeTB.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 705);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 735);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Fee";
            // 
            // receiverKeyTB
            // 
            this.receiverKeyTB.Location = new System.Drawing.Point(496, 741);
            this.receiverKeyTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.receiverKeyTB.Name = "receiverKeyTB";
            this.receiverKeyTB.Size = new System.Drawing.Size(433, 26);
            this.receiverKeyTB.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(388, 741);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Receiver Key";
            // 
            // generateBlockBtn
            // 
            this.generateBlockBtn.Location = new System.Drawing.Point(18, 547);
            this.generateBlockBtn.Name = "generateBlockBtn";
            this.generateBlockBtn.Size = new System.Drawing.Size(123, 68);
            this.generateBlockBtn.TabIndex = 18;
            this.generateBlockBtn.Text = "Generate Block";
            this.generateBlockBtn.UseVisualStyleBackColor = true;
            this.generateBlockBtn.Click += new System.EventHandler(this.generateBlockBtnClick);
            // 
            // validateChainBtn
            // 
            this.validateChainBtn.Location = new System.Drawing.Point(857, 623);
            this.validateChainBtn.Name = "validateChainBtn";
            this.validateChainBtn.Size = new System.Drawing.Size(154, 42);
            this.validateChainBtn.TabIndex = 19;
            this.validateChainBtn.Text = "Validate Chain";
            this.validateChainBtn.UseVisualStyleBackColor = true;
            this.validateChainBtn.Click += new System.EventHandler(this.validateChainBtnClick);
            // 
            // checkBalanceBtn
            // 
            this.checkBalanceBtn.Location = new System.Drawing.Point(698, 572);
            this.checkBalanceBtn.Name = "checkBalanceBtn";
            this.checkBalanceBtn.Size = new System.Drawing.Size(150, 35);
            this.checkBalanceBtn.TabIndex = 20;
            this.checkBalanceBtn.Text = "Check Balance";
            this.checkBalanceBtn.UseVisualStyleBackColor = true;
            this.checkBalanceBtn.Click += new System.EventHandler(this.checkBalanceBtnClick);
            // 
            // readAllBtn
            // 
            this.readAllBtn.Location = new System.Drawing.Point(307, 513);
            this.readAllBtn.Name = "readAllBtn";
            this.readAllBtn.Size = new System.Drawing.Size(89, 37);
            this.readAllBtn.TabIndex = 23;
            this.readAllBtn.Text = "Read All";
            this.readAllBtn.UseVisualStyleBackColor = true;
            this.readAllBtn.Click += new System.EventHandler(this.readAllBtnClick);
            // 
            // readPendingTransactionsBtn
            // 
            this.readPendingTransactionsBtn.Location = new System.Drawing.Point(168, 547);
            this.readPendingTransactionsBtn.Name = "readPendingTransactionsBtn";
            this.readPendingTransactionsBtn.Size = new System.Drawing.Size(133, 68);
            this.readPendingTransactionsBtn.TabIndex = 24;
            this.readPendingTransactionsBtn.Text = "Read Pending Transactions";
            this.readPendingTransactionsBtn.UseVisualStyleBackColor = true;
            this.readPendingTransactionsBtn.Click += new System.EventHandler(this.readPendingTransactionsBtnClick);
            // 
            // transactionPreferenceCB
            // 
            this.transactionPreferenceCB.FormattingEnabled = true;
            this.transactionPreferenceCB.Items.AddRange(new object[] {
            "Greedy",
            "Altruistic",
            "Random",
            "AddressPreference"});
            this.transactionPreferenceCB.Location = new System.Drawing.Point(20, 647);
            this.transactionPreferenceCB.Name = "transactionPreferenceCB";
            this.transactionPreferenceCB.Size = new System.Drawing.Size(121, 28);
            this.transactionPreferenceCB.TabIndex = 25;
            // 
            // miningPreferenceLabel
            // 
            this.miningPreferenceLabel.AutoSize = true;
            this.miningPreferenceLabel.Location = new System.Drawing.Point(16, 623);
            this.miningPreferenceLabel.Name = "miningPreferenceLabel";
            this.miningPreferenceLabel.Size = new System.Drawing.Size(137, 20);
            this.miningPreferenceLabel.TabIndex = 26;
            this.miningPreferenceLabel.Text = "Mining Preference";
            // 
            // BlockchainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1026, 778);
            this.Controls.Add(this.miningPreferenceLabel);
            this.Controls.Add(this.transactionPreferenceCB);
            this.Controls.Add(this.readPendingTransactionsBtn);
            this.Controls.Add(this.readAllBtn);
            this.Controls.Add(this.checkBalanceBtn);
            this.Controls.Add(this.validateChainBtn);
            this.Controls.Add(this.generateBlockBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.receiverKeyTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.feeTB);
            this.Controls.Add(this.amountTB);
            this.Controls.Add(this.createTransactionBtn);
            this.Controls.Add(this.validateKeysBtn);
            this.Controls.Add(this.generateWalletBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.privateKeyTB);
            this.Controls.Add(this.publicKeyTB);
            this.Controls.Add(this.printBlockBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.mainConsoleTB);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BlockchainApp";
            this.Text = "Blockchain App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox mainConsoleTB;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button printBlockBtn;
        private System.Windows.Forms.TextBox publicKeyTB;
        private System.Windows.Forms.TextBox privateKeyTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button generateWalletBtn;
        private System.Windows.Forms.Button validateKeysBtn;
        private System.Windows.Forms.Button createTransactionBtn;
        private System.Windows.Forms.TextBox amountTB;
        private System.Windows.Forms.TextBox feeTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox receiverKeyTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button generateBlockBtn;
        private System.Windows.Forms.Button validateChainBtn;
        private System.Windows.Forms.Button checkBalanceBtn;
        private System.Windows.Forms.Button readAllBtn;
        private System.Windows.Forms.Button readPendingTransactionsBtn;
        private System.Windows.Forms.ComboBox transactionPreferenceCB;
        private System.Windows.Forms.Label miningPreferenceLabel;
    }
}

