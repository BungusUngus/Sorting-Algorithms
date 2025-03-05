using UnityEngine;

public abstract class Search 
{
    public abstract int Find(int[] numbers, int target);
}
public class BruteForceSearch : Search
{
    //You can assume that the numbers list is in order
   public override int Find(int[] numbers, int target)
    {
        //Array.sort.RandomRange(i); 
        //return the index of the found number

        for(int x = 0; x < numbers.Length; x++)
        {
            if(x == target)
            {
                return x;
            }
        }
        return -1;
    }
}
