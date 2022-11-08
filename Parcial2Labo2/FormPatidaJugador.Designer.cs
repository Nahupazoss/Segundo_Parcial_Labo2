
namespace Parcial2Labo2
{
    partial class FormPartida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPartida));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.img_5 = new System.Windows.Forms.PictureBox();
            this.img_4 = new System.Windows.Forms.PictureBox();
            this.img_2 = new System.Windows.Forms.PictureBox();
            this.img_3 = new System.Windows.Forms.PictureBox();
            this.img_1 = new System.Windows.Forms.PictureBox();
            this.btn_tirar1 = new System.Windows.Forms.Button();
            this.btn_2doTiro = new System.Windows.Forms.Button();
            this.btn_3erTiro = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.img_5);
            this.groupBox1.Controls.Add(this.img_4);
            this.groupBox1.Controls.Add(this.img_2);
            this.groupBox1.Controls.Add(this.img_3);
            this.groupBox1.Controls.Add(this.img_1);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 196);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // img_5
            // 
            this.img_5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img_5.Image = ((System.Drawing.Image)(resources.GetObject("img_5.Image")));
            this.img_5.Location = new System.Drawing.Point(532, 59);
            this.img_5.Name = "img_5";
            this.img_5.Size = new System.Drawing.Size(97, 102);
            this.img_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_5.TabIndex = 4;
            this.img_5.TabStop = false;
            this.img_5.Click += new System.EventHandler(this.img_5_Click);
            // 
            // img_4
            // 
            this.img_4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img_4.Image = ((System.Drawing.Image)(resources.GetObject("img_4.Image")));
            this.img_4.Location = new System.Drawing.Point(404, 59);
            this.img_4.Name = "img_4";
            this.img_4.Size = new System.Drawing.Size(97, 102);
            this.img_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_4.TabIndex = 3;
            this.img_4.TabStop = false;
            this.img_4.Click += new System.EventHandler(this.img_4_Click);
            // 
            // img_2
            // 
            this.img_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img_2.Image = ((System.Drawing.Image)(resources.GetObject("img_2.Image")));
            this.img_2.Location = new System.Drawing.Point(153, 59);
            this.img_2.Name = "img_2";
            this.img_2.Size = new System.Drawing.Size(97, 102);
            this.img_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_2.TabIndex = 2;
            this.img_2.TabStop = false;
            this.img_2.Click += new System.EventHandler(this.img_2_Click);
            // 
            // img_3
            // 
            this.img_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img_3.Image = ((System.Drawing.Image)(resources.GetObject("img_3.Image")));
            this.img_3.Location = new System.Drawing.Point(281, 59);
            this.img_3.Name = "img_3";
            this.img_3.Size = new System.Drawing.Size(97, 102);
            this.img_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_3.TabIndex = 1;
            this.img_3.TabStop = false;
            this.img_3.Click += new System.EventHandler(this.img_3_Click);
            // 
            // img_1
            // 
            this.img_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img_1.Image = global::Parcial2Labo2.Properties.Resources.cara0;
            this.img_1.Location = new System.Drawing.Point(26, 59);
            this.img_1.Name = "img_1";
            this.img_1.Size = new System.Drawing.Size(97, 102);
            this.img_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_1.TabIndex = 0;
            this.img_1.TabStop = false;
            this.img_1.Click += new System.EventHandler(this.img_1_Click);
            // 
            // btn_tirar1
            // 
            this.btn_tirar1.BackColor = System.Drawing.Color.Black;
            this.btn_tirar1.ForeColor = System.Drawing.Color.White;
            this.btn_tirar1.Location = new System.Drawing.Point(252, 543);
            this.btn_tirar1.Name = "btn_tirar1";
            this.btn_tirar1.Size = new System.Drawing.Size(161, 59);
            this.btn_tirar1.TabIndex = 1;
            this.btn_tirar1.Text = "TIRAR DADOS";
            this.btn_tirar1.UseVisualStyleBackColor = false;
            this.btn_tirar1.Click += new System.EventHandler(this.btn_PrimerTiro);
            // 
            // btn_2doTiro
            // 
            this.btn_2doTiro.BackColor = System.Drawing.Color.Black;
            this.btn_2doTiro.ForeColor = System.Drawing.Color.White;
            this.btn_2doTiro.Location = new System.Drawing.Point(252, 543);
            this.btn_2doTiro.Name = "btn_2doTiro";
            this.btn_2doTiro.Size = new System.Drawing.Size(161, 59);
            this.btn_2doTiro.TabIndex = 2;
            this.btn_2doTiro.Text = "TIRAR DADOS";
            this.btn_2doTiro.UseVisualStyleBackColor = false;
            this.btn_2doTiro.Click += new System.EventHandler(this.btn_2doTiro_Click);
            // 
            // btn_3erTiro
            // 
            this.btn_3erTiro.BackColor = System.Drawing.Color.Black;
            this.btn_3erTiro.ForeColor = System.Drawing.Color.White;
            this.btn_3erTiro.Location = new System.Drawing.Point(252, 543);
            this.btn_3erTiro.Name = "btn_3erTiro";
            this.btn_3erTiro.Size = new System.Drawing.Size(161, 59);
            this.btn_3erTiro.TabIndex = 3;
            this.btn_3erTiro.Text = "TIRAR DADOS";
            this.btn_3erTiro.UseVisualStyleBackColor = false;
            this.btn_3erTiro.Click += new System.EventHandler(this.btn_3erTiro_Click);
            // 
            // FormPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1103, 626);
            this.Controls.Add(this.btn_3erTiro);
            this.Controls.Add(this.btn_2doTiro);
            this.Controls.Add(this.btn_tirar1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPartida";
            this.Text = "Partida";
            this.Load += new System.EventHandler(this.FormPartida_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox img_5;
        private System.Windows.Forms.PictureBox img_4;
        private System.Windows.Forms.PictureBox img_2;
        private System.Windows.Forms.PictureBox img_3;
        private System.Windows.Forms.PictureBox img_1;
        private System.Windows.Forms.Button btn_tirar1;
        private System.Windows.Forms.Button btn_2doTiro;
        private System.Windows.Forms.Button btn_3erTiro;
    }
}