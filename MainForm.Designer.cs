namespace Contact_Registry
{
    partial class MainForm
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
            this.grpBoxName = new System.Windows.Forms.GroupBox();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBoxAdress = new System.Windows.Forms.GroupBox();
            this.txtBoxZip = new System.Windows.Forms.TextBox();
            this.txtBoxCity = new System.Windows.Forms.TextBox();
            this.txtBoxStreet = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxContacts = new System.Windows.Forms.ListBox();
            this.butt_add = new System.Windows.Forms.Button();
            this.butt_change = new System.Windows.Forms.Button();
            this.butt_delete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lab_nrOfRecords = new System.Windows.Forms.Label();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.grpBoxName.SuspendLayout();
            this.grpBoxAdress.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxName
            // 
            this.grpBoxName.Controls.Add(this.txtBoxLastName);
            this.grpBoxName.Controls.Add(this.txtBoxFirstName);
            this.grpBoxName.Controls.Add(this.label2);
            this.grpBoxName.Controls.Add(this.label1);
            this.grpBoxName.Location = new System.Drawing.Point(24, 25);
            this.grpBoxName.Name = "grpBoxName";
            this.grpBoxName.Size = new System.Drawing.Size(492, 85);
            this.grpBoxName.TabIndex = 0;
            this.grpBoxName.TabStop = false;
            this.grpBoxName.Text = "Name";
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Location = new System.Drawing.Point(115, 45);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(346, 20);
            this.txtBoxLastName.TabIndex = 3;
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Location = new System.Drawing.Point(115, 14);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(346, 20);
            this.txtBoxFirstName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First name";
            // 
            // grpBoxAdress
            // 
            this.grpBoxAdress.Controls.Add(this.cmbCountry);
            this.grpBoxAdress.Controls.Add(this.txtBoxZip);
            this.grpBoxAdress.Controls.Add(this.txtBoxCity);
            this.grpBoxAdress.Controls.Add(this.txtBoxStreet);
            this.grpBoxAdress.Controls.Add(this.label6);
            this.grpBoxAdress.Controls.Add(this.label5);
            this.grpBoxAdress.Controls.Add(this.label4);
            this.grpBoxAdress.Controls.Add(this.label3);
            this.grpBoxAdress.Location = new System.Drawing.Point(24, 116);
            this.grpBoxAdress.Name = "grpBoxAdress";
            this.grpBoxAdress.Size = new System.Drawing.Size(491, 171);
            this.grpBoxAdress.TabIndex = 1;
            this.grpBoxAdress.TabStop = false;
            this.grpBoxAdress.Text = "Address";
            // 
            // txtBoxZip
            // 
            this.txtBoxZip.Location = new System.Drawing.Point(115, 88);
            this.txtBoxZip.Name = "txtBoxZip";
            this.txtBoxZip.Size = new System.Drawing.Size(346, 20);
            this.txtBoxZip.TabIndex = 6;
            // 
            // txtBoxCity
            // 
            this.txtBoxCity.Location = new System.Drawing.Point(115, 56);
            this.txtBoxCity.Name = "txtBoxCity";
            this.txtBoxCity.Size = new System.Drawing.Size(346, 20);
            this.txtBoxCity.TabIndex = 5;
            // 
            // txtBoxStreet
            // 
            this.txtBoxStreet.Location = new System.Drawing.Point(115, 23);
            this.txtBoxStreet.Name = "txtBoxStreet";
            this.txtBoxStreet.Size = new System.Drawing.Size(346, 20);
            this.txtBoxStreet.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Country";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Zip code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Street";
            // 
            // listBoxContacts
            // 
            this.listBoxContacts.FormattingEnabled = true;
            this.listBoxContacts.Location = new System.Drawing.Point(24, 303);
            this.listBoxContacts.Name = "listBoxContacts";
            this.listBoxContacts.Size = new System.Drawing.Size(491, 277);
            this.listBoxContacts.TabIndex = 2;
            this.listBoxContacts.SelectedIndexChanged += new System.EventHandler(this.listBoxContacts_SelectedIndexChanged);
            // 
            // butt_add
            // 
            this.butt_add.Location = new System.Drawing.Point(570, 39);
            this.butt_add.Name = "butt_add";
            this.butt_add.Size = new System.Drawing.Size(148, 51);
            this.butt_add.TabIndex = 3;
            this.butt_add.Text = "ADD";
            this.butt_add.UseVisualStyleBackColor = true;
            this.butt_add.Click += new System.EventHandler(this.butt_add_Click);
            // 
            // butt_change
            // 
            this.butt_change.Location = new System.Drawing.Point(570, 116);
            this.butt_change.Name = "butt_change";
            this.butt_change.Size = new System.Drawing.Size(148, 51);
            this.butt_change.TabIndex = 4;
            this.butt_change.Text = "CHANGE";
            this.butt_change.UseVisualStyleBackColor = true;
            // 
            // butt_delete
            // 
            this.butt_delete.Location = new System.Drawing.Point(570, 192);
            this.butt_delete.Name = "butt_delete";
            this.butt_delete.Size = new System.Drawing.Size(148, 51);
            this.butt_delete.TabIndex = 5;
            this.butt_delete.Text = "DELETE";
            this.butt_delete.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(534, 567);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Number of added records";
            // 
            // lab_nrOfRecords
            // 
            this.lab_nrOfRecords.AutoSize = true;
            this.lab_nrOfRecords.Location = new System.Drawing.Point(682, 566);
            this.lab_nrOfRecords.Name = "lab_nrOfRecords";
            this.lab_nrOfRecords.Size = new System.Drawing.Size(103, 13);
            this.lab_nrOfRecords.TabIndex = 7;
            this.lab_nrOfRecords.Text = "Not implemented yet";
            // 
            // cmbCountry
            // 
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(115, 122);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(226, 21);
            this.cmbCountry.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 606);
            this.Controls.Add(this.lab_nrOfRecords);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.butt_delete);
            this.Controls.Add(this.butt_change);
            this.Controls.Add(this.butt_add);
            this.Controls.Add(this.listBoxContacts);
            this.Controls.Add(this.grpBoxAdress);
            this.Controls.Add(this.grpBoxName);
            this.Name = "MainForm";
            this.Text = "Contact Registry";
            this.grpBoxName.ResumeLayout(false);
            this.grpBoxName.PerformLayout();
            this.grpBoxAdress.ResumeLayout(false);
            this.grpBoxAdress.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxName;
        private System.Windows.Forms.TextBox txtBoxLastName;
        private System.Windows.Forms.TextBox txtBoxFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBoxAdress;
        private System.Windows.Forms.ListBox listBoxContacts;
        private System.Windows.Forms.TextBox txtBoxZip;
        private System.Windows.Forms.TextBox txtBoxCity;
        private System.Windows.Forms.TextBox txtBoxStreet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butt_add;
        private System.Windows.Forms.Button butt_change;
        private System.Windows.Forms.Button butt_delete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lab_nrOfRecords;
        private System.Windows.Forms.ComboBox cmbCountry;
    }
}

