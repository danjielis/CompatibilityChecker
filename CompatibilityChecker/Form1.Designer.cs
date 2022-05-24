namespace CompatibilityChecker
{
    partial class Form1
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
            this.database1DataSet = new CompatibilityChecker.Database1DataSet();
            this.harnessdrawingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.harness_drawingTableAdapter = new CompatibilityChecker.Database1DataSetTableAdapters.Harness_drawingTableAdapter();
            this.harnessdrawingBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.harnesswiresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.harness_wiresTableAdapter = new CompatibilityChecker.Database1DataSetTableAdapters.Harness_wiresTableAdapter();
            this.harnessdrawingBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.harnesswiresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Generuoti = new System.Windows.Forms.Button();
            this.tableAdapterManager = new CompatibilityChecker.Database1DataSetTableAdapters.TableAdapterManager();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.harnessdrawingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.harnessdrawingBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.harnesswiresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.harnessdrawingBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.harnesswiresBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1393, 570);
            this.dataGridView1.TabIndex = 0;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // harnessdrawingBindingSource
            // 
            this.harnessdrawingBindingSource.DataMember = "Harness_drawing";
            this.harnessdrawingBindingSource.DataSource = this.database1DataSet;
            // 
            // harness_drawingTableAdapter
            // 
            this.harness_drawingTableAdapter.ClearBeforeFill = true;
            // 
            // harnessdrawingBindingSource1
            // 
            this.harnessdrawingBindingSource1.DataMember = "Harness_drawing";
            this.harnessdrawingBindingSource1.DataSource = this.database1DataSet;
            // 
            // harnesswiresBindingSource
            // 
            this.harnesswiresBindingSource.DataMember = "Harness_wires";
            this.harnesswiresBindingSource.DataSource = this.database1DataSet;
            // 
            // harness_wiresTableAdapter
            // 
            this.harness_wiresTableAdapter.ClearBeforeFill = true;
            // 
            // harnessdrawingBindingSource2
            // 
            this.harnessdrawingBindingSource2.DataMember = "Harness_drawing";
            this.harnessdrawingBindingSource2.DataSource = this.database1DataSet;
            // 
            // harnesswiresBindingSource1
            // 
            this.harnesswiresBindingSource1.DataMember = "Harness_wires";
            this.harnesswiresBindingSource1.DataSource = this.database1DataSet;
            // 
            // Generuoti
            // 
            this.Generuoti.Location = new System.Drawing.Point(12, 12);
            this.Generuoti.Name = "Generuoti";
            this.Generuoti.Size = new System.Drawing.Size(143, 23);
            this.Generuoti.TabIndex = 1;
            this.Generuoti.Text = "Generuoti";
            this.Generuoti.UseVisualStyleBackColor = true;
            this.Generuoti.Click += new System.EventHandler(this.Generuoti_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Harness_drawingTableAdapter = this.harness_drawingTableAdapter;
            this.tableAdapterManager.Harness_wiresTableAdapter = this.harness_wiresTableAdapter;
            this.tableAdapterManager.UpdateOrder = CompatibilityChecker.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(161, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1244, 23);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 623);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Generuoti);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.harnessdrawingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.harnessdrawingBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.harnesswiresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.harnessdrawingBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.harnesswiresBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource harnessdrawingBindingSource;
        private Database1DataSetTableAdapters.Harness_drawingTableAdapter harness_drawingTableAdapter;
        private System.Windows.Forms.BindingSource harnessdrawingBindingSource1;
        private System.Windows.Forms.BindingSource harnesswiresBindingSource;
        private Database1DataSetTableAdapters.Harness_wiresTableAdapter harness_wiresTableAdapter;
        private System.Windows.Forms.BindingSource harnessdrawingBindingSource2;
        private System.Windows.Forms.BindingSource harnesswiresBindingSource1;
        private System.Windows.Forms.Button Generuoti;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox textBox1;
    }
}

