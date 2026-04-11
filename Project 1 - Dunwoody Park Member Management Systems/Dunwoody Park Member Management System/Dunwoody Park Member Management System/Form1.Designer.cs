
namespace Dunwoody_Park_Member_Management_System
{
    partial class FrmMembers
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_phoneNumber = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.cbox_membershipType = new System.Windows.Forms.ComboBox();
            this.dtPicker_joinDate = new System.Windows.Forms.DateTimePicker();
            this.cbox_gender = new System.Windows.Forms.ComboBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_view = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGrid_DunwoodyParks = new System.Windows.Forms.DataGridView();
            this.dunwoodyParkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dunwoodyParkDBDataSet = new Dunwoody_Park_Member_Management_System.DunwoodyParkDBDataSet();
            this.dunwoodyParkTableAdapter = new Dunwoody_Park_Member_Management_System.DunwoodyParkDBDataSetTableAdapters.DunwoodyParkTableAdapter();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.joinDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_DunwoodyParks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dunwoodyParkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dunwoodyParkDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(388, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(955, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dunwoody Park - Member Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(384, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(782, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1165, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(101, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Phone Number*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(446, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Email*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(927, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(446, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Membership Type*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(904, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Join Date*";
            // 
            // txt_firstName
            // 
            this.txt_firstName.Location = new System.Drawing.Point(492, 132);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(267, 22);
            this.txt_firstName.TabIndex = 10;
            // 
            // txt_lastName
            // 
            this.txt_lastName.Location = new System.Drawing.Point(887, 132);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(252, 22);
            this.txt_lastName.TabIndex = 11;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(520, 206);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(391, 22);
            this.txt_email.TabIndex = 13;
            // 
            // txt_phoneNumber
            // 
            this.txt_phoneNumber.Location = new System.Drawing.Point(253, 205);
            this.txt_phoneNumber.Name = "txt_phoneNumber";
            this.txt_phoneNumber.Size = new System.Drawing.Size(174, 22);
            this.txt_phoneNumber.TabIndex = 14;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(1007, 206);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(584, 22);
            this.txt_address.TabIndex = 15;
            // 
            // cbox_membershipType
            // 
            this.cbox_membershipType.FormattingEnabled = true;
            this.cbox_membershipType.Location = new System.Drawing.Point(619, 277);
            this.cbox_membershipType.Name = "cbox_membershipType";
            this.cbox_membershipType.Size = new System.Drawing.Size(252, 24);
            this.cbox_membershipType.TabIndex = 16;
            // 
            // dtPicker_joinDate
            // 
            this.dtPicker_joinDate.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPicker_joinDate.Location = new System.Drawing.Point(1002, 273);
            this.dtPicker_joinDate.Name = "dtPicker_joinDate";
            this.dtPicker_joinDate.Size = new System.Drawing.Size(319, 25);
            this.dtPicker_joinDate.TabIndex = 17;
            // 
            // cbox_gender
            // 
            this.cbox_gender.FormattingEnabled = true;
            this.cbox_gender.Location = new System.Drawing.Point(1241, 133);
            this.cbox_gender.Name = "cbox_gender";
            this.cbox_gender.Size = new System.Drawing.Size(92, 24);
            this.cbox_gender.TabIndex = 18;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_add.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(433, 338);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(175, 63);
            this.btn_add.TabIndex = 19;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_view
            // 
            this.btn_view.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_view.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view.Location = new System.Drawing.Point(614, 338);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(175, 63);
            this.btn_view.TabIndex = 20;
            this.btn_view.Text = "View";
            this.btn_view.UseVisualStyleBackColor = false;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_update.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(795, 338);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(175, 63);
            this.btn_update.TabIndex = 21;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_delete.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(976, 338);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(175, 63);
            this.btn_delete.TabIndex = 22;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_clear.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(1157, 338);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(175, 63);
            this.btn_clear.TabIndex = 23;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(805, 913);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "* = required field";
            // 
            // dataGrid_DunwoodyParks
            // 
            this.dataGrid_DunwoodyParks.AutoGenerateColumns = false;
            this.dataGrid_DunwoodyParks.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGrid_DunwoodyParks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_DunwoodyParks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.memberIDDataGridViewTextBoxColumn,
            this.memberTypeDataGridViewTextBoxColumn,
            this.joinDateDataGridViewTextBoxColumn});
            this.dataGrid_DunwoodyParks.DataSource = this.dunwoodyParkBindingSource;
            this.dataGrid_DunwoodyParks.Location = new System.Drawing.Point(54, 443);
            this.dataGrid_DunwoodyParks.Name = "dataGrid_DunwoodyParks";
            this.dataGrid_DunwoodyParks.RowHeadersWidth = 51;
            this.dataGrid_DunwoodyParks.RowTemplate.Height = 24;
            this.dataGrid_DunwoodyParks.Size = new System.Drawing.Size(1585, 408);
            this.dataGrid_DunwoodyParks.TabIndex = 25;
            this.dataGrid_DunwoodyParks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_DunwoodyParks_CellClick);
            this.dataGrid_DunwoodyParks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_DunwoodyParks_CellClick);
            // 
            // dunwoodyParkBindingSource
            // 
            this.dunwoodyParkBindingSource.DataMember = "DunwoodyPark";
            this.dunwoodyParkBindingSource.DataSource = this.dunwoodyParkDBDataSet;
            // 
            // dunwoodyParkDBDataSet
            // 
            this.dunwoodyParkDBDataSet.DataSetName = "DunwoodyParkDBDataSet";
            this.dunwoodyParkDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dunwoodyParkTableAdapter
            // 
            this.dunwoodyParkTableAdapter.ClearBeforeFill = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // memberIDDataGridViewTextBoxColumn
            // 
            this.memberIDDataGridViewTextBoxColumn.DataPropertyName = "MemberID";
            this.memberIDDataGridViewTextBoxColumn.HeaderText = "MemberID";
            this.memberIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.memberIDDataGridViewTextBoxColumn.Name = "memberIDDataGridViewTextBoxColumn";
            this.memberIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.memberIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // memberTypeDataGridViewTextBoxColumn
            // 
            this.memberTypeDataGridViewTextBoxColumn.DataPropertyName = "MemberType";
            this.memberTypeDataGridViewTextBoxColumn.HeaderText = "MemberType";
            this.memberTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.memberTypeDataGridViewTextBoxColumn.Name = "memberTypeDataGridViewTextBoxColumn";
            this.memberTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // joinDateDataGridViewTextBoxColumn
            // 
            this.joinDateDataGridViewTextBoxColumn.DataPropertyName = "JoinDate";
            this.joinDateDataGridViewTextBoxColumn.HeaderText = "JoinDate";
            this.joinDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.joinDateDataGridViewTextBoxColumn.Name = "joinDateDataGridViewTextBoxColumn";
            this.joinDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // FrmMembers
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1753, 953);
            this.Controls.Add(this.dataGrid_DunwoodyParks);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.cbox_gender);
            this.Controls.Add(this.dtPicker_joinDate);
            this.Controls.Add(this.cbox_membershipType);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_phoneNumber);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_lastName);
            this.Controls.Add(this.txt_firstName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmMembers";
            this.Text = "Windows Forms - Dunwoody Park";
            this.Load += new System.EventHandler(this.FrmMembers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_DunwoodyParks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dunwoodyParkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dunwoodyParkDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_firstName;
        private System.Windows.Forms.TextBox txt_lastName;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_phoneNumber;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.ComboBox cbox_membershipType;
        private System.Windows.Forms.DateTimePicker dtPicker_joinDate;
        private System.Windows.Forms.ComboBox cbox_gender;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGrid_DunwoodyParks;
        private DunwoodyParkDBDataSet dunwoodyParkDBDataSet;
        private System.Windows.Forms.BindingSource dunwoodyParkBindingSource;
        private DunwoodyParkDBDataSetTableAdapters.DunwoodyParkTableAdapter dunwoodyParkTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn joinDateDataGridViewTextBoxColumn;
    }
}

