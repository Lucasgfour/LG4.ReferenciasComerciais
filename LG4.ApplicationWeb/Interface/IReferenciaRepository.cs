using LG4.ApplicationWeb.Model;

namespace LG4.ApplicationWeb.Interface {
    public interface IReferenciaRepository {

        List<Referencia> Read();

        void Save(List<Referencia> referencias);

    }
}
