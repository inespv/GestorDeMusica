namespace GestorDeMusica
{
    partial class AgregarCancion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tituloTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.albumTB = new System.Windows.Forms.TextBox();
            this.artistaTB = new System.Windows.Forms.TextBox();
            this.generoTB = new System.Windows.Forms.TextBox();
            this.anyoTB = new System.Windows.Forms.TextBox();
            this.duracionTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cancionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cancionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Título";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Género";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(424, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Año ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Artista";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(407, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "Álbum";
            // 
            // tituloTB
            // 
            this.tituloTB.Location = new System.Drawing.Point(179, 149);
            this.tituloTB.Name = "tituloTB";
            this.tituloTB.Size = new System.Drawing.Size(180, 22);
            this.tituloTB.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(390, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 26);
            this.label7.TabIndex = 7;
            this.label7.Text = "Duración";
            // 
            // albumTB
            // 
            this.albumTB.Location = new System.Drawing.Point(535, 247);
            this.albumTB.Name = "albumTB";
            this.albumTB.Size = new System.Drawing.Size(180, 22);
            this.albumTB.TabIndex = 8;
            // 
            // artistaTB
            // 
            this.artistaTB.Location = new System.Drawing.Point(179, 365);
            this.artistaTB.Name = "artistaTB";
            this.artistaTB.Size = new System.Drawing.Size(180, 22);
            this.artistaTB.TabIndex = 9;
            // 
            // generoTB
            // 
            this.generoTB.Location = new System.Drawing.Point(179, 247);
            this.generoTB.Name = "generoTB";
            this.generoTB.Size = new System.Drawing.Size(180, 22);
            this.generoTB.TabIndex = 10;
            // 
            // anyoTB
            // 
            this.anyoTB.Location = new System.Drawing.Point(535, 149);
            this.anyoTB.Name = "anyoTB";
            this.anyoTB.Size = new System.Drawing.Size(180, 22);
            this.anyoTB.TabIndex = 11;
            this.anyoTB.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // duracionTB
            // 
            this.duracionTB.Location = new System.Drawing.Point(535, 365);
            this.duracionTB.Name = "duracionTB";
            this.duracionTB.Size = new System.Drawing.Size(180, 22);
            this.duracionTB.TabIndex = 12;
            this.duracionTB.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(170, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(486, 54);
            this.label2.TabIndex = 13;
            this.label2.Text = "AÑADIR CANCIÓN";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(344, 447);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 62);
            this.button1.TabIndex = 14;
            this.button1.Text = "GUARDAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancionBindingSource
            // 
            this.cancionBindingSource.DataSource = typeof(GestorDeMusica.Cancion);
            // 
            // AgregarCancion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(841, 564);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.duracionTB);
            this.Controls.Add(this.anyoTB);
            this.Controls.Add(this.generoTB);
            this.Controls.Add(this.artistaTB);
            this.Controls.Add(this.albumTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tituloTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.MinimizeBox = false;
            this.Name = "AgregarCancion";
            this.Text = "AgregarCancion";
            ((System.ComponentModel.ISupportInitialize)(this.cancionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tituloTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox albumTB;
        private System.Windows.Forms.TextBox artistaTB;
        private System.Windows.Forms.TextBox generoTB;
        private System.Windows.Forms.TextBox anyoTB;
        private System.Windows.Forms.TextBox duracionTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource cancionBindingSource;
    }
}