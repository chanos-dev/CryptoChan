using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoChan.Lib
{
    public class Setting
    {
        public static Option Option { get; private set; } = null;

        private Setting()
        { }

        static Setting()
        {
            Option = new Option();
        }
    }
}
