namespace lab2s4
{
    partial class PersonOperationWindow
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
            this.nameInput = new System.Windows.Forms.TextBox();
            this.surnameInput = new System.Windows.Forms.TextBox();
            this.birthDateInput = new System.Windows.Forms.TextBox();
            this.cityInput = new System.Windows.Forms.TextBox();
            this.AddPersonButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.closeWindowButton = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(219, 71);
            this.nameInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(148, 26);
            this.nameInput.TabIndex = 1;
            // 
            // surnameInput
            // 
            this.surnameInput.Location = new System.Drawing.Point(219, 111);
            this.surnameInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.surnameInput.Name = "surnameInput";
            this.surnameInput.Size = new System.Drawing.Size(148, 26);
            this.surnameInput.TabIndex = 2;
            // 
            // birthDateInput
            // 
            this.birthDateInput.Location = new System.Drawing.Point(219, 151);
            this.birthDateInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.birthDateInput.Name = "birthDateInput";
            this.birthDateInput.Size = new System.Drawing.Size(148, 26);
            this.birthDateInput.TabIndex = 3;
            // 
            // cityInput
            // 
            this.cityInput.Location = new System.Drawing.Point(219, 191);
            this.cityInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cityInput.Name = "cityInput";
            this.cityInput.Size = new System.Drawing.Size(148, 26);
            this.cityInput.TabIndex = 4;
            // 
            // AddPersonButton
            // 
            this.AddPersonButton.Location = new System.Drawing.Point(256, 272);
            this.AddPersonButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddPersonButton.Name = "AddPersonButton";
            this.AddPersonButton.Size = new System.Drawing.Size(112, 35);
            this.AddPersonButton.TabIndex = 5;
            this.AddPersonButton.Text = "Dodaj";
            this.AddPersonButton.UseVisualStyleBackColor = true;
            this.AddPersonButton.Click += new System.EventHandler(this.AddPersonButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 234);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Miasto zamieszkania:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Data urodzenie:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nazwisko:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Imię: ";
            // 
            // closeWindowButton
            // 
            this.closeWindowButton.Location = new System.Drawing.Point(58, 272);
            this.closeWindowButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.closeWindowButton.Name = "closeWindowButton";
            this.closeWindowButton.Size = new System.Drawing.Size(112, 35);
            this.closeWindowButton.TabIndex = 10;
            this.closeWindowButton.Text = "Anuluj";
            this.closeWindowButton.UseVisualStyleBackColor = true;
            this.closeWindowButton.Click += new System.EventHandler(this.closeWindowButton_Click);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Location = new System.Drawing.Point(82, 316);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(18, 20);
            this.error.TabIndex = 15;
            this.error.Text = "e";
            // 
            // AddPersonWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 383);
            this.Controls.Add(this.error);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeWindowButton);
            this.Controls.Add(this.AddPersonButton);
            this.Controls.Add(this.cityInput);
            this.Controls.Add(this.birthDateInput);
            this.Controls.Add(this.surnameInput);
            this.Controls.Add(this.nameInput);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddPersonWindow";
            this.Text = "AddPersonWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox surnameInput;
        private System.Windows.Forms.TextBox birthDateInput;
        private System.Windows.Forms.TextBox cityInput;
        private System.Windows.Forms.Button AddPersonButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closeWindowButton;
        private System.Windows.Forms.Label error;
    }
}