namespace eProdaja_UI
{
    partial class LoginForm
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
            this.odustaniButton = new System.Windows.Forms.Button();
            this.potvrdiButton = new System.Windows.Forms.Button();
            this.lozinkaInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.korisnickoImeInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // odustaniButton
            // 
            this.odustaniButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.odustaniButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.odustaniButton.Location = new System.Drawing.Point(161, 86);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(81, 30);
            this.odustaniButton.TabIndex = 17;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.odustaniButton.UseVisualStyleBackColor = true;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // potvrdiButton
            // 
            this.potvrdiButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.potvrdiButton.Location = new System.Drawing.Point(248, 86);
            this.potvrdiButton.Name = "potvrdiButton";
            this.potvrdiButton.Size = new System.Drawing.Size(81, 30);
            this.potvrdiButton.TabIndex = 16;
            this.potvrdiButton.Text = "Potvrdi";
            this.potvrdiButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.potvrdiButton.UseVisualStyleBackColor = true;
            this.potvrdiButton.Click += new System.EventHandler(this.potvrdiButton_Click);
            // 
            // lozinkaInput
            // 
            this.lozinkaInput.Location = new System.Drawing.Point(122, 49);
            this.lozinkaInput.Name = "lozinkaInput";
            this.lozinkaInput.PasswordChar = '*';
            this.lozinkaInput.Size = new System.Drawing.Size(207, 20);
            this.lozinkaInput.TabIndex = 15;
            this.lozinkaInput.UseWaitCursor = true;
            this.lozinkaInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lozinkaInput_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Lozinka:";
            // 
            // korisnickoImeInput
            // 
            this.korisnickoImeInput.Location = new System.Drawing.Point(122, 23);
            this.korisnickoImeInput.Name = "korisnickoImeInput";
            this.korisnickoImeInput.Size = new System.Drawing.Size(207, 20);
            this.korisnickoImeInput.TabIndex = 13;
            this.korisnickoImeInput.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Korisničko ime ili email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "test";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "test123";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(390, 144);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.potvrdiButton);
            this.Controls.Add(this.lozinkaInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.korisnickoImeInput);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava na sistem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button odustaniButton;
        private System.Windows.Forms.Button potvrdiButton;
        private System.Windows.Forms.TextBox lozinkaInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox korisnickoImeInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}