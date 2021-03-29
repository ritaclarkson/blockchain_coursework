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

        #region Windows Form Designer created code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextOutput = new System.Windows.Forms.RichTextBox();
            this.Print = new System.Windows.Forms.Button();
            this.TextInput = new System.Windows.Forms.RichTextBox();
            this.createWallet = new System.Windows.Forms.Button();
            this.publicKeyTextBox = new System.Windows.Forms.TextBox();
            this.privateKeyTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.validateKeys = new System.Windows.Forms.Button();
            this.createBlockButton = new System.Windows.Forms.Button();
            this.createTransactionButton = new System.Windows.Forms.Button();
            this.amountTextBox = new System.Windows.Forms.RichTextBox();
            this.feeTextBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.recipientKeyTextBox = new System.Windows.Forms.TextBox();
            this.validateChainButton = new System.Windows.Forms.Button();
            this.checkBalanceButton = new System.Windows.Forms.Button();
            this.createBlockAltruisticButton = new System.Windows.Forms.Button();
            this.createBlockUnpredicatbleButton = new System.Windows.Forms.Button();
            this.createBlockGreedyButton = new System.Windows.Forms.Button();
            this.createBlockAddressBasedButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextOutput
            // 
            this.TextOutput.BackColor = System.Drawing.SystemColors.InfoText;
            this.TextOutput.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TextOutput.Location = new System.Drawing.Point(25, 33);
            this.TextOutput.Name = "TextOutput";
            this.TextOutput.Size = new System.Drawing.Size(773, 499);
            this.TextOutput.TabIndex = 0;
            this.TextOutput.Text = "";
            this.TextOutput.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Print
            // 
            this.Print.Location = new System.Drawing.Point(814, 33);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(254, 22);
            this.Print.TabIndex = 1;
            this.Print.Text = "PRINT BLOCK";
            this.Print.UseVisualStyleBackColor = true;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // TextInput
            // 
            this.TextInput.Location = new System.Drawing.Point(1074, 33);
            this.TextInput.Name = "TextInput";
            this.TextInput.Size = new System.Drawing.Size(34, 22);
            this.TextInput.TabIndex = 2;
            this.TextInput.Text = "";
            this.TextInput.TextChanged += new System.EventHandler(this.TextInput_TextChanged);
            // 
            // createWallet
            // 
            this.createWallet.Location = new System.Drawing.Point(814, 374);
            this.createWallet.Name = "createWallet";
            this.createWallet.Size = new System.Drawing.Size(294, 52);
            this.createWallet.TabIndex = 3;
            this.createWallet.Text = "GENERATE WALLET";
            this.createWallet.UseVisualStyleBackColor = true;
            this.createWallet.Click += new System.EventHandler(this.createWallet_Click);
            // 
            // publicKeyTextBox
            // 
            this.publicKeyTextBox.Location = new System.Drawing.Point(893, 494);
            this.publicKeyTextBox.Name = "publicKeyTextBox";
            this.publicKeyTextBox.Size = new System.Drawing.Size(215, 20);
            this.publicKeyTextBox.TabIndex = 4;
            // 
            // privateKeyTextBox
            // 
            this.privateKeyTextBox.Location = new System.Drawing.Point(893, 453);
            this.privateKeyTextBox.Name = "privateKeyTextBox";
            this.privateKeyTextBox.Size = new System.Drawing.Size(215, 20);
            this.privateKeyTextBox.TabIndex = 6;
            this.privateKeyTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(815, 497);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Public Key";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(811, 453);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Private Key";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // validateKeys
            // 
            this.validateKeys.Location = new System.Drawing.Point(815, 560);
            this.validateKeys.Name = "validateKeys";
            this.validateKeys.Size = new System.Drawing.Size(137, 26);
            this.validateKeys.TabIndex = 9;
            this.validateKeys.Text = "Validate Keys";
            this.validateKeys.UseVisualStyleBackColor = true;
            this.validateKeys.Click += new System.EventHandler(this.validateKeys_Click);
            // 
            // createBlockButton
            // 
            this.createBlockButton.Location = new System.Drawing.Point(948, 87);
            this.createBlockButton.Name = "createBlockButton";
            this.createBlockButton.Size = new System.Drawing.Size(120, 49);
            this.createBlockButton.TabIndex = 10;
            this.createBlockButton.Text = "DEFAULT";
            this.createBlockButton.UseVisualStyleBackColor = true;
            this.createBlockButton.Click += new System.EventHandler(this.createBlockButton_Click);
            // 
            // createTransactionButton
            // 
            this.createTransactionButton.Location = new System.Drawing.Point(25, 558);
            this.createTransactionButton.Name = "createTransactionButton";
            this.createTransactionButton.Size = new System.Drawing.Size(120, 49);
            this.createTransactionButton.TabIndex = 11;
            this.createTransactionButton.Text = "TRANSACTION";
            this.createTransactionButton.UseVisualStyleBackColor = true;
            this.createTransactionButton.Click += new System.EventHandler(this.createTransactionButton_Click);
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(224, 559);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(50, 20);
            this.amountTextBox.TabIndex = 12;
            this.amountTextBox.Text = "";
            this.amountTextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged_1);
            // 
            // feeTextBox
            // 
            this.feeTextBox.Location = new System.Drawing.Point(224, 585);
            this.feeTextBox.Name = "feeTextBox";
            this.feeTextBox.Size = new System.Drawing.Size(50, 20);
            this.feeTextBox.TabIndex = 13;
            this.feeTextBox.Text = "";
            this.feeTextBox.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 562);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Amount";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 588);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Fee";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(322, 567);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Recipient Key";
            // 
            // recipientKeyTextBox
            // 
            this.recipientKeyTextBox.Location = new System.Drawing.Point(401, 564);
            this.recipientKeyTextBox.Name = "recipientKeyTextBox";
            this.recipientKeyTextBox.Size = new System.Drawing.Size(240, 20);
            this.recipientKeyTextBox.TabIndex = 17;
            // 
            // validateChainButton
            // 
            this.validateChainButton.Location = new System.Drawing.Point(971, 560);
            this.validateChainButton.Name = "validateChainButton";
            this.validateChainButton.Size = new System.Drawing.Size(137, 26);
            this.validateChainButton.TabIndex = 18;
            this.validateChainButton.Text = "Validate Chain";
            this.validateChainButton.UseVisualStyleBackColor = true;
            this.validateChainButton.Click += new System.EventHandler(this.validateChainButton_Click);
            // 
            // checkBalanceButton
            // 
            this.checkBalanceButton.Location = new System.Drawing.Point(701, 560);
            this.checkBalanceButton.Name = "checkBalanceButton";
            this.checkBalanceButton.Size = new System.Drawing.Size(97, 26);
            this.checkBalanceButton.TabIndex = 19;
            this.checkBalanceButton.Text = "Check Balance";
            this.checkBalanceButton.UseVisualStyleBackColor = true;
            this.checkBalanceButton.Click += new System.EventHandler(this.checkBalanceButton_Click);
            // 
            // createBlockAltruisticButton
            // 
            this.createBlockAltruisticButton.Location = new System.Drawing.Point(948, 142);
            this.createBlockAltruisticButton.Name = "createBlockAltruisticButton";
            this.createBlockAltruisticButton.Size = new System.Drawing.Size(120, 49);
            this.createBlockAltruisticButton.TabIndex = 20;
            this.createBlockAltruisticButton.Text = "ALTRUISTIC";
            this.createBlockAltruisticButton.UseVisualStyleBackColor = true;
            this.createBlockAltruisticButton.Click += new System.EventHandler(this.createBlockAltruisticButton_Click);
            // 
            // createBlockUnpredicatbleButton
            // 
            this.createBlockUnpredicatbleButton.Location = new System.Drawing.Point(948, 197);
            this.createBlockUnpredicatbleButton.Name = "createBlockUnpredicatbleButton";
            this.createBlockUnpredicatbleButton.Size = new System.Drawing.Size(120, 49);
            this.createBlockUnpredicatbleButton.TabIndex = 21;
            this.createBlockUnpredicatbleButton.Text = "RANDOM";
            this.createBlockUnpredicatbleButton.UseVisualStyleBackColor = true;
            this.createBlockUnpredicatbleButton.Click += new System.EventHandler(this.createBlockRandomButton_Click);
            // 
            // createBlockGreedyButton
            // 
            this.createBlockGreedyButton.Location = new System.Drawing.Point(948, 252);
            this.createBlockGreedyButton.Name = "createBlockGreedyButton";
            this.createBlockGreedyButton.Size = new System.Drawing.Size(120, 49);
            this.createBlockGreedyButton.TabIndex = 22;
            this.createBlockGreedyButton.Text = "GREEDY";
            this.createBlockGreedyButton.UseVisualStyleBackColor = true;
            this.createBlockGreedyButton.Click += new System.EventHandler(this.createBlockGreedyButton_Click);
            // 
            // createBlockAddressBasedButton
            // 
            this.createBlockAddressBasedButton.Location = new System.Drawing.Point(948, 307);
            this.createBlockAddressBasedButton.Name = "createBlockAddressBasedButton";
            this.createBlockAddressBasedButton.Size = new System.Drawing.Size(120, 49);
            this.createBlockAddressBasedButton.TabIndex = 23;
            this.createBlockAddressBasedButton.Text = "ADDRESS PREFERENCE";
            this.createBlockAddressBasedButton.UseVisualStyleBackColor = true;
            this.createBlockAddressBasedButton.Click += new System.EventHandler(this.createBlockAddressBasedButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(815, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "GENERATE BLOCK:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // BlockchainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1129, 619);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.createBlockAddressBasedButton);
            this.Controls.Add(this.createBlockGreedyButton);
            this.Controls.Add(this.createBlockUnpredicatbleButton);
            this.Controls.Add(this.createBlockAltruisticButton);
            this.Controls.Add(this.checkBalanceButton);
            this.Controls.Add(this.validateChainButton);
            this.Controls.Add(this.recipientKeyTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.feeTextBox);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.createTransactionButton);
            this.Controls.Add(this.createBlockButton);
            this.Controls.Add(this.validateKeys);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.privateKeyTextBox);
            this.Controls.Add(this.publicKeyTextBox);
            this.Controls.Add(this.createWallet);
            this.Controls.Add(this.TextInput);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.TextOutput);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "BlockchainApp";
            this.Text = "Blockchain App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox TextOutput;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.RichTextBox TextInput;
        private System.Windows.Forms.Button createWallet;
        private System.Windows.Forms.TextBox publicKeyTextBox;
        private System.Windows.Forms.TextBox privateKeyTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button validateKeys;
        private System.Windows.Forms.Button createBlockButton;
        private System.Windows.Forms.Button createTransactionButton;
        private System.Windows.Forms.RichTextBox amountTextBox;
        private System.Windows.Forms.RichTextBox feeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox recipientKeyTextBox;
        private System.Windows.Forms.Button validateChainButton;
        private System.Windows.Forms.Button checkBalanceButton;
        private System.Windows.Forms.Button createBlockAltruisticButton;
        private System.Windows.Forms.Button createBlockUnpredicatbleButton;
        private System.Windows.Forms.Button createBlockGreedyButton;
        private System.Windows.Forms.Button createBlockAddressBasedButton;
        private System.Windows.Forms.Label label6;
    }
}

