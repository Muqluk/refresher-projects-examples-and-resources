using System.ComponentModel;


namespace DataBinding {
  partial class MainForm {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      components = new Container();
      btn_Add = new Button();
      txt_FirstName = new TextBox();
      txt_MiddleInit = new TextBox();
      txt_LastName = new TextBox();
      label1 = new Label();
      label2 = new Label();
      label3 = new Label();
      btn_Remove = new Button();
      list_People = new ListBox();
      personBindingSource = new BindingSource(components);
      txt_SelectedPerson = new TextBox();
      txt_AddRandomNum = new TextBox();
      btn_GenerateRandoms = new Button();
      label4 = new Label();
      ((ISupportInitialize)personBindingSource).BeginInit();
      SuspendLayout();
      // 
      // btn_Add
      // 
      btn_Add.Enabled = false;
      btn_Add.Location = new Point(168, 97);
      btn_Add.Name = "btn_Add";
      btn_Add.Size = new Size(75, 23);
      btn_Add.TabIndex = 0;
      btn_Add.Text = "Add";
      btn_Add.UseVisualStyleBackColor = true;
      btn_Add.Click += btn_Add_Click;
      // 
      // txt_FirstName
      // 
      txt_FirstName.Location = new Point(73, 10);
      txt_FirstName.Name = "txt_FirstName";
      txt_FirstName.Size = new Size(170, 23);
      txt_FirstName.TabIndex = 1;
      txt_FirstName.TextChanged += UserInputs_ValueChanged;
      // 
      // txt_MiddleInit
      // 
      txt_MiddleInit.Location = new Point(73, 39);
      txt_MiddleInit.Name = "txt_MiddleInit";
      txt_MiddleInit.Size = new Size(38, 23);
      txt_MiddleInit.TabIndex = 2;
      // 
      // txt_LastName
      // 
      txt_LastName.Location = new Point(73, 68);
      txt_LastName.Name = "txt_LastName";
      txt_LastName.Size = new Size(170, 23);
      txt_LastName.TabIndex = 3;
      txt_LastName.TextChanged += UserInputs_ValueChanged;
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new Point(4, 14);
      label1.Name = "label1";
      label1.Size = new Size(64, 15);
      label1.TabIndex = 4;
      label1.Text = "First Name";
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Location = new Point(4, 42);
      label2.Name = "label2";
      label2.Size = new Size(64, 15);
      label2.TabIndex = 5;
      label2.Text = "Middle Init";
      // 
      // label3
      // 
      label3.AutoSize = true;
      label3.Location = new Point(4, 71);
      label3.Name = "label3";
      label3.Size = new Size(63, 15);
      label3.TabIndex = 6;
      label3.Text = "Last Name";
      // 
      // btn_Remove
      // 
      btn_Remove.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      btn_Remove.Enabled = false;
      btn_Remove.Location = new Point(387, 6);
      btn_Remove.Name = "btn_Remove";
      btn_Remove.Size = new Size(35, 23);
      btn_Remove.TabIndex = 7;
      btn_Remove.Text = "Del";
      btn_Remove.UseVisualStyleBackColor = true;
      btn_Remove.Click += btn_Remove_Click;
      // 
      // list_People
      // 
      list_People.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      list_People.DataBindings.Add(new Binding("SelectedItem", personBindingSource, "FirstName", true, DataSourceUpdateMode.OnPropertyChanged));
      list_People.DataBindings.Add(new Binding("SelectedValue", personBindingSource, "FirstName", true, DataSourceUpdateMode.OnPropertyChanged));
      list_People.DataBindings.Add(new Binding("Tag", personBindingSource, "FirstName", true, DataSourceUpdateMode.OnPropertyChanged));
      list_People.DataSource = personBindingSource;
      list_People.DisplayMember = "FirstName";
      list_People.ItemHeight = 15;
      list_People.Location = new Point(260, 35);
      list_People.Name = "list_People";
      list_People.Size = new Size(162, 154);
      list_People.TabIndex = 8;
      list_People.ValueMember = "FirstName";
      list_People.SelectedIndexChanged += list_People_HandleSelectedIndexChanged;
      // 
      // personBindingSource
      // 
      personBindingSource.DataSource = typeof(Models.Person);
      // 
      // txt_SelectedPerson
      // 
      txt_SelectedPerson.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      txt_SelectedPerson.Location = new Point(260, 6);
      txt_SelectedPerson.Name = "txt_SelectedPerson";
      txt_SelectedPerson.ReadOnly = true;
      txt_SelectedPerson.Size = new Size(121, 23);
      txt_SelectedPerson.TabIndex = 9;
      // 
      // txt_AddRandomNum
      // 
      txt_AddRandomNum.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      txt_AddRandomNum.Location = new Point(85, 166);
      txt_AddRandomNum.Name = "txt_AddRandomNum";
      txt_AddRandomNum.Size = new Size(50, 23);
      txt_AddRandomNum.TabIndex = 10;
      txt_AddRandomNum.Text = "0";
      txt_AddRandomNum.TextAlign = HorizontalAlignment.Center;
      txt_AddRandomNum.TextChanged += txt_AddRandomNum_ValueChanged;
      txt_AddRandomNum.KeyPress += txt_AddRandomNum_KeyPress;
      txt_AddRandomNum.Leave += txt_AddRandomNum_Leave;
      // 
      // btn_GenerateRandoms
      // 
      btn_GenerateRandoms.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      btn_GenerateRandoms.Enabled = false;
      btn_GenerateRandoms.Location = new Point(4, 166);
      btn_GenerateRandoms.Name = "btn_GenerateRandoms";
      btn_GenerateRandoms.Size = new Size(75, 23);
      btn_GenerateRandoms.TabIndex = 11;
      btn_GenerateRandoms.Text = "Generate";
      btn_GenerateRandoms.UseVisualStyleBackColor = true;
      btn_GenerateRandoms.Click += btn_GenerateRandoms_Click;
      // 
      // label4
      // 
      label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      label4.AutoSize = true;
      label4.Location = new Point(139, 169);
      label4.Name = "label4";
      label4.Size = new Size(91, 15);
      label4.TabIndex = 12;
      label4.Text = "Random People";
      // 
      // MainForm
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(434, 211);
      Controls.Add(label4);
      Controls.Add(btn_GenerateRandoms);
      Controls.Add(txt_AddRandomNum);
      Controls.Add(txt_SelectedPerson);
      Controls.Add(list_People);
      Controls.Add(btn_Remove);
      Controls.Add(label3);
      Controls.Add(label2);
      Controls.Add(label1);
      Controls.Add(txt_LastName);
      Controls.Add(txt_MiddleInit);
      Controls.Add(txt_FirstName);
      Controls.Add(btn_Add);
      MinimumSize = new Size(450, 250);
      Name = "MainForm";
      Text = "Form1";
      FormClosed += OnFormClosed;
      Load += OnLoad;
      ((ISupportInitialize)personBindingSource).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Button btn_Add;
    private TextBox txt_FirstName;
    private TextBox txt_MiddleInit;
    private TextBox txt_LastName;
    private Label label1;
    private Label label2;
    private Label label3;
    private Button btn_Remove;
    private ListBox list_People;
    private TextBox txt_SelectedPerson;
    private BindingSource personBindingSource;
    private TextBox txt_AddRandomNum;
    private Button btn_GenerateRandoms;
    private Label label4;
  }
}