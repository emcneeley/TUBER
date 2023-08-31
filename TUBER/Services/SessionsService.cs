namespace TUBER.Services;

public class SessionsService
{
  private readonly SessionsRepository _repo;

  public SessionsService(SessionsRepository repo)
  {
    _repo = repo;
  }

  internal Session CreateSession(Session sessionData)
  {
    Session session = _repo.CreateSession(sessionData);
    return session;
  }
}