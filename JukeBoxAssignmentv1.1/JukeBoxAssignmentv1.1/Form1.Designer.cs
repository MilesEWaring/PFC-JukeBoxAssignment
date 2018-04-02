namespace JukeBoxAssignmentv1._1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SelectGenre_HscrollBar = new System.Windows.Forms.HScrollBar();
            this.GenreList_lstBox = new System.Windows.Forms.ListBox();
            this.GenreTitle_txtBox = new System.Windows.Forms.TextBox();
            this.PresentlyPlaying_txtBox = new System.Windows.Forms.TextBox();
            this.PlayList_ListBox = new System.Windows.Forms.ListBox();
            this.HierarchicalMenu = new System.Windows.Forms.MenuStrip();
            this.Setup_MenuStrip_Btn = new System.Windows.Forms.ToolStripMenuItem();
            this.About_MenuStrip_Btn = new System.Windows.Forms.ToolStripMenuItem();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.Copyright_Lbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.HierarchicalMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SelectGenre_HscrollBar);
            this.groupBox1.Controls.Add(this.GenreList_lstBox);
            this.groupBox1.Controls.Add(this.GenreTitle_txtBox);
            this.groupBox1.Location = new System.Drawing.Point(92, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 97);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // SelectGenre_HscrollBar
            // 
            this.SelectGenre_HscrollBar.LargeChange = 1;
            this.SelectGenre_HscrollBar.Location = new System.Drawing.Point(0, 77);
            this.SelectGenre_HscrollBar.Name = "SelectGenre_HscrollBar";
            this.SelectGenre_HscrollBar.Size = new System.Drawing.Size(181, 20);
            this.SelectGenre_HscrollBar.TabIndex = 2;
            this.SelectGenre_HscrollBar.ValueChanged += new System.EventHandler(this.SelectGenre_HscrollBar_ValueChanged);
            // 
            // GenreList_lstBox
            // 
            this.GenreList_lstBox.FormattingEnabled = true;
            this.GenreList_lstBox.Location = new System.Drawing.Point(0, 19);
            this.GenreList_lstBox.Name = "GenreList_lstBox";
            this.GenreList_lstBox.Size = new System.Drawing.Size(181, 56);
            this.GenreList_lstBox.TabIndex = 1;
            this.GenreList_lstBox.DoubleClick += new System.EventHandler(this.GenreList_lstBox_DoubleClick);
            // 
            // GenreTitle_txtBox
            // 
            this.GenreTitle_txtBox.BackColor = System.Drawing.Color.Salmon;
            this.GenreTitle_txtBox.Location = new System.Drawing.Point(0, 0);
            this.GenreTitle_txtBox.Name = "GenreTitle_txtBox";
            this.GenreTitle_txtBox.Size = new System.Drawing.Size(181, 20);
            this.GenreTitle_txtBox.TabIndex = 0;
            // 
            // PresentlyPlaying_txtBox
            // 
            this.PresentlyPlaying_txtBox.BackColor = System.Drawing.Color.Lime;
            this.PresentlyPlaying_txtBox.Location = new System.Drawing.Point(92, 227);
            this.PresentlyPlaying_txtBox.Name = "PresentlyPlaying_txtBox";
            this.PresentlyPlaying_txtBox.Size = new System.Drawing.Size(181, 20);
            this.PresentlyPlaying_txtBox.TabIndex = 3;
            // 
            // PlayList_ListBox
            // 
            this.PlayList_ListBox.BackColor = System.Drawing.Color.Khaki;
            this.PlayList_ListBox.FormattingEnabled = true;
            this.PlayList_ListBox.Location = new System.Drawing.Point(122, 253);
            this.PlayList_ListBox.Name = "PlayList_ListBox";
            this.PlayList_ListBox.Size = new System.Drawing.Size(120, 95);
            this.PlayList_ListBox.TabIndex = 4;
            // 
            // HierarchicalMenu
            // 
            this.HierarchicalMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.HierarchicalMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Setup_MenuStrip_Btn,
            this.About_MenuStrip_Btn});
            this.HierarchicalMenu.Location = new System.Drawing.Point(0, 475);
            this.HierarchicalMenu.Name = "HierarchicalMenu";
            this.HierarchicalMenu.Size = new System.Drawing.Size(365, 24);
            this.HierarchicalMenu.TabIndex = 5;
            // 
            // Setup_MenuStrip_Btn
            // 
            this.Setup_MenuStrip_Btn.Name = "Setup_MenuStrip_Btn";
            this.Setup_MenuStrip_Btn.Size = new System.Drawing.Size(53, 20);
            this.Setup_MenuStrip_Btn.Text = "Set Up";
            this.Setup_MenuStrip_Btn.Click += new System.EventHandler(this.setUPToolStripMenuItem_Click);
            // 
            // About_MenuStrip_Btn
            // 
            this.About_MenuStrip_Btn.Name = "About_MenuStrip_Btn";
            this.About_MenuStrip_Btn.Size = new System.Drawing.Size(52, 20);
            this.About_MenuStrip_Btn.Text = "About";
            this.About_MenuStrip_Btn.Click += new System.EventHandler(this.About_MenuStrip_Btn_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, -1);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(211, 23);
            this.axWindowsMediaPlayer1.TabIndex = 6;
            this.axWindowsMediaPlayer1.Visible = false;
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // Copyright_Lbl
            // 
            this.Copyright_Lbl.AutoSize = true;
            this.Copyright_Lbl.BackColor = System.Drawing.Color.DarkGray;
            this.Copyright_Lbl.Location = new System.Drawing.Point(197, 9);
            this.Copyright_Lbl.Name = "Copyright_Lbl";
            this.Copyright_Lbl.Size = new System.Drawing.Size(168, 13);
            this.Copyright_Lbl.TabIndex = 7;
            this.Copyright_Lbl.Text = "Copyright © Miles Ejgierd - Waring";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(365, 499);
            this.Controls.Add(this.Copyright_Lbl);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.PlayList_ListBox);
            this.Controls.Add(this.PresentlyPlaying_txtBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.HierarchicalMenu);
            this.MainMenuStrip = this.HierarchicalMenu;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.HierarchicalMenu.ResumeLayout(false);
            this.HierarchicalMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.HScrollBar SelectGenre_HscrollBar;
        private System.Windows.Forms.ListBox GenreList_lstBox;
        private System.Windows.Forms.TextBox GenreTitle_txtBox;
        private System.Windows.Forms.TextBox PresentlyPlaying_txtBox;
        private System.Windows.Forms.ListBox PlayList_ListBox;
        private System.Windows.Forms.MenuStrip HierarchicalMenu;
        private System.Windows.Forms.ToolStripMenuItem Setup_MenuStrip_Btn;
        private System.Windows.Forms.ToolStripMenuItem About_MenuStrip_Btn;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label Copyright_Lbl;
        private System.Windows.Forms.Timer timer1;
    }
}

