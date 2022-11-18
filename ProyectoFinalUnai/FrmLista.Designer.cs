
namespace ProyectoFinalUnai
{
    partial class FrmLista
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLista));
            this.LblVacio = new System.Windows.Forms.Label();
            this.DtgLista = new System.Windows.Forms.DataGridView();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.PcbFoto = new System.Windows.Forms.PictureBox();
            this.LblLista = new System.Windows.Forms.Label();
            this.TxtAnimes = new ProyectoFinalUnai.RJTextBox();
            this.PcbImagen = new ProyectoFinalUnai.RJPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DtgLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // LblVacio
            // 
            this.LblVacio.AutoSize = true;
            this.LblVacio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.LblVacio.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVacio.Location = new System.Drawing.Point(150, 230);
            this.LblVacio.Name = "LblVacio";
            this.LblVacio.Size = new System.Drawing.Size(0, 23);
            this.LblVacio.TabIndex = 3;
            this.LblVacio.Visible = false;
            // 
            // DtgLista
            // 
            this.DtgLista.AllowUserToAddRows = false;
            this.DtgLista.AllowUserToDeleteRows = false;
            this.DtgLista.AllowUserToResizeColumns = false;
            this.DtgLista.AllowUserToResizeRows = false;
            this.DtgLista.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.DtgLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DtgLista.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DtgLista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DtgLista.ColumnHeadersHeight = 30;
            this.DtgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DtgLista.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DtgLista.EnableHeadersVisualStyles = false;
            this.DtgLista.GridColor = System.Drawing.Color.SteelBlue;
            this.DtgLista.Location = new System.Drawing.Point(0, 157);
            this.DtgLista.Name = "DtgLista";
            this.DtgLista.ReadOnly = true;
            this.DtgLista.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgLista.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DtgLista.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.DtgLista.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DtgLista.Size = new System.Drawing.Size(634, 321);
            this.DtgLista.TabIndex = 0;
            this.DtgLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgLista_CellContentClick);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TxtBuscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TxtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscar.Location = new System.Drawing.Point(323, 123);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(300, 17);
            this.TxtBuscar.TabIndex = 102;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            this.TxtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtBuscar_KeyDown);
            // 
            // PcbFoto
            // 
            this.PcbFoto.BackColor = System.Drawing.Color.Transparent;
            this.PcbFoto.ImageLocation = "";
            this.PcbFoto.InitialImage = null;
            this.PcbFoto.Location = new System.Drawing.Point(22, 0);
            this.PcbFoto.Name = "PcbFoto";
            this.PcbFoto.Size = new System.Drawing.Size(279, 157);
            this.PcbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbFoto.TabIndex = 103;
            this.PcbFoto.TabStop = false;
            // 
            // LblLista
            // 
            this.LblLista.AutoSize = true;
            this.LblLista.BackColor = System.Drawing.Color.Transparent;
            this.LblLista.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLista.Location = new System.Drawing.Point(314, 9);
            this.LblLista.MaximumSize = new System.Drawing.Size(280, 0);
            this.LblLista.Name = "LblLista";
            this.LblLista.Size = new System.Drawing.Size(0, 23);
            this.LblLista.TabIndex = 115;
            // 
            // TxtAnimes
            // 
            this.TxtAnimes.AcceptReturn = true;
            this.TxtAnimes.BackColor = System.Drawing.SystemColors.Window;
            this.TxtAnimes.BoderSize = 2;
            this.TxtAnimes.BorderColor = System.Drawing.Color.Black;
            this.TxtAnimes.BorderRadius = 15;
            this.TxtAnimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAnimes.ForeColor = System.Drawing.Color.DimGray;
            this.TxtAnimes.Location = new System.Drawing.Point(317, 116);
            this.TxtAnimes.Name = "TxtAnimes";
            this.TxtAnimes.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxtAnimes.passwordChar = false;
            this.TxtAnimes.Size = new System.Drawing.Size(312, 31);
            this.TxtAnimes.TabIndex = 101;
            this.TxtAnimes.Texts = "";
            this.TxtAnimes.Underlinedstyle = false;
            // 
            // PcbImagen
            // 
            this.PcbImagen.BordeLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.PcbImagen.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.PcbImagen.BorderColor = System.Drawing.Color.RoyalBlue;
            this.PcbImagen.BorderColor2 = System.Drawing.Color.HotPink;
            this.PcbImagen.BorderSize = 2;
            this.PcbImagen.GradientAngle = 50F;
            this.PcbImagen.Location = new System.Drawing.Point(575, 0);
            this.PcbImagen.Name = "PcbImagen";
            this.PcbImagen.Size = new System.Drawing.Size(55, 55);
            this.PcbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbImagen.TabIndex = 2;
            this.PcbImagen.TabStop = false;
            // 
            // FrmLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::ProyectoFinalUnai.Properties.Resources.Textura;
            this.ClientSize = new System.Drawing.Size(634, 478);
            this.Controls.Add(this.LblLista);
            this.Controls.Add(this.PcbFoto);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.TxtAnimes);
            this.Controls.Add(this.LblVacio);
            this.Controls.Add(this.PcbImagen);
            this.Controls.Add(this.DtgLista);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLista";
            this.Load += new System.EventHandler(this.FrmLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RJPictureBox PcbImagen;
        private System.Windows.Forms.Label LblVacio;
        private System.Windows.Forms.DataGridView DtgLista;
        private System.Windows.Forms.TextBox TxtBuscar;
        private RJTextBox TxtAnimes;
        private System.Windows.Forms.PictureBox PcbFoto;
        private System.Windows.Forms.Label LblLista;
    }
}