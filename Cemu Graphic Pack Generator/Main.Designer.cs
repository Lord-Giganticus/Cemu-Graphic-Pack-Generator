
namespace Cemu_Graphic_Pack_Generator
{
    partial class Main
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
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Title IDs");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Folders for pack");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode3.Name = "Title IDs";
            treeNode3.Text = "Title IDs";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.treeView1.Size = new System.Drawing.Size(162, 87);
            this.treeView1.TabIndex = 0;
            this.treeView1.MouseUp += new System.Windows.Forms.MouseEventHandler(TreeView1_MouseUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 87);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add a TitleID";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // treeView2
            // 
            this.treeView2.Location = new System.Drawing.Point(13, 105);
            this.treeView2.Name = "treeView2";
            treeNode4.Name = "Folders for pack";
            treeNode4.Text = "Folders for pack";
            this.treeView2.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.treeView2.Size = new System.Drawing.Size(161, 87);
            this.treeView2.TabIndex = 2;
            this.treeView2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TreeView2_MouseUp);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(180, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 87);
            this.button2.TabIndex = 3;
            this.button2.Text = "Add a folder";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 301);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(328, 23);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Path relative to CEMU folder";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(132, 330);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 27);
            this.button3.TabIndex = 6;
            this.button3.Text = "Generate";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 213);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(328, 23);
            this.textBox2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name of the path";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 257);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(328, 23);
            this.textBox3.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Description";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 363);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.treeView2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "Cemu Graphic Pack Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
    }
}

