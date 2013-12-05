namespace Organizer
{
    partial class FormMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_calendar = new System.Windows.Forms.DataGridView();
            this.clMonday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTuesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clWednesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clThursaday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clFriday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSaturday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSunday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_month = new System.Windows.Forms.Label();
            this.pb_decreaseMonth = new System.Windows.Forms.PictureBox();
            this.pb_increaseMonth = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_calendar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_decreaseMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_increaseMonth)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_calendar
            // 
            this.dgv_calendar.AllowUserToAddRows = false;
            this.dgv_calendar.AllowUserToDeleteRows = false;
            this.dgv_calendar.AllowUserToResizeColumns = false;
            this.dgv_calendar.AllowUserToResizeRows = false;
            this.dgv_calendar.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_calendar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_calendar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_calendar.ColumnHeadersVisible = false;
            this.dgv_calendar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMonday,
            this.clTuesday,
            this.clWednesday,
            this.clThursaday,
            this.clFriday,
            this.clSaturday,
            this.clSunday});
            this.dgv_calendar.Location = new System.Drawing.Point(139, 77);
            this.dgv_calendar.Name = "dgv_calendar";
            this.dgv_calendar.ReadOnly = true;
            this.dgv_calendar.RowHeadersVisible = false;
            this.dgv_calendar.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgv_calendar.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(57)))), ((int)(((byte)(202)))));
            this.dgv_calendar.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(231)))), ((int)(((byte)(238)))));
            this.dgv_calendar.RowTemplate.Height = 40;
            this.dgv_calendar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_calendar.Size = new System.Drawing.Size(421, 241);
            this.dgv_calendar.TabIndex = 2;
            // 
            // clMonday
            // 
            this.clMonday.HeaderText = "";
            this.clMonday.Name = "clMonday";
            this.clMonday.ReadOnly = true;
            this.clMonday.Width = 60;
            // 
            // clTuesday
            // 
            this.clTuesday.HeaderText = "";
            this.clTuesday.Name = "clTuesday";
            this.clTuesday.ReadOnly = true;
            this.clTuesday.Width = 60;
            // 
            // clWednesday
            // 
            this.clWednesday.HeaderText = "";
            this.clWednesday.Name = "clWednesday";
            this.clWednesday.ReadOnly = true;
            this.clWednesday.Width = 60;
            // 
            // clThursaday
            // 
            this.clThursaday.HeaderText = "";
            this.clThursaday.Name = "clThursaday";
            this.clThursaday.ReadOnly = true;
            this.clThursaday.Width = 60;
            // 
            // clFriday
            // 
            this.clFriday.HeaderText = "";
            this.clFriday.Name = "clFriday";
            this.clFriday.ReadOnly = true;
            this.clFriday.Width = 60;
            // 
            // clSaturday
            // 
            this.clSaturday.HeaderText = "";
            this.clSaturday.Name = "clSaturday";
            this.clSaturday.ReadOnly = true;
            this.clSaturday.Width = 60;
            // 
            // clSunday
            // 
            this.clSunday.HeaderText = "";
            this.clSunday.Name = "clSunday";
            this.clSunday.ReadOnly = true;
            this.clSunday.Width = 60;
            // 
            // lb_month
            // 
            this.lb_month.AutoSize = true;
            this.lb_month.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_month.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(57)))), ((int)(((byte)(202)))));
            this.lb_month.Location = new System.Drawing.Point(288, 43);
            this.lb_month.Name = "lb_month";
            this.lb_month.Size = new System.Drawing.Size(118, 22);
            this.lb_month.TabIndex = 4;
            this.lb_month.Text = "Декабрь 2013";
            // 
            // pb_decreaseMonth
            // 
            this.pb_decreaseMonth.BackColor = System.Drawing.Color.Transparent;
            this.pb_decreaseMonth.Image = global::Organizer.Properties.Resources.left1;
            this.pb_decreaseMonth.Location = new System.Drawing.Point(139, 35);
            this.pb_decreaseMonth.Name = "pb_decreaseMonth";
            this.pb_decreaseMonth.Size = new System.Drawing.Size(36, 42);
            this.pb_decreaseMonth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_decreaseMonth.TabIndex = 6;
            this.pb_decreaseMonth.TabStop = false;
            this.pb_decreaseMonth.Click += new System.EventHandler(this.pb_decreaseMonth_Click);
            // 
            // pb_increaseMonth
            // 
            this.pb_increaseMonth.BackColor = System.Drawing.Color.DarkRed;
            this.pb_increaseMonth.Image = global::Organizer.Properties.Resources.right;
            this.pb_increaseMonth.Location = new System.Drawing.Point(533, 31);
            this.pb_increaseMonth.Name = "pb_increaseMonth";
            this.pb_increaseMonth.Size = new System.Drawing.Size(36, 42);
            this.pb_increaseMonth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_increaseMonth.TabIndex = 5;
            this.pb_increaseMonth.TabStop = false;
            this.pb_increaseMonth.Click += new System.EventHandler(this.pb_increaseMonth_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(683, 330);
            this.Controls.Add(this.pb_decreaseMonth);
            this.Controls.Add(this.pb_increaseMonth);
            this.Controls.Add(this.lb_month);
            this.Controls.Add(this.dgv_calendar);
            this.Name = "FormMain";
            this.Text = "Organaizer";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_calendar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_decreaseMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_increaseMonth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_calendar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMonday;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTuesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn clWednesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn clThursaday;
        private System.Windows.Forms.DataGridViewTextBoxColumn clFriday;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSaturday;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSunday;
        private System.Windows.Forms.Label lb_month;
        private System.Windows.Forms.PictureBox pb_increaseMonth;
        private System.Windows.Forms.PictureBox pb_decreaseMonth;

    }
}

