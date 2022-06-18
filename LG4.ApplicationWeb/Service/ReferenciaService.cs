using LG4.ApplicationWeb.Interface;
using LG4.ApplicationWeb.Model;

namespace LG4.ApplicationWeb.Service {
    public class ReferenciaService : IReferenciaService {

        private readonly IReferenciaRepository _referenciaRepository;

        public ReferenciaService(IReferenciaRepository referenciaRepository) {
            this._referenciaRepository = referenciaRepository;
        }


        public void Add(Referencia referencia) {

            var listaAtual = Read();

            listaAtual.Add(referencia);

            Save(listaAtual);

        }

        public void Delete(Referencia referencia) {

            var listaAtual = Read();

            listaAtual = listaAtual.Where(refe => refe.id != referencia.id).ToList();

            Save(listaAtual);

        }

        public void Update(Referencia referencia) {

            var listaAtual = Read();

            var referenciaOld = listaAtual.Where(refe => refe.id == referencia.id).FirstOrDefault();

            if (referenciaOld == null)
                throw new Exception("Não foi possível encontrar a referência a ser atualizada.");

            Delete(referenciaOld);

            Add(referencia);

        }

        public List<Referencia> Read() {

            var referencias = _referenciaRepository.Read();

            return referencias;

        }

        private void Save(List<Referencia> referencias) {

            _referenciaRepository.Save(referencias);

        }
    }
}
