namespace Vistas
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.AgSal = new System.Windows.Forms.Button();
            this.TxtNom = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.BdD = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.BoSal = new System.Windows.Forms.Button();
            this.MoSal = new System.Windows.Forms.Button();
            this.Capacidad = new System.Windows.Forms.TextBox();
            this.TxtCap = new System.Windows.Forms.Label();
            this.Descripcion = new System.Windows.Forms.TextBox();
            this.TxtDes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BdD)).BeginInit();
            this.SuspendLayout();
            // 
            // AgSal
            // 
            this.AgSal.Location = new System.Drawing.Point(59, 519);
            this.AgSal.Name = "AgSal";
            this.AgSal.Size = new System.Drawing.Size(106, 23);
            this.AgSal.TabIndex = 2;
            this.AgSal.Text = "Agregar Sala";
            this.AgSal.UseVisualStyleBackColor = true;
            this.AgSal.Click += new System.EventHandler(this.AgSal_Click);
            // 
            // TxtNom
            // 
            this.TxtNom.AutoSize = true;
            this.TxtNom.BackColor = System.Drawing.Color.Transparent;
            this.TxtNom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtNom.Location = new System.Drawing.Point(32, 103);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(44, 13);
            this.TxtNom.TabIndex = 3;
            this.TxtNom.Text = "Nombre";
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(82, 100);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(342, 20);
            this.Nombre.TabIndex = 4;
            // 
            // BdD
            // 
            this.BdD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BdD.Location = new System.Drawing.Point(12, 229);
            this.BdD.Name = "BdD";
            this.BdD.Size = new System.Drawing.Size(476, 273);
            this.BdD.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Agregar nuevas Salas";
            // 
            // BoSal
            // 
            this.BoSal.Location = new System.Drawing.Point(189, 519);
            this.BoSal.Name = "BoSal";
            this.BoSal.Size = new System.Drawing.Size(106, 23);
            this.BoSal.TabIndex = 7;
            this.BoSal.Text = "Borrar Sala";
            this.BoSal.UseVisualStyleBackColor = true;
            this.BoSal.Click += new System.EventHandler(this.BoSal_Click);
            // 
            // MoSal
            // 
            this.MoSal.Location = new System.Drawing.Point(318, 519);
            this.MoSal.Name = "MoSal";
            this.MoSal.Size = new System.Drawing.Size(106, 23);
            this.MoSal.TabIndex = 8;
            this.MoSal.Text = "Modificar Sala";
            this.MoSal.UseVisualStyleBackColor = true;
            this.MoSal.Click += new System.EventHandler(this.MoSal_Click);
            // 
            // Capacidad
            // 
            this.Capacidad.Location = new System.Drawing.Point(82, 147);
            this.Capacidad.Name = "Capacidad";
            this.Capacidad.Size = new System.Drawing.Size(342, 20);
            this.Capacidad.TabIndex = 10;
            // 
            // TxtCap
            // 
            this.TxtCap.AutoSize = true;
            this.TxtCap.BackColor = System.Drawing.Color.Transparent;
            this.TxtCap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtCap.Location = new System.Drawing.Point(18, 150);
            this.TxtCap.Name = "TxtCap";
            this.TxtCap.Size = new System.Drawing.Size(58, 13);
            this.TxtCap.TabIndex = 9;
            this.TxtCap.Text = "Capacidad";
            // 
            // Descripcion
            // 
            this.Descripcion.Location = new System.Drawing.Point(82, 188);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(342, 20);
            this.Descripcion.TabIndex = 12;
            // 
            // TxtDes
            // 
            this.TxtDes.AutoSize = true;
            this.TxtDes.BackColor = System.Drawing.Color.Transparent;
            this.TxtDes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtDes.Location = new System.Drawing.Point(18, 191);
            this.TxtDes.Name = "TxtDes";
            this.TxtDes.Size = new System.Drawing.Size(63, 13);
            this.TxtDes.TabIndex = 11;
            this.TxtDes.Text = "Descripcion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Vistas.Properties.Resources.depositphotos_353360974_stock_photo_abstract_background_blue_gradient_white;
            this.ClientSize = new System.Drawing.Size(505, 554);
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.TxtDes);
            this.Controls.Add(this.Capacidad);
            this.Controls.Add(this.TxtCap);
            this.Controls.Add(this.MoSal);
            this.Controls.Add(this.BoSal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BdD);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.TxtNom);
            this.Controls.Add(this.AgSal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BdD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AgSal;
        private System.Windows.Forms.Label TxtNom;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.DataGridView BdD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BoSal;
        private System.Windows.Forms.Button MoSal;
        private System.Windows.Forms.TextBox Capacidad;
        private System.Windows.Forms.Label TxtCap;
        private System.Windows.Forms.TextBox Descripcion;
        private System.Windows.Forms.Label TxtDes;
    }
}

