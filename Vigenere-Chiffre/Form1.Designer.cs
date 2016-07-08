namespace Vigenère_Chiffre
{
    partial class Vigenere
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
            this.lbl_output = new System.Windows.Forms.Label();
            this.lbl_input = new System.Windows.Forms.Label();
            this.box_output = new System.Windows.Forms.RichTextBox();
            this.box_input = new System.Windows.Forms.RichTextBox();
            this.rad_decrypt = new System.Windows.Forms.RadioButton();
            this.rad_encrypt = new System.Windows.Forms.RadioButton();
            this.btn_execute = new System.Windows.Forms.Button();
            this.lbl_key = new System.Windows.Forms.Label();
            this.box_key = new System.Windows.Forms.TextBox();
            this.check_settings = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbl_output
            // 
            this.lbl_output.AutoSize = true;
            this.lbl_output.Location = new System.Drawing.Point(236, 141);
            this.lbl_output.Name = "lbl_output";
            this.lbl_output.Size = new System.Drawing.Size(76, 13);
            this.lbl_output.TabIndex = 15;
            this.lbl_output.Text = "Text Ausgabe:";
            // 
            // lbl_input
            // 
            this.lbl_input.AutoSize = true;
            this.lbl_input.Location = new System.Drawing.Point(12, 141);
            this.lbl_input.Name = "lbl_input";
            this.lbl_input.Size = new System.Drawing.Size(73, 13);
            this.lbl_input.TabIndex = 14;
            this.lbl_input.Text = "Text Eingabe:";
            // 
            // box_output
            // 
            this.box_output.Location = new System.Drawing.Point(239, 157);
            this.box_output.Name = "box_output";
            this.box_output.ReadOnly = true;
            this.box_output.Size = new System.Drawing.Size(205, 197);
            this.box_output.TabIndex = 13;
            this.box_output.Text = "";
            // 
            // box_input
            // 
            this.box_input.Location = new System.Drawing.Point(12, 157);
            this.box_input.Name = "box_input";
            this.box_input.Size = new System.Drawing.Size(205, 197);
            this.box_input.TabIndex = 12;
            this.box_input.Text = "";
            // 
            // rad_decrypt
            // 
            this.rad_decrypt.AutoSize = true;
            this.rad_decrypt.Location = new System.Drawing.Point(12, 72);
            this.rad_decrypt.Name = "rad_decrypt";
            this.rad_decrypt.Size = new System.Drawing.Size(90, 17);
            this.rad_decrypt.TabIndex = 11;
            this.rad_decrypt.TabStop = true;
            this.rad_decrypt.Text = "Entschlüsseln";
            this.rad_decrypt.UseVisualStyleBackColor = true;
            // 
            // rad_encrypt
            // 
            this.rad_encrypt.AutoSize = true;
            this.rad_encrypt.Checked = true;
            this.rad_encrypt.Location = new System.Drawing.Point(12, 48);
            this.rad_encrypt.Name = "rad_encrypt";
            this.rad_encrypt.Size = new System.Drawing.Size(90, 17);
            this.rad_encrypt.TabIndex = 10;
            this.rad_encrypt.TabStop = true;
            this.rad_encrypt.Text = "Verschlüsseln";
            this.rad_encrypt.UseVisualStyleBackColor = true;
            // 
            // btn_execute
            // 
            this.btn_execute.Location = new System.Drawing.Point(12, 360);
            this.btn_execute.Name = "btn_execute";
            this.btn_execute.Size = new System.Drawing.Size(432, 23);
            this.btn_execute.TabIndex = 9;
            this.btn_execute.Text = "Ausführen";
            this.btn_execute.UseVisualStyleBackColor = true;
            this.btn_execute.Click += new System.EventHandler(this.btn_execute_Click);
            // 
            // lbl_key
            // 
            this.lbl_key.AutoSize = true;
            this.lbl_key.Location = new System.Drawing.Point(9, 15);
            this.lbl_key.Name = "lbl_key";
            this.lbl_key.Size = new System.Drawing.Size(55, 13);
            this.lbl_key.TabIndex = 16;
            this.lbl_key.Text = "Schlüssel:";
            // 
            // box_key
            // 
            this.box_key.Location = new System.Drawing.Point(70, 12);
            this.box_key.Name = "box_key";
            this.box_key.Size = new System.Drawing.Size(100, 20);
            this.box_key.TabIndex = 17;
            // 
            // check_settings
            // 
            this.check_settings.AutoSize = true;
            this.check_settings.Location = new System.Drawing.Point(12, 104);
            this.check_settings.Name = "check_settings";
            this.check_settings.Size = new System.Drawing.Size(355, 17);
            this.check_settings.TabIndex = 18;
            this.check_settings.Text = " Leer-, Satz- und Sonderzeichen \"verbrauchen\" Schlüsselbuchstaben";
            this.check_settings.UseVisualStyleBackColor = true;
            // 
            // Vigenere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 394);
            this.Controls.Add(this.check_settings);
            this.Controls.Add(this.box_key);
            this.Controls.Add(this.lbl_key);
            this.Controls.Add(this.lbl_output);
            this.Controls.Add(this.lbl_input);
            this.Controls.Add(this.box_output);
            this.Controls.Add(this.box_input);
            this.Controls.Add(this.rad_decrypt);
            this.Controls.Add(this.rad_encrypt);
            this.Controls.Add(this.btn_execute);
            this.MaximizeBox = false;
            this.Name = "Vigenere";
            this.Text = "Vigenère-Chiffre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_output;
        private System.Windows.Forms.Label lbl_input;
        private System.Windows.Forms.RichTextBox box_output;
        private System.Windows.Forms.RichTextBox box_input;
        private System.Windows.Forms.RadioButton rad_decrypt;
        private System.Windows.Forms.RadioButton rad_encrypt;
        private System.Windows.Forms.Button btn_execute;
        private System.Windows.Forms.Label lbl_key;
        private System.Windows.Forms.TextBox box_key;
        private System.Windows.Forms.CheckBox check_settings;
    }
}

