
namespace ENE
{
    partial class RegistroRequerimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroRequerimiento));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxTipoRequerimientos = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txaDescripcionRequerimiento = new System.Windows.Forms.TextBox();
            this.cbxAsignacion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxPrioridad = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnClearCampos = new System.Windows.Forms.Button();
            this.btnListRequerimiento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro Requerimiento";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo Requerimiento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Asignado a:";
            // 
            // cbxTipoRequerimientos
            // 
            this.cbxTipoRequerimientos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxTipoRequerimientos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoRequerimientos.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipoRequerimientos.FormattingEnabled = true;
            this.cbxTipoRequerimientos.Location = new System.Drawing.Point(206, 85);
            this.cbxTipoRequerimientos.Name = "cbxTipoRequerimientos";
            this.cbxTipoRequerimientos.Size = new System.Drawing.Size(212, 24);
            this.cbxTipoRequerimientos.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "Descripcion del Requerimiento:";
            // 
            // txaDescripcionRequerimiento
            // 
            this.txaDescripcionRequerimiento.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txaDescripcionRequerimiento.Location = new System.Drawing.Point(50, 225);
            this.txaDescripcionRequerimiento.Multiline = true;
            this.txaDescripcionRequerimiento.Name = "txaDescripcionRequerimiento";
            this.txaDescripcionRequerimiento.Size = new System.Drawing.Size(416, 84);
            this.txaDescripcionRequerimiento.TabIndex = 5;
            // 
            // cbxAsignacion
            // 
            this.cbxAsignacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxAsignacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAsignacion.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAsignacion.FormattingEnabled = true;
            this.cbxAsignacion.Location = new System.Drawing.Point(206, 139);
            this.cbxAsignacion.Name = "cbxAsignacion";
            this.cbxAsignacion.Size = new System.Drawing.Size(212, 24);
            this.cbxAsignacion.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "Prioridad:";
            // 
            // cbxPrioridad
            // 
            this.cbxPrioridad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPrioridad.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPrioridad.FormattingEnabled = true;
            this.cbxPrioridad.Location = new System.Drawing.Point(206, 324);
            this.cbxPrioridad.Name = "cbxPrioridad";
            this.cbxPrioridad.Size = new System.Drawing.Size(212, 24);
            this.cbxPrioridad.TabIndex = 9;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.Location = new System.Drawing.Point(12, 379);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(130, 37);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnClearCampos
            // 
            this.btnClearCampos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearCampos.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.btnClearCampos.Location = new System.Drawing.Point(165, 379);
            this.btnClearCampos.Name = "btnClearCampos";
            this.btnClearCampos.Size = new System.Drawing.Size(173, 37);
            this.btnClearCampos.TabIndex = 11;
            this.btnClearCampos.Text = "Limpiar Campos";
            this.btnClearCampos.UseVisualStyleBackColor = true;
            this.btnClearCampos.Click += new System.EventHandler(this.btnClearCampos_Click);
            // 
            // btnListRequerimiento
            // 
            this.btnListRequerimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListRequerimiento.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListRequerimiento.Location = new System.Drawing.Point(360, 379);
            this.btnListRequerimiento.Name = "btnListRequerimiento";
            this.btnListRequerimiento.Size = new System.Drawing.Size(243, 37);
            this.btnListRequerimiento.TabIndex = 12;
            this.btnListRequerimiento.Text = "Ir a Listar Requerimientos";
            this.btnListRequerimiento.UseVisualStyleBackColor = true;
            this.btnListRequerimiento.Click += new System.EventHandler(this.btnListRequerimiento_Click);
            // 
            // RegistroRequerimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 424);
            this.Controls.Add(this.btnListRequerimiento);
            this.Controls.Add(this.btnClearCampos);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cbxPrioridad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxAsignacion);
            this.Controls.Add(this.txaDescripcionRequerimiento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxTipoRequerimientos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RegistroRequerimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registro Requerimientos";
            this.Load += new System.EventHandler(this.RegistroRequerimiento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxTipoRequerimientos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txaDescripcionRequerimiento;
        private System.Windows.Forms.ComboBox cbxAsignacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxPrioridad;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnClearCampos;
        private System.Windows.Forms.Button btnListRequerimiento;
    }
}