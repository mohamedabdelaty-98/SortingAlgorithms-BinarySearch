namespace SortingAlgorithms
{
   
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int[] arr = new int[] { 60, 40, 50, 30, 10, 20 };
            Console.WriteLine("array before Sorting");
            for (int i = 0; i < arr.Length; i++)
                Console.Write($"{arr[i]} ");
            Console.WriteLine("\n................Ending................");
            #region SelectionSort
            //// selection sort
            //SortingAlgortihms.SelectionSort(arr, arr.Length);
            //Console.WriteLine("Selection Sort Output:");
            //for (int i=0; i<arr.Length; i++)
            //    Console.Write($"{arr[i]} ");
            //Console.WriteLine("\n................EndingSelectionSorting................"); 
            #endregion
            #region BubbleSort
            ////bubble sort
            //SortingAlgortihms.BubbleSort(arr, arr.Length);
            //Console.WriteLine("Bubble Sort  Output:");
            //for (int i = 0; i < arr.Length; i++)
            //    Console.Write($"{arr[i]} ");
            //Console.WriteLine("\n................EndingBubbleSorting................");
            ////bubble sort with sorting array
            //int[] arr2 = new int[] { 10, 20, 30, 40, 50, 60 };
            //SortingAlgortihms.BubbleSort(arr2, arr2.Length);
            //Console.WriteLine("Bubble Sort  Output:");
            //for (int i = 0; i < arr2.Length; i++)
            //    Console.Write($"{arr2[i]} ");
            //Console.WriteLine("\n................EndingBubbleSorting................"); 
            #endregion
            #region InsertionSort
            //InsertionSort
            //SortingAlgortihms.InsertionSort(arr, arr.Length);
            //for (int i = 0; i < arr.Length; i++)
            //    Console.Write($"{arr[i]} ");
            //Console.WriteLine("\n................InsertionSort................"); 
            #endregion
            #region MergeSort
            //MergeSort
            //SortingAlgortihms.MergeSort(arr,0,arr.Length-1);
            //for (int i = 0; i < arr.Length; i++)
            //    Console.Write($"{arr[i]} ");
            //Console.WriteLine("\n................MergeSort................"); 
            #endregion
            #region QuieckSort
            ////QuieckSort
            //SortingAlgortihms.QuickSort(arr, 0, arr.Length - 1);
            //for (int i = 0; i < arr.Length; i++)
            //    Console.Write($"{arr[i]} ");
            //Console.WriteLine("\n................QuieckSort................"); 
            #endregion
            #region HeapSort
            ////HeapSort
            //SortingAlgortihms.HeapSort(arr, arr.Length);
            //for (int i = 0; i < arr.Length; i++)
            //    Console.Write($"{arr[i]} ");
            //Console.WriteLine("\n................HeapSort................");  
            #endregion
            #region LinearSearch
            //LinearSearch
            //string result = SortingAlgortihms.LinearSearch(arr, 50) ? "Item Exist" : "Item Not Exist";
            //Console.WriteLine(result);
            //Console.WriteLine("\n................LinearSearch................"); 
            #endregion
            #region BinarySearch
            //BinarySearch
            //int[] arr2 = new int[] { 10,20,30,40,50,60 };
            //string result = SortingAlgortihms.BinarySearch(arr2, 50) ? "Item Exist" : "Item Not Exist";
            //Console.WriteLine(result);
            //Console.WriteLine("\n................BinarySearch................");
            //string result_recuresve = SortingAlgortihms.BinarySearchRecuresve(arr2, 50) ? "Item Exist" : "Item Not Exist";
            //Console.WriteLine(result_recuresve);
            //Console.WriteLine("\n................BinarySearchRecuresve................"); 
            #endregion


        }
    }
}