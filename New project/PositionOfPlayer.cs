using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class PositionOfPlayer
    {
        int PositionId, PlayerId;
        public void SetPositionOfPlayerAll(int PositionId,int PlayerId)
        {
            this.PositionId = PositionId;
            this.PlayerId = PlayerId;
        }
    }
}
