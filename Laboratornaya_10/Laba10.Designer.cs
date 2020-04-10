namespace Laboratornaya_10
{
    partial class Laba10
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
            this.label1 = new System.Windows.Forms.Label();
            this.SizeLineLable = new System.Windows.Forms.Label();
            this.CircleRadioButton = new System.Windows.Forms.RadioButton();
            this.SquareRadioButton = new System.Windows.Forms.RadioButton();
            this.TriangleRadioButton = new System.Windows.Forms.RadioButton();
            this.SnowmanRadioButton = new System.Windows.Forms.RadioButton();
            this.HouseRadioButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SizeLineUpDown = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ColorButton = new System.Windows.Forms.Button();
            this.DrawButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.MyColorDialog = new System.Windows.Forms.ColorDialog();
            this.ClearButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SizeLineUpDown)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "ГРАФИКА В WINDOWS FORMS";
            // 
            // SizeLineLable
            // 
            this.SizeLineLable.AutoSize = true;
            this.SizeLineLable.Location = new System.Drawing.Point(7, 13);
            this.SizeLineLable.Name = "SizeLineLable";
            this.SizeLineLable.Size = new System.Drawing.Size(96, 19);
            this.SizeLineLable.TabIndex = 2;
            this.SizeLineLable.Text = "Толщина линии";
            // 
            // CircleRadioButton
            // 
            this.CircleRadioButton.AutoSize = true;
            this.CircleRadioButton.Location = new System.Drawing.Point(16, 15);
            this.CircleRadioButton.Name = "CircleRadioButton";
            this.CircleRadioButton.Size = new System.Drawing.Size(57, 23);
            this.CircleRadioButton.TabIndex = 3;
            this.CircleRadioButton.TabStop = true;
            this.CircleRadioButton.Text = "Круг";
            this.CircleRadioButton.UseVisualStyleBackColor = true;
            // 
            // SquareRadioButton
            // 
            this.SquareRadioButton.AutoSize = true;
            this.SquareRadioButton.Location = new System.Drawing.Point(16, 38);
            this.SquareRadioButton.Name = "SquareRadioButton";
            this.SquareRadioButton.Size = new System.Drawing.Size(114, 23);
            this.SquareRadioButton.TabIndex = 4;
            this.SquareRadioButton.TabStop = true;
            this.SquareRadioButton.Text = "Прямоугольник";
            this.SquareRadioButton.UseVisualStyleBackColor = true;
            // 
            // TriangleRadioButton
            // 
            this.TriangleRadioButton.AutoSize = true;
            this.TriangleRadioButton.Location = new System.Drawing.Point(16, 63);
            this.TriangleRadioButton.Name = "TriangleRadioButton";
            this.TriangleRadioButton.Size = new System.Drawing.Size(97, 23);
            this.TriangleRadioButton.TabIndex = 5;
            this.TriangleRadioButton.TabStop = true;
            this.TriangleRadioButton.Text = "Треугольник";
            this.TriangleRadioButton.UseVisualStyleBackColor = true;
            // 
            // SnowmanRadioButton
            // 
            this.SnowmanRadioButton.AutoSize = true;
            this.SnowmanRadioButton.Location = new System.Drawing.Point(16, 87);
            this.SnowmanRadioButton.Name = "SnowmanRadioButton";
            this.SnowmanRadioButton.Size = new System.Drawing.Size(77, 23);
            this.SnowmanRadioButton.TabIndex = 6;
            this.SnowmanRadioButton.TabStop = true;
            this.SnowmanRadioButton.Text = "Снеговик";
            this.SnowmanRadioButton.UseVisualStyleBackColor = true;
            // 
            // HouseRadioButton
            // 
            this.HouseRadioButton.AutoSize = true;
            this.HouseRadioButton.Location = new System.Drawing.Point(16, 111);
            this.HouseRadioButton.Name = "HouseRadioButton";
            this.HouseRadioButton.Size = new System.Drawing.Size(53, 23);
            this.HouseRadioButton.TabIndex = 7;
            this.HouseRadioButton.TabStop = true;
            this.HouseRadioButton.Text = "Дом";
            this.HouseRadioButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SnowmanRadioButton);
            this.panel1.Controls.Add(this.HouseRadioButton);
            this.panel1.Controls.Add(this.CircleRadioButton);
            this.panel1.Controls.Add(this.SquareRadioButton);
            this.panel1.Controls.Add(this.TriangleRadioButton);
            this.panel1.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 144);
            this.panel1.TabIndex = 8;
            // 
            // SizeLineUpDown
            // 
            this.SizeLineUpDown.Location = new System.Drawing.Point(118, 11);
            this.SizeLineUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.SizeLineUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SizeLineUpDown.Name = "SizeLineUpDown";
            this.SizeLineUpDown.ReadOnly = true;
            this.SizeLineUpDown.Size = new System.Drawing.Size(120, 27);
            this.SizeLineUpDown.TabIndex = 9;
            this.SizeLineUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ColorButton);
            this.panel2.Controls.Add(this.SizeLineUpDown);
            this.panel2.Controls.Add(this.DrawButton);
            this.panel2.Controls.Add(this.SizeLineLable);
            this.panel2.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(155, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(252, 105);
            this.panel2.TabIndex = 11;
            // 
            // ColorButton
            // 
            this.ColorButton.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColorButton.Location = new System.Drawing.Point(163, 58);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(75, 33);
            this.ColorButton.TabIndex = 13;
            this.ColorButton.Text = "Цвет";
            this.ColorButton.UseVisualStyleBackColor = true;
            this.ColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // DrawButton
            // 
            this.DrawButton.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrawButton.Location = new System.Drawing.Point(11, 58);
            this.DrawButton.Name = "DrawButton";
            this.DrawButton.Size = new System.Drawing.Size(88, 33);
            this.DrawButton.TabIndex = 12;
            this.DrawButton.Text = "Нарисовать";
            this.DrawButton.UseVisualStyleBackColor = true;
            this.DrawButton.Click += new System.EventHandler(this.DrawButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(413, 39);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(559, 406);
            this.pictureBox.TabIndex = 13;
            this.pictureBox.TabStop = false;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(250, 160);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 14;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Laba10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 469);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Laba10";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SizeLineUpDown)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SizeLineLable;
        private System.Windows.Forms.RadioButton CircleRadioButton;
        private System.Windows.Forms.RadioButton SquareRadioButton;
        private System.Windows.Forms.RadioButton TriangleRadioButton;
        private System.Windows.Forms.RadioButton SnowmanRadioButton;
        private System.Windows.Forms.RadioButton HouseRadioButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown SizeLineUpDown;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button DrawButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ColorDialog MyColorDialog;
        private System.Windows.Forms.Button ColorButton;
        private System.Windows.Forms.Button ClearButton;
    }
}

