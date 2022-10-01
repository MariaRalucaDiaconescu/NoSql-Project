﻿
namespace DemoApp
{
    partial class Main
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.sideBar = new System.Windows.Forms.TableLayoutPanel();
            this.pic_Logo = new System.Windows.Forms.PictureBox();
            this.tblPnl_UserInfo = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Welcome = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Role = new System.Windows.Forms.Label();
            this.flowPnl_Navigation = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Dashboard = new DemoApp.Custom_Controls.RoundedButton();
            this.btn_TicketManagement = new DemoApp.Custom_Controls.RoundedButton();
            this.btn_CreateTicket = new DemoApp.Custom_Controls.RoundedButton();
            this.btn_UserManagement = new DemoApp.Custom_Controls.RoundedButton();
            this.btn_CreateUser = new DemoApp.Custom_Controls.RoundedButton();
            this.lbl_LogOut = new System.Windows.Forms.Label();
            this.tabControl = new DemoApp.Custom_Controls.TabControlWithoutBorder();
            this.tab_Dashboard = new System.Windows.Forms.TabPage();
            this.rPnl_Dashboard = new DemoApp.Custom_Controls.RoundedPanel();
            this.tblPnl_DashboardNew = new DemoApp.Custom_Controls.FasterTableLayoutPanel();
            this.rPnl_D1_Open = new DemoApp.Custom_Controls.RoundedPanel();
            this.lbl_OpenIncidents_Desc = new System.Windows.Forms.Label();
            this.lbl_OpenIncidents_Title = new System.Windows.Forms.Label();
            this.rPnl_D2_Past = new DemoApp.Custom_Controls.RoundedPanel();
            this.lbl_PastDeadline_Desc = new System.Windows.Forms.Label();
            this.lbl_PastDeadline_Title = new System.Windows.Forms.Label();
            this.rPnl_D3_Unresolved = new DemoApp.Custom_Controls.RoundedPanel();
            this.lbl_Unresolved_Desc = new System.Windows.Forms.Label();
            this.lbl_Unresolved_Title = new System.Windows.Forms.Label();
            this.rPnl_D4_Resolved = new DemoApp.Custom_Controls.RoundedPanel();
            this.lbl_Resolved_Desc = new System.Windows.Forms.Label();
            this.lbl_Resolved_Title = new System.Windows.Forms.Label();
            this.header_Dashboard = new System.Windows.Forms.Panel();
            this.lbl_HeaderDashboard = new System.Windows.Forms.Label();
            this.tab_TicketManagement = new System.Windows.Forms.TabPage();
            this.rPnl_TicketManagement = new DemoApp.Custom_Controls.RoundedPanel();
            this.header_TicketManagement = new System.Windows.Forms.Panel();
            this.lbl_HeaderTicketManagement = new System.Windows.Forms.Label();
            this.tab_CreateTicket = new System.Windows.Forms.TabPage();
            this.rPnl_CreateTicket = new DemoApp.Custom_Controls.RoundedPanel();
            this.header_CreateTicket = new System.Windows.Forms.Panel();
            this.lbl_HeaderCreateTicket = new System.Windows.Forms.Label();
            this.tab_UserManagement = new System.Windows.Forms.TabPage();
            this.rPnl_UserManagement = new DemoApp.Custom_Controls.RoundedPanel();
            this.header_UserManagement = new System.Windows.Forms.Panel();
            this.lbl_HeaderUserManagement = new System.Windows.Forms.Label();
            this.tab_CreateUser = new System.Windows.Forms.TabPage();
            this.rPnl_CreateUser = new DemoApp.Custom_Controls.RoundedPanel();
            this.header_CreateUser = new System.Windows.Forms.Panel();
            this.lbl_HeaderCreateUser = new System.Windows.Forms.Label();
            this.circularProgressBar2 = new DemoApp.Custom_Controls.CircularProgressBar();
            this.circularProgressBar1 = new DemoApp.Custom_Controls.CircularProgressBar();
            this.circularProgressBar3 = new DemoApp.Custom_Controls.CircularProgressBar();
            this.circularProgressBar4 = new DemoApp.Custom_Controls.CircularProgressBar();
            this.tableLayoutPanel.SuspendLayout();
            this.sideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).BeginInit();
            this.tblPnl_UserInfo.SuspendLayout();
            this.flowPnl_Navigation.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tab_Dashboard.SuspendLayout();
            this.rPnl_Dashboard.SuspendLayout();
            this.tblPnl_DashboardNew.SuspendLayout();
            this.rPnl_D1_Open.SuspendLayout();
            this.rPnl_D2_Past.SuspendLayout();
            this.rPnl_D3_Unresolved.SuspendLayout();
            this.rPnl_D4_Resolved.SuspendLayout();
            this.header_Dashboard.SuspendLayout();
            this.tab_TicketManagement.SuspendLayout();
            this.rPnl_TicketManagement.SuspendLayout();
            this.header_TicketManagement.SuspendLayout();
            this.tab_CreateTicket.SuspendLayout();
            this.rPnl_CreateTicket.SuspendLayout();
            this.header_CreateTicket.SuspendLayout();
            this.tab_UserManagement.SuspendLayout();
            this.rPnl_UserManagement.SuspendLayout();
            this.header_UserManagement.SuspendLayout();
            this.tab_CreateUser.SuspendLayout();
            this.rPnl_CreateUser.SuspendLayout();
            this.header_CreateUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(128)))), ((int)(((byte)(97)))));
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.sideBar, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.tabControl, 1, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1598, 1024);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(128)))), ((int)(((byte)(97)))));
            this.sideBar.ColumnCount = 1;
            this.sideBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sideBar.Controls.Add(this.pic_Logo, 0, 0);
            this.sideBar.Controls.Add(this.tblPnl_UserInfo, 0, 2);
            this.sideBar.Controls.Add(this.flowPnl_Navigation, 0, 3);
            this.sideBar.Controls.Add(this.lbl_LogOut, 0, 4);
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideBar.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.sideBar.Location = new System.Drawing.Point(3, 3);
            this.sideBar.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.sideBar.Name = "sideBar";
            this.sideBar.RowCount = 5;
            this.sideBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.sideBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.sideBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.sideBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sideBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.sideBar.Size = new System.Drawing.Size(347, 1018);
            this.sideBar.TabIndex = 1;
            // 
            // pic_Logo
            // 
            this.pic_Logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_Logo.Image = global::DemoApp.Properties.Resources.Logo;
            this.pic_Logo.Location = new System.Drawing.Point(6, 3);
            this.pic_Logo.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.pic_Logo.Name = "pic_Logo";
            this.pic_Logo.Size = new System.Drawing.Size(335, 104);
            this.pic_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Logo.TabIndex = 0;
            this.pic_Logo.TabStop = false;
            // 
            // tblPnl_UserInfo
            // 
            this.tblPnl_UserInfo.ColumnCount = 1;
            this.tblPnl_UserInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPnl_UserInfo.Controls.Add(this.lbl_Welcome, 0, 0);
            this.tblPnl_UserInfo.Controls.Add(this.lbl_Username, 0, 1);
            this.tblPnl_UserInfo.Controls.Add(this.lbl_Role, 0, 2);
            this.tblPnl_UserInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPnl_UserInfo.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tblPnl_UserInfo.Location = new System.Drawing.Point(0, 130);
            this.tblPnl_UserInfo.Margin = new System.Windows.Forms.Padding(0);
            this.tblPnl_UserInfo.Name = "tblPnl_UserInfo";
            this.tblPnl_UserInfo.RowCount = 3;
            this.tblPnl_UserInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblPnl_UserInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblPnl_UserInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblPnl_UserInfo.Size = new System.Drawing.Size(347, 100);
            this.tblPnl_UserInfo.TabIndex = 1;
            // 
            // lbl_Welcome
            // 
            this.lbl_Welcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Welcome.ForeColor = System.Drawing.Color.White;
            this.lbl_Welcome.Location = new System.Drawing.Point(3, 0);
            this.lbl_Welcome.Name = "lbl_Welcome";
            this.lbl_Welcome.Size = new System.Drawing.Size(341, 33);
            this.lbl_Welcome.TabIndex = 0;
            this.lbl_Welcome.Text = "Welcome,";
            this.lbl_Welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Username
            // 
            this.lbl_Username.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_Username.ForeColor = System.Drawing.Color.White;
            this.lbl_Username.Location = new System.Drawing.Point(0, 33);
            this.lbl_Username.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(347, 33);
            this.lbl_Username.TabIndex = 1;
            this.lbl_Username.Text = "{Username}";
            this.lbl_Username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Role
            // 
            this.lbl_Role.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Role.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_Role.Location = new System.Drawing.Point(3, 66);
            this.lbl_Role.Name = "lbl_Role";
            this.lbl_Role.Size = new System.Drawing.Size(341, 34);
            this.lbl_Role.TabIndex = 2;
            this.lbl_Role.Text = "{Role}";
            this.lbl_Role.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowPnl_Navigation
            // 
            this.flowPnl_Navigation.Controls.Add(this.btn_Dashboard);
            this.flowPnl_Navigation.Controls.Add(this.btn_TicketManagement);
            this.flowPnl_Navigation.Controls.Add(this.btn_CreateTicket);
            this.flowPnl_Navigation.Controls.Add(this.btn_UserManagement);
            this.flowPnl_Navigation.Controls.Add(this.btn_CreateUser);
            this.flowPnl_Navigation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPnl_Navigation.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowPnl_Navigation.Location = new System.Drawing.Point(0, 280);
            this.flowPnl_Navigation.Margin = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.flowPnl_Navigation.Name = "flowPnl_Navigation";
            this.flowPnl_Navigation.Size = new System.Drawing.Size(347, 678);
            this.flowPnl_Navigation.TabIndex = 2;
            this.flowPnl_Navigation.WrapContents = false;
            // 
            // btn_Dashboard
            // 
            this.btn_Dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(222)))));
            this.btn_Dashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Dashboard.FlatAppearance.BorderSize = 0;
            this.btn_Dashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(222)))));
            this.btn_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btn_Dashboard.ForeColor = System.Drawing.Color.Black;
            this.btn_Dashboard.Image = global::DemoApp.Properties.Resources.icon_Home_Normal;
            this.btn_Dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Dashboard.Location = new System.Drawing.Point(10, 3);
            this.btn_Dashboard.Margin = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.btn_Dashboard.Name = "btn_Dashboard";
            this.btn_Dashboard.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_Dashboard.Size = new System.Drawing.Size(345, 60);
            this.btn_Dashboard.TabIndex = 0;
            this.btn_Dashboard.Text = "Dashboard";
            this.btn_Dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Dashboard.UseVisualStyleBackColor = false;
            this.btn_Dashboard.Click += new System.EventHandler(this.Btn_Dashboard_Click);
            // 
            // btn_TicketManagement
            // 
            this.btn_TicketManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(128)))), ((int)(((byte)(97)))));
            this.btn_TicketManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_TicketManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TicketManagement.FlatAppearance.BorderSize = 0;
            this.btn_TicketManagement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(155)))), ((int)(((byte)(116)))));
            this.btn_TicketManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TicketManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btn_TicketManagement.ForeColor = System.Drawing.Color.White;
            this.btn_TicketManagement.Image = global::DemoApp.Properties.Resources.icon_Ticket_Management_Normal;
            this.btn_TicketManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TicketManagement.Location = new System.Drawing.Point(10, 69);
            this.btn_TicketManagement.Margin = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.btn_TicketManagement.Name = "btn_TicketManagement";
            this.btn_TicketManagement.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_TicketManagement.Size = new System.Drawing.Size(345, 60);
            this.btn_TicketManagement.TabIndex = 5;
            this.btn_TicketManagement.Text = "Ticket Management";
            this.btn_TicketManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TicketManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_TicketManagement.UseVisualStyleBackColor = false;
            this.btn_TicketManagement.Click += new System.EventHandler(this.Btn_TicketManagement_Click);
            // 
            // btn_CreateTicket
            // 
            this.btn_CreateTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(128)))), ((int)(((byte)(97)))));
            this.btn_CreateTicket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_CreateTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CreateTicket.FlatAppearance.BorderSize = 0;
            this.btn_CreateTicket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(155)))), ((int)(((byte)(116)))));
            this.btn_CreateTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CreateTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btn_CreateTicket.ForeColor = System.Drawing.Color.White;
            this.btn_CreateTicket.Image = global::DemoApp.Properties.Resources.icon_Ticket_Create_Normal;
            this.btn_CreateTicket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CreateTicket.Location = new System.Drawing.Point(10, 135);
            this.btn_CreateTicket.Margin = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.btn_CreateTicket.Name = "btn_CreateTicket";
            this.btn_CreateTicket.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_CreateTicket.Size = new System.Drawing.Size(345, 60);
            this.btn_CreateTicket.TabIndex = 6;
            this.btn_CreateTicket.Text = "Create Ticket";
            this.btn_CreateTicket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CreateTicket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_CreateTicket.UseVisualStyleBackColor = false;
            this.btn_CreateTicket.Click += new System.EventHandler(this.Btn_CreateTicket_Click);
            // 
            // btn_UserManagement
            // 
            this.btn_UserManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(128)))), ((int)(((byte)(97)))));
            this.btn_UserManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_UserManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_UserManagement.FlatAppearance.BorderSize = 0;
            this.btn_UserManagement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(155)))), ((int)(((byte)(116)))));
            this.btn_UserManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UserManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btn_UserManagement.ForeColor = System.Drawing.Color.White;
            this.btn_UserManagement.Image = global::DemoApp.Properties.Resources.icon_User_Management_Normal;
            this.btn_UserManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_UserManagement.Location = new System.Drawing.Point(10, 201);
            this.btn_UserManagement.Margin = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.btn_UserManagement.Name = "btn_UserManagement";
            this.btn_UserManagement.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_UserManagement.Size = new System.Drawing.Size(345, 60);
            this.btn_UserManagement.TabIndex = 7;
            this.btn_UserManagement.Text = "User Management";
            this.btn_UserManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_UserManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_UserManagement.UseVisualStyleBackColor = false;
            this.btn_UserManagement.Click += new System.EventHandler(this.Btn_UserManagement_Click);
            // 
            // btn_CreateUser
            // 
            this.btn_CreateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(128)))), ((int)(((byte)(97)))));
            this.btn_CreateUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_CreateUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CreateUser.FlatAppearance.BorderSize = 0;
            this.btn_CreateUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(155)))), ((int)(((byte)(116)))));
            this.btn_CreateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CreateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btn_CreateUser.ForeColor = System.Drawing.Color.White;
            this.btn_CreateUser.Image = global::DemoApp.Properties.Resources.icon_User_Create_Normal;
            this.btn_CreateUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CreateUser.Location = new System.Drawing.Point(10, 267);
            this.btn_CreateUser.Margin = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.btn_CreateUser.Name = "btn_CreateUser";
            this.btn_CreateUser.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_CreateUser.Size = new System.Drawing.Size(345, 60);
            this.btn_CreateUser.TabIndex = 8;
            this.btn_CreateUser.Text = "Create User";
            this.btn_CreateUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CreateUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_CreateUser.UseVisualStyleBackColor = false;
            this.btn_CreateUser.Click += new System.EventHandler(this.Btn_CreateUser_Click);
            // 
            // lbl_LogOut
            // 
            this.lbl_LogOut.AutoSize = true;
            this.lbl_LogOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbl_LogOut.ForeColor = System.Drawing.Color.White;
            this.lbl_LogOut.Location = new System.Drawing.Point(3, 958);
            this.lbl_LogOut.Name = "lbl_LogOut";
            this.lbl_LogOut.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lbl_LogOut.Size = new System.Drawing.Size(341, 60);
            this.lbl_LogOut.TabIndex = 3;
            this.lbl_LogOut.Text = "Log out";
            this.lbl_LogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tab_Dashboard);
            this.tabControl.Controls.Add(this.tab_TicketManagement);
            this.tabControl.Controls.Add(this.tab_CreateTicket);
            this.tabControl.Controls.Add(this.tab_UserManagement);
            this.tabControl.Controls.Add(this.tab_CreateUser);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(350, 15);
            this.tabControl.Margin = new System.Windows.Forms.Padding(0, 15, 15, 15);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(0, 0);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1233, 994);
            this.tabControl.TabIndex = 2;
            this.tabControl.TabStop = false;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_IndexChanged);
            this.tabControl.TabIndexChanged += new System.EventHandler(this.TabControl_IndexChanged);
            // 
            // tab_Dashboard
            // 
            this.tab_Dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(128)))), ((int)(((byte)(97)))));
            this.tab_Dashboard.Controls.Add(this.rPnl_Dashboard);
            this.tab_Dashboard.Location = new System.Drawing.Point(4, 29);
            this.tab_Dashboard.Margin = new System.Windows.Forms.Padding(0);
            this.tab_Dashboard.Name = "tab_Dashboard";
            this.tab_Dashboard.Size = new System.Drawing.Size(1225, 961);
            this.tab_Dashboard.TabIndex = 0;
            this.tab_Dashboard.Text = "Dashboard";
            // 
            // rPnl_Dashboard
            // 
            this.rPnl_Dashboard.BackColor = System.Drawing.Color.White;
            this.rPnl_Dashboard.BorderAngle = 90F;
            this.rPnl_Dashboard.BorderRadius = 40;
            this.rPnl_Dashboard.Controls.Add(this.tblPnl_DashboardNew);
            this.rPnl_Dashboard.Controls.Add(this.header_Dashboard);
            this.rPnl_Dashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rPnl_Dashboard.ForeColor = System.Drawing.Color.Black;
            this.rPnl_Dashboard.Location = new System.Drawing.Point(0, 0);
            this.rPnl_Dashboard.Margin = new System.Windows.Forms.Padding(0);
            this.rPnl_Dashboard.Name = "rPnl_Dashboard";
            this.rPnl_Dashboard.Size = new System.Drawing.Size(1225, 961);
            this.rPnl_Dashboard.SurfaceColor = System.Drawing.Color.Empty;
            this.rPnl_Dashboard.TabIndex = 0;
            // 
            // tblPnl_DashboardNew
            // 
            this.tblPnl_DashboardNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tblPnl_DashboardNew.ColumnCount = 2;
            this.tblPnl_DashboardNew.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPnl_DashboardNew.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPnl_DashboardNew.Controls.Add(this.rPnl_D1_Open, 0, 0);
            this.tblPnl_DashboardNew.Controls.Add(this.rPnl_D2_Past, 0, 1);
            this.tblPnl_DashboardNew.Controls.Add(this.rPnl_D3_Unresolved, 1, 0);
            this.tblPnl_DashboardNew.Controls.Add(this.rPnl_D4_Resolved, 1, 1);
            this.tblPnl_DashboardNew.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tblPnl_DashboardNew.Location = new System.Drawing.Point(0, 60);
            this.tblPnl_DashboardNew.Margin = new System.Windows.Forms.Padding(0);
            this.tblPnl_DashboardNew.Name = "tblPnl_DashboardNew";
            this.tblPnl_DashboardNew.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.tblPnl_DashboardNew.RowCount = 2;
            this.tblPnl_DashboardNew.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPnl_DashboardNew.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPnl_DashboardNew.Size = new System.Drawing.Size(873, 846);
            this.tblPnl_DashboardNew.TabIndex = 2;
            // 
            // rPnl_D1_Open
            // 
            this.rPnl_D1_Open.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rPnl_D1_Open.BackColor = System.Drawing.Color.White;
            this.rPnl_D1_Open.BorderAngle = 90F;
            this.rPnl_D1_Open.BorderRadius = 40;
            this.rPnl_D1_Open.Controls.Add(this.circularProgressBar2);
            this.rPnl_D1_Open.Controls.Add(this.lbl_OpenIncidents_Desc);
            this.rPnl_D1_Open.Controls.Add(this.lbl_OpenIncidents_Title);
            this.rPnl_D1_Open.ForeColor = System.Drawing.Color.Black;
            this.rPnl_D1_Open.Location = new System.Drawing.Point(25, 11);
            this.rPnl_D1_Open.MaximumSize = new System.Drawing.Size(400, 400);
            this.rPnl_D1_Open.MinimumSize = new System.Drawing.Size(400, 400);
            this.rPnl_D1_Open.Name = "rPnl_D1_Open";
            this.rPnl_D1_Open.Size = new System.Drawing.Size(400, 400);
            this.rPnl_D1_Open.SurfaceColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.rPnl_D1_Open.TabIndex = 0;
            // 
            // lbl_OpenIncidents_Desc
            // 
            this.lbl_OpenIncidents_Desc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.lbl_OpenIncidents_Desc.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_OpenIncidents_Desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_OpenIncidents_Desc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.lbl_OpenIncidents_Desc.Location = new System.Drawing.Point(0, 70);
            this.lbl_OpenIncidents_Desc.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_OpenIncidents_Desc.MaximumSize = new System.Drawing.Size(400, 60);
            this.lbl_OpenIncidents_Desc.MinimumSize = new System.Drawing.Size(400, 60);
            this.lbl_OpenIncidents_Desc.Name = "lbl_OpenIncidents_Desc";
            this.lbl_OpenIncidents_Desc.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lbl_OpenIncidents_Desc.Size = new System.Drawing.Size(400, 60);
            this.lbl_OpenIncidents_Desc.TabIndex = 2;
            this.lbl_OpenIncidents_Desc.Text = "These tickets are currently open and require resolving.";
            this.lbl_OpenIncidents_Desc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_OpenIncidents_Title
            // 
            this.lbl_OpenIncidents_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.lbl_OpenIncidents_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_OpenIncidents_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OpenIncidents_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.lbl_OpenIncidents_Title.Location = new System.Drawing.Point(0, 0);
            this.lbl_OpenIncidents_Title.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_OpenIncidents_Title.MaximumSize = new System.Drawing.Size(400, 70);
            this.lbl_OpenIncidents_Title.MinimumSize = new System.Drawing.Size(400, 70);
            this.lbl_OpenIncidents_Title.Name = "lbl_OpenIncidents_Title";
            this.lbl_OpenIncidents_Title.Size = new System.Drawing.Size(400, 70);
            this.lbl_OpenIncidents_Title.TabIndex = 1;
            this.lbl_OpenIncidents_Title.Text = "Open incidents";
            this.lbl_OpenIncidents_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rPnl_D2_Past
            // 
            this.rPnl_D2_Past.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rPnl_D2_Past.BackColor = System.Drawing.Color.White;
            this.rPnl_D2_Past.BorderAngle = 90F;
            this.rPnl_D2_Past.BorderRadius = 40;
            this.rPnl_D2_Past.Controls.Add(this.circularProgressBar3);
            this.rPnl_D2_Past.Controls.Add(this.lbl_PastDeadline_Desc);
            this.rPnl_D2_Past.Controls.Add(this.lbl_PastDeadline_Title);
            this.rPnl_D2_Past.ForeColor = System.Drawing.Color.Black;
            this.rPnl_D2_Past.Location = new System.Drawing.Point(25, 434);
            this.rPnl_D2_Past.MaximumSize = new System.Drawing.Size(400, 400);
            this.rPnl_D2_Past.MinimumSize = new System.Drawing.Size(400, 400);
            this.rPnl_D2_Past.Name = "rPnl_D2_Past";
            this.rPnl_D2_Past.Size = new System.Drawing.Size(400, 400);
            this.rPnl_D2_Past.SurfaceColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.rPnl_D2_Past.TabIndex = 1;
            // 
            // lbl_PastDeadline_Desc
            // 
            this.lbl_PastDeadline_Desc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.lbl_PastDeadline_Desc.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_PastDeadline_Desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_PastDeadline_Desc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.lbl_PastDeadline_Desc.Location = new System.Drawing.Point(0, 70);
            this.lbl_PastDeadline_Desc.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_PastDeadline_Desc.MaximumSize = new System.Drawing.Size(400, 60);
            this.lbl_PastDeadline_Desc.MinimumSize = new System.Drawing.Size(400, 60);
            this.lbl_PastDeadline_Desc.Name = "lbl_PastDeadline_Desc";
            this.lbl_PastDeadline_Desc.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lbl_PastDeadline_Desc.Size = new System.Drawing.Size(400, 60);
            this.lbl_PastDeadline_Desc.TabIndex = 2;
            this.lbl_PastDeadline_Desc.Text = "These tickets were closed without solution.";
            this.lbl_PastDeadline_Desc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_PastDeadline_Title
            // 
            this.lbl_PastDeadline_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.lbl_PastDeadline_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_PastDeadline_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PastDeadline_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.lbl_PastDeadline_Title.Location = new System.Drawing.Point(0, 0);
            this.lbl_PastDeadline_Title.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_PastDeadline_Title.MaximumSize = new System.Drawing.Size(400, 70);
            this.lbl_PastDeadline_Title.MinimumSize = new System.Drawing.Size(400, 70);
            this.lbl_PastDeadline_Title.Name = "lbl_PastDeadline_Title";
            this.lbl_PastDeadline_Title.Size = new System.Drawing.Size(400, 70);
            this.lbl_PastDeadline_Title.TabIndex = 1;
            this.lbl_PastDeadline_Title.Text = "Incidents closed without resolve";
            this.lbl_PastDeadline_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rPnl_D3_Unresolved
            // 
            this.rPnl_D3_Unresolved.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rPnl_D3_Unresolved.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rPnl_D3_Unresolved.BorderAngle = 90F;
            this.rPnl_D3_Unresolved.BorderRadius = 40;
            this.rPnl_D3_Unresolved.Controls.Add(this.circularProgressBar1);
            this.rPnl_D3_Unresolved.Controls.Add(this.lbl_Unresolved_Desc);
            this.rPnl_D3_Unresolved.Controls.Add(this.lbl_Unresolved_Title);
            this.rPnl_D3_Unresolved.ForeColor = System.Drawing.Color.Black;
            this.rPnl_D3_Unresolved.Location = new System.Drawing.Point(457, 11);
            this.rPnl_D3_Unresolved.MaximumSize = new System.Drawing.Size(400, 400);
            this.rPnl_D3_Unresolved.MinimumSize = new System.Drawing.Size(400, 400);
            this.rPnl_D3_Unresolved.Name = "rPnl_D3_Unresolved";
            this.rPnl_D3_Unresolved.Size = new System.Drawing.Size(400, 400);
            this.rPnl_D3_Unresolved.SurfaceColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.rPnl_D3_Unresolved.TabIndex = 2;
            // 
            // lbl_Unresolved_Desc
            // 
            this.lbl_Unresolved_Desc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.lbl_Unresolved_Desc.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Unresolved_Desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Unresolved_Desc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.lbl_Unresolved_Desc.Location = new System.Drawing.Point(0, 70);
            this.lbl_Unresolved_Desc.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Unresolved_Desc.MaximumSize = new System.Drawing.Size(400, 60);
            this.lbl_Unresolved_Desc.MinimumSize = new System.Drawing.Size(400, 60);
            this.lbl_Unresolved_Desc.Name = "lbl_Unresolved_Desc";
            this.lbl_Unresolved_Desc.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lbl_Unresolved_Desc.Size = new System.Drawing.Size(400, 60);
            this.lbl_Unresolved_Desc.TabIndex = 2;
            this.lbl_Unresolved_Desc.Text = "These tickets require your immediate attention.";
            this.lbl_Unresolved_Desc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Unresolved_Title
            // 
            this.lbl_Unresolved_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.lbl_Unresolved_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Unresolved_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Unresolved_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.lbl_Unresolved_Title.Location = new System.Drawing.Point(0, 0);
            this.lbl_Unresolved_Title.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Unresolved_Title.MaximumSize = new System.Drawing.Size(400, 70);
            this.lbl_Unresolved_Title.MinimumSize = new System.Drawing.Size(400, 70);
            this.lbl_Unresolved_Title.Name = "lbl_Unresolved_Title";
            this.lbl_Unresolved_Title.Size = new System.Drawing.Size(400, 70);
            this.lbl_Unresolved_Title.TabIndex = 1;
            this.lbl_Unresolved_Title.Text = "Incidents past deadline";
            this.lbl_Unresolved_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rPnl_D4_Resolved
            // 
            this.rPnl_D4_Resolved.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rPnl_D4_Resolved.BackColor = System.Drawing.Color.White;
            this.rPnl_D4_Resolved.BorderAngle = 90F;
            this.rPnl_D4_Resolved.BorderRadius = 40;
            this.rPnl_D4_Resolved.Controls.Add(this.circularProgressBar4);
            this.rPnl_D4_Resolved.Controls.Add(this.lbl_Resolved_Desc);
            this.rPnl_D4_Resolved.Controls.Add(this.lbl_Resolved_Title);
            this.rPnl_D4_Resolved.ForeColor = System.Drawing.Color.Black;
            this.rPnl_D4_Resolved.Location = new System.Drawing.Point(457, 434);
            this.rPnl_D4_Resolved.MaximumSize = new System.Drawing.Size(400, 400);
            this.rPnl_D4_Resolved.MinimumSize = new System.Drawing.Size(400, 400);
            this.rPnl_D4_Resolved.Name = "rPnl_D4_Resolved";
            this.rPnl_D4_Resolved.Size = new System.Drawing.Size(400, 400);
            this.rPnl_D4_Resolved.SurfaceColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.rPnl_D4_Resolved.TabIndex = 3;
            // 
            // lbl_Resolved_Desc
            // 
            this.lbl_Resolved_Desc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.lbl_Resolved_Desc.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Resolved_Desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_Resolved_Desc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.lbl_Resolved_Desc.Location = new System.Drawing.Point(0, 70);
            this.lbl_Resolved_Desc.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Resolved_Desc.MaximumSize = new System.Drawing.Size(400, 60);
            this.lbl_Resolved_Desc.MinimumSize = new System.Drawing.Size(400, 60);
            this.lbl_Resolved_Desc.Name = "lbl_Resolved_Desc";
            this.lbl_Resolved_Desc.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lbl_Resolved_Desc.Size = new System.Drawing.Size(400, 60);
            this.lbl_Resolved_Desc.TabIndex = 2;
            this.lbl_Resolved_Desc.Text = "Good job! These tickets were succesfully resolved.";
            this.lbl_Resolved_Desc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Resolved_Title
            // 
            this.lbl_Resolved_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.lbl_Resolved_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Resolved_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Resolved_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.lbl_Resolved_Title.Location = new System.Drawing.Point(0, 0);
            this.lbl_Resolved_Title.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Resolved_Title.MaximumSize = new System.Drawing.Size(400, 70);
            this.lbl_Resolved_Title.MinimumSize = new System.Drawing.Size(400, 70);
            this.lbl_Resolved_Title.Name = "lbl_Resolved_Title";
            this.lbl_Resolved_Title.Size = new System.Drawing.Size(400, 70);
            this.lbl_Resolved_Title.TabIndex = 1;
            this.lbl_Resolved_Title.Text = "Resolved incidents";
            this.lbl_Resolved_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // header_Dashboard
            // 
            this.header_Dashboard.Controls.Add(this.lbl_HeaderDashboard);
            this.header_Dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_Dashboard.Location = new System.Drawing.Point(0, 0);
            this.header_Dashboard.Name = "header_Dashboard";
            this.header_Dashboard.Size = new System.Drawing.Size(1225, 60);
            this.header_Dashboard.TabIndex = 0;
            // 
            // lbl_HeaderDashboard
            // 
            this.lbl_HeaderDashboard.AutoSize = true;
            this.lbl_HeaderDashboard.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_HeaderDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_HeaderDashboard.Location = new System.Drawing.Point(0, 23);
            this.lbl_HeaderDashboard.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.lbl_HeaderDashboard.Name = "lbl_HeaderDashboard";
            this.lbl_HeaderDashboard.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lbl_HeaderDashboard.Size = new System.Drawing.Size(214, 37);
            this.lbl_HeaderDashboard.TabIndex = 0;
            this.lbl_HeaderDashboard.Text = "Dashboard";
            this.lbl_HeaderDashboard.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tab_TicketManagement
            // 
            this.tab_TicketManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(128)))), ((int)(((byte)(97)))));
            this.tab_TicketManagement.Controls.Add(this.rPnl_TicketManagement);
            this.tab_TicketManagement.Location = new System.Drawing.Point(4, 29);
            this.tab_TicketManagement.Name = "tab_TicketManagement";
            this.tab_TicketManagement.Size = new System.Drawing.Size(1225, 961);
            this.tab_TicketManagement.TabIndex = 2;
            this.tab_TicketManagement.Text = "Ticket Management";
            // 
            // rPnl_TicketManagement
            // 
            this.rPnl_TicketManagement.BackColor = System.Drawing.Color.White;
            this.rPnl_TicketManagement.BorderAngle = 90F;
            this.rPnl_TicketManagement.BorderRadius = 40;
            this.rPnl_TicketManagement.Controls.Add(this.header_TicketManagement);
            this.rPnl_TicketManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rPnl_TicketManagement.ForeColor = System.Drawing.Color.Black;
            this.rPnl_TicketManagement.Location = new System.Drawing.Point(0, 0);
            this.rPnl_TicketManagement.Margin = new System.Windows.Forms.Padding(0);
            this.rPnl_TicketManagement.Name = "rPnl_TicketManagement";
            this.rPnl_TicketManagement.Size = new System.Drawing.Size(1225, 961);
            this.rPnl_TicketManagement.SurfaceColor = System.Drawing.Color.Empty;
            this.rPnl_TicketManagement.TabIndex = 1;
            // 
            // header_TicketManagement
            // 
            this.header_TicketManagement.Controls.Add(this.lbl_HeaderTicketManagement);
            this.header_TicketManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_TicketManagement.Location = new System.Drawing.Point(0, 0);
            this.header_TicketManagement.Name = "header_TicketManagement";
            this.header_TicketManagement.Size = new System.Drawing.Size(1225, 60);
            this.header_TicketManagement.TabIndex = 1;
            // 
            // lbl_HeaderTicketManagement
            // 
            this.lbl_HeaderTicketManagement.AutoSize = true;
            this.lbl_HeaderTicketManagement.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_HeaderTicketManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_HeaderTicketManagement.Location = new System.Drawing.Point(0, 23);
            this.lbl_HeaderTicketManagement.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.lbl_HeaderTicketManagement.Name = "lbl_HeaderTicketManagement";
            this.lbl_HeaderTicketManagement.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lbl_HeaderTicketManagement.Size = new System.Drawing.Size(344, 37);
            this.lbl_HeaderTicketManagement.TabIndex = 0;
            this.lbl_HeaderTicketManagement.Text = "Ticket Management";
            this.lbl_HeaderTicketManagement.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tab_CreateTicket
            // 
            this.tab_CreateTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(128)))), ((int)(((byte)(97)))));
            this.tab_CreateTicket.Controls.Add(this.rPnl_CreateTicket);
            this.tab_CreateTicket.Location = new System.Drawing.Point(4, 29);
            this.tab_CreateTicket.Name = "tab_CreateTicket";
            this.tab_CreateTicket.Size = new System.Drawing.Size(1225, 961);
            this.tab_CreateTicket.TabIndex = 1;
            this.tab_CreateTicket.Text = "Create Ticket";
            // 
            // rPnl_CreateTicket
            // 
            this.rPnl_CreateTicket.BackColor = System.Drawing.Color.White;
            this.rPnl_CreateTicket.BorderAngle = 90F;
            this.rPnl_CreateTicket.BorderRadius = 40;
            this.rPnl_CreateTicket.Controls.Add(this.header_CreateTicket);
            this.rPnl_CreateTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rPnl_CreateTicket.ForeColor = System.Drawing.Color.Black;
            this.rPnl_CreateTicket.Location = new System.Drawing.Point(0, 0);
            this.rPnl_CreateTicket.Margin = new System.Windows.Forms.Padding(0);
            this.rPnl_CreateTicket.Name = "rPnl_CreateTicket";
            this.rPnl_CreateTicket.Size = new System.Drawing.Size(1225, 961);
            this.rPnl_CreateTicket.SurfaceColor = System.Drawing.Color.Empty;
            this.rPnl_CreateTicket.TabIndex = 2;
            // 
            // header_CreateTicket
            // 
            this.header_CreateTicket.Controls.Add(this.lbl_HeaderCreateTicket);
            this.header_CreateTicket.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_CreateTicket.Location = new System.Drawing.Point(0, 0);
            this.header_CreateTicket.Name = "header_CreateTicket";
            this.header_CreateTicket.Size = new System.Drawing.Size(1225, 60);
            this.header_CreateTicket.TabIndex = 1;
            // 
            // lbl_HeaderCreateTicket
            // 
            this.lbl_HeaderCreateTicket.AutoSize = true;
            this.lbl_HeaderCreateTicket.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_HeaderCreateTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_HeaderCreateTicket.Location = new System.Drawing.Point(0, 23);
            this.lbl_HeaderCreateTicket.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.lbl_HeaderCreateTicket.Name = "lbl_HeaderCreateTicket";
            this.lbl_HeaderCreateTicket.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lbl_HeaderCreateTicket.Size = new System.Drawing.Size(249, 37);
            this.lbl_HeaderCreateTicket.TabIndex = 0;
            this.lbl_HeaderCreateTicket.Text = "Create Ticket";
            this.lbl_HeaderCreateTicket.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tab_UserManagement
            // 
            this.tab_UserManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(128)))), ((int)(((byte)(97)))));
            this.tab_UserManagement.Controls.Add(this.rPnl_UserManagement);
            this.tab_UserManagement.Location = new System.Drawing.Point(4, 29);
            this.tab_UserManagement.Name = "tab_UserManagement";
            this.tab_UserManagement.Size = new System.Drawing.Size(1225, 961);
            this.tab_UserManagement.TabIndex = 3;
            this.tab_UserManagement.Text = "User Management";
            // 
            // rPnl_UserManagement
            // 
            this.rPnl_UserManagement.BackColor = System.Drawing.Color.White;
            this.rPnl_UserManagement.BorderAngle = 90F;
            this.rPnl_UserManagement.BorderRadius = 40;
            this.rPnl_UserManagement.Controls.Add(this.header_UserManagement);
            this.rPnl_UserManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rPnl_UserManagement.ForeColor = System.Drawing.Color.Black;
            this.rPnl_UserManagement.Location = new System.Drawing.Point(0, 0);
            this.rPnl_UserManagement.Margin = new System.Windows.Forms.Padding(0);
            this.rPnl_UserManagement.Name = "rPnl_UserManagement";
            this.rPnl_UserManagement.Size = new System.Drawing.Size(1225, 961);
            this.rPnl_UserManagement.SurfaceColor = System.Drawing.Color.Empty;
            this.rPnl_UserManagement.TabIndex = 3;
            // 
            // header_UserManagement
            // 
            this.header_UserManagement.Controls.Add(this.lbl_HeaderUserManagement);
            this.header_UserManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_UserManagement.Location = new System.Drawing.Point(0, 0);
            this.header_UserManagement.Name = "header_UserManagement";
            this.header_UserManagement.Size = new System.Drawing.Size(1225, 60);
            this.header_UserManagement.TabIndex = 1;
            // 
            // lbl_HeaderUserManagement
            // 
            this.lbl_HeaderUserManagement.AutoSize = true;
            this.lbl_HeaderUserManagement.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_HeaderUserManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_HeaderUserManagement.Location = new System.Drawing.Point(0, 23);
            this.lbl_HeaderUserManagement.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.lbl_HeaderUserManagement.Name = "lbl_HeaderUserManagement";
            this.lbl_HeaderUserManagement.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lbl_HeaderUserManagement.Size = new System.Drawing.Size(324, 37);
            this.lbl_HeaderUserManagement.TabIndex = 0;
            this.lbl_HeaderUserManagement.Text = "User Management";
            this.lbl_HeaderUserManagement.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tab_CreateUser
            // 
            this.tab_CreateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(128)))), ((int)(((byte)(97)))));
            this.tab_CreateUser.Controls.Add(this.rPnl_CreateUser);
            this.tab_CreateUser.Location = new System.Drawing.Point(4, 29);
            this.tab_CreateUser.Name = "tab_CreateUser";
            this.tab_CreateUser.Size = new System.Drawing.Size(1225, 961);
            this.tab_CreateUser.TabIndex = 4;
            this.tab_CreateUser.Text = "Create User";
            // 
            // rPnl_CreateUser
            // 
            this.rPnl_CreateUser.BackColor = System.Drawing.Color.White;
            this.rPnl_CreateUser.BorderAngle = 90F;
            this.rPnl_CreateUser.BorderRadius = 40;
            this.rPnl_CreateUser.Controls.Add(this.header_CreateUser);
            this.rPnl_CreateUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rPnl_CreateUser.ForeColor = System.Drawing.Color.Black;
            this.rPnl_CreateUser.Location = new System.Drawing.Point(0, 0);
            this.rPnl_CreateUser.Margin = new System.Windows.Forms.Padding(0);
            this.rPnl_CreateUser.Name = "rPnl_CreateUser";
            this.rPnl_CreateUser.Size = new System.Drawing.Size(1225, 961);
            this.rPnl_CreateUser.SurfaceColor = System.Drawing.Color.Empty;
            this.rPnl_CreateUser.TabIndex = 4;
            // 
            // header_CreateUser
            // 
            this.header_CreateUser.Controls.Add(this.lbl_HeaderCreateUser);
            this.header_CreateUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_CreateUser.Location = new System.Drawing.Point(0, 0);
            this.header_CreateUser.Name = "header_CreateUser";
            this.header_CreateUser.Size = new System.Drawing.Size(1225, 60);
            this.header_CreateUser.TabIndex = 1;
            // 
            // lbl_HeaderCreateUser
            // 
            this.lbl_HeaderCreateUser.AutoSize = true;
            this.lbl_HeaderCreateUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_HeaderCreateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_HeaderCreateUser.Location = new System.Drawing.Point(0, 23);
            this.lbl_HeaderCreateUser.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.lbl_HeaderCreateUser.Name = "lbl_HeaderCreateUser";
            this.lbl_HeaderCreateUser.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lbl_HeaderCreateUser.Size = new System.Drawing.Size(229, 37);
            this.lbl_HeaderCreateUser.TabIndex = 0;
            this.lbl_HeaderCreateUser.Text = "Create User";
            this.lbl_HeaderCreateUser.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // circularProgressBar2
            // 
            this.circularProgressBar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.circularProgressBar2.BorderSize = 25;
            this.circularProgressBar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar2.Location = new System.Drawing.Point(80, 150);
            this.circularProgressBar2.Margin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar2.MiddleCircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.circularProgressBar2.Name = "circularProgressBar2";
            this.circularProgressBar2.OuterCircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularProgressBar2.Size = new System.Drawing.Size(240, 240);
            this.circularProgressBar2.TabIndex = 3;
            this.circularProgressBar2.ValueMax = 100F;
            this.circularProgressBar2.ValueSize = 50F;
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.circularProgressBar1.BorderSize = 25;
            this.circularProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar1.Location = new System.Drawing.Point(85, 150);
            this.circularProgressBar1.Margin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar1.MiddleCircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterCircleColor = System.Drawing.Color.Red;
            this.circularProgressBar1.Size = new System.Drawing.Size(240, 240);
            this.circularProgressBar1.TabIndex = 4;
            this.circularProgressBar1.ValueMax = 10F;
            this.circularProgressBar1.ValueSize = 3F;
            // 
            // circularProgressBar3
            // 
            this.circularProgressBar3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.circularProgressBar3.BorderSize = 25;
            this.circularProgressBar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar3.Location = new System.Drawing.Point(80, 150);
            this.circularProgressBar3.Margin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar3.MiddleCircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.circularProgressBar3.Name = "circularProgressBar3";
            this.circularProgressBar3.OuterCircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.circularProgressBar3.Size = new System.Drawing.Size(240, 240);
            this.circularProgressBar3.TabIndex = 5;
            this.circularProgressBar3.ValueMax = 50F;
            this.circularProgressBar3.ValueSize = 34F;
            // 
            // circularProgressBar4
            // 
            this.circularProgressBar4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.circularProgressBar4.BorderSize = 25;
            this.circularProgressBar4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar4.Location = new System.Drawing.Point(80, 150);
            this.circularProgressBar4.Margin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar4.MiddleCircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.circularProgressBar4.Name = "circularProgressBar4";
            this.circularProgressBar4.OuterCircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(155)))), ((int)(((byte)(116)))));
            this.circularProgressBar4.Size = new System.Drawing.Size(240, 240);
            this.circularProgressBar4.TabIndex = 6;
            this.circularProgressBar4.ValueMax = 30F;
            this.circularProgressBar4.ValueSize = 21F;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(128)))), ((int)(((byte)(97)))));
            this.ClientSize = new System.Drawing.Size(1598, 1024);
            this.Controls.Add(this.tableLayoutPanel);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1620, 1080);
            this.Name = "Main";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Form_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.sideBar.ResumeLayout(false);
            this.sideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Logo)).EndInit();
            this.tblPnl_UserInfo.ResumeLayout(false);
            this.flowPnl_Navigation.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tab_Dashboard.ResumeLayout(false);
            this.rPnl_Dashboard.ResumeLayout(false);
            this.tblPnl_DashboardNew.ResumeLayout(false);
            this.rPnl_D1_Open.ResumeLayout(false);
            this.rPnl_D2_Past.ResumeLayout(false);
            this.rPnl_D3_Unresolved.ResumeLayout(false);
            this.rPnl_D4_Resolved.ResumeLayout(false);
            this.header_Dashboard.ResumeLayout(false);
            this.header_Dashboard.PerformLayout();
            this.tab_TicketManagement.ResumeLayout(false);
            this.rPnl_TicketManagement.ResumeLayout(false);
            this.header_TicketManagement.ResumeLayout(false);
            this.header_TicketManagement.PerformLayout();
            this.tab_CreateTicket.ResumeLayout(false);
            this.rPnl_CreateTicket.ResumeLayout(false);
            this.header_CreateTicket.ResumeLayout(false);
            this.header_CreateTicket.PerformLayout();
            this.tab_UserManagement.ResumeLayout(false);
            this.rPnl_UserManagement.ResumeLayout(false);
            this.header_UserManagement.ResumeLayout(false);
            this.header_UserManagement.PerformLayout();
            this.tab_CreateUser.ResumeLayout(false);
            this.rPnl_CreateUser.ResumeLayout(false);
            this.header_CreateUser.ResumeLayout(false);
            this.header_CreateUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel sideBar;
        private Custom_Controls.TabControlWithoutBorder tabControl;
        private System.Windows.Forms.TabPage tab_Dashboard;
        private System.Windows.Forms.TabPage tab_CreateTicket;
        private Custom_Controls.RoundedPanel rPnl_Dashboard;
        private System.Windows.Forms.PictureBox pic_Logo;
        private System.Windows.Forms.TableLayoutPanel tblPnl_UserInfo;
        private System.Windows.Forms.Label lbl_Welcome;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_Role;
        private System.Windows.Forms.FlowLayoutPanel flowPnl_Navigation;
        private System.Windows.Forms.TabPage tab_TicketManagement;
        private System.Windows.Forms.TabPage tab_UserManagement;
        private System.Windows.Forms.TabPage tab_CreateUser;
        private Custom_Controls.RoundedPanel rPnl_TicketManagement;
        private Custom_Controls.RoundedPanel rPnl_CreateTicket;
        private Custom_Controls.RoundedPanel rPnl_UserManagement;
        private Custom_Controls.RoundedPanel rPnl_CreateUser;
        private Custom_Controls.RoundedButton btn_Dashboard;
        private Custom_Controls.RoundedButton btn_TicketManagement;
        private Custom_Controls.RoundedButton btn_CreateTicket;
        private Custom_Controls.RoundedButton btn_UserManagement;
        private Custom_Controls.RoundedButton btn_CreateUser;
        private System.Windows.Forms.Label lbl_LogOut;
        private System.Windows.Forms.Panel header_Dashboard;
        private System.Windows.Forms.Label lbl_HeaderDashboard;
        private System.Windows.Forms.Panel header_TicketManagement;
        private System.Windows.Forms.Label lbl_HeaderTicketManagement;
        private System.Windows.Forms.Panel header_CreateTicket;
        private System.Windows.Forms.Label lbl_HeaderCreateTicket;
        private System.Windows.Forms.Panel header_UserManagement;
        private System.Windows.Forms.Label lbl_HeaderUserManagement;
        private System.Windows.Forms.Panel header_CreateUser;
        private System.Windows.Forms.Label lbl_HeaderCreateUser;
        private Custom_Controls.RoundedPanel rPnl_D1_Open;
        private Custom_Controls.RoundedPanel rPnl_D3_Unresolved;
        private Custom_Controls.RoundedPanel rPnl_D2_Past;
        private Custom_Controls.RoundedPanel rPnl_D4_Resolved;
        private System.Windows.Forms.Label lbl_Resolved_Title;
        private System.Windows.Forms.Label lbl_Resolved_Desc;
        private System.Windows.Forms.Label lbl_Unresolved_Title;
        private System.Windows.Forms.Label lbl_Unresolved_Desc;
        private System.Windows.Forms.Label lbl_PastDeadline_Title;
        private System.Windows.Forms.Label lbl_PastDeadline_Desc;
        private System.Windows.Forms.Label lbl_OpenIncidents_Title;
        private System.Windows.Forms.Label lbl_OpenIncidents_Desc;
        private Custom_Controls.FasterTableLayoutPanel tblPnl_DashboardNew;
        private Custom_Controls.CircularProgressBar circularProgressBar2;
        private Custom_Controls.CircularProgressBar circularProgressBar3;
        private Custom_Controls.CircularProgressBar circularProgressBar1;
        private Custom_Controls.CircularProgressBar circularProgressBar4;
    }
}

