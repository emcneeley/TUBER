namespace TUBER.Models;

public class Account : Profile
{
  public string Email { get; set; }

}

public class Profile
{
  public string Id { get; set; }
  public string Name { get; set; }
  public string Picture { get; set; }
  public bool IsTutor { get; set; }
  public bool IsStudent { get; set; }
}