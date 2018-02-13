using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace myWebRazorCrudApp
{
    public class Cliente {

        public int Id {get; set;}

        [Required, StringLength(50)]
        public string Nome {get; set;}

    }

}