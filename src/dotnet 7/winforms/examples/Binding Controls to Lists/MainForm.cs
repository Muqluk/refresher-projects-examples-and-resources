using System;

using ChanceNET;

using DataBinding.Models;

namespace DataBinding {
  public partial class MainForm : Form {
    private Chance chance = new Chance();
    private BindingSource? peopleBindingSource;

    #region Properties

    public IList<IPerson> People { get; set; } = new List<IPerson>();

    #endregion

    #region CTOR

    public MainForm() {
      InitializeComponent();
    }

    #endregion

    #region Lifecycle Events

    private void OnLoad(object sender, EventArgs e) {
      peopleBindingSource = new BindingSource(People, null);

      lb_People.DataSource = peopleBindingSource;
      lb_People.DisplayMember = "FullName";
      lb_People.ValueMember = "FirstName";
    }

    protected void OnFormClosed(object sender, FormClosedEventArgs e) {
      peopleBindingSource.Dispose();
    }

    #endregion

    #region Event Handlers

    private void btn_Remove_Click(object sender, EventArgs e) {
      if (peopleBindingSource.Count > 0) {
        txt_SelectedPerson.Text = string.Empty;
        peopleBindingSource.RemoveCurrent();
        peopleBindingSource.ResetCurrentItem();
      }
    }

    private void lb_People_HandleSelectedIndexChanged(object sender, EventArgs e) {
      var person = peopleBindingSource?.Current as Models.Person;
      txt_SelectedPerson.Text = person?.FullName ?? string.Empty;
    }

    private void btn_GenerateRandoms_Click(object sender, EventArgs e) {
      for (int i = 0; i < 5; i++) {
        peopleBindingSource.Add(new Models.Person {
          FirstName = chance.FirstName(),
          MiddleInitial = chance.LastName().Substring(0, 1),
          LastName = chance.LastName(),
        });
      }
      peopleBindingSource.ResetCurrentItem();
    }

    #endregion

  }
}
