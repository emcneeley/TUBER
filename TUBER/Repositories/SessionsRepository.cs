namespace TUBER.Repositories;

public class SessionsRepository
{
  private readonly IDbConnection _db;

  public SessionsRepository(IDbConnection db)
  {
    _db = db;
  }

  internal Session CreateSession(Session sessionData)
  {
    string sql = @"
      INSERT INTO session
      (creatorId, studentId, tutorId, topicId, isCompleted, isConfirmed, topic)
      VALUES
      (@CreatorId, @StudentId, @TutorId, @TopicId, @IsCompleted, @IsConfirmed, @Topic);

      SELECT
      s.*,
      creator.*
      FROM sessions s
      JOIN accounts creator on s.creatorId = creator.id
      WHERE s.id = LAST_INSERT_ID()
      ;";

    Session session = _db.Query<Session, Account, Session>(sql, (session, creator) =>
    {
      session.Creator = creator;
      return session;
    }, sessionData).FirstOrDefault();
    return session;
  }




}
