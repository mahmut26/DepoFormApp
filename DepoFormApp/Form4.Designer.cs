namespace DepoFormApp
{
    partial class Form4
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
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            label3 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(115, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(573, 27);
            textBox1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 5;
            label1.Text = "Malzeme Adı";
            // 
            // button1
            // 
            button1.Location = new Point(694, 22);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 120);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 10;
            label3.Text = "Adet";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(59, 117);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(72, 27);
            textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(254, 117);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(72, 27);
            textBox2.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(138, 124);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
            label2.TabIndex = 12;
            label2.Text = "Adet Eklenecek";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 182);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private Label label3;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label2;
    }
}