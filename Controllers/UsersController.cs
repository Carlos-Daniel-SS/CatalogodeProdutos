using Microsoft.AspNetCore.Mvc;
using MinhaApi.Models;

namespace MinhaApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    // Lista em memória (simula um banco de dados)
    private static List<User> users = new()
    {
        new User { Id = 1, Name = "Carlos", Email = "carlos@email.com" },
        new User { Id = 2, Name = "Maria", Email = "maria@email.com" }
    };

    // GET: api/users
    [HttpGet]
    public ActionResult<List<User>> GetAll()
    {
        return Ok(users);
    }

    // GET: api/users/1
    [HttpGet("{id}")]
    public ActionResult<User> GetById(int id)
    {
        var user = users.FirstOrDefault(u => u.Id == id);

        if (user == null)
            return NotFound("Usuário não encontrado.");

        return Ok(user);
    }

    // POST: api/users
    [HttpPost]
    public ActionResult<User> Create(User user)
    {
        user.Id = users.Max(u => u.Id) + 1;

        users.Add(user);

        return CreatedAtAction(nameof(GetById), new { id = user.Id }, user);
    }

    // PUT: api/users/1
    [HttpPut("{id}")]
    public IActionResult Update(int id, User updatedUser)
    {
        var user = users.FirstOrDefault(u => u.Id == id);

        if (user == null)
            return NotFound("Usuário não encontrado.");

        user.Name = updatedUser.Name;
        user.Email = updatedUser.Email;

        return NoContent();
    }

    // DELETE: api/users/1
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var user = users.FirstOrDefault(u => u.Id == id);

        if (user == null)
            return NotFound("Usuário não encontrado.");

        users.Remove(user);

        return NoContent();
    }
}