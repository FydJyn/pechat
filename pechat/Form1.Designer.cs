namespace pechat
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.ComboBox cmbDifficulty;
        private System.Windows.Forms.Label lblTextLabel;
        private System.Windows.Forms.Label lblTargetText;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblErrors;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Timer timer1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.cmbDifficulty = new System.Windows.Forms.ComboBox();
            this.lblTextLabel = new System.Windows.Forms.Label();
            this.lblTargetText = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblErrors = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(25, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(261, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Тренировка печатания";
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Location = new System.Drawing.Point(28, 75);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(140, 16);
            this.lblDifficulty.TabIndex = 1;
            this.lblDifficulty.Text = "Выберите уровень:";
            // 
            // cmbDifficulty
            // 
            this.cmbDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDifficulty.FormattingEnabled = true;
            this.cmbDifficulty.Location = new System.Drawing.Point(31, 100);
            this.cmbDifficulty.Name = "cmbDifficulty";
            this.cmbDifficulty.Size = new System.Drawing.Size(220, 24);
            this.cmbDifficulty.TabIndex = 2;
            // 
            // lblTextLabel
            // 
            this.lblTextLabel.AutoSize = true;
            this.lblTextLabel.Location = new System.Drawing.Point(28, 145);
            this.lblTextLabel.Name = "lblTextLabel";
            this.lblTextLabel.Size = new System.Drawing.Size(110, 16);
            this.lblTextLabel.TabIndex = 3;
            this.lblTextLabel.Text = "Текст для ввода:";
            // 
            // lblTargetText
            // 
            this.lblTargetText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTargetText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTargetText.Location = new System.Drawing.Point(31, 170);
            this.lblTargetText.Name = "lblTargetText";
            this.lblTargetText.Size = new System.Drawing.Size(500, 70);
            this.lblTargetText.TabIndex = 4; this.lblTargetText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(31, 260);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(500, 22);
            this.txtInput.TabIndex = 5;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(31, 305);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(180, 35);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Начать";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(31, 365);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(86, 16);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "Время: 0 сек";
            // 
            // lblErrors
            // 
            this.lblErrors.AutoSize = true;
            this.lblErrors.Location = new System.Drawing.Point(31, 395);
            this.lblErrors.Name = "lblErrors";
            this.lblErrors.Size = new System.Drawing.Size(71, 16);
            this.lblErrors.TabIndex = 8;
            this.lblErrors.Text = "Ошибки: 0";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(31, 425);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(123, 16);
            this.lblResult.TabIndex = 9;
            this.lblResult.Text = "Статус: ожидание";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(570, 470);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblErrors);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblTargetText);
            this.Controls.Add(this.lblTextLabel);
            this.Controls.Add(this.cmbDifficulty);
            this.Controls.Add(this.lblDifficulty);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тренажёр скоропечатания v2";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}