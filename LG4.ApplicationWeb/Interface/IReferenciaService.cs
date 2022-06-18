using LG4.ApplicationWeb.Model;

namespace LG4.ApplicationWeb.Interface {
    public interface IReferenciaService {

        List<Referencia> Read();
        void Add(Referencia referencia);
        void Delete(Referencia referencia);

        void Update(Referencia referencia);

    }
}
