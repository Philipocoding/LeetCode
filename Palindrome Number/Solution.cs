public class Solution {
    public bool IsPalindrome(int x) {
        
        string number = "";
        for(int i = x.ToString().Length; i >= 1; i--){
            number = number + x.ToString()[i-1].ToString();
        }

        if(number == x.ToString())
        {
            return true;
        }
        else{
            return false;
        }
    }
}
