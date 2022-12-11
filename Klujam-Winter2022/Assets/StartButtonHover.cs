using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class StartButtonHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Vector3 cachedScale;
    // Start is called before the first frame update
    void Start()
    {
        cachedScale = this.GetComponent<RectTransform>().transform.localScale;
        Debug.Log(cachedScale);
    }

   


   

    void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
    {
        this.GetComponent<RectTransform>().transform.localScale = new Vector3(2.2F, 2.2f, 2.2f);
    }

    void IPointerExitHandler.OnPointerExit(PointerEventData eventData)
    {
        this.GetComponent<RectTransform>().transform.localScale = cachedScale;
    }
}
