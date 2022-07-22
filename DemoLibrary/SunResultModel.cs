using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class SunResultModel
    {
        public SunModel Results { get; set; }

        public static implicit operator SunResultModel(ComicModel v)
        {
            throw new NotImplementedException();
        }
    }
}
