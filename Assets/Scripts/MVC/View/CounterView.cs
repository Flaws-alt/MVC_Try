using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CounterView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI countText;
    [SerializeField] private Button addButton;

    //初始化
    public void Initialize(Action onClickAddButton)
    {
        addButton.onClick.AddListener(() => onClickAddButton?.Invoke());
    }

    //更新UI文本显示
    public void UpdateCountDisplay(int count)
    {
        countText.text = $"Counts: {count}";
    }
}
