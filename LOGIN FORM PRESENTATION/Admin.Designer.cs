namespace LOGIN_FORM_PRESENTATION
{
    partial class Admin
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridBT = new System.Windows.Forms.Button();
            this.groupBoxData = new System.Windows.Forms.GroupBox();
            this.groupBoxUpdate = new System.Windows.Forms.GroupBox();
            this.groupBoxDelete = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataEditBT = new System.Windows.Forms.Button();
            this.dataDeleteBT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.accountEditBT = new System.Windows.Forms.Button();
            this.logoutBT = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.deleteIDTextBox = new System.Windows.Forms.TextBox();
            this.deleteUserNIdBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxData.SuspendLayout();
            this.groupBoxUpdate.SuspendLayout();
            this.groupBoxDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LOGIN_FORM_PRESENTATION.Properties.Resources.loadingScreen;
            this.pictureBox1.Location = new System.Drawing.Point(48, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridBT
            // 
            this.dataGridBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(102)))), ((int)(((byte)(240)))));
            this.dataGridBT.FlatAppearance.BorderSize = 0;
            this.dataGridBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridBT.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridBT.ForeColor = System.Drawing.Color.White;
            this.dataGridBT.Location = new System.Drawing.Point(48, 166);
            this.dataGridBT.Name = "dataGridBT";
            this.dataGridBT.Size = new System.Drawing.Size(119, 35);
            this.dataGridBT.TabIndex = 2;
            this.dataGridBT.Text = "VIEW";
            this.dataGridBT.UseVisualStyleBackColor = false;
            this.dataGridBT.Click += new System.EventHandler(this.dataGridBT_Click);
            // 
            // groupBoxData
            // 
            this.groupBoxData.Controls.Add(this.dataGridView1);
            this.groupBoxData.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxData.ForeColor = System.Drawing.Color.White;
            this.groupBoxData.Location = new System.Drawing.Point(238, 124);
            this.groupBoxData.Name = "groupBoxData";
            this.groupBoxData.Size = new System.Drawing.Size(514, 315);
            this.groupBoxData.TabIndex = 3;
            this.groupBoxData.TabStop = false;
            this.groupBoxData.Text = "DATA GRID";
            // 
            // groupBoxUpdate
            // 
            this.groupBoxUpdate.Controls.Add(this.idTextBox);
            this.groupBoxUpdate.Controls.Add(this.passwordTextBox);
            this.groupBoxUpdate.Controls.Add(this.emailTextBox);
            this.groupBoxUpdate.Controls.Add(this.usernameTextBox);
            this.groupBoxUpdate.Controls.Add(this.label4);
            this.groupBoxUpdate.Controls.Add(this.accountEditBT);
            this.groupBoxUpdate.Controls.Add(this.label3);
            this.groupBoxUpdate.Controls.Add(this.label5);
            this.groupBoxUpdate.Controls.Add(this.label2);
            this.groupBoxUpdate.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxUpdate.ForeColor = System.Drawing.Color.White;
            this.groupBoxUpdate.Location = new System.Drawing.Point(238, 124);
            this.groupBoxUpdate.Name = "groupBoxUpdate";
            this.groupBoxUpdate.Size = new System.Drawing.Size(514, 315);
            this.groupBoxUpdate.TabIndex = 3;
            this.groupBoxUpdate.TabStop = false;
            this.groupBoxUpdate.Text = "EDIT ACCOUNT";
            // 
            // groupBoxDelete
            // 
            this.groupBoxDelete.Controls.Add(this.deleteUserNIdBT);
            this.groupBoxDelete.Controls.Add(this.deleteIDTextBox);
            this.groupBoxDelete.Controls.Add(this.label6);
            this.groupBoxDelete.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDelete.ForeColor = System.Drawing.Color.White;
            this.groupBoxDelete.Location = new System.Drawing.Point(238, 124);
            this.groupBoxDelete.Name = "groupBoxDelete";
            this.groupBoxDelete.Size = new System.Drawing.Size(514, 315);
            this.groupBoxDelete.TabIndex = 3;
            this.groupBoxDelete.TabStop = false;
            this.groupBoxDelete.Text = "DELETE ACCOUNT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(385, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 48);
            this.label1.TabIndex = 4;
            this.label1.Text = "ADMINISTRATOR";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(7, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(501, 282);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataEditBT
            // 
            this.dataEditBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(102)))), ((int)(((byte)(240)))));
            this.dataEditBT.FlatAppearance.BorderSize = 0;
            this.dataEditBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataEditBT.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataEditBT.ForeColor = System.Drawing.Color.White;
            this.dataEditBT.Location = new System.Drawing.Point(48, 216);
            this.dataEditBT.Name = "dataEditBT";
            this.dataEditBT.Size = new System.Drawing.Size(119, 35);
            this.dataEditBT.TabIndex = 2;
            this.dataEditBT.Text = "EDIT";
            this.dataEditBT.UseVisualStyleBackColor = false;
            this.dataEditBT.Click += new System.EventHandler(this.dataEditBT_Click);
            // 
            // dataDeleteBT
            // 
            this.dataDeleteBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(102)))), ((int)(((byte)(240)))));
            this.dataDeleteBT.FlatAppearance.BorderSize = 0;
            this.dataDeleteBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataDeleteBT.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataDeleteBT.ForeColor = System.Drawing.Color.White;
            this.dataDeleteBT.Location = new System.Drawing.Point(48, 267);
            this.dataDeleteBT.Name = "dataDeleteBT";
            this.dataDeleteBT.Size = new System.Drawing.Size(119, 35);
            this.dataDeleteBT.TabIndex = 2;
            this.dataDeleteBT.Text = "DELETE";
            this.dataDeleteBT.UseVisualStyleBackColor = false;
            this.dataDeleteBT.Click += new System.EventHandler(this.dataDeleteBT_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "USERNAME";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTextBox.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.ForeColor = System.Drawing.Color.White;
            this.usernameTextBox.Location = new System.Drawing.Point(131, 116);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(268, 23);
            this.usernameTextBox.TabIndex = 1;
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTextBox.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.ForeColor = System.Drawing.Color.White;
            this.emailTextBox.Location = new System.Drawing.Point(131, 174);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(268, 23);
            this.emailTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "EMAIL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "PASSWORD";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.White;
            this.passwordTextBox.Location = new System.Drawing.Point(131, 236);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(268, 23);
            this.passwordTextBox.TabIndex = 1;
            // 
            // accountEditBT
            // 
            this.accountEditBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(102)))), ((int)(((byte)(240)))));
            this.accountEditBT.FlatAppearance.BorderSize = 0;
            this.accountEditBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountEditBT.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountEditBT.ForeColor = System.Drawing.Color.White;
            this.accountEditBT.Location = new System.Drawing.Point(131, 270);
            this.accountEditBT.Name = "accountEditBT";
            this.accountEditBT.Size = new System.Drawing.Size(268, 29);
            this.accountEditBT.TabIndex = 2;
            this.accountEditBT.Text = "EDIT";
            this.accountEditBT.UseVisualStyleBackColor = false;
            this.accountEditBT.Click += new System.EventHandler(this.accountEditBT_Click);
            // 
            // logoutBT
            // 
            this.logoutBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(102)))), ((int)(((byte)(240)))));
            this.logoutBT.FlatAppearance.BorderSize = 0;
            this.logoutBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBT.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBT.ForeColor = System.Drawing.Color.White;
            this.logoutBT.Location = new System.Drawing.Point(48, 404);
            this.logoutBT.Name = "logoutBT";
            this.logoutBT.Size = new System.Drawing.Size(119, 35);
            this.logoutBT.TabIndex = 2;
            this.logoutBT.Text = "LOG OUT";
            this.logoutBT.UseVisualStyleBackColor = false;
            this.logoutBT.Click += new System.EventHandler(this.logoutBT_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idTextBox.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.ForeColor = System.Drawing.Color.White;
            this.idTextBox.Location = new System.Drawing.Point(131, 58);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(268, 23);
            this.idTextBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(127, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID";
            // 
            // deleteIDTextBox
            // 
            this.deleteIDTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.deleteIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.deleteIDTextBox.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteIDTextBox.ForeColor = System.Drawing.Color.White;
            this.deleteIDTextBox.Location = new System.Drawing.Point(131, 143);
            this.deleteIDTextBox.Name = "deleteIDTextBox";
            this.deleteIDTextBox.Size = new System.Drawing.Size(268, 23);
            this.deleteIDTextBox.TabIndex = 1;
            // 
            // deleteUserNIdBT
            // 
            this.deleteUserNIdBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(102)))), ((int)(((byte)(240)))));
            this.deleteUserNIdBT.FlatAppearance.BorderSize = 0;
            this.deleteUserNIdBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteUserNIdBT.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteUserNIdBT.ForeColor = System.Drawing.Color.White;
            this.deleteUserNIdBT.Location = new System.Drawing.Point(131, 187);
            this.deleteUserNIdBT.Name = "deleteUserNIdBT";
            this.deleteUserNIdBT.Size = new System.Drawing.Size(268, 29);
            this.deleteUserNIdBT.TabIndex = 3;
            this.deleteUserNIdBT.Text = "REMOVE";
            this.deleteUserNIdBT.UseVisualStyleBackColor = false;
            this.deleteUserNIdBT.Click += new System.EventHandler(this.deleteUserNIdBT_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.groupBoxDelete);
            this.Controls.Add(this.groupBoxUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxData);
            this.Controls.Add(this.logoutBT);
            this.Controls.Add(this.dataDeleteBT);
            this.Controls.Add(this.dataEditBT);
            this.Controls.Add(this.dataGridBT);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "12";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxData.ResumeLayout(false);
            this.groupBoxUpdate.ResumeLayout(false);
            this.groupBoxUpdate.PerformLayout();
            this.groupBoxDelete.ResumeLayout(false);
            this.groupBoxDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button dataGridBT;
        private System.Windows.Forms.GroupBox groupBoxData;
        private System.Windows.Forms.GroupBox groupBoxUpdate;
        private System.Windows.Forms.GroupBox groupBoxDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dataEditBT;
        private System.Windows.Forms.Button dataDeleteBT;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button accountEditBT;
        private System.Windows.Forms.Button logoutBT;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button deleteUserNIdBT;
        private System.Windows.Forms.TextBox deleteIDTextBox;
        private System.Windows.Forms.Label label6;
        }
}