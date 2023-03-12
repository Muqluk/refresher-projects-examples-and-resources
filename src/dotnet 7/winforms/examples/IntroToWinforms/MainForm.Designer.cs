namespace example_winforms_app {
  partial class MainForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      label1 = new Label();
      txt_firstName = new TextBox();
      btn_addPerson = new Button();
      txt_lastName = new TextBox();
      label2 = new Label();
      cmb_names = new ComboBox();
      cmb_RemovePerson = new Button();
      SuspendLayout();
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new Point(12, 15);
      label1.Name = "label1";
      label1.Size = new Size(67, 15);
      label1.TabIndex = 0;
      label1.Text = "First Name:";
      // 
      // txt_firstName
      // 
      txt_firstName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      txt_firstName.Location = new Point(85, 12);
      txt_firstName.Name = "txt_firstName";
      txt_firstName.Size = new Size(171, 23);
      txt_firstName.TabIndex = 1;
      // 
      // btn_addPerson
      // 
      btn_addPerson.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      btn_addPerson.Location = new Point(139, 141);
      btn_addPerson.Name = "btn_addPerson";
      btn_addPerson.Size = new Size(117, 23);
      btn_addPerson.TabIndex = 2;
      btn_addPerson.Text = "Add Person";
      btn_addPerson.UseVisualStyleBackColor = true;
      btn_addPerson.Click += btn_addPerson_Click;
      // 
      // txt_lastName
      // 
      txt_lastName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      txt_lastName.Location = new Point(85, 41);
      txt_lastName.Name = "txt_lastName";
      txt_lastName.Size = new Size(171, 23);
      txt_lastName.TabIndex = 4;
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Location = new Point(12, 44);
      label2.Name = "label2";
      label2.Size = new Size(66, 15);
      label2.TabIndex = 3;
      label2.Text = "Last Name:";
      // 
      // cmb_names
      // 
      cmb_names.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      cmb_names.DropDownStyle = ComboBoxStyle.Simple;
      cmb_names.FormattingEnabled = true;
      cmb_names.Location = new Point(12, 70);
      cmb_names.Name = "cmb_names";
      cmb_names.Size = new Size(121, 118);
      cmb_names.TabIndex = 5;
      cmb_names.SelectedIndexChanged += cmb_SelectionChangeEvent;
      // 
      // cmb_RemovePerson
      // 
      cmb_RemovePerson.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      cmb_RemovePerson.Location = new Point(139, 165);
      cmb_RemovePerson.Name = "cmb_RemovePerson";
      cmb_RemovePerson.Size = new Size(117, 23);
      cmb_RemovePerson.TabIndex = 6;
      cmb_RemovePerson.Text = "Remove Person";
      cmb_RemovePerson.UseVisualStyleBackColor = true;
      cmb_RemovePerson.Click += cmb_RemovePerson_Click;
      // 
      // MainForm
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(260, 192);
      Controls.Add(cmb_RemovePerson);
      Controls.Add(cmb_names);
      Controls.Add(txt_lastName);
      Controls.Add(label2);
      Controls.Add(btn_addPerson);
      Controls.Add(txt_firstName);
      Controls.Add(label1);
      MinimumSize = new Size(275, 200);
      Name = "MainForm";
      Text = "Intro To Winforms - 1";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox txt_firstName;
    private Button btn_addPerson;
    private TextBox txt_lastName;
    private Label label2;
    private ComboBox cmb_names;
    private Button cmb_RemovePerson;
  }
}