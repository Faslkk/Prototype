namespace BuilderPrototype
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

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
            this.lblType = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStep = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.lblSteps = new System.Windows.Forms.Label();
            this.lstSteps = new System.Windows.Forms.ListBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblObjects = new System.Windows.Forms.Label();
            this.lstObjects = new System.Windows.Forms.ListBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.numCount = new System.Windows.Forms.NumericUpDown();
            this.btnClone = new System.Windows.Forms.Button();
            this.lblTable = new System.Windows.Forms.Label();
            this.txtTable = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).BeginInit();
            this.SuspendLayout();
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(12, 16);
            this.lblType.Name = "lblType";
            this.lblType.Text = "Тип запиту:";
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.Location = new System.Drawing.Point(95, 12);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(130, 23);
            this.cmbType.TabIndex = 0;
            this.btnStart.Location = new System.Drawing.Point(240, 10);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(120, 28);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Почати";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            this.btnStep.Location = new System.Drawing.Point(370, 10);
            this.btnStep.Name = "btnStep";
            this.btnStep.Size = new System.Drawing.Size(130, 28);
            this.btnStep.TabIndex = 2;
            this.btnStep.Text = "Наступний крок";
            this.btnStep.UseVisualStyleBackColor = true;
            this.btnStep.Click += new System.EventHandler(this.btnStep_Click);
            this.btnAll.Location = new System.Drawing.Point(510, 10);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(130, 28);
            this.btnAll.TabIndex = 3;
            this.btnAll.Text = "Виконати все";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            this.lblSteps.AutoSize = true;
            this.lblSteps.Location = new System.Drawing.Point(12, 52);
            this.lblSteps.Name = "lblSteps";
            this.lblSteps.Text = "Кроки побудови (Будівельник):";
            this.lstSteps.HorizontalScrollbar = true;
            this.lstSteps.ItemHeight = 15;
            this.lstSteps.Location = new System.Drawing.Point(12, 72);
            this.lstSteps.Name = "lstSteps";
            this.lstSteps.Size = new System.Drawing.Size(736, 184);
            this.lstSteps.TabIndex = 4;
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 266);
            this.lblResult.Name = "lblResult";
            this.lblResult.Text = "SQL-запит:";
            this.txtResult.Font = new System.Drawing.Font("Consolas", 11F);
            this.txtResult.Location = new System.Drawing.Point(12, 286);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(736, 48);
            this.txtResult.TabIndex = 5;
            this.lblObjects.AutoSize = true;
            this.lblObjects.Location = new System.Drawing.Point(12, 346);
            this.lblObjects.Name = "lblObjects";
            this.lblObjects.Text = "Оригінал і копії (Прототип):";
            this.lstObjects.HorizontalScrollbar = true;
            this.lstObjects.ItemHeight = 15;
            this.lstObjects.Location = new System.Drawing.Point(12, 366);
            this.lstObjects.Name = "lstObjects";
            this.lstObjects.Size = new System.Drawing.Size(736, 184);
            this.lstObjects.TabIndex = 6;
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(12, 568);
            this.lblCount.Name = "lblCount";
            this.lblCount.Text = "Кількість копій:";
            this.numCount.Location = new System.Drawing.Point(115, 564);
            this.numCount.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            this.numCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numCount.Name = "numCount";
            this.numCount.Size = new System.Drawing.Size(60, 23);
            this.numCount.TabIndex = 7;
            this.numCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            this.btnClone.Location = new System.Drawing.Point(185, 562);
            this.btnClone.Name = "btnClone";
            this.btnClone.Size = new System.Drawing.Size(170, 28);
            this.btnClone.TabIndex = 8;
            this.btnClone.Text = "Клонувати вибраний";
            this.btnClone.UseVisualStyleBackColor = true;
            this.btnClone.Click += new System.EventHandler(this.btnClone_Click);
            this.lblTable.AutoSize = true;
            this.lblTable.Location = new System.Drawing.Point(380, 568);
            this.lblTable.Name = "lblTable";
            this.lblTable.Text = "Нова таблиця:";
            this.txtTable.Location = new System.Drawing.Point(475, 564);
            this.txtTable.Name = "txtTable";
            this.txtTable.Size = new System.Drawing.Size(130, 23);
            this.txtTable.TabIndex = 9;
            this.btnChange.Location = new System.Drawing.Point(615, 562);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(133, 28);
            this.btnChange.TabIndex = 10;
            this.btnChange.Text = "Змінити таблицю";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 602);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.txtTable);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.btnClone);
            this.Controls.Add(this.numCount);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lstObjects);
            this.Controls.Add(this.lblObjects);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lstSteps);
            this.Controls.Add(this.lblSteps);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnStep);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.lblType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Builder + Prototype - SQL-запити";
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStep;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Label lblSteps;
        private System.Windows.Forms.ListBox lstSteps;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblObjects;
        private System.Windows.Forms.ListBox lstObjects;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.NumericUpDown numCount;
        private System.Windows.Forms.Button btnClone;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.TextBox txtTable;
        private System.Windows.Forms.Button btnChange;
    }
}
