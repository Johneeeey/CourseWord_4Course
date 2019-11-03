namespace CourseWork
{
    partial class DetailsForm
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
            this.TableNumLabel = new System.Windows.Forms.Label();
            this.TableNumTextBox = new System.Windows.Forms.TextBox();
            this.PlaceCountLabel = new System.Windows.Forms.Label();
            this.PlaceCountTextBox = new System.Windows.Forms.TextBox();
            this.TableColorLabel = new System.Windows.Forms.Label();
            this.TableFormLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.comboBoxForm = new System.Windows.Forms.ComboBox();
            this.comboBoxMaterial = new System.Windows.Forms.ComboBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxOwnerName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TableNumLabel
            // 
            this.TableNumLabel.AutoSize = true;
            this.TableNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TableNumLabel.Location = new System.Drawing.Point(13, 13);
            this.TableNumLabel.Name = "TableNumLabel";
            this.TableNumLabel.Size = new System.Drawing.Size(129, 20);
            this.TableNumLabel.TabIndex = 0;
            this.TableNumLabel.Text = "Номер столика:";
            // 
            // TableNumTextBox
            // 
            this.TableNumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TableNumTextBox.Location = new System.Drawing.Point(148, 8);
            this.TableNumTextBox.Name = "TableNumTextBox";
            this.TableNumTextBox.ReadOnly = true;
            this.TableNumTextBox.Size = new System.Drawing.Size(100, 24);
            this.TableNumTextBox.TabIndex = 1;
            // 
            // PlaceCountLabel
            // 
            this.PlaceCountLabel.AutoSize = true;
            this.PlaceCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlaceCountLabel.Location = new System.Drawing.Point(255, 13);
            this.PlaceCountLabel.Name = "PlaceCountLabel";
            this.PlaceCountLabel.Size = new System.Drawing.Size(145, 20);
            this.PlaceCountLabel.TabIndex = 2;
            this.PlaceCountLabel.Text = "Количество мест:";
            // 
            // PlaceCountTextBox
            // 
            this.PlaceCountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlaceCountTextBox.Location = new System.Drawing.Point(406, 8);
            this.PlaceCountTextBox.Name = "PlaceCountTextBox";
            this.PlaceCountTextBox.Size = new System.Drawing.Size(100, 24);
            this.PlaceCountTextBox.TabIndex = 3;
            this.PlaceCountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PlaceCountTextBox_KeyPress);
            // 
            // TableColorLabel
            // 
            this.TableColorLabel.AutoSize = true;
            this.TableColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TableColorLabel.Location = new System.Drawing.Point(13, 53);
            this.TableColorLabel.Name = "TableColorLabel";
            this.TableColorLabel.Size = new System.Drawing.Size(52, 20);
            this.TableColorLabel.TabIndex = 4;
            this.TableColorLabel.Text = "Цвет:";
            // 
            // TableFormLabel
            // 
            this.TableFormLabel.AutoSize = true;
            this.TableFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TableFormLabel.Location = new System.Drawing.Point(222, 53);
            this.TableFormLabel.Name = "TableFormLabel";
            this.TableFormLabel.Size = new System.Drawing.Size(66, 20);
            this.TableFormLabel.TabIndex = 6;
            this.TableFormLabel.Text = "Форма:";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusLabel.Location = new System.Drawing.Point(305, 90);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(66, 20);
            this.StatusLabel.TabIndex = 8;
            this.StatusLabel.Text = "Статус:";
            // 
            // ButtonSave
            // 
            this.ButtonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSave.Location = new System.Drawing.Point(12, 175);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(135, 35);
            this.ButtonSave.TabIndex = 10;
            this.ButtonSave.Text = "Сохранить";
            this.ButtonSave.UseVisualStyleBackColor = true;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemove.Location = new System.Drawing.Point(153, 175);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(135, 35);
            this.buttonRemove.TabIndex = 11;
            this.buttonRemove.Text = "Удалить";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Материал:";
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Items.AddRange(new object[] {
            "Красный",
            "Коричневый",
            "Белый",
            "Желтый",
            "Зеленый"});
            this.comboBoxColor.Location = new System.Drawing.Point(72, 51);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(142, 24);
            this.comboBoxColor.TabIndex = 14;
            // 
            // comboBoxForm
            // 
            this.comboBoxForm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxForm.FormattingEnabled = true;
            this.comboBoxForm.Items.AddRange(new object[] {
            "Квадрат",
            "Кргу",
            "Овал"});
            this.comboBoxForm.Location = new System.Drawing.Point(295, 51);
            this.comboBoxForm.Name = "comboBoxForm";
            this.comboBoxForm.Size = new System.Drawing.Size(145, 24);
            this.comboBoxForm.TabIndex = 15;
            // 
            // comboBoxMaterial
            // 
            this.comboBoxMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxMaterial.FormattingEnabled = true;
            this.comboBoxMaterial.Items.AddRange(new object[] {
            "Дерево",
            "Дерево/Металл",
            "Пластик/Металл"});
            this.comboBoxMaterial.Location = new System.Drawing.Point(110, 88);
            this.comboBoxMaterial.Name = "comboBoxMaterial";
            this.comboBoxMaterial.Size = new System.Drawing.Size(189, 24);
            this.comboBoxMaterial.TabIndex = 16;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Свободен",
            "Занят"});
            this.comboBoxStatus.Location = new System.Drawing.Point(378, 88);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(128, 24);
            this.comboBoxStatus.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Клиет:";
            // 
            // textBoxOwnerName
            // 
            this.textBoxOwnerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxOwnerName.Location = new System.Drawing.Point(80, 127);
            this.textBoxOwnerName.Name = "textBoxOwnerName";
            this.textBoxOwnerName.Size = new System.Drawing.Size(219, 22);
            this.textBoxOwnerName.TabIndex = 19;
            // 
            // DetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 222);
            this.Controls.Add(this.textBoxOwnerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.comboBoxMaterial);
            this.Controls.Add(this.comboBoxForm);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.TableFormLabel);
            this.Controls.Add(this.TableColorLabel);
            this.Controls.Add(this.PlaceCountTextBox);
            this.Controls.Add(this.PlaceCountLabel);
            this.Controls.Add(this.TableNumTextBox);
            this.Controls.Add(this.TableNumLabel);
            this.Name = "DetailsForm";
            this.Text = "Информация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TableNumLabel;
        private System.Windows.Forms.TextBox TableNumTextBox;
        private System.Windows.Forms.Label PlaceCountLabel;
        private System.Windows.Forms.TextBox PlaceCountTextBox;
        private System.Windows.Forms.Label TableColorLabel;
        private System.Windows.Forms.Label TableFormLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.ComboBox comboBoxForm;
        private System.Windows.Forms.ComboBox comboBoxMaterial;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxOwnerName;
    }
}