namespace GestorDeMusica
{
    partial class AgregarAlbum
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tituloATB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.generoATB = new System.Windows.Forms.TextBox();
            this.artistaATB = new System.Windows.Forms.TextBox();
            this.anyoATB = new System.Windows.Forms.TextBox();
            this.duracionATB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Título";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Género";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(469, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Año de lanzamiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Artista";
            // 
            // tituloATB
            // 
            this.tituloATB.Location = new System.Drawing.Point(22, 141);
            this.tituloATB.Name = "tituloATB";
            this.tituloATB.Size = new System.Drawing.Size(180, 22);
            this.tituloATB.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(529, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 26);
            this.label7.TabIndex = 7;
            this.label7.Text = "Duración";
            // 
            // generoATB
            // 
            this.generoATB.Location = new System.Drawing.Point(22, 272);
            this.generoATB.Name = "generoATB";
            this.generoATB.Size = new System.Drawing.Size(180, 22);
            this.generoATB.TabIndex = 9;
            // 
            // artistaATB
            // 
            this.artistaATB.Location = new System.Drawing.Point(22, 391);
            this.artistaATB.Name = "artistaATB";
            this.artistaATB.Size = new System.Drawing.Size(180, 22);
            this.artistaATB.TabIndex = 10;
            // 
            // anyoATB
            // 
            this.anyoATB.Location = new System.Drawing.Point(495, 141);
            this.anyoATB.Name = "anyoATB";
            this.anyoATB.Size = new System.Drawing.Size(180, 22);
            this.anyoATB.TabIndex = 11;
            // 
            // duracionATB
            // 
            this.duracionATB.Location = new System.Drawing.Point(495, 272);
            this.duracionATB.Name = "duracionATB";
            this.duracionATB.Size = new System.Drawing.Size(180, 22);
            this.duracionATB.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(170, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(429, 54);
            this.label2.TabIndex = 13;
            this.label2.Text = "AÑADIR ÁLBUM";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(285, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 62);
            this.button1.TabIndex = 14;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(439, 386);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(293, 27);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = " ¿Tiene versión en vinilo ?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // AgregarAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.duracionATB);
            this.Controls.Add(this.anyoATB);
            this.Controls.Add(this.artistaATB);
            this.Controls.Add(this.generoATB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tituloATB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "AgregarAlbum";
            this.Text = "AgregarCancion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tituloATB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox generoATB;
        private System.Windows.Forms.TextBox artistaATB;
        private System.Windows.Forms.TextBox anyoATB;
        private System.Windows.Forms.TextBox duracionATB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
