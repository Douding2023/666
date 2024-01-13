using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        AudioSource audioSource = GetComponent<AudioSource>();
        if (audioSource != null)
        {
            Color randomlySelectedColor = GetRandomColorWithAlpha();
            GetComponent<Renderer>().material.color = randomlySelectedColor;
        }
    }

    // Update is called once per frame
    private Color GetRandomColorWithAlpha()
    {
        float red = Random.Range(0f, 1f); // 随机生成红色通道的值
        float green = Random.Range(0f, 1f); // 随机生成绿色通道的值
        float blue = Random.Range(0f, 1f); // 随机生成蓝色通道的值
        float alpha = Random.Range(0f, 1f); // 随机生成透明通道的值
        return new Color(red, green, blue, alpha); // 返回一个随机生成的颜色
    }
}
