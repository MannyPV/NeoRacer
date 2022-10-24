using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoverOverQuit : MonoBehaviour , IPointerEnterHandler, IPointerExitHandler
{
    public GameObject _quitBtn, _quitBackground;

    public void OnPointerEnter(PointerEventData eventData)
    {
        LeanTween.scale(_quitBtn, new Vector3(1.1f, 1.1f, 1.1f), 0.01f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.alpha(_quitBackground.GetComponent<RectTransform>(), 0.9f, 0.1f);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        LeanTween.scale(_quitBtn, new Vector3(1f, 1f, 1f), 0.01f).setEase(LeanTweenType.easeInElastic);        
        LeanTween.alpha(_quitBackground.GetComponent<RectTransform>(), 0f, 0.1f);
    }
}
