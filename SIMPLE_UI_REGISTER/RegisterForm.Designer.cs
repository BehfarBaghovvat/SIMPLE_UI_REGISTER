namespace SIMPLE_UI_REGISTER
{
	partial class RegisterForm
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.userListDataGridView = new System.Windows.Forms.DataGridView();
			this.informatoionUserGroupBox = new System.Windows.Forms.GroupBox();
			this.addressTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.lastNameTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.firstNameTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.saveButton = new System.Windows.Forms.Button();
			this.clearButton = new System.Windows.Forms.Button();
			this.cancelBtton = new System.Windows.Forms.Button();
			this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.userListDataGridView)).BeginInit();
			this.informatoionUserGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// userListDataGridView
			// 
			this.userListDataGridView.AllowUserToAddRows = false;
			this.userListDataGridView.AllowUserToDeleteRows = false;
			this.userListDataGridView.AutoGenerateColumns = false;
			this.userListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.userListDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.userListDataGridView.ColumnHeadersHeight = 30;
			this.userListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.userListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
			this.userListDataGridView.DataSource = this.userBindingSource;
			this.userListDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
			this.userListDataGridView.Location = new System.Drawing.Point(0, 0);
			this.userListDataGridView.Name = "userListDataGridView";
			this.userListDataGridView.ReadOnly = true;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.userListDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.userListDataGridView.RowHeadersWidth = 30;
			this.userListDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.userListDataGridView.Size = new System.Drawing.Size(612, 255);
			this.userListDataGridView.TabIndex = 0;
			// 
			// informatoionUserGroupBox
			// 
			this.informatoionUserGroupBox.Controls.Add(this.addressTextBox);
			this.informatoionUserGroupBox.Controls.Add(this.label3);
			this.informatoionUserGroupBox.Controls.Add(this.lastNameTextBox);
			this.informatoionUserGroupBox.Controls.Add(this.label2);
			this.informatoionUserGroupBox.Controls.Add(this.firstNameTextBox);
			this.informatoionUserGroupBox.Controls.Add(this.label1);
			this.informatoionUserGroupBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.informatoionUserGroupBox.Location = new System.Drawing.Point(146, 261);
			this.informatoionUserGroupBox.Name = "informatoionUserGroupBox";
			this.informatoionUserGroupBox.Size = new System.Drawing.Size(321, 148);
			this.informatoionUserGroupBox.TabIndex = 1;
			this.informatoionUserGroupBox.TabStop = false;
			this.informatoionUserGroupBox.Text = "اطلاعات کاربری";
			// 
			// addressTextBox
			// 
			this.addressTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addressTextBox.Location = new System.Drawing.Point(14, 85);
			this.addressTextBox.MaxLength = 200;
			this.addressTextBox.Multiline = true;
			this.addressTextBox.Name = "addressTextBox";
			this.addressTextBox.Size = new System.Drawing.Size(301, 57);
			this.addressTextBox.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(276, 68);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(39, 14);
			this.label3.TabIndex = 0;
			this.label3.Text = "آدرس:";
			// 
			// lastNameTextBox
			// 
			this.lastNameTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lastNameTextBox.Location = new System.Drawing.Point(14, 43);
			this.lastNameTextBox.MaxLength = 25;
			this.lastNameTextBox.Name = "lastNameTextBox";
			this.lastNameTextBox.Size = new System.Drawing.Size(176, 22);
			this.lastNameTextBox.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(117, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 14);
			this.label2.TabIndex = 0;
			this.label2.Text = "نام خانوادگی:";
			// 
			// firstNameTextBox
			// 
			this.firstNameTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.firstNameTextBox.Location = new System.Drawing.Point(196, 43);
			this.firstNameTextBox.MaxLength = 20;
			this.firstNameTextBox.Name = "firstNameTextBox";
			this.firstNameTextBox.Size = new System.Drawing.Size(116, 22);
			this.firstNameTextBox.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(290, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(25, 14);
			this.label1.TabIndex = 0;
			this.label1.Text = "نام:";
			// 
			// saveButton
			// 
			this.saveButton.BackColor = System.Drawing.Color.Purple;
			this.saveButton.FlatAppearance.BorderSize = 0;
			this.saveButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.saveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
			this.saveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
			this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.saveButton.ForeColor = System.Drawing.Color.White;
			this.saveButton.Location = new System.Drawing.Point(146, 415);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(85, 25);
			this.saveButton.TabIndex = 4;
			this.saveButton.Text = "دخیره";
			this.saveButton.UseVisualStyleBackColor = false;
			this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// clearButton
			// 
			this.clearButton.BackColor = System.Drawing.Color.Purple;
			this.clearButton.FlatAppearance.BorderSize = 0;
			this.clearButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.clearButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
			this.clearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
			this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.clearButton.ForeColor = System.Drawing.Color.White;
			this.clearButton.Location = new System.Drawing.Point(264, 415);
			this.clearButton.Name = "clearButton";
			this.clearButton.Size = new System.Drawing.Size(85, 25);
			this.clearButton.TabIndex = 5;
			this.clearButton.Text = "حذف";
			this.clearButton.UseVisualStyleBackColor = false;
			this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
			// 
			// cancelBtton
			// 
			this.cancelBtton.BackColor = System.Drawing.Color.Purple;
			this.cancelBtton.FlatAppearance.BorderSize = 0;
			this.cancelBtton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.cancelBtton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
			this.cancelBtton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
			this.cancelBtton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cancelBtton.ForeColor = System.Drawing.Color.White;
			this.cancelBtton.Location = new System.Drawing.Point(382, 415);
			this.cancelBtton.Name = "cancelBtton";
			this.cancelBtton.Size = new System.Drawing.Size(85, 25);
			this.cancelBtton.TabIndex = 6;
			this.cancelBtton.Text = "انصراف";
			this.cancelBtton.UseVisualStyleBackColor = false;
			this.cancelBtton.Click += new System.EventHandler(this.CancelBtton_Click);
			// 
			// firstNameDataGridViewTextBoxColumn
			// 
			this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "First_Name";
			this.firstNameDataGridViewTextBoxColumn.HeaderText = "نام";
			this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
			this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// lastNameDataGridViewTextBoxColumn
			// 
			this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "Last_Name";
			this.lastNameDataGridViewTextBoxColumn.HeaderText = "نام خانوادگی";
			this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
			this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// addressDataGridViewTextBoxColumn
			// 
			this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
			this.addressDataGridViewTextBoxColumn.HeaderText = "آدرس";
			this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
			this.addressDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// userBindingSource
			// 
			this.userBindingSource.DataSource = typeof(Models.User);
			// 
			// RegisterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(612, 450);
			this.Controls.Add(this.cancelBtton);
			this.Controls.Add(this.clearButton);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.informatoionUserGroupBox);
			this.Controls.Add(this.userListDataGridView);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "RegisterForm";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.userListDataGridView)).EndInit();
			this.informatoionUserGroupBox.ResumeLayout(false);
			this.informatoionUserGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView userListDataGridView;
		private System.Windows.Forms.GroupBox informatoionUserGroupBox;
		private System.Windows.Forms.TextBox addressTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox lastNameTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox firstNameTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.Button clearButton;
		private System.Windows.Forms.Button cancelBtton;
		private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource userBindingSource;
	}
}

