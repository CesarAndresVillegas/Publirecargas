namespace publiRecargas.Configuration
{
    partial class Videos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Videos));
            this.inputnombre = new System.Windows.Forms.TextBox();
            this.labelnombre = new System.Windows.Forms.Label();
            this.labelclientes_id = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aLMACENARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eLIMINARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.inputclientes_id = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gridVideos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.inputfranquicia_id = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVideos)).BeginInit();
            this.SuspendLayout();
            // 
            // inputnombre
            // 
            this.inputnombre.Location = new System.Drawing.Point(245, 165);
            this.inputnombre.Name = "inputnombre";
            this.inputnombre.Size = new System.Drawing.Size(384, 27);
            this.inputnombre.TabIndex = 0;
            // 
            // labelnombre
            // 
            this.labelnombre.AutoSize = true;
            this.labelnombre.Location = new System.Drawing.Point(53, 165);
            this.labelnombre.Name = "labelnombre";
            this.labelnombre.Size = new System.Drawing.Size(187, 18);
            this.labelnombre.TabIndex = 5;
            this.labelnombre.Text = "Seleccione un Video:";
            // 
            // labelclientes_id
            // 
            this.labelclientes_id.AutoSize = true;
            this.labelclientes_id.Location = new System.Drawing.Point(76, 112);
            this.labelclientes_id.Name = "labelclientes_id";
            this.labelclientes_id.Size = new System.Drawing.Size(74, 18);
            this.labelclientes_id.TabIndex = 6;
            this.labelclientes_id.Text = "Cliente:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aLMACENARToolStripMenuItem,
            this.eLIMINARToolStripMenuItem,
            this.nuevo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(723, 26);
            this.menuStrip1.TabIndex = 3;
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
            // eLIMINARToolStripMenuItem
            // 
            this.eLIMINARToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eLIMINARToolStripMenuItem.Image")));
            this.eLIMINARToolStripMenuItem.Name = "eLIMINARToolStripMenuItem";
            this.eLIMINARToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.eLIMINARToolStripMenuItem.Text = "ELIMINAR";
            this.eLIMINARToolStripMenuItem.Click += new System.EventHandler(this.eLIMINARToolStripMenuItem_Click);
            // 
            // nuevo
            // 
            this.nuevo.Image = ((System.Drawing.Image)(resources.GetObject("nuevo.Image")));
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(99, 22);
            this.nuevo.Text = "NUEVO";
            this.nuevo.Click += new System.EventHandler(this.nuevo_Click);
            // 
            // inputclientes_id
            // 
            this.inputclientes_id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.inputclientes_id.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.inputclientes_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputclientes_id.DropDownWidth = 400;
            this.inputclientes_id.FormattingEnabled = true;
            this.inputclientes_id.Location = new System.Drawing.Point(156, 111);
            this.inputclientes_id.Name = "inputclientes_id";
            this.inputclientes_id.Size = new System.Drawing.Size(287, 26);
            this.inputclientes_id.TabIndex = 2;
            this.inputclientes_id.SelectedIndexChanged += new System.EventHandler(this.inputclientes_id_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(635, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 29);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gridVideos
            // 
            this.gridVideos.AllowUserToAddRows = false;
            this.gridVideos.AllowUserToDeleteRows = false;
            this.gridVideos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridVideos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVideos.Location = new System.Drawing.Point(51, 244);
            this.gridVideos.Name = "gridVideos";
            this.gridVideos.ReadOnly = true;
            this.gridVideos.Size = new System.Drawing.Size(623, 331);
            this.gridVideos.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(51, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(623, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Listado de Videos Almacenados";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // inputfranquicia_id
            // 
            this.inputfranquicia_id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.inputfranquicia_id.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.inputfranquicia_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputfranquicia_id.FormattingEnabled = true;
            this.inputfranquicia_id.Location = new System.Drawing.Point(156, 59);
            this.inputfranquicia_id.Name = "inputfranquicia_id";
            this.inputfranquicia_id.Size = new System.Drawing.Size(473, 26);
            this.inputfranquicia_id.TabIndex = 10;
            this.inputfranquicia_id.SelectedIndexChanged += new System.EventHandler(this.inputfranquicia_id_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Franquicia:";
            // 
            // Videos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(723, 614);
            this.Controls.Add(this.inputfranquicia_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridVideos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputclientes_id);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.labelnombre);
            this.Controls.Add(this.inputnombre);
            this.Controls.Add(this.labelclientes_id);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Videos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONFIGURACIÓN DE VIDEOS";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVideos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputnombre;
        private System.Windows.Forms.Label labelnombre;
        private System.Windows.Forms.Label labelclientes_id;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aLMACENARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eLIMINARToolStripMenuItem;
        private System.Windows.Forms.ComboBox inputclientes_id;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView gridVideos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem nuevo;
        private System.Windows.Forms.ComboBox inputfranquicia_id;
        private System.Windows.Forms.Label label3;
    }
}