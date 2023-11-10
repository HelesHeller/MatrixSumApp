namespace MatrixSumApp
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
            comboBoxMatrixSize = new ComboBox();
            dataGridViewMatrixA = new DataGridView();
            buttonCalculate = new Button();
            dataGridViewMatrixB = new DataGridView();
            dataGridViewResult = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrixA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrixB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).BeginInit();
            SuspendLayout();
            // 
            // comboBoxMatrixSize
            // 
            comboBoxMatrixSize.FormattingEnabled = true;
            comboBoxMatrixSize.Location = new Point(53, 356);
            comboBoxMatrixSize.Name = "comboBoxMatrixSize";
            comboBoxMatrixSize.Size = new Size(40, 23);
            comboBoxMatrixSize.TabIndex = 0;
            // 
            // dataGridViewMatrixA
            // 
            dataGridViewMatrixA.AllowUserToOrderColumns = true;
            dataGridViewMatrixA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrixA.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridViewMatrixA.Location = new Point(37, 23);
            dataGridViewMatrixA.Name = "dataGridViewMatrixA";
            dataGridViewMatrixA.RowTemplate.Height = 25;
            dataGridViewMatrixA.Size = new Size(343, 150);
            dataGridViewMatrixA.TabIndex = 1;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(364, 532);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(75, 23);
            buttonCalculate.TabIndex = 2;
            buttonCalculate.Text = "Calculate";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // dataGridViewMatrixB
            // 
            dataGridViewMatrixB.AllowUserToOrderColumns = true;
            dataGridViewMatrixB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrixB.Columns.AddRange(new DataGridViewColumn[] { Column4, Column5, Column6 });
            dataGridViewMatrixB.Location = new Point(433, 23);
            dataGridViewMatrixB.Name = "dataGridViewMatrixB";
            dataGridViewMatrixB.RowTemplate.Height = 25;
            dataGridViewMatrixB.Size = new Size(342, 158);
            dataGridViewMatrixB.TabIndex = 3;
            // 
            // dataGridViewResult
            // 
            dataGridViewResult.AllowUserToOrderColumns = true;
            dataGridViewResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult.Columns.AddRange(new DataGridViewColumn[] { Column7, Column8, Column9 });
            dataGridViewResult.Location = new Point(277, 284);
            dataGridViewResult.Name = "dataGridViewResult";
            dataGridViewResult.RowTemplate.Height = 25;
            dataGridViewResult.Size = new Size(343, 150);
            dataGridViewResult.TabIndex = 4;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Column2";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Column3";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Column4";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Column5";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Column6";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Column7";
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.HeaderText = "Column8";
            Column8.Name = "Column8";
            // 
            // Column9
            // 
            Column9.HeaderText = "Column9";
            Column9.Name = "Column9";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 590);
            Controls.Add(dataGridViewResult);
            Controls.Add(dataGridViewMatrixB);
            Controls.Add(buttonCalculate);
            Controls.Add(dataGridViewMatrixA);
            Controls.Add(comboBoxMatrixSize);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrixA).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrixB).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxMatrixSize;
        private DataGridView dataGridViewMatrixA;
        private Button buttonCalculate;
        private DataGridView dataGridViewMatrixB;
        private DataGridView dataGridViewResult;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
    }
}