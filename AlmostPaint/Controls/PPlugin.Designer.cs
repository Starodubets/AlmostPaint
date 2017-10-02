namespace AlmostPaint.Controls
{
    partial class PPlugin
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
            this.loadBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.picturefigBtn = new System.Windows.Forms.Button();
            this.textfigBtn = new System.Windows.Forms.Button();
            this.emptyFigureBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.loadBtn);
            this.groupBox1.Controls.Add(this.saveBtn);
            this.groupBox1.Location = new System.Drawing.Point(3, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 179);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Save / Load Plugins";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(30, 107);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(75, 48);
            this.loadBtn.TabIndex = 1;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(30, 32);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 48);
            this.saveBtn.TabIndex = 0;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.picturefigBtn);
            this.groupBox2.Controls.Add(this.textfigBtn);
            this.groupBox2.Controls.Add(this.emptyFigureBtn);
            this.groupBox2.Location = new System.Drawing.Point(3, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(139, 230);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Figure Plugins";
            // 
            // picturefigBtn
            // 
            this.picturefigBtn.Location = new System.Drawing.Point(30, 166);
            this.picturefigBtn.Name = "picturefigBtn";
            this.picturefigBtn.Size = new System.Drawing.Size(75, 48);
            this.picturefigBtn.TabIndex = 4;
            this.picturefigBtn.Text = "Picture with figure";
            this.picturefigBtn.UseVisualStyleBackColor = true;
            // 
            // textfigBtn
            // 
            this.textfigBtn.Location = new System.Drawing.Point(30, 102);
            this.textfigBtn.Name = "textfigBtn";
            this.textfigBtn.Size = new System.Drawing.Size(75, 48);
            this.textfigBtn.TabIndex = 3;
            this.textfigBtn.Text = "Figure with text";
            this.textfigBtn.UseVisualStyleBackColor = true;
            // 
            // emptyFigureBtn
            // 
            this.emptyFigureBtn.Location = new System.Drawing.Point(30, 34);
            this.emptyFigureBtn.Name = "emptyFigureBtn";
            this.emptyFigureBtn.Size = new System.Drawing.Size(75, 48);
            this.emptyFigureBtn.TabIndex = 2;
            this.emptyFigureBtn.Text = "Empty figure";
            this.emptyFigureBtn.UseVisualStyleBackColor = true;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(121, 4);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(20, 22);
            this.CloseBtn.TabIndex = 2;
            this.CloseBtn.Text = "X";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Plugins";
            // 
            // PPlugin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PPlugin";
            this.Size = new System.Drawing.Size(146, 494);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button picturefigBtn;
        private System.Windows.Forms.Button textfigBtn;
        private System.Windows.Forms.Button emptyFigureBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label label1;
    }
}
