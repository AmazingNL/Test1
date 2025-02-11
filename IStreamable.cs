using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_flix
{
    internal interface IStreamable
    {
        void StartStream();
        void EndStream();
    }
}
