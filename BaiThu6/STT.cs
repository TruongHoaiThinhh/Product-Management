using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiThu6
{
    public class STT
    {
        private static STT _instance;

        private STT() { }

        public static STT Instance
        {
            get
            {
                if (_instance != null) return _instance;
                _instance = new STT();
                return _instance;

                
            }
            private set { _instance = value; }
        }



    }
}
