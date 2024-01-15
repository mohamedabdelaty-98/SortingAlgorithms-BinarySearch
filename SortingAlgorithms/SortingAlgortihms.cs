using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    internal static class SortingAlgortihms
    {
        private static void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
        public static void SelectionSort<T>(T[] arr,int n) where T :IComparable<T>
        {
            int minindex;           //0  1  2  3  4  5
            for(int i=0; i<n-1; i++)//60 40 50 30 10 20 
            {
                minindex = i;
                for(int j=i+1;j<n;j++)
                {
                    if (arr[j].CompareTo(arr[minindex]) < 0)
                        minindex = j;
                }
                Swap(ref arr[i],ref arr[minindex]);
            }
        }
        public static void BubbleSort<T>(T[] arr, int n)where T :IComparable<T>
        {
            int count = 0;
            bool flag = true;
            for(int i = 0; i < n - 1; i++)
            {
                for(int j=0;j<n-i-1;j++)
                {
                    if (arr[j].CompareTo(arr[j+1])>0)
                    {
                        Swap(ref arr[j],ref arr[j+1]);
                        flag = false;
                    }
                    count++;
                }
                if (flag)
                    break;
            }
            Console.WriteLine($"Num of round:  {count}");
        }
        public static void InsertionSort<T>(T[] arr,int n)where T:IComparable<T>
        {
            T key;    //60, 40, 50, 30, 10, 20 
            int j;    // 40,50,60
            for(int i = 1; i < n; i++)
            {
                key = arr[i];//40
                j = i - 1;//0
                while(j>=0 && arr[j].CompareTo(key)>0)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }
        private static void Merge<T>(T[]arr,int l,int m,int r)where T:IComparable<T>
        {
            //divide
            int NL = m - l + 1;
            int NR = r - m;
            T[] LeftArr= new T[NL];
            T[] RightArr= new T[NR];

            //fill divided array
            for (int x = 0; x < NL; x++) 
                LeftArr[x] = arr[l + x];
            for (int x = 0; x < NR; x++)
                RightArr[x] = arr[m + 1 + x];

            //conqour and merge
            int i=0, j = 0;
            int k = l;
            while (i < NL && j < NR)
            {
                if (LeftArr[i].CompareTo(RightArr[j])<0)
                {
                    arr[k] = LeftArr[i];
                    i++;
                }
                else
                {
                    arr[k] = RightArr[j];
                    j++;
                }
                k++; 
            }
            while (i < NL)
            {
                arr[k] = LeftArr[i];
                i++; k++;
            }
            while (j < NR)
            {
                arr[k] = RightArr[j];
                j++; k++;
            }

        }
        public static void MergeSort<T>(T[]arr, int l, int r)where T:IComparable<T>
        {
            if (l < r)
            {
                int m = l + (r - l) / 2;
                MergeSort(arr, l, m); 
                MergeSort(arr,m+1,r);
                Merge(arr, l, m, r);
            }
        }
        private static int Partioning<T>(T[]arr, int l, int r)where T: IComparable<T> 
        {
            int i = l;
            int j = r;
            int pivot = i;
            while (true)
            {
                while (arr[pivot].CompareTo(arr[j]) <= 0 && pivot != j)
                    j--;
                if (pivot == j)
                    break;
                else if (arr[pivot].CompareTo(arr[j])>0)
                {
                    Swap(ref arr[j],ref arr[pivot]);
                    pivot = j;
                }
                while (arr[pivot].CompareTo(arr[i]) >= 0 && pivot != i)
                    i++;
                if (pivot == i)
                    break;
                else if (arr[pivot].CompareTo(arr[i]) < 0)
                {
                    Swap(ref arr[i], ref arr[pivot]);
                    pivot = i;
                }
            }
            return pivot;
        }
        private static int Partioning2<T>(T[]arr,int l,int r)where T: IComparable<T>
        {
            T pivot = arr[l];
            int i = l; int j = r;
            while (i < j)
            {
                do
                {
                   i++;
                    //if (i == arr.Length)
                    //    break;
                } while (arr[i].CompareTo(pivot) <= 0);
                do
                {
                    j--;
                } while (arr[j].CompareTo(pivot) > 0);
                if(i<j)
                    Swap(ref arr[i],ref arr[j]);
            }
            Swap(ref arr[l],ref arr[j]);
            return j;
        }

        public static void QuickSort<T>(T[]arr,int l,int r)where T: IComparable<T>
        {
            if (l < r)
            {
                int piovt=Partioning(arr,l,r);
                QuickSort(arr, l, piovt );
                QuickSort(arr,piovt+1,r);
            }
        }
        private static void Heapfiy<T>(T[]arr, int size,int posetion)where T : IComparable<T>
            {
                int Left = 2 * posetion + 1;
                int Right= 2*posetion + 2;
                int Max = posetion;
                if (Left < size && arr[Left].CompareTo(arr[Max]) > 0)
                    Max = Left;
                if(Right<size && arr[Right].CompareTo(arr[Max])>0)
                    Max = Right;
                if(Max!=posetion)
                {
                    Swap(ref arr[posetion], ref arr[Max]);
                    Heapfiy(arr, size, Max);
                }
            }
        private static void BuildHeap<T>(T[]arr,int size)where T: IComparable<T>
            {
                for (int i = size / 2 - 1; i >= 0; i--)
                    {
                        Heapfiy(arr, size, i);
                    }
            }
        public static void HeapSort<T>(T[]arr,int size)where T:IComparable<T>
            {
                BuildHeap(arr, size);
                for(int i = size - 1; i >= 0; i--)
                {
                    Swap(ref arr[0], ref arr[i]);
                    Heapfiy(arr, i, 0);
                }
            }
        public static bool LinearSearch<T>(T[]arr,T k)where T : IComparable<T>
        {
            bool flag = false;
            for(int i=0;i<arr.Length;i++)
            {
                if (arr[i].CompareTo(k) == 0)
                {
                    flag = true;
                    break;
                }

            }
            return flag;
        }
        public static bool BinarySearch<T>(T[]arr,T k)where T : IComparable<T>
        {
            int l = 0;int r = arr.Length - 1;
            while (l < r)
            {
                int m = (l + r) / 2;
                if (arr[m].CompareTo(k) == 0)
                    return true;
                if (arr[m].CompareTo(k) > 0)
                    r = m - 1;
                else
                    l= m + 1;
            }
            return false;
        }
        public static bool BinarySearchRecuresve<T>(T[]arr,T k)where T : IComparable<T>
        {
            int l = 0;int r=arr.Length - 1;
            if (l < r)
            {
                int m=(l + r) / 2;
                if (arr[m].CompareTo(k) == 0)
                    return true;
                if (arr[m].CompareTo(k)>0)
                {
                    r= m - 1;
                    return BinarySearch(arr, k);
                }
                else
                {
                    l = m + 1;
                    return BinarySearch(arr, k);
                }
            }
            return false;
        }

    }
}
