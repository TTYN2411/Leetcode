public class Solution {
    public bool IsPalindrome(int x) {
        // Nếu số là số âm thì không phải số đối xứng
        if (x < 0) {
            return false;
        }

        int originalNumber = x; // Lưu số gốc
        int reversedNumber = 0; // Số đảo ngược

        // Lật ngược số
        while (x > 0) {
            int lastDigit = x % 10;
            reversedNumber = reversedNumber * 10 + lastDigit;
            x /= 10;
        }

        // So sánh số gốc với số đã lật ngược
        return originalNumber == reversedNumber;
    }
}