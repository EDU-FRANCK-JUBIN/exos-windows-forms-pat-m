namespace Exos_WindowsForm
{
    partial class exo_hotel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(exo_hotel));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_hotel = new System.Windows.Forms.Label();
            this.btn_total = new System.Windows.Forms.Button();
            this.gb_roomCharges = new System.Windows.Forms.GroupBox();
            this.label_misc = new System.Windows.Forms.Label();
            this.label_parking = new System.Windows.Forms.Label();
            this.label_telephone = new System.Windows.Forms.Label();
            this.label_internet = new System.Windows.Forms.Label();
            this.label_roomService = new System.Windows.Forms.Label();
            this.tb_MiscCharge = new System.Windows.Forms.TextBox();
            this.tb_dailyParking = new System.Windows.Forms.TextBox();
            this.tb_telephoneCharge = new System.Windows.Forms.TextBox();
            this.tb_internetCharge = new System.Windows.Forms.TextBox();
            this.tb_roomServiceCharge = new System.Windows.Forms.TextBox();
            this.tb_dailyCharges = new System.Windows.Forms.TextBox();
            this.label_dailyCharges = new System.Windows.Forms.Label();
            this.label_numberNights = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cb_discount = new System.Windows.Forms.CheckBox();
            this.gb_total = new System.Windows.Forms.GroupBox();
            this.tb_total = new System.Windows.Forms.TextBox();
            this.label_total = new System.Windows.Forms.Label();
            this.tb_taxe = new System.Windows.Forms.TextBox();
            this.label_taxe = new System.Windows.Forms.Label();
            this.label_subtotal = new System.Windows.Forms.Label();
            this.label_additional = new System.Windows.Forms.Label();
            this.label_roomCharges = new System.Windows.Forms.Label();
            this.tb_subtotal = new System.Windows.Forms.TextBox();
            this.tb_additional = new System.Windows.Forms.TextBox();
            this.tb_roomCharge = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gb_roomCharges.SuspendLayout();
            this.gb_total.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label_hotel
            // 
            this.label_hotel.AutoSize = true;
            this.label_hotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hotel.Location = new System.Drawing.Point(-19, 169);
            this.label_hotel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_hotel.Name = "label_hotel";
            this.label_hotel.Size = new System.Drawing.Size(326, 95);
            this.label_hotel.TabIndex = 1;
            this.label_hotel.Text = "Le Tuty";
            this.label_hotel.Click += new System.EventHandler(this.label_hotel_Click);
            // 
            // btn_total
            // 
            this.btn_total.Location = new System.Drawing.Point(238, 268);
            this.btn_total.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_total.Name = "btn_total";
            this.btn_total.Size = new System.Drawing.Size(177, 39);
            this.btn_total.TabIndex = 2;
            this.btn_total.Text = "Total Charges";
            this.btn_total.UseVisualStyleBackColor = true;
            // 
            // gb_roomCharges
            // 
            this.gb_roomCharges.Controls.Add(this.label_misc);
            this.gb_roomCharges.Controls.Add(this.label_parking);
            this.gb_roomCharges.Controls.Add(this.label_telephone);
            this.gb_roomCharges.Controls.Add(this.label_internet);
            this.gb_roomCharges.Controls.Add(this.label_roomService);
            this.gb_roomCharges.Controls.Add(this.tb_MiscCharge);
            this.gb_roomCharges.Controls.Add(this.tb_dailyParking);
            this.gb_roomCharges.Controls.Add(this.tb_telephoneCharge);
            this.gb_roomCharges.Controls.Add(this.tb_internetCharge);
            this.gb_roomCharges.Controls.Add(this.tb_roomServiceCharge);
            this.gb_roomCharges.Controls.Add(this.tb_dailyCharges);
            this.gb_roomCharges.Controls.Add(this.label_dailyCharges);
            this.gb_roomCharges.Controls.Add(this.label_numberNights);
            this.gb_roomCharges.Controls.Add(this.textBox1);
            this.gb_roomCharges.Location = new System.Drawing.Point(324, 10);
            this.gb_roomCharges.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_roomCharges.Name = "gb_roomCharges";
            this.gb_roomCharges.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_roomCharges.Size = new System.Drawing.Size(246, 254);
            this.gb_roomCharges.TabIndex = 3;
            this.gb_roomCharges.TabStop = false;
            this.gb_roomCharges.Text = "Room Charges";
            // 
            // label_misc
            // 
            this.label_misc.AutoSize = true;
            this.label_misc.Location = new System.Drawing.Point(122, 214);
            this.label_misc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_misc.Name = "label_misc";
            this.label_misc.Size = new System.Drawing.Size(79, 15);
            this.label_misc.TabIndex = 13;
            this.label_misc.Text = "Misc. Charge";
            // 
            // label_parking
            // 
            this.label_parking.AutoSize = true;
            this.label_parking.Location = new System.Drawing.Point(119, 183);
            this.label_parking.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_parking.Name = "label_parking";
            this.label_parking.Size = new System.Drawing.Size(79, 15);
            this.label_parking.TabIndex = 12;
            this.label_parking.Text = "Daily Parking";
            // 
            // label_telephone
            // 
            this.label_telephone.AutoSize = true;
            this.label_telephone.Location = new System.Drawing.Point(119, 148);
            this.label_telephone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_telephone.Name = "label_telephone";
            this.label_telephone.Size = new System.Drawing.Size(109, 15);
            this.label_telephone.TabIndex = 11;
            this.label_telephone.Text = "Telephone Charge";
            // 
            // label_internet
            // 
            this.label_internet.AutoSize = true;
            this.label_internet.Location = new System.Drawing.Point(119, 117);
            this.label_internet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_internet.Name = "label_internet";
            this.label_internet.Size = new System.Drawing.Size(91, 15);
            this.label_internet.TabIndex = 10;
            this.label_internet.Text = "Internet Charge";
            // 
            // label_roomService
            // 
            this.label_roomService.AutoSize = true;
            this.label_roomService.Location = new System.Drawing.Point(119, 84);
            this.label_roomService.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_roomService.Name = "label_roomService";
            this.label_roomService.Size = new System.Drawing.Size(127, 15);
            this.label_roomService.TabIndex = 9;
            this.label_roomService.Text = "Room Service Charge";
            // 
            // tb_MiscCharge
            // 
            this.tb_MiscCharge.Location = new System.Drawing.Point(5, 214);
            this.tb_MiscCharge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_MiscCharge.Name = "tb_MiscCharge";
            this.tb_MiscCharge.Size = new System.Drawing.Size(110, 20);
            this.tb_MiscCharge.TabIndex = 8;
            // 
            // tb_dailyParking
            // 
            this.tb_dailyParking.Location = new System.Drawing.Point(5, 183);
            this.tb_dailyParking.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_dailyParking.Name = "tb_dailyParking";
            this.tb_dailyParking.Size = new System.Drawing.Size(110, 20);
            this.tb_dailyParking.TabIndex = 7;
            // 
            // tb_telephoneCharge
            // 
            this.tb_telephoneCharge.Location = new System.Drawing.Point(5, 148);
            this.tb_telephoneCharge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_telephoneCharge.Name = "tb_telephoneCharge";
            this.tb_telephoneCharge.Size = new System.Drawing.Size(110, 20);
            this.tb_telephoneCharge.TabIndex = 6;
            // 
            // tb_internetCharge
            // 
            this.tb_internetCharge.Location = new System.Drawing.Point(5, 117);
            this.tb_internetCharge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_internetCharge.Name = "tb_internetCharge";
            this.tb_internetCharge.Size = new System.Drawing.Size(110, 20);
            this.tb_internetCharge.TabIndex = 5;
            // 
            // tb_roomServiceCharge
            // 
            this.tb_roomServiceCharge.Location = new System.Drawing.Point(5, 84);
            this.tb_roomServiceCharge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_roomServiceCharge.Name = "tb_roomServiceCharge";
            this.tb_roomServiceCharge.Size = new System.Drawing.Size(110, 20);
            this.tb_roomServiceCharge.TabIndex = 4;
            // 
            // tb_dailyCharges
            // 
            this.tb_dailyCharges.Location = new System.Drawing.Point(5, 54);
            this.tb_dailyCharges.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_dailyCharges.Name = "tb_dailyCharges";
            this.tb_dailyCharges.Size = new System.Drawing.Size(110, 20);
            this.tb_dailyCharges.TabIndex = 3;
            // 
            // label_dailyCharges
            // 
            this.label_dailyCharges.AutoSize = true;
            this.label_dailyCharges.Location = new System.Drawing.Point(119, 54);
            this.label_dailyCharges.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_dailyCharges.Name = "label_dailyCharges";
            this.label_dailyCharges.Size = new System.Drawing.Size(83, 15);
            this.label_dailyCharges.TabIndex = 2;
            this.label_dailyCharges.Text = "Daily Charges";
            // 
            // label_numberNights
            // 
            this.label_numberNights.AutoSize = true;
            this.label_numberNights.Location = new System.Drawing.Point(119, 24);
            this.label_numberNights.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_numberNights.Name = "label_numberNights";
            this.label_numberNights.Size = new System.Drawing.Size(103, 15);
            this.label_numberNights.TabIndex = 1;
            this.label_numberNights.Text = "Number of Nights";
            this.label_numberNights.Click += new System.EventHandler(this.label_numberNights_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 24);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(111, 20);
            this.textBox1.TabIndex = 0;
            // 
            // cb_discount
            // 
            this.cb_discount.AutoSize = true;
            this.cb_discount.Location = new System.Drawing.Point(46, 321);
            this.cb_discount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_discount.Name = "cb_discount";
            this.cb_discount.Size = new System.Drawing.Size(109, 21);
            this.cb_discount.TabIndex = 4;
            this.cb_discount.Text = "15% Discount";
            this.cb_discount.UseVisualStyleBackColor = true;
            // 
            // gb_total
            // 
            this.gb_total.Controls.Add(this.tb_total);
            this.gb_total.Controls.Add(this.label_total);
            this.gb_total.Controls.Add(this.tb_taxe);
            this.gb_total.Controls.Add(this.label_taxe);
            this.gb_total.Controls.Add(this.label_subtotal);
            this.gb_total.Controls.Add(this.label_additional);
            this.gb_total.Controls.Add(this.label_roomCharges);
            this.gb_total.Controls.Add(this.tb_subtotal);
            this.gb_total.Controls.Add(this.tb_additional);
            this.gb_total.Controls.Add(this.tb_roomCharge);
            this.gb_total.Location = new System.Drawing.Point(46, 362);
            this.gb_total.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_total.Name = "gb_total";
            this.gb_total.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_total.Size = new System.Drawing.Size(524, 147);
            this.gb_total.TabIndex = 5;
            this.gb_total.TabStop = false;
            this.gb_total.Text = "Total Room Charges";
            // 
            // tb_total
            // 
            this.tb_total.Location = new System.Drawing.Point(365, 119);
            this.tb_total.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_total.Name = "tb_total";
            this.tb_total.Size = new System.Drawing.Size(101, 20);
            this.tb_total.TabIndex = 9;
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.ForeColor = System.Drawing.Color.Red;
            this.label_total.Location = new System.Drawing.Point(370, 92);
            this.label_total.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(97, 15);
            this.label_total.TabIndex = 8;
            this.label_total.Text = "TOTAL CHARGE";
            // 
            // tb_taxe
            // 
            this.tb_taxe.Location = new System.Drawing.Point(365, 60);
            this.tb_taxe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_taxe.Name = "tb_taxe";
            this.tb_taxe.Size = new System.Drawing.Size(101, 20);
            this.tb_taxe.TabIndex = 7;
            // 
            // label_taxe
            // 
            this.label_taxe.AutoSize = true;
            this.label_taxe.Location = new System.Drawing.Point(385, 37);
            this.label_taxe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_taxe.Name = "label_taxe";
            this.label_taxe.Size = new System.Drawing.Size(65, 15);
            this.label_taxe.TabIndex = 6;
            this.label_taxe.Text = "7.00% Tax";
            // 
            // label_subtotal
            // 
            this.label_subtotal.AutoSize = true;
            this.label_subtotal.Location = new System.Drawing.Point(160, 108);
            this.label_subtotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_subtotal.Name = "label_subtotal";
            this.label_subtotal.Size = new System.Drawing.Size(52, 15);
            this.label_subtotal.TabIndex = 5;
            this.label_subtotal.Text = "Subtotal";
            // 
            // label_additional
            // 
            this.label_additional.AutoSize = true;
            this.label_additional.Location = new System.Drawing.Point(160, 64);
            this.label_additional.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_additional.Name = "label_additional";
            this.label_additional.Size = new System.Drawing.Size(110, 15);
            this.label_additional.TabIndex = 4;
            this.label_additional.Text = "Additional Charges";
            // 
            // label_roomCharges
            // 
            this.label_roomCharges.AutoSize = true;
            this.label_roomCharges.Location = new System.Drawing.Point(160, 26);
            this.label_roomCharges.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_roomCharges.Name = "label_roomCharges";
            this.label_roomCharges.Size = new System.Drawing.Size(90, 15);
            this.label_roomCharges.TabIndex = 3;
            this.label_roomCharges.Text = "Room Charges";
            // 
            // tb_subtotal
            // 
            this.tb_subtotal.Location = new System.Drawing.Point(5, 106);
            this.tb_subtotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_subtotal.Name = "tb_subtotal";
            this.tb_subtotal.Size = new System.Drawing.Size(142, 20);
            this.tb_subtotal.TabIndex = 2;
            // 
            // tb_additional
            // 
            this.tb_additional.Location = new System.Drawing.Point(5, 64);
            this.tb_additional.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_additional.Name = "tb_additional";
            this.tb_additional.Size = new System.Drawing.Size(142, 20);
            this.tb_additional.TabIndex = 1;
            this.tb_additional.TextChanged += new System.EventHandler(this.tb_additional_TextChanged);
            // 
            // tb_roomCharge
            // 
            this.tb_roomCharge.Location = new System.Drawing.Point(5, 26);
            this.tb_roomCharge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_roomCharge.Name = "tb_roomCharge";
            this.tb_roomCharge.Size = new System.Drawing.Size(142, 20);
            this.tb_roomCharge.TabIndex = 0;
            // 
            // exo_hotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 537);
            this.Controls.Add(this.gb_total);
            this.Controls.Add(this.cb_discount);
            this.Controls.Add(this.gb_roomCharges);
            this.Controls.Add(this.btn_total);
            this.Controls.Add(this.label_hotel);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "exo_hotel";
            this.Text = "Hotel Grande Room Charges - Fall 2019";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gb_roomCharges.ResumeLayout(false);
            this.gb_roomCharges.PerformLayout();
            this.gb_total.ResumeLayout(false);
            this.gb_total.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_hotel;
        private System.Windows.Forms.Button btn_total;
        private System.Windows.Forms.GroupBox gb_roomCharges;
        private System.Windows.Forms.Label label_numberNights;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_misc;
        private System.Windows.Forms.Label label_parking;
        private System.Windows.Forms.Label label_telephone;
        private System.Windows.Forms.Label label_internet;
        private System.Windows.Forms.Label label_roomService;
        private System.Windows.Forms.TextBox tb_MiscCharge;
        private System.Windows.Forms.TextBox tb_dailyParking;
        private System.Windows.Forms.TextBox tb_telephoneCharge;
        private System.Windows.Forms.TextBox tb_internetCharge;
        private System.Windows.Forms.TextBox tb_roomServiceCharge;
        private System.Windows.Forms.TextBox tb_dailyCharges;
        private System.Windows.Forms.Label label_dailyCharges;
        private System.Windows.Forms.CheckBox cb_discount;
        private System.Windows.Forms.GroupBox gb_total;
        private System.Windows.Forms.TextBox tb_additional;
        private System.Windows.Forms.TextBox tb_roomCharge;
        private System.Windows.Forms.TextBox tb_total;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.TextBox tb_taxe;
        private System.Windows.Forms.Label label_taxe;
        private System.Windows.Forms.Label label_subtotal;
        private System.Windows.Forms.Label label_additional;
        private System.Windows.Forms.Label label_roomCharges;
        private System.Windows.Forms.TextBox tb_subtotal;
    }
}