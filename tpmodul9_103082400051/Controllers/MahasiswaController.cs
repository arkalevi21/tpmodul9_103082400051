using Microsoft.AspNetCore.Mvc;
using tpmodul9_103082400051.Models;

namespace tpmodul9_103082400051.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MahasiswaController : ControllerBase
{
    private static List<Mahasiswa> dataMahasiswa = new List<Mahasiswa>
    {
        new Mahasiswa { Nama = "Aryasatya Kalevi", Nim = "103082400051" },
        new Mahasiswa { Nama = "LeBron James", Nim = "1302000001" },
        new Mahasiswa { Nama = "Stephen Curry", Nim = "1302000002" },
        new Mahasiswa { Nama = "Kevin Durant", Nim = "1302000003" }
    };

    [HttpGet]
    public IEnumerable<Mahasiswa> Get()
    {
        return dataMahasiswa;
    }

    [HttpGet("{id}")]
    public Mahasiswa Get(int id)
    {
        return dataMahasiswa[id];
    }

    [HttpPost]
    public void Post([FromBody] Mahasiswa mahasiswaBaru)
    {
        dataMahasiswa.Add(mahasiswaBaru);
    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
        dataMahasiswa.RemoveAt(id);
    }
}