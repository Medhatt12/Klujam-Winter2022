using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoverAnimationScript : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public RectTransform button;

    public void OnPointerEnter(PointerEventData eventData)
    {
        button.GetComponent<Animator>().Play("Button_On");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        button.GetComponent<Animator>().Play("Button_Off");
    }
}
