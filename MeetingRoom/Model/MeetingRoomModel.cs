using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingRoom.Model
{
    public class MeetingRoomModel
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(30)")]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "int")]
        public int Size { get; set; }


        [Column(TypeName = "bit")]
        public bool? Projector { get; set; }
    
        [Column(TypeName = "bit")]
        public bool? TV { get; set; }

    }
}
