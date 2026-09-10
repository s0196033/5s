namespace lb1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtDriver = new TextBox();
            txtTime = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            label7 = new Label();
            lstResults = new ListBox();
            cmbCar = new ComboBox();
            cmbTrack = new ComboBox();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(357, 38);
            label1.TabIndex = 0;
            label1.Text = "Учебный автосимулятор";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 61);
            label2.Name = "label2";
            label2.Size = new Size(257, 20);
            label2.TabIndex = 1;
            label2.Text = "Первый прототив журнала заездов";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 127);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 2;
            label3.Text = "Пилот";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 163);
            label4.Name = "label4";
            label4.Size = new Size(96, 20);
            label4.TabIndex = 3;
            label4.Text = "Автомобиль";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 197);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 4;
            label5.Text = "Трасса";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 231);
            label6.Name = "label6";
            label6.Size = new Size(68, 20);
            label6.TabIndex = 5;
            label6.Text = "Время, с";
            // 
            // txtDriver
            // 
            txtDriver.Location = new Point(131, 127);
            txtDriver.Name = "txtDriver";
            txtDriver.Size = new Size(238, 27);
            txtDriver.TabIndex = 0;
            // 
            // txtTime
            // 
            txtTime.Location = new Point(131, 228);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(238, 27);
            txtTime.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(14, 377);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(163, 29);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Добавить результат";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(189, 377);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(162, 29);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Удалить выбранное";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(366, 377);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(156, 29);
            btnClear.TabIndex = 7;
            btnClear.Text = "Очистить поля";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(423, 95);
            label7.Name = "label7";
            label7.Size = new Size(86, 20);
            label7.TabIndex = 11;
            label7.Text = "Результаты";
            // 
            // lstResults
            // 
            lstResults.FormattingEnabled = true;
            lstResults.HorizontalScrollbar = true;
            lstResults.Location = new Point(423, 127);
            lstResults.Name = "lstResults";
            lstResults.ScrollAlwaysVisible = true;
            lstResults.Size = new Size(350, 224);
            lstResults.TabIndex = 4;
            // 
            // cmbCar
            // 
            cmbCar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCar.FormattingEnabled = true;
            cmbCar.Items.AddRange(new object[] { "Prototype", "Sport", "Street" });
            cmbCar.Location = new Point(131, 160);
            cmbCar.Name = "cmbCar";
            cmbCar.Size = new Size(238, 28);
            cmbCar.TabIndex = 1;
            // 
            // cmbTrack
            // 
            cmbTrack.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTrack.FormattingEnabled = true;
            cmbTrack.Items.AddRange(new object[] { "Учебный овал", "Городское кольцо", "Спринт" });
            cmbTrack.Location = new Point(131, 194);
            cmbTrack.Name = "cmbTrack";
            cmbTrack.Size = new Size(238, 28);
            cmbTrack.TabIndex = 2;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(14, 421);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 20);
            lblStatus.TabIndex = 16;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblStatus);
            Controls.Add(cmbTrack);
            Controls.Add(cmbCar);
            Controls.Add(lstResults);
            Controls.Add(label7);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtTime);
            Controls.Add(txtDriver);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Учебный автосимулятор";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtDriver;
        private TextBox txtTime;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnClear;
        private Label label7;
        private ListBox lstResults;
        private ComboBox cmbCar;
        private ComboBox cmbTrack;
        private Label lblStatus;
    }
}
