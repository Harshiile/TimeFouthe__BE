using Microsoft.AspNetCore.Mvc;
using TimeFourthe.Entities;
using TimeFourthe.Mails;
using TimeFourthe.Services;

namespace TimeFourthe.Controllers
{
    [Route("api")]
    [ApiController]
    public class MailController : ControllerBase
    {
        private readonly TimetableService _timetableService;
        public MailController(TimetableService timetableService)
        {
            _timetableService = timetableService;
        }

        [HttpPost("send-otp")]
        public async Task<IActionResult> OtpMail()
        {
            Otp.Mail();
            return Ok(new { id = 'f' });
        }
        [HttpPost("send-auth")]
        public async Task<IActionResult> Authx()
        {
            Auth.Mail(["Habibi", "123456789"]);
            return Ok(new { id = 'f' });
        }
    }
}