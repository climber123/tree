namespace Sum
{
    partial class Sum
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
            this.CreateTree = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.IsSimpleElements = new System.Windows.Forms.Button();
            this.summ = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.find_button1 = new System.Windows.Forms.Button();
            this.CreateStringTree = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Interp = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateTree
            // 
            this.CreateTree.Location = new System.Drawing.Point(6, 21);
            this.CreateTree.Name = "CreateTree";
            this.CreateTree.Size = new System.Drawing.Size(195, 45);
            this.CreateTree.TabIndex = 0;
            this.CreateTree.Text = "Создать Дерево";
            this.CreateTree.UseVisualStyleBackColor = true;
            this.CreateTree.Click += new System.EventHandler(this.CreateTree_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 134);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(195, 22);
            this.textBox2.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.IsSimpleElements);
            this.groupBox1.Controls.Add(this.summ);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CreateTree);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(1099, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 281);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Дерево";
            // 
            // IsSimpleElements
            // 
            this.IsSimpleElements.Location = new System.Drawing.Point(6, 244);
            this.IsSimpleElements.Name = "IsSimpleElements";
            this.IsSimpleElements.Size = new System.Drawing.Size(195, 27);
            this.IsSimpleElements.TabIndex = 6;
            this.IsSimpleElements.Text = "Одинаковые элементы";
            this.IsSimpleElements.UseVisualStyleBackColor = true;
            this.IsSimpleElements.Click += new System.EventHandler(this.IsSimpleElements_Click);
            // 
            // summ
            // 
            this.summ.Location = new System.Drawing.Point(6, 162);
            this.summ.Name = "summ";
            this.summ.Size = new System.Drawing.Size(195, 31);
            this.summ.TabIndex = 7;
            this.summ.Text = "Посчитать";
            this.summ.UseVisualStyleBackColor = true;
            this.summ.Click += new System.EventHandler(this.summ_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 216);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(195, 22);
            this.textBox3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Результат";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Укажите уровень";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Колличество уровней";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(45, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1054, 517);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.find_button1);
            this.groupBox2.Controls.Add(this.CreateStringTree);
            this.groupBox2.Location = new System.Drawing.Point(1105, 299);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(205, 94);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Дерево слов";
            // 
            // find_button1
            // 
            this.find_button1.Location = new System.Drawing.Point(5, 54);
            this.find_button1.Name = "find_button1";
            this.find_button1.Size = new System.Drawing.Size(194, 27);
            this.find_button1.TabIndex = 1;
            this.find_button1.Text = "Найти слова";
            this.find_button1.UseVisualStyleBackColor = true;
            this.find_button1.Click += new System.EventHandler(this.find_button1_Click);
            // 
            // CreateStringTree
            // 
            this.CreateStringTree.Location = new System.Drawing.Point(5, 21);
            this.CreateStringTree.Name = "CreateStringTree";
            this.CreateStringTree.Size = new System.Drawing.Size(194, 27);
            this.CreateStringTree.TabIndex = 0;
            this.CreateStringTree.Text = "Создать дерево";
            this.CreateStringTree.UseVisualStyleBackColor = true;
            this.CreateStringTree.Click += new System.EventHandler(this.button1_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(1110, 399);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(194, 27);
            this.Clear.TabIndex = 2;
            this.Clear.Text = "Очистить";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(1000, 452);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 17);
            this.label.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1110, 432);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(194, 22);
            this.textBox4.TabIndex = 7;
            // 
            // Interp
            // 
            this.Interp.Location = new System.Drawing.Point(1110, 460);
            this.Interp.Name = "Interp";
            this.Interp.Size = new System.Drawing.Size(195, 32);
            this.Interp.TabIndex = 8;
            this.Interp.Text = "Интерпретатор";
            this.Interp.UseVisualStyleBackColor = true;
            this.Interp.Click += new System.EventHandler(this.Interp_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1116, 506);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 9;
            // 
            // Sum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 571);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Interp);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.label);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Sum";
            this.Text = "Нахождение суммы";
            this.Load += new System.EventHandler(this.Sum_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateTree;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button summ;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button CreateStringTree;
        private System.Windows.Forms.Button find_button1;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button IsSimpleElements;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button Interp;
        private System.Windows.Forms.Label label4;
    }
}

