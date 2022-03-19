
namespace ZooPark.Forms
{
    partial class KeeperAddUpdate
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
            this.btnAnimalAddUpdate = new System.Windows.Forms.Button();
            this.txtKeeperSurname = new System.Windows.Forms.TextBox();
            this.txtKeeperName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAnimalAddUpdate
            // 
            this.btnAnimalAddUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnimalAddUpdate.Location = new System.Drawing.Point(255, 114);
            this.btnAnimalAddUpdate.Name = "btnAnimalAddUpdate";
            this.btnAnimalAddUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnAnimalAddUpdate.TabIndex = 34;
            this.btnAnimalAddUpdate.Text = "Add";
            this.btnAnimalAddUpdate.UseVisualStyleBackColor = true;
            this.btnAnimalAddUpdate.Click += new System.EventHandler(this.btnAnimalAddUpdate_Click);
            // 
            // txtKeeperSurname
            // 
            this.txtKeeperSurname.Location = new System.Drawing.Point(132, 74);
            this.txtKeeperSurname.Name = "txtKeeperSurname";
            this.txtKeeperSurname.Size = new System.Drawing.Size(198, 20);
            this.txtKeeperSurname.TabIndex = 29;
            // 
            // txtKeeperName
            // 
            this.txtKeeperName.Location = new System.Drawing.Point(132, 38);
            this.txtKeeperName.Name = "txtKeeperName";
            this.txtKeeperName.Size = new System.Drawing.Size(198, 20);
            this.txtKeeperName.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Surname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Keeper";
            // 
            // KeeperAddUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 179);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAnimalAddUpdate);
            this.Controls.Add(this.txtKeeperSurname);
            this.Controls.Add(this.txtKeeperName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "KeeperAddUpdate";
            this.Text = "KeeperAddUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnimalAddUpdate;
        private System.Windows.Forms.TextBox txtKeeperSurname;
        private System.Windows.Forms.TextBox txtKeeperName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}