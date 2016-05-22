namespace Lab06
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblWheelDiameter = new System.Windows.Forms.Label();
            this.lblTurnsPerMile = new System.Windows.Forms.Label();
            this.txtWheelDiameter = new System.Windows.Forms.TextBox();
            this.txtTurnsPerMile = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.imgWheel = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgWheel)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(611, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(134, 26);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // lblWheelDiameter
            // 
            this.lblWheelDiameter.AutoSize = true;
            this.lblWheelDiameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWheelDiameter.Location = new System.Drawing.Point(177, 233);
            this.lblWheelDiameter.Name = "lblWheelDiameter";
            this.lblWheelDiameter.Size = new System.Drawing.Size(158, 25);
            this.lblWheelDiameter.TabIndex = 1;
            this.lblWheelDiameter.Text = "Wheel Diameter:";
            // 
            // lblTurnsPerMile
            // 
            this.lblTurnsPerMile.AutoSize = true;
            this.lblTurnsPerMile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurnsPerMile.Location = new System.Drawing.Point(180, 276);
            this.lblTurnsPerMile.Name = "lblTurnsPerMile";
            this.lblTurnsPerMile.Size = new System.Drawing.Size(145, 25);
            this.lblTurnsPerMile.TabIndex = 2;
            this.lblTurnsPerMile.Text = "Turns Per Mile:";
            // 
            // txtWheelDiameter
            // 
            this.txtWheelDiameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWheelDiameter.Location = new System.Drawing.Point(341, 230);
            this.txtWheelDiameter.Name = "txtWheelDiameter";
            this.txtWheelDiameter.Size = new System.Drawing.Size(100, 30);
            this.txtWheelDiameter.TabIndex = 3;
            this.txtWheelDiameter.TextChanged += new System.EventHandler(this.txtWheelDiameter_TextChanged);
            this.txtWheelDiameter.Leave += new System.EventHandler(this.txtWheelDiameter_Leave);
            // 
            // txtTurnsPerMile
            // 
            this.txtTurnsPerMile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTurnsPerMile.Location = new System.Drawing.Point(341, 271);
            this.txtTurnsPerMile.Name = "txtTurnsPerMile";
            this.txtTurnsPerMile.Size = new System.Drawing.Size(100, 30);
            this.txtTurnsPerMile.TabIndex = 4;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(276, 318);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(114, 34);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // imgWheel
            // 
            this.imgWheel.Image = ((System.Drawing.Image)(resources.GetObject("imgWheel.Image")));
            this.imgWheel.Location = new System.Drawing.Point(182, 31);
            this.imgWheel.Name = "imgWheel";
            this.imgWheel.Size = new System.Drawing.Size(259, 167);
            this.imgWheel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgWheel.TabIndex = 6;
            this.imgWheel.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 422);
            this.Controls.Add(this.imgWheel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtTurnsPerMile);
            this.Controls.Add(this.txtWheelDiameter);
            this.Controls.Add(this.lblTurnsPerMile);
            this.Controls.Add(this.lblWheelDiameter);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Wagon Mileage Calculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgWheel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.TextBox txtWheelDiameter;
        private System.Windows.Forms.TextBox txtTurnsPerMile;
        private System.Windows.Forms.Label lblTurnsPerMile;
        private System.Windows.Forms.Label lblWheelDiameter;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox imgWheel;
    }
}

