using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ShowUI : MonoBehaviour
{
    public CanvasGroup uiCanvasGroup; // 要显示的UI游戏对象的Canvas Group组件

    void Start()
    {
        uiCanvasGroup.alpha = 0; // 在游戏开始时将UI游戏对象设置为透明
        StartCoroutine(ShowUIAfterDelay(10)); // 启动协程
    }

    IEnumerator ShowUIAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay); // 等待指定的秒数
        uiCanvasGroup.alpha = 1; // 显示UI游戏对象
    }
}
