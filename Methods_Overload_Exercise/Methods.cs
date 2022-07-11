using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Overload_Exercise;

internal class Methods
{   
    public static int Add(int add1, int add2)
    {
        return add1 + add2;
    }

    public static decimal Add(decimal add1, decimal add2)
    {
        return add1 + add2;
    }

    public static string Add(int add1, int add2, bool isTrue)
    {
        var total = add1 + add2;

        if (isTrue == true)
        {
            if (total == 1)
            {
                return $"{total} dollar";
            }
            else if (total > 1 || total == 0)
            {
                return $"{total} dollars";
            }
            //else if (total > 0 && total < 1)  //commented this part out for the time being because I couldn't wrap my head around
            //{                                //allowing inputs for both integers and decimals in the same method                
            //    return $"{total} cents";    //without having to make another method...unless that's the solution
            //}
            
        }   return total.ToString();
    }

}
