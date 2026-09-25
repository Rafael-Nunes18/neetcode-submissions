//Optimized Solution O(n)

public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length){
            return false;
        }
     var count = new Dictionary<char,int>();

        foreach(char c in s){
        if(count.ContainsKey(c)){
        count[c]++;
        }
        else{
            count[c]=1;
        }
        }
     
       foreach(char c in t){
        if(!count.ContainsKey(c) || count[c] == 0 ) {
            return false;
        }
            count[c]--;
       }
       return true;
     }
    }

