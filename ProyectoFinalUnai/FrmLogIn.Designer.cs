
namespace ProyectoFinalUnai
{
    partial class FrmLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogIn));
            this.PcbLogo = new System.Windows.Forms.PictureBox();
            this.PcbFotoD = new System.Windows.Forms.PictureBox();
            this.PcbFotoI = new System.Windows.Forms.PictureBox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.PnlGeneral = new System.Windows.Forms.Panel();
            this.PcbLogIn = new System.Windows.Forms.PictureBox();
            this.LblRecordar = new System.Windows.Forms.Label();
            this.PnlDerecho = new System.Windows.Forms.Panel();
            this.PnlIzquierdo = new System.Windows.Forms.Panel();
            this.TxtUsuario = new ProyectoFinalUnai.RJTextBox();
            this.TxtPassword = new ProyectoFinalUnai.RJTextBox();
            this.PnlAbajo = new System.Windows.Forms.Panel();
            this.PnlArriba = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LblReg1 = new System.Windows.Forms.Label();
            this.LblReg2 = new System.Windows.Forms.Label();
            this.ChbRecordar = new ProyectoFinalUnai.RJToggleButton();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbFotoD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbFotoI)).BeginInit();
            this.PnlGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogIn)).BeginInit();
            this.PnlArriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // PcbLogo
            // 
            this.PcbLogo.BackColor = System.Drawing.Color.Transparent;
            this.PcbLogo.Image = global::ProyectoFinalUnai.Properties.Resources.Logo;
            this.PcbLogo.Location = new System.Drawing.Point(428, 0);
            this.PcbLogo.Name = "PcbLogo";
            this.PcbLogo.Size = new System.Drawing.Size(200, 150);
            this.PcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbLogo.TabIndex = 2;
            this.PcbLogo.TabStop = false;
            // 
            // PcbFotoD
            // 
            this.PcbFotoD.BackColor = System.Drawing.Color.Transparent;
            this.PcbFotoD.Location = new System.Drawing.Point(798, 303);
            this.PcbFotoD.Name = "PcbFotoD";
            this.PcbFotoD.Size = new System.Drawing.Size(185, 249);
            this.PcbFotoD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbFotoD.TabIndex = 1;
            this.PcbFotoD.TabStop = false;
            // 
            // PcbFotoI
            // 
            this.PcbFotoI.BackColor = System.Drawing.Color.Transparent;
            this.PcbFotoI.Image = global::ProyectoFinalUnai.Properties.Resources.Naruto;
            this.PcbFotoI.Location = new System.Drawing.Point(-10, 338);
            this.PcbFotoI.Name = "PcbFotoI";
            this.PcbFotoI.Size = new System.Drawing.Size(300, 200);
            this.PcbFotoI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbFotoI.TabIndex = 3;
            this.PcbFotoI.TabStop = false;
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.BackColor = System.Drawing.Color.Transparent;
            this.LblPassword.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.Location = new System.Drawing.Point(53, 134);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(119, 22);
            this.LblPassword.TabIndex = 2;
            this.LblPassword.Text = "Contraseña";
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.LblUsuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.Location = new System.Drawing.Point(53, 39);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(75, 22);
            this.LblUsuario.TabIndex = 1;
            this.LblUsuario.Text = "Usuario";
            // 
            // PnlGeneral
            // 
            this.PnlGeneral.BackColor = System.Drawing.Color.Transparent;
            this.PnlGeneral.Controls.Add(this.PcbLogIn);
            this.PnlGeneral.Controls.Add(this.LblRecordar);
            this.PnlGeneral.Controls.Add(this.PnlDerecho);
            this.PnlGeneral.Controls.Add(this.PnlIzquierdo);
            this.PnlGeneral.Controls.Add(this.LblPassword);
            this.PnlGeneral.Controls.Add(this.TxtUsuario);
            this.PnlGeneral.Controls.Add(this.TxtPassword);
            this.PnlGeneral.Controls.Add(this.PnlAbajo);
            this.PnlGeneral.Controls.Add(this.LblUsuario);
            this.PnlGeneral.Controls.Add(this.PnlArriba);
            this.PnlGeneral.Location = new System.Drawing.Point(343, 170);
            this.PnlGeneral.Name = "PnlGeneral";
            this.PnlGeneral.Size = new System.Drawing.Size(369, 317);
            this.PnlGeneral.TabIndex = 4;
            // 
            // PcbLogIn
            // 
            this.PcbLogIn.Image = global::ProyectoFinalUnai.Properties.Resources.LogIn;
            this.PcbLogIn.Location = new System.Drawing.Point(100, 235);
            this.PcbLogIn.Name = "PcbLogIn";
            this.PcbLogIn.Size = new System.Drawing.Size(160, 60);
            this.PcbLogIn.TabIndex = 6;
            this.PcbLogIn.TabStop = false;
            this.PcbLogIn.Click += new System.EventHandler(this.PcbLogIn_Click);
            // 
            // LblRecordar
            // 
            this.LblRecordar.AutoSize = true;
            this.LblRecordar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRecordar.Location = new System.Drawing.Point(54, 193);
            this.LblRecordar.Name = "LblRecordar";
            this.LblRecordar.Size = new System.Drawing.Size(84, 16);
            this.LblRecordar.TabIndex = 5;
            this.LblRecordar.Text = "Recordarme";
            // 
            // PnlDerecho
            // 
            this.PnlDerecho.BackColor = System.Drawing.Color.DodgerBlue;
            this.PnlDerecho.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnlDerecho.Location = new System.Drawing.Point(368, 1);
            this.PnlDerecho.Name = "PnlDerecho";
            this.PnlDerecho.Size = new System.Drawing.Size(1, 315);
            this.PnlDerecho.TabIndex = 3;
            // 
            // PnlIzquierdo
            // 
            this.PnlIzquierdo.BackColor = System.Drawing.Color.DodgerBlue;
            this.PnlIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlIzquierdo.Location = new System.Drawing.Point(0, 1);
            this.PnlIzquierdo.Name = "PnlIzquierdo";
            this.PnlIzquierdo.Size = new System.Drawing.Size(1, 315);
            this.PnlIzquierdo.TabIndex = 2;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.AcceptReturn = false;
            this.TxtUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.TxtUsuario.BoderSize = 2;
            this.TxtUsuario.BorderColor = System.Drawing.SystemColors.ControlText;
            this.TxtUsuario.BorderRadius = 15;
            this.TxtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.TxtUsuario.Location = new System.Drawing.Point(57, 64);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Padding = new System.Windows.Forms.Padding(7);
            this.TxtUsuario.passwordChar = false;
            this.TxtUsuario.Size = new System.Drawing.Size(250, 31);
            this.TxtUsuario.TabIndex = 0;
            this.TxtUsuario.Texts = "";
            this.TxtUsuario.Underlinedstyle = false;
            // 
            // TxtPassword
            // 
            this.TxtPassword.AcceptReturn = false;
            this.TxtPassword.BackColor = System.Drawing.SystemColors.Window;
            this.TxtPassword.BoderSize = 2;
            this.TxtPassword.BorderColor = System.Drawing.SystemColors.ControlText;
            this.TxtPassword.BorderRadius = 15;
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.ForeColor = System.Drawing.Color.DimGray;
            this.TxtPassword.Location = new System.Drawing.Point(57, 159);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Padding = new System.Windows.Forms.Padding(7);
            this.TxtPassword.passwordChar = true;
            this.TxtPassword.Size = new System.Drawing.Size(250, 31);
            this.TxtPassword.TabIndex = 1;
            this.TxtPassword.Texts = "";
            this.TxtPassword.Underlinedstyle = false;
            // 
            // PnlAbajo
            // 
            this.PnlAbajo.BackColor = System.Drawing.Color.DodgerBlue;
            this.PnlAbajo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlAbajo.Location = new System.Drawing.Point(0, 316);
            this.PnlAbajo.Name = "PnlAbajo";
            this.PnlAbajo.Size = new System.Drawing.Size(369, 1);
            this.PnlAbajo.TabIndex = 1;
            // 
            // PnlArriba
            // 
            this.PnlArriba.BackColor = System.Drawing.Color.DodgerBlue;
            this.PnlArriba.Controls.Add(this.pictureBox1);
            this.PnlArriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlArriba.Location = new System.Drawing.Point(0, 0);
            this.PnlArriba.Name = "PnlArriba";
            this.PnlArriba.Size = new System.Drawing.Size(369, 1);
            this.PnlArriba.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::ProyectoFinalUnai.Properties.Resources.Patron;
            this.pictureBox2.Location = new System.Drawing.Point(428, 156);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 25);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // LblReg1
            // 
            this.LblReg1.AutoSize = true;
            this.LblReg1.BackColor = System.Drawing.Color.Transparent;
            this.LblReg1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblReg1.Location = new System.Drawing.Point(397, 490);
            this.LblReg1.Name = "LblReg1";
            this.LblReg1.Size = new System.Drawing.Size(152, 21);
            this.LblReg1.TabIndex = 6;
            this.LblReg1.Text = "No tienes cuenta, ";
            // 
            // LblReg2
            // 
            this.LblReg2.AutoSize = true;
            this.LblReg2.BackColor = System.Drawing.Color.Transparent;
            this.LblReg2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblReg2.ForeColor = System.Drawing.Color.Blue;
            this.LblReg2.Location = new System.Drawing.Point(542, 490);
            this.LblReg2.Name = "LblReg2";
            this.LblReg2.Size = new System.Drawing.Size(84, 21);
            this.LblReg2.TabIndex = 7;
            this.LblReg2.Text = "R̲e̲g̲i̲s̲t̲r̲a̲t̲e̲";
            this.LblReg2.Click += new System.EventHandler(this.LblReg2_Click);
            this.LblReg2.MouseEnter += new System.EventHandler(this.LblReg2_MouseEnter);
            this.LblReg2.MouseLeave += new System.EventHandler(this.LblReg2_MouseLeave);
            // 
            // ChbRecordar
            // 
            this.ChbRecordar.AutoSize = true;
            this.ChbRecordar.Location = new System.Drawing.Point(480, 360);
            this.ChbRecordar.MinimumSize = new System.Drawing.Size(45, 22);
            this.ChbRecordar.Name = "ChbRecordar";
            this.ChbRecordar.OffBackColor = System.Drawing.Color.Gray;
            this.ChbRecordar.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.ChbRecordar.OnBackColor = System.Drawing.Color.DodgerBlue;
            this.ChbRecordar.OnToggleColor = System.Drawing.Color.MidnightBlue;
            this.ChbRecordar.Size = new System.Drawing.Size(45, 22);
            this.ChbRecordar.SolidState = true;
            this.ChbRecordar.TabIndex = 4;
            this.ChbRecordar.TabStop = false;
            this.ChbRecordar.UseVisualStyleBackColor = true;
            // 
            // FrmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::ProyectoFinalUnai.Properties.Resources.Textura;
            this.ClientSize = new System.Drawing.Size(1004, 528);
            this.Controls.Add(this.LblReg2);
            this.Controls.Add(this.LblReg1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ChbRecordar);
            this.Controls.Add(this.PnlGeneral);
            this.Controls.Add(this.PcbFotoI);
            this.Controls.Add(this.PcbLogo);
            this.Controls.Add(this.PcbFotoD);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de Sesion Animoment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogIn_FormClosing);
            this.Load += new System.EventHandler(this.FrmLogIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbFotoD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbFotoI)).EndInit();
            this.PnlGeneral.ResumeLayout(false);
            this.PnlGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogIn)).EndInit();
            this.PnlArriba.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox PcbFotoD;
        private System.Windows.Forms.PictureBox PcbLogo;
        private System.Windows.Forms.PictureBox PcbFotoI;
        private RJTextBox TxtPassword;
        private System.Windows.Forms.Label LblUsuario;
        private RJTextBox TxtUsuario;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Panel PnlGeneral;
        private System.Windows.Forms.Panel PnlAbajo;
        private System.Windows.Forms.Panel PnlArriba;
        private System.Windows.Forms.Panel PnlDerecho;
        private System.Windows.Forms.Panel PnlIzquierdo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblRecordar;
        private RJToggleButton ChbRecordar;
        private System.Windows.Forms.PictureBox PcbLogIn;
        private System.Windows.Forms.Label LblReg1;
        private System.Windows.Forms.Label LblReg2;
    }
}