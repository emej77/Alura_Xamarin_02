using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrive.Model
{
    public class Veiculo
    {
        public const double FREIO_ABS = 800;
        public const double AR_CONDICIONADO = 1000;
        public const double MP3_PLAYER = 500;

        public string Nome { get; set; }
        public double Preco { get; set; }
        public string PrecoFormatado
        {
            get
            {
                return string.Format("R${0}",this.Preco);
            }
        }
    }
}
