public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if(strs == null || strs.Length == 0) return "";


string str = strs[0];
        for(int i = 0; i<strs.Length; i++)
        {
            
            
            for(int x = 0; x<strs.Length ; x++)
            {
                while(!(strs[x].StartsWith(str)))
                {
                    str = str.Substring(0 , str.Length-1);
                    if(str == "")
                    return "";
                }

            }
            
        }
        return str;
    }
}