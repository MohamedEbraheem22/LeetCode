public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        // نرتب كل مصفوفة
        Array.Sort(nums1);
        Array.Sort(nums2);

        int m = nums1.Length, n = nums2.Length;
        double[] mergedArr = new double[m + n];

        // دمج مصفوفتين مرتبتين بطريقة مرتبة
        int i = 0, j = 0, k = 0;
        while (i < m && j < n) {
            if (nums1[i] < nums2[j]) {
                mergedArr[k++] = nums1[i++];
            } else {
                mergedArr[k++] = nums2[j++];
            }
        }

        while (i < m) mergedArr[k++] = nums1[i++];
        while (j < n) mergedArr[k++] = nums2[j++];

        int totalLength = m + n;
        if (totalLength % 2 == 1) {
            return mergedArr[totalLength / 2];
        } else {
            return (mergedArr[totalLength / 2 - 1] + mergedArr[totalLength / 2]) / 2.0;
        }
    }
}
