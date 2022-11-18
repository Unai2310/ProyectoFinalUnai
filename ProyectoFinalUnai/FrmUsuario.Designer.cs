
namespace ProyectoFinalUnai
{
    partial class FrmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuario));
            this.PcbUsuario = new ProyectoFinalUnai.RJPictureBox();
            this.PcbImagen = new System.Windows.Forms.PictureBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblApellido = new System.Windows.Forms.Label();
            this.LblCorreo = new System.Windows.Forms.Label();
            this.PcbSeparador = new System.Windows.Forms.PictureBox();
            this.LblUsuarioV = new System.Windows.Forms.Label();
            this.LblNombreV = new System.Windows.Forms.Label();
            this.LblApellidoV = new System.Windows.Forms.Label();
            this.LblCorreoV = new System.Windows.Forms.Label();
            this.PcbCerrar = new System.Windows.Forms.PictureBox();
            this.PcbBorrar = new System.Windows.Forms.PictureBox();
            this.LblCambiar = new System.Windows.Forms.Label();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.OfdImagen = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.PcbUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbSeparador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbBorrar)).BeginInit();
            this.SuspendLayout();
            // 
            // PcbUsuario
            // 
            this.PcbUsuario.BordeLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.PcbUsuario.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.PcbUsuario.BorderColor = System.Drawing.Color.RoyalBlue;
            this.PcbUsuario.BorderColor2 = System.Drawing.Color.HotPink;
            this.PcbUsuario.BorderSize = 2;
            this.PcbUsuario.GradientAngle = 50F;
            this.PcbUsuario.Location = new System.Drawing.Point(12, 12);
            this.PcbUsuario.Name = "PcbUsuario";
            this.PcbUsuario.Size = new System.Drawing.Size(158, 158);
            this.PcbUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbUsuario.TabIndex = 0;
            this.PcbUsuario.TabStop = false;
            // 
            // PcbImagen
            // 
            this.PcbImagen.BackColor = System.Drawing.Color.Transparent;
            this.PcbImagen.ImageLocation = "";
            this.PcbImagen.Location = new System.Drawing.Point(1, 180);
            this.PcbImagen.Name = "PcbImagen";
            this.PcbImagen.Size = new System.Drawing.Size(179, 224);
            this.PcbImagen.TabIndex = 1;
            this.PcbImagen.TabStop = false;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.BackColor = System.Drawing.Color.Transparent;
            this.LblNombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(231, 102);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(84, 22);
            this.LblNombre.TabIndex = 2;
            this.LblNombre.Text = "Nombre";
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.LblUsuario.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.Location = new System.Drawing.Point(231, 12);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(115, 33);
            this.LblUsuario.TabIndex = 3;
            this.LblUsuario.Text = "Usuario:";
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.BackColor = System.Drawing.Color.Transparent;
            this.LblApellido.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApellido.Location = new System.Drawing.Point(231, 180);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(84, 22);
            this.LblApellido.TabIndex = 4;
            this.LblApellido.Text = "Apellido";
            // 
            // LblCorreo
            // 
            this.LblCorreo.AutoSize = true;
            this.LblCorreo.BackColor = System.Drawing.Color.Transparent;
            this.LblCorreo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCorreo.Location = new System.Drawing.Point(233, 264);
            this.LblCorreo.Name = "LblCorreo";
            this.LblCorreo.Size = new System.Drawing.Size(73, 22);
            this.LblCorreo.TabIndex = 5;
            this.LblCorreo.Text = "Correo";
            // 
            // PcbSeparador
            // 
            this.PcbSeparador.BackColor = System.Drawing.Color.Transparent;
            this.PcbSeparador.Image = global::ProyectoFinalUnai.Properties.Resources.Separador_removebg_preview;
            this.PcbSeparador.Location = new System.Drawing.Point(200, 4);
            this.PcbSeparador.Name = "PcbSeparador";
            this.PcbSeparador.Size = new System.Drawing.Size(25, 400);
            this.PcbSeparador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbSeparador.TabIndex = 6;
            this.PcbSeparador.TabStop = false;
            // 
            // LblUsuarioV
            // 
            this.LblUsuarioV.AutoSize = true;
            this.LblUsuarioV.BackColor = System.Drawing.Color.Transparent;
            this.LblUsuarioV.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuarioV.Location = new System.Drawing.Point(250, 45);
            this.LblUsuarioV.Name = "LblUsuarioV";
            this.LblUsuarioV.Size = new System.Drawing.Size(0, 33);
            this.LblUsuarioV.TabIndex = 7;
            // 
            // LblNombreV
            // 
            this.LblNombreV.AutoSize = true;
            this.LblNombreV.BackColor = System.Drawing.Color.Transparent;
            this.LblNombreV.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreV.Location = new System.Drawing.Point(243, 124);
            this.LblNombreV.Name = "LblNombreV";
            this.LblNombreV.Size = new System.Drawing.Size(0, 22);
            this.LblNombreV.TabIndex = 8;
            // 
            // LblApellidoV
            // 
            this.LblApellidoV.AutoSize = true;
            this.LblApellidoV.BackColor = System.Drawing.Color.Transparent;
            this.LblApellidoV.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApellidoV.Location = new System.Drawing.Point(243, 202);
            this.LblApellidoV.Name = "LblApellidoV";
            this.LblApellidoV.Size = new System.Drawing.Size(0, 22);
            this.LblApellidoV.TabIndex = 9;
            // 
            // LblCorreoV
            // 
            this.LblCorreoV.AutoSize = true;
            this.LblCorreoV.BackColor = System.Drawing.Color.Transparent;
            this.LblCorreoV.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCorreoV.Location = new System.Drawing.Point(243, 286);
            this.LblCorreoV.Name = "LblCorreoV";
            this.LblCorreoV.Size = new System.Drawing.Size(0, 22);
            this.LblCorreoV.TabIndex = 10;
            // 
            // PcbCerrar
            // 
            this.PcbCerrar.Image = global::ProyectoFinalUnai.Properties.Resources.CerrarSesion;
            this.PcbCerrar.Location = new System.Drawing.Point(237, 331);
            this.PcbCerrar.Name = "PcbCerrar";
            this.PcbCerrar.Size = new System.Drawing.Size(125, 50);
            this.PcbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbCerrar.TabIndex = 11;
            this.PcbCerrar.TabStop = false;
            this.PcbCerrar.Click += new System.EventHandler(this.PcbCerrar_Click);
            // 
            // PcbBorrar
            // 
            this.PcbBorrar.Image = global::ProyectoFinalUnai.Properties.Resources.BorrarUsuario;
            this.PcbBorrar.Location = new System.Drawing.Point(464, 331);
            this.PcbBorrar.Name = "PcbBorrar";
            this.PcbBorrar.Size = new System.Drawing.Size(125, 50);
            this.PcbBorrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbBorrar.TabIndex = 12;
            this.PcbBorrar.TabStop = false;
            this.PcbBorrar.Click += new System.EventHandler(this.PcbBorrar_Click);
            // 
            // LblCambiar
            // 
            this.LblCambiar.AutoSize = true;
            this.LblCambiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCambiar.Location = new System.Drawing.Point(312, 262);
            this.LblCambiar.Name = "LblCambiar";
            this.LblCambiar.Size = new System.Drawing.Size(25, 24);
            this.LblCambiar.TabIndex = 13;
            this.LblCambiar.Text = "✎";
            this.LblCambiar.Click += new System.EventHandler(this.LblCambiar_Click);
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCorreo.Location = new System.Drawing.Point(235, 290);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(341, 27);
            this.TxtCorreo.TabIndex = 14;
            this.TxtCorreo.Visible = false;
            this.TxtCorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCorreo_KeyPress);
            // 
            // OfdImagen
            // 
            this.OfdImagen.FileName = "Seleciona una imagen";
            this.OfdImagen.Filter = "PNG|*.png|JPG|*.jpg";
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinalUnai.Properties.Resources.Textura;
            this.ClientSize = new System.Drawing.Size(601, 403);
            this.Controls.Add(this.TxtCorreo);
            this.Controls.Add(this.LblCambiar);
            this.Controls.Add(this.PcbBorrar);
            this.Controls.Add(this.PcbCerrar);
            this.Controls.Add(this.LblCorreoV);
            this.Controls.Add(this.LblApellidoV);
            this.Controls.Add(this.LblNombreV);
            this.Controls.Add(this.LblUsuarioV);
            this.Controls.Add(this.PcbSeparador);
            this.Controls.Add(this.LblCorreo);
            this.Controls.Add(this.LblApellido);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.PcbImagen);
            this.Controls.Add(this.PcbUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUsuario";
            this.Text = "Gestion de Usuario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmUsuario_FormClosing);
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PcbUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbSeparador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbBorrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJPictureBox PcbUsuario;
        private System.Windows.Forms.PictureBox PcbImagen;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.Label LblCorreo;
        private System.Windows.Forms.PictureBox PcbSeparador;
        private System.Windows.Forms.Label LblUsuarioV;
        private System.Windows.Forms.Label LblNombreV;
        private System.Windows.Forms.Label LblApellidoV;
        private System.Windows.Forms.Label LblCorreoV;
        private System.Windows.Forms.PictureBox PcbCerrar;
        private System.Windows.Forms.PictureBox PcbBorrar;
        private System.Windows.Forms.Label LblCambiar;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.OpenFileDialog OfdImagen;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}