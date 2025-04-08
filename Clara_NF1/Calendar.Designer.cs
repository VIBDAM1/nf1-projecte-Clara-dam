namespace Clara_NF1
{
    partial class Calendar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calendar));
            tableLayoutPanel14 = new TableLayoutPanel();
            tableLayoutPanel15 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            pictureBox5 = new PictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            anterior = new Button();
            seguent = new Button();
            tableLayoutPanel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel14
            // 
            resources.ApplyResources(tableLayoutPanel14, "tableLayoutPanel14");
            tableLayoutPanel14.Name = "tableLayoutPanel14";
            // 
            // tableLayoutPanel15
            // 
            resources.ApplyResources(tableLayoutPanel15, "tableLayoutPanel15");
            tableLayoutPanel15.Controls.Add(pictureBox1, 0, 1);
            tableLayoutPanel15.Controls.Add(pictureBox5, 1, 1);
            tableLayoutPanel15.Name = "tableLayoutPanel15";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            resources.ApplyResources(pictureBox5, "pictureBox5");
            pictureBox5.Name = "pictureBox5";
            pictureBox5.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.Black;
            resources.ApplyResources(tableLayoutPanel2, "tableLayoutPanel2");
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 1);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.FromArgb(64, 64, 64);
            resources.ApplyResources(tableLayoutPanel3, "tableLayoutPanel3");
            tableLayoutPanel3.Controls.Add(label1, 1, 0);
            tableLayoutPanel3.Controls.Add(pictureBox2, 1, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel1, 1, 2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Name = "label1";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(tableLayoutPanel1, "tableLayoutPanel1");
            tableLayoutPanel1.Controls.Add(anterior, 0, 0);
            tableLayoutPanel1.Controls.Add(seguent, 2, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // anterior
            // 
            anterior.BackColor = Color.SlateBlue;
            resources.ApplyResources(anterior, "anterior");
            anterior.FlatAppearance.BorderSize = 0;
            anterior.ForeColor = SystemColors.ButtonFace;
            anterior.Name = "anterior";
            anterior.UseVisualStyleBackColor = false;
            // 
            // seguent
            // 
            seguent.BackColor = Color.SlateBlue;
            resources.ApplyResources(seguent, "seguent");
            seguent.FlatAppearance.BorderSize = 0;
            seguent.ForeColor = SystemColors.ButtonFace;
            seguent.Name = "seguent";
            seguent.UseVisualStyleBackColor = false;
            // 
            // Calendar
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel2);
            Name = "Calendar";
            tableLayoutPanel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel14;
        private TableLayoutPanel tableLayoutPanel15;
        private PictureBox pictureBox1;
        private PictureBox pictureBox5;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label1;
        private PictureBox pictureBox2;
        private TableLayoutPanel tableLayoutPanel1;
        private Button anterior;
        private Button seguent;
    }
}