namespace DataBinding.Models {
  public interface IPerson {
    string FirstName { get; set; }
    string MiddleInitial { get; set; }
    string LastName { get; set; }
    string FullName { get; }
    string ToString();
  }
}
