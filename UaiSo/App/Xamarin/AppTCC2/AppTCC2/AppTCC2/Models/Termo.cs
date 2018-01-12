using AppTCC2.Enums;
using SQLite;
using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

namespace AppTCC2.Models
{

    [Table("Termos")]
    public class Termo
    {
        public Termo()
        {

        }

        [PrimaryKey, AutoIncrement]
        public int TermoId { get; set; }
        
        public string Nome  { get; set; }
        
        public string Significado { get; set; }
        
        public TipoArquivo Tipo { get; set; }
     
        public List<Arquivo> Arquivos { get; set; }
 
    }
}
