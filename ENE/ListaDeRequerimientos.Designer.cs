
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
            this.dgDetalleRequerimientos = new System.Windows.Forms.DataGridView();
            this.btnCheckResuelto = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalleRequerimientos)).BeginInit();
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
            this.label2.Location = new System.Drawing.Point(24, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo Requerimiento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(24, 119);
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
            this.cbxReadRequerimiento.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxReadRequerimiento.FormattingEnabled = true;
            this.cbxReadRequerimiento.Location = new System.Drawing.Point(198, 82);
            this.cbxReadRequerimiento.Name = "cbxReadRequerimiento";
            this.cbxReadRequerimiento.Size = new System.Drawing.Size(245, 24);
            this.cbxReadRequerimiento.TabIndex = 4;
            // 
            // cbxReadPrioridad
            // 
            this.cbxReadPrioridad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxReadPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxReadPrioridad.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxReadPrioridad.FormattingEnabled = true;
            this.cbxReadPrioridad.Location = new System.Drawing.Point(198, 116);
            this.cbxReadPrioridad.Name = "cbxReadPrioridad";
            this.cbxReadPrioridad.Size = new System.Drawing.Size(245, 24);
            this.cbxReadPrioridad.TabIndex = 5;
            // 
            // chckBoxPendientes
            // 
            this.chckBoxPendientes.AutoSize = true;
            this.chckBoxPendientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chckBoxPendientes.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.label5.Location = new System.Drawing.Point(287, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Resueltos";
            // 
            // chckBoxResueltos
            // 
            this.chckBoxResueltos.AutoSize = true;
            this.chckBoxResueltos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chckBoxResueltos.Location = new System.Drawing.Point(385, 159);
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
            // dgDetalleRequerimientos
            // 
            this.dgDetalleRequerimientos.AllowUserToAddRows = false;
            this.dgDetalleRequerimientos.AllowUserToDeleteRows = false;
            this.dgDetalleRequerimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetalleRequerimientos.Location = new System.Drawing.Point(27, 202);
            this.dgDetalleRequerimientos.Name = "dgDetalleRequerimientos";
            this.dgDetalleRequerimientos.ReadOnly = true;
            this.dgDetalleRequerimientos.Size = new System.Drawing.Size(603, 152);
            this.dgDetalleRequerimientos.TabIndex = 10;
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
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // ListaDeRequerimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 400);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCheckResuelto);
            this.Controls.Add(this.dgDetalleRequerimientos);
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
            this.Load += new System.EventHandler(this.ListaDeRequerimientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalleRequerimientos)).EndInit();
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
        private System.Windows.Forms.DataGridView dgDetalleRequerimientos;
        private System.Windows.Forms.Button btnCheckResuelto;
        private System.Windows.Forms.Button btnEliminar;
    }
}