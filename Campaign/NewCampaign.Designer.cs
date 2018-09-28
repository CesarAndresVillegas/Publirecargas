namespace publiRecargas.Campaign
{
    partial class NewCampaign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewCampaign));
            this.inputnombre = new System.Windows.Forms.TextBox();
            this.labelnombre = new System.Windows.Forms.Label();
            this.labelmunicipios_id = new System.Windows.Forms.Label();
            this.labeltipo_dispositivo_id = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aLMACENARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mODIFICARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eLIMINARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nUEVOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputfranquicia_id = new System.Windows.Forms.ComboBox();
            this.inputtipo_dispositivo_id = new System.Windows.Forms.ComboBox();
            this.gridCampanas = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelCampana = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputmes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inputano = new System.Windows.Forms.NumericUpDown();
            this.inputpublicar = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCampanas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputano)).BeginInit();
            this.SuspendLayout();
            // 
            // inputnombre
            // 
            this.inputnombre.Location = new System.Drawing.Point(128, 94);
            this.inputnombre.MaxLength = 45;
            this.inputnombre.Name = "inputnombre";
            this.inputnombre.Size = new System.Drawing.Size(540, 27);
            this.inputnombre.TabIndex = 1;
            // 
            // labelnombre
            // 
            this.labelnombre.AutoSize = true;
            this.labelnombre.Location = new System.Drawing.Point(41, 94);
            this.labelnombre.Name = "labelnombre";
            this.labelnombre.Size = new System.Drawing.Size(84, 18);
            this.labelnombre.TabIndex = 10;
            this.labelnombre.Text = "Nombre:";
            // 
            // labelmunicipios_id
            // 
            this.labelmunicipios_id.AutoSize = true;
            this.labelmunicipios_id.Location = new System.Drawing.Point(41, 55);
            this.labelmunicipios_id.Name = "labelmunicipios_id";
            this.labelmunicipios_id.Size = new System.Drawing.Size(104, 18);
            this.labelmunicipios_id.TabIndex = 9;
            this.labelmunicipios_id.Text = "Franquicia:";
            // 
            // labeltipo_dispositivo_id
            // 
            this.labeltipo_dispositivo_id.AutoSize = true;
            this.labeltipo_dispositivo_id.Location = new System.Drawing.Point(41, 181);
            this.labeltipo_dispositivo_id.Name = "labeltipo_dispositivo_id";
            this.labeltipo_dispositivo_id.Size = new System.Drawing.Size(177, 18);
            this.labeltipo_dispositivo_id.TabIndex = 13;
            this.labeltipo_dispositivo_id.Text = "Tipo de Dispositivo:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aLMACENARToolStripMenuItem,
            this.mODIFICARToolStripMenuItem,
            this.eLIMINARToolStripMenuItem,
            this.nUEVOToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(723, 26);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aLMACENARToolStripMenuItem
            // 
            this.aLMACENARToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aLMACENARToolStripMenuItem.Image")));
            this.aLMACENARToolStripMenuItem.Name = "aLMACENARToolStripMenuItem";
            this.aLMACENARToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.aLMACENARToolStripMenuItem.Text = "ALMACENAR";
            this.aLMACENARToolStripMenuItem.Click += new System.EventHandler(this.aLMACENARToolStripMenuItem_Click);
            // 
            // mODIFICARToolStripMenuItem
            // 
            this.mODIFICARToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mODIFICARToolStripMenuItem.Image")));
            this.mODIFICARToolStripMenuItem.Name = "mODIFICARToolStripMenuItem";
            this.mODIFICARToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.mODIFICARToolStripMenuItem.Text = "MODIFICAR";
            this.mODIFICARToolStripMenuItem.Click += new System.EventHandler(this.mODIFICARToolStripMenuItem_Click);
            // 
            // eLIMINARToolStripMenuItem
            // 
            this.eLIMINARToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eLIMINARToolStripMenuItem.Image")));
            this.eLIMINARToolStripMenuItem.Name = "eLIMINARToolStripMenuItem";
            this.eLIMINARToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.eLIMINARToolStripMenuItem.Text = "ELIMINAR";
            this.eLIMINARToolStripMenuItem.Click += new System.EventHandler(this.eLIMINARToolStripMenuItem_Click);
            // 
            // nUEVOToolStripMenuItem
            // 
            this.nUEVOToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nUEVOToolStripMenuItem.Image")));
            this.nUEVOToolStripMenuItem.Name = "nUEVOToolStripMenuItem";
            this.nUEVOToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.nUEVOToolStripMenuItem.Text = "NUEVO";
            this.nUEVOToolStripMenuItem.Click += new System.EventHandler(this.nUEVOToolStripMenuItem_Click);
            // 
            // inputfranquicia_id
            // 
            this.inputfranquicia_id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.inputfranquicia_id.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.inputfranquicia_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputfranquicia_id.DropDownWidth = 250;
            this.inputfranquicia_id.FormattingEnabled = true;
            this.inputfranquicia_id.Location = new System.Drawing.Point(151, 52);
            this.inputfranquicia_id.Name = "inputfranquicia_id";
            this.inputfranquicia_id.Size = new System.Drawing.Size(518, 26);
            this.inputfranquicia_id.TabIndex = 0;
            this.inputfranquicia_id.SelectedIndexChanged += new System.EventHandler(this.inputfranquicia_id_SelectedIndexChanged);
            // 
            // inputtipo_dispositivo_id
            // 
            this.inputtipo_dispositivo_id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.inputtipo_dispositivo_id.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.inputtipo_dispositivo_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputtipo_dispositivo_id.DropDownWidth = 250;
            this.inputtipo_dispositivo_id.FormattingEnabled = true;
            this.inputtipo_dispositivo_id.Location = new System.Drawing.Point(220, 179);
            this.inputtipo_dispositivo_id.Name = "inputtipo_dispositivo_id";
            this.inputtipo_dispositivo_id.Size = new System.Drawing.Size(233, 26);
            this.inputtipo_dispositivo_id.TabIndex = 4;
            this.inputtipo_dispositivo_id.SelectedIndexChanged += new System.EventHandler(this.inputtipo_dispositivo_id_SelectedIndexChanged);
            // 
            // gridCampanas
            // 
            this.gridCampanas.AllowUserToAddRows = false;
            this.gridCampanas.AllowUserToDeleteRows = false;
            this.gridCampanas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCampanas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCampanas.Location = new System.Drawing.Point(11, 303);
            this.gridCampanas.Name = "gridCampanas";
            this.gridCampanas.ReadOnly = true;
            this.gridCampanas.Size = new System.Drawing.Size(699, 296);
            this.gridCampanas.TabIndex = 6;
            this.gridCampanas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCampanas_CellClick);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(11, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(699, 32);
            this.label3.TabIndex = 14;
            this.label3.Text = "HISTORIAL DE CAMPAÑAS";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(454, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 48);
            this.button1.TabIndex = 7;
            this.button1.Text = "VIDEOS DE LA CAMPAÑA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelCampana
            // 
            this.labelCampana.AutoSize = true;
            this.labelCampana.ForeColor = System.Drawing.Color.Red;
            this.labelCampana.Location = new System.Drawing.Point(649, 4);
            this.labelCampana.Name = "labelCampana";
            this.labelCampana.Size = new System.Drawing.Size(60, 18);
            this.labelCampana.TabIndex = 8;
            this.labelCampana.Text = "label5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mes:";
            // 
            // inputmes
            // 
            this.inputmes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.inputmes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.inputmes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputmes.FormattingEnabled = true;
            this.inputmes.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.inputmes.Location = new System.Drawing.Point(128, 137);
            this.inputmes.Name = "inputmes";
            this.inputmes.Size = new System.Drawing.Size(90, 26);
            this.inputmes.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Año:";
            // 
            // inputano
            // 
            this.inputano.Location = new System.Drawing.Point(334, 137);
            this.inputano.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.inputano.Minimum = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            this.inputano.Name = "inputano";
            this.inputano.Size = new System.Drawing.Size(120, 27);
            this.inputano.TabIndex = 3;
            this.inputano.Value = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            // 
            // inputpublicar
            // 
            this.inputpublicar.AutoSize = true;
            this.inputpublicar.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.inputpublicar.Location = new System.Drawing.Point(44, 221);
            this.inputpublicar.Name = "inputpublicar";
            this.inputpublicar.Size = new System.Drawing.Size(97, 22);
            this.inputpublicar.TabIndex = 15;
            this.inputpublicar.Text = "Publicar";
            this.inputpublicar.UseVisualStyleBackColor = true;
            // 
            // NewCampaign
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(723, 614);
            this.Controls.Add(this.inputpublicar);
            this.Controls.Add(this.inputano);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputmes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelCampana);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gridCampanas);
            this.Controls.Add(this.inputtipo_dispositivo_id);
            this.Controls.Add(this.inputfranquicia_id);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.labelnombre);
            this.Controls.Add(this.inputnombre);
            this.Controls.Add(this.labelmunicipios_id);
            this.Controls.Add(this.labeltipo_dispositivo_id);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "NewCampaign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCampanas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputano)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputnombre;
        private System.Windows.Forms.Label labelnombre;
        private System.Windows.Forms.Label labelmunicipios_id;
        private System.Windows.Forms.Label labeltipo_dispositivo_id;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aLMACENARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mODIFICARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eLIMINARToolStripMenuItem;
        private System.Windows.Forms.ComboBox inputfranquicia_id;
        private System.Windows.Forms.ComboBox inputtipo_dispositivo_id;
        private System.Windows.Forms.DataGridView gridCampanas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelCampana;
        private System.Windows.Forms.ToolStripMenuItem nUEVOToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox inputmes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown inputano;
        private System.Windows.Forms.CheckBox inputpublicar;
    }
}