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
      btn_Remove = new Button();
      lb_People = new ListBox();
      personBindingSource = new BindingSource(components);
      txt_SelectedPerson = new TextBox();
      btn_GenerateRandoms = new Button();
      ((ISupportInitialize)personBindingSource).BeginInit();
      SuspendLayout();
      // 
      // btn_Remove
      // 
      btn_Remove.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      btn_Remove.Location = new Point(157, 37);
      btn_Remove.Name = "btn_Remove";
      btn_Remove.Size = new Size(65, 23);
      btn_Remove.TabIndex = 7;
      btn_Remove.Text = "Del";
      btn_Remove.UseVisualStyleBackColor = true;
      btn_Remove.Click += btn_Remove_Click;
      // 
      // lb_People
      // 
      lb_People.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      lb_People.DataSource = personBindingSource;
      lb_People.DisplayMember = "FirstName";
      lb_People.ItemHeight = 15;
      lb_People.Location = new Point(12, 64);
      lb_People.Name = "lb_People";
      lb_People.Size = new Size(210, 139);
      lb_People.TabIndex = 8;
      lb_People.ValueMember = "FirstName";
      lb_People.SelectedIndexChanged += lb_People_HandleSelectedIndexChanged;
      // 
      // personBindingSource
      // 
      personBindingSource.DataSource = typeof(Models.Person);
      // 
      // txt_SelectedPerson
      // 
      txt_SelectedPerson.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      txt_SelectedPerson.Location = new Point(12, 37);
      txt_SelectedPerson.Name = "txt_SelectedPerson";
      txt_SelectedPerson.ReadOnly = true;
      txt_SelectedPerson.Size = new Size(139, 23);
      txt_SelectedPerson.TabIndex = 9;
      // 
      // btn_GenerateRandoms
      // 
      btn_GenerateRandoms.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      btn_GenerateRandoms.Location = new Point(12, 9);
      btn_GenerateRandoms.Name = "btn_GenerateRandoms";
      btn_GenerateRandoms.Size = new Size(210, 23);
      btn_GenerateRandoms.TabIndex = 11;
      btn_GenerateRandoms.Text = "Add 5 People";
      btn_GenerateRandoms.UseVisualStyleBackColor = true;
      btn_GenerateRandoms.Click += btn_GenerateRandoms_Click;
      // 
      // MainForm
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(234, 211);
      Controls.Add(btn_GenerateRandoms);
      Controls.Add(txt_SelectedPerson);
      Controls.Add(lb_People);
      Controls.Add(btn_Remove);
      MinimumSize = new Size(250, 250);
      Name = "MainForm";
      Text = "Form1";
      FormClosed += OnFormClosed;
      Load += OnLoad;
      ((ISupportInitialize)personBindingSource).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion
    private Button btn_Remove;
    private ListBox lb_People;
    private TextBox txt_SelectedPerson;
    private BindingSource personBindingSource;
    private Button btn_GenerateRandoms;
  }
}
