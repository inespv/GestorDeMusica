﻿namespace GestorDeMusica
{
    partial class Buscar
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
            this.Lcategoria = new System.Windows.Forms.Label();
            this.comboCategoria = new System.Windows.Forms.ComboBox();
            this.comboBoxCriterio = new System.Windows.Forms.ComboBox();
            this.LCriterio = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.CategoriaSelected = new System.Windows.Forms.Label();
            this.CriterioSelected = new System.Windows.Forms.Label();
            this.seleccion = new System.Windows.Forms.Label();
            this.seleccion2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(220, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "BUSCAR DATOS";
            // 
            // Lcategoria
            // 
            this.Lcategoria.AutoSize = true;
            this.Lcategoria.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lcategoria.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lcategoria.Location = new System.Drawing.Point(12, 93);
            this.Lcategoria.Name = "Lcategoria";
            this.Lcategoria.Size = new System.Drawing.Size(369, 20);
            this.Lcategoria.TabIndex = 1;
            this.Lcategoria.Text = "Insertar categoría por la que desea buscar";
            this.Lcategoria.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboCategoria
            // 
            this.comboCategoria.FormattingEnabled = true;
            this.comboCategoria.Items.AddRange(new object[] {
            "Cancion",
            "Album",
            "Artista"});
            this.comboCategoria.Location = new System.Drawing.Point(164, 135);
            this.comboCategoria.Name = "comboCategoria";
            this.comboCategoria.Size = new System.Drawing.Size(217, 24);
            this.comboCategoria.TabIndex = 2;
            this.comboCategoria.SelectedIndexChanged += new System.EventHandler(this.comboBuscar_SelectedIndexChanged);
            // 
            // comboBoxCriterio
            // 
            this.comboBoxCriterio.FormattingEnabled = true;
            this.comboBoxCriterio.Items.AddRange(new object[] {
            "Titulo",
            "TituloAlbum",
            "Genero",
            "Artista",
            "Anyo de lanzamiento",
            "Duracion"});
            this.comboBoxCriterio.Location = new System.Drawing.Point(544, 135);
            this.comboBoxCriterio.Name = "comboBoxCriterio";
            this.comboBoxCriterio.Size = new System.Drawing.Size(217, 24);
            this.comboBoxCriterio.TabIndex = 3;
            this.comboBoxCriterio.SelectedIndexChanged += new System.EventHandler(this.comboBoxCriterio_SelectedIndexChanged);
            // 
            // LCriterio
            // 
            this.LCriterio.AutoSize = true;
            this.LCriterio.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCriterio.ForeColor = System.Drawing.Color.Black;
            this.LCriterio.Location = new System.Drawing.Point(509, 93);
            this.LCriterio.Name = "LCriterio";
            this.LCriterio.Size = new System.Drawing.Size(252, 20);
            this.LCriterio.TabIndex = 4;
            this.LCriterio.Text = "Inserte criterio de búsqueda";
            this.LCriterio.Click += new System.EventHandler(this.label3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(38, 21);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 48);
            this.button2.TabIndex = 10;
            this.button2.Text = "Volver a la pantalla inicial";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 222);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(803, 229);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(409, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "label2";
            // 
            // CategoriaSelected
            // 
            this.CategoriaSelected.AutoSize = true;
            this.CategoriaSelected.ForeColor = System.Drawing.Color.Black;
            this.CategoriaSelected.Location = new System.Drawing.Point(12, 190);
            this.CategoriaSelected.Name = "CategoriaSelected";
            this.CategoriaSelected.Size = new System.Drawing.Size(151, 16);
            this.CategoriaSelected.TabIndex = 13;
            this.CategoriaSelected.Text = "Categoria seleccionada";
            // 
            // CriterioSelected
            // 
            this.CriterioSelected.AutoSize = true;
            this.CriterioSelected.ForeColor = System.Drawing.Color.Black;
            this.CriterioSelected.Location = new System.Drawing.Point(409, 190);
            this.CriterioSelected.Name = "CriterioSelected";
            this.CriterioSelected.Size = new System.Drawing.Size(134, 16);
            this.CriterioSelected.TabIndex = 14;
            this.CriterioSelected.Text = "Criterio seleccionado";
            this.CriterioSelected.Click += new System.EventHandler(this.label4_Click);
            // 
            // seleccion
            // 
            this.seleccion.AutoSize = true;
            this.seleccion.ForeColor = System.Drawing.Color.Black;
            this.seleccion.Location = new System.Drawing.Point(213, 190);
            this.seleccion.Name = "seleccion";
            this.seleccion.Size = new System.Drawing.Size(65, 16);
            this.seleccion.TabIndex = 15;
            this.seleccion.Text = "seleccion";
            this.seleccion.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // seleccion2
            // 
            this.seleccion2.AutoSize = true;
            this.seleccion2.ForeColor = System.Drawing.Color.Black;
            this.seleccion2.Location = new System.Drawing.Point(589, 190);
            this.seleccion2.Name = "seleccion2";
            this.seleccion2.Size = new System.Drawing.Size(134, 16);
            this.seleccion2.TabIndex = 16;
            this.seleccion2.Text = "Criterio seleccionado";
            this.seleccion2.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // Buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.seleccion2);
            this.Controls.Add(this.seleccion);
            this.Controls.Add(this.CriterioSelected);
            this.Controls.Add(this.CategoriaSelected);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.LCriterio);
            this.Controls.Add(this.comboBoxCriterio);
            this.Controls.Add(this.comboCategoria);
            this.Controls.Add(this.Lcategoria);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.Name = "Buscar";
            this.Text = "Buscar";
            this.Load += new System.EventHandler(this.Buscar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lcategoria;
        private System.Windows.Forms.ComboBox comboCategoria;
        private System.Windows.Forms.ComboBox comboBoxCriterio;
        private System.Windows.Forms.Label LCriterio;
        private object button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CategoriaSelected;
        private System.Windows.Forms.Label CriterioSelected;
        private System.Windows.Forms.Label seleccion;
        private System.Windows.Forms.Label seleccion2;
    }
}