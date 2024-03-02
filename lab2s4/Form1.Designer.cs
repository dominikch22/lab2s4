namespace lab2s4
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
            this.personsList = new System.Windows.Forms.ListBox();
            this.addPersonButton = new System.Windows.Forms.Button();
            this.AddOnePersonButton = new System.Windows.Forms.Button();
            this.editPersonButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // personsList
            // 
            this.personsList.FormattingEnabled = true;
            this.personsList.ItemHeight = 20;
            this.personsList.Location = new System.Drawing.Point(20, 20);
            this.personsList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.personsList.Name = "personsList";
            this.personsList.Size = new System.Drawing.Size(571, 524);
            this.personsList.TabIndex = 0;
            this.personsList.SelectedIndexChanged += new System.EventHandler(this.personsList_SelectedIndexChanged);
            // 
            // addPersonButton
            // 
            this.addPersonButton.Location = new System.Drawing.Point(480, 555);
            this.addPersonButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addPersonButton.Name = "addPersonButton";
            this.addPersonButton.Size = new System.Drawing.Size(112, 35);
            this.addPersonButton.TabIndex = 1;
            this.addPersonButton.Text = "Dodaj";
            this.addPersonButton.UseVisualStyleBackColor = true;
            this.addPersonButton.Click += new System.EventHandler(this.addPersonButton_Click);
            // 
            // AddOnePersonButton
            // 
            this.AddOnePersonButton.Location = new System.Drawing.Point(358, 555);
            this.AddOnePersonButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddOnePersonButton.Name = "AddOnePersonButton";
            this.AddOnePersonButton.Size = new System.Drawing.Size(112, 35);
            this.AddOnePersonButton.TabIndex = 2;
            this.AddOnePersonButton.Text = "Dodaj jedna";
            this.AddOnePersonButton.UseVisualStyleBackColor = true;
            this.AddOnePersonButton.Click += new System.EventHandler(this.AddOnePersonButton_Click);
            // 
            // editPersonButton
            // 
            this.editPersonButton.Location = new System.Drawing.Point(238, 554);
            this.editPersonButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editPersonButton.Name = "editPersonButton";
            this.editPersonButton.Size = new System.Drawing.Size(112, 35);
            this.editPersonButton.TabIndex = 3;
            this.editPersonButton.Text = "Edytuj";
            this.editPersonButton.UseVisualStyleBackColor = true;
            this.editPersonButton.Click += new System.EventHandler(this.editPersonButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 610);
            this.Controls.Add(this.editPersonButton);
            this.Controls.Add(this.AddOnePersonButton);
            this.Controls.Add(this.addPersonButton);
            this.Controls.Add(this.personsList);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Okienka i wydarzenia";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox personsList;
        private System.Windows.Forms.Button addPersonButton;
        private System.Windows.Forms.Button AddOnePersonButton;
        private System.Windows.Forms.Button editPersonButton;
    }
}

