//namespace DepoFormApp
//{
//    partial class Form2
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            pictureBox1 = new PictureBox();
//            button1 = new Button();
//            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
//            SuspendLayout();
//            // 
//            // pictureBox1
//            // 
//            pictureBox1.Location = new Point(18, 19);
//            pictureBox1.Name = "pictureBox1";
//            pictureBox1.Size = new Size(348, 270);
//            pictureBox1.TabIndex = 0;
//            pictureBox1.TabStop = false;
//            pictureBox1.Click += pictureBox1_Click;
//            // 
//            // button1
//            // 
//            button1.Location = new Point(372, 137);
//            button1.Name = "button1";
//            button1.Size = new Size(59, 42);
//            button1.TabIndex = 1;
//            button1.Text = "Yazdır";
//            button1.UseVisualStyleBackColor = true;
//            button1.Click += button1_Click_1;
//            // 
//            // Form2
//            // 
//            AutoScaleDimensions = new SizeF(8F, 20F);
//            AutoScaleMode = AutoScaleMode.Font;
//            ClientSize = new Size(443, 319);
//            Controls.Add(button1);
//            Controls.Add(pictureBox1);
//            Name = "Form2";
//            Text = "Form2";
//            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
//            ResumeLayout(false);
//        }

//        #endregion

//        private PictureBox pictureBox1;
//        private Button button1;
//    }
//}
namespace DepoFormApp
{
    partial class Form2
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
            this.pictureBox1 = new PictureBox();
            this.button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();  // Ensure calling this method on the current form
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new Point(18, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Size(348, 270);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Location = new Point(372, 137);
            this.button1.Name = "button1";
            this.button1.Size = new Size(59, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Yazdır";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(443, 319);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false); // Ensure calling this method on the current form
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
    }
}
