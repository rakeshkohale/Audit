namespace Audit
{
    partial class frmHome
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnlDonationEntry = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveDonation = new System.Windows.Forms.Button();
            this.txtChequeDate = new System.Windows.Forms.TextBox();
            this.txtChequeNo = new System.Windows.Forms.TextBox();
            this.txtBranch = new System.Windows.Forms.TextBox();
            this.txtDrawnBank = new System.Windows.Forms.TextBox();
            this.lblChequeNo = new System.Windows.Forms.Label();
            this.lblBank = new System.Windows.Forms.Label();
            this.lblChequeDate = new System.Windows.Forms.Label();
            this.lblBranch = new System.Windows.Forms.Label();
            this.rdoButtonCheque = new System.Windows.Forms.RadioButton();
            this.rdoButtonCash = new System.Windows.Forms.RadioButton();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cboPoojaName = new System.Windows.Forms.ComboBox();
            this.txtNameofDonor = new System.Windows.Forms.TextBox();
            this.datPickereDonation = new System.Windows.Forms.DateTimePicker();
            this.txtReceiptNo = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPoojaName = new System.Windows.Forms.Label();
            this.lblModeofPayment = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblNameofDonor = new System.Windows.Forms.Label();
            this.lblReceiptNo = new System.Windows.Forms.Label();
            this.pnlBackNewEntry = new System.Windows.Forms.Panel();
            this.btnViewAllDonations = new System.Windows.Forms.Button();
            this.btnAddDonation = new System.Windows.Forms.Button();
            this.pnlViewAllDonations = new System.Windows.Forms.Panel();
            this.dgvAllDonations = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnViewAllPoojas = new System.Windows.Forms.Button();
            this.btnUpdatePoojaDetails = new System.Windows.Forms.Button();
            this.pnlViewPoojaDetails = new System.Windows.Forms.Panel();
            this.dgvAllPoojaDetails = new System.Windows.Forms.DataGridView();
            this.pnlUpdatePoojaDetails = new System.Windows.Forms.Panel();
            this.btnCancelUpdate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtNewAmount = new System.Windows.Forms.TextBox();
            this.txtOldAmount = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUpdatePoojaDetails = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlDonationEntry.SuspendLayout();
            this.pnlViewAllDonations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllDonations)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.pnlViewPoojaDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllPoojaDetails)).BeginInit();
            this.pnlUpdatePoojaDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(869, 502);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnlDonationEntry);
            this.tabPage1.Controls.Add(this.pnlBackNewEntry);
            this.tabPage1.Controls.Add(this.btnViewAllDonations);
            this.tabPage1.Controls.Add(this.btnAddDonation);
            this.tabPage1.Controls.Add(this.pnlViewAllDonations);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(861, 476);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pnlDonationEntry
            // 
            this.pnlDonationEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDonationEntry.Controls.Add(this.btnCancel);
            this.pnlDonationEntry.Controls.Add(this.btnSaveDonation);
            this.pnlDonationEntry.Controls.Add(this.txtChequeDate);
            this.pnlDonationEntry.Controls.Add(this.txtChequeNo);
            this.pnlDonationEntry.Controls.Add(this.txtBranch);
            this.pnlDonationEntry.Controls.Add(this.txtDrawnBank);
            this.pnlDonationEntry.Controls.Add(this.lblChequeNo);
            this.pnlDonationEntry.Controls.Add(this.lblBank);
            this.pnlDonationEntry.Controls.Add(this.lblChequeDate);
            this.pnlDonationEntry.Controls.Add(this.lblBranch);
            this.pnlDonationEntry.Controls.Add(this.rdoButtonCheque);
            this.pnlDonationEntry.Controls.Add(this.rdoButtonCash);
            this.pnlDonationEntry.Controls.Add(this.txtAmount);
            this.pnlDonationEntry.Controls.Add(this.cboPoojaName);
            this.pnlDonationEntry.Controls.Add(this.txtNameofDonor);
            this.pnlDonationEntry.Controls.Add(this.datPickereDonation);
            this.pnlDonationEntry.Controls.Add(this.txtReceiptNo);
            this.pnlDonationEntry.Controls.Add(this.lblDate);
            this.pnlDonationEntry.Controls.Add(this.lblPoojaName);
            this.pnlDonationEntry.Controls.Add(this.lblModeofPayment);
            this.pnlDonationEntry.Controls.Add(this.lblAmount);
            this.pnlDonationEntry.Controls.Add(this.lblNameofDonor);
            this.pnlDonationEntry.Controls.Add(this.lblReceiptNo);
            this.pnlDonationEntry.Location = new System.Drawing.Point(6, 36);
            this.pnlDonationEntry.Name = "pnlDonationEntry";
            this.pnlDonationEntry.Size = new System.Drawing.Size(523, 216);
            this.pnlDonationEntry.TabIndex = 0;
            this.pnlDonationEntry.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(420, 177);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSaveDonation
            // 
            this.btnSaveDonation.Location = new System.Drawing.Point(324, 177);
            this.btnSaveDonation.Name = "btnSaveDonation";
            this.btnSaveDonation.Size = new System.Drawing.Size(75, 23);
            this.btnSaveDonation.TabIndex = 21;
            this.btnSaveDonation.Text = "Save";
            this.btnSaveDonation.UseVisualStyleBackColor = true;
            this.btnSaveDonation.Click += new System.EventHandler(this.btnSaveDonation_Click);
            // 
            // txtChequeDate
            // 
            this.txtChequeDate.Location = new System.Drawing.Point(359, 142);
            this.txtChequeDate.Name = "txtChequeDate";
            this.txtChequeDate.Size = new System.Drawing.Size(136, 20);
            this.txtChequeDate.TabIndex = 20;
            // 
            // txtChequeNo
            // 
            this.txtChequeNo.Location = new System.Drawing.Point(94, 142);
            this.txtChequeNo.Name = "txtChequeNo";
            this.txtChequeNo.Size = new System.Drawing.Size(138, 20);
            this.txtChequeNo.TabIndex = 19;
            // 
            // txtBranch
            // 
            this.txtBranch.Location = new System.Drawing.Point(359, 107);
            this.txtBranch.Name = "txtBranch";
            this.txtBranch.Size = new System.Drawing.Size(136, 20);
            this.txtBranch.TabIndex = 18;
            // 
            // txtDrawnBank
            // 
            this.txtDrawnBank.Location = new System.Drawing.Point(94, 107);
            this.txtDrawnBank.Name = "txtDrawnBank";
            this.txtDrawnBank.Size = new System.Drawing.Size(138, 20);
            this.txtDrawnBank.TabIndex = 17;
            // 
            // lblChequeNo
            // 
            this.lblChequeNo.AutoSize = true;
            this.lblChequeNo.Location = new System.Drawing.Point(3, 145);
            this.lblChequeNo.Name = "lblChequeNo";
            this.lblChequeNo.Size = new System.Drawing.Size(84, 13);
            this.lblChequeNo.TabIndex = 16;
            this.lblChequeNo.Text = "Cheque Number";
            // 
            // lblBank
            // 
            this.lblBank.AutoSize = true;
            this.lblBank.Location = new System.Drawing.Point(3, 110);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(66, 13);
            this.lblBank.TabIndex = 15;
            this.lblBank.Text = "Drawn Bank";
            // 
            // lblChequeDate
            // 
            this.lblChequeDate.AutoSize = true;
            this.lblChequeDate.Location = new System.Drawing.Point(260, 145);
            this.lblChequeDate.Name = "lblChequeDate";
            this.lblChequeDate.Size = new System.Drawing.Size(70, 13);
            this.lblChequeDate.TabIndex = 14;
            this.lblChequeDate.Text = "Cheque Date";
            // 
            // lblBranch
            // 
            this.lblBranch.AutoSize = true;
            this.lblBranch.Location = new System.Drawing.Point(260, 110);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(41, 13);
            this.lblBranch.TabIndex = 13;
            this.lblBranch.Text = "Branch";
            // 
            // rdoButtonCheque
            // 
            this.rdoButtonCheque.AutoSize = true;
            this.rdoButtonCheque.Location = new System.Drawing.Point(433, 74);
            this.rdoButtonCheque.Name = "rdoButtonCheque";
            this.rdoButtonCheque.Size = new System.Drawing.Size(62, 17);
            this.rdoButtonCheque.TabIndex = 12;
            this.rdoButtonCheque.TabStop = true;
            this.rdoButtonCheque.Text = "Cheque";
            this.rdoButtonCheque.UseVisualStyleBackColor = true;
            // 
            // rdoButtonCash
            // 
            this.rdoButtonCash.AutoSize = true;
            this.rdoButtonCash.Location = new System.Drawing.Point(359, 74);
            this.rdoButtonCash.Name = "rdoButtonCash";
            this.rdoButtonCash.Size = new System.Drawing.Size(49, 17);
            this.rdoButtonCash.TabIndex = 11;
            this.rdoButtonCash.TabStop = true;
            this.rdoButtonCash.Text = "Cash";
            this.rdoButtonCash.UseVisualStyleBackColor = true;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(94, 73);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(138, 20);
            this.txtAmount.TabIndex = 10;
            // 
            // cboPoojaName
            // 
            this.cboPoojaName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPoojaName.FormattingEnabled = true;
            this.cboPoojaName.Location = new System.Drawing.Point(359, 40);
            this.cboPoojaName.Name = "cboPoojaName";
            this.cboPoojaName.Size = new System.Drawing.Size(136, 21);
            this.cboPoojaName.TabIndex = 9;
            // 
            // txtNameofDonor
            // 
            this.txtNameofDonor.Location = new System.Drawing.Point(94, 40);
            this.txtNameofDonor.Name = "txtNameofDonor";
            this.txtNameofDonor.Size = new System.Drawing.Size(138, 20);
            this.txtNameofDonor.TabIndex = 8;
            // 
            // datPickereDonation
            // 
            this.datPickereDonation.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datPickereDonation.Location = new System.Drawing.Point(359, 7);
            this.datPickereDonation.MaxDate = new System.DateTime(2017, 2, 8, 0, 0, 0, 0);
            this.datPickereDonation.MinDate = new System.DateTime(2017, 2, 8, 0, 0, 0, 0);
            this.datPickereDonation.Name = "datPickereDonation";
            this.datPickereDonation.Size = new System.Drawing.Size(136, 20);
            this.datPickereDonation.TabIndex = 7;
            this.datPickereDonation.Value = new System.DateTime(2017, 2, 8, 0, 0, 0, 0);
            // 
            // txtReceiptNo
            // 
            this.txtReceiptNo.Location = new System.Drawing.Point(94, 8);
            this.txtReceiptNo.Name = "txtReceiptNo";
            this.txtReceiptNo.ReadOnly = true;
            this.txtReceiptNo.Size = new System.Drawing.Size(138, 20);
            this.txtReceiptNo.TabIndex = 6;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(258, 11);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Date";
            // 
            // lblPoojaName
            // 
            this.lblPoojaName.AutoSize = true;
            this.lblPoojaName.Location = new System.Drawing.Point(258, 43);
            this.lblPoojaName.Name = "lblPoojaName";
            this.lblPoojaName.Size = new System.Drawing.Size(77, 13);
            this.lblPoojaName.TabIndex = 4;
            this.lblPoojaName.Text = "Name of Pooja";
            // 
            // lblModeofPayment
            // 
            this.lblModeofPayment.AutoSize = true;
            this.lblModeofPayment.Location = new System.Drawing.Point(258, 76);
            this.lblModeofPayment.Name = "lblModeofPayment";
            this.lblModeofPayment.Size = new System.Drawing.Size(90, 13);
            this.lblModeofPayment.TabIndex = 3;
            this.lblModeofPayment.Text = "Mode of Payment";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(3, 76);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 2;
            this.lblAmount.Text = "Amount";
            // 
            // lblNameofDonor
            // 
            this.lblNameofDonor.AutoSize = true;
            this.lblNameofDonor.Location = new System.Drawing.Point(3, 43);
            this.lblNameofDonor.Name = "lblNameofDonor";
            this.lblNameofDonor.Size = new System.Drawing.Size(79, 13);
            this.lblNameofDonor.TabIndex = 1;
            this.lblNameofDonor.Text = "Name of Donor";
            // 
            // lblReceiptNo
            // 
            this.lblReceiptNo.AutoSize = true;
            this.lblReceiptNo.Location = new System.Drawing.Point(3, 11);
            this.lblReceiptNo.Name = "lblReceiptNo";
            this.lblReceiptNo.Size = new System.Drawing.Size(84, 13);
            this.lblReceiptNo.TabIndex = 0;
            this.lblReceiptNo.Text = "Receipt Number";
            // 
            // pnlBackNewEntry
            // 
            this.pnlBackNewEntry.Location = new System.Drawing.Point(6, 36);
            this.pnlBackNewEntry.Name = "pnlBackNewEntry";
            this.pnlBackNewEntry.Size = new System.Drawing.Size(537, 219);
            this.pnlBackNewEntry.TabIndex = 4;
            // 
            // btnViewAllDonations
            // 
            this.btnViewAllDonations.Location = new System.Drawing.Point(102, 7);
            this.btnViewAllDonations.Name = "btnViewAllDonations";
            this.btnViewAllDonations.Size = new System.Drawing.Size(75, 23);
            this.btnViewAllDonations.TabIndex = 3;
            this.btnViewAllDonations.Text = "View All";
            this.btnViewAllDonations.UseVisualStyleBackColor = true;
            this.btnViewAllDonations.Click += new System.EventHandler(this.btnViewAllDonations_Click);
            // 
            // btnAddDonation
            // 
            this.btnAddDonation.Location = new System.Drawing.Point(6, 7);
            this.btnAddDonation.Name = "btnAddDonation";
            this.btnAddDonation.Size = new System.Drawing.Size(75, 23);
            this.btnAddDonation.TabIndex = 2;
            this.btnAddDonation.Text = "New Entry";
            this.btnAddDonation.UseVisualStyleBackColor = true;
            this.btnAddDonation.Click += new System.EventHandler(this.btnAddDonation_Click);
            // 
            // pnlViewAllDonations
            // 
            this.pnlViewAllDonations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlViewAllDonations.AutoSize = true;
            this.pnlViewAllDonations.Controls.Add(this.dgvAllDonations);
            this.pnlViewAllDonations.Location = new System.Drawing.Point(6, 261);
            this.pnlViewAllDonations.Name = "pnlViewAllDonations";
            this.pnlViewAllDonations.Size = new System.Drawing.Size(851, 200);
            this.pnlViewAllDonations.TabIndex = 1;
            // 
            // dgvAllDonations
            // 
            this.dgvAllDonations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAllDonations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllDonations.Location = new System.Drawing.Point(0, 13);
            this.dgvAllDonations.Name = "dgvAllDonations";
            this.dgvAllDonations.ReadOnly = true;
            this.dgvAllDonations.Size = new System.Drawing.Size(848, 174);
            this.dgvAllDonations.TabIndex = 0;
            this.dgvAllDonations.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(861, 476);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Receipt";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(14, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 37);
            this.panel1.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnViewAllPoojas);
            this.tabPage3.Controls.Add(this.btnUpdatePoojaDetails);
            this.tabPage3.Controls.Add(this.pnlViewPoojaDetails);
            this.tabPage3.Controls.Add(this.pnlUpdatePoojaDetails);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(861, 476);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Admin";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnViewAllPoojas
            // 
            this.btnViewAllPoojas.Location = new System.Drawing.Point(149, 13);
            this.btnViewAllPoojas.Name = "btnViewAllPoojas";
            this.btnViewAllPoojas.Size = new System.Drawing.Size(120, 23);
            this.btnViewAllPoojas.TabIndex = 3;
            this.btnViewAllPoojas.Text = "View Pooja Details";
            this.btnViewAllPoojas.UseVisualStyleBackColor = true;
            this.btnViewAllPoojas.Click += new System.EventHandler(this.btnViewAllPoojas_Click);
            // 
            // btnUpdatePoojaDetails
            // 
            this.btnUpdatePoojaDetails.Location = new System.Drawing.Point(6, 13);
            this.btnUpdatePoojaDetails.Name = "btnUpdatePoojaDetails";
            this.btnUpdatePoojaDetails.Size = new System.Drawing.Size(120, 23);
            this.btnUpdatePoojaDetails.TabIndex = 2;
            this.btnUpdatePoojaDetails.Text = "Update Pooja Details";
            this.btnUpdatePoojaDetails.UseVisualStyleBackColor = true;
            this.btnUpdatePoojaDetails.Click += new System.EventHandler(this.btnUpdatePoojaDetails_Click);
            // 
            // pnlViewPoojaDetails
            // 
            this.pnlViewPoojaDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlViewPoojaDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlViewPoojaDetails.Controls.Add(this.dgvAllPoojaDetails);
            this.pnlViewPoojaDetails.Location = new System.Drawing.Point(467, 13);
            this.pnlViewPoojaDetails.Name = "pnlViewPoojaDetails";
            this.pnlViewPoojaDetails.Size = new System.Drawing.Size(299, 413);
            this.pnlViewPoojaDetails.TabIndex = 1;
            this.pnlViewPoojaDetails.Visible = false;
            // 
            // dgvAllPoojaDetails
            // 
            this.dgvAllPoojaDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvAllPoojaDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllPoojaDetails.Location = new System.Drawing.Point(3, 3);
            this.dgvAllPoojaDetails.Name = "dgvAllPoojaDetails";
            this.dgvAllPoojaDetails.ReadOnly = true;
            this.dgvAllPoojaDetails.Size = new System.Drawing.Size(287, 398);
            this.dgvAllPoojaDetails.TabIndex = 0;
            // 
            // pnlUpdatePoojaDetails
            // 
            this.pnlUpdatePoojaDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUpdatePoojaDetails.Controls.Add(this.btnCancelUpdate);
            this.pnlUpdatePoojaDetails.Controls.Add(this.btnUpdate);
            this.pnlUpdatePoojaDetails.Controls.Add(this.txtNewAmount);
            this.pnlUpdatePoojaDetails.Controls.Add(this.txtOldAmount);
            this.pnlUpdatePoojaDetails.Controls.Add(this.comboBox1);
            this.pnlUpdatePoojaDetails.Controls.Add(this.label3);
            this.pnlUpdatePoojaDetails.Controls.Add(this.label2);
            this.pnlUpdatePoojaDetails.Controls.Add(this.label1);
            this.pnlUpdatePoojaDetails.Controls.Add(this.lblUpdatePoojaDetails);
            this.pnlUpdatePoojaDetails.Location = new System.Drawing.Point(6, 59);
            this.pnlUpdatePoojaDetails.Name = "pnlUpdatePoojaDetails";
            this.pnlUpdatePoojaDetails.Size = new System.Drawing.Size(397, 200);
            this.pnlUpdatePoojaDetails.TabIndex = 0;
            this.pnlUpdatePoojaDetails.Visible = false;
            // 
            // btnCancelUpdate
            // 
            this.btnCancelUpdate.Location = new System.Drawing.Point(276, 149);
            this.btnCancelUpdate.Name = "btnCancelUpdate";
            this.btnCancelUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnCancelUpdate.TabIndex = 8;
            this.btnCancelUpdate.Text = "Cancel";
            this.btnCancelUpdate.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(187, 149);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // txtNewAmount
            // 
            this.txtNewAmount.Location = new System.Drawing.Point(118, 108);
            this.txtNewAmount.Name = "txtNewAmount";
            this.txtNewAmount.Size = new System.Drawing.Size(100, 20);
            this.txtNewAmount.TabIndex = 6;
            // 
            // txtOldAmount
            // 
            this.txtOldAmount.Location = new System.Drawing.Point(118, 72);
            this.txtOldAmount.Name = "txtOldAmount";
            this.txtOldAmount.ReadOnly = true;
            this.txtOldAmount.Size = new System.Drawing.Size(100, 20);
            this.txtOldAmount.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(118, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(233, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "New Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Old Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Pooja";
            // 
            // lblUpdatePoojaDetails
            // 
            this.lblUpdatePoojaDetails.AutoSize = true;
            this.lblUpdatePoojaDetails.Location = new System.Drawing.Point(76, 9);
            this.lblUpdatePoojaDetails.Name = "lblUpdatePoojaDetails";
            this.lblUpdatePoojaDetails.Size = new System.Drawing.Size(107, 13);
            this.lblUpdatePoojaDetails.TabIndex = 0;
            this.lblUpdatePoojaDetails.Text = "Update Pooja Details";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 504);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.pnlDonationEntry.ResumeLayout(false);
            this.pnlDonationEntry.PerformLayout();
            this.pnlViewAllDonations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllDonations)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.pnlViewPoojaDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllPoojaDetails)).EndInit();
            this.pnlUpdatePoojaDetails.ResumeLayout(false);
            this.pnlUpdatePoojaDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddDonation;
        private System.Windows.Forms.Panel pnlViewAllDonations;
        private System.Windows.Forms.Panel pnlDonationEntry;
        private System.Windows.Forms.Label lblPoojaName;
        private System.Windows.Forms.Label lblModeofPayment;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblNameofDonor;
        private System.Windows.Forms.Label lblReceiptNo;
        private System.Windows.Forms.TextBox txtReceiptNo;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker datPickereDonation;
        private System.Windows.Forms.Label lblChequeNo;
        private System.Windows.Forms.Label lblBank;
        private System.Windows.Forms.Label lblChequeDate;
        private System.Windows.Forms.Label lblBranch;
        private System.Windows.Forms.RadioButton rdoButtonCheque;
        private System.Windows.Forms.RadioButton rdoButtonCash;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ComboBox cboPoojaName;
        private System.Windows.Forms.TextBox txtNameofDonor;
        private System.Windows.Forms.TextBox txtChequeDate;
        private System.Windows.Forms.TextBox txtChequeNo;
        private System.Windows.Forms.TextBox txtBranch;
        private System.Windows.Forms.TextBox txtDrawnBank;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveDonation;
        private System.Windows.Forms.Button btnViewAllDonations;
        private System.Windows.Forms.DataGridView dgvAllDonations;
        private System.Windows.Forms.Panel pnlViewPoojaDetails;
        private System.Windows.Forms.Panel pnlUpdatePoojaDetails;
        private System.Windows.Forms.DataGridView dgvAllPoojaDetails;
        private System.Windows.Forms.Button btnCancelUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtNewAmount;
        private System.Windows.Forms.TextBox txtOldAmount;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUpdatePoojaDetails;
        private System.Windows.Forms.Button btnUpdatePoojaDetails;
        private System.Windows.Forms.Panel pnlBackNewEntry;
        private System.Windows.Forms.Button btnViewAllPoojas;
    }
}

