namespace build_a_fit
{
    partial class Form1
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
            label1 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            Upload = new TabPage();
            button2 = new Button();
            Wardrobe = new TabPage();
            Recommendations = new TabPage();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            Upload.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(68, 36);
            label1.Name = "label1";
            label1.Size = new Size(215, 21);
            label1.TabIndex = 0;
            label1.Text = "Upload a image to get started";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(115, 204);
            button1.Name = "button1";
            button1.Size = new Size(137, 32);
            button1.TabIndex = 1;
            button1.Text = "Upload Image";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btn_upload;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(98, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(164, 120);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Upload);
            tabControl1.Controls.Add(Wardrobe);
            tabControl1.Controls.Add(Recommendations);
            tabControl1.Location = new Point(-2, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(384, 294);
            tabControl1.TabIndex = 3;
            // 
            // Upload
            // 
            Upload.Controls.Add(button2);
            Upload.Controls.Add(label1);
            Upload.Controls.Add(button1);
            Upload.Controls.Add(pictureBox1);
            Upload.Location = new Point(4, 24);
            Upload.Name = "Upload";
            Upload.Padding = new Padding(3);
            Upload.Size = new Size(376, 266);
            Upload.TabIndex = 0;
            Upload.Text = "Upload";
            Upload.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(258, 233);
            button2.Name = "button2";
            button2.Size = new Size(106, 29);
            button2.TabIndex = 3;
            button2.Text = "Next";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btn_next;
            // 
            // Wardrobe
            // 
            Wardrobe.Location = new Point(4, 24);
            Wardrobe.Name = "Wardrobe";
            Wardrobe.Padding = new Padding(3);
            Wardrobe.Size = new Size(376, 266);
            Wardrobe.TabIndex = 1;
            Wardrobe.Text = "Wardrobe";
            Wardrobe.UseVisualStyleBackColor = true;
            // 
            // Recommendations
            // 
            Recommendations.Location = new Point(4, 24);
            Recommendations.Name = "Recommendations";
            Recommendations.Size = new Size(376, 266);
            Recommendations.TabIndex = 2;
            Recommendations.Text = "Recommendations";
            Recommendations.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 297);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            Upload.ResumeLayout(false);
            Upload.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage Upload;
        private TabPage Wardrobe;
        private Button button2;
        private TabPage Recommendations;
    }
}