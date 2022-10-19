using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoverOverRecords : MonoBehaviour , IPointerEnterHandler, IPointerExitHandler
{
    public GameObject _recordsBtn, _recordsBackground, _recordsAddedTxtOne, _recordsAddedTxtTwo;

    public void OnPointerEnter(PointerEventData eventData)
    {
        LeanTween.scale(_recordsBtn, new Vector3(1.1f, 1.1f, 1.1f), 0.01f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.scale(_recordsAddedTxtOne, new Vector3(1f, 1f, 1f), 0.15f).setEase(LeanTweenType.easeOutExpo);
        LeanTween.scale(_recordsAddedTxtTwo, new Vector3(1f, 1f, 1f), 0.15f).setEase(LeanTweenType.easeOutExpo);
        LeanTween.alpha(_recordsBackground.GetComponent<RectTransform>(), 0.9f, 0.1f);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        LeanTween.scale(_recordsAddedTxtOne, new Vector3(1f, 0f, 1f), 0.08f).setEase(LeanTweenType.easeInExpo);
        LeanTween.scale(_recordsAddedTxtTwo, new Vector3(1f, 0f, 1f), 0.08f).setEase(LeanTweenType.easeInExpo);
        LeanTween.scale(_recordsBtn, new Vector3(1f, 1f, 1f), 0.01f).setEase(LeanTweenType.easeInElastic);
        LeanTween.alpha(_recordsBackground.GetComponent<RectTransform>(), 0f, 0.1f);
    }
}
