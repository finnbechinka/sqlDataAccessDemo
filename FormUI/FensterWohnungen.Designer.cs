namespace FormUI
{
    partial class FensterWohnungen
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
            this.label6 = new System.Windows.Forms.Label();
            this.StockwerkInsText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.GrößeInsText = new System.Windows.Forms.TextBox();
            this.label2123 = new System.Windows.Forms.Label();
            this.HausIDInsText = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.WohnungenFoundListBox = new System.Windows.Forms.ListBox();
            this.HausIDText = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.WohnungsIDText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // InsertRecordButton
            // 
            this.InsertRecordButton.BackColor = System.Drawing.Color.YellowGreen;
            this.InsertRecordButton.Location = new System.Drawing.Point(10, 568);
            this.InsertRecordButton.Name = "InsertRecordButton";
            this.InsertRecordButton.Size = new System.Drawing.Size(122, 40);
            this.InsertRecordButton.TabIndex = 58;
            this.InsertRecordButton.Text = "Insert";
            this.InsertRecordButton.UseVisualStyleBackColor = false;
            this.InsertRecordButton.Click += new System.EventHandler(this.InsertRecordButtonWohn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 439);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 57;
            this.label6.Text = "Stockwerk";
            // 
            // StockwerkInsText
            // 
            this.StockwerkInsText.Location = new System.Drawing.Point(174, 436);
            this.StockwerkInsText.Name = "StockwerkInsText";
            this.StockwerkInsText.Size = new System.Drawing.Size(261, 20);
            this.StockwerkInsText.TabIndex = 56;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 481);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "Größe";
            // 
            // GrößeInsText
            // 
            this.GrößeInsText.Location = new System.Drawing.Point(174, 478);
            this.GrößeInsText.Name = "GrößeInsText";
            this.GrößeInsText.Size = new System.Drawing.Size(261, 20);
            this.GrößeInsText.TabIndex = 54;
            // 
            // label2123
            // 
            this.label2123.AutoSize = true;
            this.label2123.Location = new System.Drawing.Point(7, 393);
            this.label2123.Name = "label2123";
            this.label2123.Size = new System.Drawing.Size(43, 13);
            this.label2123.TabIndex = 53;
            this.label2123.Text = "HausID";
            // 
            // HausIDInsText
            // 
            this.HausIDInsText.Location = new System.Drawing.Point(174, 390);
            this.HausIDInsText.Name = "HausIDInsText";
            this.HausIDInsText.Size = new System.Drawing.Size(261, 20);
            this.HausIDInsText.TabIndex = 52;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(174, 45);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(122, 40);
            this.SearchButton.TabIndex = 51;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButtonWohn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 50;
            this.label10.Text = "HausID";
            // 
            // WohnungenFoundListBox
            // 
            this.WohnungenFoundListBox.FormattingEnabled = true;
            this.WohnungenFoundListBox.Location = new System.Drawing.Point(12, 91);
            this.WohnungenFoundListBox.Name = "WohnungenFoundListBox";
            this.WohnungenFoundListBox.Size = new System.Drawing.Size(423, 277);
            this.WohnungenFoundListBox.TabIndex = 49;
            // 
            // HausIDText
            // 
            this.HausIDText.Location = new System.Drawing.Point(174, 4);
            this.HausIDText.Name = "HausIDText";
            this.HausIDText.Size = new System.Drawing.Size(261, 20);
            this.HausIDText.TabIndex = 48;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Coral;
            this.DeleteButton.Location = new System.Drawing.Point(321, 568);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(122, 40);
            this.DeleteButton.TabIndex = 59;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.Orange;
            this.UpdateButton.Location = new System.Drawing.Point(174, 568);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(122, 40);
            this.UpdateButton.TabIndex = 60;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 542);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "WohnungsID (Update&&Delete)";
            // 
            // WohnungsIDText
            // 
            this.WohnungsIDText.Location = new System.Drawing.Point(361, 539);
            this.WohnungsIDText.Name = "WohnungsIDText";
            this.WohnungsIDText.Size = new System.Drawing.Size(74, 20);
            this.WohnungsIDText.TabIndex = 61;
            // 
            // FensterWohnungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 620);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WohnungsIDText);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.InsertRecordButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.StockwerkInsText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.GrößeInsText);
            this.Controls.Add(this.label2123);
            this.Controls.Add(this.HausIDInsText);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.WohnungenFoundListBox);
            this.Controls.Add(this.HausIDText);
            this.Name = "FensterWohnungen";
            this.Text = "Wohnungen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InsertRecordButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox StockwerkInsText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox GrößeInsText;
        private System.Windows.Forms.Label label2123;
        private System.Windows.Forms.TextBox HausIDInsText;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox WohnungenFoundListBox;
        private System.Windows.Forms.TextBox HausIDText;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox WohnungsIDText;
    }
}