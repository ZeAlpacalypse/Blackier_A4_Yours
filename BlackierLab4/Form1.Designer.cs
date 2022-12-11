namespace BlackierLab4
{
    partial class Form1
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
            this.grpBook = new System.Windows.Forms.GroupBox();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkFlightInc = new System.Windows.Forms.CheckBox();
            this.radMexico = new System.Windows.Forms.RadioButton();
            this.radFlorida = new System.Windows.Forms.RadioButton();
            this.radCuba = new System.Windows.Forms.RadioButton();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radCash = new System.Windows.Forms.RadioButton();
            this.radCredit = new System.Windows.Forms.RadioButton();
            this.txtPeople = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpTrip = new System.Windows.Forms.GroupBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblTripInfo = new System.Windows.Forms.Label();
            this.grpBook.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpTrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBook
            // 
            this.grpBook.Controls.Add(this.btnBook);
            this.grpBook.Controls.Add(this.btnReset);
            this.grpBook.Controls.Add(this.groupBox2);
            this.grpBook.Controls.Add(this.txtPrice);
            this.grpBook.Controls.Add(this.label2);
            this.grpBook.Controls.Add(this.radCash);
            this.grpBook.Controls.Add(this.radCredit);
            this.grpBook.Controls.Add(this.txtPeople);
            this.grpBook.Controls.Add(this.label1);
            this.grpBook.Location = new System.Drawing.Point(12, 12);
            this.grpBook.Name = "grpBook";
            this.grpBook.Size = new System.Drawing.Size(181, 312);
            this.grpBook.TabIndex = 0;
            this.grpBook.TabStop = false;
            this.grpBook.Text = "Book";
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(99, 271);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(67, 35);
            this.btnBook.TabIndex = 5;
            this.btnBook.Text = "&Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(10, 271);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(67, 35);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox2.Controls.Add(this.chkFlightInc);
            this.groupBox2.Controls.Add(this.radMexico);
            this.groupBox2.Controls.Add(this.radFlorida);
            this.groupBox2.Controls.Add(this.radCuba);
            this.groupBox2.Location = new System.Drawing.Point(10, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(165, 127);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Location";
            // 
            // chkFlightInc
            // 
            this.chkFlightInc.AutoSize = true;
            this.chkFlightInc.Checked = true;
            this.chkFlightInc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFlightInc.Enabled = false;
            this.chkFlightInc.Location = new System.Drawing.Point(6, 100);
            this.chkFlightInc.Name = "chkFlightInc";
            this.chkFlightInc.Size = new System.Drawing.Size(122, 19);
            this.chkFlightInc.TabIndex = 3;
            this.chkFlightInc.Text = "Flight Included";
            this.chkFlightInc.UseVisualStyleBackColor = true;
            // 
            // radMexico
            // 
            this.radMexico.AutoSize = true;
            this.radMexico.Location = new System.Drawing.Point(6, 74);
            this.radMexico.Name = "radMexico";
            this.radMexico.Size = new System.Drawing.Size(71, 19);
            this.radMexico.TabIndex = 2;
            this.radMexico.TabStop = true;
            this.radMexico.Text = "Mexico";
            this.radMexico.UseVisualStyleBackColor = true;
            this.radMexico.CheckedChanged += new System.EventHandler(this.radMexico_CheckedChanged);
            // 
            // radFlorida
            // 
            this.radFlorida.AutoSize = true;
            this.radFlorida.Location = new System.Drawing.Point(6, 48);
            this.radFlorida.Name = "radFlorida";
            this.radFlorida.Size = new System.Drawing.Size(71, 19);
            this.radFlorida.TabIndex = 1;
            this.radFlorida.TabStop = true;
            this.radFlorida.Text = "Florida";
            this.radFlorida.UseVisualStyleBackColor = true;
            this.radFlorida.CheckedChanged += new System.EventHandler(this.radFlorida_CheckedChanged);
            // 
            // radCuba
            // 
            this.radCuba.AutoSize = true;
            this.radCuba.Location = new System.Drawing.Point(6, 22);
            this.radCuba.Name = "radCuba";
            this.radCuba.Size = new System.Drawing.Size(59, 19);
            this.radCuba.TabIndex = 0;
            this.radCuba.TabStop = true;
            this.radCuba.Text = "Cuba";
            this.radCuba.UseVisualStyleBackColor = true;
            this.radCuba.CheckedChanged += new System.EventHandler(this.radCuba_CheckedChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(45, 229);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(130, 23);
            this.txtPrice.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Price";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radCash
            // 
            this.radCash.AutoSize = true;
            this.radCash.Location = new System.Drawing.Point(6, 204);
            this.radCash.Name = "radCash";
            this.radCash.Size = new System.Drawing.Size(58, 19);
            this.radCash.TabIndex = 3;
            this.radCash.TabStop = true;
            this.radCash.Text = "Cash";
            this.radCash.UseVisualStyleBackColor = true;
            // 
            // radCredit
            // 
            this.radCredit.AutoSize = true;
            this.radCredit.Location = new System.Drawing.Point(6, 179);
            this.radCredit.Name = "radCredit";
            this.radCredit.Size = new System.Drawing.Size(101, 19);
            this.radCredit.TabIndex = 2;
            this.radCredit.TabStop = true;
            this.radCredit.Text = "Credit Card";
            this.radCredit.UseVisualStyleBackColor = true;
            // 
            // txtPeople
            // 
            this.txtPeople.Location = new System.Drawing.Point(70, 17);
            this.txtPeople.Name = "txtPeople";
            this.txtPeople.Size = new System.Drawing.Size(96, 23);
            this.txtPeople.TabIndex = 0;
            this.txtPeople.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "People:";
            // 
            // grpTrip
            // 
            this.grpTrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grpTrip.Controls.Add(this.btnConfirm);
            this.grpTrip.Controls.Add(this.lblTripInfo);
            this.grpTrip.Location = new System.Drawing.Point(199, 12);
            this.grpTrip.Name = "grpTrip";
            this.grpTrip.Size = new System.Drawing.Size(254, 312);
            this.grpTrip.TabIndex = 1;
            this.grpTrip.TabStop = false;
            this.grpTrip.Text = "Trip Information";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(88, 271);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(67, 35);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "&Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblTripInfo
            // 
            this.lblTripInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblTripInfo.Location = new System.Drawing.Point(6, 17);
            this.lblTripInfo.Name = "lblTripInfo";
            this.lblTripInfo.Size = new System.Drawing.Size(242, 235);
            this.lblTripInfo.TabIndex = 0;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnBook;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(494, 336);
            this.Controls.Add(this.grpTrip);
            this.Controls.Add(this.grpBook);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking by Chad Blackier";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBook.ResumeLayout(false);
            this.grpBook.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpTrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBook;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkFlightInc;
        private System.Windows.Forms.RadioButton radMexico;
        private System.Windows.Forms.RadioButton radFlorida;
        private System.Windows.Forms.RadioButton radCuba;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radCash;
        private System.Windows.Forms.RadioButton radCredit;
        private System.Windows.Forms.TextBox txtPeople;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpTrip;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblTripInfo;
    }
}

