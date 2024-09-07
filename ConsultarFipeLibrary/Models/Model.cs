using System.Collections.Generic;

namespace ConsultarFipeLibrary.Models
{
    public class ModelResponse
    {
        public List<Model> Modelos { get; set; }
    }
    public class Model
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
    }
}
