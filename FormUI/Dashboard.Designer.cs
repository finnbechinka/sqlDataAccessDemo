namespace FormUI
{
    partial class Dashboard
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonMieter = new System.Windows.Forms.Button();
            this.buttonWohnungen = new System.Windows.Forms.Button();
            this.buttonHäuser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMieter
            // 
            this.buttonMieter.Location = new System.Drawing.Point(24, 22);
            this.buttonMieter.Name = "buttonMieter";
            this.buttonMieter.Size = new System.Drawing.Size(105, 47);
            this.buttonMieter.TabIndex = 0;
            this.buttonMieter.Text = "Mieter";
            this.buttonMieter.UseVisualStyleBackColor = true;
            this.buttonMieter.Click += new System.EventHandler(this.buttonMieter_Click);
            // 
            // buttonWohnungen
            // 
            this.buttonWohnungen.Location = new System.Drawing.Point(135, 22);
            this.buttonWohnungen.Name = "buttonWohnungen";
            this.buttonWohnungen.Size = new System.Drawing.Size(151, 47);
            this.buttonWohnungen.TabIndex = 1;
            this.buttonWohnungen.Text = "Wohnungen";
            this.buttonWohnungen.UseVisualStyleBackColor = true;
            this.buttonWohnungen.Click += new System.EventHandler(this.buttonWohnungen_Click);
            // 
            // buttonHäuser
            // 
            this.buttonHäuser.Location = new System.Drawing.Point(292, 22);
            this.buttonHäuser.Name = "buttonHäuser";
            this.buttonHäuser.Size = new System.Drawing.Size(105, 47);
            this.buttonHäuser.TabIndex = 2;
            this.buttonHäuser.Text = "Häuser";
            this.buttonHäuser.UseVisualStyleBackColor = true;
            this.buttonHäuser.Click += new System.EventHandler(this.buttonHäuser_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 95);
            this.Controls.Add(this.buttonHäuser);
            this.Controls.Add(this.buttonWohnungen);
            this.Controls.Add(this.buttonMieter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Dashboard";
            this.Text = "SQL Data Access Demo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMieter;
        private System.Windows.Forms.Button buttonWohnungen;
        private System.Windows.Forms.Button buttonHäuser;
    }
}

