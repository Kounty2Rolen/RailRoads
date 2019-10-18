namespace RailRoadsINC
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RegButton = new System.Windows.Forms.Button();
            this.DelButton = new System.Windows.Forms.Button();
            this.BlockButton = new System.Windows.Forms.Button();
            this.LOCKBOX = new System.Windows.Forms.PictureBox();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LOCKBOX)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(735, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // RegButton
            // 
            this.RegButton.Location = new System.Drawing.Point(753, 12);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(127, 34);
            this.RegButton.TabIndex = 1;
            this.RegButton.Text = "Зарегестрировать билет";
            this.RegButton.UseVisualStyleBackColor = true;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // DelButton
            // 
            this.DelButton.Location = new System.Drawing.Point(753, 52);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(127, 36);
            this.DelButton.TabIndex = 2;
            this.DelButton.Text = "Удалить Регистрацию Билета";
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // BlockButton
            // 
            this.BlockButton.Location = new System.Drawing.Point(870, 428);
            this.BlockButton.Name = "BlockButton";
            this.BlockButton.Size = new System.Drawing.Size(22, 23);
            this.BlockButton.TabIndex = 3;
            this.BlockButton.Text = "🔒";
            this.BlockButton.UseVisualStyleBackColor = true;
            this.BlockButton.Click += new System.EventHandler(this.BlockButton_Click);
            // 
            // LOCKBOX
            // 
            this.LOCKBOX.BackColor = System.Drawing.Color.Silver;
            this.LOCKBOX.Location = new System.Drawing.Point(753, 398);
            this.LOCKBOX.Name = "LOCKBOX";
            this.LOCKBOX.Size = new System.Drawing.Size(67, 40);
            this.LOCKBOX.TabIndex = 4;
            this.LOCKBOX.TabStop = false;
            this.LOCKBOX.Visible = false;
            // 
            // SettingsButton
            // 
            this.SettingsButton.Location = new System.Drawing.Point(753, 94);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(127, 42);
            this.SettingsButton.TabIndex = 5;
            this.SettingsButton.Text = "Панель Администратора";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(753, 142);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(124, 35);
            this.buttonRefresh.TabIndex = 7;
            this.buttonRefresh.Text = "Обновить";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 450);
            this.Controls.Add(this.LOCKBOX);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.BlockButton);
            this.Controls.Add(this.DelButton);
            this.Controls.Add(this.RegButton);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "РЖД РФ 2019";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LOCKBOX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button RegButton;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.Button BlockButton;
        private System.Windows.Forms.PictureBox LOCKBOX;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button buttonRefresh;
    }
}

