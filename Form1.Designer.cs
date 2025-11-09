namespace lab6kpp
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
            this.A_matrix_dgv = new System.Windows.Forms.DataGridView();
            this.B_vector_dgv = new System.Windows.Forms.DataGridView();
            this.X_vector_dgv = new System.Windows.Forms.DataGridView();
            this.C_matrix_dgv = new System.Windows.Forms.DataGridView();
            this.NUD_rozmir = new System.Windows.Forms.NumericUpDown();
            this.BСreateGrid = new System.Windows.Forms.Button();
            this.BClear = new System.Windows.Forms.Button();
            this.BClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.A_matrix_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_vector_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X_vector_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C_matrix_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_rozmir)).BeginInit();
            this.SuspendLayout();
            // 
            // A_matrix_dgv
            // 
            this.A_matrix_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.A_matrix_dgv.ColumnHeadersVisible = false;
            this.A_matrix_dgv.Location = new System.Drawing.Point(28, 88);
            this.A_matrix_dgv.Name = "A_matrix_dgv";
            this.A_matrix_dgv.RowHeadersVisible = false;
            this.A_matrix_dgv.RowHeadersWidth = 25;
            this.A_matrix_dgv.RowTemplate.Height = 24;
            this.A_matrix_dgv.Size = new System.Drawing.Size(540, 240);
            this.A_matrix_dgv.TabIndex = 0;
            this.A_matrix_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.A_matrix_dgv_CellClick);
            // 
            // B_vector_dgv
            // 
            this.B_vector_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.B_vector_dgv.ColumnHeadersVisible = false;
            this.B_vector_dgv.Location = new System.Drawing.Point(650, 88);
            this.B_vector_dgv.Name = "B_vector_dgv";
            this.B_vector_dgv.RowHeadersVisible = false;
            this.B_vector_dgv.RowHeadersWidth = 51;
            this.B_vector_dgv.RowTemplate.Height = 24;
            this.B_vector_dgv.Size = new System.Drawing.Size(99, 188);
            this.B_vector_dgv.TabIndex = 1;
            this.B_vector_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.B_vector_dgv_CellClick);
            // 
            // X_vector_dgv
            // 
            this.X_vector_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.X_vector_dgv.ColumnHeadersVisible = false;
            this.X_vector_dgv.Location = new System.Drawing.Point(783, 88);
            this.X_vector_dgv.Name = "X_vector_dgv";
            this.X_vector_dgv.ReadOnly = true;
            this.X_vector_dgv.RowHeadersVisible = false;
            this.X_vector_dgv.RowHeadersWidth = 51;
            this.X_vector_dgv.RowTemplate.Height = 24;
            this.X_vector_dgv.Size = new System.Drawing.Size(99, 188);
            this.X_vector_dgv.TabIndex = 2;
            // 
            // C_matrix_dgv
            // 
            this.C_matrix_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.C_matrix_dgv.ColumnHeadersVisible = false;
            this.C_matrix_dgv.Location = new System.Drawing.Point(28, 369);
            this.C_matrix_dgv.Name = "C_matrix_dgv";
            this.C_matrix_dgv.RowHeadersVisible = false;
            this.C_matrix_dgv.RowHeadersWidth = 51;
            this.C_matrix_dgv.RowTemplate.Height = 24;
            this.C_matrix_dgv.Size = new System.Drawing.Size(540, 240);
            this.C_matrix_dgv.TabIndex = 3;
            // 
            // NUD_rozmir
            // 
            this.NUD_rozmir.Location = new System.Drawing.Point(255, 22);
            this.NUD_rozmir.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NUD_rozmir.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_rozmir.Name = "NUD_rozmir";
            this.NUD_rozmir.ReadOnly = true;
            this.NUD_rozmir.Size = new System.Drawing.Size(120, 22);
            this.NUD_rozmir.TabIndex = 4;
            this.NUD_rozmir.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NUD_rozmir.ValueChanged += new System.EventHandler(this.NUD_rozmir_ValueChanged);
            // 
            // BСreateGrid
            // 
            this.BСreateGrid.Location = new System.Drawing.Point(650, 305);
            this.BСreateGrid.Name = "BСreateGrid";
            this.BСreateGrid.Size = new System.Drawing.Size(99, 23);
            this.BСreateGrid.TabIndex = 5;
            this.BСreateGrid.Text = "Розв\'язати";
            this.BСreateGrid.UseVisualStyleBackColor = true;
            this.BСreateGrid.Click += new System.EventHandler(this.BСreateGrid_Click);
            // 
            // BClear
            // 
            this.BClear.Location = new System.Drawing.Point(783, 305);
            this.BClear.Name = "BClear";
            this.BClear.Size = new System.Drawing.Size(99, 23);
            this.BClear.TabIndex = 6;
            this.BClear.Text = "Очистити";
            this.BClear.UseVisualStyleBackColor = true;
            this.BClear.Click += new System.EventHandler(this.BClear_Click);
            // 
            // BClose
            // 
            this.BClose.Location = new System.Drawing.Point(716, 357);
            this.BClose.Name = "BClose";
            this.BClose.Size = new System.Drawing.Size(99, 23);
            this.BClose.TabIndex = 7;
            this.BClose.Text = "Вихід";
            this.BClose.UseVisualStyleBackColor = true;
            this.BClose.Click += new System.EventHandler(this.BClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Оберіть розмір матриці A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Матриця коефіцієнтів A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(647, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Вектор B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(780, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Вектор X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Матриця C LU-розкладу";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "LU",
            "Гаус"});
            this.comboBox1.Location = new System.Drawing.Point(583, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(505, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Метод";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 621);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BClose);
            this.Controls.Add(this.BClear);
            this.Controls.Add(this.BСreateGrid);
            this.Controls.Add(this.NUD_rozmir);
            this.Controls.Add(this.C_matrix_dgv);
            this.Controls.Add(this.X_vector_dgv);
            this.Controls.Add(this.B_vector_dgv);
            this.Controls.Add(this.A_matrix_dgv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.A_matrix_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_vector_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X_vector_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C_matrix_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_rozmir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView A_matrix_dgv;
        private System.Windows.Forms.DataGridView B_vector_dgv;
        private System.Windows.Forms.DataGridView X_vector_dgv;
        private System.Windows.Forms.DataGridView C_matrix_dgv;
        private System.Windows.Forms.NumericUpDown NUD_rozmir;
        private System.Windows.Forms.Button BСreateGrid;
        private System.Windows.Forms.Button BClear;
        private System.Windows.Forms.Button BClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
    }
}

