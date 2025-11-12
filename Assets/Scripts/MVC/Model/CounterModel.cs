using System;
using System.ComponentModel;
using Unity.Collections;
using UnityEditor.Rendering;
using UnityEngine;

public class CounterModel
{
    private int count = 0;
    public event Action<int> OnCountChanged;
    public int Count => count;//暴露给外界，但不可修改，只读

    public void AddCount(int value)
    {
        count += value;
        OnCountChanged?.Invoke(count);
    }
}
