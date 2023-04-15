using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace tpmodul9_1302213089.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    public class MahasiswaController : Controller
    {
        private static List<Mahasiswa> dataMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa("Muhammad Vikhan Muharram", "1302213089"),
            new Mahasiswa("Heru Ikhsan Maulana", "1302210009"),
            new Mahasiswa("Bimo Zachriansyah Wicaksono Hermawan", "1302213012"),
            new Mahasiswa("Muhammad Fadhil Ardiansyah Supiyan", "1302210006"),
            new Mahasiswa("Faris Siddiq Ramdan Putra", "1302213133")
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
        public void Post([FromBody]Mahasiswa value)
        {
            dataMahasiswa.Add(value);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Mahasiswa value) 
        {
            dataMahasiswa[id] = value;
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            dataMahasiswa.RemoveAt(id);
        }
    }
}
