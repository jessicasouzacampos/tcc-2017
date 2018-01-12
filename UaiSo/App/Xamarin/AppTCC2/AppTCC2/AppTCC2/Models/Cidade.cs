using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace AppTCC2.Models
{

    public class Cidade
    {
        public Cidade()
        {

        }   
        public int CidadeId { get; set; }
        
        public string Nome { get; set; }    
        public virtual List<Tema> Temas { get; set; }
    }
    
}
