using ChanceNET;

using DataBinding.Models;

namespace DataBinding
{
  public partial class MainForm : Form
  {

    #region Members & Properties

    private Chance chance = new Chance();
    private BindingSource peopleBindingSource;

    public IList<IPerson> People { get; set; } = new List<IPerson>();

    private int selectedIndex;
    public int SelectedIndex
    {
      get => selectedIndex;
      set
      {
        if (selectedIndex != value)
        {
          txt_SelectedPerson.Text = value != -1
            ? People[value].FullName
            : string.Empty;

          btn_Remove.Enabled = (value != -1);
          list_People.SelectedIndex = value;

          selectedIndex = value;
        }
      }
    }

    #endregion

    #region CTOR and Lifecycle

    public MainForm() => InitializeComponent();

    private void OnLoad(object sender, EventArgs e)
    {
      peopleBindingSource = new BindingSource(People, null);
      list_People.DataSource = peopleBindingSource;
      list_People.DisplayMember = "FullName";
      list_People.ValueMember = "FirstName";
    }

    protected void OnFormClosed(object sender, FormClosedEventArgs e) => peopleBindingSource.Dispose();

    #endregion

    #region Event Handlers

    private void btn_Add_Click(object sender, EventArgs e)
    {
      peopleBindingSource.Add(new Models.Person
      {
        FirstName = txt_FirstName.Text.Trim(),
        MiddleInitial = txt_MiddleInit.Text.Trim(),
        LastName = txt_LastName.Text.Trim(),
      });
      SelectedIndex = -1;
      ClearUserInputs();
    }

    private void btn_Remove_Click(object sender, EventArgs e)
    {
      peopleBindingSource.RemoveAt(SelectedIndex);
      SelectedIndex = -1;
    }

    private void txt_AddRandomNum_ValueChanged(object sender, EventArgs e)
    {
      var txt = txt_AddRandomNum.Text.Trim();
      int numOfRandoms;
      int.TryParse(txt, out numOfRandoms);
      btn_GenerateRandoms.Enabled = (txt.Length > 0 && numOfRandoms > 0);
    }

    private void txt_AddRandomNum_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
      {
        e.Handled = true;
      }
    }

    private void txt_AddRandomNum_Leave(object sender, EventArgs e)
    {
      int numOfRnd;
      int.TryParse(txt_AddRandomNum.Text.Trim(), out numOfRnd);
      if (numOfRnd < 0)
      {
        txt_AddRandomNum.Text = "0";
      }
    }

    private void UserInputs_ValueChanged(object sender, EventArgs e)
    {
      var fNameLen = txt_FirstName.Text.Trim().Length;
      var lNameLen = txt_LastName.Text.Trim().Length;
      btn_Add.Enabled = (fNameLen + lNameLen) > 0; // admittedly ugly...
    }

    private void list_People_HandleSelectedIndexChanged(object sender, EventArgs e) => SelectedIndex = list_People.SelectedIndex;

    private void btn_GenerateRandoms_Click(object sender, EventArgs e)
    {
      GeneratePeople(int.Parse(txt_AddRandomNum.Text));
      SelectedIndex = -1;
    }


    #endregion

    #region Utility Methods

    private void ClearUserInputs()
    {
      txt_FirstName.Clear();
      txt_MiddleInit.Clear();
      txt_LastName.Clear();
    }

    private Models.Person GeneratePerson() => new Models.Person
    {
      FirstName = chance.FirstName(),
      MiddleInitial = chance.LastName().Substring(0, 1),
      LastName = chance.LastName(),
    };

    private void GeneratePeople(int numOfPeople = 1)
    {
      for (int i = 0; i < numOfPeople; i++)
      {
        peopleBindingSource.Add(GeneratePerson());
      }
    }

    #endregion

  }
}