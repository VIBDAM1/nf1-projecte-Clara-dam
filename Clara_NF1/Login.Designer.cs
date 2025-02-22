namespace Clara_NF1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            tableLayoutPanel2 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            label3 = new Label();
            textBox1 = new TextBox();
            button3 = new Button();
            textBox2 = new TextBox();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.142857F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85.71428F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.1428566F));
            tableLayoutPanel2.Controls.Add(pictureBox1, 1, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 1, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 61F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 28F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel2.Size = new Size(690, 793);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(52, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(585, 477);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(52, 533);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 95F));
            tableLayoutPanel1.Size = new Size(585, 216);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.FromArgb(64, 64, 64);
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel3.Controls.Add(label3, 1, 3);
            tableLayoutPanel3.Controls.Add(textBox1, 1, 1);
            tableLayoutPanel3.Controls.Add(button3, 1, 4);
            tableLayoutPanel3.Controls.Add(textBox2, 1, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(90, 13);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 6;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 12F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 29F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 29F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 11F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 31F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel3.Size = new Size(403, 200);
            tableLayoutPanel3.TabIndex = 8;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(121, 115);
            label3.Margin = new Padding(0, 0, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(157, 17);
            label3.TabIndex = 7;
            label3.Text = "He oblidat la contrasenya";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left;
            textBox1.Font = new Font("Carlito", 12F);
            textBox1.Location = new Point(63, 24);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Nom d'usuari o correu electrònic";
            textBox1.Size = new Size(276, 27);
            textBox1.TabIndex = 12;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Left;
            button3.BackColor = Color.SlateBlue;
            button3.FlatAppearance.BorderColor = Color.SlateBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Carlito", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(63, 145);
            button3.Name = "button3";
            button3.Size = new Size(276, 31);
            button3.TabIndex = 4;
            button3.Text = "Inicia Sessió";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Left;
            textBox2.Font = new Font("Carlito", 12F);
            textBox2.Location = new Point(63, 75);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Contrasenya";
            textBox2.Size = new Size(276, 27);
            textBox2.TabIndex = 13;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(690, 793);
            Controls.Add(tableLayoutPanel2);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Login";
            Text = "y";
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel3;
        private Button button3;
        private Label label3;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}