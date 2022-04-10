
namespace Janelas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnOk = new System.Windows.Forms.Button();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.USUARIO = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BtnOk
            // 
            this.BtnOk.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnOk.ForeColor = System.Drawing.Color.Blue;
            this.BtnOk.Location = new System.Drawing.Point(352, 319);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(75, 23);
            this.BtnOk.TabIndex = 0;
            this.BtnOk.Text = "OK";
            this.BtnOk.UseVisualStyleBackColor = false;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(306, 168);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(171, 23);
            this.TxtUsuario.TabIndex = 1;
            this.TxtUsuario.TextChanged += new System.EventHandler(this.TxtUsuario_TextChanged);
            // 
            // TxtSenha
            // 
            this.TxtSenha.Location = new System.Drawing.Point(306, 244);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.Size = new System.Drawing.Size(171, 23);
            this.TxtSenha.TabIndex = 2;
            this.TxtSenha.UseSystemPasswordChar = true;
            // 
            // USUARIO
            // 
            this.USUARIO.AutoSize = true;
            this.USUARIO.ForeColor = System.Drawing.Color.Blue;
            this.USUARIO.Location = new System.Drawing.Point(369, 194);
            this.USUARIO.Name = "USUARIO";
            this.USUARIO.Size = new System.Drawing.Size(56, 15);
            this.USUARIO.TabIndex = 3;
            this.USUARIO.Text = "USUÁRIO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(369, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "LOGIN";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(209, 367);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(102, 19);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Mostrar Senha";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.USUARIO);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.BtnOk);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.Label USUARIO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

