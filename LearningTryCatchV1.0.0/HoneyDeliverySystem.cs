using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningTryCatchV1._0._0
{
    class HoneyDeliverySystem
    {
        public int HoneyLevel = 0;
        public void FeedHoneyToEggs()
        {
            if (HoneyLevel == 0)
            {
                throw new OutOfHoneyException("W ulu brakło miodu");
            }
            else
            {
                MessageBox.Show("Nie brakuje nam miodu!");
            }
        }
        
    }
}
