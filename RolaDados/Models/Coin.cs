using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolaDados.Models
{
    class Coin
    {
        public int Lados { get; set; } = 2;

        public int Girar()
        {
            return Random.Shared.Next(0, Lados);
        }
    }

}
