namespace publiRecargas.Campaign
{
    partial class AddVideo
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
            this.inputclientes_id = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gridVideosCliente = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.inputmoviles = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gridVideosCampana = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.inputvideos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inputCantidadMoviles = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.gridVideosCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVideosCampana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputCantidadMoviles)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Clientes:";
            // 
            // inputclientes_id
            // 
            this.inputclientes_id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.inputclientes_id.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.inputclientes_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputclientes_id.DropDownWidth = 400;
            this.inputclientes_id.FormattingEnabled = true;
            this.inputclientes_id.Location = new System.Drawing.Point(120, 53);
            this.inputclientes_id.Name = "inputclientes_id";
            this.inputclientes_id.Size = new System.Drawing.Size(201, 26);
            this.inputclientes_id.TabIndex = 0;
            this.inputclientes_id.SelectedIndexChanged += new System.EventHandler(this.inputclientes_id_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Videos del Cliente Seleccionado:";
            // 
            // gridVideosCliente
            // 
            this.gridVideosCliente.AllowUserToAddRows = false;
            this.gridVideosCliente.AllowUserToDeleteRows = false;
            this.gridVideosCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridVideosCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVideosCliente.Location = new System.Drawing.Point(37, 126);
            this.gridVideosCliente.Name = "gridVideosCliente";
            this.gridVideosCliente.ReadOnly = true;
            this.gridVideosCliente.Size = new System.Drawing.Size(460, 150);
            this.gridVideosCliente.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cantidad de Móviles:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(543, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 80);
            this.button1.TabIndex = 3;
            this.button1.Text = "AGREGAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputmoviles
            // 
            this.inputmoviles.Location = new System.Drawing.Point(223, 298);
            this.inputmoviles.Name = "inputmoviles";
            this.inputmoviles.ReadOnly = true;
            this.inputmoviles.Size = new System.Drawing.Size(127, 27);
            this.inputmoviles.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Móviles Disponibles:";
            // 
            // gridVideosCampana
            // 
            this.gridVideosCampana.AllowUserToAddRows = false;
            this.gridVideosCampana.AllowUserToDeleteRows = false;
            this.gridVideosCampana.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridVideosCampana.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVideosCampana.Location = new System.Drawing.Point(42, 368);
            this.gridVideosCampana.Name = "gridVideosCampana";
            this.gridVideosCampana.ReadOnly = true;
            this.gridVideosCampana.Size = new System.Drawing.Size(460, 169);
            this.gridVideosCampana.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(296, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Videos Agregados a la Campaña:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(543, 391);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 80);
            this.button2.TabIndex = 6;
            this.button2.Text = "BORRAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // inputvideos
            // 
            this.inputvideos.Location = new System.Drawing.Point(297, 549);
            this.inputvideos.Name = "inputvideos";
            this.inputvideos.ReadOnly = true;
            this.inputvideos.Size = new System.Drawing.Size(120, 27);
            this.inputvideos.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 552);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(257, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Total Videos de la Campaña:";
            // 
            // inputCantidadMoviles
            // 
            this.inputCantidadMoviles.Location = new System.Drawing.Point(570, 53);
            this.inputCantidadMoviles.Name = "inputCantidadMoviles";
            this.inputCantidadMoviles.Size = new System.Drawing.Size(126, 27);
            this.inputCantidadMoviles.TabIndex = 1;
            // 
            // AddVideo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(723, 614);
            this.Controls.Add(this.inputCantidadMoviles);
            this.Controls.Add(this.inputvideos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.gridVideosCampana);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.inputmoviles);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gridVideosCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputclientes_id);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AddVideo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddVideo";
            ((System.ComponentModel.ISupportInitialize)(this.gridVideosCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVideosCampana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputCantidadMoviles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox inputclientes_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridVideosCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox inputmoviles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView gridVideosCampana;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox inputvideos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown inputCantidadMoviles;
    }
}