using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RetroService.Models
{
    public class Board
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
