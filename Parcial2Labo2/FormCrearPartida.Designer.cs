
namespace Parcial2Labo2
{
    partial class FormCrearPartida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCrearPartida));
            this.btn_JugarYa = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Salir = new System.Windows.Forms.PictureBox();
            this.img_dados2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbx_CantJugadoress = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_dados2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_JugarYa
            // 
            this.btn_JugarYa.BackColor = System.Drawing.Color.Maroon;
            this.btn_JugarYa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_JugarYa.ForeColor = System.Drawing.Color.White;
            this.btn_JugarYa.Location = new System.Drawing.Point(558, 188);
            this.btn_JugarYa.Name = "btn_JugarYa";
            this.btn_JugarYa.Size = new System.Drawing.Size(137, 50);
            this.btn_JugarYa.TabIndex = 2;
            this.btn_JugarYa.Text = "JUGAR YA!!";
            this.btn_JugarYa.UseVisualStyleBackColor = false;
            this.btn_JugarYa.Click += new System.EventHandler(this.btn_JugarYa_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "NOMBRE DE SALA";
            this.textBox1.Size = new System.Drawing.Size(198, 23);
            this.textBox1.TabIndex = 3;
            this.textBox1.Tag = "";
            // 
            // btn_Salir
            // 
            this.btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_Salir.Image")));
            this.btn_Salir.Location = new System.Drawing.Point(640, 3);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(55, 47);
            this.btn_Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Salir.TabIndex = 9;
            this.btn_Salir.TabStop = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // img_dados2
            // 
            this.img_dados2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img_dados2.Image = ((System.Drawing.Image)(resources.GetObject("img_dados2.Image")));
            this.img_dados2.Location = new System.Drawing.Point(246, 3);
            this.img_dados2.Name = "img_dados2";
            this.img_dados2.Size = new System.Drawing.Size(306, 245);
            this.img_dados2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_dados2.TabIndex = 10;
            this.img_dados2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(12, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 26);
            this.label2.TabIndex = 11;
            this.label2.Text = "DRK GENERALA";
            // 
            // cmbx_CantJugadoress
            // 
            this.cmbx_CantJugadoress.AccessibleDescription = "";
            this.cmbx_CantJugadoress.AccessibleName = "";
            this.cmbx_CantJugadoress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_CantJugadoress.FormattingEnabled = true;
            this.cmbx_CantJugadoress.Location = new System.Drawing.Point(14, 110);
            this.cmbx_CantJugadoress.Name = "cmbx_CantJugadoress";
            this.cmbx_CantJugadoress.Size = new System.Drawing.Size(198, 23);
            this.cmbx_CantJugadoress.TabIndex = 12;
            this.cmbx_CantJugadoress.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Cantidad de jugadores:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbx_CantJugadoress);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(12, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 198);
            this.panel1.TabIndex = 14;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-346, -86);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(736, 965);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // FormCrearPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(702, 250);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.img_dados2);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_JugarYa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCrearPartida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCrearPartida";
            this.Load += new System.EventHandler(this.FormCrearPartida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_dados2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_JugarYa;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox btn_Salir;
        private System.Windows.Forms.PictureBox img_dados2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbx_CantJugadoress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}