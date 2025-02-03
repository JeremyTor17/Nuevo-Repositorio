namespace Reservas
{
    partial class Reservas
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
            this.ID_Sala = new System.Windows.Forms.TextBox();
            this.AgRetxt = new System.Windows.Forms.Label();
            this.ReActxt = new System.Windows.Forms.Label();
            this.BdD = new System.Windows.Forms.DataGridView();
            this.IDtxt = new System.Windows.Forms.Label();
            this.NCltxt = new System.Windows.Forms.Label();
            this.Cliente = new System.Windows.Forms.TextBox();
            this.FECHAtxt = new System.Windows.Forms.Label();
            this.Fecha_Inicio = new System.Windows.Forms.TextBox();
            this.FECHAFtxt = new System.Windows.Forms.Label();
            this.Fecha_Fin = new System.Windows.Forms.TextBox();
            this.MotRtxt = new System.Windows.Forms.Label();
            this.Motivo = new System.Windows.Forms.TextBox();
            this.MoSal = new System.Windows.Forms.Button();
            this.BoSal = new System.Windows.Forms.Button();
            this.AgSal = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BdD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ID_Sala
            // 
            this.ID_Sala.Location = new System.Drawing.Point(150, 62);
            this.ID_Sala.Name = "ID_Sala";
            this.ID_Sala.Size = new System.Drawing.Size(506, 20);
            this.ID_Sala.TabIndex = 0;
            // 
            // AgRetxt
            // 
            this.AgRetxt.AutoSize = true;
            this.AgRetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgRetxt.Location = new System.Drawing.Point(6, 9);
            this.AgRetxt.Name = "AgRetxt";
            this.AgRetxt.Size = new System.Drawing.Size(234, 31);
            this.AgRetxt.TabIndex = 1;
            this.AgRetxt.Text = "Agregar Reserva";
            // 
            // ReActxt
            // 
            this.ReActxt.AutoSize = true;
            this.ReActxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReActxt.Location = new System.Drawing.Point(6, 307);
            this.ReActxt.Name = "ReActxt";
            this.ReActxt.Size = new System.Drawing.Size(251, 31);
            this.ReActxt.TabIndex = 2;
            this.ReActxt.Text = "Reservas Activas:";
            // 
            // BdD
            // 
            this.BdD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BdD.Location = new System.Drawing.Point(12, 355);
            this.BdD.Name = "BdD";
            this.BdD.Size = new System.Drawing.Size(644, 203);
            this.BdD.TabIndex = 3;
            this.BdD.SelectionChanged += new System.EventHandler(this.BdD_SelectionChanged);
            // 
            // IDtxt
            // 
            this.IDtxt.AutoSize = true;
            this.IDtxt.BackColor = System.Drawing.Color.Transparent;
            this.IDtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDtxt.ForeColor = System.Drawing.SystemColors.Control;
            this.IDtxt.Location = new System.Drawing.Point(52, 65);
            this.IDtxt.Name = "IDtxt";
            this.IDtxt.Size = new System.Drawing.Size(85, 13);
            this.IDtxt.TabIndex = 4;
            this.IDtxt.Text = "ID de la Sala:";
            // 
            // NCltxt
            // 
            this.NCltxt.AutoSize = true;
            this.NCltxt.BackColor = System.Drawing.Color.Transparent;
            this.NCltxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NCltxt.ForeColor = System.Drawing.SystemColors.Control;
            this.NCltxt.Location = new System.Drawing.Point(41, 103);
            this.NCltxt.Name = "NCltxt";
            this.NCltxt.Size = new System.Drawing.Size(97, 13);
            this.NCltxt.TabIndex = 6;
            this.NCltxt.Text = "Nombre Cliente:";
            // 
            // Cliente
            // 
            this.Cliente.Location = new System.Drawing.Point(150, 100);
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(506, 20);
            this.Cliente.TabIndex = 5;
            // 
            // FECHAtxt
            // 
            this.FECHAtxt.AutoSize = true;
            this.FECHAtxt.BackColor = System.Drawing.Color.Transparent;
            this.FECHAtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FECHAtxt.ForeColor = System.Drawing.SystemColors.Control;
            this.FECHAtxt.Location = new System.Drawing.Point(40, 147);
            this.FECHAtxt.Name = "FECHAtxt";
            this.FECHAtxt.Size = new System.Drawing.Size(99, 13);
            this.FECHAtxt.TabIndex = 8;
            this.FECHAtxt.Text = "Fecha de Inicio:";
            // 
            // Fecha_Inicio
            // 
            this.Fecha_Inicio.Location = new System.Drawing.Point(150, 144);
            this.Fecha_Inicio.Name = "Fecha_Inicio";
            this.Fecha_Inicio.Size = new System.Drawing.Size(506, 20);
            this.Fecha_Inicio.TabIndex = 7;
            // 
            // FECHAFtxt
            // 
            this.FECHAFtxt.AutoSize = true;
            this.FECHAFtxt.BackColor = System.Drawing.Color.Transparent;
            this.FECHAFtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FECHAFtxt.ForeColor = System.Drawing.SystemColors.Control;
            this.FECHAFtxt.Location = new System.Drawing.Point(51, 191);
            this.FECHAFtxt.Name = "FECHAFtxt";
            this.FECHAFtxt.Size = new System.Drawing.Size(85, 13);
            this.FECHAFtxt.TabIndex = 10;
            this.FECHAFtxt.Text = "Fecha de Fin:";
            // 
            // Fecha_Fin
            // 
            this.Fecha_Fin.Location = new System.Drawing.Point(150, 188);
            this.Fecha_Fin.Name = "Fecha_Fin";
            this.Fecha_Fin.Size = new System.Drawing.Size(506, 20);
            this.Fecha_Fin.TabIndex = 9;
            // 
            // MotRtxt
            // 
            this.MotRtxt.AutoSize = true;
            this.MotRtxt.BackColor = System.Drawing.Color.Transparent;
            this.MotRtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MotRtxt.ForeColor = System.Drawing.SystemColors.Control;
            this.MotRtxt.Location = new System.Drawing.Point(12, 236);
            this.MotRtxt.Name = "MotRtxt";
            this.MotRtxt.Size = new System.Drawing.Size(132, 13);
            this.MotRtxt.TabIndex = 12;
            this.MotRtxt.Text = "Motivo de la Reserva:";
            // 
            // Motivo
            // 
            this.Motivo.Location = new System.Drawing.Point(150, 233);
            this.Motivo.Name = "Motivo";
            this.Motivo.Size = new System.Drawing.Size(506, 20);
            this.Motivo.TabIndex = 11;
            // 
            // MoSal
            // 
            this.MoSal.Location = new System.Drawing.Point(423, 275);
            this.MoSal.Name = "MoSal";
            this.MoSal.Size = new System.Drawing.Size(106, 23);
            this.MoSal.TabIndex = 15;
            this.MoSal.Text = "Modificar Reserva";
            this.MoSal.UseVisualStyleBackColor = true;
            this.MoSal.Click += new System.EventHandler(this.MoSal_Click);
            // 
            // BoSal
            // 
            this.BoSal.Location = new System.Drawing.Point(294, 275);
            this.BoSal.Name = "BoSal";
            this.BoSal.Size = new System.Drawing.Size(106, 23);
            this.BoSal.TabIndex = 14;
            this.BoSal.Text = "Borrar Reserva";
            this.BoSal.UseVisualStyleBackColor = true;
            this.BoSal.Click += new System.EventHandler(this.BoSal_Click);
            // 
            // AgSal
            // 
            this.AgSal.Location = new System.Drawing.Point(164, 275);
            this.AgSal.Name = "AgSal";
            this.AgSal.Size = new System.Drawing.Size(106, 23);
            this.AgSal.TabIndex = 13;
            this.AgSal.Text = "Agregar Reserva";
            this.AgSal.UseVisualStyleBackColor = true;
            this.AgSal.Click += new System.EventHandler(this.AgSal_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = global::Reservas.Properties.Resources.Yes;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(606, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 42);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Reservas.Properties.Resources.depositphotos_353360974_stock_photo_abstract_background_blue_gradient_white;
            this.ClientSize = new System.Drawing.Size(668, 570);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MoSal);
            this.Controls.Add(this.BoSal);
            this.Controls.Add(this.AgSal);
            this.Controls.Add(this.MotRtxt);
            this.Controls.Add(this.Motivo);
            this.Controls.Add(this.FECHAFtxt);
            this.Controls.Add(this.Fecha_Fin);
            this.Controls.Add(this.FECHAtxt);
            this.Controls.Add(this.Fecha_Inicio);
            this.Controls.Add(this.NCltxt);
            this.Controls.Add(this.Cliente);
            this.Controls.Add(this.IDtxt);
            this.Controls.Add(this.BdD);
            this.Controls.Add(this.ReActxt);
            this.Controls.Add(this.AgRetxt);
            this.Controls.Add(this.ID_Sala);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BdD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ID_Sala;
        private System.Windows.Forms.Label AgRetxt;
        private System.Windows.Forms.Label ReActxt;
        private System.Windows.Forms.DataGridView BdD;
        private System.Windows.Forms.Label IDtxt;
        private System.Windows.Forms.Label NCltxt;
        private System.Windows.Forms.TextBox Cliente;
        private System.Windows.Forms.Label FECHAtxt;
        private System.Windows.Forms.TextBox Fecha_Inicio;
        private System.Windows.Forms.Label FECHAFtxt;
        private System.Windows.Forms.TextBox Fecha_Fin;
        private System.Windows.Forms.Label MotRtxt;
        private System.Windows.Forms.TextBox Motivo;
        private System.Windows.Forms.Button MoSal;
        private System.Windows.Forms.Button BoSal;
        private System.Windows.Forms.Button AgSal;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

