namespace SimepleGame_20_4_2015
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.groupBoxDifficulty = new System.Windows.Forms.GroupBox();
            this.radioButtonHard = new System.Windows.Forms.RadioButton();
            this.radioButtonMedium = new System.Windows.Forms.RadioButton();
            this.radioButtonEasy = new System.Windows.Forms.RadioButton();
            this.labelDifficulty = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxPlayer = new System.Windows.Forms.TextBox();
            this.labelImeIgraca = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBoxDifficulty.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Peru;
            this.panel1.Controls.Add(this.buttonSubmit);
            this.panel1.Controls.Add(this.groupBoxDifficulty);
            this.panel1.Controls.Add(this.labelDifficulty);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.labelImeIgraca);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(759, 312);
            this.panel1.TabIndex = 0;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.Coral;
            this.buttonSubmit.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.buttonSubmit.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.ForeColor = System.Drawing.Color.Maroon;
            this.buttonSubmit.Location = new System.Drawing.Point(235, 231);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(260, 56);
            this.buttonSubmit.TabIndex = 7;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // groupBoxDifficulty
            // 
            this.groupBoxDifficulty.Controls.Add(this.radioButtonHard);
            this.groupBoxDifficulty.Controls.Add(this.radioButtonMedium);
            this.groupBoxDifficulty.Controls.Add(this.radioButtonEasy);
            this.groupBoxDifficulty.Location = new System.Drawing.Point(229, 137);
            this.groupBoxDifficulty.Name = "groupBoxDifficulty";
            this.groupBoxDifficulty.Size = new System.Drawing.Size(434, 66);
            this.groupBoxDifficulty.TabIndex = 6;
            this.groupBoxDifficulty.TabStop = false;
            // 
            // radioButtonHard
            // 
            this.radioButtonHard.AutoSize = true;
            this.radioButtonHard.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonHard.ForeColor = System.Drawing.Color.Maroon;
            this.radioButtonHard.Location = new System.Drawing.Point(321, 19);
            this.radioButtonHard.Name = "radioButtonHard";
            this.radioButtonHard.Size = new System.Drawing.Size(88, 37);
            this.radioButtonHard.TabIndex = 2;
            this.radioButtonHard.TabStop = true;
            this.radioButtonHard.Text = "Hard";
            this.radioButtonHard.UseVisualStyleBackColor = true;
            // 
            // radioButtonMedium
            // 
            this.radioButtonMedium.AutoSize = true;
            this.radioButtonMedium.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMedium.ForeColor = System.Drawing.Color.Maroon;
            this.radioButtonMedium.Location = new System.Drawing.Point(154, 19);
            this.radioButtonMedium.Name = "radioButtonMedium";
            this.radioButtonMedium.Size = new System.Drawing.Size(112, 37);
            this.radioButtonMedium.TabIndex = 1;
            this.radioButtonMedium.TabStop = true;
            this.radioButtonMedium.Text = "Medium";
            this.radioButtonMedium.UseVisualStyleBackColor = true;
            // 
            // radioButtonEasy
            // 
            this.radioButtonEasy.AutoSize = true;
            this.radioButtonEasy.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonEasy.ForeColor = System.Drawing.Color.Maroon;
            this.radioButtonEasy.Location = new System.Drawing.Point(11, 19);
            this.radioButtonEasy.Name = "radioButtonEasy";
            this.radioButtonEasy.Size = new System.Drawing.Size(89, 37);
            this.radioButtonEasy.TabIndex = 0;
            this.radioButtonEasy.TabStop = true;
            this.radioButtonEasy.Text = "Easy";
            this.radioButtonEasy.UseVisualStyleBackColor = true;
            // 
            // labelDifficulty
            // 
            this.labelDifficulty.AutoSize = true;
            this.labelDifficulty.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDifficulty.ForeColor = System.Drawing.Color.Maroon;
            this.labelDifficulty.Location = new System.Drawing.Point(53, 152);
            this.labelDifficulty.Name = "labelDifficulty";
            this.labelDifficulty.Size = new System.Drawing.Size(151, 42);
            this.labelDifficulty.TabIndex = 5;
            this.labelDifficulty.Text = "Difficulty:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SandyBrown;
            this.panel2.Controls.Add(this.textBoxPlayer);
            this.panel2.Location = new System.Drawing.Point(223, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(440, 50);
            this.panel2.TabIndex = 4;
            // 
            // textBoxPlayer
            // 
            this.textBoxPlayer.BackColor = System.Drawing.Color.SandyBrown;
            this.textBoxPlayer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPlayer.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPlayer.ForeColor = System.Drawing.Color.Maroon;
            this.textBoxPlayer.Location = new System.Drawing.Point(17, 8);
            this.textBoxPlayer.Name = "textBoxPlayer";
            this.textBoxPlayer.Size = new System.Drawing.Size(407, 34);
            this.textBoxPlayer.TabIndex = 3;
            // 
            // labelImeIgraca
            // 
            this.labelImeIgraca.AutoSize = true;
            this.labelImeIgraca.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImeIgraca.ForeColor = System.Drawing.Color.Maroon;
            this.labelImeIgraca.Location = new System.Drawing.Point(98, 53);
            this.labelImeIgraca.Name = "labelImeIgraca";
            this.labelImeIgraca.Size = new System.Drawing.Size(106, 42);
            this.labelImeIgraca.TabIndex = 2;
            this.labelImeIgraca.Text = "Player:";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 312);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(775, 351);
            this.MinimumSize = new System.Drawing.Size(775, 351);
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Simple Game - by Dragisa Mitrovic";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxDifficulty.ResumeLayout(false);
            this.groupBoxDifficulty.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxPlayer;
        private System.Windows.Forms.Label labelImeIgraca;
        private System.Windows.Forms.Label labelDifficulty;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.GroupBox groupBoxDifficulty;
        private System.Windows.Forms.RadioButton radioButtonHard;
        private System.Windows.Forms.RadioButton radioButtonMedium;
        private System.Windows.Forms.RadioButton radioButtonEasy;
    }
}