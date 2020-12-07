
namespace ENE
{
    partial class ListaDeRequerimientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaDeRequerimientos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxReadRequerimiento = new System.Windows.Forms.ComboBox();
            this.cbxReadPrioridad = new System.Windows.Forms.ComboBox();
            this.chckBoxPendientes = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chckBoxResueltos = new System.Windows.Forms.CheckBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCheckResuelto = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblLineaForTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.label1.Location = new System.Drawing.Point(214, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de Requerimientos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(24, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo Requerimiento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(24, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prioridad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(24, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pendientes";
            // 
            // cbxReadRequerimiento
            // 
            this.cbxReadRequerimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxReadRequerimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxReadRequerimiento.FormattingEnabled = true;
            this.cbxReadRequerimiento.Location = new System.Drawing.Point(198, 82);
            this.cbxReadRequerimiento.Name = "cbxReadRequerimiento";
            this.cbxReadRequerimiento.Size = new System.Drawing.Size(245, 21);
            this.cbxReadRequerimiento.TabIndex = 4;
            // 
            // cbxReadPrioridad
            // 
            this.cbxReadPrioridad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxReadPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxReadPrioridad.FormattingEnabled = true;
            this.cbxReadPrioridad.Location = new System.Drawing.Point(198, 116);
            this.cbxReadPrioridad.Name = "cbxReadPrioridad";
            this.cbxReadPrioridad.Size = new System.Drawing.Size(245, 21);
            this.cbxReadPrioridad.TabIndex = 5;
            // 
            // chckBoxPendientes
            // 
            this.chckBoxPendientes.AutoSize = true;
            this.chckBoxPendientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chckBoxPendientes.Location = new System.Drawing.Point(198, 157);
            this.chckBoxPendientes.Name = "chckBoxPendientes";
            this.chckBoxPendientes.Size = new System.Drawing.Size(15, 14);
            this.chckBoxPendientes.TabIndex = 6;
            this.chckBoxPendientes.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(287, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Resueltos";
            // 
            // chckBoxResueltos
            // 
            this.chckBoxResueltos.AutoSize = true;
            this.chckBoxResueltos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chckBoxResueltos.Location = new System.Drawing.Point(388, 156);
            this.chckBoxResueltos.Name = "chckBoxResueltos";
            this.chckBoxResueltos.Size = new System.Drawing.Size(15, 14);
            this.chckBoxResueltos.TabIndex = 8;
            this.chckBoxResueltos.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.Location = new System.Drawing.Point(508, 146);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(122, 31);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(27, 221);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(603, 133);
            this.dataGridView1.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tipo Requerimiento";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Prioridad";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Descripción";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Días Plazo";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // btnCheckResuelto
            // 
            this.btnCheckResuelto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckResuelto.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnCheckResuelto.Location = new System.Drawing.Point(27, 360);
            this.btnCheckResuelto.Name = "btnCheckResuelto";
            this.btnCheckResuelto.Size = new System.Drawing.Size(231, 34);
            this.btnCheckResuelto.TabIndex = 11;
            this.btnCheckResuelto.Text = "Marcar como Resuelto";
            this.btnCheckResuelto.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.Location = new System.Drawing.Point(290, 360);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(218, 34);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // lblLineaForTitle
            // 
            this.lblLineaForTitle.AutoSize = true;
            this.lblLineaForTitle.Location = new System.Drawing.Point(245, 44);
            this.lblLineaForTitle.Name = "lblLineaForTitle";
            this.lblLineaForTitle.Size = new System.Drawing.Size(175, 13);
            this.lblLineaForTitle.TabIndex = 13;
            this.lblLineaForTitle.Text = "--------------------------------------------------------";
            // 
            // ListaDeRequerimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 400);
            this.Controls.Add(this.lblLineaForTitle);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCheckResuelto);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.chckBoxResueltos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chckBoxPendientes);
            this.Controls.Add(this.cbxReadPrioridad);
            this.Controls.Add(this.cbxReadRequerimiento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListaDeRequerimientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lista Requerimientos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxReadRequerimiento;
        private System.Windows.Forms.ComboBox cbxReadPrioridad;
        private System.Windows.Forms.CheckBox chckBoxPendientes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chckBoxResueltos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnCheckResuelto;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblLineaForTitle;
    }
}