namespace TravBot
{
    partial class MainView
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
            this.mainWB = new Awesomium.Windows.Forms.WebControl(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabs = new System.Windows.Forms.TabControl();
            this.browser = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.aBrowser = new Awesomium.Windows.Forms.WebControl(this.components);
            this.build = new System.Windows.Forms.TabPage();
            this.buildTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.serverAddr = new System.Windows.Forms.ComboBox();
            this.userPass = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabs.SuspendLayout();
            this.browser.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.build.SuspendLayout();
            this.buildTabs.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainWB
            // 
            this.mainWB.Location = new System.Drawing.Point(840, 378);
            this.mainWB.Size = new System.Drawing.Size(76, 77);
            this.mainWB.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tabs, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.loginPanel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.42949F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.57051F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1636, 804);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.browser);
            this.tabs.Controls.Add(this.build);
            this.tabs.Controls.Add(this.tabPage3);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(4, 152);
            this.tabs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1628, 648);
            this.tabs.TabIndex = 0;
            // 
            // browser
            // 
            this.browser.Controls.Add(this.tableLayoutPanel2);
            this.browser.Location = new System.Drawing.Point(4, 25);
            this.browser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.browser.Name = "browser";
            this.browser.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.browser.Size = new System.Drawing.Size(1620, 619);
            this.browser.TabIndex = 0;
            this.browser.Text = "Browser";
            this.browser.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.aBrowser, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.050505F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.94949F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1612, 611);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // aBrowser
            // 
            this.aBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aBrowser.Location = new System.Drawing.Point(4, 34);
            this.aBrowser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aBrowser.Size = new System.Drawing.Size(1604, 573);
            this.aBrowser.TabIndex = 0;
            // 
            // build
            // 
            this.build.Controls.Add(this.buildTabs);
            this.build.Location = new System.Drawing.Point(4, 25);
            this.build.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.build.Name = "build";
            this.build.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.build.Size = new System.Drawing.Size(1620, 620);
            this.build.TabIndex = 1;
            this.build.Text = "Build";
            this.build.UseVisualStyleBackColor = true;
            // 
            // buildTabs
            // 
            this.buildTabs.Controls.Add(this.tabPage1);
            this.buildTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buildTabs.Location = new System.Drawing.Point(4, 4);
            this.buildTabs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buildTabs.Name = "buildTabs";
            this.buildTabs.SelectedIndex = 0;
            this.buildTabs.Size = new System.Drawing.Size(1612, 612);
            this.buildTabs.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1604, 583);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Size = new System.Drawing.Size(1620, 620);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.serverAddr);
            this.loginPanel.Controls.Add(this.userPass);
            this.loginPanel.Controls.Add(this.userName);
            this.loginPanel.Controls.Add(this.login);
            this.loginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginPanel.Location = new System.Drawing.Point(4, 4);
            this.loginPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(1628, 140);
            this.loginPanel.TabIndex = 1;
            this.loginPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.loginPanel_Paint);
            // 
            // serverAddr
            // 
            this.serverAddr.FormattingEnabled = true;
            this.serverAddr.Items.AddRange(new object[] {
            "ts3.travian.no"});
            this.serverAddr.Location = new System.Drawing.Point(7, 70);
            this.serverAddr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.serverAddr.Name = "serverAddr";
            this.serverAddr.Size = new System.Drawing.Size(160, 24);
            this.serverAddr.TabIndex = 3;
            // 
            // userPass
            // 
            this.userPass.Location = new System.Drawing.Point(7, 38);
            this.userPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userPass.Name = "userPass";
            this.userPass.PasswordChar = '*';
            this.userPass.Size = new System.Drawing.Size(160, 22);
            this.userPass.TabIndex = 2;
            this.userPass.Text = "password";
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(7, 6);
            this.userName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(160, 22);
            this.userName.TabIndex = 1;
            this.userName.Text = "username";
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(176, 4);
            this.login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(100, 28);
            this.login.TabIndex = 0;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1636, 804);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainView";
            this.Text = "TravianBot v0.1 by Eska";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabs.ResumeLayout(false);
            this.browser.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.build.ResumeLayout(false);
            this.buildTabs.ResumeLayout(false);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Awesomium.Windows.Forms.WebControl mainWB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.TabControl tabs;
        public System.Windows.Forms.TabPage browser;
        private System.Windows.Forms.TabPage build;
        private System.Windows.Forms.Panel loginPanel;
        public System.Windows.Forms.ComboBox serverAddr;
        public System.Windows.Forms.TextBox userPass;
        public System.Windows.Forms.TextBox userName;
        public System.Windows.Forms.Button login;
        private System.Windows.Forms.TabPage tabPage3;
        public Awesomium.Windows.Forms.WebControl aBrowser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TabControl buildTabs;
        private System.Windows.Forms.TabPage tabPage1;
    }
}

