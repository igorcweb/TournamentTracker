namespace TrackerUI
{
  partial class CreateTeamForm
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
      this.teamNameValue = new System.Windows.Forms.TextBox();
      this.teamNameLabel = new System.Windows.Forms.Label();
      this.headerLabel = new System.Windows.Forms.Label();
      this.selectTeamMemberLabel = new System.Windows.Forms.Label();
      this.addMemberButton = new System.Windows.Forms.Button();
      this.selectTeamMemberDropDown = new System.Windows.Forms.ComboBox();
      this.addNewMemberGroupBox = new System.Windows.Forms.GroupBox();
      this.firstNameValue = new System.Windows.Forms.TextBox();
      this.firstNameLabel = new System.Windows.Forms.Label();
      this.lastNameValue = new System.Windows.Forms.TextBox();
      this.lastNameLabel = new System.Windows.Forms.Label();
      this.emailValue = new System.Windows.Forms.TextBox();
      this.emailLabel = new System.Windows.Forms.Label();
      this.cellphoneValue = new System.Windows.Forms.TextBox();
      this.cellphoneLabel = new System.Windows.Forms.Label();
      this.createMemberButton = new System.Windows.Forms.Button();
      this.teamMembersListBox = new System.Windows.Forms.ListBox();
      this.delecteSelectedMemberButton = new System.Windows.Forms.Button();
      this.createTeamButton = new System.Windows.Forms.Button();
      this.addNewMemberGroupBox.SuspendLayout();
      this.SuspendLayout();
      // 
      // teamNameValue
      // 
      this.teamNameValue.Location = new System.Drawing.Point(34, 145);
      this.teamNameValue.Name = "teamNameValue";
      this.teamNameValue.Size = new System.Drawing.Size(308, 35);
      this.teamNameValue.TabIndex = 13;
      // 
      // teamNameLabel
      // 
      this.teamNameLabel.AutoSize = true;
      this.teamNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.teamNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.teamNameLabel.Location = new System.Drawing.Point(27, 99);
      this.teamNameLabel.Name = "teamNameLabel";
      this.teamNameLabel.Size = new System.Drawing.Size(157, 37);
      this.teamNameLabel.TabIndex = 12;
      this.teamNameLabel.Text = "Team Name";
      // 
      // headerLabel
      // 
      this.headerLabel.AutoSize = true;
      this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.headerLabel.Location = new System.Drawing.Point(26, 30);
      this.headerLabel.Name = "headerLabel";
      this.headerLabel.Size = new System.Drawing.Size(213, 50);
      this.headerLabel.TabIndex = 11;
      this.headerLabel.Text = "Create Team";
      // 
      // selectTeamMemberLabel
      // 
      this.selectTeamMemberLabel.AutoSize = true;
      this.selectTeamMemberLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.selectTeamMemberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.selectTeamMemberLabel.Location = new System.Drawing.Point(28, 209);
      this.selectTeamMemberLabel.Name = "selectTeamMemberLabel";
      this.selectTeamMemberLabel.Size = new System.Drawing.Size(263, 37);
      this.selectTeamMemberLabel.TabIndex = 14;
      this.selectTeamMemberLabel.Text = "Select Team Member";
      // 
      // addMemberButton
      // 
      this.addMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.addMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
      this.addMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
      this.addMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.addMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.addMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.addMemberButton.Location = new System.Drawing.Point(85, 317);
      this.addMemberButton.Name = "addMemberButton";
      this.addMemberButton.Size = new System.Drawing.Size(207, 49);
      this.addMemberButton.TabIndex = 18;
      this.addMemberButton.Text = "Add Member";
      this.addMemberButton.UseVisualStyleBackColor = true;
      // 
      // selectTeamMemberDropDown
      // 
      this.selectTeamMemberDropDown.FormattingEnabled = true;
      this.selectTeamMemberDropDown.Location = new System.Drawing.Point(34, 257);
      this.selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
      this.selectTeamMemberDropDown.Size = new System.Drawing.Size(308, 38);
      this.selectTeamMemberDropDown.TabIndex = 17;
      // 
      // addNewMemberGroupBox
      // 
      this.addNewMemberGroupBox.Controls.Add(this.createMemberButton);
      this.addNewMemberGroupBox.Controls.Add(this.cellphoneValue);
      this.addNewMemberGroupBox.Controls.Add(this.cellphoneLabel);
      this.addNewMemberGroupBox.Controls.Add(this.emailValue);
      this.addNewMemberGroupBox.Controls.Add(this.emailLabel);
      this.addNewMemberGroupBox.Controls.Add(this.lastNameValue);
      this.addNewMemberGroupBox.Controls.Add(this.lastNameLabel);
      this.addNewMemberGroupBox.Controls.Add(this.firstNameValue);
      this.addNewMemberGroupBox.Controls.Add(this.firstNameLabel);
      this.addNewMemberGroupBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.addNewMemberGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.addNewMemberGroupBox.Location = new System.Drawing.Point(36, 382);
      this.addNewMemberGroupBox.Name = "addNewMemberGroupBox";
      this.addNewMemberGroupBox.Size = new System.Drawing.Size(408, 335);
      this.addNewMemberGroupBox.TabIndex = 19;
      this.addNewMemberGroupBox.TabStop = false;
      this.addNewMemberGroupBox.Text = "Add New Member";
      this.addNewMemberGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
      // 
      // firstNameValue
      // 
      this.firstNameValue.Location = new System.Drawing.Point(156, 40);
      this.firstNameValue.Name = "firstNameValue";
      this.firstNameValue.Size = new System.Drawing.Size(171, 43);
      this.firstNameValue.TabIndex = 10;
      this.firstNameValue.TextChanged += new System.EventHandler(this.firstNameValue_TextChanged);
      // 
      // firstNameLabel
      // 
      this.firstNameLabel.AutoSize = true;
      this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.firstNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.firstNameLabel.Location = new System.Drawing.Point(6, 40);
      this.firstNameLabel.Name = "firstNameLabel";
      this.firstNameLabel.Size = new System.Drawing.Size(144, 37);
      this.firstNameLabel.TabIndex = 9;
      this.firstNameLabel.Text = "First Name";
      // 
      // lastNameValue
      // 
      this.lastNameValue.Location = new System.Drawing.Point(156, 95);
      this.lastNameValue.Name = "lastNameValue";
      this.lastNameValue.Size = new System.Drawing.Size(171, 43);
      this.lastNameValue.TabIndex = 12;
      // 
      // lastNameLabel
      // 
      this.lastNameLabel.AutoSize = true;
      this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lastNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.lastNameLabel.Location = new System.Drawing.Point(6, 95);
      this.lastNameLabel.Name = "lastNameLabel";
      this.lastNameLabel.Size = new System.Drawing.Size(142, 37);
      this.lastNameLabel.TabIndex = 11;
      this.lastNameLabel.Text = "Last Name";
      // 
      // emailValue
      // 
      this.emailValue.Location = new System.Drawing.Point(156, 145);
      this.emailValue.Name = "emailValue";
      this.emailValue.Size = new System.Drawing.Size(171, 43);
      this.emailValue.TabIndex = 14;
      // 
      // emailLabel
      // 
      this.emailLabel.AutoSize = true;
      this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.emailLabel.Location = new System.Drawing.Point(6, 145);
      this.emailLabel.Name = "emailLabel";
      this.emailLabel.Size = new System.Drawing.Size(82, 37);
      this.emailLabel.TabIndex = 13;
      this.emailLabel.Text = "Email";
      // 
      // cellphoneValue
      // 
      this.cellphoneValue.Location = new System.Drawing.Point(155, 196);
      this.cellphoneValue.Name = "cellphoneValue";
      this.cellphoneValue.Size = new System.Drawing.Size(171, 43);
      this.cellphoneValue.TabIndex = 16;
      // 
      // cellphoneLabel
      // 
      this.cellphoneLabel.AutoSize = true;
      this.cellphoneLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cellphoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.cellphoneLabel.Location = new System.Drawing.Point(5, 196);
      this.cellphoneLabel.Name = "cellphoneLabel";
      this.cellphoneLabel.Size = new System.Drawing.Size(144, 37);
      this.cellphoneLabel.TabIndex = 15;
      this.cellphoneLabel.Text = "Cell Phone";
      // 
      // createMemberButton
      // 
      this.createMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.createMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
      this.createMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
      this.createMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.createMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.createMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.createMemberButton.Location = new System.Drawing.Point(101, 260);
      this.createMemberButton.Name = "createMemberButton";
      this.createMemberButton.Size = new System.Drawing.Size(207, 49);
      this.createMemberButton.TabIndex = 19;
      this.createMemberButton.Text = "Create Member";
      this.createMemberButton.UseVisualStyleBackColor = true;
      // 
      // teamMembersListBox
      // 
      this.teamMembersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.teamMembersListBox.FormattingEnabled = true;
      this.teamMembersListBox.ItemHeight = 30;
      this.teamMembersListBox.Location = new System.Drawing.Point(479, 145);
      this.teamMembersListBox.Name = "teamMembersListBox";
      this.teamMembersListBox.Size = new System.Drawing.Size(349, 572);
      this.teamMembersListBox.TabIndex = 20;
      // 
      // delecteSelectedMemberButton
      // 
      this.delecteSelectedMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.delecteSelectedMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
      this.delecteSelectedMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
      this.delecteSelectedMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.delecteSelectedMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.delecteSelectedMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.delecteSelectedMemberButton.Location = new System.Drawing.Point(862, 382);
      this.delecteSelectedMemberButton.Name = "delecteSelectedMemberButton";
      this.delecteSelectedMemberButton.Size = new System.Drawing.Size(121, 70);
      this.delecteSelectedMemberButton.TabIndex = 21;
      this.delecteSelectedMemberButton.Text = "Delete Selected";
      this.delecteSelectedMemberButton.UseVisualStyleBackColor = true;
      // 
      // createTeamButton
      // 
      this.createTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
      this.createTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
      this.createTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
      this.createTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.createTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.createTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.createTeamButton.Location = new System.Drawing.Point(323, 739);
      this.createTeamButton.Name = "createTeamButton";
      this.createTeamButton.Size = new System.Drawing.Size(286, 69);
      this.createTeamButton.TabIndex = 25;
      this.createTeamButton.Text = "Create Team";
      this.createTeamButton.UseVisualStyleBackColor = true;
      // 
      // CreateTeamForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(1019, 856);
      this.Controls.Add(this.createTeamButton);
      this.Controls.Add(this.delecteSelectedMemberButton);
      this.Controls.Add(this.teamMembersListBox);
      this.Controls.Add(this.addNewMemberGroupBox);
      this.Controls.Add(this.addMemberButton);
      this.Controls.Add(this.selectTeamMemberDropDown);
      this.Controls.Add(this.selectTeamMemberLabel);
      this.Controls.Add(this.teamNameValue);
      this.Controls.Add(this.teamNameLabel);
      this.Controls.Add(this.headerLabel);
      this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
      this.Name = "CreateTeamForm";
      this.Text = "Create Team";
      this.Load += new System.EventHandler(this.CreateTeamForm_Load);
      this.addNewMemberGroupBox.ResumeLayout(false);
      this.addNewMemberGroupBox.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox teamNameValue;
    private System.Windows.Forms.Label teamNameLabel;
    private System.Windows.Forms.Label headerLabel;
    private System.Windows.Forms.Label selectTeamMemberLabel;
    private System.Windows.Forms.Button addMemberButton;
    private System.Windows.Forms.ComboBox selectTeamMemberDropDown;
    private System.Windows.Forms.GroupBox addNewMemberGroupBox;
    private System.Windows.Forms.TextBox firstNameValue;
    private System.Windows.Forms.Label firstNameLabel;
    private System.Windows.Forms.Button createMemberButton;
    private System.Windows.Forms.TextBox cellphoneValue;
    private System.Windows.Forms.Label cellphoneLabel;
    private System.Windows.Forms.TextBox emailValue;
    private System.Windows.Forms.Label emailLabel;
    private System.Windows.Forms.TextBox lastNameValue;
    private System.Windows.Forms.Label lastNameLabel;
    private System.Windows.Forms.ListBox teamMembersListBox;
    private System.Windows.Forms.Button delecteSelectedMemberButton;
    private System.Windows.Forms.Button createTeamButton;
  }
}