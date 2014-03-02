namespace Organizer
{
    partial class SettingForm
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
            this.lb_clCompleteNotice = new System.Windows.Forms.Label();
            this.pb_clCompleteNotice = new System.Windows.Forms.PictureBox();
            this.lb_notCompleteColor = new System.Windows.Forms.Label();
            this.pb_clNotCompleteNotice = new System.Windows.Forms.PictureBox();
            this.cd_chooseColor = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pb_clCompleteNotice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_clNotCompleteNotice)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_clCompleteNotice
            // 
            this.lb_clCompleteNotice.AutoSize = true;
            this.lb_clCompleteNotice.Location = new System.Drawing.Point(7, 20);
            this.lb_clCompleteNotice.Name = "lb_clCompleteNotice";
            this.lb_clCompleteNotice.Size = new System.Drawing.Size(158, 13);
            this.lb_clCompleteNotice.TabIndex = 0;
            this.lb_clCompleteNotice.Text = "Цвет выполненных заданий : ";
            // 
            // pb_clCompleteNotice
            // 
            this.pb_clCompleteNotice.Location = new System.Drawing.Point(203, 8);
            this.pb_clCompleteNotice.Name = "pb_clCompleteNotice";
            this.pb_clCompleteNotice.Size = new System.Drawing.Size(45, 34);
            this.pb_clCompleteNotice.TabIndex = 1;
            this.pb_clCompleteNotice.TabStop = false;
            this.pb_clCompleteNotice.Click += new System.EventHandler(this.pb_clCompleteNotice_Click);
            // 
            // lb_notCompleteColor
            // 
            this.lb_notCompleteColor.AutoSize = true;
            this.lb_notCompleteColor.Location = new System.Drawing.Point(7, 73);
            this.lb_notCompleteColor.Name = "lb_notCompleteColor";
            this.lb_notCompleteColor.Size = new System.Drawing.Size(170, 13);
            this.lb_notCompleteColor.TabIndex = 2;
            this.lb_notCompleteColor.Text = "Цвет невыполненных заданий : ";
            // 
            // pb_clNotCompleteNotice
            // 
            this.pb_clNotCompleteNotice.Location = new System.Drawing.Point(203, 61);
            this.pb_clNotCompleteNotice.Name = "pb_clNotCompleteNotice";
            this.pb_clNotCompleteNotice.Size = new System.Drawing.Size(45, 34);
            this.pb_clNotCompleteNotice.TabIndex = 3;
            this.pb_clNotCompleteNotice.TabStop = false;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(240)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(316, 336);
            this.Controls.Add(this.pb_clNotCompleteNotice);
            this.Controls.Add(this.lb_notCompleteColor);
            this.Controls.Add(this.pb_clCompleteNotice);
            this.Controls.Add(this.lb_clCompleteNotice);
            this.Name = "SettingForm";
            this.Text = "Настройки";
            ((System.ComponentModel.ISupportInitialize)(this.pb_clCompleteNotice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_clNotCompleteNotice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_clCompleteNotice;
        private System.Windows.Forms.PictureBox pb_clCompleteNotice;
        private System.Windows.Forms.Label lb_notCompleteColor;
        private System.Windows.Forms.PictureBox pb_clNotCompleteNotice;
        private System.Windows.Forms.ColorDialog cd_chooseColor;
    }
}