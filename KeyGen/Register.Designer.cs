using PasswordStrengthControlLib;

namespace KeyGen
{
    partial class Register
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
            this.components = new System.ComponentModel.Container();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordStrengthControl2 = new PasswordStrengthControlLib.PasswordStrengthControl();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btRegistrar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btViewPasswd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(15, 143);
            this.textBox2.MaxLength = 50;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(263, 25);
            this.textBox2.TabIndex = 2;
            this.textBox2.UseSystemPasswordChar = true;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Contraseña:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(15, 85);
            this.textBox1.MaxLength = 50;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 25);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Crear nueva cuenta";
            // 
            // passwordStrengthControl2
            // 
            this.passwordStrengthControl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.passwordStrengthControl2.BorderColor = System.Drawing.Color.Lime;
            this.passwordStrengthControl2.ControlStyle = PasswordStrengthControlLib.StrengthStyle.Gradient;
            this.passwordStrengthControl2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordStrengthControl2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.passwordStrengthControl2.ForeGroundColor = System.Drawing.Color.Yellow;
            this.passwordStrengthControl2.Location = new System.Drawing.Point(15, 174);
            this.passwordStrengthControl2.Name = "passwordStrengthControl2";
            this.passwordStrengthControl2.SegmentationGap = 0;
            this.passwordStrengthControl2.SegmentWidth = 16;
            this.passwordStrengthControl2.Size = new System.Drawing.Size(127, 20);
            this.passwordStrengthControl2.StrengthText = "Weak";
            this.passwordStrengthControl2.TabIndex = 9;
            this.passwordStrengthControl2.Text = "passwordStrengthControl2";
            this.passwordStrengthControl2.TextAlignment = PasswordStrengthControlLib.TextStyle.None;
            this.passwordStrengthControl2.StrengthChangedEventHandler += new PasswordStrengthControlLib.PasswordStrengthChangedEventHandler(this.passwordStrengthControl2_StrengthChangedEventHandler);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(148, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Repite la contraseña:";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(15, 232);
            this.textBox3.MaxLength = 50;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(263, 25);
            this.textBox3.TabIndex = 3;
            this.textBox3.UseSystemPasswordChar = true;
            // 
            // btRegistrar
            // 
            this.btRegistrar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegistrar.Location = new System.Drawing.Point(15, 293);
            this.btRegistrar.Name = "btRegistrar";
            this.btRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btRegistrar.TabIndex = 4;
            this.btRegistrar.Text = "Registrar";
            this.btRegistrar.UseVisualStyleBackColor = true;
            this.btRegistrar.Click += new System.EventHandler(this.btRegistrar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(96, 293);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 5;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(12, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 14);
            this.label6.TabIndex = 27;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::KeyGen.Properties.Resources.singup;
            this.pictureBox2.Location = new System.Drawing.Point(12, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // btViewPasswd
            // 
            this.btViewPasswd.Image = global::KeyGen.Properties.Resources.eye;
            this.btViewPasswd.Location = new System.Drawing.Point(284, 143);
            this.btViewPasswd.Name = "btViewPasswd";
            this.btViewPasswd.Size = new System.Drawing.Size(42, 25);
            this.btViewPasswd.TabIndex = 6;
            this.btViewPasswd.UseVisualStyleBackColor = true;
            this.btViewPasswd.Click += new System.EventHandler(this.btViewPasswd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::KeyGen.Properties.Resources.slide3_bg;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 348);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btRegistrar);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btViewPasswd);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.passwordStrengthControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Register_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Register_FormClosed);
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btViewPasswd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private PasswordStrengthControl passwordStrengthControl2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btRegistrar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}