namespace CourseWork
{
    partial class MainForm
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewTables = new System.Windows.Forms.DataGridView();
            this.groupBoxTableInfoOnDate = new System.Windows.Forms.GroupBox();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTableNum = new System.Windows.Forms.Label();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.textBoxTableNum = new System.Windows.Forms.TextBox();
            this.groupBoxAmountReservation = new System.Windows.Forms.GroupBox();
            this.labelDateForAmount = new System.Windows.Forms.Label();
            this.textBoxDateForAmount = new System.Windows.Forms.TextBox();
            this.buttonShowAmount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTables)).BeginInit();
            this.groupBoxTableInfoOnDate.SuspendLayout();
            this.groupBoxAmountReservation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::CourseWork.Properties.Resources.Понорама;
            this.pictureBox.Location = new System.Drawing.Point(9, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(555, 170);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // labelSearch
            // 
            this.labelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSearch.Location = new System.Drawing.Point(13, 191);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(225, 18);
            this.labelSearch.TabIndex = 1;
            this.labelSearch.Text = "Введите номер нужного стола:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(245, 191);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(319, 20);
            this.textBoxSearch.TabIndex = 2;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // dataGridViewTables
            // 
            this.dataGridViewTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTables.Location = new System.Drawing.Point(9, 217);
            this.dataGridViewTables.Name = "dataGridViewTables";
            this.dataGridViewTables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTables.Size = new System.Drawing.Size(555, 238);
            this.dataGridViewTables.TabIndex = 4;
            this.dataGridViewTables.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewTables_CellMouseDoubleClick);
            // 
            // groupBoxTableInfoOnDate
            // 
            this.groupBoxTableInfoOnDate.Controls.Add(this.buttonInfo);
            this.groupBoxTableInfoOnDate.Controls.Add(this.labelDate);
            this.groupBoxTableInfoOnDate.Controls.Add(this.labelTableNum);
            this.groupBoxTableInfoOnDate.Controls.Add(this.textBoxDate);
            this.groupBoxTableInfoOnDate.Controls.Add(this.textBoxTableNum);
            this.groupBoxTableInfoOnDate.Location = new System.Drawing.Point(9, 461);
            this.groupBoxTableInfoOnDate.Name = "groupBoxTableInfoOnDate";
            this.groupBoxTableInfoOnDate.Size = new System.Drawing.Size(555, 79);
            this.groupBoxTableInfoOnDate.TabIndex = 5;
            this.groupBoxTableInfoOnDate.TabStop = false;
            this.groupBoxTableInfoOnDate.Text = "Поиск информации о столике по дате";
            // 
            // buttonInfo
            // 
            this.buttonInfo.Location = new System.Drawing.Point(225, 45);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(92, 28);
            this.buttonInfo.TabIndex = 4;
            this.buttonInfo.Text = "Посмотреть";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(255, 22);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(182, 13);
            this.labelDate.TabIndex = 3;
            this.labelDate.Text = "Введите дату (формат: \"dd.mm.yy\")";
            // 
            // labelTableNum
            // 
            this.labelTableNum.AutoSize = true;
            this.labelTableNum.Location = new System.Drawing.Point(6, 22);
            this.labelTableNum.Name = "labelTableNum";
            this.labelTableNum.Size = new System.Drawing.Size(128, 13);
            this.labelTableNum.TabIndex = 2;
            this.labelTableNum.Text = "Введите номер столика";
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(443, 19);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(100, 20);
            this.textBoxDate.TabIndex = 1;
            // 
            // textBoxTableNum
            // 
            this.textBoxTableNum.Location = new System.Drawing.Point(140, 19);
            this.textBoxTableNum.Name = "textBoxTableNum";
            this.textBoxTableNum.Size = new System.Drawing.Size(100, 20);
            this.textBoxTableNum.TabIndex = 0;
            this.textBoxTableNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTableNum_KeyPress);
            // 
            // groupBoxAmountReservation
            // 
            this.groupBoxAmountReservation.Controls.Add(this.buttonShowAmount);
            this.groupBoxAmountReservation.Controls.Add(this.labelDateForAmount);
            this.groupBoxAmountReservation.Controls.Add(this.textBoxDateForAmount);
            this.groupBoxAmountReservation.Location = new System.Drawing.Point(9, 546);
            this.groupBoxAmountReservation.Name = "groupBoxAmountReservation";
            this.groupBoxAmountReservation.Size = new System.Drawing.Size(555, 54);
            this.groupBoxAmountReservation.TabIndex = 6;
            this.groupBoxAmountReservation.TabStop = false;
            this.groupBoxAmountReservation.Text = "Сколько столиков забронировано n-ого числа";
            // 
            // labelDateForAmount
            // 
            this.labelDateForAmount.AutoSize = true;
            this.labelDateForAmount.Location = new System.Drawing.Point(16, 22);
            this.labelDateForAmount.Name = "labelDateForAmount";
            this.labelDateForAmount.Size = new System.Drawing.Size(182, 13);
            this.labelDateForAmount.TabIndex = 6;
            this.labelDateForAmount.Text = "Введите дату (формат: \"dd.mm.yy\")";
            // 
            // textBoxDateForAmount
            // 
            this.textBoxDateForAmount.Location = new System.Drawing.Point(204, 19);
            this.textBoxDateForAmount.Name = "textBoxDateForAmount";
            this.textBoxDateForAmount.Size = new System.Drawing.Size(100, 20);
            this.textBoxDateForAmount.TabIndex = 5;
            // 
            // buttonShowAmount
            // 
            this.buttonShowAmount.Location = new System.Drawing.Point(443, 14);
            this.buttonShowAmount.Name = "buttonShowAmount";
            this.buttonShowAmount.Size = new System.Drawing.Size(92, 28);
            this.buttonShowAmount.TabIndex = 5;
            this.buttonShowAmount.Text = "Посмотреть";
            this.buttonShowAmount.UseVisualStyleBackColor = true;
            this.buttonShowAmount.Click += new System.EventHandler(this.buttonShowAmount_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 612);
            this.Controls.Add(this.groupBoxAmountReservation);
            this.Controls.Add(this.groupBoxTableInfoOnDate);
            this.Controls.Add(this.dataGridViewTables);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.pictureBox);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTables)).EndInit();
            this.groupBoxTableInfoOnDate.ResumeLayout(false);
            this.groupBoxTableInfoOnDate.PerformLayout();
            this.groupBoxAmountReservation.ResumeLayout(false);
            this.groupBoxAmountReservation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.DataGridView dataGridViewTables;
        private System.Windows.Forms.GroupBox groupBoxTableInfoOnDate;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTableNum;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.TextBox textBoxTableNum;
        private System.Windows.Forms.GroupBox groupBoxAmountReservation;
        private System.Windows.Forms.Button buttonShowAmount;
        private System.Windows.Forms.Label labelDateForAmount;
        private System.Windows.Forms.TextBox textBoxDateForAmount;
    }
}