
namespace Lab2_Encryption_
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
            this.buttonHill = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxCipher = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCesar = new System.Windows.Forms.TextBox();
            this.labelCeasar = new System.Windows.Forms.Label();
            this.buttonCeasar = new System.Windows.Forms.Button();
            this.textBoxCeasarMoreKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCeasarMoreKey = new System.Windows.Forms.Button();
            this.textBoxLFSR = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonLFSR = new System.Windows.Forms.Button();
            this.buttonGraph = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonHill
            // 
            this.buttonHill.Location = new System.Drawing.Point(12, 12);
            this.buttonHill.Name = "buttonHill";
            this.buttonHill.Size = new System.Drawing.Size(128, 38);
            this.buttonHill.TabIndex = 0;
            this.buttonHill.Text = "Зашифровать";
            this.buttonHill.UseVisualStyleBackColor = true;
            this.buttonHill.Click += new System.EventHandler(this.buttonHill_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 76);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 455);
            this.textBox1.TabIndex = 1;
            // 
            // textBoxCipher
            // 
            this.textBoxCipher.Location = new System.Drawing.Point(230, 76);
            this.textBoxCipher.Multiline = true;
            this.textBoxCipher.Name = "textBoxCipher";
            this.textBoxCipher.Size = new System.Drawing.Size(218, 455);
            this.textBoxCipher.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Исходный текст";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Зашифрованный текст";
            // 
            // textBoxCesar
            // 
            this.textBoxCesar.Location = new System.Drawing.Point(454, 76);
            this.textBoxCesar.Multiline = true;
            this.textBoxCesar.Name = "textBoxCesar";
            this.textBoxCesar.Size = new System.Drawing.Size(282, 455);
            this.textBoxCesar.TabIndex = 5;
            // 
            // labelCeasar
            // 
            this.labelCeasar.AutoSize = true;
            this.labelCeasar.Location = new System.Drawing.Point(451, 56);
            this.labelCeasar.Name = "labelCeasar";
            this.labelCeasar.Size = new System.Drawing.Size(262, 17);
            this.labelCeasar.TabIndex = 6;
            this.labelCeasar.Text = "Зашифрованный текст(Шифр Цезаря)";
            // 
            // buttonCeasar
            // 
            this.buttonCeasar.Location = new System.Drawing.Point(146, 12);
            this.buttonCeasar.Name = "buttonCeasar";
            this.buttonCeasar.Size = new System.Drawing.Size(128, 38);
            this.buttonCeasar.TabIndex = 7;
            this.buttonCeasar.Text = "Шифр Цезаря";
            this.buttonCeasar.UseVisualStyleBackColor = true;
            this.buttonCeasar.Click += new System.EventHandler(this.buttonCeasar_Click);
            // 
            // textBoxCeasarMoreKey
            // 
            this.textBoxCeasarMoreKey.Location = new System.Drawing.Point(745, 76);
            this.textBoxCeasarMoreKey.Multiline = true;
            this.textBoxCeasarMoreKey.Name = "textBoxCeasarMoreKey";
            this.textBoxCeasarMoreKey.Size = new System.Drawing.Size(342, 455);
            this.textBoxCeasarMoreKey.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(742, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(345, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Зашифрованный текст(Шифр Цезаря + поговорка)";
            // 
            // buttonCeasarMoreKey
            // 
            this.buttonCeasarMoreKey.Location = new System.Drawing.Point(280, 12);
            this.buttonCeasarMoreKey.Name = "buttonCeasarMoreKey";
            this.buttonCeasarMoreKey.Size = new System.Drawing.Size(212, 38);
            this.buttonCeasarMoreKey.TabIndex = 10;
            this.buttonCeasarMoreKey.Text = "Шифр Цезаря + поговорка";
            this.buttonCeasarMoreKey.UseVisualStyleBackColor = true;
            this.buttonCeasarMoreKey.Click += new System.EventHandler(this.buttonCeasarMoreKey_Click);
            // 
            // textBoxLFSR
            // 
            this.textBoxLFSR.Location = new System.Drawing.Point(1093, 76);
            this.textBoxLFSR.Multiline = true;
            this.textBoxLFSR.Name = "textBoxLFSR";
            this.textBoxLFSR.Size = new System.Drawing.Size(308, 455);
            this.textBoxLFSR.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1093, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(313, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Зашифрованный текст(Шифр Цезаря + LFSR)";
            // 
            // buttonLFSR
            // 
            this.buttonLFSR.Location = new System.Drawing.Point(498, 12);
            this.buttonLFSR.Name = "buttonLFSR";
            this.buttonLFSR.Size = new System.Drawing.Size(212, 38);
            this.buttonLFSR.TabIndex = 13;
            this.buttonLFSR.Text = "Шифр Цезаря + LFSR";
            this.buttonLFSR.UseVisualStyleBackColor = true;
            this.buttonLFSR.Click += new System.EventHandler(this.buttonLFSR_Click);
            // 
            // buttonGraph
            // 
            this.buttonGraph.Location = new System.Drawing.Point(716, 13);
            this.buttonGraph.Name = "buttonGraph";
            this.buttonGraph.Size = new System.Drawing.Size(198, 37);
            this.buttonGraph.TabIndex = 14;
            this.buttonGraph.Text = "Графики";
            this.buttonGraph.UseVisualStyleBackColor = true;
            this.buttonGraph.Click += new System.EventHandler(this.buttonGraph_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 543);
            this.Controls.Add(this.buttonGraph);
            this.Controls.Add(this.buttonLFSR);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxLFSR);
            this.Controls.Add(this.buttonCeasarMoreKey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCeasarMoreKey);
            this.Controls.Add(this.buttonCeasar);
            this.Controls.Add(this.labelCeasar);
            this.Controls.Add(this.textBoxCesar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCipher);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonHill);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonHill;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxCipher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCesar;
        private System.Windows.Forms.Label labelCeasar;
        private System.Windows.Forms.Button buttonCeasar;
        private System.Windows.Forms.TextBox textBoxCeasarMoreKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCeasarMoreKey;
        private System.Windows.Forms.TextBox textBoxLFSR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonLFSR;
        private System.Windows.Forms.Button buttonGraph;
    }
}

