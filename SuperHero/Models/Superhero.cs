using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHero.Models
{
    public class Superhero
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string AlterEgo { get; set; }
        [Required]
        public string primarySuperheroAbility { get; set; }
        [Required]
        public string SecondarySuperheroAbility { get; set; }
        [Required]
        public string Catchphrase{ get; set; }
        

    }
}
