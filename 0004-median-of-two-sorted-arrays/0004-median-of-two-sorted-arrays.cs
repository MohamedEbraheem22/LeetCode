public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
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
        for(int z =0; z<mergedArr.Length - 1; z++)
        {
           int minIndex = z;
           for(int j=z+1; j<mergedArr.Length; j++)
           {
            if(mergedArr[j] < mergedArr[minIndex])
            minIndex = j;
           }
double temp = mergedArr[z];
    mergedArr[z] = mergedArr[minIndex];
    mergedArr[minIndex] = temp;
        }
        


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
