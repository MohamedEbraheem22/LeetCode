public class Solution {
    public int StrStr(string haystack, string needle) {  
        if (needle == "") return 0;
        int index =-1;
        for(int i =0 ; i<= haystack.Length-needle.Length; i++)
        {
            
            if(haystack[i] == needle[0])
            {
                bool match = true;
                for(int x =0; x<needle.Length; x++)
                {
                    
                     if(haystack[i+x] != needle[x])
                    {
                        match =false;
                        break;
                         
                    }
                    else
                    {
                        match = true;
                    }
                }
                if (match) return i;
            }
        }
    return -1;
    }
}