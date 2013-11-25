using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workker.Telemetria.InfraStructure.ScopeInstance
{
    public class ThreadStaticInstanceScoper<T> : InstanceScoperBase<T>
    {
        [ThreadStatic]
        private static readonly IDictionary _dictionary = new Dictionary<string, T>();

        protected override IDictionary GetDictionary()
        {
            return _dictionary;
        }
    }
}
