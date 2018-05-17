using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle.Resources
{
    public class SingltonForMainResource
    {
        private static SingltonForMainResource instance;
        //public MyRes res{get; private set;}
        
        private SingltonForMainResource()
        {

        }
        public static SingltonForMainResource GetInstance()
        {
            return instance == null ? new SingltonForMainResource() : instance;
        }
    }
}
