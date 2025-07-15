namespace PresentationLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JournalEntryController : ControllerBase
    {

        private readonly IJournalEntryService _journalEntryService;

        public JournalEntryController(IJournalEntryService journalEntryService)
        {
            _journalEntryService = journalEntryService;
        }

        [HttpPost("AddJournalEntry")]
        public async Task<IActionResult> AddJournalEntry([FromBody] SaveJournalEntryHeaderDTO journalEntry)
        {
            try
            {
                var result = await _journalEntryService.AddJournalEntryAsync(journalEntry);
                return Ok(result);
            }
            catch (ArgumentNullException ex)
            {
                return BadRequest(new ResponseDTO<int>
                {
                    IsSuccess = false,
                    Message = ex.Message,
                    Data = 0
                });
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new ResponseDTO<int>
                {
                    IsSuccess = false,
                    Message = ex.Message,
                    Data = 0
                });
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(new ResponseDTO<int>
                {
                    IsSuccess = false,
                    Message = ex.Message,
                    Data = 0
                });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new ResponseDTO<int>
                {
                    IsSuccess = false,
                    Message = $"An error occurred while adding the journal entry: {ex.Message}",
                    Data = 0
                });
            }
        }

    }
}
