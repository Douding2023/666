using UnityEngine;
using UnityEngine.Playables;

public class TimelineController : MonoBehaviour
{
public GameObject introObject; // 开场动画的游戏对象
    public PlayableDirector director; // 控制开场动画的PlayableDirector

    void Start()
    {
        introObject.SetActive(true); // 在游戏开始时激活游戏对象
        director.Play(); // 播放开场动画
    }

    void Update()
    {
        if (Time.time >= 10f) // 如果游戏时间过去了5秒
        {
            director.Stop(); // 停止播放开场动画
            introObject.SetActive(false); // 禁用游戏对象
       
        }
    }
}