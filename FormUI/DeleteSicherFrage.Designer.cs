namespace FormUI
{
    partial class DeleteSicherFrage
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
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonJa = new System.Windows.Forms.Button();
            this.ButtonNein = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Möchten Sie wirklich Löschen?";
            // 
            // ButtonJa
            // 
            this.ButtonJa.BackColor = System.Drawing.Color.LightGreen;
            this.ButtonJa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ButtonJa.Location = new System.Drawing.Point(161, 38);
            this.ButtonJa.Name = "ButtonJa";
            this.ButtonJa.Size = new System.Drawing.Size(78, 33);
            this.ButtonJa.TabIndex = 1;
            this.ButtonJa.Text = "Ja";
            this.ButtonJa.UseVisualStyleBackColor = false;
            this.ButtonJa.Click += new System.EventHandler(this.ButtonJa_Click);
            // 
            // ButtonNein
            // 
            this.ButtonNein.BackColor = System.Drawing.Color.LightCoral;
            this.ButtonNein.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ButtonNein.Location = new System.Drawing.Point(245, 38);
            this.ButtonNein.Name = "ButtonNein";
            this.ButtonNein.Size = new System.Drawing.Size(78, 33);
            this.ButtonNein.TabIndex = 2;
            this.ButtonNein.Text = "Nein";
            this.ButtonNein.UseVisualStyleBackColor = false;
            this.ButtonNein.Click += new System.EventHandler(this.ButtonNein_Click);
            // 
            // DeleteSicherFrage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 84);
            this.Controls.Add(this.ButtonNein);
            this.Controls.Add(this.ButtonJa);
            this.Controls.Add(this.label1);
            this.Name = "DeleteSicherFrage";
            this.Text = "DeleteSicherFrage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonJa;
        private System.Windows.Forms.Button ButtonNein;
    }
}