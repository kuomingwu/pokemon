using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace jon.Models{

    public abstract class Pokemon{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid id { get ; set; }

        public Pokemon (){
            this.id = Guid.NewGuid();
        }
    }

}