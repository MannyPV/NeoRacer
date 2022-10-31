using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    public GameObject _playBtn, _recordsBtn, _settingsBtn, _creditsBtn, _quitBtn, //Main Menu Buttons
    _recordsBackBtn, _settingsBackBtn, _creditsBackBtn, _quitBackBtn, _quitConfirmBtn, // Main Menu Sub Buttons
    _recordsBackground, _settingsBackground, _creditsBackground, _quitBackground; //Main Menu Backgrounds


    public void NoSelections() => EventSystem.current.SetSelectedGameObject(null);

    void Start()
    {
        NoSelections();
        EventSystem.current.SetSelectedGameObject(_playBtn);
    }

    public void PlayClicked()
    {
        SceneManager.LoadScene("New Track Oval");
    }

    public void RecordsClicked()
    {
        NoSelections();

        LeanTween.alpha(_recordsBackground.GetComponent<RectTransform>(), 0.5f, 0.8f);

        LeanTween.moveLocal(_playBtn, new Vector3(-1750f, 300f, 0f), 0.7f).setDelay(0.1f).setEase(LeanTweenType.easeInCubic);
        LeanTween.moveLocal(_recordsBtn, new Vector3(-1750f, 100f, 0f), 0.75f).setEase(LeanTweenType.easeInCubic);
        LeanTween.moveLocal(_settingsBtn, new Vector3(-1750f, -100f, 0f), 0.8f).setDelay(0.1f).setEase(LeanTweenType.easeInCubic);
        LeanTween.moveLocal(_creditsBtn, new Vector3(-1750f, -300f, 0f), 0.75f).setDelay(0.2f).setEase(LeanTweenType.easeInCubic);
        LeanTween.moveLocal(_quitBtn, new Vector3(-1750f, -500f, 0f), 0.7f).setDelay(0.3f).setEase(LeanTweenType.easeInCubic);

        LeanTween.moveLocal(_recordsBackBtn, new Vector3(-1200f, -500f, 0f), 1f).setDelay(0.5f).setEase(LeanTweenType.easeInCubic);
        EventSystem.current.SetSelectedGameObject(_recordsBackBtn);
    }

    public void RecordsClosed()
    {
        NoSelections();

        LeanTween.alpha(_recordsBackground.GetComponent<RectTransform>(), 0f, 0.8f);

        LeanTween.moveLocal(_recordsBackBtn, new Vector3(-1700f, -500f, 0f), 0.3f).setEase(LeanTweenType.easeInCubic);

        LeanTween.moveLocal(_playBtn, new Vector3(0f, 300f, 0f), 1f).setDelay(0.2f).setEase(LeanTweenType.easeOutCubic);
        LeanTween.moveLocal(_recordsBtn, new Vector3(0f, 100f, 0f), 1f).setDelay(0.1f).setEase(LeanTweenType.easeOutCubic);
        LeanTween.moveLocal(_settingsBtn, new Vector3(0f, -100f, 0f), 1f).setDelay(0.2f).setEase(LeanTweenType.easeOutCubic);
        LeanTween.moveLocal(_creditsBtn, new Vector3(0f, -300f, 0f), 1f).setDelay(0.3f).setEase(LeanTweenType.easeOutCubic);
        LeanTween.moveLocal(_quitBtn, new Vector3(0f, -500f, 0f), 1f).setDelay(0.4f).setEase(LeanTweenType.easeOutCubic);

        EventSystem.current.SetSelectedGameObject(_recordsBtn);
    }

    public void SettingsClicked()
    {
        NoSelections();

        LeanTween.alpha(_settingsBackground.GetComponent<RectTransform>(), 0.5f, 0.8f);

        LeanTween.moveLocal(_playBtn, new Vector3(-1750f, 300f, 0f), 0.7f).setDelay(0.2f).setEase(LeanTweenType.easeInCubic);
        LeanTween.moveLocal(_recordsBtn, new Vector3(-1750f, 100f, 0f), 0.75f).setDelay(0.1f).setEase(LeanTweenType.easeInCubic);
        LeanTween.moveLocal(_settingsBtn, new Vector3(-1750f, -100f, 0f), 0.8f).setEase(LeanTweenType.easeInCubic);
        LeanTween.moveLocal(_creditsBtn, new Vector3(-1750f, -300f, 0f), 0.75f).setDelay(0.1f).setEase(LeanTweenType.easeInCubic);
        LeanTween.moveLocal(_quitBtn, new Vector3(-1750f, -500f, 0f), 0.7f).setDelay(0.2f).setEase(LeanTweenType.easeInCubic);

        LeanTween.moveLocal(_settingsBackBtn, new Vector3(-1200f, -500f, 0f), 1f).setDelay(0.5f).setEase(LeanTweenType.easeInCubic);
        EventSystem.current.SetSelectedGameObject(_settingsBackBtn);
    }

    public void SettingsClosed()
    {
        NoSelections();

        LeanTween.alpha(_settingsBackground.GetComponent<RectTransform>(), 0f, 0.8f);

        LeanTween.moveLocal(_settingsBackBtn, new Vector3(-1700f, -500f, 0f), 0.3f).setEase(LeanTweenType.easeInCubic);

        LeanTween.moveLocal(_playBtn, new Vector3(0f, 300f, 0f), 1f).setDelay(0.3f).setEase(LeanTweenType.easeOutCubic);
        LeanTween.moveLocal(_recordsBtn, new Vector3(0f, 100f, 0f), 1f).setDelay(0.2f).setEase(LeanTweenType.easeOutCubic);
        LeanTween.moveLocal(_settingsBtn, new Vector3(0f, -100f, 0f), 1f).setDelay(0.1f).setEase(LeanTweenType.easeOutCubic);
        LeanTween.moveLocal(_creditsBtn, new Vector3(0f, -300f, 0f), 1f).setDelay(0.2f).setEase(LeanTweenType.easeOutCubic);
        LeanTween.moveLocal(_quitBtn, new Vector3(0f, -500f, 0f), 1f).setDelay(0.3f).setEase(LeanTweenType.easeOutCubic);

        EventSystem.current.SetSelectedGameObject(_settingsBtn);
    }

    public void CreditsClicked()
    {
        NoSelections();

        LeanTween.alpha(_creditsBackground.GetComponent<RectTransform>(), 0.5f, 0.8f);


        LeanTween.moveLocal(_playBtn, new Vector3(-1750f, 300f, 0f), 0.7f).setDelay(0.3f).setEase(LeanTweenType.easeInCubic);
        LeanTween.moveLocal(_recordsBtn, new Vector3(-1750f, 100f, 0f), 0.75f).setDelay(0.2f).setEase(LeanTweenType.easeInCubic);
        LeanTween.moveLocal(_settingsBtn, new Vector3(-1750f, -100f, 0f), 0.8f).setDelay(0.1f).setEase(LeanTweenType.easeInCubic);
        LeanTween.moveLocal(_creditsBtn, new Vector3(-1750f, -300f, 0f), 0.75f).setEase(LeanTweenType.easeInCubic);
        LeanTween.moveLocal(_quitBtn, new Vector3(-1750f, -500f, 0f), 0.7f).setDelay(0.1f).setEase(LeanTweenType.easeInCubic);

        LeanTween.moveLocal(_creditsBackBtn, new Vector3(-1200f, -500f, 0f), 1f).setDelay(0.5f).setEase(LeanTweenType.easeInCubic);
        EventSystem.current.SetSelectedGameObject(_creditsBackBtn);
    }

    public void CreditsClosed()
    {
        NoSelections();

        LeanTween.alpha(_creditsBackground.GetComponent<RectTransform>(), 0f, 0.8f);

        LeanTween.moveLocal(_creditsBackBtn, new Vector3(-1700f, -500f, 0f), 0.3f).setEase(LeanTweenType.easeInCubic);

        LeanTween.moveLocal(_playBtn, new Vector3(0f, 300f, 0f), 1f).setDelay(0.4f).setEase(LeanTweenType.easeOutCubic);
        LeanTween.moveLocal(_recordsBtn, new Vector3(0f, 100f, 0f), 1f).setDelay(0.3f).setEase(LeanTweenType.easeOutCubic);
        LeanTween.moveLocal(_settingsBtn, new Vector3(0f, -100f, 0f), 1f).setDelay(0.2f).setEase(LeanTweenType.easeOutCubic);
        LeanTween.moveLocal(_creditsBtn, new Vector3(0f, -300f, 0f), 1f).setDelay(0.1f).setEase(LeanTweenType.easeOutCubic);
        LeanTween.moveLocal(_quitBtn, new Vector3(0f, -500f, 0f), 1f).setDelay(0.2f).setEase(LeanTweenType.easeOutCubic);

        EventSystem.current.SetSelectedGameObject(_creditsBtn);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    

    
}
