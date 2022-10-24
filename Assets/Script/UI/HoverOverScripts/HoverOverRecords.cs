using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoverOverRecords : MonoBehaviour , IPointerEnterHandler, IPointerExitHandler
{
    public GameObject _recordsBtn, _recordsBackground;

    public void OnPointerEnter(PointerEventData eventData)
    {
        LeanTween.scale(_recordsBtn, new Vector3(1.1f, 1.1f, 1.1f), 0.01f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.alpha(_recordsBackground.GetComponent<RectTransform>(), 0.9f, 0.1f);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        LeanTween.scale(_recordsBtn, new Vector3(1f, 1f, 1f), 0.01f).setEase(LeanTweenType.easeInElastic);
        LeanTween.alpha(_recordsBackground.GetComponent<RectTransform>(), 0f, 0.1f);
    }
}
