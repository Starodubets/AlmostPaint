namespace AlmostPaint.Controls
{
    partial class PProperties
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rectBn = new System.Windows.Forms.Button();
            this.rrectBtn = new System.Windows.Forms.Button();
            this.ellipseBtn = new System.Windows.Forms.Button();
            this.lineBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.colorBtn = new System.Windows.Forms.Button();
            this.widthCB = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.loadBtn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textField = new System.Windows.Forms.TextBox();
            this.textColBtn = new System.Windows.Forms.Button();
            this.fontBtn = new System.Windows.Forms.Button();
            this.rotateField = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lineBtn);
            this.groupBox1.Controls.Add(this.ellipseBtn);
            this.groupBox1.Controls.Add(this.rrectBtn);
            this.groupBox1.Controls.Add(this.rectBn);
            this.groupBox1.Location = new System.Drawing.Point(3, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 156);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Figure type";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Properties";
            // 
            // rectBn
            // 
            this.rectBn.Location = new System.Drawing.Point(13, 20);
            this.rectBn.Name = "rectBn";
            this.rectBn.Size = new System.Drawing.Size(146, 25);
            this.rectBn.TabIndex = 0;
            this.rectBn.Text = "Rectangle";
            this.rectBn.UseVisualStyleBackColor = true;
            // 
            // rrectBtn
            // 
            this.rrectBtn.Location = new System.Drawing.Point(13, 51);
            this.rrectBtn.Name = "rrectBtn";
            this.rrectBtn.Size = new System.Drawing.Size(146, 25);
            this.rrectBtn.TabIndex = 1;
            this.rrectBtn.Text = "RRectangle";
            this.rrectBtn.UseVisualStyleBackColor = true;
            // 
            // ellipseBtn
            // 
            this.ellipseBtn.Location = new System.Drawing.Point(13, 82);
            this.ellipseBtn.Name = "ellipseBtn";
            this.ellipseBtn.Size = new System.Drawing.Size(146, 25);
            this.ellipseBtn.TabIndex = 2;
            this.ellipseBtn.Text = "Ellipse";
            this.ellipseBtn.UseVisualStyleBackColor = true;
            // 
            // lineBtn
            // 
            this.lineBtn.Location = new System.Drawing.Point(13, 113);
            this.lineBtn.Name = "lineBtn";
            this.lineBtn.Size = new System.Drawing.Size(146, 25);
            this.lineBtn.TabIndex = 3;
            this.lineBtn.Text = "Line";
            this.lineBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.widthCB);
            this.groupBox2.Controls.Add(this.colorBtn);
            this.groupBox2.Location = new System.Drawing.Point(3, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(165, 101);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Color and Width";
            // 
            // colorBtn
            // 
            this.colorBtn.Location = new System.Drawing.Point(13, 53);
            this.colorBtn.Name = "colorBtn";
            this.colorBtn.Size = new System.Drawing.Size(146, 25);
            this.colorBtn.TabIndex = 4;
            this.colorBtn.Text = "Color";
            this.colorBtn.UseVisualStyleBackColor = true;
            // 
            // widthCB
            // 
            this.widthCB.FormattingEnabled = true;
            this.widthCB.Items.AddRange(new object[] {
            "1",
            "3",
            "5",
            "10",
            "15",
            "20"});
            this.widthCB.Location = new System.Drawing.Point(13, 26);
            this.widthCB.Name = "widthCB";
            this.widthCB.Size = new System.Drawing.Size(146, 21);
            this.widthCB.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.loadBtn);
            this.groupBox3.Controls.Add(this.saveBtn);
            this.groupBox3.Location = new System.Drawing.Point(3, 446);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(165, 85);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Save/Load";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(13, 19);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(146, 25);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(13, 50);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(146, 25);
            this.loadBtn.TabIndex = 5;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rotateField);
            this.groupBox4.Controls.Add(this.fontBtn);
            this.groupBox4.Controls.Add(this.textColBtn);
            this.groupBox4.Controls.Add(this.textField);
            this.groupBox4.Location = new System.Drawing.Point(3, 302);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(165, 138);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Text";
            // 
            // textField
            // 
            this.textField.Location = new System.Drawing.Point(13, 19);
            this.textField.Name = "textField";
            this.textField.Size = new System.Drawing.Size(146, 20);
            this.textField.TabIndex = 0;
            // 
            // textColBtn
            // 
            this.textColBtn.Location = new System.Drawing.Point(13, 45);
            this.textColBtn.Name = "textColBtn";
            this.textColBtn.Size = new System.Drawing.Size(146, 25);
            this.textColBtn.TabIndex = 6;
            this.textColBtn.Text = "Text color";
            this.textColBtn.UseVisualStyleBackColor = true;
            // 
            // fontBtn
            // 
            this.fontBtn.Location = new System.Drawing.Point(13, 76);
            this.fontBtn.Name = "fontBtn";
            this.fontBtn.Size = new System.Drawing.Size(146, 25);
            this.fontBtn.TabIndex = 7;
            this.fontBtn.Text = "Font";
            this.fontBtn.UseVisualStyleBackColor = true;
            // 
            // rotateField
            // 
            this.rotateField.Location = new System.Drawing.Point(13, 107);
            this.rotateField.Name = "rotateField";
            this.rotateField.Size = new System.Drawing.Size(146, 20);
            this.rotateField.TabIndex = 8;
            // 
            // PProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "PProperties";
            this.Size = new System.Drawing.Size(176, 536);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button lineBtn;
        private System.Windows.Forms.Button ellipseBtn;
        private System.Windows.Forms.Button rrectBtn;
        private System.Windows.Forms.Button rectBn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox widthCB;
        private System.Windows.Forms.Button colorBtn;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox rotateField;
        private System.Windows.Forms.Button fontBtn;
        private System.Windows.Forms.Button textColBtn;
        private System.Windows.Forms.TextBox textField;
    }
}
