namespace TUBER.Repositories;

public class SessionsRepository
{
  private readonly IDbConnection _db;

  public SessionsRepository(IDbConnection db)
  {
    _db = db;
  }

}