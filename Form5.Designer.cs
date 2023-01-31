namespace KyrsachOOP
{
    partial class Form5
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_date = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.operatorDataSet = new KyrsachOOP.OperatorDataSet();
            this.operatorDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.operatorDataSet1 = new KyrsachOOP.OperatorDataSet1();
            this.aboBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aboTableAdapter = new KyrsachOOP.OperatorDataSet1TableAdapters.aboTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.sotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sotTableAdapter = new KyrsachOOP.OperatorDataSetTableAdapters.sotTableAdapter();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.operatorDataSet2 = new KyrsachOOP.OperatorDataSet2();
            this.tariffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tariffTableAdapter = new KyrsachOOP.OperatorDataSet2TableAdapters.tariffTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.operatorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operatorDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operatorDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aboBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operatorDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tariffBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 359);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(233, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 39);
            this.label3.TabIndex = 23;
            this.label3.Text = "Заявка";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.comboBox3);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.textBox_date);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(161, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(259, 186);
            this.panel2.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Номер телефона:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "ID сотрудника:";
            // 
            // textBox_date
            // 
            this.textBox_date.Location = new System.Drawing.Point(117, 66);
            this.textBox_date.Name = "textBox_date";
            this.textBox_date.Size = new System.Drawing.Size(121, 20);
            this.textBox_date.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(75, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Дата:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(68, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Тариф:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(255, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.aboBindingSource;
            this.comboBox1.DisplayMember = "phone_number";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(117, 116);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.ValueMember = "phone_number";
            // 
            // operatorDataSet
            // 
            this.operatorDataSet.DataSetName = "OperatorDataSet";
            this.operatorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // operatorDataSetBindingSource
            // 
            this.operatorDataSetBindingSource.DataSource = this.operatorDataSet;
            this.operatorDataSetBindingSource.Position = 0;
            // 
            // operatorDataSet1
            // 
            this.operatorDataSet1.DataSetName = "OperatorDataSet1";
            this.operatorDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aboBindingSource
            // 
            this.aboBindingSource.DataMember = "abo";
            this.aboBindingSource.DataSource = this.operatorDataSet1;
            // 
            // aboTableAdapter
            // 
            this.aboTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.sotBindingSource;
            this.comboBox2.DisplayMember = "id_employee";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(117, 92);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 24;
            this.comboBox2.ValueMember = "id_employee";
            // 
            // sotBindingSource
            // 
            this.sotBindingSource.DataMember = "sot";
            this.sotBindingSource.DataSource = this.operatorDataSetBindingSource;
            // 
            // sotTableAdapter
            // 
            this.sotTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.tariffBindingSource;
            this.comboBox3.DisplayMember = "id_tariff";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(117, 39);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 25;
            this.comboBox3.ValueMember = "id_tariff";
            // 
            // operatorDataSet2
            // 
            this.operatorDataSet2.DataSetName = "OperatorDataSet2";
            this.operatorDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tariffBindingSource
            // 
            this.tariffBindingSource.DataMember = "tariff";
            this.tariffBindingSource.DataSource = this.operatorDataSet2;
            // 
            // tariffTableAdapter
            // 
            this.tariffTableAdapter.ClearBeforeFill = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.panel1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.operatorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operatorDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operatorDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aboBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operatorDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tariffBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_date;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox comboBox1;
        private OperatorDataSet operatorDataSet;
        private System.Windows.Forms.BindingSource operatorDataSetBindingSource;
        private OperatorDataSet1 operatorDataSet1;
        private System.Windows.Forms.BindingSource aboBindingSource;
        private OperatorDataSet1TableAdapters.aboTableAdapter aboTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource sotBindingSource;
        private OperatorDataSetTableAdapters.sotTableAdapter sotTableAdapter;
        private System.Windows.Forms.ComboBox comboBox3;
        private OperatorDataSet2 operatorDataSet2;
        private System.Windows.Forms.BindingSource tariffBindingSource;
        private OperatorDataSet2TableAdapters.tariffTableAdapter tariffTableAdapter;
    }
}