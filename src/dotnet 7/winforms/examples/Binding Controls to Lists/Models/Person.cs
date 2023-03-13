namespace DataBinding.Models {
  public class Person : IPerson {
    public string FirstName { get; set; } = string.Empty;
    public string MiddleInitial { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string FullName => this.ToString();
    public override string ToString() => $"{FirstName.Trim()} {MiddleInitial.Trim()} {LastName.Trim()}";
  }
}
