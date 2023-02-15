using System;
interface IFindFib 
    {
    int CalculateFib(int num);
    }

class FibInteration : IFindFib
{
    public int CalculateFib(int num)
    {
        if (num == 1 || num == 2)
        {
            return 1;
        }
        else {
            int addthis = 1;
            int addthis2 = 1;
            int returnable = 1;
            for (int i = 2; i < num; i++){
                returnable = addthis + addthis2;
                addthis2 = addthis;
                addthis = returnable;
                
            }
            return returnable;
        }
    }
}

class FibFormula : IFindFib
{
    public int CalculateFib(int num)
    {
        return (int)((Math.Pow(((1+Math.Sqrt(5))/2), num) - (Math.Pow(((1 - Math.Sqrt(5)) / 2), num)))/ Math.Sqrt(5));
    }
}