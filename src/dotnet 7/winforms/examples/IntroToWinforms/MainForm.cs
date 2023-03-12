namespace example_winforms_app {
  public partial class MainForm : Form {

    #region CTOR

    public MainForm() => InitializeComponent();

    #endregion

    #region Event Handlers

    private void btn_addPerson_Click(object sender, EventArgs e) => AddPerson();

    private void cmb_SelectionChangeEvent(object sender, EventArgs e) => SetSelectedPerson();

    private void cmb_RemovePerson_Click(object sender, EventArgs e) => RemovePerson();

    #endregion

    #region Private Methods

    private void AddPerson() {
      cmb_names.Items.Add($"{txt_firstName.Text.Trim()} {txt_lastName.Text.Trim()}");
      ClearUserInput();
    }

    private void ClearUserInput() {
      txt_firstName.Clear();
      txt_lastName.Clear();
    }

    private void SetSelectedPerson() {
      txt_firstName.Text = cmb_names.SelectedItem.ToString()?.Split(' ')[0] ?? String.Empty;
      txt_lastName.Text = cmb_names.SelectedItem.ToString()?.Split(' ')[1] ?? String.Empty;
    }

    private void RemovePerson() {
      cmb_names.Items.RemoveAt(cmb_names.SelectedIndex);
      ClearUserInput();
    }

    #endregion
  }
}
