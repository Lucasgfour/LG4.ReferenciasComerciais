using LG4.ApplicationWeb.Interface;
using LG4.ApplicationWeb.Model;
using Microsoft.AspNetCore.Mvc;

namespace LG4.ApplicationWeb.Controllers {

    [Route("api/referencia")]
    [ApiController]
    public class ReferenciaController : ControllerBase {

        private readonly IReferenciaService _referenciaService;

        public ReferenciaController(IReferenciaService referenciaService) {
            this._referenciaService = referenciaService;
        }

        [HttpGet]
        public List<Referencia> GetAll() {

            var referencias = _referenciaService.Read();

            return referencias;

        }

        [HttpPost]
        public void Add([FromBody] Referencia referencia) {

            referencia.id = System.Guid.NewGuid();

            _referenciaService.Add(referencia);

        }

        [HttpPut]
        public void Update([FromBody] Referencia referencia) {

            _referenciaService.Update(referencia);

        }

        [HttpDelete]
        public void Delete([FromBody] Referencia referencia) {

            _referenciaService.Delete(referencia);

        }


    }
}
