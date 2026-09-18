using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTA
{
    internal class CarroEsportivo:  Carro
    {
        public bool TemAerofolio { get; set; }
        public CarroEsportivo()
            :base()
        {
            this.TemAerofolio = true;
        }

        public override void subirMarcha() // override significa sobreescrever
        {
            base.subirMarcha();

            this.Marcha++;
            if (this.Marcha > 8) this.Marcha = 8;
        }
    }
}
