namespace JukeBoxAssignmentv1._1
{
    partial class SetUp
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
            this.SetupCancel_btn = new System.Windows.Forms.Button();
            this.ImportTracks_GB = new System.Windows.Forms.GroupBox();
            this.ImportTracks_ListBox = new System.Windows.Forms.ListBox();
            this.ImportTracks_Btn = new System.Windows.Forms.Button();
            this.ClearTracks_Btn = new System.Windows.Forms.Button();
            this.Present_Tracks_GB = new System.Windows.Forms.GroupBox();
            this.PresentGenre_ListBox = new System.Windows.Forms.ListBox();
            this.Previous_btn = new System.Windows.Forms.Button();
            this.Next_Btn = new System.Windows.Forms.Button();
            this.Add_btn = new System.Windows.Forms.Button();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.CopyTrack_btn = new System.Windows.Forms.Button();
            this.Move_btn = new System.Windows.Forms.Button();
            this.DeleteTrackFromGenre_btn = new System.Windows.Forms.Button();
            this.Ok_btn = new System.Windows.Forms.Button();
            this.ImportTracks_GB.SuspendLayout();
            this.Present_Tracks_GB.SuspendLayout();
            this.SuspendLayout();
            // 
            // SetupCancel_btn
            // 
            this.SetupCancel_btn.Location = new System.Drawing.Point(463, 284);
            this.SetupCancel_btn.Name = "SetupCancel_btn";
            this.SetupCancel_btn.Size = new System.Drawing.Size(75, 23);
            this.SetupCancel_btn.TabIndex = 0;
            this.SetupCancel_btn.Text = "Cancel";
            this.SetupCancel_btn.UseVisualStyleBackColor = true;
            this.SetupCancel_btn.Click += new System.EventHandler(this.SetupCancel_btn_Click);
            // 
            // ImportTracks_GB
            // 
            this.ImportTracks_GB.Controls.Add(this.ClearTracks_Btn);
            this.ImportTracks_GB.Controls.Add(this.ImportTracks_Btn);
            this.ImportTracks_GB.Controls.Add(this.ImportTracks_ListBox);
            this.ImportTracks_GB.Location = new System.Drawing.Point(12, 12);
            this.ImportTracks_GB.Name = "ImportTracks_GB";
            this.ImportTracks_GB.Size = new System.Drawing.Size(196, 266);
            this.ImportTracks_GB.TabIndex = 1;
            this.ImportTracks_GB.TabStop = false;
            this.ImportTracks_GB.Text = "Import Tracks";
            // 
            // ImportTracks_ListBox
            // 
            this.ImportTracks_ListBox.FormattingEnabled = true;
            this.ImportTracks_ListBox.Location = new System.Drawing.Point(6, 19);
            this.ImportTracks_ListBox.Name = "ImportTracks_ListBox";
            this.ImportTracks_ListBox.Size = new System.Drawing.Size(184, 186);
            this.ImportTracks_ListBox.TabIndex = 0;
            // 
            // ImportTracks_Btn
            // 
            this.ImportTracks_Btn.Location = new System.Drawing.Point(6, 211);
            this.ImportTracks_Btn.Name = "ImportTracks_Btn";
            this.ImportTracks_Btn.Size = new System.Drawing.Size(184, 23);
            this.ImportTracks_Btn.TabIndex = 1;
            this.ImportTracks_Btn.Text = "Import Tracks From Directory";
            this.ImportTracks_Btn.UseVisualStyleBackColor = true;
            // 
            // ClearTracks_Btn
            // 
            this.ClearTracks_Btn.Location = new System.Drawing.Point(6, 235);
            this.ClearTracks_Btn.Name = "ClearTracks_Btn";
            this.ClearTracks_Btn.Size = new System.Drawing.Size(184, 23);
            this.ClearTracks_Btn.TabIndex = 2;
            this.ClearTracks_Btn.Text = "Clear Imported Tracks";
            this.ClearTracks_Btn.UseVisualStyleBackColor = true;
            // 
            // Present_Tracks_GB
            // 
            this.Present_Tracks_GB.Controls.Add(this.Delete_btn);
            this.Present_Tracks_GB.Controls.Add(this.Add_btn);
            this.Present_Tracks_GB.Controls.Add(this.Next_Btn);
            this.Present_Tracks_GB.Controls.Add(this.Previous_btn);
            this.Present_Tracks_GB.Controls.Add(this.PresentGenre_ListBox);
            this.Present_Tracks_GB.Location = new System.Drawing.Point(327, 12);
            this.Present_Tracks_GB.Name = "Present_Tracks_GB";
            this.Present_Tracks_GB.Size = new System.Drawing.Size(211, 266);
            this.Present_Tracks_GB.TabIndex = 2;
            this.Present_Tracks_GB.TabStop = false;
            this.Present_Tracks_GB.Text = "Present Genre";
            // 
            // PresentGenre_ListBox
            // 
            this.PresentGenre_ListBox.FormattingEnabled = true;
            this.PresentGenre_ListBox.Location = new System.Drawing.Point(6, 19);
            this.PresentGenre_ListBox.Name = "PresentGenre_ListBox";
            this.PresentGenre_ListBox.Size = new System.Drawing.Size(199, 186);
            this.PresentGenre_ListBox.TabIndex = 3;
            // 
            // Previous_btn
            // 
            this.Previous_btn.Location = new System.Drawing.Point(6, 211);
            this.Previous_btn.Name = "Previous_btn";
            this.Previous_btn.Size = new System.Drawing.Size(71, 47);
            this.Previous_btn.TabIndex = 4;
            this.Previous_btn.Text = "<< Previous";
            this.Previous_btn.UseVisualStyleBackColor = true;
            // 
            // Next_Btn
            // 
            this.Next_Btn.Location = new System.Drawing.Point(136, 210);
            this.Next_Btn.Name = "Next_Btn";
            this.Next_Btn.Size = new System.Drawing.Size(69, 49);
            this.Next_Btn.TabIndex = 3;
            this.Next_Btn.Text = "Next >>";
            this.Next_Btn.UseVisualStyleBackColor = true;
            // 
            // Add_btn
            // 
            this.Add_btn.Location = new System.Drawing.Point(83, 211);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(47, 23);
            this.Add_btn.TabIndex = 5;
            this.Add_btn.Text = "Add";
            this.Add_btn.UseVisualStyleBackColor = true;
            // 
            // Delete_btn
            // 
            this.Delete_btn.Location = new System.Drawing.Point(83, 237);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(47, 23);
            this.Delete_btn.TabIndex = 3;
            this.Delete_btn.Text = "Delete";
            this.Delete_btn.UseVisualStyleBackColor = true;
            // 
            // CopyTrack_btn
            // 
            this.CopyTrack_btn.Location = new System.Drawing.Point(223, 31);
            this.CopyTrack_btn.Name = "CopyTrack_btn";
            this.CopyTrack_btn.Size = new System.Drawing.Size(89, 23);
            this.CopyTrack_btn.TabIndex = 3;
            this.CopyTrack_btn.Text = "Copy Track >>";
            this.CopyTrack_btn.UseVisualStyleBackColor = true;
            // 
            // Move_btn
            // 
            this.Move_btn.Location = new System.Drawing.Point(223, 60);
            this.Move_btn.Name = "Move_btn";
            this.Move_btn.Size = new System.Drawing.Size(89, 23);
            this.Move_btn.TabIndex = 4;
            this.Move_btn.Text = "Move Track >>";
            this.Move_btn.UseVisualStyleBackColor = true;
            // 
            // DeleteTrackFromGenre_btn
            // 
            this.DeleteTrackFromGenre_btn.Location = new System.Drawing.Point(223, 143);
            this.DeleteTrackFromGenre_btn.Name = "DeleteTrackFromGenre_btn";
            this.DeleteTrackFromGenre_btn.Size = new System.Drawing.Size(89, 74);
            this.DeleteTrackFromGenre_btn.TabIndex = 5;
            this.DeleteTrackFromGenre_btn.Text = "Delete Track From Genre";
            this.DeleteTrackFromGenre_btn.UseVisualStyleBackColor = true;
            // 
            // Ok_btn
            // 
            this.Ok_btn.Location = new System.Drawing.Point(382, 284);
            this.Ok_btn.Name = "Ok_btn";
            this.Ok_btn.Size = new System.Drawing.Size(75, 23);
            this.Ok_btn.TabIndex = 6;
            this.Ok_btn.Text = "Ok";
            this.Ok_btn.UseVisualStyleBackColor = true;
            // 
            // SetUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 311);
            this.Controls.Add(this.Ok_btn);
            this.Controls.Add(this.DeleteTrackFromGenre_btn);
            this.Controls.Add(this.Move_btn);
            this.Controls.Add(this.CopyTrack_btn);
            this.Controls.Add(this.Present_Tracks_GB);
            this.Controls.Add(this.ImportTracks_GB);
            this.Controls.Add(this.SetupCancel_btn);
            this.Name = "SetUp";
            this.Text = "SetUp";
            this.ImportTracks_GB.ResumeLayout(false);
            this.Present_Tracks_GB.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SetupCancel_btn;
        private System.Windows.Forms.GroupBox ImportTracks_GB;
        private System.Windows.Forms.Button ClearTracks_Btn;
        private System.Windows.Forms.Button ImportTracks_Btn;
        private System.Windows.Forms.ListBox ImportTracks_ListBox;
        private System.Windows.Forms.GroupBox Present_Tracks_GB;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.Button Next_Btn;
        private System.Windows.Forms.Button Previous_btn;
        private System.Windows.Forms.ListBox PresentGenre_ListBox;
        private System.Windows.Forms.Button CopyTrack_btn;
        private System.Windows.Forms.Button Move_btn;
        private System.Windows.Forms.Button DeleteTrackFromGenre_btn;
        private System.Windows.Forms.Button Ok_btn;
    }
}