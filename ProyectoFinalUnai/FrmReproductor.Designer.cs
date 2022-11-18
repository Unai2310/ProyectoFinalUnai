
namespace ProyectoFinalUnai
{
    partial class FrmReproductor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReproductor));
            this.VlcPantalla = new LibVLCSharp.WinForms.VideoView();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.PnlControles = new System.Windows.Forms.Panel();
            this.LblTimer = new System.Windows.Forms.Label();
            this.TrbTime = new TrackBar.Dotnetrix.Controls.TrackBar();
            this.BtnVolumen = new System.Windows.Forms.Button();
            this.BtnCerrrar = new System.Windows.Forms.Button();
            this.BtnAmpliarReducir = new System.Windows.Forms.Button();
            this.BtnAvanzar = new System.Windows.Forms.Button();
            this.BtnRetroceder = new System.Windows.Forms.Button();
            this.BtnPlayPause = new System.Windows.Forms.Button();
            this.TrbVolumen = new TrackBar.Dotnetrix.Controls.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.VlcPantalla)).BeginInit();
            this.PnlControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrbTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrbVolumen)).BeginInit();
            this.SuspendLayout();
            // 
            // VlcPantalla
            // 
            this.VlcPantalla.BackColor = System.Drawing.Color.Black;
            this.VlcPantalla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VlcPantalla.Location = new System.Drawing.Point(0, 0);
            this.VlcPantalla.MediaPlayer = null;
            this.VlcPantalla.Name = "VlcPantalla";
            this.VlcPantalla.Size = new System.Drawing.Size(800, 450);
            this.VlcPantalla.TabIndex = 0;
            this.VlcPantalla.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.VlcPantalla_MouseDoubleClick);
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // PnlControles
            // 
            this.PnlControles.BackgroundImage = global::ProyectoFinalUnai.Properties.Resources.Textura;
            this.PnlControles.Controls.Add(this.LblTimer);
            this.PnlControles.Controls.Add(this.TrbTime);
            this.PnlControles.Controls.Add(this.BtnVolumen);
            this.PnlControles.Controls.Add(this.BtnCerrrar);
            this.PnlControles.Controls.Add(this.BtnAmpliarReducir);
            this.PnlControles.Controls.Add(this.BtnAvanzar);
            this.PnlControles.Controls.Add(this.BtnRetroceder);
            this.PnlControles.Controls.Add(this.BtnPlayPause);
            this.PnlControles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlControles.Location = new System.Drawing.Point(0, 409);
            this.PnlControles.Name = "PnlControles";
            this.PnlControles.Size = new System.Drawing.Size(800, 41);
            this.PnlControles.TabIndex = 1;
            // 
            // LblTimer
            // 
            this.LblTimer.AutoSize = true;
            this.LblTimer.BackColor = System.Drawing.Color.Transparent;
            this.LblTimer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTimer.Location = new System.Drawing.Point(190, 25);
            this.LblTimer.Name = "LblTimer";
            this.LblTimer.Size = new System.Drawing.Size(0, 16);
            this.LblTimer.TabIndex = 7;
            // 
            // TrbTime
            // 
            this.TrbTime.BackColor = System.Drawing.Color.Transparent;
            this.TrbTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrbTime.Location = new System.Drawing.Point(184, 0);
            this.TrbTime.Maximum = 0;
            this.TrbTime.Name = "TrbTime";
            this.TrbTime.Size = new System.Drawing.Size(524, 41);
            this.TrbTime.TabIndex = 8;
            this.TrbTime.TabStop = false;
            this.TrbTime.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TrbTime.Scroll += new System.EventHandler(this.TrbTime_Scroll);
            // 
            // BtnVolumen
            // 
            this.BtnVolumen.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnVolumen.Image = ((System.Drawing.Image)(resources.GetObject("BtnVolumen.Image")));
            this.BtnVolumen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVolumen.Location = new System.Drawing.Point(708, 0);
            this.BtnVolumen.Name = "BtnVolumen";
            this.BtnVolumen.Size = new System.Drawing.Size(46, 41);
            this.BtnVolumen.TabIndex = 6;
            this.BtnVolumen.TabStop = false;
            this.BtnVolumen.UseVisualStyleBackColor = true;
            this.BtnVolumen.Click += new System.EventHandler(this.BtnVolumen_Click);
            // 
            // BtnCerrrar
            // 
            this.BtnCerrrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnCerrrar.Image = global::ProyectoFinalUnai.Properties.Resources.Borrar;
            this.BtnCerrrar.Location = new System.Drawing.Point(754, 0);
            this.BtnCerrrar.Name = "BtnCerrrar";
            this.BtnCerrrar.Size = new System.Drawing.Size(46, 41);
            this.BtnCerrrar.TabIndex = 4;
            this.BtnCerrrar.TabStop = false;
            this.BtnCerrrar.UseVisualStyleBackColor = true;
            this.BtnCerrrar.Click += new System.EventHandler(this.BtnCerrrar_Click);
            // 
            // BtnAmpliarReducir
            // 
            this.BtnAmpliarReducir.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnAmpliarReducir.Image = global::ProyectoFinalUnai.Properties.Resources.ampliar;
            this.BtnAmpliarReducir.Location = new System.Drawing.Point(138, 0);
            this.BtnAmpliarReducir.Name = "BtnAmpliarReducir";
            this.BtnAmpliarReducir.Size = new System.Drawing.Size(46, 41);
            this.BtnAmpliarReducir.TabIndex = 3;
            this.BtnAmpliarReducir.TabStop = false;
            this.BtnAmpliarReducir.UseVisualStyleBackColor = true;
            this.BtnAmpliarReducir.Click += new System.EventHandler(this.BtnAmpliarReducir_Click);
            // 
            // BtnAvanzar
            // 
            this.BtnAvanzar.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnAvanzar.Image = global::ProyectoFinalUnai.Properties.Resources.avanzar;
            this.BtnAvanzar.Location = new System.Drawing.Point(92, 0);
            this.BtnAvanzar.Name = "BtnAvanzar";
            this.BtnAvanzar.Size = new System.Drawing.Size(46, 41);
            this.BtnAvanzar.TabIndex = 2;
            this.BtnAvanzar.TabStop = false;
            this.BtnAvanzar.UseVisualStyleBackColor = true;
            this.BtnAvanzar.Click += new System.EventHandler(this.BtnAvanzar_Click);
            // 
            // BtnRetroceder
            // 
            this.BtnRetroceder.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnRetroceder.Image = global::ProyectoFinalUnai.Properties.Resources.retroceder;
            this.BtnRetroceder.Location = new System.Drawing.Point(46, 0);
            this.BtnRetroceder.Name = "BtnRetroceder";
            this.BtnRetroceder.Size = new System.Drawing.Size(46, 41);
            this.BtnRetroceder.TabIndex = 1;
            this.BtnRetroceder.TabStop = false;
            this.BtnRetroceder.UseVisualStyleBackColor = true;
            this.BtnRetroceder.Click += new System.EventHandler(this.BtnRetroceder_Click);
            // 
            // BtnPlayPause
            // 
            this.BtnPlayPause.BackColor = System.Drawing.SystemColors.Control;
            this.BtnPlayPause.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnPlayPause.Image = global::ProyectoFinalUnai.Properties.Resources.pause;
            this.BtnPlayPause.Location = new System.Drawing.Point(0, 0);
            this.BtnPlayPause.Name = "BtnPlayPause";
            this.BtnPlayPause.Size = new System.Drawing.Size(46, 41);
            this.BtnPlayPause.TabIndex = 0;
            this.BtnPlayPause.TabStop = false;
            this.BtnPlayPause.UseVisualStyleBackColor = false;
            this.BtnPlayPause.Click += new System.EventHandler(this.BtnPlayPause_Click);
            // 
            // TrbVolumen
            // 
            this.TrbVolumen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TrbVolumen.BackColor = System.Drawing.Color.Transparent;
            this.TrbVolumen.Location = new System.Drawing.Point(708, 279);
            this.TrbVolumen.Maximum = 100;
            this.TrbVolumen.Name = "TrbVolumen";
            this.TrbVolumen.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TrbVolumen.Size = new System.Drawing.Size(45, 130);
            this.TrbVolumen.TabIndex = 7;
            this.TrbVolumen.TickFrequency = 10;
            this.TrbVolumen.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.TrbVolumen.Value = 100;
            this.TrbVolumen.Visible = false;
            this.TrbVolumen.Scroll += new System.EventHandler(this.TrbVolumen_Scroll);
            this.TrbVolumen.ValueChanged += new System.EventHandler(this.TrbVolumen_ValueChanged);
            // 
            // FrmReproductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TrbVolumen);
            this.Controls.Add(this.PnlControles);
            this.Controls.Add(this.VlcPantalla);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReproductor";
            this.Text = "FrmReproductor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmReproductor_FormClosing);
            this.Load += new System.EventHandler(this.FrmReproductor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VlcPantalla)).EndInit();
            this.PnlControles.ResumeLayout(false);
            this.PnlControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrbTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrbVolumen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LibVLCSharp.WinForms.VideoView VlcPantalla;
        private System.Windows.Forms.Panel PnlControles;
        private System.Windows.Forms.Button BtnCerrrar;
        private System.Windows.Forms.Button BtnAmpliarReducir;
        private System.Windows.Forms.Button BtnAvanzar;
        private System.Windows.Forms.Button BtnRetroceder;
        private System.Windows.Forms.Button BtnPlayPause;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Button BtnVolumen;
        private TrackBar.Dotnetrix.Controls.TrackBar TrbVolumen;
        private System.Windows.Forms.Label LblTimer;
        private TrackBar.Dotnetrix.Controls.TrackBar TrbTime;
    }
}