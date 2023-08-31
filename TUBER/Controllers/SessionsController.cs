namespace TUBER.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SessionsController : ControllerBase
{
    private readonly SessionsService _sessionsService;
    private readonly Auth0Provider _auth;

    public SessionsController(SessionsService sessionsService)
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
            sessionData.CreatorId = userInfo.Id;

            Session session = _sessionsService.CreateSession(sessionData);
            return new ActionResult<Session>(Ok(session));
        }
        catch (Exception e)
        {
            return new ActionResult<Session>(BadRequest(e.Message));
        }
    } 

}