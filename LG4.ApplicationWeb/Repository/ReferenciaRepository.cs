using LG4.ApplicationWeb.Interface;
using LG4.ApplicationWeb.Model;
using Newtonsoft.Json;
using System.Text;

namespace LG4.ApplicationWeb.Repository {
    public class ReferenciaRepository : IReferenciaRepository {

        private string ReferenciaPath = "C:\\Referencias\\referencias.json";
        public List<Referencia> Read() {

            if (!File.Exists(ReferenciaPath))
                return new List<Referencia>();

            var json = File.ReadAllText(ReferenciaPath, Encoding.UTF8);

            var referencias = JsonConvert.DeserializeObject<List<Referencia>>(json);

            if (referencias == null)
                return new List<Referencia>();

            return referencias;

        }

        public void Save(List<Referencia> referencias) {

            var diretorio = ReferenciaPath.Replace("referencias.json", "");

            if (!Directory.Exists(diretorio))
                Directory.CreateDirectory(diretorio);

            var json = JsonConvert.SerializeObject(referencias);

            File.WriteAllText(ReferenciaPath, json, Encoding.UTF8);

        }
    }
}
