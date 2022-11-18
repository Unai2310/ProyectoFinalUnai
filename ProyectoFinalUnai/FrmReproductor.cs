using LibVLCSharp.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalUnai
{
    public partial class FrmReproductor : Form
    {
        private String url;

        private int segundos = 0;
        private int minutos = 0;
        private int horas = 0;
        public LibVLC libVLC;
        public MediaPlayer mp;
        public Media media;
        public bool pantallaComp = false;
        public bool reproduciendo = false;
        public Size tamañoVideo;
        public Size tamañoForm;
        public Point videoLoc;
        private int volumen;
        public FrmReproductor(String video)
        {
            InitializeComponent();
            url = video;
            Core.Initialize();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(EventosTeclas);
            tamañoVideo = VlcPantalla.Size;
            tamañoForm = this.Size;
            videoLoc = VlcPantalla.Location;
            //VLC stuff
            libVLC = new LibVLC();
            mp = new MediaPlayer(libVLC);
            VlcPantalla.MediaPlayer = mp;
            mp.Playing += OnPlaying;
            mp.EndReached += OnEnding;
        }
        private void FrmReproductor_Load(object sender, EventArgs e)
        {
            mp.Play(new Media(libVLC, new Uri(url)));
            TrbVolumen.Value = mp.Volume;
            reproduciendo = true;
        }
        public void EventosTeclas(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && pantallaComp)
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
                this.Size = tamañoForm;
                VlcPantalla.Size = tamañoForm;
                BtnAmpliarReducir.Image = Properties.Resources.ampliar;
                VlcPantalla.Location = videoLoc;
                pantallaComp = false;
            }
            if (e.KeyCode == Keys.F && !pantallaComp)
            {
                VlcPantalla.Size = this.Size;
                VlcPantalla.Location = new Point(0, 0);
                this.FormBorderStyle = FormBorderStyle.None;
                BtnAmpliarReducir.Image = Properties.Resources.minimizar;
                this.WindowState = FormWindowState.Maximized;
                pantallaComp = true;
            }

            if (reproduciendo)
            {
                if (e.KeyCode == Keys.Space)
                {
                    if (mp.State == VLCState.Playing)
                    {
                        mp.Pause();
                        Timer.Stop();
                        BtnPlayPause.Image = Properties.Resources.play;
                    }
                    else
                    {
                        mp.Play();
                        Timer.Start();
                        BtnPlayPause.Image = Properties.Resources.pause;
                    }
                }

                if (e.KeyCode == Keys.A)
                {
                    mp.Position -= 0.02f;
                    TrbTime.Value = Convert.ToInt32(mp.Time / 1000);
                    LblTimer.Text = milisaFormatTrack(TrbTime.Value) + " / " + milisaFormatTrack(mp.Length / 1000);
                    String[] partes = milisaFormatTrack(TrbTime.Value).Split(':');
                    if (partes.Length == 2)
                    {
                        minutos = Convert.ToInt32(partes[0]);
                        segundos = Convert.ToInt32(partes[1]);
                    }
                    else
                    {
                        horas = Convert.ToInt32(partes[0]);
                        minutos = Convert.ToInt32(partes[1]);
                        segundos = Convert.ToInt32(partes[2]);
                    }
                }
                if (e.KeyCode == Keys.D)
                {
                    mp.Position += 0.02f;
                    TrbTime.Value = Convert.ToInt32(mp.Time / 1000);
                    LblTimer.Text = milisaFormatTrack(TrbTime.Value) + " / " + milisaFormatTrack(mp.Length / 1000);
                    String[] partes = milisaFormatTrack(TrbTime.Value).Split(':');
                    if (partes.Length == 2)
                    {
                        minutos = Convert.ToInt32(partes[0]);
                        segundos = Convert.ToInt32(partes[1]);
                    }
                    else
                    {
                        horas = Convert.ToInt32(partes[0]);
                        minutos = Convert.ToInt32(partes[1]);
                        segundos = Convert.ToInt32(partes[2]);
                    }
                }
            }
            if (e.KeyCode == Keys.C && PnlControles.Visible)
            {
                PnlControles.Hide();
                if (TrbVolumen.Visible)
                {
                    TrbVolumen.Hide();
                }
            }
            else if (e.KeyCode == Keys.C)
            {
                PnlControles.Show();
            }
            if (e.KeyCode == Keys.M && mp.Volume != 0)
            {
                volumen = mp.Volume;
                mp.Volume = 0;
                TrbVolumen.Value = 0;
                BtnVolumen.Image = Properties.Resources.Volumen0;
            }
            else if (e.KeyCode == Keys.M)
            {
                mp.Volume = volumen;
                TrbVolumen.Value = volumen;
                if (TrbVolumen.Value == 0)
                {
                    BtnVolumen.Image = Properties.Resources.Volumen0;
                }
                else if (TrbVolumen.Value > 0 && TrbVolumen.Value < 33)
                {
                    BtnVolumen.Image = Properties.Resources.VolumenMin;
                }
                else if (TrbVolumen.Value > 33 && TrbVolumen.Value < 66)
                {
                    BtnVolumen.Image = Properties.Resources.VolumenMid;
                }
                else if (TrbVolumen.Value > 66)
                {
                    BtnVolumen.Image = Properties.Resources.VolumenMax;
                }
            }
        }
        private void FrmReproductor_FormClosing(object sender, FormClosingEventArgs e)
        {
            mp.Stop();
            this.Dispose();
        }
        private void OnPlaying(object sender, EventArgs e)
        {
            mp.EnableKeyInput = false;
            mp.EnableMouseInput = false;
        }
        private void OnEnding(object sender, EventArgs e)
        {
            Timer.Stop();
            this.Invoke(new MethodInvoker(delegate
            {
                this.Dispose();
            }));
        }
        private void VlcPantalla_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (pantallaComp)
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
                this.Size = tamañoForm;
                VlcPantalla.Size = tamañoForm;
                VlcPantalla.Location = videoLoc;
                pantallaComp = false;
            }
            else
            {
                VlcPantalla.Size = this.Size;
                VlcPantalla.Location = new Point(0, 0);
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                pantallaComp = true;
            }
        }
        private void BtnCerrrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void BtnAmpliarReducir_Click(object sender, EventArgs e)
        {
            if (pantallaComp)
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
                this.Size = tamañoForm;
                VlcPantalla.Size = tamañoForm;
                VlcPantalla.Location = videoLoc;
                BtnAmpliarReducir.Image = Properties.Resources.ampliar;
                pantallaComp = false;
            }
            else
            {
                VlcPantalla.Size = this.Size;
                VlcPantalla.Location = new Point(0, 0);
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                BtnAmpliarReducir.Image = Properties.Resources.minimizar;
                pantallaComp = true;
            }
        }
        private void BtnAvanzar_Click(object sender, EventArgs e)
        {
            mp.Position += 0.02f;
            TrbTime.Value = Convert.ToInt32(mp.Time / 1000);
            LblTimer.Text = milisaFormatTrack(TrbTime.Value) + " / " + milisaFormatTrack(mp.Length / 1000);
            String[] partes = milisaFormatTrack(TrbTime.Value).Split(':');
            if (partes.Length == 2)
            {
                minutos = Convert.ToInt32(partes[0]);
                segundos = Convert.ToInt32(partes[1]);
            }
            else
            {
                horas = Convert.ToInt32(partes[0]);
                minutos = Convert.ToInt32(partes[1]);
                segundos = Convert.ToInt32(partes[2]);
            }
        }
        private void BtnRetroceder_Click(object sender, EventArgs e)
        {
            mp.Position -= 0.02f;
            TrbTime.Value = Convert.ToInt32(mp.Time / 1000);
            LblTimer.Text = milisaFormatTrack(TrbTime.Value) + " / " + milisaFormatTrack(mp.Length / 1000);
            String[] partes = milisaFormatTrack(TrbTime.Value).Split(':');
            if (partes.Length == 2)
            {
                minutos = Convert.ToInt32(partes[0]);
                segundos = Convert.ToInt32(partes[1]);
            }
            else
            {
                horas = Convert.ToInt32(partes[0]);
                minutos = Convert.ToInt32(partes[1]);
                segundos = Convert.ToInt32(partes[2]);
            }
        }
        private void BtnPlayPause_Click(object sender, EventArgs e)
        {
            if (mp.State == VLCState.Playing)
            {
                mp.Pause();
                Timer.Stop();
                BtnPlayPause.Image = Properties.Resources.play;
            }
            else
            {
                mp.Play();
                Timer.Start();
                BtnPlayPause.Image = Properties.Resources.pause;
            }
        }
        private void BtnVolumen_Click(object sender, EventArgs e)
        {
            if (TrbVolumen.Visible)
            {
                TrbVolumen.Hide();
            }
            else
            {
                TrbVolumen.Show();
            }
        }
        private void TrbVolumen_ValueChanged(object sender, EventArgs e)
        {
            mp.Volume = TrbVolumen.Value;
            if (TrbVolumen.Value == 0)
            {
                BtnVolumen.Image = Properties.Resources.Volumen0;
            }
            else if (TrbVolumen.Value > 0 && TrbVolumen.Value < 33)
            {
                BtnVolumen.Image = Properties.Resources.VolumenMin;
            }
            else if (TrbVolumen.Value > 33 && TrbVolumen.Value < 66)
            {
                BtnVolumen.Image = Properties.Resources.VolumenMid;
            }
            else if (TrbVolumen.Value > 66)
            {
                BtnVolumen.Image = Properties.Resources.VolumenMax;
            }
        }
        private void TrbVolumen_Scroll(object sender, EventArgs e)
        {
            mp.Volume = TrbVolumen.Value;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (TrbTime.Maximum == 0)
            {
                TrbTime.Maximum = Convert.ToInt32(mp.Length / 1000);
            }
            if (milisaFormatTrack(mp.Length / 1000).Length > 5 && mp.IsPlaying)
            {
                segundos++;
                if (segundos == 60)
                {
                    segundos = 0;
                    minutos++;
                    if (minutos == 60)
                    {
                        minutos = 0;
                        horas++;
                    }
                }
                LblTimer.Text = horas + ":" + minutos + ":" + segundos + " / " + milisaFormatTrack(mp.Length / 1000);
                try
                {
                    TrbTime.Value += 1;
                }
                catch (Exception ex)
                {
                    TrbTime.Value += 0;
                }

            }
            else if (mp.IsPlaying)
            {
                segundos++;
                if (segundos == 60)
                {
                    segundos = 0;
                    minutos++;
                }
                LblTimer.Text = minutos + ":" + segundos + " / " + milisaFormatTrack(mp.Length / 1000);
                try
                {
                    TrbTime.Value += 1;
                }
                catch (Exception ex)
                {
                    TrbTime.Value += 0;
                }
            }
        }
        private void TrbTime_Scroll(object sender, EventArgs e)
        {
            mp.Time = TrbTime.Value * 1000;
            LblTimer.Text = milisaFormatTrack(TrbTime.Value) + " / " + milisaFormatTrack(mp.Length / 1000);
            String[] partes = milisaFormatTrack(TrbTime.Value).Split(':');
            if (partes.Length == 2)
            {
                minutos = Convert.ToInt32(partes[0]);
                segundos = Convert.ToInt32(partes[1]);
            }
            else
            {
                horas = Convert.ToInt32(partes[0]);
                minutos = Convert.ToInt32(partes[1]);
                segundos = Convert.ToInt32(partes[2]);
            }
        }
        private String milisaFormatTrack(long segTotal)
        {
            long horas = segTotal / 3600;
            long mins = (segTotal - horas * 3600) / 60;
            long seg = (segTotal - horas * 3600) % 60;
            if (horas == 0)
            {
                return mins + ":" + seg;
            }
            else
            {
                return horas + ":" + mins + ":" + seg;
            }
        }
    }
}