namespace publiRecargas.Configuration
{
    partial class Device
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Device));
            this.inputnombre = new System.Windows.Forms.TextBox();
            this.labelnombre = new System.Windows.Forms.Label();
            this.inputdocumento = new System.Windows.Forms.TextBox();
            this.labeldocumento = new System.Windows.Forms.Label();
            this.labelfecha_soat = new System.Windows.Forms.Label();
            this.labelfecha_tecnomecanica = new System.Windows.Forms.Label();
            this.inputnumero_vehiculo = new System.Windows.Forms.TextBox();
            this.labelnumero_vehiculo = new System.Windows.Forms.Label();
            this.inputplaca = new System.Windows.Forms.TextBox();
            this.labelplaca = new System.Windows.Forms.Label();
            this.inputdireccion = new System.Windows.Forms.TextBox();
            this.labeldireccion = new System.Windows.Forms.Label();
            this.inputtelefono = new System.Windows.Forms.TextBox();
            this.labeltelefono = new System.Windows.Forms.Label();
            this.inputdispositivo_id = new System.Windows.Forms.TextBox();
            this.labeldispositivo_id = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aLMACENARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mODIFICARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eLIMINARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.labeltipo_dispositivo_id = new System.Windows.Forms.Label();
            this.inputtipo_dispositivo_id = new System.Windows.Forms.ComboBox();
            this.inputfecha_soat = new System.Windows.Forms.DateTimePicker();
            this.inputfecha_tecnomecanica = new System.Windows.Forms.DateTimePicker();
            this.gridDevices = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.inputactivo = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.inputfranquicia_id = new System.Windows.Forms.ComboBox();
            this.labelmunicipios_id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDevices)).BeginInit();
            this.SuspendLayout();
            // 
            // inputnombre
            // 
            this.inputnombre.Location = new System.Drawing.Point(113, 94);
            this.inputnombre.MaxLength = 100;
            this.inputnombre.Name = "inputnombre";
            this.inputnombre.Size = new System.Drawing.Size(260, 27);
            this.inputnombre.TabIndex = 1;
            // 
            // labelnombre
            // 
            this.labelnombre.AutoSize = true;
            this.labelnombre.Location = new System.Drawing.Point(28, 94);
            this.labelnombre.Name = "labelnombre";
            this.labelnombre.Size = new System.Drawing.Size(84, 18);
            this.labelnombre.TabIndex = 18;
            this.labelnombre.Text = "Nombre:";
            // 
            // inputdocumento
            // 
            this.inputdocumento.Location = new System.Drawing.Point(504, 94);
            this.inputdocumento.MaxLength = 20;
            this.inputdocumento.Name = "inputdocumento";
            this.inputdocumento.Size = new System.Drawing.Size(190, 27);
            this.inputdocumento.TabIndex = 2;
            // 
            // labeldocumento
            // 
            this.labeldocumento.AutoSize = true;
            this.labeldocumento.Location = new System.Drawing.Point(389, 94);
            this.labeldocumento.Name = "labeldocumento";
            this.labeldocumento.Size = new System.Drawing.Size(114, 18);
            this.labeldocumento.TabIndex = 19;
            this.labeldocumento.Text = "Documento:";
            // 
            // labelfecha_soat
            // 
            this.labelfecha_soat.AutoSize = true;
            this.labelfecha_soat.Location = new System.Drawing.Point(28, 181);
            this.labelfecha_soat.Name = "labelfecha_soat";
            this.labelfecha_soat.Size = new System.Drawing.Size(111, 18);
            this.labelfecha_soat.TabIndex = 21;
            this.labelfecha_soat.Text = "Fecha Soat:";
            // 
            // labelfecha_tecnomecanica
            // 
            this.labelfecha_tecnomecanica.AutoSize = true;
            this.labelfecha_tecnomecanica.Location = new System.Drawing.Point(389, 181);
            this.labelfecha_tecnomecanica.Name = "labelfecha_tecnomecanica";
            this.labelfecha_tecnomecanica.Size = new System.Drawing.Size(131, 18);
            this.labelfecha_tecnomecanica.TabIndex = 22;
            this.labelfecha_tecnomecanica.Text = "Fecha Tecno.:";
            // 
            // inputnumero_vehiculo
            // 
            this.inputnumero_vehiculo.Location = new System.Drawing.Point(222, 224);
            this.inputnumero_vehiculo.MaxLength = 10;
            this.inputnumero_vehiculo.Name = "inputnumero_vehiculo";
            this.inputnumero_vehiculo.Size = new System.Drawing.Size(151, 27);
            this.inputnumero_vehiculo.TabIndex = 7;
            // 
            // labelnumero_vehiculo
            // 
            this.labelnumero_vehiculo.AutoSize = true;
            this.labelnumero_vehiculo.Location = new System.Drawing.Point(28, 224);
            this.labelnumero_vehiculo.Name = "labelnumero_vehiculo";
            this.labelnumero_vehiculo.Size = new System.Drawing.Size(193, 18);
            this.labelnumero_vehiculo.TabIndex = 23;
            this.labelnumero_vehiculo.Text = "Número del Vehículo:";
            // 
            // inputplaca
            // 
            this.inputplaca.Location = new System.Drawing.Point(453, 221);
            this.inputplaca.MaxLength = 10;
            this.inputplaca.Name = "inputplaca";
            this.inputplaca.Size = new System.Drawing.Size(241, 27);
            this.inputplaca.TabIndex = 8;
            // 
            // labelplaca
            // 
            this.labelplaca.AutoSize = true;
            this.labelplaca.Location = new System.Drawing.Point(389, 221);
            this.labelplaca.Name = "labelplaca";
            this.labelplaca.Size = new System.Drawing.Size(61, 18);
            this.labelplaca.TabIndex = 24;
            this.labelplaca.Text = "Placa:";
            // 
            // inputdireccion
            // 
            this.inputdireccion.Location = new System.Drawing.Point(123, 265);
            this.inputdireccion.MaxLength = 45;
            this.inputdireccion.Name = "inputdireccion";
            this.inputdireccion.Size = new System.Drawing.Size(250, 27);
            this.inputdireccion.TabIndex = 9;
            // 
            // labeldireccion
            // 
            this.labeldireccion.AutoSize = true;
            this.labeldireccion.Location = new System.Drawing.Point(28, 265);
            this.labeldireccion.Name = "labeldireccion";
            this.labeldireccion.Size = new System.Drawing.Size(94, 18);
            this.labeldireccion.TabIndex = 25;
            this.labeldireccion.Text = "Dirección:";
            // 
            // inputtelefono
            // 
            this.inputtelefono.Location = new System.Drawing.Point(483, 262);
            this.inputtelefono.MaxLength = 45;
            this.inputtelefono.Name = "inputtelefono";
            this.inputtelefono.Size = new System.Drawing.Size(211, 27);
            this.inputtelefono.TabIndex = 10;
            // 
            // labeltelefono
            // 
            this.labeltelefono.AutoSize = true;
            this.labeltelefono.Location = new System.Drawing.Point(389, 262);
            this.labeltelefono.Name = "labeltelefono";
            this.labeltelefono.Size = new System.Drawing.Size(92, 18);
            this.labeltelefono.TabIndex = 26;
            this.labeltelefono.Text = "Teléfono:";
            // 
            // inputdispositivo_id
            // 
            this.inputdispositivo_id.Location = new System.Drawing.Point(162, 305);
            this.inputdispositivo_id.MaxLength = 45;
            this.inputdispositivo_id.Name = "inputdispositivo_id";
            this.inputdispositivo_id.Size = new System.Drawing.Size(211, 27);
            this.inputdispositivo_id.TabIndex = 11;
            // 
            // labeldispositivo_id
            // 
            this.labeldispositivo_id.AutoSize = true;
            this.labeldispositivo_id.Location = new System.Drawing.Point(28, 305);
            this.labeldispositivo_id.Name = "labeldispositivo_id";
            this.labeldispositivo_id.Size = new System.Drawing.Size(131, 18);
            this.labeldispositivo_id.TabIndex = 27;
            this.labeldispositivo_id.Text = "Id Dispositivo:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aLMACENARToolStripMenuItem,
            this.mODIFICARToolStripMenuItem,
            this.eLIMINARToolStripMenuItem,
            this.nuevo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(723, 26);
            this.menuStrip1.TabIndex = 13;
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
            // nuevo
            // 
            this.nuevo.Image = ((System.Drawing.Image)(resources.GetObject("nuevo.Image")));
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(99, 22);
            this.nuevo.Text = "NUEVO";
            this.nuevo.Click += new System.EventHandler(this.nuevo_Click);
            // 
            // labeltipo_dispositivo_id
            // 
            this.labeltipo_dispositivo_id.AutoSize = true;
            this.labeltipo_dispositivo_id.Location = new System.Drawing.Point(28, 137);
            this.labeltipo_dispositivo_id.Name = "labeltipo_dispositivo_id";
            this.labeltipo_dispositivo_id.Size = new System.Drawing.Size(177, 18);
            this.labeltipo_dispositivo_id.TabIndex = 20;
            this.labeltipo_dispositivo_id.Text = "Tipo de Dispositivo:";
            // 
            // inputtipo_dispositivo_id
            // 
            this.inputtipo_dispositivo_id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.inputtipo_dispositivo_id.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.inputtipo_dispositivo_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputtipo_dispositivo_id.DropDownWidth = 300;
            this.inputtipo_dispositivo_id.FormattingEnabled = true;
            this.inputtipo_dispositivo_id.Location = new System.Drawing.Point(205, 134);
            this.inputtipo_dispositivo_id.Name = "inputtipo_dispositivo_id";
            this.inputtipo_dispositivo_id.Size = new System.Drawing.Size(296, 26);
            this.inputtipo_dispositivo_id.TabIndex = 3;
            this.inputtipo_dispositivo_id.SelectedIndexChanged += new System.EventHandler(this.inputtipo_dispositivo_id_SelectedIndexChanged);
            // 
            // inputfecha_soat
            // 
            this.inputfecha_soat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.inputfecha_soat.Location = new System.Drawing.Point(142, 179);
            this.inputfecha_soat.Name = "inputfecha_soat";
            this.inputfecha_soat.Size = new System.Drawing.Size(157, 27);
            this.inputfecha_soat.TabIndex = 5;
            // 
            // inputfecha_tecnomecanica
            // 
            this.inputfecha_tecnomecanica.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.inputfecha_tecnomecanica.Location = new System.Drawing.Point(536, 178);
            this.inputfecha_tecnomecanica.Name = "inputfecha_tecnomecanica";
            this.inputfecha_tecnomecanica.Size = new System.Drawing.Size(157, 27);
            this.inputfecha_tecnomecanica.TabIndex = 6;
            // 
            // gridDevices
            // 
            this.gridDevices.AllowUserToAddRows = false;
            this.gridDevices.AllowUserToDeleteRows = false;
            this.gridDevices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridDevices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDevices.Location = new System.Drawing.Point(31, 418);
            this.gridDevices.Name = "gridDevices";
            this.gridDevices.ReadOnly = true;
            this.gridDevices.Size = new System.Drawing.Size(663, 191);
            this.gridDevices.TabIndex = 16;
            this.gridDevices.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDevices_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(31, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(663, 27);
            this.label2.TabIndex = 28;
            this.label2.Text = "Móviles y Puntos Fijos Configurados";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputactivo
            // 
            this.inputactivo.AutoSize = true;
            this.inputactivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.inputactivo.Checked = true;
            this.inputactivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.inputactivo.Location = new System.Drawing.Point(392, 305);
            this.inputactivo.Name = "inputactivo";
            this.inputactivo.Size = new System.Drawing.Size(86, 22);
            this.inputactivo.TabIndex = 12;
            this.inputactivo.Text = "Activo:";
            this.inputactivo.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(385, 364);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 28);
            this.button2.TabIndex = 14;
            this.button2.Text = "Buscar Dispositivo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(573, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 28);
            this.button1.TabIndex = 15;
            this.button1.Text = "Filtrar Tipo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(502, 133);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(18, 28);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // inputfranquicia_id
            // 
            this.inputfranquicia_id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.inputfranquicia_id.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.inputfranquicia_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputfranquicia_id.DropDownWidth = 300;
            this.inputfranquicia_id.FormattingEnabled = true;
            this.inputfranquicia_id.Location = new System.Drawing.Point(133, 55);
            this.inputfranquicia_id.Name = "inputfranquicia_id";
            this.inputfranquicia_id.Size = new System.Drawing.Size(560, 26);
            this.inputfranquicia_id.TabIndex = 0;
            this.inputfranquicia_id.SelectedIndexChanged += new System.EventHandler(this.inputfranquicia_id_SelectedIndexChanged);
            // 
            // labelmunicipios_id
            // 
            this.labelmunicipios_id.AutoSize = true;
            this.labelmunicipios_id.Location = new System.Drawing.Point(28, 58);
            this.labelmunicipios_id.Name = "labelmunicipios_id";
            this.labelmunicipios_id.Size = new System.Drawing.Size(104, 18);
            this.labelmunicipios_id.TabIndex = 17;
            this.labelmunicipios_id.Text = "Franquicia:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 29;
            this.label1.Text = "(Serial)";
            // 
            // Device
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(723, 614);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputfranquicia_id);
            this.Controls.Add(this.labelmunicipios_id);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputactivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridDevices);
            this.Controls.Add(this.inputfecha_tecnomecanica);
            this.Controls.Add(this.inputfecha_soat);
            this.Controls.Add(this.inputtipo_dispositivo_id);
            this.Controls.Add(this.labeltipo_dispositivo_id);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.labelnombre);
            this.Controls.Add(this.inputnombre);
            this.Controls.Add(this.labeldocumento);
            this.Controls.Add(this.inputdocumento);
            this.Controls.Add(this.labelfecha_soat);
            this.Controls.Add(this.labelfecha_tecnomecanica);
            this.Controls.Add(this.labelnumero_vehiculo);
            this.Controls.Add(this.inputnumero_vehiculo);
            this.Controls.Add(this.labelplaca);
            this.Controls.Add(this.inputplaca);
            this.Controls.Add(this.labeldireccion);
            this.Controls.Add(this.inputdireccion);
            this.Controls.Add(this.labeltelefono);
            this.Controls.Add(this.inputtelefono);
            this.Controls.Add(this.labeldispositivo_id);
            this.Controls.Add(this.inputdispositivo_id);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Device";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONFIGURACIÓN DE MÓVILES Y PUNTOS FIJOS";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDevices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputnombre;
        private System.Windows.Forms.Label labelnombre;
        private System.Windows.Forms.TextBox inputdocumento;
        private System.Windows.Forms.Label labeldocumento;
        private System.Windows.Forms.Label labelfecha_soat;
        private System.Windows.Forms.Label labelfecha_tecnomecanica;
        private System.Windows.Forms.TextBox inputnumero_vehiculo;
        private System.Windows.Forms.Label labelnumero_vehiculo;
        private System.Windows.Forms.TextBox inputplaca;
        private System.Windows.Forms.Label labelplaca;
        private System.Windows.Forms.TextBox inputdireccion;
        private System.Windows.Forms.Label labeldireccion;
        private System.Windows.Forms.TextBox inputtelefono;
        private System.Windows.Forms.Label labeltelefono;
        private System.Windows.Forms.TextBox inputdispositivo_id;
        private System.Windows.Forms.Label labeldispositivo_id;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aLMACENARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mODIFICARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eLIMINARToolStripMenuItem;
        private System.Windows.Forms.Label labeltipo_dispositivo_id;
        private System.Windows.Forms.ComboBox inputtipo_dispositivo_id;
        private System.Windows.Forms.DateTimePicker inputfecha_soat;
        private System.Windows.Forms.DateTimePicker inputfecha_tecnomecanica;
        private System.Windows.Forms.DataGridView gridDevices;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox inputactivo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem nuevo;
        private System.Windows.Forms.ComboBox inputfranquicia_id;
        private System.Windows.Forms.Label labelmunicipios_id;
        private System.Windows.Forms.Label label1;
    }
}