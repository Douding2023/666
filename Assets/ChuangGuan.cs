using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // 引入UI命名空间

public class ChuangGuan : MonoBehaviour
{
    AudioSource audio;
    public GameObject[] objects; // 你的物体，按照123顺序排列
    public Image[] uiImages; // 对应的UI图片
    private int nextObjectIndex = 0; // 下一个应该碰撞的物体的索引

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // OnTriggerEnter is called when the Collider other enters the trigger
    void OnTriggerEnter(Collider other)
    {
        
        // 如果碰撞的物体是正确的物体
        if (other.gameObject == objects[nextObjectIndex])
        {
            audio.Play();
            // 点亮对应的UI图片
            uiImages[nextObjectIndex].color = Color.green;
            // 准备碰撞下一个物体
            nextObjectIndex++;
        }
    }
}