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
            lblRaselog = new Label();
            lblFirstPrototype = new Label();
            lblPilot = new Label();
            lblAuto = new Label();
            lblRoads = new Label();
            lblTime = new Label();
            txtDriver = new TextBox();
            txtTime = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            lblResult = new Label();
            lstResults = new ListBox();
            cmbCar = new ComboBox();
            cmbTrack = new ComboBox();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // lblRaselog
            // 
            lblRaselog.AutoSize = true;
            lblRaselog.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblRaselog.Location = new Point(12, 13);
            lblRaselog.Name = "lblRaselog";
            lblRaselog.Size = new Size(430, 46);
            lblRaselog.TabIndex = 0;
            lblRaselog.Text = "Учебный автосимулятор";
            // 
            // lblFirstPrototype
            // 
            lblFirstPrototype.AutoSize = true;
            lblFirstPrototype.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblFirstPrototype.Location = new Point(12, 59);
            lblFirstPrototype.Name = "lblFirstPrototype";
            lblFirstPrototype.Size = new Size(384, 31);
            lblFirstPrototype.TabIndex = 1;
            lblFirstPrototype.Text = "Первый прототив журнала заездов";
            // 
            // lblPilot
            // 
            lblPilot.AutoSize = true;
            lblPilot.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblPilot.Location = new Point(14, 127);
            lblPilot.Name = "lblPilot";
            lblPilot.Size = new Size(69, 28);
            lblPilot.TabIndex = 2;
            lblPilot.Text = "Пилот";
            // 
            // lblAuto
            // 
            lblAuto.AutoSize = true;
            lblAuto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblAuto.Location = new Point(12, 200);
            lblAuto.Name = "lblAuto";
            lblAuto.Size = new Size(127, 28);
            lblAuto.TabIndex = 3;
            lblAuto.Text = "Автомобиль";
            // 
            // lblRoads
            // 
            lblRoads.AutoSize = true;
            lblRoads.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblRoads.Location = new Point(14, 276);
            lblRoads.Name = "lblRoads";
            lblRoads.Size = new Size(72, 28);
            lblRoads.TabIndex = 4;
            lblRoads.Text = "Трасса";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblTime.Location = new Point(12, 354);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(87, 28);
            lblTime.TabIndex = 5;
            lblTime.Text = "Время, с";
            // 
            // txtDriver
            // 
            txtDriver.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtDriver.Location = new Point(158, 127);
            txtDriver.Name = "txtDriver";
            txtDriver.Size = new Size(238, 34);
            txtDriver.TabIndex = 0;
            // 
            // txtTime
            // 
            txtTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtTime.Location = new Point(158, 351);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(238, 34);
            txtTime.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnAdd.Location = new Point(12, 547);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(227, 46);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Добавить результат";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnDelete.Location = new Point(256, 547);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(227, 46);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Удалить выбранное";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnClear.Location = new Point(505, 547);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(227, 46);
            btnClear.TabIndex = 7;
            btnClear.Text = "Очистить поля";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblResult.Location = new Point(423, 95);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(113, 28);
            lblResult.TabIndex = 11;
            lblResult.Text = "Результаты";
            // 
            // lstResults
            // 
            lstResults.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lstResults.FormattingEnabled = true;
            lstResults.HorizontalScrollbar = true;
            lstResults.ItemHeight = 28;
            lstResults.Location = new Point(423, 127);
            lstResults.Name = "lstResults";
            lstResults.ScrollAlwaysVisible = true;
            lstResults.Size = new Size(513, 368);
            lstResults.TabIndex = 4;
            // 
            // cmbCar
            // 
            cmbCar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cmbCar.FormattingEnabled = true;
            cmbCar.Items.AddRange(new object[] { "Спорт-прототип", "Одноместный болид", "Полноприводная машина" });
            cmbCar.Location = new Point(158, 200);
            cmbCar.Name = "cmbCar";
            cmbCar.Size = new Size(238, 36);
            cmbCar.TabIndex = 1;
            // 
            // cmbTrack
            // 
            cmbTrack.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTrack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cmbTrack.FormattingEnabled = true;
            cmbTrack.Items.AddRange(new object[] { "Автодром", "Городская трасса", "Грунтовая трасса" });
            cmbTrack.Location = new Point(158, 273);
            cmbTrack.Name = "cmbTrack";
            cmbTrack.Size = new Size(238, 36);
            cmbTrack.TabIndex = 2;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblStatus.Location = new Point(14, 606);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 38);
            lblStatus.TabIndex = 16;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 653);
            Controls.Add(lblStatus);
            Controls.Add(cmbTrack);
            Controls.Add(cmbCar);
            Controls.Add(lstResults);
            Controls.Add(lblResult);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtTime);
            Controls.Add(txtDriver);
            Controls.Add(lblTime);
            Controls.Add(lblRoads);
            Controls.Add(lblAuto);
            Controls.Add(lblPilot);
            Controls.Add(lblFirstPrototype);
            Controls.Add(lblRaselog);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Учебный автосимулятор";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRaselog;
        private Label lblFirstPrototype;
        private Label lblPilot;
        private Label lblAuto;
        private Label lblRoads;
        private Label lblTime;
        private TextBox txtDriver;
        private TextBox txtTime;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnClear;
        private Label lblResult;
        private ListBox lstResults;
        private ComboBox cmbCar;
        private ComboBox cmbTrack;
        private Label lblStatus;
    }
}
