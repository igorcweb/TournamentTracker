﻿namespace TrackerUI
{
  partial class TournamentViewerForm
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
      this.headerLabel = new System.Windows.Forms.Label();
      this.tournamentName = new System.Windows.Forms.Label();
      this.roundLabel = new System.Windows.Forms.Label();
      this.roundDropDown = new System.Windows.Forms.ComboBox();
      this.unplayedOnlyCheckbox = new System.Windows.Forms.CheckBox();
      this.matchupListBox = new System.Windows.Forms.ListBox();
      this.teamOneName = new System.Windows.Forms.Label();
      this.teamOneScoreLabel = new System.Windows.Forms.Label();
      this.teamOneScoreValue = new System.Windows.Forms.TextBox();
      this.teamTwoScoreValue = new System.Windows.Forms.TextBox();
      this.teamTwoScoreLabel = new System.Windows.Forms.Label();
      this.teamTwoName = new System.Windows.Forms.Label();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.colorDialog1 = new System.Windows.Forms.ColorDialog();
      this.versesLabel = new System.Windows.Forms.Label();
      this.scoreButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // headerLabel
      // 
      this.headerLabel.AutoSize = true;
      this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.headerLabel.Location = new System.Drawing.Point(22, 18);
      this.headerLabel.Name = "headerLabel";
      this.headerLabel.Size = new System.Drawing.Size(214, 50);
      this.headerLabel.TabIndex = 0;
      this.headerLabel.Text = "Tournament:";
      this.headerLabel.Click += new System.EventHandler(this.label1_Click);
      // 
      // tournamentName
      // 
      this.tournamentName.AutoSize = true;
      this.tournamentName.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tournamentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.tournamentName.Location = new System.Drawing.Point(230, 18);
      this.tournamentName.Name = "tournamentName";
      this.tournamentName.Size = new System.Drawing.Size(150, 50);
      this.tournamentName.TabIndex = 1;
      this.tournamentName.Text = "<none>";
      this.tournamentName.Click += new System.EventHandler(this.label1_Click_1);
      // 
      // roundLabel
      // 
      this.roundLabel.AutoSize = true;
      this.roundLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.roundLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.roundLabel.Location = new System.Drawing.Point(34, 91);
      this.roundLabel.Name = "roundLabel";
      this.roundLabel.Size = new System.Drawing.Size(94, 37);
      this.roundLabel.TabIndex = 2;
      this.roundLabel.Text = "Round";
      // 
      // roundDropDown
      // 
      this.roundDropDown.FormattingEnabled = true;
      this.roundDropDown.Location = new System.Drawing.Point(134, 90);
      this.roundDropDown.Name = "roundDropDown";
      this.roundDropDown.Size = new System.Drawing.Size(246, 38);
      this.roundDropDown.TabIndex = 3;
      // 
      // unplayedOnlyCheckbox
      // 
      this.unplayedOnlyCheckbox.AutoSize = true;
      this.unplayedOnlyCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.unplayedOnlyCheckbox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.unplayedOnlyCheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.unplayedOnlyCheckbox.Location = new System.Drawing.Point(134, 145);
      this.unplayedOnlyCheckbox.Name = "unplayedOnlyCheckbox";
      this.unplayedOnlyCheckbox.Size = new System.Drawing.Size(209, 41);
      this.unplayedOnlyCheckbox.TabIndex = 4;
      this.unplayedOnlyCheckbox.Text = "Unplayed Only";
      this.unplayedOnlyCheckbox.UseVisualStyleBackColor = true;
      // 
      // matchupListBox
      // 
      this.matchupListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.matchupListBox.FormattingEnabled = true;
      this.matchupListBox.ItemHeight = 30;
      this.matchupListBox.Location = new System.Drawing.Point(41, 218);
      this.matchupListBox.Name = "matchupListBox";
      this.matchupListBox.Size = new System.Drawing.Size(339, 212);
      this.matchupListBox.TabIndex = 5;
      // 
      // teamOneName
      // 
      this.teamOneName.AutoSize = true;
      this.teamOneName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.teamOneName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.teamOneName.Location = new System.Drawing.Point(430, 212);
      this.teamOneName.Name = "teamOneName";
      this.teamOneName.Size = new System.Drawing.Size(165, 37);
      this.teamOneName.TabIndex = 6;
      this.teamOneName.Text = "<team one>";
      // 
      // teamOneScoreLabel
      // 
      this.teamOneScoreLabel.AutoSize = true;
      this.teamOneScoreLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.teamOneScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.teamOneScoreLabel.Location = new System.Drawing.Point(430, 259);
      this.teamOneScoreLabel.Name = "teamOneScoreLabel";
      this.teamOneScoreLabel.Size = new System.Drawing.Size(82, 37);
      this.teamOneScoreLabel.TabIndex = 7;
      this.teamOneScoreLabel.Text = "Score";
      // 
      // teamOneScoreValue
      // 
      this.teamOneScoreValue.Location = new System.Drawing.Point(529, 261);
      this.teamOneScoreValue.Name = "teamOneScoreValue";
      this.teamOneScoreValue.Size = new System.Drawing.Size(100, 35);
      this.teamOneScoreValue.TabIndex = 8;
      this.teamOneScoreValue.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
      // 
      // teamTwoScoreValue
      // 
      this.teamTwoScoreValue.Location = new System.Drawing.Point(529, 400);
      this.teamTwoScoreValue.Name = "teamTwoScoreValue";
      this.teamTwoScoreValue.Size = new System.Drawing.Size(100, 35);
      this.teamTwoScoreValue.TabIndex = 11;
      // 
      // teamTwoScoreLabel
      // 
      this.teamTwoScoreLabel.AutoSize = true;
      this.teamTwoScoreLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.teamTwoScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.teamTwoScoreLabel.Location = new System.Drawing.Point(430, 398);
      this.teamTwoScoreLabel.Name = "teamTwoScoreLabel";
      this.teamTwoScoreLabel.Size = new System.Drawing.Size(82, 37);
      this.teamTwoScoreLabel.TabIndex = 10;
      this.teamTwoScoreLabel.Text = "Score";
      // 
      // teamTwoName
      // 
      this.teamTwoName.AutoSize = true;
      this.teamTwoName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.teamTwoName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.teamTwoName.Location = new System.Drawing.Point(430, 351);
      this.teamTwoName.Name = "teamTwoName";
      this.teamTwoName.Size = new System.Drawing.Size(165, 37);
      this.teamTwoName.TabIndex = 9;
      this.teamTwoName.Text = "<team two>";
      // 
      // versesLabel
      // 
      this.versesLabel.AutoSize = true;
      this.versesLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.versesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.versesLabel.Location = new System.Drawing.Point(533, 309);
      this.versesLabel.Name = "versesLabel";
      this.versesLabel.Size = new System.Drawing.Size(63, 37);
      this.versesLabel.TabIndex = 12;
      this.versesLabel.Text = "-vs-";
      this.versesLabel.Click += new System.EventHandler(this.label1_Click_2);
      // 
      // scoreButton
      // 
      this.scoreButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.scoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
      this.scoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
      this.scoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.scoreButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.scoreButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.scoreButton.Location = new System.Drawing.Point(629, 309);
      this.scoreButton.Name = "scoreButton";
      this.scoreButton.Size = new System.Drawing.Size(94, 49);
      this.scoreButton.TabIndex = 13;
      this.scoreButton.Text = "Score";
      this.scoreButton.UseVisualStyleBackColor = true;
      // 
      // TournamentViewerForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(744, 520);
      this.Controls.Add(this.scoreButton);
      this.Controls.Add(this.versesLabel);
      this.Controls.Add(this.teamTwoScoreValue);
      this.Controls.Add(this.teamTwoScoreLabel);
      this.Controls.Add(this.teamTwoName);
      this.Controls.Add(this.teamOneScoreValue);
      this.Controls.Add(this.teamOneScoreLabel);
      this.Controls.Add(this.teamOneName);
      this.Controls.Add(this.matchupListBox);
      this.Controls.Add(this.unplayedOnlyCheckbox);
      this.Controls.Add(this.roundDropDown);
      this.Controls.Add(this.roundLabel);
      this.Controls.Add(this.tournamentName);
      this.Controls.Add(this.headerLabel);
      this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
      this.Name = "TournamentViewerForm";
      this.Text = "TournamentViewer";
      this.Load += new System.EventHandler(this.TournamentViewerForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label headerLabel;
    private System.Windows.Forms.Label tournamentName;
    private System.Windows.Forms.Label roundLabel;
    private System.Windows.Forms.ComboBox roundDropDown;
    private System.Windows.Forms.CheckBox unplayedOnlyCheckbox;
    private System.Windows.Forms.ListBox matchupListBox;
    private System.Windows.Forms.Label teamOneName;
    private System.Windows.Forms.Label teamOneScoreLabel;
    private System.Windows.Forms.TextBox teamOneScoreValue;
    private System.Windows.Forms.TextBox teamTwoScoreValue;
    private System.Windows.Forms.Label teamTwoScoreLabel;
    private System.Windows.Forms.Label teamTwoName;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.ColorDialog colorDialog1;
    private System.Windows.Forms.Label versesLabel;
    private System.Windows.Forms.Button scoreButton;
  }
}

