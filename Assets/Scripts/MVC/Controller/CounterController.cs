using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterController : MonoBehaviour
{
    [SerializeField] private CounterView counterView;
    private CounterModel counterModel;

    private void Start()
    {
        counterModel = new CounterModel();//new一个model
        counterView.Initialize(OnclickButton);//按下按钮后回调该方法
        counterView.UpdateCountDisplay(counterModel.Count);//初始化UI
        counterModel.OnCountChanged += counterView.UpdateCountDisplay;//OnCounterChanged本身就会传出来一个int值，给UpdateCountDisplay接收
    }
    private void OnDisable()
    {
        // 避免事件重复订阅或内存泄漏
        if (counterModel != null)
            counterModel.OnCountChanged -= counterView.UpdateCountDisplay;
    }

    private void OnclickButton()
    {
        counterModel.AddCount(10);
    }
}
