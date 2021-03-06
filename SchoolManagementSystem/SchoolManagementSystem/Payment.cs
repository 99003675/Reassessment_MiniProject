using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem
{
   public class Payment
    {
        
        public  int CalFees(int Grade)
        {
            int fees = 10000 * Grade;

            return fees;
        }


    }
}
