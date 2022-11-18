
namespace ProyectoFinalUnai
{
    partial class FrmRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistro));
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblApellido = new System.Windows.Forms.Label();
            this.LblCorreo = new System.Windows.Forms.Label();
            this.LblContraseña = new System.Windows.Forms.Label();
            this.LblReContraseña = new System.Windows.Forms.Label();
            this.TtpRegistro = new System.Windows.Forms.ToolTip(this.components);
            this.PcbRegistrar = new System.Windows.Forms.PictureBox();
            this.PcbFotoU = new System.Windows.Forms.PictureBox();
            this.PcbFoto = new System.Windows.Forms.PictureBox();
            this.BtnUrl = new System.Windows.Forms.Button();
            this.BtnArchivo = new System.Windows.Forms.Button();
            this.TxtUrl = new System.Windows.Forms.TextBox();
            this.RdbArchivo = new System.Windows.Forms.RadioButton();
            this.RdbUrl = new System.Windows.Forms.RadioButton();
            this.OfdFotos = new System.Windows.Forms.OpenFileDialog();
            this.PcbVolver = new System.Windows.Forms.PictureBox();
            this.LblRegresar = new System.Windows.Forms.Label();
            this.TxtApellido = new ProyectoFinalUnai.RJTextBox();
            this.TxtReContraseña = new ProyectoFinalUnai.RJTextBox();
            this.TxtContraseña = new ProyectoFinalUnai.RJTextBox();
            this.TxtCorreo = new ProyectoFinalUnai.RJTextBox();
            this.TxtNombre = new ProyectoFinalUnai.RJTextBox();
            this.TxtUsuario = new ProyectoFinalUnai.RJTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PcbRegistrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbFotoU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbVolver)).BeginInit();
            this.SuspendLayout();
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.LblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.Location = new System.Drawing.Point(447, 66);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(93, 25);
            this.LblUsuario.TabIndex = 6;
            this.LblUsuario.Text = "Usuario";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.BackColor = System.Drawing.Color.Transparent;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(447, 146);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(93, 25);
            this.LblNombre.TabIndex = 7;
            this.LblNombre.Text = "Nombre";
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.BackColor = System.Drawing.Color.Transparent;
            this.LblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApellido.Location = new System.Drawing.Point(443, 226);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(97, 25);
            this.LblApellido.TabIndex = 8;
            this.LblApellido.Text = "Apellido";
            // 
            // LblCorreo
            // 
            this.LblCorreo.AutoSize = true;
            this.LblCorreo.BackColor = System.Drawing.Color.Transparent;
            this.LblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCorreo.Location = new System.Drawing.Point(457, 306);
            this.LblCorreo.Name = "LblCorreo";
            this.LblCorreo.Size = new System.Drawing.Size(83, 25);
            this.LblCorreo.TabIndex = 9;
            this.LblCorreo.Text = "Correo";
            // 
            // LblContraseña
            // 
            this.LblContraseña.AutoSize = true;
            this.LblContraseña.BackColor = System.Drawing.Color.Transparent;
            this.LblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContraseña.Location = new System.Drawing.Point(407, 385);
            this.LblContraseña.Name = "LblContraseña";
            this.LblContraseña.Size = new System.Drawing.Size(133, 25);
            this.LblContraseña.TabIndex = 10;
            this.LblContraseña.Text = "Contraseña";
            // 
            // LblReContraseña
            // 
            this.LblReContraseña.AutoSize = true;
            this.LblReContraseña.BackColor = System.Drawing.Color.Transparent;
            this.LblReContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblReContraseña.Location = new System.Drawing.Point(298, 466);
            this.LblReContraseña.Name = "LblReContraseña";
            this.LblReContraseña.Size = new System.Drawing.Size(242, 25);
            this.LblReContraseña.TabIndex = 11;
            this.LblReContraseña.Text = "Confirmar Contraseña";
            // 
            // PcbRegistrar
            // 
            this.PcbRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.PcbRegistrar.Image = ((System.Drawing.Image)(resources.GetObject("PcbRegistrar.Image")));
            this.PcbRegistrar.Location = new System.Drawing.Point(46, 414);
            this.PcbRegistrar.Name = "PcbRegistrar";
            this.PcbRegistrar.Size = new System.Drawing.Size(160, 60);
            this.PcbRegistrar.TabIndex = 12;
            this.PcbRegistrar.TabStop = false;
            this.PcbRegistrar.Click += new System.EventHandler(this.PcbRegistrar_Click);
            // 
            // PcbFotoU
            // 
            this.PcbFotoU.ErrorImage = null;
            this.PcbFotoU.InitialImage = null;
            this.PcbFotoU.Location = new System.Drawing.Point(33, 21);
            this.PcbFotoU.Name = "PcbFotoU";
            this.PcbFotoU.Size = new System.Drawing.Size(229, 239);
            this.PcbFotoU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbFotoU.TabIndex = 13;
            this.PcbFotoU.TabStop = false;
            this.PcbFotoU.Click += new System.EventHandler(this.PcbFotoU_Click);
            // 
            // PcbFoto
            // 
            this.PcbFoto.BackColor = System.Drawing.Color.Transparent;
            this.PcbFoto.ImageLocation = "";
            this.PcbFoto.Location = new System.Drawing.Point(281, 66);
            this.PcbFoto.Name = "PcbFoto";
            this.PcbFoto.Size = new System.Drawing.Size(139, 311);
            this.PcbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PcbFoto.TabIndex = 14;
            this.PcbFoto.TabStop = false;
            // 
            // BtnUrl
            // 
            this.BtnUrl.Location = new System.Drawing.Point(57, 315);
            this.BtnUrl.Name = "BtnUrl";
            this.BtnUrl.Size = new System.Drawing.Size(106, 22);
            this.BtnUrl.TabIndex = 20;
            this.BtnUrl.Text = "Subir Foto";
            this.BtnUrl.UseVisualStyleBackColor = true;
            this.BtnUrl.Visible = false;
            this.BtnUrl.Click += new System.EventHandler(this.BtnUrl_Click);
            // 
            // BtnArchivo
            // 
            this.BtnArchivo.Enabled = false;
            this.BtnArchivo.Location = new System.Drawing.Point(57, 379);
            this.BtnArchivo.Name = "BtnArchivo";
            this.BtnArchivo.Size = new System.Drawing.Size(106, 22);
            this.BtnArchivo.TabIndex = 18;
            this.BtnArchivo.Text = "Elegir un Archivo";
            this.BtnArchivo.UseVisualStyleBackColor = true;
            this.BtnArchivo.Visible = false;
            this.BtnArchivo.Click += new System.EventHandler(this.BtnArchivo_Click);
            // 
            // TxtUrl
            // 
            this.TxtUrl.Location = new System.Drawing.Point(57, 289);
            this.TxtUrl.Name = "TxtUrl";
            this.TxtUrl.Size = new System.Drawing.Size(182, 20);
            this.TxtUrl.TabIndex = 17;
            this.TxtUrl.Visible = false;
            // 
            // RdbArchivo
            // 
            this.RdbArchivo.AutoSize = true;
            this.RdbArchivo.Location = new System.Drawing.Point(54, 356);
            this.RdbArchivo.Name = "RdbArchivo";
            this.RdbArchivo.Size = new System.Drawing.Size(90, 17);
            this.RdbArchivo.TabIndex = 16;
            this.RdbArchivo.Text = "Archivo Local";
            this.RdbArchivo.UseVisualStyleBackColor = true;
            this.RdbArchivo.Visible = false;
            // 
            // RdbUrl
            // 
            this.RdbUrl.AutoSize = true;
            this.RdbUrl.Checked = true;
            this.RdbUrl.Location = new System.Drawing.Point(54, 266);
            this.RdbUrl.Name = "RdbUrl";
            this.RdbUrl.Size = new System.Drawing.Size(47, 17);
            this.RdbUrl.TabIndex = 15;
            this.RdbUrl.TabStop = true;
            this.RdbUrl.Text = "URL";
            this.RdbUrl.UseVisualStyleBackColor = true;
            this.RdbUrl.Visible = false;
            this.RdbUrl.CheckedChanged += new System.EventHandler(this.RdbUrl_CheckedChanged);
            // 
            // OfdFotos
            // 
            this.OfdFotos.FileName = "Seleciona una imagen";
            this.OfdFotos.Filter = "PNG|*.png|JPG|*.jpg";
            // 
            // PcbVolver
            // 
            this.PcbVolver.BackColor = System.Drawing.Color.Transparent;
            this.PcbVolver.Image = global::ProyectoFinalUnai.Properties.Resources.atras;
            this.PcbVolver.Location = new System.Drawing.Point(0, 0);
            this.PcbVolver.Name = "PcbVolver";
            this.PcbVolver.Size = new System.Drawing.Size(16, 16);
            this.PcbVolver.TabIndex = 21;
            this.PcbVolver.TabStop = false;
            this.PcbVolver.Click += new System.EventHandler(this.LblRegresar_Click);
            // 
            // LblRegresar
            // 
            this.LblRegresar.AutoSize = true;
            this.LblRegresar.BackColor = System.Drawing.Color.Transparent;
            this.LblRegresar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRegresar.Location = new System.Drawing.Point(12, -1);
            this.LblRegresar.Name = "LblRegresar";
            this.LblRegresar.Size = new System.Drawing.Size(58, 19);
            this.LblRegresar.TabIndex = 22;
            this.LblRegresar.Text = "Volver";
            this.LblRegresar.Click += new System.EventHandler(this.LblRegresar_Click);
            // 
            // TxtApellido
            // 
            this.TxtApellido.AcceptReturn = false;
            this.TxtApellido.BackColor = System.Drawing.SystemColors.Window;
            this.TxtApellido.BoderSize = 7;
            this.TxtApellido.BorderColor = System.Drawing.Color.Black;
            this.TxtApellido.BorderRadius = 0;
            this.TxtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellido.ForeColor = System.Drawing.Color.DimGray;
            this.TxtApellido.Location = new System.Drawing.Point(572, 220);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Padding = new System.Windows.Forms.Padding(7);
            this.TxtApellido.passwordChar = false;
            this.TxtApellido.Size = new System.Drawing.Size(279, 31);
            this.TxtApellido.TabIndex = 2;
            this.TxtApellido.Texts = "";
            this.TtpRegistro.SetToolTip(this.TxtApellido, "Introdcir Apellidos");
            this.TxtApellido.Underlinedstyle = true;
            // 
            // TxtReContraseña
            // 
            this.TxtReContraseña.AcceptReturn = false;
            this.TxtReContraseña.BackColor = System.Drawing.SystemColors.Window;
            this.TxtReContraseña.BoderSize = 7;
            this.TxtReContraseña.BorderColor = System.Drawing.Color.Black;
            this.TxtReContraseña.BorderRadius = 0;
            this.TxtReContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtReContraseña.ForeColor = System.Drawing.Color.DimGray;
            this.TxtReContraseña.Location = new System.Drawing.Point(572, 460);
            this.TxtReContraseña.Name = "TxtReContraseña";
            this.TxtReContraseña.Padding = new System.Windows.Forms.Padding(7);
            this.TxtReContraseña.passwordChar = true;
            this.TxtReContraseña.Size = new System.Drawing.Size(279, 31);
            this.TxtReContraseña.TabIndex = 5;
            this.TxtReContraseña.Texts = "";
            this.TtpRegistro.SetToolTip(this.TxtReContraseña, "Repetir Contraseña");
            this.TxtReContraseña.Underlinedstyle = true;
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.AcceptReturn = false;
            this.TxtContraseña.BackColor = System.Drawing.SystemColors.Window;
            this.TxtContraseña.BoderSize = 7;
            this.TxtContraseña.BorderColor = System.Drawing.Color.Black;
            this.TxtContraseña.BorderRadius = 0;
            this.TxtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContraseña.ForeColor = System.Drawing.Color.DimGray;
            this.TxtContraseña.Location = new System.Drawing.Point(572, 380);
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.Padding = new System.Windows.Forms.Padding(7);
            this.TxtContraseña.passwordChar = true;
            this.TxtContraseña.Size = new System.Drawing.Size(279, 31);
            this.TxtContraseña.TabIndex = 4;
            this.TxtContraseña.Texts = "";
            this.TtpRegistro.SetToolTip(this.TxtContraseña, "Introdcir Contraseña");
            this.TxtContraseña.Underlinedstyle = true;
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.AcceptReturn = false;
            this.TxtCorreo.BackColor = System.Drawing.SystemColors.Window;
            this.TxtCorreo.BoderSize = 7;
            this.TxtCorreo.BorderColor = System.Drawing.Color.Black;
            this.TxtCorreo.BorderRadius = 0;
            this.TxtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCorreo.ForeColor = System.Drawing.Color.DimGray;
            this.TxtCorreo.Location = new System.Drawing.Point(572, 300);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Padding = new System.Windows.Forms.Padding(7);
            this.TxtCorreo.passwordChar = false;
            this.TxtCorreo.Size = new System.Drawing.Size(279, 31);
            this.TxtCorreo.TabIndex = 3;
            this.TxtCorreo.Texts = "";
            this.TtpRegistro.SetToolTip(this.TxtCorreo, "Introdcir Correo");
            this.TxtCorreo.Underlinedstyle = true;
            // 
            // TxtNombre
            // 
            this.TxtNombre.AcceptReturn = false;
            this.TxtNombre.BackColor = System.Drawing.SystemColors.Window;
            this.TxtNombre.BoderSize = 7;
            this.TxtNombre.BorderColor = System.Drawing.Color.Black;
            this.TxtNombre.BorderRadius = 0;
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.ForeColor = System.Drawing.Color.DimGray;
            this.TxtNombre.Location = new System.Drawing.Point(572, 140);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Padding = new System.Windows.Forms.Padding(7);
            this.TxtNombre.passwordChar = false;
            this.TxtNombre.Size = new System.Drawing.Size(279, 31);
            this.TxtNombre.TabIndex = 1;
            this.TxtNombre.Texts = "";
            this.TtpRegistro.SetToolTip(this.TxtNombre, "Introdcir Nombre");
            this.TxtNombre.Underlinedstyle = true;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.AcceptReturn = false;
            this.TxtUsuario.BackColor = System.Drawing.Color.White;
            this.TxtUsuario.BoderSize = 7;
            this.TxtUsuario.BorderColor = System.Drawing.Color.Black;
            this.TxtUsuario.BorderRadius = 0;
            this.TxtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtUsuario.Location = new System.Drawing.Point(572, 60);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Padding = new System.Windows.Forms.Padding(7);
            this.TxtUsuario.passwordChar = false;
            this.TxtUsuario.Size = new System.Drawing.Size(279, 31);
            this.TxtUsuario.TabIndex = 0;
            this.TxtUsuario.Texts = "";
            this.TtpRegistro.SetToolTip(this.TxtUsuario, "Introdcir Usuario");
            this.TxtUsuario.Underlinedstyle = true;
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::ProyectoFinalUnai.Properties.Resources.Textura;
            this.ClientSize = new System.Drawing.Size(884, 504);
            this.Controls.Add(this.LblRegresar);
            this.Controls.Add(this.PcbVolver);
            this.Controls.Add(this.BtnUrl);
            this.Controls.Add(this.BtnArchivo);
            this.Controls.Add(this.TxtUrl);
            this.Controls.Add(this.RdbArchivo);
            this.Controls.Add(this.RdbUrl);
            this.Controls.Add(this.PcbFoto);
            this.Controls.Add(this.PcbFotoU);
            this.Controls.Add(this.PcbRegistrar);
            this.Controls.Add(this.LblReContraseña);
            this.Controls.Add(this.LblContraseña);
            this.Controls.Add(this.LblCorreo);
            this.Controls.Add(this.LblApellido);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.TxtReContraseña);
            this.Controls.Add(this.TxtContraseña);
            this.Controls.Add(this.TxtCorreo);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Usuarios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmRegistro_FormClosing);
            this.Load += new System.EventHandler(this.FrmRegistro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PcbRegistrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbFotoU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbVolver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJTextBox TxtUsuario;
        private RJTextBox TxtNombre;
        private RJTextBox TxtCorreo;
        private RJTextBox TxtContraseña;
        private RJTextBox TxtReContraseña;
        private RJTextBox TxtApellido;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.Label LblCorreo;
        private System.Windows.Forms.Label LblContraseña;
        private System.Windows.Forms.Label LblReContraseña;
        private System.Windows.Forms.ToolTip TtpRegistro;
        private System.Windows.Forms.PictureBox PcbRegistrar;
        private System.Windows.Forms.PictureBox PcbFotoU;
        private System.Windows.Forms.PictureBox PcbFoto;
        private System.Windows.Forms.Button BtnUrl;
        private System.Windows.Forms.Button BtnArchivo;
        private System.Windows.Forms.TextBox TxtUrl;
        private System.Windows.Forms.RadioButton RdbArchivo;
        private System.Windows.Forms.RadioButton RdbUrl;
        private System.Windows.Forms.OpenFileDialog OfdFotos;
        private System.Windows.Forms.PictureBox PcbVolver;
        private System.Windows.Forms.Label LblRegresar;
    }
}