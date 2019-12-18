namespace Exos_WindowsForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Label");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Button");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("CheckBox");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Root", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.lb_address = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.listBox_cities = new System.Windows.Forms.ListBox();
            this.rb_male = new System.Windows.Forms.RadioButton();
            this.rb_female = new System.Windows.Forms.RadioButton();
            this.cb_cs = new System.Windows.Forms.CheckBox();
            this.cb_asp = new System.Windows.Forms.CheckBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_address);
            this.groupBox1.Controls.Add(this.tb_name);
            this.groupBox1.Controls.Add(this.lb_address);
            this.groupBox1.Controls.Add(this.lb_name);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(249, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Details";
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(92, 53);
            this.tb_address.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(122, 20);
            this.tb_address.TabIndex = 3;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(92, 28);
            this.tb_name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(122, 20);
            this.tb_name.TabIndex = 2;
            // 
            // lb_address
            // 
            this.lb_address.AutoSize = true;
            this.lb_address.Location = new System.Drawing.Point(15, 57);
            this.lb_address.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_address.Name = "lb_address";
            this.lb_address.Size = new System.Drawing.Size(51, 15);
            this.lb_address.TabIndex = 1;
            this.lb_address.Text = "Address";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(15, 28);
            this.lb_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(41, 15);
            this.lb_name.TabIndex = 0;
            this.lb_name.Text = "Name";
            // 
            // listBox_cities
            // 
            this.listBox_cities.FormattingEnabled = true;
            this.listBox_cities.Items.AddRange(new object[] {
            "Dunkerque",
            "Toulouse",
            "Paris"});
            this.listBox_cities.Location = new System.Drawing.Point(26, 158);
            this.listBox_cities.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox_cities.Name = "listBox_cities";
            this.listBox_cities.Size = new System.Drawing.Size(91, 69);
            this.listBox_cities.TabIndex = 1;
            this.listBox_cities.SelectedIndexChanged += new System.EventHandler(this.listBox_cities_SelectedIndexChanged);
            // 
            // rb_male
            // 
            this.rb_male.AutoSize = true;
            this.rb_male.Location = new System.Drawing.Point(296, 34);
            this.rb_male.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rb_male.Name = "rb_male";
            this.rb_male.Size = new System.Drawing.Size(60, 20);
            this.rb_male.TabIndex = 2;
            this.rb_male.TabStop = true;
            this.rb_male.Text = "Male";
            this.rb_male.UseVisualStyleBackColor = true;
            // 
            // rb_female
            // 
            this.rb_female.AutoSize = true;
            this.rb_female.Location = new System.Drawing.Point(296, 63);
            this.rb_female.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rb_female.Name = "rb_female";
            this.rb_female.Size = new System.Drawing.Size(74, 20);
            this.rb_female.TabIndex = 3;
            this.rb_female.TabStop = true;
            this.rb_female.Text = "Female";
            this.rb_female.UseVisualStyleBackColor = true;
            // 
            // cb_cs
            // 
            this.cb_cs.AutoSize = true;
            this.cb_cs.Location = new System.Drawing.Point(296, 158);
            this.cb_cs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_cs.Name = "cb_cs";
            this.cb_cs.Size = new System.Drawing.Size(48, 21);
            this.cb_cs.TabIndex = 4;
            this.cb_cs.Text = "C#";
            this.cb_cs.UseVisualStyleBackColor = true;
            // 
            // cb_asp
            // 
            this.cb_asp.AutoSize = true;
            this.cb_asp.Location = new System.Drawing.Point(296, 188);
            this.cb_asp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_asp.Name = "cb_asp";
            this.cb_asp.Size = new System.Drawing.Size(56, 21);
            this.cb_asp.TabIndex = 5;
            this.cb_asp.Text = "ASP";
            this.cb_asp.UseVisualStyleBackColor = true;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(296, 257);
            this.btn_submit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(74, 26);
            this.btn_submit.TabIndex = 6;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(445, 34);
            this.treeView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "label";
            treeNode1.Text = "Label";
            treeNode2.Name = "button";
            treeNode2.Text = "Button";
            treeNode3.Name = "checkbox";
            treeNode3.Text = "CheckBox";
            treeNode4.Name = "root";
            treeNode4.Text = "Root";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.treeView1.Size = new System.Drawing.Size(92, 80);
            this.treeView1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(445, 128);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 323);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.cb_asp);
            this.Controls.Add(this.cb_cs);
            this.Controls.Add(this.rb_female);
            this.Controls.Add(this.rb_male);
            this.Controls.Add(this.listBox_cities);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label lb_address;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.ListBox listBox_cities;
        private System.Windows.Forms.RadioButton rb_male;
        private System.Windows.Forms.RadioButton rb_female;
        private System.Windows.Forms.CheckBox cb_cs;
        private System.Windows.Forms.CheckBox cb_asp;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}