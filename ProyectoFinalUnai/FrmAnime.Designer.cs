
namespace ProyectoFinalUnai
{
    partial class FrmAnime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnime));
            this.PcbImagen = new System.Windows.Forms.PictureBox();
            this.LblLupa = new System.Windows.Forms.Label();
            this.LvwTemporadas = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ImgLista = new System.Windows.Forms.ImageList(this.components);
            this.PcbLogo = new System.Windows.Forms.PictureBox();
            this.LblOrden = new System.Windows.Forms.Label();
            this.LblInformacion = new System.Windows.Forms.Label();
            this.PcbAñadir = new System.Windows.Forms.PictureBox();
            this.CbxNota = new System.Windows.Forms.ComboBox();
            this.PcbAyuda = new System.Windows.Forms.PictureBox();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.PcbCerrar = new System.Windows.Forms.PictureBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblGenero = new System.Windows.Forms.Label();
            this.LblTemporadas = new System.Windows.Forms.Label();
            this.LblCapitulos = new System.Windows.Forms.Label();
            this.LblNombreV = new System.Windows.Forms.Label();
            this.LblGeneroV = new System.Windows.Forms.Label();
            this.LblTemporadasV = new System.Windows.Forms.Label();
            this.LblCapitulosV = new System.Windows.Forms.Label();
            this.PcbPerfil = new ProyectoFinalUnai.RJPictureBox();
            this.TxtAnimes = new ProyectoFinalUnai.RJTextBox();
            this.ErrLista = new System.Windows.Forms.ErrorProvider(this.components);
            this.PcbFoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PcbImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbAñadir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbAyuda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // PcbImagen
            // 
            this.PcbImagen.Location = new System.Drawing.Point(3, 56);
            this.PcbImagen.Name = "PcbImagen";
            this.PcbImagen.Size = new System.Drawing.Size(272, 382);
            this.PcbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbImagen.TabIndex = 0;
            this.PcbImagen.TabStop = false;
            // 
            // LblLupa
            // 
            this.LblLupa.AutoSize = true;
            this.LblLupa.BackColor = System.Drawing.Color.Transparent;
            this.LblLupa.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLupa.Location = new System.Drawing.Point(98, 6);
            this.LblLupa.Name = "LblLupa";
            this.LblLupa.Size = new System.Drawing.Size(59, 42);
            this.LblLupa.TabIndex = 5;
            this.LblLupa.Text = "🔎";
            // 
            // LvwTemporadas
            // 
            this.LvwTemporadas.AutoArrange = false;
            this.LvwTemporadas.BackgroundImage = global::ProyectoFinalUnai.Properties.Resources.Textura;
            this.LvwTemporadas.BackgroundImageTiled = true;
            this.LvwTemporadas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LvwTemporadas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.LvwTemporadas.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LvwTemporadas.ForeColor = System.Drawing.Color.Black;
            this.LvwTemporadas.GridLines = true;
            this.LvwTemporadas.HideSelection = false;
            this.LvwTemporadas.LargeImageList = this.ImgLista;
            this.LvwTemporadas.Location = new System.Drawing.Point(565, 84);
            this.LvwTemporadas.Name = "LvwTemporadas";
            this.LvwTemporadas.Size = new System.Drawing.Size(361, 354);
            this.LvwTemporadas.SmallImageList = this.ImgLista;
            this.LvwTemporadas.TabIndex = 6;
            this.LvwTemporadas.UseCompatibleStateImageBehavior = false;
            this.LvwTemporadas.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LvwTemporadas_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 1000;
            // 
            // ImgLista
            // 
            this.ImgLista.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ImgLista.ImageSize = new System.Drawing.Size(90, 50);
            this.ImgLista.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // PcbLogo
            // 
            this.PcbLogo.BackColor = System.Drawing.Color.Transparent;
            this.PcbLogo.Image = global::ProyectoFinalUnai.Properties.Resources.Logo;
            this.PcbLogo.Location = new System.Drawing.Point(3, -8);
            this.PcbLogo.Name = "PcbLogo";
            this.PcbLogo.Size = new System.Drawing.Size(98, 86);
            this.PcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbLogo.TabIndex = 7;
            this.PcbLogo.TabStop = false;
            // 
            // LblOrden
            // 
            this.LblOrden.AutoSize = true;
            this.LblOrden.BackColor = System.Drawing.Color.Transparent;
            this.LblOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOrden.Location = new System.Drawing.Point(560, 56);
            this.LblOrden.Name = "LblOrden";
            this.LblOrden.Size = new System.Drawing.Size(372, 25);
            this.LblOrden.TabIndex = 8;
            this.LblOrden.Text = "Orden de Visualización                       ";
            // 
            // LblInformacion
            // 
            this.LblInformacion.AutoSize = true;
            this.LblInformacion.BackColor = System.Drawing.Color.Transparent;
            this.LblInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInformacion.Location = new System.Drawing.Point(281, 56);
            this.LblInformacion.Name = "LblInformacion";
            this.LblInformacion.Size = new System.Drawing.Size(273, 25);
            this.LblInformacion.TabIndex = 101;
            this.LblInformacion.Text = "Informacion                         ";
            // 
            // PcbAñadir
            // 
            this.PcbAñadir.BackColor = System.Drawing.Color.Transparent;
            this.PcbAñadir.Location = new System.Drawing.Point(462, 6);
            this.PcbAñadir.Name = "PcbAñadir";
            this.PcbAñadir.Size = new System.Drawing.Size(119, 47);
            this.PcbAñadir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbAñadir.TabIndex = 102;
            this.PcbAñadir.TabStop = false;
            this.PcbAñadir.Click += new System.EventHandler(this.PcbAñadir_Click);
            // 
            // CbxNota
            // 
            this.CbxNota.FormattingEnabled = true;
            this.CbxNota.Items.AddRange(new object[] {
            "(10) Obra Maestra",
            "(9) Genial",
            "(8) Muy Bueno",
            "(7) Bueno",
            "(6) En la Media",
            "(5) Normal",
            "(4) Malo",
            "(3) Muy Malo",
            "(2) Horrible",
            "(1) Espantoso"});
            this.CbxNota.Location = new System.Drawing.Point(587, 22);
            this.CbxNota.Name = "CbxNota";
            this.CbxNota.Size = new System.Drawing.Size(136, 21);
            this.CbxNota.TabIndex = 103;
            // 
            // PcbAyuda
            // 
            this.PcbAyuda.Image = global::ProyectoFinalUnai.Properties.Resources.Temporada;
            this.PcbAyuda.Location = new System.Drawing.Point(1, 1);
            this.PcbAyuda.Name = "PcbAyuda";
            this.PcbAyuda.Size = new System.Drawing.Size(1, 1);
            this.PcbAyuda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbAyuda.TabIndex = 104;
            this.PcbAyuda.TabStop = false;
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TxtBuscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TxtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscar.Location = new System.Drawing.Point(172, 20);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(236, 17);
            this.TxtBuscar.TabIndex = 106;
            this.TxtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtBuscar_KeyDown);
            // 
            // PcbCerrar
            // 
            this.PcbCerrar.BackColor = System.Drawing.Color.Transparent;
            this.PcbCerrar.Image = global::ProyectoFinalUnai.Properties.Resources.Borrar;
            this.PcbCerrar.Location = new System.Drawing.Point(899, 6);
            this.PcbCerrar.Name = "PcbCerrar";
            this.PcbCerrar.Size = new System.Drawing.Size(32, 32);
            this.PcbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PcbCerrar.TabIndex = 107;
            this.PcbCerrar.TabStop = false;
            this.PcbCerrar.Click += new System.EventHandler(this.PcbCerrar_Click);
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.BackColor = System.Drawing.Color.Transparent;
            this.LblNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(282, 84);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(78, 21);
            this.LblNombre.TabIndex = 109;
            this.LblNombre.Text = "-Nombre";
            // 
            // LblGenero
            // 
            this.LblGenero.AutoSize = true;
            this.LblGenero.BackColor = System.Drawing.Color.Transparent;
            this.LblGenero.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGenero.Location = new System.Drawing.Point(281, 122);
            this.LblGenero.Name = "LblGenero";
            this.LblGenero.Size = new System.Drawing.Size(74, 21);
            this.LblGenero.TabIndex = 110;
            this.LblGenero.Text = "-Genero";
            // 
            // LblTemporadas
            // 
            this.LblTemporadas.AutoSize = true;
            this.LblTemporadas.BackColor = System.Drawing.Color.Transparent;
            this.LblTemporadas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTemporadas.Location = new System.Drawing.Point(281, 189);
            this.LblTemporadas.Name = "LblTemporadas";
            this.LblTemporadas.Size = new System.Drawing.Size(113, 21);
            this.LblTemporadas.TabIndex = 111;
            this.LblTemporadas.Text = "-Temporadas";
            // 
            // LblCapitulos
            // 
            this.LblCapitulos.AutoSize = true;
            this.LblCapitulos.BackColor = System.Drawing.Color.Transparent;
            this.LblCapitulos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCapitulos.Location = new System.Drawing.Point(280, 227);
            this.LblCapitulos.Name = "LblCapitulos";
            this.LblCapitulos.Size = new System.Drawing.Size(89, 21);
            this.LblCapitulos.TabIndex = 112;
            this.LblCapitulos.Text = "-Capitulos";
            // 
            // LblNombreV
            // 
            this.LblNombreV.AutoSize = true;
            this.LblNombreV.BackColor = System.Drawing.Color.Transparent;
            this.LblNombreV.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreV.Location = new System.Drawing.Point(292, 105);
            this.LblNombreV.MaximumSize = new System.Drawing.Size(280, 0);
            this.LblNombreV.Name = "LblNombreV";
            this.LblNombreV.Size = new System.Drawing.Size(0, 17);
            this.LblNombreV.TabIndex = 113;
            // 
            // LblGeneroV
            // 
            this.LblGeneroV.AutoSize = true;
            this.LblGeneroV.BackColor = System.Drawing.Color.Transparent;
            this.LblGeneroV.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGeneroV.Location = new System.Drawing.Point(303, 143);
            this.LblGeneroV.MaximumSize = new System.Drawing.Size(280, 0);
            this.LblGeneroV.Name = "LblGeneroV";
            this.LblGeneroV.Size = new System.Drawing.Size(0, 17);
            this.LblGeneroV.TabIndex = 114;
            // 
            // LblTemporadasV
            // 
            this.LblTemporadasV.AutoSize = true;
            this.LblTemporadasV.BackColor = System.Drawing.Color.Transparent;
            this.LblTemporadasV.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTemporadasV.Location = new System.Drawing.Point(291, 210);
            this.LblTemporadasV.Name = "LblTemporadasV";
            this.LblTemporadasV.Size = new System.Drawing.Size(0, 17);
            this.LblTemporadasV.TabIndex = 115;
            // 
            // LblCapitulosV
            // 
            this.LblCapitulosV.AutoSize = true;
            this.LblCapitulosV.BackColor = System.Drawing.Color.Transparent;
            this.LblCapitulosV.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCapitulosV.Location = new System.Drawing.Point(291, 248);
            this.LblCapitulosV.Name = "LblCapitulosV";
            this.LblCapitulosV.Size = new System.Drawing.Size(0, 17);
            this.LblCapitulosV.TabIndex = 116;
            // 
            // PcbPerfil
            // 
            this.PcbPerfil.BordeLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.PcbPerfil.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Round;
            this.PcbPerfil.BorderColor = System.Drawing.Color.RoyalBlue;
            this.PcbPerfil.BorderColor2 = System.Drawing.Color.HotPink;
            this.PcbPerfil.BorderSize = 2;
            this.PcbPerfil.GradientAngle = 50F;
            this.PcbPerfil.Location = new System.Drawing.Point(827, 6);
            this.PcbPerfil.Name = "PcbPerfil";
            this.PcbPerfil.Size = new System.Drawing.Size(66, 66);
            this.PcbPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbPerfil.TabIndex = 99;
            this.PcbPerfil.TabStop = false;
            // 
            // TxtAnimes
            // 
            this.TxtAnimes.AcceptReturn = false;
            this.TxtAnimes.BackColor = System.Drawing.SystemColors.Window;
            this.TxtAnimes.BoderSize = 2;
            this.TxtAnimes.BorderColor = System.Drawing.Color.Black;
            this.TxtAnimes.BorderRadius = 15;
            this.TxtAnimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAnimes.ForeColor = System.Drawing.Color.DimGray;
            this.TxtAnimes.Location = new System.Drawing.Point(163, 12);
            this.TxtAnimes.Name = "TxtAnimes";
            this.TxtAnimes.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxtAnimes.passwordChar = false;
            this.TxtAnimes.Size = new System.Drawing.Size(253, 31);
            this.TxtAnimes.TabIndex = 4;
            this.TxtAnimes.Texts = "";
            this.TxtAnimes.Underlinedstyle = false;
            // 
            // ErrLista
            // 
            this.ErrLista.ContainerControl = this;
            // 
            // PcbFoto
            // 
            this.PcbFoto.BackColor = System.Drawing.Color.Transparent;
            this.PcbFoto.Image = global::ProyectoFinalUnai.Properties.Resources.Foto3_removebg_preview;
            this.PcbFoto.Location = new System.Drawing.Point(278, 268);
            this.PcbFoto.Name = "PcbFoto";
            this.PcbFoto.Size = new System.Drawing.Size(276, 203);
            this.PcbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbFoto.TabIndex = 117;
            this.PcbFoto.TabStop = false;
            // 
            // FrmAnime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::ProyectoFinalUnai.Properties.Resources.Textura;
            this.ClientSize = new System.Drawing.Size(938, 450);
            this.Controls.Add(this.PcbFoto);
            this.Controls.Add(this.LblCapitulosV);
            this.Controls.Add(this.LblTemporadasV);
            this.Controls.Add(this.LblGeneroV);
            this.Controls.Add(this.LblNombreV);
            this.Controls.Add(this.LblCapitulos);
            this.Controls.Add(this.LblTemporadas);
            this.Controls.Add(this.LblGenero);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.PcbCerrar);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.PcbImagen);
            this.Controls.Add(this.PcbAyuda);
            this.Controls.Add(this.CbxNota);
            this.Controls.Add(this.PcbAñadir);
            this.Controls.Add(this.LblInformacion);
            this.Controls.Add(this.PcbPerfil);
            this.Controls.Add(this.LblOrden);
            this.Controls.Add(this.PcbLogo);
            this.Controls.Add(this.LvwTemporadas);
            this.Controls.Add(this.LblLupa);
            this.Controls.Add(this.TxtAnimes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmAnime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmAnime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PcbImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbAñadir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbAyuda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PcbImagen;
        private System.Windows.Forms.Label LblLupa;
        private RJTextBox TxtAnimes;
        private System.Windows.Forms.ListView LvwTemporadas;
        private System.Windows.Forms.PictureBox PcbLogo;
        private System.Windows.Forms.Label LblOrden;
        private RJPictureBox PcbPerfil;
        private System.Windows.Forms.Label LblInformacion;
        private System.Windows.Forms.PictureBox PcbAñadir;
        private System.Windows.Forms.ComboBox CbxNota;
        private System.Windows.Forms.PictureBox PcbAyuda;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.PictureBox PcbCerrar;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblGenero;
        private System.Windows.Forms.Label LblTemporadas;
        private System.Windows.Forms.Label LblCapitulos;
        private System.Windows.Forms.Label LblNombreV;
        private System.Windows.Forms.Label LblGeneroV;
        private System.Windows.Forms.Label LblTemporadasV;
        private System.Windows.Forms.Label LblCapitulosV;
        private System.Windows.Forms.ImageList ImgLista;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ErrorProvider ErrLista;
        private System.Windows.Forms.PictureBox PcbFoto;
    }
}