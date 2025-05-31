public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        Array.Sort(nums1);
        Array.Sort(nums2);

        int totalLength = nums1.Length+nums2.Length;
        double [] mergedArr = new double[totalLength];
        for(int i =0; i<nums1.Length ; i++)
        {
            mergedArr[i] = (double)nums1[i];
        }
        for(int x =0; x<nums2.Length; x++)
            {
                mergedArr[nums1.Length+x] = (double)nums2[x];
            }
       
        Array.Sort(mergedArr);


        if (totalLength % 2 == 1)
        {
            return mergedArr[totalLength / 2];
        }
        else
        {
            return (mergedArr[totalLength / 2 - 1] + mergedArr[totalLength / 2]) / 2.0;
        }
        

        }
    }
