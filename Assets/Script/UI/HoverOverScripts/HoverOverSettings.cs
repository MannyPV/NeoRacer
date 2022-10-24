using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoverOverSettings : MonoBehaviour , IPointerEnterHandler, IPointerExitHandler
{
    public GameObject _settingsBtn, _settingsBackground;

    public void OnPointerEnter(PointerEventData eventData)
    {
        LeanTween.scale(_settingsBtn, new Vector3(1.1f, 1.1f, 1.1f), 0.01f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.alpha(_settingsBackground.GetComponent<RectTransform>(), 0.9f, 0.1f);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        LeanTween.scale(_settingsBtn, new Vector3(1f, 1f, 1f), 0.01f).setEase(LeanTweenType.easeInElastic);        
        LeanTween.alpha(_settingsBackground.GetComponent<RectTransform>(), 0f, 0.1f);
    }
}
