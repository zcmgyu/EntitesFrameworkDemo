namespace EntitesFrameworkDemo
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtStandardName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cbbStandard = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtDescriptionUpdate = new System.Windows.Forms.TextBox();
            this.txtStandardNameUpdate = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(103, 66);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtStandardName
            // 
            this.txtStandardName.Location = new System.Drawing.Point(78, 13);
            this.txtStandardName.Name = "txtStandardName";
            this.txtStandardName.Size = new System.Drawing.Size(100, 20);
            this.txtStandardName.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(78, 40);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 20);
            this.txtDescription.TabIndex = 2;
            // 
            // cbbStandard
            // 
            this.cbbStandard.FormattingEnabled = true;
            this.cbbStandard.Location = new System.Drawing.Point(221, 12);
            this.cbbStandard.Name = "cbbStandard";
            this.cbbStandard.Size = new System.Drawing.Size(121, 21);
            this.cbbStandard.TabIndex = 3;
            this.cbbStandard.SelectedIndexChanged += new System.EventHandler(this.cbbStandard_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(509, 226);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(415, 226);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtDescriptionUpdate
            // 
            this.txtDescriptionUpdate.Location = new System.Drawing.Point(460, 40);
            this.txtDescriptionUpdate.Name = "txtDescriptionUpdate";
            this.txtDescriptionUpdate.Size = new System.Drawing.Size(100, 20);
            this.txtDescriptionUpdate.TabIndex = 7;
            // 
            // txtStandardNameUpdate
            // 
            this.txtStandardNameUpdate.Location = new System.Drawing.Point(460, 12);
            this.txtStandardNameUpdate.Name = "txtStandardNameUpdate";
            this.txtStandardNameUpdate.Size = new System.Drawing.Size(100, 20);
            this.txtStandardNameUpdate.TabIndex = 6;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(311, 226);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 261);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtDescriptionUpdate);
            this.Controls.Add(this.txtStandardNameUpdate);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.cbbStandard);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtStandardName);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtStandardName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cbbStandard;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtDescriptionUpdate;
        private System.Windows.Forms.TextBox txtStandardNameUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}

