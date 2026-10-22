using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pi31_2_Dyadchenko_Kite.NeuroNet
{
    enum MemoryMode
    {
        GET,
        SET,
        INIT
    }

    enum NeuronType
    {
        Hidden,
        Output
    }

    enum NetworkMode
    {
        Train,
        Test,
        Demo
    }
}
