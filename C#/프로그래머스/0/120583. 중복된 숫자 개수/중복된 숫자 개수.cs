using System;
using System.Linq;

public class Solution {
    public int solution(int[] array, int n) {
        return array.Count(item => item == n);
    }
}