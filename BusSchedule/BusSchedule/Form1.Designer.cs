namespace BusSchedule
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idStopsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estimatedArrivalTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPaymentFormDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDirectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.busScheduleDataSet = new BusSchedule.BusScheduleDataSet();
            this.scheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new BusSchedule.DataSet1();
            this.routerTableAdapter = new BusSchedule.BusScheduleDataSetTableAdapters.RouterTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.scheduleTableAdapter = new BusSchedule.DataSet1TableAdapters.ScheduleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busScheduleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.idStopsDataGridViewTextBoxColumn,
            this.estimatedArrivalTimeDataGridViewTextBoxColumn,
            this.idPaymentFormDataGridViewTextBoxColumn,
            this.idDirectionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.routerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // idStopsDataGridViewTextBoxColumn
            // 
            this.idStopsDataGridViewTextBoxColumn.DataPropertyName = "IdStops";
            this.idStopsDataGridViewTextBoxColumn.HeaderText = "IdStops";
            this.idStopsDataGridViewTextBoxColumn.Name = "idStopsDataGridViewTextBoxColumn";
            // 
            // estimatedArrivalTimeDataGridViewTextBoxColumn
            // 
            this.estimatedArrivalTimeDataGridViewTextBoxColumn.DataPropertyName = "EstimatedArrivalTime";
            this.estimatedArrivalTimeDataGridViewTextBoxColumn.HeaderText = "EstimatedArrivalTime";
            this.estimatedArrivalTimeDataGridViewTextBoxColumn.Name = "estimatedArrivalTimeDataGridViewTextBoxColumn";
            // 
            // idPaymentFormDataGridViewTextBoxColumn
            // 
            this.idPaymentFormDataGridViewTextBoxColumn.DataPropertyName = "IdPaymentForm";
            this.idPaymentFormDataGridViewTextBoxColumn.HeaderText = "IdPaymentForm";
            this.idPaymentFormDataGridViewTextBoxColumn.Name = "idPaymentFormDataGridViewTextBoxColumn";
            // 
            // idDirectionDataGridViewTextBoxColumn
            // 
            this.idDirectionDataGridViewTextBoxColumn.DataPropertyName = "IdDirection";
            this.idDirectionDataGridViewTextBoxColumn.HeaderText = "IdDirection";
            this.idDirectionDataGridViewTextBoxColumn.Name = "idDirectionDataGridViewTextBoxColumn";
            // 
            // routerBindingSource
            // 
            this.routerBindingSource.DataMember = "Router";
            this.routerBindingSource.DataSource = this.busScheduleDataSet;
            // 
            // busScheduleDataSet
            // 
            this.busScheduleDataSet.DataSetName = "BusScheduleDataSet";
            this.busScheduleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scheduleBindingSource
            // 
            this.scheduleBindingSource.DataMember = "Schedule";
            this.scheduleBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // routerTableAdapter
            // 
            this.routerTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(662, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Далее =>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.nextClick);
            // 
            // scheduleTableAdapter
            // 
            this.scheduleTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busScheduleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private BusScheduleDataSet busScheduleDataSet;
        private System.Windows.Forms.BindingSource routerBindingSource;
        private BusScheduleDataSetTableAdapters.RouterTableAdapter routerTableAdapter;
        private System.Windows.Forms.Button button1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource scheduleBindingSource;
        private DataSet1TableAdapters.ScheduleTableAdapter scheduleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStopsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estimatedArrivalTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPaymentFormDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDirectionDataGridViewTextBoxColumn;
    }
}

