using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class PositionName
    {
        int PositionId;
        string Name;
        public void SetPositionNameAll(int PositionId, string Name)
        {
            this.PositionId = PositionId;
            this.Name = Name;
        }
    }
}
