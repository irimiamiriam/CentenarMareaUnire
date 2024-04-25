using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentenarMareaUnire.Models
{
    internal class LectieModel
    {
        public int Id { get; set; }
        public int IdUtilizator { get; set; }
        public string Titlu { get; set; }
        public string Regiune { get; set; }
        public DateTime Data {  get; set; }
        public string File {  get; set; }
    }
}
