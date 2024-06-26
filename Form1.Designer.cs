﻿namespace WindowsFormsApp3
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
            this.gbx1 = new System.Windows.Forms.GroupBox();
            this.txtDragon1Name = new System.Windows.Forms.TextBox();
            this.txtPlayer1Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave1 = new System.Windows.Forms.Button();
            this.gbx2 = new System.Windows.Forms.GroupBox();
            this.radEarth1 = new System.Windows.Forms.RadioButton();
            this.radWind1 = new System.Windows.Forms.RadioButton();
            this.radIce1 = new System.Windows.Forms.RadioButton();
            this.radFire1 = new System.Windows.Forms.RadioButton();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDragon2Name = new System.Windows.Forms.TextBox();
            this.txtPlayer2Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave2 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radEarth2 = new System.Windows.Forms.RadioButton();
            this.radWind2 = new System.Windows.Forms.RadioButton();
            this.radIce2 = new System.Windows.Forms.RadioButton();
            this.radFire2 = new System.Windows.Forms.RadioButton();
            this.gbx1.SuspendLayout();
            this.gbx2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx1
            // 
            this.gbx1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbx1.Controls.Add(this.txtDragon1Name);
            this.gbx1.Controls.Add(this.txtPlayer1Name);
            this.gbx1.Controls.Add(this.label2);
            this.gbx1.Controls.Add(this.label1);
            this.gbx1.Controls.Add(this.btnSave1);
            this.gbx1.Controls.Add(this.gbx2);
            this.gbx1.Font = new System.Drawing.Font("Goudy Stout", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbx1.Location = new System.Drawing.Point(43, 48);
            this.gbx1.Name = "gbx1";
            this.gbx1.Size = new System.Drawing.Size(254, 317);
            this.gbx1.TabIndex = 0;
            this.gbx1.TabStop = false;
            this.gbx1.Text = "Player 1";
            // 
            // txtDragon1Name
            // 
            this.txtDragon1Name.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtDragon1Name.Location = new System.Drawing.Point(99, 79);
            this.txtDragon1Name.Name = "txtDragon1Name";
            this.txtDragon1Name.Size = new System.Drawing.Size(144, 33);
            this.txtDragon1Name.TabIndex = 5;
            // 
            // txtPlayer1Name
            // 
            this.txtPlayer1Name.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPlayer1Name.Location = new System.Drawing.Point(97, 41);
            this.txtPlayer1Name.Name = "txtPlayer1Name";
            this.txtPlayer1Name.Size = new System.Drawing.Size(146, 33);
            this.txtPlayer1Name.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(1, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dragon Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(1, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Player Name:";
            // 
            // btnSave1
            // 
            this.btnSave1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSave1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave1.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSave1.Location = new System.Drawing.Point(11, 279);
            this.btnSave1.Name = "btnSave1";
            this.btnSave1.Size = new System.Drawing.Size(236, 38);
            this.btnSave1.TabIndex = 1;
            this.btnSave1.Text = "Save";
            this.btnSave1.UseVisualStyleBackColor = false;
            this.btnSave1.Click += new System.EventHandler(this.btnSave1_Click);
            // 
            // gbx2
            // 
            this.gbx2.BackColor = System.Drawing.Color.Transparent;
            this.gbx2.Controls.Add(this.radEarth1);
            this.gbx2.Controls.Add(this.radWind1);
            this.gbx2.Controls.Add(this.radIce1);
            this.gbx2.Controls.Add(this.radFire1);
            this.gbx2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbx2.Location = new System.Drawing.Point(11, 143);
            this.gbx2.Name = "gbx2";
            this.gbx2.Size = new System.Drawing.Size(232, 130);
            this.gbx2.TabIndex = 0;
            this.gbx2.TabStop = false;
            this.gbx2.Text = "Dragons ";
            this.gbx2.Enter += new System.EventHandler(this.gbx2_Enter);
            // 
            // radEarth1
            // 
            this.radEarth1.AutoSize = true;
            this.radEarth1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radEarth1.ForeColor = System.Drawing.Color.Lime;
            this.radEarth1.Location = new System.Drawing.Point(15, 88);
            this.radEarth1.Name = "radEarth1";
            this.radEarth1.Size = new System.Drawing.Size(129, 25);
            this.radEarth1.TabIndex = 3;
            this.radEarth1.TabStop = true;
            this.radEarth1.Text = "Earth Dragon";
            this.radEarth1.UseVisualStyleBackColor = true;
            this.radEarth1.CheckedChanged += new System.EventHandler(this.radEarth1_CheckedChanged);
            // 
            // radWind1
            // 
            this.radWind1.AutoSize = true;
            this.radWind1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radWind1.ForeColor = System.Drawing.Color.Aqua;
            this.radWind1.Location = new System.Drawing.Point(15, 65);
            this.radWind1.Name = "radWind1";
            this.radWind1.Size = new System.Drawing.Size(130, 25);
            this.radWind1.TabIndex = 2;
            this.radWind1.TabStop = true;
            this.radWind1.Text = "Wind Dragon";
            this.radWind1.UseVisualStyleBackColor = true;
            this.radWind1.CheckedChanged += new System.EventHandler(this.radWind1_CheckedChanged);
            // 
            // radIce1
            // 
            this.radIce1.AutoSize = true;
            this.radIce1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radIce1.ForeColor = System.Drawing.Color.Blue;
            this.radIce1.Location = new System.Drawing.Point(15, 42);
            this.radIce1.Name = "radIce1";
            this.radIce1.Size = new System.Drawing.Size(109, 25);
            this.radIce1.TabIndex = 1;
            this.radIce1.TabStop = true;
            this.radIce1.Text = "Ice dragon";
            this.radIce1.UseVisualStyleBackColor = true;
            this.radIce1.CheckedChanged += new System.EventHandler(this.radIce1_CheckedChanged);
            // 
            // radFire1
            // 
            this.radFire1.AutoSize = true;
            this.radFire1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFire1.ForeColor = System.Drawing.Color.Red;
            this.radFire1.Location = new System.Drawing.Point(15, 19);
            this.radFire1.Name = "radFire1";
            this.radFire1.Size = new System.Drawing.Size(117, 25);
            this.radFire1.TabIndex = 0;
            this.radFire1.TabStop = true;
            this.radFire1.Text = "Fire Dragon";
            this.radFire1.UseVisualStyleBackColor = true;
            this.radFire1.CheckedChanged += new System.EventHandler(this.radFire1_CheckedChanged);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnStart.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Red;
            this.btnStart.Location = new System.Drawing.Point(43, 395);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(537, 66);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox3.Controls.Add(this.txtDragon2Name);
            this.groupBox3.Controls.Add(this.txtPlayer2Name);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.btnSave2);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Font = new System.Drawing.Font("Goudy Stout", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(326, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(254, 317);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Player 2";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // txtDragon2Name
            // 
            this.txtDragon2Name.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtDragon2Name.Location = new System.Drawing.Point(99, 79);
            this.txtDragon2Name.Name = "txtDragon2Name";
            this.txtDragon2Name.Size = new System.Drawing.Size(144, 33);
            this.txtDragon2Name.TabIndex = 5;
            // 
            // txtPlayer2Name
            // 
            this.txtPlayer2Name.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPlayer2Name.Location = new System.Drawing.Point(97, 41);
            this.txtPlayer2Name.Name = "txtPlayer2Name";
            this.txtPlayer2Name.Size = new System.Drawing.Size(146, 33);
            this.txtPlayer2Name.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(1, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dragon Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(1, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Player Name:";
            // 
            // btnSave2
            // 
            this.btnSave2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSave2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave2.Location = new System.Drawing.Point(11, 279);
            this.btnSave2.Name = "btnSave2";
            this.btnSave2.Size = new System.Drawing.Size(236, 38);
            this.btnSave2.TabIndex = 1;
            this.btnSave2.Text = "Save";
            this.btnSave2.UseVisualStyleBackColor = false;
            this.btnSave2.Click += new System.EventHandler(this.btnSave2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Black;
            this.groupBox4.Controls.Add(this.radEarth2);
            this.groupBox4.Controls.Add(this.radWind2);
            this.groupBox4.Controls.Add(this.radIce2);
            this.groupBox4.Controls.Add(this.radFire2);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox4.Location = new System.Drawing.Point(11, 143);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(232, 130);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dragons ";
            // 
            // radEarth2
            // 
            this.radEarth2.AutoSize = true;
            this.radEarth2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radEarth2.ForeColor = System.Drawing.Color.Lime;
            this.radEarth2.Location = new System.Drawing.Point(15, 88);
            this.radEarth2.Name = "radEarth2";
            this.radEarth2.Size = new System.Drawing.Size(129, 25);
            this.radEarth2.TabIndex = 3;
            this.radEarth2.TabStop = true;
            this.radEarth2.Text = "Earth Dragon";
            this.radEarth2.UseVisualStyleBackColor = true;
            // 
            // radWind2
            // 
            this.radWind2.AutoSize = true;
            this.radWind2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radWind2.ForeColor = System.Drawing.Color.Aqua;
            this.radWind2.Location = new System.Drawing.Point(15, 65);
            this.radWind2.Name = "radWind2";
            this.radWind2.Size = new System.Drawing.Size(130, 25);
            this.radWind2.TabIndex = 2;
            this.radWind2.TabStop = true;
            this.radWind2.Text = "Wind Dragon";
            this.radWind2.UseVisualStyleBackColor = true;
            // 
            // radIce2
            // 
            this.radIce2.AutoSize = true;
            this.radIce2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radIce2.ForeColor = System.Drawing.Color.Blue;
            this.radIce2.Location = new System.Drawing.Point(15, 42);
            this.radIce2.Name = "radIce2";
            this.radIce2.Size = new System.Drawing.Size(109, 25);
            this.radIce2.TabIndex = 1;
            this.radIce2.TabStop = true;
            this.radIce2.Text = "Ice dragon";
            this.radIce2.UseVisualStyleBackColor = true;
            // 
            // radFire2
            // 
            this.radFire2.AutoSize = true;
            this.radFire2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFire2.ForeColor = System.Drawing.Color.Red;
            this.radFire2.Location = new System.Drawing.Point(15, 19);
            this.radFire2.Name = "radFire2";
            this.radFire2.Size = new System.Drawing.Size(117, 25);
            this.radFire2.TabIndex = 0;
            this.radFire2.TabStop = true;
            this.radFire2.Text = "Fire Dragon";
            this.radFire2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.dragon_scales_part_2;
            this.ClientSize = new System.Drawing.Size(622, 498);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.gbx1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbx1.ResumeLayout(false);
            this.gbx1.PerformLayout();
            this.gbx2.ResumeLayout(false);
            this.gbx2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx1;
        private System.Windows.Forms.Button btnSave1;
        private System.Windows.Forms.GroupBox gbx2;
        private System.Windows.Forms.RadioButton radIce1;
        private System.Windows.Forms.RadioButton radFire1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtDragon1Name;
        private System.Windows.Forms.TextBox txtPlayer1Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radEarth1;
        private System.Windows.Forms.RadioButton radWind1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDragon2Name;
        private System.Windows.Forms.TextBox txtPlayer2Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radEarth2;
        private System.Windows.Forms.RadioButton radWind2;
        private System.Windows.Forms.RadioButton radIce2;
        private System.Windows.Forms.RadioButton radFire2;
    }
}

