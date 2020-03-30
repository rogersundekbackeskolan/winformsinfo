namespace WindowsFormsAppMenyer
{
    partial class frmTriangelarea
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
            this.mnuArkiv = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTriangelArea = new System.Windows.Forms.Label();
            this.txtBasen = new System.Windows.Forms.TextBox();
            this.lblBasen = new System.Windows.Forms.Label();
            this.lblHojden = new System.Windows.Forms.Label();
            this.txtHojden = new System.Windows.Forms.TextBox();
            this.btnBerakna = new System.Windows.Forms.Button();
            this.mnuArkiv.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuArkiv
            // 
            this.mnuArkiv.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.mnuArkiv.Location = new System.Drawing.Point(0, 0);
            this.mnuArkiv.Name = "mnuArkiv";
            this.mnuArkiv.Size = new System.Drawing.Size(800, 24);
            this.mnuArkiv.TabIndex = 0;
            this.mnuArkiv.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(141, 20);
            this.toolStripMenuItem1.Text = "toolStripMenuArkivExit";
            // 
            // lblTriangelArea
            // 
            this.lblTriangelArea.AutoSize = true;
            this.lblTriangelArea.BackColor = System.Drawing.Color.Transparent;
            this.lblTriangelArea.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTriangelArea.Location = new System.Drawing.Point(269, 39);
            this.lblTriangelArea.Name = "lblTriangelArea";
            this.lblTriangelArea.Size = new System.Drawing.Size(305, 34);
            this.lblTriangelArea.TabIndex = 1;
            this.lblTriangelArea.Text = "Beräkna en triangels area";
            this.lblTriangelArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBasen
            // 
            this.txtBasen.Location = new System.Drawing.Point(290, 102);
            this.txtBasen.Name = "txtBasen";
            this.txtBasen.Size = new System.Drawing.Size(100, 20);
            this.txtBasen.TabIndex = 2;
            // 
            // lblBasen
            // 
            this.lblBasen.AutoSize = true;
            this.lblBasen.Location = new System.Drawing.Point(290, 81);
            this.lblBasen.Name = "lblBasen";
            this.lblBasen.Size = new System.Drawing.Size(67, 13);
            this.lblBasen.TabIndex = 3;
            this.lblBasen.Text = "Ange basen:";
            // 
            // lblHojden
            // 
            this.lblHojden.AutoSize = true;
            this.lblHojden.Location = new System.Drawing.Point(575, 84);
            this.lblHojden.Name = "lblHojden";
            this.lblHojden.Size = new System.Drawing.Size(70, 13);
            this.lblHojden.TabIndex = 4;
            this.lblHojden.Text = "Ange höjden:";
            // 
            // txtHojden
            // 
            this.txtHojden.Location = new System.Drawing.Point(574, 112);
            this.txtHojden.Name = "txtHojden";
            this.txtHojden.Size = new System.Drawing.Size(85, 20);
            this.txtHojden.TabIndex = 5;
            // 
            // btnBerakna
            // 
            this.btnBerakna.Location = new System.Drawing.Point(605, 251);
            this.btnBerakna.Name = "btnBerakna";
            this.btnBerakna.Size = new System.Drawing.Size(110, 23);
            this.btnBerakna.TabIndex = 6;
            this.btnBerakna.Text = "Beräkna arean";
            this.btnBerakna.UseVisualStyleBackColor = true;
            // 
            // frmTriangelarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBerakna);
            this.Controls.Add(this.txtHojden);
            this.Controls.Add(this.lblHojden);
            this.Controls.Add(this.lblBasen);
            this.Controls.Add(this.txtBasen);
            this.Controls.Add(this.lblTriangelArea);
            this.Controls.Add(this.mnuArkiv);
            this.MainMenuStrip = this.mnuArkiv;
            this.Name = "frmTriangelarea";
            this.Text = "Triangelarea";
            this.mnuArkiv.ResumeLayout(false);
            this.mnuArkiv.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuArkiv;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label lblTriangelArea;
        private System.Windows.Forms.TextBox txtBasen;
        private System.Windows.Forms.Label lblBasen;
        private System.Windows.Forms.Label lblHojden;
        private System.Windows.Forms.TextBox txtHojden;
        private System.Windows.Forms.Button btnBerakna;
    }
}

