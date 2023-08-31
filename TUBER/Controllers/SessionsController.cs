namespace TUBER.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SessionsController : ControllerBase
{
    private readonly SessionsService _sessionsService;
    private readonly Auth0Provider _auth;

    public SessionsController(SessionsService sessionsService, Auth0Provider auth)
    {
        _sessionsService = sessionsService;
        _auth = auth;
    }

    [HttpPost]
    [Authorize]
    public async Task<ActionResult<Session>> CreateSession([FromBody] Session sessionData)
    {
        try
        {
            Account userInfo = await _auth.GetUserInfoAsync<Account>
            (HttpContext);

            Session session = _sessionsService.CreateSession(sessionData);
            return new ActionResult<Session>(Ok(session));
        }
        catch (Exception e)
        {
            return new ActionResult<Session>(BadRequest(e.Message));
        }
    }

}