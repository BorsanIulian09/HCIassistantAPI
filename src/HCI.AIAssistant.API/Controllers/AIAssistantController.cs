
using Microsoft.AspNetCore.Mvc;
using HCI.AIAssistant.API.models.DTOs.AIAssistantController;
namespace HCI.AIAssistant.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AIAssistantController : ControllerBase
{
    [HttpPost("/message")]
 public async Task<ActionResult<AIAssistantControllerPostMessageResponseDTO>> PostMessageAsync(AIAssistantControllerPostMessageRequestDTO request)
    {
        // Simulate some processing delay
        AIAssistantControllerPostMessageResponseDTO response = new (){
            TextMessage = "Echo: " + request.TextMessage
        };
        return Ok(response);
    }
}
