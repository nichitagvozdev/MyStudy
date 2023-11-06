using System;
using UnityEngine;

public class Homework : MonoBehaviour
{
    //EX 1
    // private void Start()
    // {
    //     int[] nums = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
    //         
    //     for (int i = 0; i <= nums.Length -1; i++)
    //     {
    //         if (nums[i] % 2 == 0)
    //         {
    //             Debug.Log(nums[i]);
    //         }
    //     }
    // }

    //EX2
    // private void Start()
    // {
    //     var a = 0;
    //     var b = 1;
    //     
    //     for(var i = 0; i < 10; i++)
    //     {
    //         b = 1;
    //         a++;
    //         for (var j = 0; j < 10; j++)
    //         {
    //             var c = a * b;
    //             Debug.Log($"{a} * {b} = {c}");
    //             Debug.Log("___________________________");
    //             b++;
    //         }
    //     }
    // }
    
    //EX3
    void Start()
    {
        // Replace this value with the desired integer n
        int n = 1;
        long factorial = CalculateFactorial(n);
        Debug.Log($"Factorial of a number {n} equals {factorial}");
    }
    
    long CalculateFactorial(int n)
    {
        if (n < 0)
        {
            throw new ArgumentException("Factorial is defined only for non-negative integers..");
        }
    
        if (n == 0 || n == 1)
        {
            return 1;
        }
    
        long result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }
    
        return result;
    }
} 
