﻿
namespace ProyectoFinalUnai
{
    partial class RJTextBox
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtRJ = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtRJ
            // 
            this.TxtRJ.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TxtRJ.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TxtRJ.BackColor = System.Drawing.Color.White;
            this.TxtRJ.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtRJ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtRJ.Location = new System.Drawing.Point(10, 7);
            this.TxtRJ.Name = "TxtRJ";
            this.TxtRJ.Size = new System.Drawing.Size(230, 15);
            this.TxtRJ.TabIndex = 0;
            // 
            // RJTextBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.TxtRJ);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DimGray;
            this.Name = "RJTextBox";
            this.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Size = new System.Drawing.Size(250, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtRJ;
    }
}
