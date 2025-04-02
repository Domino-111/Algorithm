using UnityEngine;

public class QuickSortTest : MonoBehaviour
{
    void Start()
    {
        {
            int[] numbers = new[] { 10, 40, 30, 23, 2, 3, 6, 5 };
            QuickSort.Swap(numbers, 0, 1);
            Debug.Log(numbers[0] + " " + numbers[1]);
        }
    }
}
