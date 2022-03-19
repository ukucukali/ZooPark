
namespace ZooPark
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
            this.dgvAnimals = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnKeeperUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbKeeper = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEditSelection = new System.Windows.Forms.ComboBox();
            this.btnKeeperDelete = new System.Windows.Forms.Button();
            this.btnFoodDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFood = new System.Windows.Forms.ComboBox();
            this.btnFoodUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimals)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAnimals
            // 
            this.dgvAnimals.AllowUserToAddRows = false;
            this.dgvAnimals.AllowUserToDeleteRows = false;
            this.dgvAnimals.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAnimals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAnimals.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAnimals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnimals.Location = new System.Drawing.Point(221, 13);
            this.dgvAnimals.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAnimals.Name = "dgvAnimals";
            this.dgvAnimals.ReadOnly = true;
            this.dgvAnimals.RowHeadersVisible = false;
            this.dgvAnimals.RowHeadersWidth = 62;
            this.dgvAnimals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAnimals.Size = new System.Drawing.Size(794, 562);
            this.dgvAnimals.TabIndex = 0;
            this.dgvAnimals.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvAnimals_MouseDoubleClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(781, 583);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 32);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(903, 583);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(112, 32);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnKeeperUpdate
            // 
            this.btnKeeperUpdate.Location = new System.Drawing.Point(12, 88);
            this.btnKeeperUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnKeeperUpdate.Name = "btnKeeperUpdate";
            this.btnKeeperUpdate.Size = new System.Drawing.Size(78, 32);
            this.btnKeeperUpdate.TabIndex = 3;
            this.btnKeeperUpdate.Text = "Update";
            this.btnKeeperUpdate.UseVisualStyleBackColor = true;
            this.btnKeeperUpdate.Click += new System.EventHandler(this.btnKeeperUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(7, 97);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 32);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbKeeper
            // 
            this.cmbKeeper.DisplayMember = "Name";
            this.cmbKeeper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKeeper.FormattingEnabled = true;
            this.cmbKeeper.Location = new System.Drawing.Point(12, 46);
            this.cmbKeeper.Name = "cmbKeeper";
            this.cmbKeeper.Size = new System.Drawing.Size(202, 34);
            this.cmbKeeper.TabIndex = 5;
            this.cmbKeeper.SelectedIndexChanged += new System.EventHandler(this.cmbBakicilar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Zoo Keepers";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbEditSelection);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Location = new System.Drawing.Point(12, 479);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 136);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "Add";
            // 
            // cmbEditSelection
            // 
            this.cmbEditSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditSelection.FormattingEnabled = true;
            this.cmbEditSelection.Location = new System.Drawing.Point(7, 54);
            this.cmbEditSelection.Name = "cmbEditSelection";
            this.cmbEditSelection.Size = new System.Drawing.Size(188, 34);
            this.cmbEditSelection.TabIndex = 8;
            // 
            // btnKeeperDelete
            // 
            this.btnKeeperDelete.Location = new System.Drawing.Point(118, 88);
            this.btnKeeperDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnKeeperDelete.Name = "btnKeeperDelete";
            this.btnKeeperDelete.Size = new System.Drawing.Size(77, 32);
            this.btnKeeperDelete.TabIndex = 8;
            this.btnKeeperDelete.Text = "Delete";
            this.btnKeeperDelete.UseVisualStyleBackColor = true;
            this.btnKeeperDelete.Click += new System.EventHandler(this.btnKeeperDelete_Click);
            // 
            // btnFoodDelete
            // 
            this.btnFoodDelete.Location = new System.Drawing.Point(113, 249);
            this.btnFoodDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnFoodDelete.Name = "btnFoodDelete";
            this.btnFoodDelete.Size = new System.Drawing.Size(77, 32);
            this.btnFoodDelete.TabIndex = 12;
            this.btnFoodDelete.Text = "Delete";
            this.btnFoodDelete.UseVisualStyleBackColor = true;
            this.btnFoodDelete.Click += new System.EventHandler(this.btnFoodDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "Food";
            // 
            // cmbFood
            // 
            this.cmbFood.DisplayMember = "Name";
            this.cmbFood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFood.FormattingEnabled = true;
            this.cmbFood.Location = new System.Drawing.Point(7, 207);
            this.cmbFood.Name = "cmbFood";
            this.cmbFood.Size = new System.Drawing.Size(202, 34);
            this.cmbFood.TabIndex = 10;
            // 
            // btnFoodUpdate
            // 
            this.btnFoodUpdate.Location = new System.Drawing.Point(7, 249);
            this.btnFoodUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnFoodUpdate.Name = "btnFoodUpdate";
            this.btnFoodUpdate.Size = new System.Drawing.Size(78, 32);
            this.btnFoodUpdate.TabIndex = 9;
            this.btnFoodUpdate.Text = "Update";
            this.btnFoodUpdate.UseVisualStyleBackColor = true;
            this.btnFoodUpdate.Click += new System.EventHandler(this.btnFoodUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 624);
            this.Controls.Add(this.btnFoodDelete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbFood);
            this.Controls.Add(this.btnFoodUpdate);
            this.Controls.Add(this.btnKeeperDelete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbKeeper);
            this.Controls.Add(this.btnKeeperUpdate);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvAnimals);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "ZooPark";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimals)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvAnimals;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnKeeperUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbKeeper;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbEditSelection;
        private System.Windows.Forms.Button btnKeeperDelete;
        private System.Windows.Forms.Button btnFoodDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFood;
        private System.Windows.Forms.Button btnFoodUpdate;
    }
}

