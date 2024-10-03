using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10_OOP_TruuTuong.Start
{
    internal class CongTac
    {
        private readonly IStartable _startable;

        public CongTac(IStartable startable)
        {
            _startable = startable;
        }

        public void Bat()
        {
            _startable.Start();
        }
    }
}
