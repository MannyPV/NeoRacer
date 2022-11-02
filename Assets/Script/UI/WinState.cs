using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class WinState : MonoBehaviour
{
    public GameObject _winstateManager, _winstateBackground, _winstateTxt, _returntomenuBtn, _quitBtn;
 
    void Awake()
    {
        EventSystem.current.SetSelectedGameObject(null);

        LeanTween.alpha(_winstateBackground.GetComponent<RectTransform>(), 1f, 1f);
        LeanTween.moveLocal(_returntomenuBtn, new Vector3(0f, 0f, 0f), 1f).setDelay(0.3f).setEase(LeanTweenType.easeInCubic);
        LeanTween.moveLocal(_quitBtn, new Vector3(0f, -120f, 0f), 1f).setDelay(0.4f).setEase(LeanTweenType.easeInCubic);
        LeanTween.scale(_winstateTxt, new Vector3(1f, 1f, 1f), 1f).setDelay(0.8f).setEase(LeanTweenType.easeInCubic).setOnComplete(FreezeTime);

        EventSystem.current.SetSelectedGameObject(_returntomenuBtn);
    }

    void FreezeTime() => Time.timeScale = 0;


    public void ReturntoMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
    }

    public void QuitGame() => Application.Quit();

}
