namespace FormUI
{
    partial class FensterHäuser
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
            this.InsertRecordButton = new System.Windows.Forms.Button();
            this.adresseIns = new System.Windows.Forms.Label();
            this.adresseInsText = new System.Windows.Forms.TextBox();
            this.hausmeisterTelIns = new System.Windows.Forms.Label();
            this.hausmeisterTelInsText = new System.Windows.Forms.TextBox();
            this.bezeichnungIns = new System.Windows.Forms.Label();
            this.bezeichnungInsText = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.BezeichnungLabel = new System.Windows.Forms.Label();
            this.HäuserFoundListBox = new System.Windows.Forms.ListBox();
            this.BezeichnungText = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.HausIDText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InsertRecordButton
            // 
            this.InsertRecordButton.BackColor = System.Drawing.Color.YellowGreen;
            this.InsertRecordButton.Location = new System.Drawing.Point(12, 574);
            this.InsertRecordButton.Name = "InsertRecordButton";
            this.InsertRecordButton.Size = new System.Drawing.Size(122, 40);
            this.InsertRecordButton.TabIndex = 23;
            this.InsertRecordButton.Text = "Insert";
            this.InsertRecordButton.UseVisualStyleBackColor = false;
            this.InsertRecordButton.Click += new System.EventHandler(this.InsertRecordButton_Click);
            // 
            // adresseIns
            // 
            this.adresseIns.AutoSize = true;
            this.adresseIns.Location = new System.Drawing.Point(7, 444);
            this.adresseIns.Name = "adresseIns";
            this.adresseIns.Size = new System.Drawing.Size(45, 13);
            this.adresseIns.TabIndex = 22;
            this.adresseIns.Text = "Adresse";
            // 
            // adresseInsText
            // 
            this.adresseInsText.Location = new System.Drawing.Point(174, 441);
            this.adresseInsText.Name = "adresseInsText";
            this.adresseInsText.Size = new System.Drawing.Size(261, 20);
            this.adresseInsText.TabIndex = 21;
            // 
            // hausmeisterTelIns
            // 
            this.hausmeisterTelIns.AutoSize = true;
            this.hausmeisterTelIns.Location = new System.Drawing.Point(7, 486);
            this.hausmeisterTelIns.Name = "hausmeisterTelIns";
            this.hausmeisterTelIns.Size = new System.Drawing.Size(80, 13);
            this.hausmeisterTelIns.TabIndex = 20;
            this.hausmeisterTelIns.Text = "HausmeisterTel";
            // 
            // hausmeisterTelInsText
            // 
            this.hausmeisterTelInsText.Location = new System.Drawing.Point(174, 483);
            this.hausmeisterTelInsText.Name = "hausmeisterTelInsText";
            this.hausmeisterTelInsText.Size = new System.Drawing.Size(261, 20);
            this.hausmeisterTelInsText.TabIndex = 19;
            // 
            // bezeichnungIns
            // 
            this.bezeichnungIns.AutoSize = true;
            this.bezeichnungIns.Location = new System.Drawing.Point(7, 398);
            this.bezeichnungIns.Name = "bezeichnungIns";
            this.bezeichnungIns.Size = new System.Drawing.Size(69, 13);
            this.bezeichnungIns.TabIndex = 18;
            this.bezeichnungIns.Text = "Bezeichnung";
            // 
            // bezeichnungInsText
            // 
            this.bezeichnungInsText.Location = new System.Drawing.Point(174, 395);
            this.bezeichnungInsText.Name = "bezeichnungInsText";
            this.bezeichnungInsText.Size = new System.Drawing.Size(261, 20);
            this.bezeichnungInsText.TabIndex = 17;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(174, 50);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(122, 40);
            this.SearchButton.TabIndex = 16;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // BezeichnungLabel
            // 
            this.BezeichnungLabel.AutoSize = true;
            this.BezeichnungLabel.Location = new System.Drawing.Point(7, 12);
            this.BezeichnungLabel.Name = "BezeichnungLabel";
            this.BezeichnungLabel.Size = new System.Drawing.Size(69, 13);
            this.BezeichnungLabel.TabIndex = 15;
            this.BezeichnungLabel.Text = "Bezeichnung";
            // 
            // HäuserFoundListBox
            // 
            this.HäuserFoundListBox.FormattingEnabled = true;
            this.HäuserFoundListBox.Location = new System.Drawing.Point(12, 96);
            this.HäuserFoundListBox.Name = "HäuserFoundListBox";
            this.HäuserFoundListBox.Size = new System.Drawing.Size(423, 277);
            this.HäuserFoundListBox.TabIndex = 14;
            // 
            // BezeichnungText
            // 
            this.BezeichnungText.Location = new System.Drawing.Point(174, 9);
            this.BezeichnungText.Name = "BezeichnungText";
            this.BezeichnungText.Size = new System.Drawing.Size(261, 20);
            this.BezeichnungText.TabIndex = 13;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Coral;
            this.DeleteButton.Location = new System.Drawing.Point(313, 574);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(122, 40);
            this.DeleteButton.TabIndex = 24;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.Orange;
            this.UpdateButton.Location = new System.Drawing.Point(167, 574);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(122, 40);
            this.UpdateButton.TabIndex = 25;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // HausIDText
            // 
            this.HausIDText.Location = new System.Drawing.Point(313, 545);
            this.HausIDText.Name = "HausIDText";
            this.HausIDText.Size = new System.Drawing.Size(42, 20);
            this.HausIDText.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 548);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "HausID (Update&Delete)";
            // 
            // FensterHäuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 640);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HausIDText);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.InsertRecordButton);
            this.Controls.Add(this.adresseIns);
            this.Controls.Add(this.adresseInsText);
            this.Controls.Add(this.hausmeisterTelIns);
            this.Controls.Add(this.hausmeisterTelInsText);
            this.Controls.Add(this.bezeichnungIns);
            this.Controls.Add(this.bezeichnungInsText);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.BezeichnungLabel);
            this.Controls.Add(this.HäuserFoundListBox);
            this.Controls.Add(this.BezeichnungText);
            this.Name = "FensterHäuser";
            this.Text = "Häuser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InsertRecordButton;
        private System.Windows.Forms.Label adresseIns;
        private System.Windows.Forms.TextBox adresseInsText;
        private System.Windows.Forms.Label hausmeisterTelIns;
        private System.Windows.Forms.TextBox hausmeisterTelInsText;
        private System.Windows.Forms.Label bezeichnungIns;
        private System.Windows.Forms.TextBox bezeichnungInsText;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label BezeichnungLabel;
        private System.Windows.Forms.ListBox HäuserFoundListBox;
        private System.Windows.Forms.TextBox BezeichnungText;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.TextBox HausIDText;
        private System.Windows.Forms.Label label1;
    }
}