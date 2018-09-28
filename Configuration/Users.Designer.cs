namespace publiRecargas.Configuration
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aLMACENARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mODIFICARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eLIMINARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.gridUsers = new System.Windows.Forms.DataGridView();
            this.labelnombre = new System.Windows.Forms.Label();
            this.inputnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputdocumento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputtipo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inputuser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inputpass = new System.Windows.Forms.TextBox();
            this.inputpass2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.inputfranquicia_id = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers)).BeginInit();
            this.SuspendLayout();
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
            this.menuStrip1.TabIndex = 6;
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
            this.nuevo.Click += new System.EventHandler(this.lIMPIARPANTALLAToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(30, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(663, 27);
            this.label2.TabIndex = 13;
            this.label2.Text = "USUARIOS DEL SISTEMA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridUsers
            // 
            this.gridUsers.AllowUserToAddRows = false;
            this.gridUsers.AllowUserToDeleteRows = false;
            this.gridUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUsers.Location = new System.Drawing.Point(30, 310);
            this.gridUsers.Name = "gridUsers";
            this.gridUsers.ReadOnly = true;
            this.gridUsers.Size = new System.Drawing.Size(663, 278);
            this.gridUsers.TabIndex = 7;
            this.gridUsers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUsers_CellDoubleClick);
            // 
            // labelnombre
            // 
            this.labelnombre.AutoSize = true;
            this.labelnombre.Location = new System.Drawing.Point(24, 61);
            this.labelnombre.Name = "labelnombre";
            this.labelnombre.Size = new System.Drawing.Size(84, 18);
            this.labelnombre.TabIndex = 8;
            this.labelnombre.Text = "Nombre:";
            // 
            // inputnombre
            // 
            this.inputnombre.Location = new System.Drawing.Point(109, 61);
            this.inputnombre.MaxLength = 100;
            this.inputnombre.Name = "inputnombre";
            this.inputnombre.Size = new System.Drawing.Size(251, 27);
            this.inputnombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Documento:";
            // 
            // inputdocumento
            // 
            this.inputdocumento.Location = new System.Drawing.Point(492, 61);
            this.inputdocumento.MaxLength = 100;
            this.inputdocumento.Name = "inputdocumento";
            this.inputdocumento.Size = new System.Drawing.Size(210, 27);
            this.inputdocumento.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Perfil:";
            // 
            // inputtipo
            // 
            this.inputtipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.inputtipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.inputtipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputtipo.DropDownWidth = 300;
            this.inputtipo.FormattingEnabled = true;
            this.inputtipo.Items.AddRange(new object[] {
            "Administrador",
            "Auxiliar",
            "Franquicia"});
            this.inputtipo.Location = new System.Drawing.Point(109, 101);
            this.inputtipo.Name = "inputtipo";
            this.inputtipo.Size = new System.Drawing.Size(251, 26);
            this.inputtipo.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Usuario:";
            // 
            // inputuser
            // 
            this.inputuser.Location = new System.Drawing.Point(109, 142);
            this.inputuser.MaxLength = 100;
            this.inputuser.Name = "inputuser";
            this.inputuser.Size = new System.Drawing.Size(251, 27);
            this.inputuser.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Contraseña:";
            // 
            // inputpass
            // 
            this.inputpass.Location = new System.Drawing.Point(139, 182);
            this.inputpass.MaxLength = 100;
            this.inputpass.Name = "inputpass";
            this.inputpass.PasswordChar = '*';
            this.inputpass.Size = new System.Drawing.Size(221, 27);
            this.inputpass.TabIndex = 4;
            this.inputpass.UseSystemPasswordChar = true;
            // 
            // inputpass2
            // 
            this.inputpass2.Location = new System.Drawing.Point(378, 182);
            this.inputpass2.MaxLength = 100;
            this.inputpass2.Name = "inputpass2";
            this.inputpass2.PasswordChar = '*';
            this.inputpass2.Size = new System.Drawing.Size(221, 27);
            this.inputpass2.TabIndex = 5;
            this.inputpass2.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(382, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(265, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "** (Confirme su Contraseña)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Franquicia:";
            // 
            // inputfranquicia_id
            // 
            this.inputfranquicia_id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.inputfranquicia_id.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.inputfranquicia_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputfranquicia_id.DropDownWidth = 300;
            this.inputfranquicia_id.FormattingEnabled = true;
            this.inputfranquicia_id.Items.AddRange(new object[] {
            "Administrador",
            "Auxiliar"});
            this.inputfranquicia_id.Location = new System.Drawing.Point(139, 223);
            this.inputfranquicia_id.Name = "inputfranquicia_id";
            this.inputfranquicia_id.Size = new System.Drawing.Size(221, 26);
            this.inputfranquicia_id.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(364, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 28);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Users
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(723, 614);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputfranquicia_id);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.inputpass2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inputpass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputuser);
            this.Controls.Add(this.inputtipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputdocumento);
            this.Controls.Add(this.labelnombre);
            this.Controls.Add(this.inputnombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridUsers);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.Name = "Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración de Usuarios";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aLMACENARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mODIFICARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eLIMINARToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridUsers;
        private System.Windows.Forms.Label labelnombre;
        private System.Windows.Forms.TextBox inputnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputdocumento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox inputtipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputuser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputpass;
        private System.Windows.Forms.TextBox inputpass2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem nuevo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox inputfranquicia_id;
        private System.Windows.Forms.Button button1;
    }
}