﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace Krka.MoveOn.Data.Dials
{
    [Table("dial_indications")]
    public class DialIndication
    {
        [Key]
        [Column("id")]
        public required int Id { get; set; }

        [Column("id_user")]
        public required int UserId { get; set; }

        [Column(TypeName = "nvarchar"), StringLength(50)]
        public required string Name { get; set; }

        [Column("modified_at")]
        public required DateTime ModifiedAt { get; set; } = DateTime.Now;

        [Column("created_at")]
        public required DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}