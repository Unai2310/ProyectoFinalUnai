
namespace ProyectoFinalUnai
{
    partial class FrmTemporada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTemporada));
            this.LblNombre = new System.Windows.Forms.Label();
            this.LvwDatos = new System.Windows.Forms.ListView();
            this.ImgLista = new System.Windows.Forms.ImageList(this.components);
            this.PnlIzq = new System.Windows.Forms.Panel();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnOp = new System.Windows.Forms.Button();
            this.BtnCapitulos = new System.Windows.Forms.Button();
            this.PnlIzq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.BackColor = System.Drawing.Color.Transparent;
            this.LblNombre.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(243, 1);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(0, 25);
            this.LblNombre.TabIndex = 5;
            // 
            // LvwDatos
            // 
            this.LvwDatos.AutoArrange = false;
            this.LvwDatos.BackgroundImage = global::ProyectoFinalUnai.Properties.Resources.animoment;
            this.LvwDatos.BackgroundImageTiled = true;
            this.LvwDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LvwDatos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LvwDatos.HideSelection = false;
            this.LvwDatos.LargeImageList = this.ImgLista;
            this.LvwDatos.Location = new System.Drawing.Point(243, 36);
            this.LvwDatos.Name = "LvwDatos";
            this.LvwDatos.Size = new System.Drawing.Size(499, 422);
            this.LvwDatos.SmallImageList = this.ImgLista;
            this.LvwDatos.TabIndex = 4;
            this.LvwDatos.UseCompatibleStateImageBehavior = false;
            this.LvwDatos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LvwDatos_MouseDoubleClick);
            // 
            // ImgLista
            // 
            this.ImgLista.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ImgLista.ImageSize = new System.Drawing.Size(90, 50);
            this.ImgLista.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // PnlIzq
            // 
            this.PnlIzq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.PnlIzq.Controls.Add(this.BtnVolver);
            this.PnlIzq.Controls.Add(this.pictureBox1);
            this.PnlIzq.Controls.Add(this.BtnOp);
            this.PnlIzq.Controls.Add(this.BtnCapitulos);
            this.PnlIzq.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlIzq.Location = new System.Drawing.Point(0, 0);
            this.PnlIzq.Name = "PnlIzq";
            this.PnlIzq.Size = new System.Drawing.Size(222, 467);
            this.PnlIzq.TabIndex = 3;
            // 
            // BtnVolver
            // 
            this.BtnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.BtnVolver.FlatAppearance.BorderSize = 0;
            this.BtnVolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolver.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVolver.ForeColor = System.Drawing.Color.IndianRed;
            this.BtnVolver.Location = new System.Drawing.Point(33, 389);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(157, 47);
            this.BtnVolver.TabIndex = 3;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = false;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            this.BtnVolver.MouseEnter += new System.EventHandler(this.BtnCapitulos_MouseEnter);
            this.BtnVolver.MouseLeave += new System.EventHandler(this.BtnCapitulos_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ProyectoFinalUnai.Properties.Resources.Textura;
            this.pictureBox1.Image = global::ProyectoFinalUnai.Properties.Resources.LogoIncio;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // BtnOp
            // 
            this.BtnOp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.BtnOp.FlatAppearance.BorderSize = 0;
            this.BtnOp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.BtnOp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOp.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOp.ForeColor = System.Drawing.Color.IndianRed;
            this.BtnOp.Location = new System.Drawing.Point(33, 295);
            this.BtnOp.Name = "BtnOp";
            this.BtnOp.Size = new System.Drawing.Size(157, 47);
            this.BtnOp.TabIndex = 1;
            this.BtnOp.Text = "Openings";
            this.BtnOp.UseVisualStyleBackColor = false;
            this.BtnOp.Click += new System.EventHandler(this.BtnOp_Click);
            this.BtnOp.MouseEnter += new System.EventHandler(this.BtnCapitulos_MouseEnter);
            this.BtnOp.MouseLeave += new System.EventHandler(this.BtnCapitulos_MouseLeave);
            // 
            // BtnCapitulos
            // 
            this.BtnCapitulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.BtnCapitulos.FlatAppearance.BorderSize = 0;
            this.BtnCapitulos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.BtnCapitulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCapitulos.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCapitulos.ForeColor = System.Drawing.Color.IndianRed;
            this.BtnCapitulos.Location = new System.Drawing.Point(33, 212);
            this.BtnCapitulos.Name = "BtnCapitulos";
            this.BtnCapitulos.Size = new System.Drawing.Size(147, 47);
            this.BtnCapitulos.TabIndex = 0;
            this.BtnCapitulos.Text = "Capitulos";
            this.BtnCapitulos.UseVisualStyleBackColor = false;
            this.BtnCapitulos.Click += new System.EventHandler(this.BtnCapitulos_Click);
            this.BtnCapitulos.MouseEnter += new System.EventHandler(this.BtnCapitulos_MouseEnter);
            this.BtnCapitulos.MouseLeave += new System.EventHandler(this.BtnCapitulos_MouseLeave);
            // 
            // FrmTemporada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::ProyectoFinalUnai.Properties.Resources.Textura;
            this.ClientSize = new System.Drawing.Size(757, 467);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LvwDatos);
            this.Controls.Add(this.PnlIzq);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmTemporada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temporada";
            this.Load += new System.EventHandler(this.FrmTemporada_Load);
            this.PnlIzq.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.ListView LvwDatos;
        private System.Windows.Forms.Panel PnlIzq;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnOp;
        private System.Windows.Forms.Button BtnCapitulos;
        private System.Windows.Forms.ImageList ImgLista;
    }
}