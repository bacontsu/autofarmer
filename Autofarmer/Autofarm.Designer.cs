namespace Autofarmer {
	partial class Autofarm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autofarm));
            this.fileSelectDialog = new System.Windows.Forms.OpenFileDialog();
            this.fileSelectButton = new System.Windows.Forms.Button();
            this.fileNameDisplayer = new System.Windows.Forms.TextBox();
            this.openGTButton = new System.Windows.Forms.Button();
            this.toggleAutofarmer = new System.Windows.Forms.Button();
            this.statusMessage = new System.Windows.Forms.Label();
            this.numberInput = new System.Windows.Forms.NumericUpDown();
            this.processList = new System.Windows.Forms.DataGridView();
            this.Checkbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Multibox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.settingsLabel1 = new System.Windows.Forms.Label();
            this.autoFarmerType = new System.Windows.Forms.ComboBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numberInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSelectDialog
            // 
            this.fileSelectDialog.FileName = "Growtopia.exe";
            // 
            // fileSelectButton
            // 
            this.fileSelectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.fileSelectButton.FlatAppearance.BorderSize = 0;
            this.fileSelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fileSelectButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileSelectButton.ForeColor = System.Drawing.SystemColors.Control;
            this.fileSelectButton.Location = new System.Drawing.Point(178, 44);
            this.fileSelectButton.Name = "fileSelectButton";
            this.fileSelectButton.Size = new System.Drawing.Size(124, 26);
            this.fileSelectButton.TabIndex = 0;
            this.fileSelectButton.TabStop = false;
            this.fileSelectButton.Text = "Select Growtopia...";
            this.fileSelectButton.UseVisualStyleBackColor = false;
            this.fileSelectButton.Click += new System.EventHandler(this.SelectFile);
            // 
            // fileNameDisplayer
            // 
            this.fileNameDisplayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.fileNameDisplayer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fileNameDisplayer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fileNameDisplayer.Enabled = false;
            this.fileNameDisplayer.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileNameDisplayer.ForeColor = System.Drawing.SystemColors.Window;
            this.fileNameDisplayer.Location = new System.Drawing.Point(16, 50);
            this.fileNameDisplayer.Name = "fileNameDisplayer";
            this.fileNameDisplayer.ReadOnly = true;
            this.fileNameDisplayer.Size = new System.Drawing.Size(141, 14);
            this.fileNameDisplayer.TabIndex = 0;
            this.fileNameDisplayer.TabStop = false;
            this.fileNameDisplayer.Text = "Please select Growtopia.exe";
            this.fileNameDisplayer.TextChanged += new System.EventHandler(this.fileNameDisplayer_TextChanged);
            // 
            // openGTButton
            // 
            this.openGTButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.openGTButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.openGTButton.FlatAppearance.BorderSize = 0;
            this.openGTButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openGTButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openGTButton.ForeColor = System.Drawing.SystemColors.Window;
            this.openGTButton.Location = new System.Drawing.Point(178, 80);
            this.openGTButton.Name = "openGTButton";
            this.openGTButton.Size = new System.Drawing.Size(124, 37);
            this.openGTButton.TabIndex = 0;
            this.openGTButton.TabStop = false;
            this.openGTButton.Text = "Open GT (0 open)";
            this.openGTButton.UseVisualStyleBackColor = false;
            this.openGTButton.Click += new System.EventHandler(this.OpenGrowtopia);
            // 
            // toggleAutofarmer
            // 
            this.toggleAutofarmer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.toggleAutofarmer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.toggleAutofarmer.FlatAppearance.BorderSize = 0;
            this.toggleAutofarmer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toggleAutofarmer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleAutofarmer.ForeColor = System.Drawing.SystemColors.Window;
            this.toggleAutofarmer.Location = new System.Drawing.Point(12, 311);
            this.toggleAutofarmer.Name = "toggleAutofarmer";
            this.toggleAutofarmer.Size = new System.Drawing.Size(291, 38);
            this.toggleAutofarmer.TabIndex = 1;
            this.toggleAutofarmer.Text = "Autofarmers: Off";
            this.toggleAutofarmer.UseVisualStyleBackColor = false;
            this.toggleAutofarmer.Click += new System.EventHandler(this.ToggleAutofarmers);
            // 
            // statusMessage
            // 
            this.statusMessage.AutoSize = true;
            this.statusMessage.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusMessage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.statusMessage.Location = new System.Drawing.Point(9, 80);
            this.statusMessage.MaximumSize = new System.Drawing.Size(280, 0);
            this.statusMessage.Name = "statusMessage";
            this.statusMessage.Size = new System.Drawing.Size(130, 15);
            this.statusMessage.TabIndex = 2;
            this.statusMessage.Text = "Select amount to open.";
            // 
            // numberInput
            // 
            this.numberInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.numberInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numberInput.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberInput.ForeColor = System.Drawing.SystemColors.Window;
            this.numberInput.Location = new System.Drawing.Point(12, 100);
            this.numberInput.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numberInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberInput.Name = "numberInput";
            this.numberInput.Size = new System.Drawing.Size(53, 17);
            this.numberInput.TabIndex = 3;
            this.numberInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // processList
            // 
            this.processList.AllowUserToAddRows = false;
            this.processList.AllowUserToDeleteRows = false;
            this.processList.AllowUserToResizeColumns = false;
            this.processList.AllowUserToResizeRows = false;
            this.processList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.processList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.processList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.processList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(101)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.processList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.processList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.processList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Checkbox,
            this.Number,
            this.Active,
            this.Multibox,
            this.PID});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.processList.DefaultCellStyle = dataGridViewCellStyle5;
            this.processList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.processList.EnableHeadersVisualStyles = false;
            this.processList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.processList.Location = new System.Drawing.Point(12, 181);
            this.processList.Name = "processList";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.processList.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.processList.RowHeadersVisible = false;
            this.processList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.processList.Size = new System.Drawing.Size(291, 119);
            this.processList.TabIndex = 4;
            // 
            // Checkbox
            // 
            this.Checkbox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Checkbox.FillWeight = 40F;
            this.Checkbox.HeaderText = "";
            this.Checkbox.Name = "Checkbox";
            // 
            // Number
            // 
            this.Number.HeaderText = "#";
            this.Number.Name = "Number";
            this.Number.Width = 35;
            // 
            // Active
            // 
            this.Active.HeaderText = "Active Autofarmer";
            this.Active.Name = "Active";
            this.Active.Width = 80;
            // 
            // Multibox
            // 
            this.Multibox.HeaderText = "Multibox";
            this.Multibox.Name = "Multibox";
            this.Multibox.Width = 65;
            // 
            // PID
            // 
            this.PID.HeaderText = "Process ID";
            this.PID.Name = "PID";
            this.PID.Width = 60;
            // 
            // settingsLabel1
            // 
            this.settingsLabel1.AutoSize = true;
            this.settingsLabel1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsLabel1.ForeColor = System.Drawing.SystemColors.Window;
            this.settingsLabel1.Location = new System.Drawing.Point(9, 130);
            this.settingsLabel1.Name = "settingsLabel1";
            this.settingsLabel1.Size = new System.Drawing.Size(100, 15);
            this.settingsLabel1.TabIndex = 5;
            this.settingsLabel1.Text = "Autofarmer Status";
            this.toolTip.SetToolTip(this.settingsLabel1, "What autofarming script should be used");
            this.settingsLabel1.Click += new System.EventHandler(this.settingsLabel1_Click);
            // 
            // autoFarmerType
            // 
            this.autoFarmerType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(101)))), ((int)(((byte)(138)))));
            this.autoFarmerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.autoFarmerType.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoFarmerType.FormattingEnabled = true;
            this.autoFarmerType.Items.AddRange(new object[] {
            "Off",
            "On"});
            this.autoFarmerType.Location = new System.Drawing.Point(12, 149);
            this.autoFarmerType.Name = "autoFarmerType";
            this.autoFarmerType.Size = new System.Drawing.Size(124, 23);
            this.autoFarmerType.TabIndex = 6;
            this.autoFarmerType.SelectedIndexChanged += new System.EventHandler(this.autoFarmerType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(175, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Autofarmer Type";
            this.toolTip.SetToolTip(this.label1, "What autofarming script should be used");
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(101)))), ((int)(((byte)(138)))));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "None",
            "2 Block Right",
            "1 Block Up",
            "8 Block Down"});
            this.comboBox1.Location = new System.Drawing.Point(179, 149);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(124, 23);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(12, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 26);
            this.button2.TabIndex = 17;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Window;
            this.button3.Location = new System.Drawing.Point(288, -2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 36);
            this.button3.TabIndex = 18;
            this.button3.Text = "x";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseEnter += new System.EventHandler(this.button3_MouseHover);
            this.button3.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Window;
            this.button4.Location = new System.Drawing.Point(262, -3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(30, 36);
            this.button4.TabIndex = 19;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.MouseEnter += new System.EventHandler(this.button4_MouseHover);
            this.button4.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(35, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Autofarmer by Baconツ";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label2_MouseDown);
            // 
            // Autofarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(315, 362);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.fileNameDisplayer);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.openGTButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.processList);
            this.Controls.Add(this.autoFarmerType);
            this.Controls.Add(this.settingsLabel1);
            this.Controls.Add(this.numberInput);
            this.Controls.Add(this.statusMessage);
            this.Controls.Add(this.toggleAutofarmer);
            this.Controls.Add(this.fileSelectButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Autofarm";
            this.Text = "Autofarm";
            this.Load += new System.EventHandler(this.Autofarmer_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Autofarm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.numberInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.OpenFileDialog fileSelectDialog;
		private System.Windows.Forms.Button fileSelectButton;
		private System.Windows.Forms.TextBox fileNameDisplayer;
		private System.Windows.Forms.Button openGTButton;
		private System.Windows.Forms.Button toggleAutofarmer;
		private System.Windows.Forms.Label statusMessage;
		private System.Windows.Forms.NumericUpDown numberInput;
		private System.Windows.Forms.DataGridView processList;
		private System.Windows.Forms.Label settingsLabel1;
		private System.Windows.Forms.ComboBox autoFarmerType;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Checkbox;
		private System.Windows.Forms.DataGridViewTextBoxColumn Number;
		private System.Windows.Forms.DataGridViewTextBoxColumn Active;
		private System.Windows.Forms.DataGridViewTextBoxColumn Multibox;
		private System.Windows.Forms.DataGridViewTextBoxColumn PID;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}

