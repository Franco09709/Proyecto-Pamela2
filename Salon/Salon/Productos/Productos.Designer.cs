namespace Salon.Clientes
{
    partial class Productos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.drakeUIGradientPanel1 = new DrakeUI.Framework.DrakeUIGradientPanel();
            this.drakeUITextBox2 = new DrakeUI.Framework.DrakeUITextBox();
            this.DgvDatosProductos = new DrakeUI.Framework.DrakeUIDataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Closemenu = new System.Windows.Forms.PictureBox();
            this.btnAgregclient = new System.Windows.Forms.Button();
            this.drakeUIGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatosProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Closemenu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(-6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(979, 1);
            this.label1.TabIndex = 220;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(29, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 219;
            this.label2.Text = "Productos";
            // 
            // drakeUIGradientPanel1
            // 
            this.drakeUIGradientPanel1.Controls.Add(this.drakeUITextBox2);
            this.drakeUIGradientPanel1.Controls.Add(this.Closemenu);
            this.drakeUIGradientPanel1.FillColor = System.Drawing.Color.White;
            this.drakeUIGradientPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.drakeUIGradientPanel1.Location = new System.Drawing.Point(23, 155);
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
            this.drakeUITextBox2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.drakeUITextBox2.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.drakeUITextBox2.Size = new System.Drawing.Size(225, 27);
            this.drakeUITextBox2.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUITextBox2.TabIndex = 0;
            // 
            // DgvDatosProductos
            // 
            this.DgvDatosProductos.AllowUserToAddRows = false;
            this.DgvDatosProductos.AllowUserToDeleteRows = false;
            this.DgvDatosProductos.AllowUserToResizeColumns = false;
            this.DgvDatosProductos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DgvDatosProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvDatosProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvDatosProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DgvDatosProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DgvDatosProductos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DgvDatosProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvDatosProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.DgvDatosProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDatosProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvDatosProductos.ColumnHeadersHeight = 32;
            this.DgvDatosProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvDatosProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NombreProducto,
            this.Precio,
            this.Proveedor,
            this.Estado,
            this.FechaIngreso});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvDatosProductos.DefaultCellStyle = dataGridViewCellStyle4;
            this.DgvDatosProductos.EnableHeadersVisualStyles = false;
            this.DgvDatosProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DgvDatosProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.DgvDatosProductos.Location = new System.Drawing.Point(23, 204);
            this.DgvDatosProductos.Name = "DgvDatosProductos";
            this.DgvDatosProductos.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvDatosProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDatosProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DgvDatosProductos.RowHeadersVisible = false;
            this.DgvDatosProductos.RowHeadersWidth = 25;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvDatosProductos.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DgvDatosProductos.RowTemplate.Height = 29;
            this.DgvDatosProductos.SelectedIndex = -1;
            this.DgvDatosProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvDatosProductos.ShowRect = false;
            this.DgvDatosProductos.Size = new System.Drawing.Size(916, 339);
            this.DgvDatosProductos.StripeOddColor = System.Drawing.Color.White;
            this.DgvDatosProductos.Style = DrakeUI.Framework.UIStyle.Custom;
            this.DgvDatosProductos.StyleCustomMode = true;
            this.DgvDatosProductos.TabIndex = 235;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 95;
            // 
            // NombreProducto
            // 
            this.NombreProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NombreProducto.DataPropertyName = "NombreProducto";
            this.NombreProducto.HeaderText = "Nombre";
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.Width = 260;
            // 
            // Precio
            // 
            this.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.Width = 130;
            // 
            // Proveedor
            // 
            this.Proveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Proveedor.DataPropertyName = "Proveedor";
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.Width = 189;
            // 
            // Estado
            // 
            this.Estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Estado.DataPropertyName = "Estado";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estado.DefaultCellStyle = dataGridViewCellStyle3;
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // FechaIngreso
            // 
            this.FechaIngreso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FechaIngreso.DataPropertyName = "FechaIngreso";
            this.FechaIngreso.HeaderText = "Fecha Ingreso";
            this.FechaIngreso.Name = "FechaIngreso";
            this.FechaIngreso.Width = 145;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Salon.Properties.Resources.productonegro;
            this.pictureBox1.Location = new System.Drawing.Point(6, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 234;
            this.pictureBox1.TabStop = false;
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
            // btnAgregclient
            // 
            this.btnAgregclient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregclient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(160)))), ((int)(((byte)(190)))));
            this.btnAgregclient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregclient.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregclient.ForeColor = System.Drawing.Color.White;
            this.btnAgregclient.Image = global::Salon.Properties.Resources.icons8_más_2_matemáticas_23;
            this.btnAgregclient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregclient.Location = new System.Drawing.Point(867, 155);
            this.btnAgregclient.Name = "btnAgregclient";
            this.btnAgregclient.Size = new System.Drawing.Size(83, 32);
            this.btnAgregclient.TabIndex = 58;
            this.btnAgregclient.Text = "      Nuevo";
            this.btnAgregclient.UseVisualStyleBackColor = false;
            this.btnAgregclient.Click += new System.EventHandler(this.btnAgregclient_Click);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 584);
            this.Controls.Add(this.DgvDatosProductos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.drakeUIGradientPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAgregclient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Productos";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Productos_Load);
            this.drakeUIGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatosProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Closemenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAgregclient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DrakeUI.Framework.DrakeUIGradientPanel drakeUIGradientPanel1;
        private DrakeUI.Framework.DrakeUITextBox drakeUITextBox2;
        private System.Windows.Forms.PictureBox Closemenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DrakeUI.Framework.DrakeUIDataGridView DgvDatosProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIngreso;
    }
}