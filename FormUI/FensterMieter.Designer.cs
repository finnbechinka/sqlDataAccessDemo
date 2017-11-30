namespace FormUI
{
    partial class FensterMieter
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
            this.label9 = new System.Windows.Forms.Label();
            this.WohnungsIDInsText = new System.Windows.Forms.TextBox();
            this.InsertRecordButtonMieter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.VornameInsText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TelInsText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NachnameInsText = new System.Windows.Forms.TextBox();
            this.SearchButtonMieter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.MieterFoundListBox = new System.Windows.Forms.ListBox();
            this.NachnameText = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.MieterIDText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 520);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "WohnungsID";
            // 
            // WohnungsIDInsText
            // 
            this.WohnungsIDInsText.Location = new System.Drawing.Point(174, 517);
            this.WohnungsIDInsText.Name = "WohnungsIDInsText";
            this.WohnungsIDInsText.Size = new System.Drawing.Size(261, 20);
            this.WohnungsIDInsText.TabIndex = 48;
            // 
            // InsertRecordButtonMieter
            // 
            this.InsertRecordButtonMieter.BackColor = System.Drawing.Color.YellowGreen;
            this.InsertRecordButtonMieter.Location = new System.Drawing.Point(10, 608);
            this.InsertRecordButtonMieter.Name = "InsertRecordButtonMieter";
            this.InsertRecordButtonMieter.Size = new System.Drawing.Size(122, 40);
            this.InsertRecordButtonMieter.TabIndex = 47;
            this.InsertRecordButtonMieter.Text = "Insert";
            this.InsertRecordButtonMieter.UseVisualStyleBackColor = false;
            this.InsertRecordButtonMieter.Click += new System.EventHandler(this.InsertRecordButtonMieter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Vorname";
            // 
            // VornameInsText
            // 
            this.VornameInsText.Location = new System.Drawing.Point(174, 438);
            this.VornameInsText.Name = "VornameInsText";
            this.VornameInsText.Size = new System.Drawing.Size(261, 20);
            this.VornameInsText.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 483);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Tel";
            // 
            // TelInsText
            // 
            this.TelInsText.Location = new System.Drawing.Point(174, 480);
            this.TelInsText.Name = "TelInsText";
            this.TelInsText.Size = new System.Drawing.Size(261, 20);
            this.TelInsText.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Nachname";
            // 
            // NachnameInsText
            // 
            this.NachnameInsText.Location = new System.Drawing.Point(174, 392);
            this.NachnameInsText.Name = "NachnameInsText";
            this.NachnameInsText.Size = new System.Drawing.Size(261, 20);
            this.NachnameInsText.TabIndex = 41;
            // 
            // SearchButtonMieter
            // 
            this.SearchButtonMieter.Location = new System.Drawing.Point(174, 47);
            this.SearchButtonMieter.Name = "SearchButtonMieter";
            this.SearchButtonMieter.Size = new System.Drawing.Size(122, 40);
            this.SearchButtonMieter.TabIndex = 40;
            this.SearchButtonMieter.Text = "Search";
            this.SearchButtonMieter.UseVisualStyleBackColor = true;
            this.SearchButtonMieter.Click += new System.EventHandler(this.SearchButtonMieter_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Nachname";
            // 
            // MieterFoundListBox
            // 
            this.MieterFoundListBox.FormattingEnabled = true;
            this.MieterFoundListBox.Location = new System.Drawing.Point(12, 93);
            this.MieterFoundListBox.Name = "MieterFoundListBox";
            this.MieterFoundListBox.Size = new System.Drawing.Size(423, 277);
            this.MieterFoundListBox.TabIndex = 38;
            // 
            // NachnameText
            // 
            this.NachnameText.Location = new System.Drawing.Point(174, 6);
            this.NachnameText.Name = "NachnameText";
            this.NachnameText.Size = new System.Drawing.Size(261, 20);
            this.NachnameText.TabIndex = 37;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Coral;
            this.DeleteButton.Location = new System.Drawing.Point(329, 608);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(122, 40);
            this.DeleteButton.TabIndex = 50;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.Orange;
            this.UpdateButton.Location = new System.Drawing.Point(174, 608);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(122, 40);
            this.UpdateButton.TabIndex = 51;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 585);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "MieterID (Update&Delete)";
            // 
            // MieterIDText
            // 
            this.MieterIDText.Location = new System.Drawing.Point(329, 582);
            this.MieterIDText.Name = "MieterIDText";
            this.MieterIDText.Size = new System.Drawing.Size(84, 20);
            this.MieterIDText.TabIndex = 52;
            // 
            // FensterMieter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 660);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MieterIDText);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.WohnungsIDInsText);
            this.Controls.Add(this.InsertRecordButtonMieter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VornameInsText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TelInsText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NachnameInsText);
            this.Controls.Add(this.SearchButtonMieter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MieterFoundListBox);
            this.Controls.Add(this.NachnameText);
            this.Name = "FensterMieter";
            this.Text = "Mieter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox WohnungsIDInsText;
        private System.Windows.Forms.Button InsertRecordButtonMieter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox VornameInsText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TelInsText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NachnameInsText;
        private System.Windows.Forms.Button SearchButtonMieter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox MieterFoundListBox;
        private System.Windows.Forms.TextBox NachnameText;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MieterIDText;
    }
}