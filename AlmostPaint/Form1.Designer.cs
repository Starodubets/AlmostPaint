namespace AlmostPaint
{
    partial class Form1
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
            this.pTab1 = new AlmostPaint.Controls.PTab();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pMenu1 = new AlmostPaint.Controls.PMenu();
            this.pStatusBar1 = new AlmostPaint.Controls.PStatusBar();
            this.pToolBox1 = new AlmostPaint.Controls.PToolBox();
            this.pPlugin1 = new AlmostPaint.Controls.PPlugin();
            this.pProperties1 = new AlmostPaint.Controls.PProperties();
            this.pTab1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pTab1
            // 
            this.pTab1.Controls.Add(this.tabPage2);
            this.pTab1.Location = new System.Drawing.Point(164, 65);
            this.pTab1.Name = "pTab1";
            this.pTab1.SelectedIndex = 0;
            this.pTab1.Size = new System.Drawing.Size(616, 523);
            this.pTab1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(608, 497);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pMenu1
            // 
            this.pMenu1.Location = new System.Drawing.Point(0, 42);
            this.pMenu1.Name = "pMenu1";
            this.pMenu1.Size = new System.Drawing.Size(993, 27);
            this.pMenu1.TabIndex = 1;
            // 
            // pStatusBar1
            // 
            this.pStatusBar1.Location = new System.Drawing.Point(0, 603);
            this.pStatusBar1.Name = "pStatusBar1";
            this.pStatusBar1.Size = new System.Drawing.Size(993, 24);
            this.pStatusBar1.TabIndex = 2;
            // 
            // pToolBox1
            // 
            this.pToolBox1.Location = new System.Drawing.Point(1, 22);
            this.pToolBox1.Name = "pToolBox1";
            this.pToolBox1.Size = new System.Drawing.Size(993, 25);
            this.pToolBox1.TabIndex = 3;
            // 
            // pPlugin1
            // 
            this.pPlugin1.Location = new System.Drawing.Point(12, 75);
            this.pPlugin1.Name = "pPlugin1";
            this.pPlugin1.Size = new System.Drawing.Size(146, 523);
            this.pPlugin1.TabIndex = 4;
            // 
            // pProperties1
            // 
            this.pProperties1.Location = new System.Drawing.Point(805, 40);
            this.pProperties1.Name = "pProperties1";
            this.pProperties1.Size = new System.Drawing.Size(176, 536);
            this.pProperties1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 629);
            this.Controls.Add(this.pProperties1);
            this.Controls.Add(this.pPlugin1);
            this.Controls.Add(this.pToolBox1);
            this.Controls.Add(this.pStatusBar1);
            this.Controls.Add(this.pMenu1);
            this.Controls.Add(this.pTab1);
            this.Name = "Form1";
            this.Text = "Paint";
            this.pTab1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.PTab pTab1;
        private System.Windows.Forms.TabPage tabPage2;
        private Controls.PMenu pMenu1;
        private Controls.PStatusBar pStatusBar1;
        private Controls.PToolBox pToolBox1;
        private Controls.PPlugin pPlugin1;
        private Controls.PProperties pProperties1;
    }
}

