public class Solution {
    public bool IsPalindrome(string s) {
        int l = 0, r = s.Length-1;

        while(l < r){
            while(l < r && !isAlphanum(s[l])){
                l++;
            }
            while(r>l && !isAlphanum(s[r])){
                r--;
            }

            if(char.ToLower(s[l]) != char.ToLower(s[r])){
                return false;
            }
            l++;
            r--;
        }
        return true;
    }
    
    public bool isAlphanum(char c) {
        return (c >= 'A' && c <= 'Z' || 
                c >= 'a' && c <= 'z' || 
                c >= '0' && c <= '9');
    }
}
