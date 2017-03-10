using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    interface IRekeningRepository
    {
        void BijSchrijven(decimal bedrag);

        void AfSchrijven(decimal bedrag);
      
    }
}
