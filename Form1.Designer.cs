
namespace WindowsFormsApp1
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
            this.tab_CloudKeysAndConnection = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_isConnected = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_connectDB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_AzureAccountAndPrimaryKey = new System.Windows.Forms.TextBox();
            this.textBox_AzureAccountAndPointUri = new System.Windows.Forms.TextBox();
            this.tab_CloudDbAndTables = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_refreshTableList = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox_cloudTables = new System.Windows.Forms.ComboBox();
            this.btn_deleteDBfromCloud = new System.Windows.Forms.Button();
            this.btn_refreshDBlist = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox_cloudDBs = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_CreateTable = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_TableName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_DBname = new System.Windows.Forms.TextBox();
            this.tab_insertTab = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkedListBox_cloudActivity = new System.Windows.Forms.CheckedListBox();
            this.btn_insert = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox_textFromUser = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tab_CloudKeysAndConnection.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tab_CloudDbAndTables.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tab_insertTab.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_CloudKeysAndConnection);
            this.tabControl1.Controls.Add(this.tab_CloudDbAndTables);
            this.tabControl1.Controls.Add(this.tab_insertTab);
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1177, 530);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_CloudKeysAndConnection
            // 
            this.tab_CloudKeysAndConnection.Controls.Add(this.panel1);
            this.tab_CloudKeysAndConnection.Location = new System.Drawing.Point(4, 25);
            this.tab_CloudKeysAndConnection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_CloudKeysAndConnection.Name = "tab_CloudKeysAndConnection";
            this.tab_CloudKeysAndConnection.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_CloudKeysAndConnection.Size = new System.Drawing.Size(1169, 501);
            this.tab_CloudKeysAndConnection.TabIndex = 0;
            this.tab_CloudKeysAndConnection.Text = "COSMOS DB Client Creation";
            this.tab_CloudKeysAndConnection.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.ForeColor = System.Drawing.Color.Maroon;
            this.panel1.Location = new System.Drawing.Point(5, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1149, 228);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_isConnected);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_connectDB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_AzureAccountAndPrimaryKey);
            this.groupBox1.Controls.Add(this.textBox_AzureAccountAndPointUri);
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(13, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1116, 194);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AzureDbConnectionDetails";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_isConnected
            // 
            this.btn_isConnected.Location = new System.Drawing.Point(566, 155);
            this.btn_isConnected.Name = "btn_isConnected";
            this.btn_isConnected.Size = new System.Drawing.Size(243, 23);
            this.btn_isConnected.TabIndex = 2;
            this.btn_isConnected.Text = "Am i connected to DB?";
            this.btn_isConnected.UseVisualStyleBackColor = true;
            this.btn_isConnected.Click += new System.EventHandler(this.btn_isConnected_click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Primary";
            // 
            // btn_connectDB
            // 
            this.btn_connectDB.Location = new System.Drawing.Point(292, 155);
            this.btn_connectDB.Name = "btn_connectDB";
            this.btn_connectDB.Size = new System.Drawing.Size(171, 23);
            this.btn_connectDB.TabIndex = 1;
            this.btn_connectDB.Text = "connect to DB";
            this.btn_connectDB.UseVisualStyleBackColor = true;
            this.btn_connectDB.Click += new System.EventHandler(this.btn_connectDB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "URI";
            // 
            // textBox_AzureAccountAndPrimaryKey
            // 
            this.textBox_AzureAccountAndPrimaryKey.Location = new System.Drawing.Point(264, 111);
            this.textBox_AzureAccountAndPrimaryKey.Name = "textBox_AzureAccountAndPrimaryKey";
            this.textBox_AzureAccountAndPrimaryKey.ReadOnly = true;
            this.textBox_AzureAccountAndPrimaryKey.Size = new System.Drawing.Size(406, 22);
            this.textBox_AzureAccountAndPrimaryKey.TabIndex = 1;
            // 
            // textBox_AzureAccountAndPointUri
            // 
            this.textBox_AzureAccountAndPointUri.Location = new System.Drawing.Point(264, 46);
            this.textBox_AzureAccountAndPointUri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_AzureAccountAndPointUri.Name = "textBox_AzureAccountAndPointUri";
            this.textBox_AzureAccountAndPointUri.ReadOnly = true;
            this.textBox_AzureAccountAndPointUri.Size = new System.Drawing.Size(406, 22);
            this.textBox_AzureAccountAndPointUri.TabIndex = 0;
            // 
            // tab_CloudDbAndTables
            // 
            this.tab_CloudDbAndTables.Controls.Add(this.panel5);
            this.tab_CloudDbAndTables.Controls.Add(this.panel2);
            this.tab_CloudDbAndTables.ForeColor = System.Drawing.Color.Maroon;
            this.tab_CloudDbAndTables.Location = new System.Drawing.Point(4, 25);
            this.tab_CloudDbAndTables.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_CloudDbAndTables.Name = "tab_CloudDbAndTables";
            this.tab_CloudDbAndTables.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_CloudDbAndTables.Size = new System.Drawing.Size(1169, 501);
            this.tab_CloudDbAndTables.TabIndex = 1;
            this.tab_CloudDbAndTables.Text = "Cloud DB\'s And Tables";
            this.tab_CloudDbAndTables.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.btn_refreshTableList);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.comboBox_cloudTables);
            this.panel5.Controls.Add(this.btn_deleteDBfromCloud);
            this.panel5.Controls.Add(this.btn_refreshDBlist);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.comboBox_cloudDBs);
            this.panel5.Location = new System.Drawing.Point(15, 251);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1148, 247);
            this.panel5.TabIndex = 2;
            // 
            // btn_refreshTableList
            // 
            this.btn_refreshTableList.Location = new System.Drawing.Point(526, 155);
            this.btn_refreshTableList.Name = "btn_refreshTableList";
            this.btn_refreshTableList.Size = new System.Drawing.Size(143, 23);
            this.btn_refreshTableList.TabIndex = 11;
            this.btn_refreshTableList.Text = "refresh Table list";
            this.btn_refreshTableList.UseVisualStyleBackColor = true;
            this.btn_refreshTableList.Click += new System.EventHandler(this.btn_refreshTableList_Click_2);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(699, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Delete Table";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(120, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tables:";
            // 
            // comboBox_cloudTables
            // 
            this.comboBox_cloudTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_cloudTables.ForeColor = System.Drawing.Color.Maroon;
            this.comboBox_cloudTables.FormattingEnabled = true;
            this.comboBox_cloudTables.Location = new System.Drawing.Point(196, 151);
            this.comboBox_cloudTables.Name = "comboBox_cloudTables";
            this.comboBox_cloudTables.Size = new System.Drawing.Size(279, 24);
            this.comboBox_cloudTables.TabIndex = 7;
            this.comboBox_cloudTables.SelectedIndexChanged += new System.EventHandler(this.comboBox_cloudTables_SelectedIndexChanged);
            // 
            // btn_deleteDBfromCloud
            // 
            this.btn_deleteDBfromCloud.Location = new System.Drawing.Point(699, 96);
            this.btn_deleteDBfromCloud.Name = "btn_deleteDBfromCloud";
            this.btn_deleteDBfromCloud.Size = new System.Drawing.Size(122, 23);
            this.btn_deleteDBfromCloud.TabIndex = 6;
            this.btn_deleteDBfromCloud.Text = "Delete DB";
            this.btn_deleteDBfromCloud.UseVisualStyleBackColor = true;
            this.btn_deleteDBfromCloud.Click += new System.EventHandler(this.btn_deleteDBfromCloud_Click);
            // 
            // btn_refreshDBlist
            // 
            this.btn_refreshDBlist.Location = new System.Drawing.Point(526, 96);
            this.btn_refreshDBlist.Name = "btn_refreshDBlist";
            this.btn_refreshDBlist.Size = new System.Drawing.Size(143, 23);
            this.btn_refreshDBlist.TabIndex = 5;
            this.btn_refreshDBlist.Text = "refresh DB list";
            this.btn_refreshDBlist.UseVisualStyleBackColor = true;
            this.btn_refreshDBlist.Click += new System.EventHandler(this.btn_refreshDBlist_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(109, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "DataBases:";
            // 
            // comboBox_cloudDBs
            // 
            this.comboBox_cloudDBs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_cloudDBs.ForeColor = System.Drawing.Color.Maroon;
            this.comboBox_cloudDBs.FormattingEnabled = true;
            this.comboBox_cloudDBs.Location = new System.Drawing.Point(196, 92);
            this.comboBox_cloudDBs.Name = "comboBox_cloudDBs";
            this.comboBox_cloudDBs.Size = new System.Drawing.Size(279, 24);
            this.comboBox_cloudDBs.TabIndex = 0;
            this.comboBox_cloudDBs.SelectedIndexChanged += new System.EventHandler(this.comboBox_cloudDBs_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Location = new System.Drawing.Point(17, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1128, 228);
            this.panel2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_CreateTable);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox_TableName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox_DBname);
            this.groupBox2.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox2.Location = new System.Drawing.Point(34, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1075, 202);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create DB or table in your Account";
            // 
            // btn_CreateTable
            // 
            this.btn_CreateTable.Enabled = false;
            this.btn_CreateTable.Location = new System.Drawing.Point(418, 143);
            this.btn_CreateTable.Name = "btn_CreateTable";
            this.btn_CreateTable.Size = new System.Drawing.Size(193, 23);
            this.btn_CreateTable.TabIndex = 4;
            this.btn_CreateTable.Text = "Create DB / Table";
            this.btn_CreateTable.UseVisualStyleBackColor = true;
            this.btn_CreateTable.Click += new System.EventHandler(this.btn_createTable_click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Table";
            this.label4.Click += new System.EventHandler(this.btn_createTable_click);
            // 
            // textBox_TableName
            // 
            this.textBox_TableName.Location = new System.Drawing.Point(380, 92);
            this.textBox_TableName.Name = "textBox_TableName";
            this.textBox_TableName.Size = new System.Drawing.Size(470, 22);
            this.textBox_TableName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Database:";
            // 
            // textBox_DBname
            // 
            this.textBox_DBname.Location = new System.Drawing.Point(380, 36);
            this.textBox_DBname.Name = "textBox_DBname";
            this.textBox_DBname.Size = new System.Drawing.Size(429, 22);
            this.textBox_DBname.TabIndex = 0;
            this.textBox_DBname.TextChanged += new System.EventHandler(this.textBox_DBname_TextChanged);
            // 
            // tab_insertTab
            // 
            this.tab_insertTab.Controls.Add(this.panel3);
            this.tab_insertTab.Location = new System.Drawing.Point(4, 25);
            this.tab_insertTab.Name = "tab_insertTab";
            this.tab_insertTab.Padding = new System.Windows.Forms.Padding(3);
            this.tab_insertTab.Size = new System.Drawing.Size(1169, 501);
            this.tab_insertTab.TabIndex = 2;
            this.tab_insertTab.Text = "insertValue";
            this.tab_insertTab.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Location = new System.Drawing.Point(6, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(364, 424);
            this.panel3.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.richTextBox_textFromUser);
            this.groupBox3.Controls.Add(this.checkedListBox_cloudActivity);
            this.groupBox3.Controls.Add(this.btn_insert);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox3.Location = new System.Drawing.Point(25, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(317, 405);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data Activities";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // checkedListBox_cloudActivity
            // 
            this.checkedListBox_cloudActivity.FormattingEnabled = true;
            this.checkedListBox_cloudActivity.Items.AddRange(new object[] {
            "insert new data into cloud",
            "modify data",
            "delete data from cloud"});
            this.checkedListBox_cloudActivity.Location = new System.Drawing.Point(41, 236);
            this.checkedListBox_cloudActivity.Name = "checkedListBox_cloudActivity";
            this.checkedListBox_cloudActivity.Size = new System.Drawing.Size(234, 89);
            this.checkedListBox_cloudActivity.TabIndex = 7;
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(85, 347);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(112, 23);
            this.btn_insert.TabIndex = 6;
            this.btn_insert.Text = "execute query";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Data to enter";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // richTextBox_textFromUser
            // 
            this.richTextBox_textFromUser.Location = new System.Drawing.Point(27, 93);
            this.richTextBox_textFromUser.Name = "richTextBox_textFromUser";
            this.richTextBox_textFromUser.Size = new System.Drawing.Size(248, 137);
            this.richTextBox_textFromUser.TabIndex = 8;
            this.richTextBox_textFromUser.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 562);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_CloudKeysAndConnection.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tab_CloudDbAndTables.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tab_insertTab.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_CloudKeysAndConnection;
        private System.Windows.Forms.TabPage tab_CloudDbAndTables;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_AzureAccountAndPointUri;
        private System.Windows.Forms.TextBox textBox_AzureAccountAndPrimaryKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_connectDB;
        private System.Windows.Forms.Button btn_isConnected;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_TableName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_DBname;
        private System.Windows.Forms.Button btn_CreateTable;
        private System.Windows.Forms.TabPage tab_insertTab;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox_cloudTables;
        private System.Windows.Forms.Button btn_deleteDBfromCloud;
        private System.Windows.Forms.Button btn_refreshDBlist;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox_cloudDBs;
        private System.Windows.Forms.Button btn_refreshTableList;
        private System.Windows.Forms.CheckedListBox checkedListBox_cloudActivity;
        private System.Windows.Forms.RichTextBox richTextBox_textFromUser;
    }
}

