using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // 新添加的using语句
public class FanHui :  MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        public void OnPointerDown(PointerEventData eventData)
    {
        //按下
        GetComponent<Image>().color = Color.green;
          // 加载第一个场景
        SceneManager.LoadScene("Start Button"); // 将"SceneName1"替换为你的第一个场景的名称
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        //抬起
        GetComponent<Image>().color = Color.white;
        
    }
}
