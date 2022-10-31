
namespace Parcial2Labo2
{
    partial class FormMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuPrincipal));
            this.img_menu = new System.Windows.Forms.PictureBox();
            this.lbl_Bienvenida = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.PictureBox();
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_CrearPartida = new System.Windows.Forms.Button();
            this.btn_HistorialPartidas = new System.Windows.Forms.Button();
            this.btn_Estadisticas = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.img_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // img_menu
            // 
            this.img_menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.img_menu.BackColor = System.Drawing.Color.Black;
            this.img_menu.Image = ((System.Drawing.Image)(resources.GetObject("img_menu.Image")));
            this.img_menu.Location = new System.Drawing.Point(-351, 150);
            this.img_menu.Name = "img_menu";
            this.img_menu.Size = new System.Drawing.Size(1517, 267);
            this.img_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_menu.TabIndex = 0;
            this.img_menu.TabStop = false;
            // 
            // lbl_Bienvenida
            // 
            this.lbl_Bienvenida.AutoSize = true;
            this.lbl_Bienvenida.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Bienvenida.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Bienvenida.Location = new System.Drawing.Point(87, 97);
            this.lbl_Bienvenida.Name = "lbl_Bienvenida";
            this.lbl_Bienvenida.Size = new System.Drawing.Size(258, 26);
            this.lbl_Bienvenida.TabIndex = 1;
            this.lbl_Bienvenida.Text = "¡Bienvenido NahuPazos!";
            // 
            // btn_Salir
            // 
            this.btn_Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_Salir.Image")));
            this.btn_Salir.Location = new System.Drawing.Point(765, 3);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(51, 50);
            this.btn_Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Salir.TabIndex = 9;
            this.btn_Salir.TabStop = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.ForeColor = System.Drawing.Color.Gray;
            this.lbl_Fecha.Location = new System.Drawing.Point(87, 132);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(172, 15);
            this.lbl_Fecha.TabIndex = 10;
            this.lbl_Fecha.Text = "miercoles, 27 de octbre de 2022";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-32, 280);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1214, 884);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // btn_CrearPartida
            // 
            this.btn_CrearPartida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_CrearPartida.BackColor = System.Drawing.Color.Maroon;
            this.btn_CrearPartida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CrearPartida.ForeColor = System.Drawing.Color.White;
            this.btn_CrearPartida.Location = new System.Drawing.Point(87, 508);
            this.btn_CrearPartida.Name = "btn_CrearPartida";
            this.btn_CrearPartida.Size = new System.Drawing.Size(133, 69);
            this.btn_CrearPartida.TabIndex = 15;
            this.btn_CrearPartida.Text = "CREAR PARTIDA";
            this.btn_CrearPartida.UseVisualStyleBackColor = false;
            this.btn_CrearPartida.Click += new System.EventHandler(this.btn_CrearPartida_Click);
            // 
            // btn_HistorialPartidas
            // 
            this.btn_HistorialPartidas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_HistorialPartidas.BackColor = System.Drawing.Color.Maroon;
            this.btn_HistorialPartidas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_HistorialPartidas.ForeColor = System.Drawing.Color.White;
            this.btn_HistorialPartidas.Location = new System.Drawing.Point(595, 508);
            this.btn_HistorialPartidas.Name = "btn_HistorialPartidas";
            this.btn_HistorialPartidas.Size = new System.Drawing.Size(133, 69);
            this.btn_HistorialPartidas.TabIndex = 16;
            this.btn_HistorialPartidas.Text = "HISTORIAL DE PARTIDAS";
            this.btn_HistorialPartidas.UseVisualStyleBackColor = false;
            // 
            // btn_Estadisticas
            // 
            this.btn_Estadisticas.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Estadisticas.BackColor = System.Drawing.Color.Maroon;
            this.btn_Estadisticas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Estadisticas.ForeColor = System.Drawing.Color.White;
            this.btn_Estadisticas.Location = new System.Drawing.Point(338, 508);
            this.btn_Estadisticas.Name = "btn_Estadisticas";
            this.btn_Estadisticas.Size = new System.Drawing.Size(133, 69);
            this.btn_Estadisticas.TabIndex = 17;
            this.btn_Estadisticas.Text = "ESTADISTICAS";
            this.btn_Estadisticas.UseVisualStyleBackColor = false;
            this.btn_Estadisticas.Click += new System.EventHandler(this.btn_Estadisticas_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 26);
            this.label2.TabIndex = 18;
            this.label2.Text = "DRK GENERALA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Jugar a la generala nunca fue tan facil!";
            // 
            // FormMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(818, 622);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Fecha);
            this.Controls.Add(this.btn_Estadisticas);
            this.Controls.Add(this.btn_HistorialPartidas);
            this.Controls.Add(this.btn_CrearPartida);
            this.Controls.Add(this.img_menu);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.lbl_Bienvenida);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(834, 661);
            this.Name = "FormMenuPrincipal";
            this.Text = "Menu principal";
            this.Load += new System.EventHandler(this.FormMenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox img_menu;
        private System.Windows.Forms.Label lbl_Bienvenida;
        private System.Windows.Forms.PictureBox btn_Salir;
        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btn_CrearPartida;
        private System.Windows.Forms.Button btn_HistorialPartidas;
        private System.Windows.Forms.Button btn_Estadisticas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}