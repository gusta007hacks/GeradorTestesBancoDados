﻿namespace GeradorTestes.WinApp.ModuloMateria
{
    partial class TabelaMateriasControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grid = new System.Windows.Forms.DataGridView();
            this.panelMateria = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.panelMateria.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(0, 3);
            this.grid.Name = "grid";
            this.grid.RowTemplate.Height = 25;
            this.grid.Size = new System.Drawing.Size(572, 320);
            this.grid.TabIndex = 0;
            // 
            // panelMateria
            // 
            this.panelMateria.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelMateria.Controls.Add(this.grid);
            this.panelMateria.Location = new System.Drawing.Point(0, 0);
            this.panelMateria.Name = "panelMateria";
            this.panelMateria.Size = new System.Drawing.Size(578, 320);
            this.panelMateria.TabIndex = 0;
            // 
            // TabelaMateriasControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMateria);
            this.Name = "TabelaMateriasControl";
            this.Size = new System.Drawing.Size(578, 320);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.panelMateria.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Panel panelMateria;
    }
}
