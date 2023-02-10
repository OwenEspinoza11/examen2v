namespace examen2V
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mtxtInversion = new System.Windows.Forms.MaskedTextBox();
            this.cboTipoProy = new System.Windows.Forms.ComboBox();
            this.dtgvDatos = new System.Windows.Forms.DataGridView();
            this.Inversion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ingreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Egreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Impuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mtxtIngreso = new System.Windows.Forms.MaskedTextBox();
            this.mtxtEgreso = new System.Windows.Forms.MaskedTextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUtilidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUdIm = new System.Windows.Forms.TextBox();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inversion inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo proyeccion";
            // 
            // mtxtInversion
            // 
            this.mtxtInversion.Location = new System.Drawing.Point(151, 22);
            this.mtxtInversion.Mask = "00000000";
            this.mtxtInversion.Name = "mtxtInversion";
            this.mtxtInversion.Size = new System.Drawing.Size(100, 23);
            this.mtxtInversion.TabIndex = 2;
            // 
            // cboTipoProy
            // 
            this.cboTipoProy.FormattingEnabled = true;
            this.cboTipoProy.Items.AddRange(new object[] {
            "3",
            "4",
            "6",
            "8",
            "10",
            "12",
            "18",
            "24"});
            this.cboTipoProy.Location = new System.Drawing.Point(151, 180);
            this.cboTipoProy.Name = "cboTipoProy";
            this.cboTipoProy.Size = new System.Drawing.Size(121, 23);
            this.cboTipoProy.TabIndex = 3;
            // 
            // dtgvDatos
            // 
            this.dtgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Inversion,
            this.Ingreso,
            this.Egreso,
            this.UAI,
            this.Impuesto});
            this.dtgvDatos.Location = new System.Drawing.Point(41, 289);
            this.dtgvDatos.Name = "dtgvDatos";
            this.dtgvDatos.RowTemplate.Height = 25;
            this.dtgvDatos.Size = new System.Drawing.Size(544, 188);
            this.dtgvDatos.TabIndex = 4;
            this.dtgvDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDatos_CellClick);
            this.dtgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDatos_CellContentClick);
            // 
            // Inversion
            // 
            this.Inversion.HeaderText = "Inversion";
            this.Inversion.Name = "Inversion";
            // 
            // Ingreso
            // 
            this.Ingreso.HeaderText = "Ingreso";
            this.Ingreso.Name = "Ingreso";
            // 
            // Egreso
            // 
            this.Egreso.HeaderText = "Egreso";
            this.Egreso.Name = "Egreso";
            // 
            // UAI
            // 
            this.UAI.HeaderText = "UAI";
            this.UAI.Name = "UAI";
            // 
            // Impuesto
            // 
            this.Impuesto.HeaderText = "Impuesto";
            this.Impuesto.Name = "Impuesto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ingreso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Egreso";
            // 
            // mtxtIngreso
            // 
            this.mtxtIngreso.Location = new System.Drawing.Point(151, 75);
            this.mtxtIngreso.Mask = "00000000";
            this.mtxtIngreso.Name = "mtxtIngreso";
            this.mtxtIngreso.Size = new System.Drawing.Size(100, 23);
            this.mtxtIngreso.TabIndex = 8;
            // 
            // mtxtEgreso
            // 
            this.mtxtEgreso.Location = new System.Drawing.Point(151, 129);
            this.mtxtEgreso.Mask = "00000000";
            this.mtxtEgreso.Name = "mtxtEgreso";
            this.mtxtEgreso.Size = new System.Drawing.Size(100, 23);
            this.mtxtEgreso.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(406, 183);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(325, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Utilidad";
            // 
            // txtUtilidad
            // 
            this.txtUtilidad.Location = new System.Drawing.Point(406, 22);
            this.txtUtilidad.Name = "txtUtilidad";
            this.txtUtilidad.Size = new System.Drawing.Size(100, 23);
            this.txtUtilidad.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(325, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Impuesto";
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Location = new System.Drawing.Point(406, 75);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Size = new System.Drawing.Size(100, 23);
            this.txtImpuesto.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(325, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "UdImpuesto";
            // 
            // txtUdIm
            // 
            this.txtUdIm.Location = new System.Drawing.Point(406, 129);
            this.txtUdIm.Name = "txtUdIm";
            this.txtUdIm.Size = new System.Drawing.Size(100, 23);
            this.txtUdIm.TabIndex = 16;
            // 
            // lblInformacion
            // 
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.Location = new System.Drawing.Point(41, 230);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(192, 15);
            this.lblInformacion.TabIndex = 17;
            this.lblInformacion.Text = "-------------------------------------";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(322, 222);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 18;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(322, 183);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 19;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 501);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.lblInformacion);
            this.Controls.Add(this.txtUdIm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtImpuesto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtUtilidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.mtxtIngreso);
            this.Controls.Add(this.mtxtEgreso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtgvDatos);
            this.Controls.Add(this.cboTipoProy);
            this.Controls.Add(this.mtxtInversion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private MaskedTextBox mtxtInversion;
        private ComboBox cboTipoProy;
        private DataGridView dtgvDatos;
        private DataGridViewTextBoxColumn Inversion;
        private DataGridViewTextBoxColumn Ingreso;
        private DataGridViewTextBoxColumn Egreso;
        private DataGridViewTextBoxColumn UAI;
        private DataGridViewTextBoxColumn Impuesto;
        private Label label3;
        private Label label4;
        private MaskedTextBox mtxtIngreso;
        private MaskedTextBox mtxtEgreso;
        private Button btnCalcular;
        private Label label5;
        private TextBox txtUtilidad;
        private Label label6;
        private TextBox txtImpuesto;
        private Label label7;
        private TextBox txtUdIm;
        private Label lblInformacion;
        private Button btnBorrar;
        private Button btnAgregar;
    }
}