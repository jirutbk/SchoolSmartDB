namespace SchoolSmartDB
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStatus1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripMain = new System.Windows.Forms.ToolStripSplitButton();
            this.เปดไฟลฐานขอมลToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ตงคาขอมลพนฐานToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.เปลยนรหสผานToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ปดโปรแกรมToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripReport = new System.Windows.Forms.ToolStripSplitButton();
            this.หนงสอรบรองToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripReg = new System.Windows.Forms.ToolStripSplitButton();
            this.บนทกทะเบยนนกเรยนToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.บนทกยายออกToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStatus1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 544);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(945, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStatus1
            // 
            this.toolStatus1.Name = "toolStatus1";
            this.toolStatus1.Size = new System.Drawing.Size(76, 17);
            this.toolStatus1.Text = "ฐานข้อมูล : OK";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMain,
            this.toolStripSeparator1,
            this.toolStripReg,
            this.toolStripReport});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(945, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripMain
            // 
            this.toolStripMain.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.เปดไฟลฐานขอมลToolStripMenuItem,
            this.ตงคาขอมลพนฐานToolStripMenuItem,
            this.เปลยนรหสผานToolStripMenuItem,
            this.toolStripMenuItem1,
            this.ปดโปรแกรมToolStripMenuItem});
            this.toolStripMain.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMain.Image")));
            this.toolStripMain.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(32, 22);
            this.toolStripMain.Text = "จัดการฐานข้อมูล";
            this.toolStripMain.ButtonClick += new System.EventHandler(this.toolStripMain_ButtonClick);
            // 
            // เปดไฟลฐานขอมลToolStripMenuItem
            // 
            this.เปดไฟลฐานขอมลToolStripMenuItem.Name = "เปดไฟลฐานขอมลToolStripMenuItem";
            this.เปดไฟลฐานขอมลToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.เปดไฟลฐานขอมลToolStripMenuItem.Text = "เปิดไฟล์ฐานข้อมูล";
            // 
            // ตงคาขอมลพนฐานToolStripMenuItem
            // 
            this.ตงคาขอมลพนฐานToolStripMenuItem.Name = "ตงคาขอมลพนฐานToolStripMenuItem";
            this.ตงคาขอมลพนฐานToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.ตงคาขอมลพนฐานToolStripMenuItem.Text = "ตั้งค่าข้อมูลพื้นฐาน";
            // 
            // เปลยนรหสผานToolStripMenuItem
            // 
            this.เปลยนรหสผานToolStripMenuItem.Name = "เปลยนรหสผานToolStripMenuItem";
            this.เปลยนรหสผานToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.เปลยนรหสผานToolStripMenuItem.Text = "เปลี่ยนรหัสผ่าน";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(154, 6);
            // 
            // ปดโปรแกรมToolStripMenuItem
            // 
            this.ปดโปรแกรมToolStripMenuItem.Name = "ปดโปรแกรมToolStripMenuItem";
            this.ปดโปรแกรมToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.ปดโปรแกรมToolStripMenuItem.Text = "ปิดโปรแกรม";
            // 
            // toolStripReport
            // 
            this.toolStripReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.หนงสอรบรองToolStripMenuItem});
            this.toolStripReport.Image = ((System.Drawing.Image)(resources.GetObject("toolStripReport.Image")));
            this.toolStripReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripReport.Name = "toolStripReport";
            this.toolStripReport.Size = new System.Drawing.Size(32, 22);
            this.toolStripReport.Text = "แบบฟอร์ม/รายงาน";
            // 
            // หนงสอรบรองToolStripMenuItem
            // 
            this.หนงสอรบรองToolStripMenuItem.Name = "หนงสอรบรองToolStripMenuItem";
            this.หนงสอรบรองToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.หนงสอรบรองToolStripMenuItem.Text = "หนังสือรับรอง";
            // 
            // toolStripReg
            // 
            this.toolStripReg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripReg.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.บนทกทะเบยนนกเรยนToolStripMenuItem,
            this.บนทกยายออกToolStripMenuItem});
            this.toolStripReg.Image = ((System.Drawing.Image)(resources.GetObject("toolStripReg.Image")));
            this.toolStripReg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripReg.Name = "toolStripReg";
            this.toolStripReg.Size = new System.Drawing.Size(32, 22);
            this.toolStripReg.Text = "ทะเบียนนักเรียน";
            // 
            // บนทกทะเบยนนกเรยนToolStripMenuItem
            // 
            this.บนทกทะเบยนนกเรยนToolStripMenuItem.Name = "บนทกทะเบยนนกเรยนToolStripMenuItem";
            this.บนทกทะเบยนนกเรยนToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.บนทกทะเบยนนกเรยนToolStripMenuItem.Text = "เพิ่มข้อมูลนักเรียน";
            // 
            // บนทกยายออกToolStripMenuItem
            // 
            this.บนทกยายออกToolStripMenuItem.Name = "บนทกยายออกToolStripMenuItem";
            this.บนทกยายออกToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.บนทกยายออกToolStripMenuItem.Text = "บันทึกย้ายออก";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "accdb";
            this.openFileDialog.FileName = "SSDB";
            this.openFileDialog.Filter = "SSDB file|*.accdb";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 566);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "School Smart DB - ฐานข้อมูลงานทะเบียนนักเรียน";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStatus1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripMain;
        private System.Windows.Forms.ToolStripMenuItem เปดไฟลฐานขอมลToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ตงคาขอมลพนฐานToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem เปลยนรหสผานToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ปดโปรแกรมToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton toolStripReport;
        private System.Windows.Forms.ToolStripMenuItem หนงสอรบรองToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSplitButton toolStripReg;
        private System.Windows.Forms.ToolStripMenuItem บนทกทะเบยนนกเรยนToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem บนทกยายออกToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

