using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab34
{
    [Table(Name = "date")]
    public class Datas
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        [Column]
        public int Regnum { get; set; }
        [Column]
        public DateTime Regdate { get; set; }
        [Column]
        public string Opisprois { get; set; }
    }
    [Table(Name = "info")]
    public class Inf
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        [Column]
        public int Regnum { get; set; }
        [Column]
        public string Resch { get; set; }
        [Column]
        public int Codeus { get; set; }
    }
    [Table(Name = "users")]
    public class User
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        [Column]
        public int Uscode { get; set; }
        [Column]
        public string Fname { get; set; }
        [Column]
        public string Name { get; set; }
        [Column]
        public string Oname { get; set; }
        [Column]
        public char Sex { get; set; }
        [Column]
        public DateTime Datage { get; set; }
        [Column]
        public string Mestrojd { get; set; }
        [Column]
        public string Addres { get; set; }
        [Column]
        public int Sudcol { get; set; }
        [Column]
        public string Status { get; set; }
    }
}
