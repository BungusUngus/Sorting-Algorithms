using UnityEngine;
using System.Diagnostics;
using Debug = UnityEngine.Debug;
using System;
using Random = UnityEngine.Random;

public class SearchTest : MonoBehaviour
{
    int[] numbers = new int[5000000];
    int target = 50;

    private void Start()
    {
        Search search = new BruteForceSearch();
        Search search2 = new BinarySearch();


        
        for (int x = 0; x < numbers.Length; x++)
        {
            numbers[x] = Random.Range(0, numbers.Length);
        }
        numbers[Random.Range(0, numbers.Length)] = target;
        Array.Sort(numbers);

        //numbers[Random.Range(0, numbers.Length)] = target;

        Stopwatch stopWatch = new Stopwatch();
        int loopAmount = 1000000;

        stopWatch.Start();
        for (int x = 0; x < loopAmount; x++)
        {
            search.Find(numbers, target);
        }
        stopWatch.Stop();

        print(stopWatch.ElapsedMilliseconds);
    }
}
