namespace WindowsFormsApp1
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.database1DataSet = new WindowsFormsApp1.Database1DataSet();
            this.magazieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.magazieTableAdapter = new WindowsFormsApp1.Database1DataSetTableAdapters.MagazieTableAdapter();
            this.produsIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeProdusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bucatiProdusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.comenziBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comenziTableAdapter = new WindowsFormsApp1.Database1DataSetTableAdapters.ComenziTableAdapter();
            this.numeProdusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comandaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comenziBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.produsIdDataGridViewTextBoxColumn,
            this.numeProdusDataGridViewTextBoxColumn,
            this.bucatiProdusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.magazieBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(50, 259);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(464, 261);
            this.dataGridView1.TabIndex = 0;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // magazieBindingSource
            // 
            this.magazieBindingSource.DataMember = "Magazie";
            this.magazieBindingSource.DataSource = this.database1DataSet;
            // 
            // magazieTableAdapter
            // 
            this.magazieTableAdapter.ClearBeforeFill = true;
            // 
            // produsIdDataGridViewTextBoxColumn
            // 
            this.produsIdDataGridViewTextBoxColumn.DataPropertyName = "ProdusId";
            this.produsIdDataGridViewTextBoxColumn.HeaderText = "ProdusId";
            this.produsIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.produsIdDataGridViewTextBoxColumn.Name = "produsIdDataGridViewTextBoxColumn";
            this.produsIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.produsIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // numeProdusDataGridViewTextBoxColumn
            // 
            this.numeProdusDataGridViewTextBoxColumn.DataPropertyName = "NumeProdus";
            this.numeProdusDataGridViewTextBoxColumn.HeaderText = "NumeProdus";
            this.numeProdusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeProdusDataGridViewTextBoxColumn.Name = "numeProdusDataGridViewTextBoxColumn";
            this.numeProdusDataGridViewTextBoxColumn.Width = 125;
            // 
            // bucatiProdusDataGridViewTextBoxColumn
            // 
            this.bucatiProdusDataGridViewTextBoxColumn.DataPropertyName = "BucatiProdus";
            this.bucatiProdusDataGridViewTextBoxColumn.HeaderText = "BucatiProdus";
            this.bucatiProdusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bucatiProdusDataGridViewTextBoxColumn.Name = "bucatiProdusDataGridViewTextBoxColumn";
            this.bucatiProdusDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeProdusDataGridViewTextBoxColumn1,
            this.comandaIdDataGridViewTextBoxColumn,
            this.cantitateDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.comenziBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(611, 259);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(564, 261);
            this.dataGridView2.TabIndex = 1;
            // 
            // comenziBindingSource
            // 
            this.comenziBindingSource.DataMember = "Comenzi";
            this.comenziBindingSource.DataSource = this.database1DataSet;
            // 
            // comenziTableAdapter
            // 
            this.comenziTableAdapter.ClearBeforeFill = true;
            // 
            // numeProdusDataGridViewTextBoxColumn1
            // 
            this.numeProdusDataGridViewTextBoxColumn1.DataPropertyName = "NumeProdus";
            this.numeProdusDataGridViewTextBoxColumn1.HeaderText = "NumeProdus";
            this.numeProdusDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.numeProdusDataGridViewTextBoxColumn1.Name = "numeProdusDataGridViewTextBoxColumn1";
            this.numeProdusDataGridViewTextBoxColumn1.Width = 125;
            // 
            // comandaIdDataGridViewTextBoxColumn
            // 
            this.comandaIdDataGridViewTextBoxColumn.DataPropertyName = "ComandaId";
            this.comandaIdDataGridViewTextBoxColumn.HeaderText = "ComandaId";
            this.comandaIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.comandaIdDataGridViewTextBoxColumn.Name = "comandaIdDataGridViewTextBoxColumn";
            this.comandaIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.comandaIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // cantitateDataGridViewTextBoxColumn
            // 
            this.cantitateDataGridViewTextBoxColumn.DataPropertyName = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.HeaderText = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantitateDataGridViewTextBoxColumn.Name = "cantitateDataGridViewTextBoxColumn";
            this.cantitateDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.Width = 125;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(476, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 251);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Comanda";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Plaseaza comanda";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Cantitate\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nume";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(94, 128);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Produse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1067, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Comenzi";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(517, 388);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Afiseaza";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1227, 604);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comenziBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource magazieBindingSource;
        private Database1DataSetTableAdapters.MagazieTableAdapter magazieTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn produsIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeProdusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bucatiProdusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource comenziBindingSource;
        private Database1DataSetTableAdapters.ComenziTableAdapter comenziTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeProdusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn comandaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
    }
}