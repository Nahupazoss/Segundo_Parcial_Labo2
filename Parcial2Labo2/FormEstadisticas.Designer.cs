
namespace Parcial2Labo2
{
    partial class FormEstadisticas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEstadisticas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_jugadas = new System.Windows.Forms.Label();
            this.lbl_ganadas = new System.Windows.Forms.Label();
            this.lbl_perdidas = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_numCantJugadores = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Salir)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(109, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 68);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(463, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "ESTADISTICAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "DRK GENERALA";
            // 
            // btn_Salir
            // 
            this.btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_Salir.Image")));
            this.btn_Salir.Location = new System.Drawing.Point(720, 9);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(58, 54);
            this.btn_Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Salir.TabIndex = 10;
            this.btn_Salir.TabStop = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(109, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "Partidas jugadas ===>";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(109, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "Partidas ganadas ===>";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(109, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(256, 26);
            this.label5.TabIndex = 13;
            this.label5.Text = "Partidas perdidas ===>";
            // 
            // lbl_jugadas
            // 
            this.lbl_jugadas.AutoSize = true;
            this.lbl_jugadas.BackColor = System.Drawing.Color.Black;
            this.lbl_jugadas.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_jugadas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_jugadas.Location = new System.Drawing.Point(648, 227);
            this.lbl_jugadas.Name = "lbl_jugadas";
            this.lbl_jugadas.Size = new System.Drawing.Size(24, 26);
            this.lbl_jugadas.TabIndex = 14;
            this.lbl_jugadas.Text = "0";
            // 
            // lbl_ganadas
            // 
            this.lbl_ganadas.AutoSize = true;
            this.lbl_ganadas.BackColor = System.Drawing.Color.Black;
            this.lbl_ganadas.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_ganadas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_ganadas.Location = new System.Drawing.Point(648, 307);
            this.lbl_ganadas.Name = "lbl_ganadas";
            this.lbl_ganadas.Size = new System.Drawing.Size(24, 26);
            this.lbl_ganadas.TabIndex = 15;
            this.lbl_ganadas.Text = "0";
            // 
            // lbl_perdidas
            // 
            this.lbl_perdidas.AutoSize = true;
            this.lbl_perdidas.BackColor = System.Drawing.Color.Black;
            this.lbl_perdidas.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_perdidas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_perdidas.Location = new System.Drawing.Point(648, 392);
            this.lbl_perdidas.Name = "lbl_perdidas";
            this.lbl_perdidas.Size = new System.Drawing.Size(24, 26);
            this.lbl_perdidas.TabIndex = 16;
            this.lbl_perdidas.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(109, 475);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(306, 26);
            this.label9.TabIndex = 17;
            this.label9.Text = "Cantidad de jugadores ===>";
            // 
            // lbl_numCantJugadores
            // 
            this.lbl_numCantJugadores.AutoSize = true;
            this.lbl_numCantJugadores.BackColor = System.Drawing.Color.Black;
            this.lbl_numCantJugadores.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_numCantJugadores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_numCantJugadores.Location = new System.Drawing.Point(648, 475);
            this.lbl_numCantJugadores.Name = "lbl_numCantJugadores";
            this.lbl_numCantJugadores.Size = new System.Drawing.Size(24, 26);
            this.lbl_numCantJugadores.TabIndex = 18;
            this.lbl_numCantJugadores.Text = "0";
            // 
            // FormEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(792, 690);
            this.Controls.Add(this.lbl_numCantJugadores);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl_perdidas);
            this.Controls.Add(this.lbl_ganadas);
            this.Controls.Add(this.lbl_jugadas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEstadisticas";
            this.Text = "Estadisticas";
            this.Load += new System.EventHandler(this.FormEstadisticas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Salir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btn_Salir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_jugadas;
        private System.Windows.Forms.Label lbl_ganadas;
        private System.Windows.Forms.Label lbl_perdidas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_numCantJugadores;
    }
}