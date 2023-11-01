class Solution {
    public void merge(int[] nums1, int m, int[] nums2, int n) {
        int p1 = m - 1;
        int p2 = n - 1;
        int target = m + n - 1;

        while(p1 >= 0 && p2 >= 0) {
            if(nums1[p1] > nums2[p2]) {
                nums1[target] = nums1[p1];
                p1--;
            }
            else {
                nums1[target] = nums2[p2];
                p2--;
            }
            target--;
        }

        while(p2 >= 0) {
            nums1[target--] = nums2[p2--];
        }
    }
}