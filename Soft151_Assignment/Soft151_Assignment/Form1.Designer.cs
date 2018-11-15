namespace Soft151_Assignment
{
    partial class hireCars
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
            this.lstCompanies = new System.Windows.Forms.ListBox();
            this.lstCars = new System.Windows.Forms.ListBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblCars = new System.Windows.Forms.Label();
            this.grpCompany = new System.Windows.Forms.GroupBox();
            this.btnCancelCompany = new System.Windows.Forms.Button();
            this.txtCompanyPostcode = new System.Windows.Forms.TextBox();
            this.txtCompanyAddress = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtCompanyIdNumber = new System.Windows.Forms.TextBox();
            this.btnSaveCompanyAdd = new System.Windows.Forms.Button();
            this.btnEditCompany = new System.Windows.Forms.Button();
            this.lblCompanyPostcode = new System.Windows.Forms.Label();
            this.lblCompanyAddress = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblCompanyId = new System.Windows.Forms.Label();
            this.btnSaveCompanyEdit = new System.Windows.Forms.Button();
            this.grpCar = new System.Windows.Forms.GroupBox();
            this.btnSaveCarEdit = new System.Windows.Forms.Button();
            this.btnCancelCar = new System.Windows.Forms.Button();
            this.txtCarComments = new System.Windows.Forms.TextBox();
            this.txtCarLastServiceDate = new System.Windows.Forms.TextBox();
            this.txtCarFuelType = new System.Windows.Forms.TextBox();
            this.txtCarRegistration = new System.Windows.Forms.TextBox();
            this.txtCarMakeAndModel = new System.Windows.Forms.TextBox();
            this.txtCarIdNumber = new System.Windows.Forms.TextBox();
            this.btnSaveCarAdd = new System.Windows.Forms.Button();
            this.btnEditCar = new System.Windows.Forms.Button();
            this.lblComments = new System.Windows.Forms.Label();
            this.lblLastServiceDate = new System.Windows.Forms.Label();
            this.lblFuelType = new System.Windows.Forms.Label();
            this.lblCarRegistration = new System.Windows.Forms.Label();
            this.lblCarMakeAndModel = new System.Windows.Forms.Label();
            this.lblCarId = new System.Windows.Forms.Label();
            this.btnAddCompany = new System.Windows.Forms.Button();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.btnDeleteCompany = new System.Windows.Forms.Button();
            this.btnDeleteCar = new System.Windows.Forms.Button();
            this.txtSearchCompany = new System.Windows.Forms.TextBox();
            this.txtSearchCar = new System.Windows.Forms.TextBox();
            this.btnSaveAll = new System.Windows.Forms.Button();
            this.grpCompany.SuspendLayout();
            this.grpCar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstCompanies
            // 
            this.lstCompanies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lstCompanies.FormattingEnabled = true;
            this.lstCompanies.HorizontalScrollbar = true;
            this.lstCompanies.ItemHeight = 16;
            this.lstCompanies.Location = new System.Drawing.Point(36, 65);
            this.lstCompanies.Margin = new System.Windows.Forms.Padding(2);
            this.lstCompanies.Name = "lstCompanies";
            this.lstCompanies.Size = new System.Drawing.Size(708, 180);
            this.lstCompanies.TabIndex = 0;
            this.lstCompanies.SelectedIndexChanged += new System.EventHandler(this.lstCompanies_SelectedIndexChanged);
            // 
            // lstCars
            // 
            this.lstCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lstCars.FormattingEnabled = true;
            this.lstCars.HorizontalScrollbar = true;
            this.lstCars.ItemHeight = 16;
            this.lstCars.Location = new System.Drawing.Point(37, 378);
            this.lstCars.Margin = new System.Windows.Forms.Padding(2);
            this.lstCars.Name = "lstCars";
            this.lstCars.Size = new System.Drawing.Size(708, 180);
            this.lstCars.TabIndex = 1;
            this.lstCars.SelectedIndexChanged += new System.EventHandler(this.lstCars_SelectedIndexChanged);
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCompany.Location = new System.Drawing.Point(35, 20);
            this.lblCompany.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(110, 17);
            this.lblCompany.TabIndex = 2;
            this.lblCompany.Text = "Select Company";
            // 
            // lblCars
            // 
            this.lblCars.AutoSize = true;
            this.lblCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCars.Location = new System.Drawing.Point(35, 333);
            this.lblCars.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCars.Name = "lblCars";
            this.lblCars.Size = new System.Drawing.Size(80, 17);
            this.lblCars.TabIndex = 3;
            this.lblCars.Text = "Select Cars";
            // 
            // grpCompany
            // 
            this.grpCompany.Controls.Add(this.btnCancelCompany);
            this.grpCompany.Controls.Add(this.txtCompanyPostcode);
            this.grpCompany.Controls.Add(this.txtCompanyAddress);
            this.grpCompany.Controls.Add(this.txtCompanyName);
            this.grpCompany.Controls.Add(this.txtCompanyIdNumber);
            this.grpCompany.Controls.Add(this.btnSaveCompanyAdd);
            this.grpCompany.Controls.Add(this.btnEditCompany);
            this.grpCompany.Controls.Add(this.lblCompanyPostcode);
            this.grpCompany.Controls.Add(this.lblCompanyAddress);
            this.grpCompany.Controls.Add(this.lblCompanyName);
            this.grpCompany.Controls.Add(this.lblCompanyId);
            this.grpCompany.Controls.Add(this.btnSaveCompanyEdit);
            this.grpCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grpCompany.Location = new System.Drawing.Point(763, 49);
            this.grpCompany.Margin = new System.Windows.Forms.Padding(2);
            this.grpCompany.Name = "grpCompany";
            this.grpCompany.Padding = new System.Windows.Forms.Padding(2);
            this.grpCompany.Size = new System.Drawing.Size(350, 227);
            this.grpCompany.TabIndex = 4;
            this.grpCompany.TabStop = false;
            this.grpCompany.Text = "Company Details";
            // 
            // btnCancelCompany
            // 
            this.btnCancelCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancelCompany.Location = new System.Drawing.Point(188, 196);
            this.btnCancelCompany.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelCompany.Name = "btnCancelCompany";
            this.btnCancelCompany.Size = new System.Drawing.Size(70, 26);
            this.btnCancelCompany.TabIndex = 21;
            this.btnCancelCompany.Text = "Cancel";
            this.btnCancelCompany.UseVisualStyleBackColor = true;
            this.btnCancelCompany.Click += new System.EventHandler(this.btnCancelCompany_Click);
            // 
            // txtCompanyPostcode
            // 
            this.txtCompanyPostcode.Enabled = false;
            this.txtCompanyPostcode.Location = new System.Drawing.Point(123, 111);
            this.txtCompanyPostcode.Margin = new System.Windows.Forms.Padding(2);
            this.txtCompanyPostcode.Name = "txtCompanyPostcode";
            this.txtCompanyPostcode.Size = new System.Drawing.Size(98, 23);
            this.txtCompanyPostcode.TabIndex = 19;
            // 
            // txtCompanyAddress
            // 
            this.txtCompanyAddress.Enabled = false;
            this.txtCompanyAddress.Location = new System.Drawing.Point(123, 85);
            this.txtCompanyAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtCompanyAddress.Name = "txtCompanyAddress";
            this.txtCompanyAddress.Size = new System.Drawing.Size(224, 23);
            this.txtCompanyAddress.TabIndex = 18;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Enabled = false;
            this.txtCompanyName.Location = new System.Drawing.Point(123, 59);
            this.txtCompanyName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(190, 23);
            this.txtCompanyName.TabIndex = 17;
            // 
            // txtCompanyIdNumber
            // 
            this.txtCompanyIdNumber.Enabled = false;
            this.txtCompanyIdNumber.Location = new System.Drawing.Point(123, 33);
            this.txtCompanyIdNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtCompanyIdNumber.Name = "txtCompanyIdNumber";
            this.txtCompanyIdNumber.Size = new System.Drawing.Size(76, 23);
            this.txtCompanyIdNumber.TabIndex = 16;
            // 
            // btnSaveCompanyAdd
            // 
            this.btnSaveCompanyAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSaveCompanyAdd.Location = new System.Drawing.Point(102, 196);
            this.btnSaveCompanyAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveCompanyAdd.Name = "btnSaveCompanyAdd";
            this.btnSaveCompanyAdd.Size = new System.Drawing.Size(70, 26);
            this.btnSaveCompanyAdd.TabIndex = 15;
            this.btnSaveCompanyAdd.Text = "Save";
            this.btnSaveCompanyAdd.UseVisualStyleBackColor = true;
            this.btnSaveCompanyAdd.Click += new System.EventHandler(this.btnSaveCompany_Click);
            // 
            // btnEditCompany
            // 
            this.btnEditCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEditCompany.Location = new System.Drawing.Point(13, 196);
            this.btnEditCompany.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditCompany.Name = "btnEditCompany";
            this.btnEditCompany.Size = new System.Drawing.Size(70, 26);
            this.btnEditCompany.TabIndex = 10;
            this.btnEditCompany.Text = "Edit";
            this.btnEditCompany.UseVisualStyleBackColor = true;
            this.btnEditCompany.Click += new System.EventHandler(this.btnEditCompany_Click);
            // 
            // lblCompanyPostcode
            // 
            this.lblCompanyPostcode.AutoSize = true;
            this.lblCompanyPostcode.Location = new System.Drawing.Point(4, 110);
            this.lblCompanyPostcode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompanyPostcode.Name = "lblCompanyPostcode";
            this.lblCompanyPostcode.Size = new System.Drawing.Size(71, 17);
            this.lblCompanyPostcode.TabIndex = 13;
            this.lblCompanyPostcode.Text = "Postcode:";
            // 
            // lblCompanyAddress
            // 
            this.lblCompanyAddress.AutoSize = true;
            this.lblCompanyAddress.Location = new System.Drawing.Point(4, 84);
            this.lblCompanyAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompanyAddress.Name = "lblCompanyAddress";
            this.lblCompanyAddress.Size = new System.Drawing.Size(64, 17);
            this.lblCompanyAddress.TabIndex = 12;
            this.lblCompanyAddress.Text = "Address:";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(4, 59);
            this.lblCompanyName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(49, 17);
            this.lblCompanyName.TabIndex = 11;
            this.lblCompanyName.Text = "Name:";
            // 
            // lblCompanyId
            // 
            this.lblCompanyId.AutoSize = true;
            this.lblCompanyId.Location = new System.Drawing.Point(4, 35);
            this.lblCompanyId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompanyId.Name = "lblCompanyId";
            this.lblCompanyId.Size = new System.Drawing.Size(79, 17);
            this.lblCompanyId.TabIndex = 10;
            this.lblCompanyId.Text = "ID Number:";
            // 
            // btnSaveCompanyEdit
            // 
            this.btnSaveCompanyEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSaveCompanyEdit.Location = new System.Drawing.Point(101, 196);
            this.btnSaveCompanyEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveCompanyEdit.Name = "btnSaveCompanyEdit";
            this.btnSaveCompanyEdit.Size = new System.Drawing.Size(70, 26);
            this.btnSaveCompanyEdit.TabIndex = 22;
            this.btnSaveCompanyEdit.Text = "Save";
            this.btnSaveCompanyEdit.UseVisualStyleBackColor = true;
            this.btnSaveCompanyEdit.Click += new System.EventHandler(this.btnSaveCompanyEdit_Click);
            // 
            // grpCar
            // 
            this.grpCar.Controls.Add(this.btnSaveCarEdit);
            this.grpCar.Controls.Add(this.btnCancelCar);
            this.grpCar.Controls.Add(this.txtCarComments);
            this.grpCar.Controls.Add(this.txtCarLastServiceDate);
            this.grpCar.Controls.Add(this.txtCarFuelType);
            this.grpCar.Controls.Add(this.txtCarRegistration);
            this.grpCar.Controls.Add(this.txtCarMakeAndModel);
            this.grpCar.Controls.Add(this.txtCarIdNumber);
            this.grpCar.Controls.Add(this.btnSaveCarAdd);
            this.grpCar.Controls.Add(this.btnEditCar);
            this.grpCar.Controls.Add(this.lblComments);
            this.grpCar.Controls.Add(this.lblLastServiceDate);
            this.grpCar.Controls.Add(this.lblFuelType);
            this.grpCar.Controls.Add(this.lblCarRegistration);
            this.grpCar.Controls.Add(this.lblCarMakeAndModel);
            this.grpCar.Controls.Add(this.lblCarId);
            this.grpCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grpCar.Location = new System.Drawing.Point(764, 362);
            this.grpCar.Margin = new System.Windows.Forms.Padding(2);
            this.grpCar.Name = "grpCar";
            this.grpCar.Padding = new System.Windows.Forms.Padding(2);
            this.grpCar.Size = new System.Drawing.Size(350, 228);
            this.grpCar.TabIndex = 5;
            this.grpCar.TabStop = false;
            this.grpCar.Text = "Car details";
            // 
            // btnSaveCarEdit
            // 
            this.btnSaveCarEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSaveCarEdit.Location = new System.Drawing.Point(100, 197);
            this.btnSaveCarEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveCarEdit.Name = "btnSaveCarEdit";
            this.btnSaveCarEdit.Size = new System.Drawing.Size(70, 26);
            this.btnSaveCarEdit.TabIndex = 23;
            this.btnSaveCarEdit.Text = "Save";
            this.btnSaveCarEdit.UseVisualStyleBackColor = true;
            this.btnSaveCarEdit.Click += new System.EventHandler(this.btnSaveCarEdit_Click);
            // 
            // btnCancelCar
            // 
            this.btnCancelCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancelCar.Location = new System.Drawing.Point(188, 197);
            this.btnCancelCar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelCar.Name = "btnCancelCar";
            this.btnCancelCar.Size = new System.Drawing.Size(70, 26);
            this.btnCancelCar.TabIndex = 22;
            this.btnCancelCar.Text = "Cancel";
            this.btnCancelCar.UseVisualStyleBackColor = true;
            this.btnCancelCar.Click += new System.EventHandler(this.btnCancelCar_Click);
            // 
            // txtCarComments
            // 
            this.txtCarComments.Enabled = false;
            this.txtCarComments.Location = new System.Drawing.Point(125, 161);
            this.txtCarComments.Margin = new System.Windows.Forms.Padding(2);
            this.txtCarComments.Name = "txtCarComments";
            this.txtCarComments.Size = new System.Drawing.Size(221, 23);
            this.txtCarComments.TabIndex = 22;
            // 
            // txtCarLastServiceDate
            // 
            this.txtCarLastServiceDate.Enabled = false;
            this.txtCarLastServiceDate.Location = new System.Drawing.Point(125, 135);
            this.txtCarLastServiceDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtCarLastServiceDate.Name = "txtCarLastServiceDate";
            this.txtCarLastServiceDate.Size = new System.Drawing.Size(99, 23);
            this.txtCarLastServiceDate.TabIndex = 21;
            // 
            // txtCarFuelType
            // 
            this.txtCarFuelType.Enabled = false;
            this.txtCarFuelType.Location = new System.Drawing.Point(125, 109);
            this.txtCarFuelType.Margin = new System.Windows.Forms.Padding(2);
            this.txtCarFuelType.Name = "txtCarFuelType";
            this.txtCarFuelType.Size = new System.Drawing.Size(99, 23);
            this.txtCarFuelType.TabIndex = 20;
            // 
            // txtCarRegistration
            // 
            this.txtCarRegistration.Enabled = false;
            this.txtCarRegistration.Location = new System.Drawing.Point(125, 83);
            this.txtCarRegistration.Margin = new System.Windows.Forms.Padding(2);
            this.txtCarRegistration.Name = "txtCarRegistration";
            this.txtCarRegistration.Size = new System.Drawing.Size(99, 23);
            this.txtCarRegistration.TabIndex = 19;
            // 
            // txtCarMakeAndModel
            // 
            this.txtCarMakeAndModel.Enabled = false;
            this.txtCarMakeAndModel.Location = new System.Drawing.Point(125, 57);
            this.txtCarMakeAndModel.Margin = new System.Windows.Forms.Padding(2);
            this.txtCarMakeAndModel.Name = "txtCarMakeAndModel";
            this.txtCarMakeAndModel.Size = new System.Drawing.Size(175, 23);
            this.txtCarMakeAndModel.TabIndex = 18;
            // 
            // txtCarIdNumber
            // 
            this.txtCarIdNumber.Enabled = false;
            this.txtCarIdNumber.Location = new System.Drawing.Point(125, 31);
            this.txtCarIdNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtCarIdNumber.Name = "txtCarIdNumber";
            this.txtCarIdNumber.Size = new System.Drawing.Size(76, 23);
            this.txtCarIdNumber.TabIndex = 17;
            // 
            // btnSaveCarAdd
            // 
            this.btnSaveCarAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSaveCarAdd.Location = new System.Drawing.Point(101, 197);
            this.btnSaveCarAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveCarAdd.Name = "btnSaveCarAdd";
            this.btnSaveCarAdd.Size = new System.Drawing.Size(70, 26);
            this.btnSaveCarAdd.TabIndex = 16;
            this.btnSaveCarAdd.Text = "Save";
            this.btnSaveCarAdd.UseVisualStyleBackColor = true;
            this.btnSaveCarAdd.Click += new System.EventHandler(this.btnSaveCarAdd_Click);
            // 
            // btnEditCar
            // 
            this.btnEditCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEditCar.Location = new System.Drawing.Point(12, 197);
            this.btnEditCar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditCar.Name = "btnEditCar";
            this.btnEditCar.Size = new System.Drawing.Size(70, 26);
            this.btnEditCar.TabIndex = 16;
            this.btnEditCar.Text = "Edit";
            this.btnEditCar.UseVisualStyleBackColor = true;
            this.btnEditCar.Click += new System.EventHandler(this.btnEditCar_Click);
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Location = new System.Drawing.Point(4, 163);
            this.lblComments.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(78, 17);
            this.lblComments.TabIndex = 5;
            this.lblComments.Text = "Comments:";
            // 
            // lblLastServiceDate
            // 
            this.lblLastServiceDate.AutoSize = true;
            this.lblLastServiceDate.Location = new System.Drawing.Point(4, 140);
            this.lblLastServiceDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastServiceDate.Name = "lblLastServiceDate";
            this.lblLastServiceDate.Size = new System.Drawing.Size(124, 17);
            this.lblLastServiceDate.TabIndex = 4;
            this.lblLastServiceDate.Text = "Last Service Date:";
            // 
            // lblFuelType
            // 
            this.lblFuelType.AutoSize = true;
            this.lblFuelType.Location = new System.Drawing.Point(4, 114);
            this.lblFuelType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFuelType.Name = "lblFuelType";
            this.lblFuelType.Size = new System.Drawing.Size(75, 17);
            this.lblFuelType.TabIndex = 3;
            this.lblFuelType.Text = "Fuel Type:";
            // 
            // lblCarRegistration
            // 
            this.lblCarRegistration.AutoSize = true;
            this.lblCarRegistration.Location = new System.Drawing.Point(4, 88);
            this.lblCarRegistration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCarRegistration.Name = "lblCarRegistration";
            this.lblCarRegistration.Size = new System.Drawing.Size(88, 17);
            this.lblCarRegistration.TabIndex = 2;
            this.lblCarRegistration.Text = "Registration:";
            // 
            // lblCarMakeAndModel
            // 
            this.lblCarMakeAndModel.AutoSize = true;
            this.lblCarMakeAndModel.Location = new System.Drawing.Point(4, 62);
            this.lblCarMakeAndModel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCarMakeAndModel.Name = "lblCarMakeAndModel";
            this.lblCarMakeAndModel.Size = new System.Drawing.Size(116, 17);
            this.lblCarMakeAndModel.TabIndex = 1;
            this.lblCarMakeAndModel.Text = "Make and Model:";
            // 
            // lblCarId
            // 
            this.lblCarId.AutoSize = true;
            this.lblCarId.Location = new System.Drawing.Point(4, 33);
            this.lblCarId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCarId.Name = "lblCarId";
            this.lblCarId.Size = new System.Drawing.Size(79, 17);
            this.lblCarId.TabIndex = 0;
            this.lblCarId.Text = "ID Number:";
            // 
            // btnAddCompany
            // 
            this.btnAddCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddCompany.Location = new System.Drawing.Point(36, 281);
            this.btnAddCompany.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddCompany.Name = "btnAddCompany";
            this.btnAddCompany.Size = new System.Drawing.Size(70, 26);
            this.btnAddCompany.TabIndex = 6;
            this.btnAddCompany.Text = "Add";
            this.btnAddCompany.UseVisualStyleBackColor = true;
            this.btnAddCompany.Click += new System.EventHandler(this.btnAddCompany_Click);
            // 
            // btnAddCar
            // 
            this.btnAddCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddCar.Location = new System.Drawing.Point(37, 590);
            this.btnAddCar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(70, 26);
            this.btnAddCar.TabIndex = 7;
            this.btnAddCar.Text = "Add";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // btnDeleteCompany
            // 
            this.btnDeleteCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDeleteCompany.Location = new System.Drawing.Point(120, 281);
            this.btnDeleteCompany.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteCompany.Name = "btnDeleteCompany";
            this.btnDeleteCompany.Size = new System.Drawing.Size(70, 26);
            this.btnDeleteCompany.TabIndex = 8;
            this.btnDeleteCompany.Text = "Delete";
            this.btnDeleteCompany.UseVisualStyleBackColor = true;
            this.btnDeleteCompany.Click += new System.EventHandler(this.btnDeleteCompany_Click);
            // 
            // btnDeleteCar
            // 
            this.btnDeleteCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDeleteCar.Location = new System.Drawing.Point(121, 590);
            this.btnDeleteCar.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteCar.Name = "btnDeleteCar";
            this.btnDeleteCar.Size = new System.Drawing.Size(70, 26);
            this.btnDeleteCar.TabIndex = 9;
            this.btnDeleteCar.Text = "Delete";
            this.btnDeleteCar.UseVisualStyleBackColor = true;
            this.btnDeleteCar.Click += new System.EventHandler(this.btnDeleteCar_Click);
            // 
            // txtSearchCompany
            // 
            this.txtSearchCompany.Location = new System.Drawing.Point(36, 40);
            this.txtSearchCompany.Name = "txtSearchCompany";
            this.txtSearchCompany.Size = new System.Drawing.Size(295, 20);
            this.txtSearchCompany.TabIndex = 10;
            this.txtSearchCompany.TextChanged += new System.EventHandler(this.searchCompany_TextChanged);
            // 
            // txtSearchCar
            // 
            this.txtSearchCar.Location = new System.Drawing.Point(36, 353);
            this.txtSearchCar.Name = "txtSearchCar";
            this.txtSearchCar.Size = new System.Drawing.Size(295, 20);
            this.txtSearchCar.TabIndex = 11;
            this.txtSearchCar.TextChanged += new System.EventHandler(this.txtSearchCar_TextChanged);
            // 
            // btnSaveAll
            // 
            this.btnSaveAll.Location = new System.Drawing.Point(1111, 10);
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.Size = new System.Drawing.Size(95, 48);
            this.btnSaveAll.TabIndex = 12;
            this.btnSaveAll.Text = "Save All";
            this.btnSaveAll.UseVisualStyleBackColor = true;
            this.btnSaveAll.Click += new System.EventHandler(this.btnSaveAll_Click);
            // 
            // hireCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 645);
            this.Controls.Add(this.btnSaveAll);
            this.Controls.Add(this.txtSearchCar);
            this.Controls.Add(this.txtSearchCompany);
            this.Controls.Add(this.btnDeleteCar);
            this.Controls.Add(this.btnDeleteCompany);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.btnAddCompany);
            this.Controls.Add(this.grpCar);
            this.Controls.Add(this.grpCompany);
            this.Controls.Add(this.lblCars);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.lstCars);
            this.Controls.Add(this.lstCompanies);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "hireCars";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.hireForms_Load);
            this.grpCompany.ResumeLayout(false);
            this.grpCompany.PerformLayout();
            this.grpCar.ResumeLayout(false);
            this.grpCar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCompanies;
        private System.Windows.Forms.ListBox lstCars;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblCars;
        private System.Windows.Forms.GroupBox grpCompany;
        private System.Windows.Forms.GroupBox grpCar;
        private System.Windows.Forms.Button btnAddCompany;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Button btnDeleteCompany;
        private System.Windows.Forms.Button btnDeleteCar;
        private System.Windows.Forms.Label lblCompanyId;
        private System.Windows.Forms.Label lblCompanyPostcode;
        private System.Windows.Forms.Label lblCompanyAddress;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblCarId;
        private System.Windows.Forms.Label lblCarRegistration;
        private System.Windows.Forms.Label lblCarMakeAndModel;
        private System.Windows.Forms.Button btnSaveCompanyAdd;
        private System.Windows.Forms.Button btnEditCompany;
        private System.Windows.Forms.Button btnEditCar;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.Label lblLastServiceDate;
        private System.Windows.Forms.Label lblFuelType;
        private System.Windows.Forms.Button btnSaveCarAdd;
        private System.Windows.Forms.TextBox txtCompanyPostcode;
        private System.Windows.Forms.TextBox txtCompanyAddress;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtCompanyIdNumber;
        private System.Windows.Forms.TextBox txtCarComments;
        private System.Windows.Forms.TextBox txtCarLastServiceDate;
        private System.Windows.Forms.TextBox txtCarFuelType;
        private System.Windows.Forms.TextBox txtCarRegistration;
        private System.Windows.Forms.TextBox txtCarMakeAndModel;
        private System.Windows.Forms.TextBox txtCarIdNumber;
        private System.Windows.Forms.Button btnCancelCompany;
        private System.Windows.Forms.Button btnCancelCar;
        private System.Windows.Forms.TextBox txtSearchCompany;
        private System.Windows.Forms.TextBox txtSearchCar;
        private System.Windows.Forms.Button btnSaveCompanyEdit;
        private System.Windows.Forms.Button btnSaveCarEdit;
        private System.Windows.Forms.Button btnSaveAll;
    }
}

