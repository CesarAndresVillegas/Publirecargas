namespace publiRecargas.Configuration
{
    partial class TipoDispositivo
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
            this.label2 = new System.Windows.Forms.Label();
            this.gridTipos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputnombre = new System.Windows.Forms.TextBox();
            this.inputcantidad_reproducciones = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridTipos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputcantidad_reproducciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(28, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(663, 27);
            this.label2.TabIndex = 15;
            this.label2.Text = "TIPOS DE DISPOSITIVO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridTipos
            // 
            this.gridTipos.AllowUserToAddRows = false;
            this.gridTipos.AllowUserToDeleteRows = false;
            this.gridTipos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridTipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTipos.Location = new System.Drawing.Point(28, 290);
            this.gridTipos.Name = "gridTipos";
            this.gridTipos.ReadOnly = true;
            this.gridTipos.Size = new System.Drawing.Size(663, 122);
            this.gridTipos.TabIndex = 14;
            this.gridTipos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTipos_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tipo de Dispositivo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Cantidad de Reproducciones:";
            // 
            // inputnombre
            // 
            this.inputnombre.Location = new System.Drawing.Point(228, 54);
            this.inputnombre.MaxLength = 45;
            this.inputnombre.Name = "inputnombre";
            this.inputnombre.Size = new System.Drawing.Size(225, 27);
            this.inputnombre.TabIndex = 18;
            // 
            // inputcantidad_reproducciones
            // 
            this.inputcantidad_reproducciones.Location = new System.Drawing.Point(333, 98);
            this.inputcantidad_reproducciones.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.inputcantidad_reproducciones.Name = "inputcantidad_reproducciones";
            this.inputcantidad_reproducciones.Size = new System.Drawing.Size(120, 27);
            this.inputcantidad_reproducciones.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 53);
            this.button1.TabIndex = 20;
            this.button1.Text = "MODIFICAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TipoDispositivo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(723, 456);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputcantidad_reproducciones);
            this.Controls.Add(this.inputnombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridTipos);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.Name = "TipoDispositivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TIPO DE DISPOSITIVO";
            ((System.ComponentModel.ISupportInitialize)(this.gridTipos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputcantidad_reproducciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridTipos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputnombre;
        private System.Windows.Forms.NumericUpDown inputcantidad_reproducciones;
        private System.Windows.Forms.Button button1;
    }
}