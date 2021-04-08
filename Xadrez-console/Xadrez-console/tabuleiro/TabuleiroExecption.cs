using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    class TabuleiroExecption :Exception
    {
        public TabuleiroExecption (string msg) : base(msg)
        {

        }
    }
}
