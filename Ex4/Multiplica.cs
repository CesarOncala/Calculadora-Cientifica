using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Multiplica:OperaçõesMat
    {
        public override double calc(double n1, double n2)
        {
            return (double) n1 * n2;
        }
    }
}
