using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MainMenuManager : MonoBehaviour
{
    public GameObject _playBtn, _recordsBtn, _settingsBtn, _creditsBtn, _quitBtn, _testBtnOne, _testBtnTwo;

    public void NoSelections() => EventSystem.current.SetSelectedGameObject(null);

    public void AnimationTestOne()
    {
        LeanTween.moveLocal(_playBtn, new Vector3(-1750f, 300f, 0f), 0.8f).setEase(LeanTweenType.easeInCubic);
        LeanTween.moveLocal(_recordsBtn, new Vector3(-1750f, 100f, 0f), 0.75f).setDelay(0.1f).setEase(LeanTweenType.easeInCubic);
        LeanTween.moveLocal(_settingsBtn, new Vector3(-1750f, -100f, 0f), 0.7f).setDelay(0.2f).setEase(LeanTweenType.easeInCubic);
        LeanTween.moveLocal(_creditsBtn, new Vector3(-1750f, -300f, 0f), 0.75f).setDelay(0.1f).setEase(LeanTweenType.easeInCubic);
        LeanTween.moveLocal(_quitBtn, new Vector3(-1750f, -500f, 0f), 0.8f).setEase(LeanTweenType.easeInCubic);
    }

    public void AnimationTestTwo()
    {
        LeanTween.moveLocal(_playBtn, new Vector3(0f, 300f, 0f), 1f).setDelay(0.1f).setEase(LeanTweenType.easeOutCubic);
        LeanTween.moveLocal(_recordsBtn, new Vector3(0f, 100f, 0f), 1f).setDelay(0.2f).setEase(LeanTweenType.easeOutCubic);
        LeanTween.moveLocal(_settingsBtn, new Vector3(0f, -100f, 0f), 1f).setDelay(0.3f).setEase(LeanTweenType.easeOutCubic);
        LeanTween.moveLocal(_creditsBtn, new Vector3(0f, -300f, 0f), 1f).setDelay(0.2f).setEase(LeanTweenType.easeOutCubic);
        LeanTween.moveLocal(_quitBtn, new Vector3(0f, -500f, 0f), 1f).setDelay(0.1f).setEase(LeanTweenType.easeOutCubic);
    }

    public void PlayClicked()
    {
        SceneManager.LoadScene("New Track Oval");
    }

    

    
}
