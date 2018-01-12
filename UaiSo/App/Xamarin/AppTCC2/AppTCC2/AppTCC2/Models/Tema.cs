using SQLite;
using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

namespace AppTCC2.Models
{
    [Table("Temas")]
    public class Tema
    {
        public Tema()
        {

        }

        [PrimaryKey, AutoIncrement]
        public int TemaId { get; set; }
        
        public string Nome { get; set; }

        public virtual List<Termo> Termos { get; set; }
    }
}
