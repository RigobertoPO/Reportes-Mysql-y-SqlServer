namespace ReportesWindows
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AlmacenDBDataSet = new ReportesWindows.AlmacenDBDataSet();
            this.ProductosTableAdapter = new ReportesWindows.AlmacenDBDataSetTableAdapters.ProductosTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewMysql = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CodigoLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GenerarButton = new System.Windows.Forms.Button();
            this.BarrasLabel = new System.Windows.Forms.Label();
            this.codigotextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.FiltrarMYSQLbutton = new System.Windows.Forms.Button();
            this.FiltrarSQLServerbutton = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlmacenDBDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMysql)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductosBindingSource
            // 
            this.ProductosBindingSource.DataMember = "Productos";
            this.ProductosBindingSource.DataSource = this.AlmacenDBDataSet;
            // 
            // AlmacenDBDataSet
            // 
            this.AlmacenDBDataSet.DataSetName = "AlmacenDBDataSet";
            this.AlmacenDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ProductosTableAdapter
            // 
            this.ProductosTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewMysql);
            this.groupBox1.Location = new System.Drawing.Point(25, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 145);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Leer datos de una base de datos Mysql";
            // 
            // dataGridViewMysql
            // 
            this.dataGridViewMysql.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMysql.Location = new System.Drawing.Point(12, 30);
            this.dataGridViewMysql.Name = "dataGridViewMysql";
            this.dataGridViewMysql.Size = new System.Drawing.Size(737, 95);
            this.dataGridViewMysql.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CodigoLabel);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.GenerarButton);
            this.groupBox2.Controls.Add(this.BarrasLabel);
            this.groupBox2.Controls.Add(this.codigotextBox);
            this.groupBox2.Location = new System.Drawing.Point(25, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(755, 82);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Generar codigos de barra";
            // 
            // CodigoLabel
            // 
            this.CodigoLabel.AutoSize = true;
            this.CodigoLabel.Location = new System.Drawing.Point(505, 59);
            this.CodigoLabel.Name = "CodigoLabel";
            this.CodigoLabel.Size = new System.Drawing.Size(13, 13);
            this.CodigoLabel.TabIndex = 10;
            this.CodigoLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Introduce un código:";
            // 
            // GenerarButton
            // 
            this.GenerarButton.Location = new System.Drawing.Point(244, 30);
            this.GenerarButton.Name = "GenerarButton";
            this.GenerarButton.Size = new System.Drawing.Size(75, 23);
            this.GenerarButton.TabIndex = 8;
            this.GenerarButton.Text = "Generar";
            this.GenerarButton.UseVisualStyleBackColor = true;
            // 
            // BarrasLabel
            // 
            this.BarrasLabel.AutoSize = true;
            this.BarrasLabel.Font = new System.Drawing.Font("Bar-Code 39", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.BarrasLabel.Location = new System.Drawing.Point(488, 17);
            this.BarrasLabel.Name = "BarrasLabel";
            this.BarrasLabel.Size = new System.Drawing.Size(30, 31);
            this.BarrasLabel.TabIndex = 7;
            this.BarrasLabel.Text = "0";
            // 
            // codigotextBox
            // 
            this.codigotextBox.Location = new System.Drawing.Point(128, 32);
            this.codigotextBox.Name = "codigotextBox";
            this.codigotextBox.Size = new System.Drawing.Size(100, 20);
            this.codigotextBox.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.FiltrarMYSQLbutton);
            this.groupBox3.Controls.Add(this.FiltrarSQLServerbutton);
            this.groupBox3.Controls.Add(this.reportViewer1);
            this.groupBox3.Location = new System.Drawing.Point(25, 272);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(755, 220);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Reportes con datos de mysql y sqlserver (version localdb)";
            // 
            // FiltrarMYSQLbutton
            // 
            this.FiltrarMYSQLbutton.Location = new System.Drawing.Point(189, 174);
            this.FiltrarMYSQLbutton.Name = "FiltrarMYSQLbutton";
            this.FiltrarMYSQLbutton.Size = new System.Drawing.Size(130, 23);
            this.FiltrarMYSQLbutton.TabIndex = 12;
            this.FiltrarMYSQLbutton.Text = "Filtrar MYSQL";
            this.FiltrarMYSQLbutton.UseVisualStyleBackColor = true;
            // 
            // FiltrarSQLServerbutton
            // 
            this.FiltrarSQLServerbutton.Location = new System.Drawing.Point(376, 174);
            this.FiltrarSQLServerbutton.Name = "FiltrarSQLServerbutton";
            this.FiltrarSQLServerbutton.Size = new System.Drawing.Size(115, 23);
            this.FiltrarSQLServerbutton.TabIndex = 11;
            this.FiltrarSQLServerbutton.Text = "Filtrar SQLServer";
            this.FiltrarSQLServerbutton.UseVisualStyleBackColor = true;
            this.FiltrarSQLServerbutton.Click += new System.EventHandler(this.FiltrarSQLServerbutton_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ProductosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportesWindows.ListaProductos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 32);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(737, 136);
            this.reportViewer1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 504);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Conexiones DataSet Mysql y SQLServer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlmacenDBDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMysql)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource ProductosBindingSource;
        private AlmacenDBDataSet AlmacenDBDataSet;
        private AlmacenDBDataSetTableAdapters.ProductosTableAdapter ProductosTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewMysql;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label CodigoLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GenerarButton;
        private System.Windows.Forms.Label BarrasLabel;
        private System.Windows.Forms.TextBox codigotextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button FiltrarMYSQLbutton;
        private System.Windows.Forms.Button FiltrarSQLServerbutton;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}

