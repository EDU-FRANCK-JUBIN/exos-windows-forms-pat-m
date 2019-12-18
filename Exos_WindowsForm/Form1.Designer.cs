namespace Exos_WindowsForm
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_username = new System.Windows.Forms.Label();
            this.tb_userName = new System.Windows.Forms.TextBox();
            this.lb_pass = new System.Windows.Forms.Label();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.bt_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Location = new System.Drawing.Point(87, 100);
            this.lb_username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(100, 15);
            this.lb_username.TabIndex = 0;
            this.lb_username.Text = "Nom d\'utilisateur";
            // 
            // tb_userName
            // 
            this.tb_userName.Location = new System.Drawing.Point(218, 100);
            this.tb_userName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_userName.Name = "tb_userName";
            this.tb_userName.Size = new System.Drawing.Size(120, 20);
            this.tb_userName.TabIndex = 1;
            // 
            // lb_pass
            // 
            this.lb_pass.AutoSize = true;
            this.lb_pass.Location = new System.Drawing.Point(89, 132);
            this.lb_pass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_pass.Name = "lb_pass";
            this.lb_pass.Size = new System.Drawing.Size(81, 15);
            this.lb_pass.TabIndex = 2;
            this.lb_pass.Text = "Mot de passe";
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(218, 127);
            this.tb_pass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(120, 20);
            this.tb_pass.TabIndex = 3;
            // 
            // bt_login
            // 
            this.bt_login.BackColor = System.Drawing.Color.LimeGreen;
            this.bt_login.ForeColor = System.Drawing.Color.White;
            this.bt_login.Location = new System.Drawing.Point(218, 165);
            this.bt_login.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(120, 23);
            this.bt_login.TabIndex = 4;
            this.bt_login.Text = "Connexion";
            this.bt_login.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 451);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.lb_pass);
            this.Controls.Add(this.tb_userName);
            this.Controls.Add(this.lb_username);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.TextBox tb_userName;
        private System.Windows.Forms.Label lb_pass;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.Button bt_login;
    }
}

