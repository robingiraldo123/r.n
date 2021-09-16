using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apifutbolistas.Models
{
    public class futbolista
    {
      [key]
      public int id { get; set; }
      public string nombre { get; set; }

    public string posicion { get; set; }

    public string nacionalidad { get; set; }

        public string imagen { get; set; }
    }
}
