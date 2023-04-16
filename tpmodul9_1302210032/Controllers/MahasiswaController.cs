using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace tpmodul9_1302210032.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> mahasiswas = new List<Mahasiswa>
        {
            new Mahasiswa("Kamal Maulaazka Sidhqi", "1302210032"),
            new Mahasiswa("Herdi Ardana", "1302210078"),
            new Mahasiswa("Iqnaz Nadhif", "1302210104"),
            new Mahasiswa("Mochamad Rizky Evan Ramadhan", "1302213058"),
            new Mahasiswa("Rahman Ar Rasyid", "1302213088")
        };

        [HttpGet]   
        public IEnumerable<Mahasiswa> Get()
        {
            return mahasiswas;
        }

        [HttpPost]
        public void Post([FromBody] Mahasiswa value)
        {
            mahasiswas.Add(value);
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return mahasiswas[id];
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            mahasiswas.RemoveAt(id);
        }
    }
}
