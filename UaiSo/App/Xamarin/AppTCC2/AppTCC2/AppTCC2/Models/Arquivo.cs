using SQLite;
//using System.Web;

namespace AppTCC2.Models
{
    [Table("Arquivos")]
    public class Arquivo
    {
        [PrimaryKey, AutoIncrement]
        public int ArquivoId { get; set; }
        
        public string Nome { get; set; }
       
        public byte[] File { get; set; }
    }
}