public class Solution {
    public int FinalValueAfterOperations(string[] operations) {
        int x =0;
        foreach(var item in operations)
        {
            if(item == "--X")
             --x;
            else if(item == "X--")
             x--;
            else if(item == "X++")
             x++;
            else if(item == "++X")
             ++x;
            else
            Console.WriteLine("invalid input");
        }
        return x;
    }
}