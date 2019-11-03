namespace CourseWork
{
    partial class SecondaryForm
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
            this.labelTableNum = new System.Windows.Forms.Label();
            this.textBoxTableNum = new System.Windows.Forms.TextBox();
            this.labelNumOfSeats = new System.Windows.Forms.Label();
            this.textBoxNumOfSeats = new System.Windows.Forms.TextBox();
            this.labelColor = new System.Windows.Forms.Label();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.labelFormFactor = new System.Windows.Forms.Label();
            this.comboBoxFormFactor = new System.Windows.Forms.ComboBox();
            this.labelMaterial = new System.Windows.Forms.Label();
            this.comboBoxMaterial = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonReserve = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.dataGridViewReservations = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservations)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTableNum
            // 
            this.labelTableNum.AutoSize = true;
            this.labelTableNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTableNum.Location = new System.Drawing.Point(13, 13);
            this.labelTableNum.Name = "labelTableNum";
            this.labelTableNum.Size = new System.Drawing.Size(142, 20);
            this.labelTableNum.TabIndex = 0;
            this.labelTableNum.Text = "Номер столика:";
            // 
            // textBoxTableNum
            // 
            this.textBoxTableNum.Location = new System.Drawing.Point(162, 12);
            this.textBoxTableNum.Name = "textBoxTableNum";
            this.textBoxTableNum.Size = new System.Drawing.Size(100, 20);
            this.textBoxTableNum.TabIndex = 1;
            this.textBoxTableNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTableNum_KeyPress);
            // 
            // labelNumOfSeats
            // 
            this.labelNumOfSeats.AutoSize = true;
            this.labelNumOfSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumOfSeats.Location = new System.Drawing.Point(278, 13);
            this.labelNumOfSeats.Name = "labelNumOfSeats";
            this.labelNumOfSeats.Size = new System.Drawing.Size(160, 20);
            this.labelNumOfSeats.TabIndex = 2;
            this.labelNumOfSeats.Text = "Количество мест:";
            // 
            // textBoxNumOfSeats
            // 
            this.textBoxNumOfSeats.Location = new System.Drawing.Point(445, 12);
            this.textBoxNumOfSeats.Name = "textBoxNumOfSeats";
            this.textBoxNumOfSeats.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumOfSeats.TabIndex = 3;
            this.textBoxNumOfSeats.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTableNum_KeyPress);
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelColor.Location = new System.Drawing.Point(13, 59);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(57, 20);
            this.labelColor.TabIndex = 4;
            this.labelColor.Text = "Цвет:";
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Location = new System.Drawing.Point(72, 57);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(121, 21);
            this.comboBoxColor.TabIndex = 5;
            // 
            // labelFormFactor
            // 
            this.labelFormFactor.AutoSize = true;
            this.labelFormFactor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFormFactor.Location = new System.Drawing.Point(215, 59);
            this.labelFormFactor.Name = "labelFormFactor";
            this.labelFormFactor.Size = new System.Drawing.Size(72, 20);
            this.labelFormFactor.TabIndex = 6;
            this.labelFormFactor.Text = "Форма:";
            // 
            // comboBoxFormFactor
            // 
            this.comboBoxFormFactor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFormFactor.FormattingEnabled = true;
            this.comboBoxFormFactor.Location = new System.Drawing.Point(293, 58);
            this.comboBoxFormFactor.Name = "comboBoxFormFactor";
            this.comboBoxFormFactor.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFormFactor.TabIndex = 7;
            // 
            // labelMaterial
            // 
            this.labelMaterial.AutoSize = true;
            this.labelMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaterial.Location = new System.Drawing.Point(13, 102);
            this.labelMaterial.Name = "labelMaterial";
            this.labelMaterial.Size = new System.Drawing.Size(98, 20);
            this.labelMaterial.TabIndex = 8;
            this.labelMaterial.Text = "Материал:";
            // 
            // comboBoxMaterial
            // 
            this.comboBoxMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaterial.FormattingEnabled = true;
            this.comboBoxMaterial.Location = new System.Drawing.Point(117, 101);
            this.comboBoxMaterial.Name = "comboBoxMaterial";
            this.comboBoxMaterial.Size = new System.Drawing.Size(242, 21);
            this.comboBoxMaterial.TabIndex = 9;
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(72, 320);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(94, 32);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonReserve
            // 
            this.buttonReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReserve.Location = new System.Drawing.Point(172, 320);
            this.buttonReserve.Name = "buttonReserve";
            this.buttonReserve.Size = new System.Drawing.Size(119, 32);
            this.buttonReserve.TabIndex = 13;
            this.buttonReserve.Text = "Забронировать";
            this.buttonReserve.UseVisualStyleBackColor = true;
            this.buttonReserve.Click += new System.EventHandler(this.buttonReserve_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(552, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(166, 110);
            this.pictureBox.TabIndex = 15;
            this.pictureBox.TabStop = false;
            // 
            // dataGridViewReservations
            // 
            this.dataGridViewReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReservations.Location = new System.Drawing.Point(72, 139);
            this.dataGridViewReservations.Name = "dataGridViewReservations";
            this.dataGridViewReservations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewReservations.Size = new System.Drawing.Size(646, 175);
            this.dataGridViewReservations.TabIndex = 16;
            this.dataGridViewReservations.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewReservations_CellMouseDoubleClick);
            // 
            // SecondaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 358);
            this.Controls.Add(this.dataGridViewReservations);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.buttonReserve);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.comboBoxMaterial);
            this.Controls.Add(this.labelMaterial);
            this.Controls.Add(this.comboBoxFormFactor);
            this.Controls.Add(this.labelFormFactor);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.textBoxNumOfSeats);
            this.Controls.Add(this.labelNumOfSeats);
            this.Controls.Add(this.textBoxTableNum);
            this.Controls.Add(this.labelTableNum);
            this.Name = "SecondaryForm";
            this.Text = "SecondaryForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTableNum;
        private System.Windows.Forms.TextBox textBoxTableNum;
        private System.Windows.Forms.Label labelNumOfSeats;
        private System.Windows.Forms.TextBox textBoxNumOfSeats;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.Label labelFormFactor;
        private System.Windows.Forms.ComboBox comboBoxFormFactor;
        private System.Windows.Forms.Label labelMaterial;
        private System.Windows.Forms.ComboBox comboBoxMaterial;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonReserve;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.DataGridView dataGridViewReservations;
    }
}