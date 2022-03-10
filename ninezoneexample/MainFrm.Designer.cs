
namespace ninezoneexample
{
    partial class MainFrm
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
            this.L_Strike = new System.Windows.Forms.Label();
            this.L_Ball = new System.Windows.Forms.Label();
            this.L_Out = new System.Windows.Forms.Label();
            this.V_Strike = new System.Windows.Forms.Label();
            this.V_Ball = new System.Windows.Forms.Label();
            this.V_Out = new System.Windows.Forms.Label();
            this.G_SBO = new System.Windows.Forms.GroupBox();
            this.B_Base2 = new System.Windows.Forms.Button();
            this.B_Home = new System.Windows.Forms.Button();
            this.B_Base1 = new System.Windows.Forms.Button();
            this.B_Base3 = new System.Windows.Forms.Button();
            this.T_Home = new System.Windows.Forms.TextBox();
            this.T_Base1 = new System.Windows.Forms.TextBox();
            this.T_Base2 = new System.Windows.Forms.TextBox();
            this.T_Base3 = new System.Windows.Forms.TextBox();
            this.B_Strike = new System.Windows.Forms.Button();
            this.B_Ball = new System.Windows.Forms.Button();
            this.B_Bunt = new System.Windows.Forms.Button();
            this.B_Swing = new System.Windows.Forms.Button();
            this.B_Hit = new System.Windows.Forms.Button();
            this.B_Foul = new System.Windows.Forms.Button();
            this.B_Homerun = new System.Windows.Forms.Button();
            this.B_HitByPitch = new System.Windows.Forms.Button();
            this.T_Out = new System.Windows.Forms.TextBox();
            this.B_Steal = new System.Windows.Forms.Button();
            this.B_Pickoff = new System.Windows.Forms.Button();
            this.L_Pitcher = new System.Windows.Forms.Label();
            this.L_Batter = new System.Windows.Forms.Label();
            this.V_Batter = new System.Windows.Forms.Label();
            this.V_Pitcher = new System.Windows.Forms.Label();
            this.G_SBO.SuspendLayout();
            this.SuspendLayout();
            // 
            // L_Strike
            // 
            this.L_Strike.AutoSize = true;
            this.L_Strike.Location = new System.Drawing.Point(14, 23);
            this.L_Strike.Name = "L_Strike";
            this.L_Strike.Size = new System.Drawing.Size(36, 12);
            this.L_Strike.TabIndex = 0;
            this.L_Strike.Text = "Strike";
            // 
            // L_Ball
            // 
            this.L_Ball.AutoSize = true;
            this.L_Ball.Location = new System.Drawing.Point(14, 40);
            this.L_Ball.Name = "L_Ball";
            this.L_Ball.Size = new System.Drawing.Size(26, 12);
            this.L_Ball.TabIndex = 1;
            this.L_Ball.Text = "Ball";
            // 
            // L_Out
            // 
            this.L_Out.AutoSize = true;
            this.L_Out.Location = new System.Drawing.Point(14, 57);
            this.L_Out.Name = "L_Out";
            this.L_Out.Size = new System.Drawing.Size(24, 12);
            this.L_Out.TabIndex = 2;
            this.L_Out.Text = "Out";
            // 
            // V_Strike
            // 
            this.V_Strike.AutoSize = true;
            this.V_Strike.Location = new System.Drawing.Point(94, 23);
            this.V_Strike.Name = "V_Strike";
            this.V_Strike.Size = new System.Drawing.Size(11, 12);
            this.V_Strike.TabIndex = 5;
            this.V_Strike.Text = "0";
            // 
            // V_Ball
            // 
            this.V_Ball.AutoSize = true;
            this.V_Ball.Location = new System.Drawing.Point(94, 40);
            this.V_Ball.Name = "V_Ball";
            this.V_Ball.Size = new System.Drawing.Size(11, 12);
            this.V_Ball.TabIndex = 4;
            this.V_Ball.Text = "0";
            // 
            // V_Out
            // 
            this.V_Out.AutoSize = true;
            this.V_Out.Location = new System.Drawing.Point(94, 57);
            this.V_Out.Name = "V_Out";
            this.V_Out.Size = new System.Drawing.Size(11, 12);
            this.V_Out.TabIndex = 3;
            this.V_Out.Text = "0";
            // 
            // G_SBO
            // 
            this.G_SBO.Controls.Add(this.V_Batter);
            this.G_SBO.Controls.Add(this.V_Pitcher);
            this.G_SBO.Controls.Add(this.L_Batter);
            this.G_SBO.Controls.Add(this.L_Pitcher);
            this.G_SBO.Controls.Add(this.L_Strike);
            this.G_SBO.Controls.Add(this.V_Strike);
            this.G_SBO.Controls.Add(this.L_Ball);
            this.G_SBO.Controls.Add(this.V_Ball);
            this.G_SBO.Controls.Add(this.L_Out);
            this.G_SBO.Controls.Add(this.V_Out);
            this.G_SBO.Location = new System.Drawing.Point(37, 12);
            this.G_SBO.Name = "G_SBO";
            this.G_SBO.Size = new System.Drawing.Size(274, 78);
            this.G_SBO.TabIndex = 6;
            this.G_SBO.TabStop = false;
            this.G_SBO.Text = "StatusPanel";
            // 
            // B_Base2
            // 
            this.B_Base2.Location = new System.Drawing.Point(142, 163);
            this.B_Base2.Name = "B_Base2";
            this.B_Base2.Size = new System.Drawing.Size(100, 21);
            this.B_Base2.TabIndex = 7;
            this.B_Base2.Text = "None";
            this.B_Base2.UseVisualStyleBackColor = true;
            this.B_Base2.Click += new System.EventHandler(this.B_Base2_Click);
            // 
            // B_Home
            // 
            this.B_Home.Location = new System.Drawing.Point(142, 301);
            this.B_Home.Name = "B_Home";
            this.B_Home.Size = new System.Drawing.Size(100, 21);
            this.B_Home.TabIndex = 8;
            this.B_Home.Text = "None";
            this.B_Home.UseVisualStyleBackColor = true;
            this.B_Home.Click += new System.EventHandler(this.B_Home_Click);
            // 
            // B_Base1
            // 
            this.B_Base1.Location = new System.Drawing.Point(226, 230);
            this.B_Base1.Name = "B_Base1";
            this.B_Base1.Size = new System.Drawing.Size(100, 21);
            this.B_Base1.TabIndex = 9;
            this.B_Base1.Text = "None";
            this.B_Base1.UseVisualStyleBackColor = true;
            this.B_Base1.Click += new System.EventHandler(this.B_Base1_Click);
            // 
            // B_Base3
            // 
            this.B_Base3.Location = new System.Drawing.Point(60, 230);
            this.B_Base3.Name = "B_Base3";
            this.B_Base3.Size = new System.Drawing.Size(100, 21);
            this.B_Base3.TabIndex = 10;
            this.B_Base3.Text = "None";
            this.B_Base3.UseVisualStyleBackColor = true;
            this.B_Base3.Click += new System.EventHandler(this.B_Base3_Click);
            // 
            // T_Home
            // 
            this.T_Home.Location = new System.Drawing.Point(142, 274);
            this.T_Home.Name = "T_Home";
            this.T_Home.Size = new System.Drawing.Size(100, 21);
            this.T_Home.TabIndex = 11;
            this.T_Home.Text = "None";
            this.T_Home.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // T_Base1
            // 
            this.T_Base1.Location = new System.Drawing.Point(226, 203);
            this.T_Base1.Name = "T_Base1";
            this.T_Base1.Size = new System.Drawing.Size(100, 21);
            this.T_Base1.TabIndex = 12;
            this.T_Base1.Text = "None";
            this.T_Base1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // T_Base2
            // 
            this.T_Base2.Location = new System.Drawing.Point(142, 136);
            this.T_Base2.Name = "T_Base2";
            this.T_Base2.Size = new System.Drawing.Size(100, 21);
            this.T_Base2.TabIndex = 13;
            this.T_Base2.Text = "None";
            this.T_Base2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // T_Base3
            // 
            this.T_Base3.Location = new System.Drawing.Point(60, 203);
            this.T_Base3.Name = "T_Base3";
            this.T_Base3.Size = new System.Drawing.Size(100, 21);
            this.T_Base3.TabIndex = 14;
            this.T_Base3.Text = "None";
            this.T_Base3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // B_Strike
            // 
            this.B_Strike.Location = new System.Drawing.Point(60, 391);
            this.B_Strike.Name = "B_Strike";
            this.B_Strike.Size = new System.Drawing.Size(75, 23);
            this.B_Strike.TabIndex = 15;
            this.B_Strike.Text = "STRIKE";
            this.B_Strike.UseVisualStyleBackColor = true;
            this.B_Strike.Click += new System.EventHandler(this.B_Strike_Click);
            // 
            // B_Ball
            // 
            this.B_Ball.Location = new System.Drawing.Point(142, 391);
            this.B_Ball.Name = "B_Ball";
            this.B_Ball.Size = new System.Drawing.Size(75, 23);
            this.B_Ball.TabIndex = 16;
            this.B_Ball.Text = "BALL";
            this.B_Ball.UseVisualStyleBackColor = true;
            this.B_Ball.Click += new System.EventHandler(this.B_Ball_Click);
            // 
            // B_Bunt
            // 
            this.B_Bunt.Location = new System.Drawing.Point(226, 391);
            this.B_Bunt.Name = "B_Bunt";
            this.B_Bunt.Size = new System.Drawing.Size(75, 23);
            this.B_Bunt.TabIndex = 17;
            this.B_Bunt.Text = "BUNT";
            this.B_Bunt.UseVisualStyleBackColor = true;
            // 
            // B_Swing
            // 
            this.B_Swing.Location = new System.Drawing.Point(60, 420);
            this.B_Swing.Name = "B_Swing";
            this.B_Swing.Size = new System.Drawing.Size(75, 23);
            this.B_Swing.TabIndex = 18;
            this.B_Swing.Text = "SWING";
            this.B_Swing.UseVisualStyleBackColor = true;
            // 
            // B_Hit
            // 
            this.B_Hit.Location = new System.Drawing.Point(226, 420);
            this.B_Hit.Name = "B_Hit";
            this.B_Hit.Size = new System.Drawing.Size(75, 23);
            this.B_Hit.TabIndex = 19;
            this.B_Hit.Text = "HIT";
            this.B_Hit.UseVisualStyleBackColor = true;
            // 
            // B_Foul
            // 
            this.B_Foul.Location = new System.Drawing.Point(142, 420);
            this.B_Foul.Name = "B_Foul";
            this.B_Foul.Size = new System.Drawing.Size(75, 23);
            this.B_Foul.TabIndex = 20;
            this.B_Foul.Text = "FOUL";
            this.B_Foul.UseVisualStyleBackColor = true;
            // 
            // B_Homerun
            // 
            this.B_Homerun.Location = new System.Drawing.Point(307, 391);
            this.B_Homerun.Name = "B_Homerun";
            this.B_Homerun.Size = new System.Drawing.Size(75, 23);
            this.B_Homerun.TabIndex = 21;
            this.B_Homerun.Text = "HOMERUN";
            this.B_Homerun.UseVisualStyleBackColor = true;
            // 
            // B_HitByPitch
            // 
            this.B_HitByPitch.Font = new System.Drawing.Font("Gulim", 7F);
            this.B_HitByPitch.Location = new System.Drawing.Point(307, 420);
            this.B_HitByPitch.Name = "B_HitByPitch";
            this.B_HitByPitch.Size = new System.Drawing.Size(75, 23);
            this.B_HitByPitch.TabIndex = 22;
            this.B_HitByPitch.Text = "HITBYPITCH";
            this.B_HitByPitch.UseVisualStyleBackColor = true;
            // 
            // T_Out
            // 
            this.T_Out.Location = new System.Drawing.Point(12, 274);
            this.T_Out.Multiline = true;
            this.T_Out.Name = "T_Out";
            this.T_Out.Size = new System.Drawing.Size(100, 64);
            this.T_Out.TabIndex = 23;
            this.T_Out.Text = "OUT";
            this.T_Out.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // B_Steal
            // 
            this.B_Steal.Location = new System.Drawing.Point(287, 283);
            this.B_Steal.Name = "B_Steal";
            this.B_Steal.Size = new System.Drawing.Size(75, 23);
            this.B_Steal.TabIndex = 24;
            this.B_Steal.Text = "STEAL";
            this.B_Steal.UseVisualStyleBackColor = true;
            // 
            // B_Pickoff
            // 
            this.B_Pickoff.Location = new System.Drawing.Point(287, 315);
            this.B_Pickoff.Name = "B_Pickoff";
            this.B_Pickoff.Size = new System.Drawing.Size(75, 23);
            this.B_Pickoff.TabIndex = 25;
            this.B_Pickoff.Text = "PICKOFF";
            this.B_Pickoff.UseVisualStyleBackColor = true;
            // 
            // L_Pitcher
            // 
            this.L_Pitcher.AutoSize = true;
            this.L_Pitcher.Location = new System.Drawing.Point(142, 23);
            this.L_Pitcher.Name = "L_Pitcher";
            this.L_Pitcher.Size = new System.Drawing.Size(44, 12);
            this.L_Pitcher.TabIndex = 26;
            this.L_Pitcher.Text = "Pitcher";
            // 
            // L_Batter
            // 
            this.L_Batter.AutoSize = true;
            this.L_Batter.Location = new System.Drawing.Point(142, 40);
            this.L_Batter.Name = "L_Batter";
            this.L_Batter.Size = new System.Drawing.Size(37, 12);
            this.L_Batter.TabIndex = 27;
            this.L_Batter.Text = "Batter";
            // 
            // V_Batter
            // 
            this.V_Batter.AutoSize = true;
            this.V_Batter.Location = new System.Drawing.Point(220, 40);
            this.V_Batter.Name = "V_Batter";
            this.V_Batter.Size = new System.Drawing.Size(37, 12);
            this.V_Batter.TabIndex = 29;
            this.V_Batter.Text = "Batter";
            // 
            // V_Pitcher
            // 
            this.V_Pitcher.AutoSize = true;
            this.V_Pitcher.Location = new System.Drawing.Point(220, 23);
            this.V_Pitcher.Name = "V_Pitcher";
            this.V_Pitcher.Size = new System.Drawing.Size(44, 12);
            this.V_Pitcher.TabIndex = 28;
            this.V_Pitcher.Text = "Pitcher";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 481);
            this.Controls.Add(this.B_Pickoff);
            this.Controls.Add(this.B_Steal);
            this.Controls.Add(this.T_Out);
            this.Controls.Add(this.B_HitByPitch);
            this.Controls.Add(this.B_Homerun);
            this.Controls.Add(this.B_Foul);
            this.Controls.Add(this.B_Hit);
            this.Controls.Add(this.B_Swing);
            this.Controls.Add(this.B_Bunt);
            this.Controls.Add(this.B_Ball);
            this.Controls.Add(this.B_Strike);
            this.Controls.Add(this.T_Base3);
            this.Controls.Add(this.T_Base2);
            this.Controls.Add(this.T_Base1);
            this.Controls.Add(this.T_Home);
            this.Controls.Add(this.B_Base3);
            this.Controls.Add(this.B_Base1);
            this.Controls.Add(this.B_Home);
            this.Controls.Add(this.B_Base2);
            this.Controls.Add(this.G_SBO);
            this.Name = "Form1";
            this.Text = "NineZoneProto";
            this.G_SBO.ResumeLayout(false);
            this.G_SBO.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_Strike;
        private System.Windows.Forms.Label L_Ball;
        private System.Windows.Forms.Label L_Out;
        private System.Windows.Forms.Label V_Strike;
        private System.Windows.Forms.Label V_Ball;
        private System.Windows.Forms.Label V_Out;
        private System.Windows.Forms.GroupBox G_SBO;
        private System.Windows.Forms.Button B_Base2;
        private System.Windows.Forms.Button B_Home;
        private System.Windows.Forms.Button B_Base1;
        private System.Windows.Forms.Button B_Base3;
        private System.Windows.Forms.TextBox T_Home;
        private System.Windows.Forms.TextBox T_Base1;
        private System.Windows.Forms.TextBox T_Base2;
        private System.Windows.Forms.TextBox T_Base3;
        private System.Windows.Forms.Button B_Strike;
        private System.Windows.Forms.Button B_Ball;
        private System.Windows.Forms.Button B_Bunt;
        private System.Windows.Forms.Button B_Swing;
        private System.Windows.Forms.Button B_Hit;
        private System.Windows.Forms.Button B_Foul;
        private System.Windows.Forms.Button B_Homerun;
        private System.Windows.Forms.Button B_HitByPitch;
        private System.Windows.Forms.TextBox T_Out;
        private System.Windows.Forms.Button B_Steal;
        private System.Windows.Forms.Button B_Pickoff;
        private System.Windows.Forms.Label V_Batter;
        private System.Windows.Forms.Label V_Pitcher;
        private System.Windows.Forms.Label L_Batter;
        private System.Windows.Forms.Label L_Pitcher;
    }
}

