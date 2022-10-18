using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoverOverPlay : MonoBehaviour , IPointerEnterHandler, IPointerExitHandler
{
    public GameObject _playBtn, _playBackground;

    public void OnPointerEnter(PointerEventData eventData)
    {
        LeanTween.scale(_playBtn, new Vector3(1.1f, 1.1f, 1.1f), 0.01f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.alpha(_playBackground.GetComponent<RectTransform>(), 0.9f, 0.1f);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        LeanTween.scale(_playBtn, new Vector3(1f, 1f, 1f), 0.01f).setEase(LeanTweenType.easeInElastic);
        LeanTween.alpha(_playBackground.GetComponent<RectTransform>(), 0f, 0.1f);
    }
}
