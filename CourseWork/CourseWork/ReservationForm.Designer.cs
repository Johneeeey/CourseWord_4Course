namespace CourseWork
{
    partial class ReservationForm
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
            this.labelReservNum = new System.Windows.Forms.Label();
            this.textBoxReservNum = new System.Windows.Forms.TextBox();
            this.textBoxClientFname = new System.Windows.Forms.TextBox();
            this.labelClientFname = new System.Windows.Forms.Label();
            this.textBoxClientLname = new System.Windows.Forms.TextBox();
            this.labelLname = new System.Windows.Forms.Label();
            this.labelClientPhone = new System.Windows.Forms.Label();
            this.textBoxClientPhone = new System.Windows.Forms.TextBox();
            this.textBoxReservTime = new System.Windows.Forms.TextBox();
            this.labelReservTime = new System.Windows.Forms.Label();
            this.textBoxReservDate = new System.Windows.Forms.TextBox();
            this.labelReservDate = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelReservNum
            // 
            this.labelReservNum.AutoSize = true;
            this.labelReservNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelReservNum.Location = new System.Drawing.Point(13, 13);
            this.labelReservNum.Name = "labelReservNum";
            this.labelReservNum.Size = new System.Drawing.Size(194, 20);
            this.labelReservNum.TabIndex = 0;
            this.labelReservNum.Text = "Номер бронирования:";
            // 
            // textBoxReservNum
            // 
            this.textBoxReservNum.Location = new System.Drawing.Point(214, 12);
            this.textBoxReservNum.Name = "textBoxReservNum";
            this.textBoxReservNum.Size = new System.Drawing.Size(100, 20);
            this.textBoxReservNum.TabIndex = 1;
            this.textBoxReservNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxReservNum_KeyPress);
            // 
            // textBoxClientFname
            // 
            this.textBoxClientFname.Location = new System.Drawing.Point(135, 46);
            this.textBoxClientFname.Name = "textBoxClientFname";
            this.textBoxClientFname.Size = new System.Drawing.Size(179, 20);
            this.textBoxClientFname.TabIndex = 3;
            // 
            // labelClientFname
            // 
            this.labelClientFname.AutoSize = true;
            this.labelClientFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClientFname.Location = new System.Drawing.Point(13, 46);
            this.labelClientFname.Name = "labelClientFname";
            this.labelClientFname.Size = new System.Drawing.Size(121, 20);
            this.labelClientFname.TabIndex = 2;
            this.labelClientFname.Text = "Имя клиента:";
            // 
            // textBoxClientLname
            // 
            this.textBoxClientLname.Location = new System.Drawing.Point(492, 48);
            this.textBoxClientLname.Name = "textBoxClientLname";
            this.textBoxClientLname.Size = new System.Drawing.Size(208, 20);
            this.textBoxClientLname.TabIndex = 5;
            // 
            // labelLname
            // 
            this.labelLname.AutoSize = true;
            this.labelLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLname.Location = new System.Drawing.Point(320, 46);
            this.labelLname.Name = "labelLname";
            this.labelLname.Size = new System.Drawing.Size(166, 20);
            this.labelLname.TabIndex = 4;
            this.labelLname.Text = "Фамилия клиента:";
            // 
            // labelClientPhone
            // 
            this.labelClientPhone.AutoSize = true;
            this.labelClientPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClientPhone.Location = new System.Drawing.Point(12, 82);
            this.labelClientPhone.Name = "labelClientPhone";
            this.labelClientPhone.Size = new System.Drawing.Size(234, 20);
            this.labelClientPhone.TabIndex = 6;
            this.labelClientPhone.Text = "Номер телефона клиента:";
            // 
            // textBoxClientPhone
            // 
            this.textBoxClientPhone.Location = new System.Drawing.Point(252, 82);
            this.textBoxClientPhone.Name = "textBoxClientPhone";
            this.textBoxClientPhone.Size = new System.Drawing.Size(179, 20);
            this.textBoxClientPhone.TabIndex = 7;
            this.textBoxClientPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxReservNum_KeyPress);
            // 
            // textBoxReservTime
            // 
            this.textBoxReservTime.Location = new System.Drawing.Point(214, 116);
            this.textBoxReservTime.Name = "textBoxReservTime";
            this.textBoxReservTime.Size = new System.Drawing.Size(100, 20);
            this.textBoxReservTime.TabIndex = 9;
            // 
            // labelReservTime
            // 
            this.labelReservTime.AutoSize = true;
            this.labelReservTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelReservTime.Location = new System.Drawing.Point(13, 117);
            this.labelReservTime.Name = "labelReservTime";
            this.labelReservTime.Size = new System.Drawing.Size(193, 20);
            this.labelReservTime.TabIndex = 8;
            this.labelReservTime.Text = "Время бронирования:";
            // 
            // textBoxReservDate
            // 
            this.textBoxReservDate.Location = new System.Drawing.Point(532, 116);
            this.textBoxReservDate.Name = "textBoxReservDate";
            this.textBoxReservDate.Size = new System.Drawing.Size(100, 20);
            this.textBoxReservDate.TabIndex = 11;
            // 
            // labelReservDate
            // 
            this.labelReservDate.AutoSize = true;
            this.labelReservDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelReservDate.Location = new System.Drawing.Point(331, 117);
            this.labelReservDate.Name = "labelReservDate";
            this.labelReservDate.Size = new System.Drawing.Size(182, 20);
            this.labelReservDate.TabIndex = 10;
            this.labelReservDate.Text = "Дата бронирования:";
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(147, 156);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(121, 35);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemove.Location = new System.Drawing.Point(310, 156);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(121, 35);
            this.buttonRemove.TabIndex = 13;
            this.buttonRemove.Text = "Удалить";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 200);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxReservDate);
            this.Controls.Add(this.labelReservDate);
            this.Controls.Add(this.textBoxReservTime);
            this.Controls.Add(this.labelReservTime);
            this.Controls.Add(this.textBoxClientPhone);
            this.Controls.Add(this.labelClientPhone);
            this.Controls.Add(this.textBoxClientLname);
            this.Controls.Add(this.labelLname);
            this.Controls.Add(this.textBoxClientFname);
            this.Controls.Add(this.labelClientFname);
            this.Controls.Add(this.textBoxReservNum);
            this.Controls.Add(this.labelReservNum);
            this.Name = "ReservationForm";
            this.Text = "Бронирование";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelReservNum;
        private System.Windows.Forms.TextBox textBoxReservNum;
        private System.Windows.Forms.TextBox textBoxClientFname;
        private System.Windows.Forms.Label labelClientFname;
        private System.Windows.Forms.TextBox textBoxClientLname;
        private System.Windows.Forms.Label labelLname;
        private System.Windows.Forms.Label labelClientPhone;
        private System.Windows.Forms.TextBox textBoxClientPhone;
        private System.Windows.Forms.TextBox textBoxReservTime;
        private System.Windows.Forms.Label labelReservTime;
        private System.Windows.Forms.TextBox textBoxReservDate;
        private System.Windows.Forms.Label labelReservDate;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonRemove;
    }
}