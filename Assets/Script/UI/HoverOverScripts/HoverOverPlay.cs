using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoverOverPlay : MonoBehaviour , IPointerEnterHandler, IPointerExitHandler
{
    public GameObject _playBtn, _playBackground, _playAddedTxtOne, _playAddedTxtTwo;

    public void OnPointerEnter(PointerEventData eventData)
    {
        LeanTween.scale(_playBtn, new Vector3(1.1f, 1.1f, 1.1f), 0.01f).setEase(LeanTweenType.easeOutExpo);
        LeanTween.scale(_playAddedTxtOne, new Vector3(1f, 1f, 1f), 0.15f).setEase(LeanTweenType.easeOutExpo);
        LeanTween.scale(_playAddedTxtTwo, new Vector3(1f, 1f, 1f), 0.15f).setEase(LeanTweenType.easeOutExpo);
        LeanTween.alpha(_playBackground.GetComponent<RectTransform>(), 0.9f, 0.1f);  
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        LeanTween.scale(_playAddedTxtOne, new Vector3(1f, 0f, 1f), 0.08f).setEase(LeanTweenType.easeInExpo);
        LeanTween.scale(_playAddedTxtTwo, new Vector3(1f, 0f, 1f), 0.08f).setEase(LeanTweenType.easeInExpo);
        LeanTween.scale(_playBtn, new Vector3(1f, 1f, 1f), 0.01f).setEase(LeanTweenType.easeInExpo);
        LeanTween.alpha(_playBackground.GetComponent<RectTransform>(), 0f, 0.1f);
    }
}
