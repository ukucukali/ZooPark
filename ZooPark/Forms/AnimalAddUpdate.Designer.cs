
namespace ZooPark.Forms
{
    partial class AnimalAddUpdate
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAnimalName = new System.Windows.Forms.TextBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.cbHaveOwner = new System.Windows.Forms.CheckBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtSpecies = new System.Windows.Forms.TextBox();
            this.cmbFavFood = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nudMass = new System.Windows.Forms.NumericUpDown();
            this.btnAnimalAddUpdate = new System.Windows.Forms.Button();
            this.clbKeepers = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudMass)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gender:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 188);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date Of Birth:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Owner:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 285);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Species:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 237);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mass:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 331);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Keeper:";
            // 
            // txtAnimalName
            // 
            this.txtAnimalName.Location = new System.Drawing.Point(198, 37);
            this.txtAnimalName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAnimalName.Name = "txtAnimalName";
            this.txtAnimalName.Size = new System.Drawing.Size(295, 26);
            this.txtAnimalName.TabIndex = 7;
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(198, 85);
            this.cmbGender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(295, 28);
            this.cmbGender.TabIndex = 8;
            this.cmbGender.SelectedIndexChanged += new System.EventHandler(this.cmbGender_SelectedIndexChanged);
            // 
            // cbHaveOwner
            // 
            this.cbHaveOwner.AutoSize = true;
            this.cbHaveOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHaveOwner.Location = new System.Drawing.Point(198, 140);
            this.cbHaveOwner.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbHaveOwner.Name = "cbHaveOwner";
            this.cbHaveOwner.Size = new System.Drawing.Size(138, 24);
            this.cbHaveOwner.TabIndex = 9;
            this.cbHaveOwner.Text = "Have Owner";
            this.cbHaveOwner.UseVisualStyleBackColor = true;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(198, 188);
            this.dtpDOB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(295, 26);
            this.dtpDOB.TabIndex = 10;
            // 
            // txtSpecies
            // 
            this.txtSpecies.Location = new System.Drawing.Point(198, 280);
            this.txtSpecies.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSpecies.Name = "txtSpecies";
            this.txtSpecies.Size = new System.Drawing.Size(295, 26);
            this.txtSpecies.TabIndex = 12;
            // 
            // cmbFavFood
            // 
            this.cmbFavFood.DisplayMember = "Name";
            this.cmbFavFood.FormattingEnabled = true;
            this.cmbFavFood.Location = new System.Drawing.Point(198, 457);
            this.cmbFavFood.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbFavFood.Name = "cmbFavFood";
            this.cmbFavFood.Size = new System.Drawing.Size(295, 28);
            this.cmbFavFood.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 462);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Favourite Food:";
            // 
            // nudMass
            // 
            this.nudMass.DecimalPlaces = 1;
            this.nudMass.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudMass.Location = new System.Drawing.Point(198, 234);
            this.nudMass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudMass.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudMass.Name = "nudMass";
            this.nudMass.Size = new System.Drawing.Size(297, 26);
            this.nudMass.TabIndex = 16;
            // 
            // btnAnimalAddUpdate
            // 
            this.btnAnimalAddUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnimalAddUpdate.Location = new System.Drawing.Point(384, 517);
            this.btnAnimalAddUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAnimalAddUpdate.Name = "btnAnimalAddUpdate";
            this.btnAnimalAddUpdate.Size = new System.Drawing.Size(112, 35);
            this.btnAnimalAddUpdate.TabIndex = 17;
            this.btnAnimalAddUpdate.Text = "Add";
            this.btnAnimalAddUpdate.UseVisualStyleBackColor = true;
            this.btnAnimalAddUpdate.Click += new System.EventHandler(this.btnAnimalAddUpdate_Click);
            // 
            // clbKeepers
            // 
            this.clbKeepers.FormattingEnabled = true;
            this.clbKeepers.Location = new System.Drawing.Point(198, 331);
            this.clbKeepers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clbKeepers.Name = "clbKeepers";
            this.clbKeepers.ScrollAlwaysVisible = true;
            this.clbKeepers.Size = new System.Drawing.Size(296, 96);
            this.clbKeepers.TabIndex = 18;
            // 
            // AnimalAddUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 562);
            this.Controls.Add(this.clbKeepers);
            this.Controls.Add(this.btnAnimalAddUpdate);
            this.Controls.Add(this.nudMass);
            this.Controls.Add(this.cmbFavFood);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSpecies);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.cbHaveOwner);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.txtAnimalName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AnimalAddUpdate";
            this.Text = "AnimalAddUpdate";
            ((System.ComponentModel.ISupportInitialize)(this.nudMass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAnimalName;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.CheckBox cbHaveOwner;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox txtSpecies;
        private System.Windows.Forms.ComboBox cmbFavFood;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudMass;
        private System.Windows.Forms.Button btnAnimalAddUpdate;
        private System.Windows.Forms.CheckedListBox clbKeepers;
    }
}