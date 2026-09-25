public class Solution {
    public bool IsAnagram(string s, string t) {
   char[] sArray = s.ToCharArray();
    Array.Sort(sArray);
    char[] tArray = t.ToCharArray();
    Array.Sort(tArray);
    string sString =  new string(sArray);
    string tString =  new string(tArray);

    if(sString == tString){
        return true;
    }

   return false;
    }
}
