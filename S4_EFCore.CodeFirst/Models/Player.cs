using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S4_EFCore.CodeFirst.Models
{
    [Table("Player")]
    public class Player
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName ="nvarchar(100)")]
        public string Fullname { get; set; }
        [Column(TypeName ="int")]
        public int Dorsal { get; set; }
        [Column(TypeName ="bit")]
        public bool Status { get; set; }
        
        public int SoccerPositionId { get; set; }
        public virtual SoccerPosition SoccerPosition { get; set; }

    }
}
