namespace studiu_individual
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchEvent = new System.Windows.Forms.Button();
            this.searchEventTextBox = new System.Windows.Forms.TextBox();
            this.deleteEvent = new System.Windows.Forms.Button();
            this.updateEvent = new System.Windows.Forms.Button();
            this.addEvent = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_evenimente = new System.Windows.Forms.DateTimePicker();
            this.tipEvenimentTextBox = new System.Windows.Forms.TextBox();
            this.locuriTextBox = new System.Windows.Forms.TextBox();
            this.locatieTextBox = new System.Windows.Forms.TextBox();
            this.denumireTextBox = new System.Windows.Forms.TextBox();
            this.eventDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.deleteParticipant = new System.Windows.Forms.Button();
            this.updateParticipant = new System.Windows.Forms.Button();
            this.searchParticipant = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.searchParticipantTextBox = new System.Windows.Forms.TextBox();
            this.addParticipant = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.prenumeTextBox = new System.Windows.Forms.TextBox();
            this.numeTextBox = new System.Windows.Forms.TextBox();
            this.participantDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.showAllRegistration = new System.Windows.Forms.Button();
            this.searchRegistrationByStatus = new System.Windows.Forms.Button();
            this.searchRegistrationByEvent = new System.Windows.Forms.Button();
            this.newRegistration = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.participantComboBox = new System.Windows.Forms.ComboBox();
            this.eventComboBox = new System.Windows.Forms.ComboBox();
            this.regDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.reportNrOfParticipantPerEvent = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.participantsOnSpecificEvent = new System.Windows.Forms.Button();
            this.reportEventsComboBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventDataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.participantDataGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regDataGridView)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1228, 812);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage1.Size = new System.Drawing.Size(1212, 765);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Gestionare Evenimente";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.eventDataGridView, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1200, 753);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.searchEvent);
            this.panel1.Controls.Add(this.searchEventTextBox);
            this.panel1.Controls.Add(this.deleteEvent);
            this.panel1.Controls.Add(this.updateEvent);
            this.panel1.Controls.Add(this.addEvent);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimePicker_evenimente);
            this.panel1.Controls.Add(this.tipEvenimentTextBox);
            this.panel1.Controls.Add(this.locuriTextBox);
            this.panel1.Controls.Add(this.locatieTextBox);
            this.panel1.Controls.Add(this.denumireTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 506);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1194, 244);
            this.panel1.TabIndex = 0;
            // 
            // searchEvent
            // 
            this.searchEvent.Location = new System.Drawing.Point(701, 147);
            this.searchEvent.Name = "searchEvent";
            this.searchEvent.Size = new System.Drawing.Size(155, 39);
            this.searchEvent.TabIndex = 14;
            this.searchEvent.Text = "Caută";
            this.searchEvent.UseVisualStyleBackColor = true;
            this.searchEvent.Click += new System.EventHandler(this.searchEvent_Click);
            // 
            // searchEventTextBox
            // 
            this.searchEventTextBox.Location = new System.Drawing.Point(701, 107);
            this.searchEventTextBox.Name = "searchEventTextBox";
            this.searchEventTextBox.Size = new System.Drawing.Size(274, 31);
            this.searchEventTextBox.TabIndex = 13;
            // 
            // deleteEvent
            // 
            this.deleteEvent.Location = new System.Drawing.Point(436, 185);
            this.deleteEvent.Name = "deleteEvent";
            this.deleteEvent.Size = new System.Drawing.Size(155, 39);
            this.deleteEvent.TabIndex = 12;
            this.deleteEvent.Text = "Ștergere";
            this.deleteEvent.UseVisualStyleBackColor = true;
            this.deleteEvent.Click += new System.EventHandler(this.deleteEvent_Click);
            // 
            // updateEvent
            // 
            this.updateEvent.Location = new System.Drawing.Point(436, 140);
            this.updateEvent.Name = "updateEvent";
            this.updateEvent.Size = new System.Drawing.Size(155, 39);
            this.updateEvent.TabIndex = 11;
            this.updateEvent.Text = "Actualizare";
            this.updateEvent.UseVisualStyleBackColor = true;
            this.updateEvent.Click += new System.EventHandler(this.updateEvent_Click);
            // 
            // addEvent
            // 
            this.addEvent.Location = new System.Drawing.Point(436, 96);
            this.addEvent.Name = "addEvent";
            this.addEvent.Size = new System.Drawing.Size(155, 39);
            this.addEvent.TabIndex = 10;
            this.addEvent.Text = "Adăugare";
            this.addEvent.UseVisualStyleBackColor = true;
            this.addEvent.Click += new System.EventHandler(this.addEvent_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tip eveniment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Locuri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Locatie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Denumire";
            // 
            // dateTimePicker_evenimente
            // 
            this.dateTimePicker_evenimente.Location = new System.Drawing.Point(193, 70);
            this.dateTimePicker_evenimente.Name = "dateTimePicker_evenimente";
            this.dateTimePicker_evenimente.Size = new System.Drawing.Size(226, 31);
            this.dateTimePicker_evenimente.TabIndex = 4;
            // 
            // tipEvenimentTextBox
            // 
            this.tipEvenimentTextBox.Location = new System.Drawing.Point(193, 181);
            this.tipEvenimentTextBox.Name = "tipEvenimentTextBox";
            this.tipEvenimentTextBox.Size = new System.Drawing.Size(226, 31);
            this.tipEvenimentTextBox.TabIndex = 3;
            // 
            // locuriTextBox
            // 
            this.locuriTextBox.Location = new System.Drawing.Point(193, 144);
            this.locuriTextBox.Name = "locuriTextBox";
            this.locuriTextBox.Size = new System.Drawing.Size(226, 31);
            this.locuriTextBox.TabIndex = 2;
            // 
            // locatieTextBox
            // 
            this.locatieTextBox.Location = new System.Drawing.Point(193, 107);
            this.locatieTextBox.Name = "locatieTextBox";
            this.locatieTextBox.Size = new System.Drawing.Size(226, 31);
            this.locatieTextBox.TabIndex = 1;
            // 
            // denumireTextBox
            // 
            this.denumireTextBox.Location = new System.Drawing.Point(193, 33);
            this.denumireTextBox.Name = "denumireTextBox";
            this.denumireTextBox.Size = new System.Drawing.Size(226, 31);
            this.denumireTextBox.TabIndex = 0;
            // 
            // eventDataGridView
            // 
            this.eventDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventDataGridView.Location = new System.Drawing.Point(3, 3);
            this.eventDataGridView.Name = "eventDataGridView";
            this.eventDataGridView.RowHeadersWidth = 82;
            this.eventDataGridView.RowTemplate.Height = 33;
            this.eventDataGridView.Size = new System.Drawing.Size(1194, 497);
            this.eventDataGridView.TabIndex = 1;
            this.eventDataGridView.SelectionChanged += new System.EventHandler(this.eventDataGridView_SelectionChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage2.Size = new System.Drawing.Size(1212, 765);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Gestionare Participanti";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.participantDataGridView, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1200, 753);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.deleteParticipant);
            this.panel2.Controls.Add(this.updateParticipant);
            this.panel2.Controls.Add(this.searchParticipant);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.searchParticipantTextBox);
            this.panel2.Controls.Add(this.addParticipant);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.emailTextBox);
            this.panel2.Controls.Add(this.prenumeTextBox);
            this.panel2.Controls.Add(this.numeTextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 556);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1194, 194);
            this.panel2.TabIndex = 0;
            // 
            // deleteParticipant
            // 
            this.deleteParticipant.Location = new System.Drawing.Point(419, 123);
            this.deleteParticipant.Name = "deleteParticipant";
            this.deleteParticipant.Size = new System.Drawing.Size(167, 35);
            this.deleteParticipant.TabIndex = 11;
            this.deleteParticipant.Text = "Șterge";
            this.deleteParticipant.UseVisualStyleBackColor = true;
            this.deleteParticipant.Click += new System.EventHandler(this.deleteParticipant_Click);
            // 
            // updateParticipant
            // 
            this.updateParticipant.Location = new System.Drawing.Point(419, 82);
            this.updateParticipant.Name = "updateParticipant";
            this.updateParticipant.Size = new System.Drawing.Size(167, 35);
            this.updateParticipant.TabIndex = 10;
            this.updateParticipant.Text = "Actualizează";
            this.updateParticipant.UseVisualStyleBackColor = true;
            this.updateParticipant.Click += new System.EventHandler(this.updateParticipant_Click);
            // 
            // searchParticipant
            // 
            this.searchParticipant.Location = new System.Drawing.Point(630, 120);
            this.searchParticipant.Name = "searchParticipant";
            this.searchParticipant.Size = new System.Drawing.Size(141, 35);
            this.searchParticipant.TabIndex = 9;
            this.searchParticipant.Text = "Caută";
            this.searchParticipant.UseVisualStyleBackColor = true;
            this.searchParticipant.Click += new System.EventHandler(this.searchParticipant_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(625, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "Nume";
            // 
            // searchParticipantTextBox
            // 
            this.searchParticipantTextBox.Location = new System.Drawing.Point(630, 83);
            this.searchParticipantTextBox.Name = "searchParticipantTextBox";
            this.searchParticipantTextBox.Size = new System.Drawing.Size(234, 31);
            this.searchParticipantTextBox.TabIndex = 7;
            // 
            // addParticipant
            // 
            this.addParticipant.Location = new System.Drawing.Point(419, 41);
            this.addParticipant.Name = "addParticipant";
            this.addParticipant.Size = new System.Drawing.Size(167, 35);
            this.addParticipant.TabIndex = 6;
            this.addParticipant.Text = "Adaugă";
            this.addParticipant.UseVisualStyleBackColor = true;
            this.addParticipant.Click += new System.EventHandler(this.addParticipant_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Prenume";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Nume";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(151, 117);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(234, 31);
            this.emailTextBox.TabIndex = 2;
            // 
            // prenumeTextBox
            // 
            this.prenumeTextBox.Location = new System.Drawing.Point(151, 80);
            this.prenumeTextBox.Name = "prenumeTextBox";
            this.prenumeTextBox.Size = new System.Drawing.Size(234, 31);
            this.prenumeTextBox.TabIndex = 1;
            // 
            // numeTextBox
            // 
            this.numeTextBox.Location = new System.Drawing.Point(151, 43);
            this.numeTextBox.Name = "numeTextBox";
            this.numeTextBox.Size = new System.Drawing.Size(234, 31);
            this.numeTextBox.TabIndex = 0;
            // 
            // participantDataGridView
            // 
            this.participantDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.participantDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.participantDataGridView.Location = new System.Drawing.Point(3, 3);
            this.participantDataGridView.Name = "participantDataGridView";
            this.participantDataGridView.RowHeadersWidth = 82;
            this.participantDataGridView.RowTemplate.Height = 33;
            this.participantDataGridView.Size = new System.Drawing.Size(1194, 547);
            this.participantDataGridView.TabIndex = 1;
            this.participantDataGridView.SelectionChanged += new System.EventHandler(this.participantDataGridView_SelectionChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel3);
            this.tabPage3.Location = new System.Drawing.Point(8, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1212, 765);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Gestionare inscrieri";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.regDataGridView, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1206, 759);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.showAllRegistration);
            this.panel3.Controls.Add(this.searchRegistrationByStatus);
            this.panel3.Controls.Add(this.searchRegistrationByEvent);
            this.panel3.Controls.Add(this.newRegistration);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.statusTextBox);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.participantComboBox);
            this.panel3.Controls.Add(this.eventComboBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 602);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1200, 154);
            this.panel3.TabIndex = 0;
            // 
            // showAllRegistration
            // 
            this.showAllRegistration.Location = new System.Drawing.Point(653, 92);
            this.showAllRegistration.Name = "showAllRegistration";
            this.showAllRegistration.Size = new System.Drawing.Size(299, 36);
            this.showAllRegistration.TabIndex = 9;
            this.showAllRegistration.Text = "Afișează tot";
            this.showAllRegistration.UseVisualStyleBackColor = true;
            this.showAllRegistration.Click += new System.EventHandler(this.showAllRegistration_Click);
            // 
            // searchRegistrationByStatus
            // 
            this.searchRegistrationByStatus.Location = new System.Drawing.Point(653, 53);
            this.searchRegistrationByStatus.Name = "searchRegistrationByStatus";
            this.searchRegistrationByStatus.Size = new System.Drawing.Size(299, 36);
            this.searchRegistrationByStatus.TabIndex = 8;
            this.searchRegistrationByStatus.Text = "Caută dupa status";
            this.searchRegistrationByStatus.UseVisualStyleBackColor = true;
            this.searchRegistrationByStatus.Click += new System.EventHandler(this.searchRegistrationByStatus_Click);
            // 
            // searchRegistrationByEvent
            // 
            this.searchRegistrationByEvent.Location = new System.Drawing.Point(653, 16);
            this.searchRegistrationByEvent.Name = "searchRegistrationByEvent";
            this.searchRegistrationByEvent.Size = new System.Drawing.Size(299, 36);
            this.searchRegistrationByEvent.TabIndex = 7;
            this.searchRegistrationByEvent.Text = "Caută după eveniment";
            this.searchRegistrationByEvent.UseVisualStyleBackColor = true;
            this.searchRegistrationByEvent.Click += new System.EventHandler(this.searchRegistrationByEvent_Click);
            // 
            // newRegistration
            // 
            this.newRegistration.Location = new System.Drawing.Point(444, 53);
            this.newRegistration.Name = "newRegistration";
            this.newRegistration.Size = new System.Drawing.Size(185, 36);
            this.newRegistration.TabIndex = 6;
            this.newRegistration.Text = "Inscriere nouă";
            this.newRegistration.UseVisualStyleBackColor = true;
            this.newRegistration.Click += new System.EventHandler(this.newRegistration_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(48, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 25);
            this.label12.TabIndex = 5;
            this.label12.Text = "Status";
            // 
            // statusTextBox
            // 
            this.statusTextBox.Location = new System.Drawing.Point(143, 95);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(295, 31);
            this.statusTextBox.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 25);
            this.label11.TabIndex = 3;
            this.label11.Text = "Participant";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 25);
            this.label10.TabIndex = 2;
            this.label10.Text = "Eveniment";
            // 
            // participantComboBox
            // 
            this.participantComboBox.FormattingEnabled = true;
            this.participantComboBox.Location = new System.Drawing.Point(143, 56);
            this.participantComboBox.Name = "participantComboBox";
            this.participantComboBox.Size = new System.Drawing.Size(295, 33);
            this.participantComboBox.TabIndex = 1;
            // 
            // eventComboBox
            // 
            this.eventComboBox.FormattingEnabled = true;
            this.eventComboBox.Location = new System.Drawing.Point(143, 17);
            this.eventComboBox.Name = "eventComboBox";
            this.eventComboBox.Size = new System.Drawing.Size(295, 33);
            this.eventComboBox.TabIndex = 0;
            // 
            // regDataGridView
            // 
            this.regDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.regDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.regDataGridView.Location = new System.Drawing.Point(3, 3);
            this.regDataGridView.Name = "regDataGridView";
            this.regDataGridView.RowHeadersWidth = 82;
            this.regDataGridView.RowTemplate.Height = 33;
            this.regDataGridView.Size = new System.Drawing.Size(1200, 593);
            this.regDataGridView.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tableLayoutPanel4);
            this.tabPage4.Location = new System.Drawing.Point(8, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1212, 765);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Rapoarte";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.reportViewer1, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1206, 759);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.reportEventsComboBox);
            this.panel4.Controls.Add(this.participantsOnSpecificEvent);
            this.panel4.Controls.Add(this.reportNrOfParticipantPerEvent);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 642);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1200, 114);
            this.panel4.TabIndex = 0;
            // 
            // reportNrOfParticipantPerEvent
            // 
            this.reportNrOfParticipantPerEvent.Location = new System.Drawing.Point(17, 18);
            this.reportNrOfParticipantPerEvent.Name = "reportNrOfParticipantPerEvent";
            this.reportNrOfParticipantPerEvent.Size = new System.Drawing.Size(297, 80);
            this.reportNrOfParticipantPerEvent.TabIndex = 0;
            this.reportNrOfParticipantPerEvent.Text = "Numărul de participanti\r\nper eveniment";
            this.reportNrOfParticipantPerEvent.UseVisualStyleBackColor = true;
            this.reportNrOfParticipantPerEvent.Click += new System.EventHandler(this.reportNrOfParticipantPerEvent_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1200, 633);
            this.reportViewer1.TabIndex = 1;
            // 
            // participantsOnSpecificEvent
            // 
            this.participantsOnSpecificEvent.Location = new System.Drawing.Point(756, 42);
            this.participantsOnSpecificEvent.Name = "participantsOnSpecificEvent";
            this.participantsOnSpecificEvent.Size = new System.Drawing.Size(395, 56);
            this.participantsOnSpecificEvent.TabIndex = 1;
            this.participantsOnSpecificEvent.Text = "Participanti la un eveniment anumit";
            this.participantsOnSpecificEvent.UseVisualStyleBackColor = true;
            this.participantsOnSpecificEvent.Click += new System.EventHandler(this.participantsOnSpecificEvent_Click);
            // 
            // reportEventsComboBox
            // 
            this.reportEventsComboBox.FormattingEnabled = true;
            this.reportEventsComboBox.Location = new System.Drawing.Point(340, 55);
            this.reportEventsComboBox.Name = "reportEventsComboBox";
            this.reportEventsComboBox.Size = new System.Drawing.Size(400, 33);
            this.reportEventsComboBox.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(335, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 25);
            this.label13.TabIndex = 3;
            this.label13.Text = "Eveniment";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 812);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventDataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.participantDataGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regDataGridView)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView eventDataGridView;
        private System.Windows.Forms.TextBox denumireTextBox;
        private System.Windows.Forms.TextBox tipEvenimentTextBox;
        private System.Windows.Forms.TextBox locuriTextBox;
        private System.Windows.Forms.TextBox locatieTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker_evenimente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addEvent;
        private System.Windows.Forms.Button deleteEvent;
        private System.Windows.Forms.Button updateEvent;
        private System.Windows.Forms.Button searchEvent;
        private System.Windows.Forms.TextBox searchEventTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView participantDataGridView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox prenumeTextBox;
        private System.Windows.Forms.TextBox numeTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addParticipant;
        private System.Windows.Forms.Button deleteParticipant;
        private System.Windows.Forms.Button updateParticipant;
        private System.Windows.Forms.Button searchParticipant;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox searchParticipantTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView regDataGridView;
        private System.Windows.Forms.ComboBox participantComboBox;
        private System.Windows.Forms.ComboBox eventComboBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.Button newRegistration;
        private System.Windows.Forms.Button searchRegistrationByEvent;
        private System.Windows.Forms.Button searchRegistrationByStatus;
        private System.Windows.Forms.Button showAllRegistration;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button reportNrOfParticipantPerEvent;
        private System.Windows.Forms.Button participantsOnSpecificEvent;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox reportEventsComboBox;
    }
}

