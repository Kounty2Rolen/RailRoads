namespace RailRoadsINC.Interface
{
    partial class RegTickets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegTickets));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTrainsArrivalPoint = new System.Windows.Forms.ComboBox();
            this.comboBoxTrain = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonReg = new System.Windows.Forms.Button();
            this.numericUpDownSeat = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберте направление";
            // 
            // comboBoxTrainsArrivalPoint
            // 
            this.comboBoxTrainsArrivalPoint.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxTrainsArrivalPoint.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxTrainsArrivalPoint.FormattingEnabled = true;
            this.comboBoxTrainsArrivalPoint.Location = new System.Drawing.Point(198, 11);
            this.comboBoxTrainsArrivalPoint.Name = "comboBoxTrainsArrivalPoint";
            this.comboBoxTrainsArrivalPoint.Size = new System.Drawing.Size(126, 21);
            this.comboBoxTrainsArrivalPoint.TabIndex = 1;
            this.comboBoxTrainsArrivalPoint.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTrainsArrivalPoint_SelectedIndexChanged);
            // 
            // comboBoxTrain
            // 
            this.comboBoxTrain.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxTrain.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxTrain.Enabled = false;
            this.comboBoxTrain.FormattingEnabled = true;
            this.comboBoxTrain.Location = new System.Drawing.Point(198, 37);
            this.comboBoxTrain.Name = "comboBoxTrain";
            this.comboBoxTrain.Size = new System.Drawing.Size(126, 21);
            this.comboBoxTrain.TabIndex = 3;
            this.comboBoxTrain.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTrain_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Выберте поезд";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Выберте место";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Введите ФИО";
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Enabled = false;
            this.textBoxFIO.Location = new System.Drawing.Point(198, 90);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(126, 20);
            this.textBoxFIO.TabIndex = 8;
            this.textBoxFIO.TextChanged += new System.EventHandler(this.TextBoxFIO_TextChanged);
            this.textBoxFIO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxFIO_KeyPress);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(261, 159);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // buttonReg
            // 
            this.buttonReg.Location = new System.Drawing.Point(12, 159);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(122, 23);
            this.buttonReg.TabIndex = 10;
            this.buttonReg.Text = "Зарегестрировать";
            this.buttonReg.UseVisualStyleBackColor = true;
            this.buttonReg.Click += new System.EventHandler(this.ButtonReg_Click);
            // 
            // numericUpDownSeat
            // 
            this.numericUpDownSeat.Enabled = false;
            this.numericUpDownSeat.Location = new System.Drawing.Point(198, 64);
            this.numericUpDownSeat.Name = "numericUpDownSeat";
            this.numericUpDownSeat.Size = new System.Drawing.Size(126, 20);
            this.numericUpDownSeat.TabIndex = 11;
            this.numericUpDownSeat.ValueChanged += new System.EventHandler(this.NumericUpDownSeat_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(198, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 20);
            this.textBox1.TabIndex = 13;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 40);
            this.label5.TabIndex = 12;
            this.label5.Text = "Введите серию и \r\nномер паспорта";
            // 
            // RegTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 194);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownSeat);
            this.Controls.Add(this.buttonReg);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.textBoxFIO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxTrain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxTrainsArrivalPoint);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegTickets";
            this.Text = "RegTickets";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTrainsArrivalPoint;
        private System.Windows.Forms.ComboBox comboBoxTrain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.NumericUpDown numericUpDownSeat;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
    }
}