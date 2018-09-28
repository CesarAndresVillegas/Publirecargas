namespace publiRecargas.Reports
{
    partial class VideosDevices
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
            this.gridCampanas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.inputTipoCampana = new System.Windows.Forms.ComboBox();
            this.gridCantidadVideos = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.gridCantidadReproducciones = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.inputfranquicia = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.inputcantidad_dispositivos = new System.Windows.Forms.TextBox();
            this.inputcantidad_videos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridCampanas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCantidadVideos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCantidadReproducciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(29, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(663, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "HISTORIAL DE CAMPAÑAS CREADAS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridCampanas
            // 
            this.gridCampanas.AllowUserToAddRows = false;
            this.gridCampanas.AllowUserToDeleteRows = false;
            this.gridCampanas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCampanas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCampanas.Location = new System.Drawing.Point(29, 135);
            this.gridCampanas.Name = "gridCampanas";
            this.gridCampanas.ReadOnly = true;
            this.gridCampanas.Size = new System.Drawing.Size(663, 175);
            this.gridCampanas.TabIndex = 1;
            this.gridCampanas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCampanas_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo de Campaña:";
            // 
            // inputTipoCampana
            // 
            this.inputTipoCampana.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.inputTipoCampana.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.inputTipoCampana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputTipoCampana.DropDownWidth = 300;
            this.inputTipoCampana.FormattingEnabled = true;
            this.inputTipoCampana.Location = new System.Drawing.Point(488, 25);
            this.inputTipoCampana.Name = "inputTipoCampana";
            this.inputTipoCampana.Size = new System.Drawing.Size(174, 26);
            this.inputTipoCampana.TabIndex = 3;
            // 
            // gridCantidadVideos
            // 
            this.gridCantidadVideos.AllowUserToAddRows = false;
            this.gridCantidadVideos.AllowUserToDeleteRows = false;
            this.gridCantidadVideos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCantidadVideos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCantidadVideos.Location = new System.Drawing.Point(25, 362);
            this.gridCantidadVideos.Name = "gridCantidadVideos";
            this.gridCantidadVideos.ReadOnly = true;
            this.gridCantidadVideos.Size = new System.Drawing.Size(332, 194);
            this.gridCantidadVideos.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(25, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(332, 49);
            this.label3.TabIndex = 4;
            this.label3.Text = "CANTIDAD DE VIDEOS POR DISPOSITIVO";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridCantidadReproducciones
            // 
            this.gridCantidadReproducciones.AllowUserToAddRows = false;
            this.gridCantidadReproducciones.AllowUserToDeleteRows = false;
            this.gridCantidadReproducciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCantidadReproducciones.Location = new System.Drawing.Point(363, 362);
            this.gridCantidadReproducciones.Name = "gridCantidadReproducciones";
            this.gridCantidadReproducciones.ReadOnly = true;
            this.gridCantidadReproducciones.Size = new System.Drawing.Size(332, 194);
            this.gridCantidadReproducciones.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(363, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(332, 49);
            this.label4.TabIndex = 6;
            this.label4.Text = "CANTIDAD DE REPRODUCCIONES POR DISPOSITIVO";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputfranquicia
            // 
            this.inputfranquicia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.inputfranquicia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.inputfranquicia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputfranquicia.DropDownWidth = 300;
            this.inputfranquicia.FormattingEnabled = true;
            this.inputfranquicia.Location = new System.Drawing.Point(135, 25);
            this.inputfranquicia.Name = "inputfranquicia";
            this.inputfranquicia.Size = new System.Drawing.Size(174, 26);
            this.inputfranquicia.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Franquicia:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(527, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 37);
            this.button1.TabIndex = 10;
            this.button1.Text = "BUSCAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 614);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cantidad de Dispositivos:";
            // 
            // inputcantidad_dispositivos
            // 
            this.inputcantidad_dispositivos.Location = new System.Drawing.Point(251, 611);
            this.inputcantidad_dispositivos.Name = "inputcantidad_dispositivos";
            this.inputcantidad_dispositivos.Size = new System.Drawing.Size(105, 27);
            this.inputcantidad_dispositivos.TabIndex = 12;
            // 
            // inputcantidad_videos
            // 
            this.inputcantidad_videos.Location = new System.Drawing.Point(251, 578);
            this.inputcantidad_videos.Name = "inputcantidad_videos";
            this.inputcantidad_videos.Size = new System.Drawing.Size(105, 27);
            this.inputcantidad_videos.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 581);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Cantidad de Videos:";
            // 
            // VideosDevices
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(723, 646);
            this.Controls.Add(this.inputcantidad_videos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.inputcantidad_dispositivos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputfranquicia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gridCantidadReproducciones);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gridCantidadVideos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputTipoCampana);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridCampanas);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "VideosDevices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CANTIDAD DE VIDEOS POR DISPOSITIVO";
            ((System.ComponentModel.ISupportInitialize)(this.gridCampanas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCantidadVideos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCantidadReproducciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridCampanas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox inputTipoCampana;
        private System.Windows.Forms.DataGridView gridCantidadVideos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gridCantidadReproducciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox inputfranquicia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox inputcantidad_dispositivos;
        private System.Windows.Forms.TextBox inputcantidad_videos;
        private System.Windows.Forms.Label label7;
    }
}