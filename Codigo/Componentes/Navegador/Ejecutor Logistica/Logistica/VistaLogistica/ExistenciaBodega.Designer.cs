
namespace VistaLogistica
{
    partial class ExistenciaBodega
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtExistencia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.txtIdAplicacion = new System.Windows.Forms.TextBox();
            this.txtIdBodega = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgExisBodega = new System.Windows.Forms.DataGridView();
            this.dtgBodega_Producto = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgExisBodega)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBodega_Producto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtExistencia);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtIdProducto);
            this.groupBox1.Controls.Add(this.txtIdAplicacion);
            this.groupBox1.Controls.Add(this.txtIdBodega);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 110);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // txtExistencia
            // 
            this.txtExistencia.Location = new System.Drawing.Point(190, 79);
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.Size = new System.Drawing.Size(177, 20);
            this.txtExistencia.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(109, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 45;
            this.label3.Text = "Existencia";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(8, 42);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 24);
            this.button3.TabIndex = 44;
            this.button3.Text = "?";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(230, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 24);
            this.button2.TabIndex = 43;
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Location = new System.Drawing.Point(258, 46);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(174, 20);
            this.txtIdProducto.TabIndex = 42;
            this.txtIdProducto.Tag = "";
            // 
            // txtIdAplicacion
            // 
            this.txtIdAplicacion.Location = new System.Drawing.Point(435, 46);
            this.txtIdAplicacion.Name = "txtIdAplicacion";
            this.txtIdAplicacion.Size = new System.Drawing.Size(24, 20);
            this.txtIdAplicacion.TabIndex = 40;
            this.txtIdAplicacion.Tag = "fk_id_aplicacion";
            // 
            // txtIdBodega
            // 
            this.txtIdBodega.Location = new System.Drawing.Point(38, 46);
            this.txtIdBodega.Name = "txtIdBodega";
            this.txtIdBodega.Size = new System.Drawing.Size(170, 20);
            this.txtIdBodega.TabIndex = 39;
            this.txtIdBodega.Tag = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(305, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bodega";
            // 
            // dtgExisBodega
            // 
            this.dtgExisBodega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgExisBodega.Location = new System.Drawing.Point(12, 173);
            this.dtgExisBodega.Margin = new System.Windows.Forms.Padding(2);
            this.dtgExisBodega.Name = "dtgExisBodega";
            this.dtgExisBodega.RowHeadersWidth = 51;
            this.dtgExisBodega.RowTemplate.Height = 24;
            this.dtgExisBodega.Size = new System.Drawing.Size(459, 199);
            this.dtgExisBodega.TabIndex = 62;
            // 
            // dtgBodega_Producto
            // 
            this.dtgBodega_Producto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBodega_Producto.Location = new System.Drawing.Point(480, 19);
            this.dtgBodega_Producto.Name = "dtgBodega_Producto";
            this.dtgBodega_Producto.RowHeadersWidth = 51;
            this.dtgBodega_Producto.Size = new System.Drawing.Size(350, 353);
            this.dtgBodega_Producto.TabIndex = 63;
            this.dtgBodega_Producto.Tag = "";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(248, 128);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(77, 35);
            this.btnEliminar.TabIndex = 68;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(331, 128);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(77, 35);
            this.btnSalir.TabIndex = 67;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(165, 128);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(77, 35);
            this.btnGuardar.TabIndex = 65;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(82, 128);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(77, 35);
            this.btnLimpiar.TabIndex = 64;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // ExistenciaBodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 378);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.dtgBodega_Producto);
            this.Controls.Add(this.dtgExisBodega);
            this.Controls.Add(this.groupBox1);
            this.Name = "ExistenciaBodega";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExistenciaBodega";
            this.Load += new System.EventHandler(this.ExistenciaBodega_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgExisBodega)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBodega_Producto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.TextBox txtIdAplicacion;
        private System.Windows.Forms.TextBox txtIdBodega;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtExistencia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgExisBodega;
        private System.Windows.Forms.DataGridView dtgBodega_Producto;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}