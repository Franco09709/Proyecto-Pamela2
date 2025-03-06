﻿namespace Salon.Servicios
{
    partial class Servicio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.DgvDatosServicios = new DrakeUI.Framework.DrakeUIDataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.drakeUIGradientPanel1 = new DrakeUI.Framework.DrakeUIGradientPanel();
            this.drakeUITextBox2 = new DrakeUI.Framework.DrakeUITextBox();
            this.Closemenu = new System.Windows.Forms.PictureBox();
            this.btnAgregaremp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatosServicios)).BeginInit();
            this.drakeUIGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Closemenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(34, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 224;
            this.label2.Text = "Servicios";
            // 
            // DgvDatosServicios
            // 
            this.DgvDatosServicios.AllowUserToAddRows = false;
            this.DgvDatosServicios.AllowUserToDeleteRows = false;
            this.DgvDatosServicios.AllowUserToResizeColumns = false;
            this.DgvDatosServicios.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DgvDatosServicios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvDatosServicios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvDatosServicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DgvDatosServicios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DgvDatosServicios.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DgvDatosServicios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvDatosServicios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.DgvDatosServicios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDatosServicios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvDatosServicios.ColumnHeadersHeight = 32;
            this.DgvDatosServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvDatosServicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.ID_Empleado,
            this.Nombre,
            this.Precio,
            this.Estado});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvDatosServicios.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvDatosServicios.EnableHeadersVisualStyles = false;
            this.DgvDatosServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DgvDatosServicios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.DgvDatosServicios.Location = new System.Drawing.Point(19, 225);
            this.DgvDatosServicios.Name = "DgvDatosServicios";
            this.DgvDatosServicios.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvDatosServicios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDatosServicios.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvDatosServicios.RowHeadersVisible = false;
            this.DgvDatosServicios.RowHeadersWidth = 25;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvDatosServicios.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DgvDatosServicios.RowTemplate.Height = 29;
            this.DgvDatosServicios.SelectedIndex = -1;
            this.DgvDatosServicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvDatosServicios.ShowRect = false;
            this.DgvDatosServicios.Size = new System.Drawing.Size(902, 285);
            this.DgvDatosServicios.StripeOddColor = System.Drawing.Color.White;
            this.DgvDatosServicios.Style = DrakeUI.Framework.UIStyle.Custom;
            this.DgvDatosServicios.StyleCustomMode = true;
            this.DgvDatosServicios.TabIndex = 228;
            // 
            // Editar
            // 
            this.Editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Editar.Frozen = true;
            this.Editar.HeaderText = "";
            this.Editar.Name = "Editar";
            this.Editar.Width = 55;
            // 
            // ID_Empleado
            // 
            this.ID_Empleado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID_Empleado.DataPropertyName = "ID_Empleado";
            this.ID_Empleado.Frozen = true;
            this.ID_Empleado.HeaderText = "ID";
            this.ID_Empleado.Name = "ID_Empleado";
            this.ID_Empleado.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.Frozen = true;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 300;
            // 
            // Precio
            // 
            this.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.Width = 300;
            // 
            // Estado
            // 
            this.Estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.Width = 195;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(-52, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1003, 1);
            this.label1.TabIndex = 230;
            this.label1.Text = "label1";
            // 
            // drakeUIGradientPanel1
            // 
            this.drakeUIGradientPanel1.Controls.Add(this.drakeUITextBox2);
            this.drakeUIGradientPanel1.Controls.Add(this.Closemenu);
            this.drakeUIGradientPanel1.FillColor = System.Drawing.Color.White;
            this.drakeUIGradientPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.drakeUIGradientPanel1.Location = new System.Drawing.Point(19, 173);
            this.drakeUIGradientPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drakeUIGradientPanel1.Name = "drakeUIGradientPanel1";
            this.drakeUIGradientPanel1.RectColor = System.Drawing.Color.Silver;
            this.drakeUIGradientPanel1.RectDisableColor = System.Drawing.Color.White;
            this.drakeUIGradientPanel1.Size = new System.Drawing.Size(275, 32);
            this.drakeUIGradientPanel1.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUIGradientPanel1.TabIndex = 233;
            this.drakeUIGradientPanel1.Text = null;
            // 
            // drakeUITextBox2
            // 
            this.drakeUITextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.drakeUITextBox2.FillColor = System.Drawing.Color.White;
            this.drakeUITextBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drakeUITextBox2.Location = new System.Drawing.Point(46, 3);
            this.drakeUITextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drakeUITextBox2.Maximum = 2147483647D;
            this.drakeUITextBox2.Minimum = -2147483648D;
            this.drakeUITextBox2.Name = "drakeUITextBox2";
            this.drakeUITextBox2.Padding = new System.Windows.Forms.Padding(5);
            this.drakeUITextBox2.RectColor = System.Drawing.Color.White;
            this.drakeUITextBox2.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.drakeUITextBox2.Size = new System.Drawing.Size(225, 27);
            this.drakeUITextBox2.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUITextBox2.TabIndex = 0;
            // 
            // Closemenu
            // 
            this.Closemenu.BackColor = System.Drawing.Color.White;
            this.Closemenu.Image = global::Salon.Properties.Resources.icons8_búsqueda_22;
            this.Closemenu.Location = new System.Drawing.Point(17, 1);
            this.Closemenu.Name = "Closemenu";
            this.Closemenu.Size = new System.Drawing.Size(26, 30);
            this.Closemenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Closemenu.TabIndex = 225;
            this.Closemenu.TabStop = false;
            // 
            // btnAgregaremp
            // 
            this.btnAgregaremp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregaremp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(160)))), ((int)(((byte)(190)))));
            this.btnAgregaremp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregaremp.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregaremp.ForeColor = System.Drawing.Color.White;
            this.btnAgregaremp.Image = global::Salon.Properties.Resources.icons8_más_2_matemáticas_23;
            this.btnAgregaremp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregaremp.Location = new System.Drawing.Point(832, 174);
            this.btnAgregaremp.Name = "btnAgregaremp";
            this.btnAgregaremp.Size = new System.Drawing.Size(83, 32);
            this.btnAgregaremp.TabIndex = 227;
            this.btnAgregaremp.Text = "      Nuevo";
            this.btnAgregaremp.UseVisualStyleBackColor = false;
            this.btnAgregaremp.Click += new System.EventHandler(this.btnAgregaremp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Salon.Properties.Resources.icons8_maletín_22;
            this.pictureBox1.Location = new System.Drawing.Point(8, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 25);
            this.pictureBox1.TabIndex = 223;
            this.pictureBox1.TabStop = false;
            // 
            // Servicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 545);
            this.Controls.Add(this.drakeUIGradientPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvDatosServicios);
            this.Controls.Add(this.btnAgregaremp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Servicio";
            this.Text = "Servicio";
            this.Load += new System.EventHandler(this.Servicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatosServicios)).EndInit();
            this.drakeUIGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Closemenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregaremp;
        private DrakeUI.Framework.DrakeUIDataGridView DgvDatosServicios;
        private System.Windows.Forms.Label label1;
        private DrakeUI.Framework.DrakeUIGradientPanel drakeUIGradientPanel1;
        private DrakeUI.Framework.DrakeUITextBox drakeUITextBox2;
        private System.Windows.Forms.PictureBox Closemenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Editar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}