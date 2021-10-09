namespace Chess
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.viewBox = new System.Windows.Forms.PictureBox();
            this.PawContexMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KingContexMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.QueenContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.viewBox)).BeginInit();
            this.PawContexMenu.SuspendLayout();
            this.KingContexMenu.SuspendLayout();
            this.QueenContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewBox
            // 
            this.viewBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewBox.Location = new System.Drawing.Point(0, 0);
            this.viewBox.Name = "viewBox";
            this.viewBox.Size = new System.Drawing.Size(896, 658);
            this.viewBox.TabIndex = 0;
            this.viewBox.TabStop = false;
            this.viewBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.viewBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.viewBox_MouseClick);
            // 
            // PawContexMenu
            // 
            this.PawContexMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem});
            this.PawContexMenu.Name = "PawContexMenu";
            this.PawContexMenu.Size = new System.Drawing.Size(157, 26);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.testToolStripMenuItem.Text = "PawTestControl";
            // 
            // KingContexMenu
            // 
            this.KingContexMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.KingContexMenu.Name = "PawContexMenu";
            this.KingContexMenu.Size = new System.Drawing.Size(159, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.toolStripMenuItem1.Text = "KingTestControl";
            // 
            // QueenContextMenu
            // 
            this.QueenContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.QueenContextMenu.Name = "PawContexMenu";
            this.QueenContextMenu.Size = new System.Drawing.Size(181, 48);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "QueenControlTest";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 658);
            this.Controls.Add(this.viewBox);
            this.Name = "Form1";
            this.Text = "Chess";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewBox)).EndInit();
            this.PawContexMenu.ResumeLayout(false);
            this.KingContexMenu.ResumeLayout(false);
            this.QueenContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox viewBox;
        private System.Windows.Forms.ContextMenuStrip PawContexMenu;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip KingContexMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip QueenContextMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}

