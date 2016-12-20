namespace QuanLyDoanHoi
{
    partial class FormChinh
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.danhSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchChươngTrìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmDSSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmDSChươngTrìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Checkin = new System.Windows.Forms.Button();
            this.btn_drl = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(548, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // danhSáchToolStripMenuItem
            // 
            this.danhSáchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchSinhViênToolStripMenuItem,
            this.danhSáchChươngTrìnhToolStripMenuItem});
            this.danhSáchToolStripMenuItem.Name = "danhSáchToolStripMenuItem";
            this.danhSáchToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.danhSáchToolStripMenuItem.Text = "Danh Sách";
            // 
            // danhSáchSinhViênToolStripMenuItem
            // 
            this.danhSáchSinhViênToolStripMenuItem.Name = "danhSáchSinhViênToolStripMenuItem";
            this.danhSáchSinhViênToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.danhSáchSinhViênToolStripMenuItem.Text = "Danh Sách Sinh Viên";
            // 
            // danhSáchChươngTrìnhToolStripMenuItem
            // 
            this.danhSáchChươngTrìnhToolStripMenuItem.Name = "danhSáchChươngTrìnhToolStripMenuItem";
            this.danhSáchChươngTrìnhToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.danhSáchChươngTrìnhToolStripMenuItem.Text = "Danh Sách Chương Trình";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmDSSinhViênToolStripMenuItem,
            this.thêmDSChươngTrìnhToolStripMenuItem});
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.updateToolStripMenuItem.Text = "Update";
            // 
            // thêmDSSinhViênToolStripMenuItem
            // 
            this.thêmDSSinhViênToolStripMenuItem.Name = "thêmDSSinhViênToolStripMenuItem";
            this.thêmDSSinhViênToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.thêmDSSinhViênToolStripMenuItem.Text = "Thêm DS Sinh Viên";
            // 
            // thêmDSChươngTrìnhToolStripMenuItem
            // 
            this.thêmDSChươngTrìnhToolStripMenuItem.Name = "thêmDSChươngTrìnhToolStripMenuItem";
            this.thêmDSChươngTrìnhToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.thêmDSChươngTrìnhToolStripMenuItem.Text = "Thêm DS Chương Trình";
            // 
            // btn_Checkin
            // 
            this.btn_Checkin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Checkin.Location = new System.Drawing.Point(102, 173);
            this.btn_Checkin.Name = "btn_Checkin";
            this.btn_Checkin.Size = new System.Drawing.Size(144, 59);
            this.btn_Checkin.TabIndex = 1;
            this.btn_Checkin.Text = "Check-In";
            this.btn_Checkin.UseVisualStyleBackColor = true;
            // 
            // btn_drl
            // 
            this.btn_drl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_drl.Location = new System.Drawing.Point(303, 173);
            this.btn_drl.Name = "btn_drl";
            this.btn_drl.Size = new System.Drawing.Size(144, 59);
            this.btn_drl.TabIndex = 2;
            this.btn_drl.Text = "Điểm Rèn Luyện Sinh Viên";
            this.btn_drl.UseVisualStyleBackColor = true;
            // 
            // FormChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 405);
            this.Controls.Add(this.btn_drl);
            this.Controls.Add(this.btn_Checkin);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormChinh";
            this.Text = "FormChinh";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchChươngTrìnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmDSSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmDSChươngTrìnhToolStripMenuItem;
        private System.Windows.Forms.Button btn_Checkin;
        private System.Windows.Forms.Button btn_drl;
    }
}