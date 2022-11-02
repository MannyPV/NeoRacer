using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    public GameObject _playBtn, _settingsBtn, _creditsBtn, _quitBtn, //Main Menu Buttons
    _settingsBackBtn, _creditsBackBtn, // Main Menu Sub Buttons
    _settingsBackground, _creditsBackground, _quitBackground; //Main Menu Backgrounds

    public AudioClip selectSFX;
    public AudioClip welcomeSFX;
    public AudioClip bgMusic;

    public void NoSelections() => EventSystem.current.SetSelectedGameObject(null);

    void Start()
    {
        SoundManager.instance.PlaySFX(welcomeSFX);
        SoundManager.instance.PlayMusic(bgMusic);
        NoSelections();
        EventSystem.current.SetSelectedGameObject(_playBtn);
    }

    public void PlayClicked()
    {
        SoundManager.instance.PlaySFX(selectSFX);
        SceneManager.LoadScene("TrackSelect");
    }

    public void SettingsClicked()
    {
        NoSelections();

        LeanTween.alpha(_settingsBackground.GetComponent<RectTransform>(), 0.5f, 0.8f);

        LeanTween.moveLocal(_playBtn, new Vector3(-1750f, 250f, 0f), 0.7f).setDelay(0.1f).setEase(LeanTweenType.easeInCubic);
        LeanTween.moveLocal(_settingsBtn, new Vector3(-1750f, 50f, 0f), 0.8f).setEase(LeanTweenType.easeInCubic);
        LeanTween.moveLocal(_creditsBtn, new Vector3(-1750f, -150f, 0f), 0.75f).setDelay(0.1f).setEase(LeanTweenType.easeInCubic);
        LeanTween.moveLocal(_quitBtn, new Vector3(-1750f, -350f, 0f), 0.7f).setDelay(0.2f).setEase(LeanTweenType.easeInCubic);

        LeanTween.moveLocal(_settingsBackBtn, new Vector3(-1200f, -500f, 0f), 1f).setDelay(0.5f).setEase(LeanTweenType.easeInCubic);
        EventSystem.current.SetSelectedGameObject(_settingsBackBtn);

        SoundManager.instance.PlaySFX(selectSFX);
    }

    public void SettingsClosed()
    {
        NoSelections();

        LeanTween.alpha(_settingsBackground.GetComponent<RectTransform>(), 0f, 0.8f);

        LeanTween.moveLocal(_settingsBackBtn, new Vector3(-1700f, -500f, 0f), 0.3f).setEase(LeanTweenType.easeInCubic);

        LeanTween.moveLocal(_playBtn, new Vector3(0f, 250f, 0f), 1f).setDelay(0.2f).setEase(LeanTweenType.easeOutCubic);
        LeanTween.moveLocal(_settingsBtn, new Vector3(0f, 50f, 0f), 1f).setDelay(0.1f).setEase(LeanTweenType.easeOutCubic);
        LeanTween.moveLocal(_creditsBtn, new Vector3(0f, -150f, 0f), 1f).setDelay(0.2f).setEase(LeanTweenType.easeOutCubic);
        LeanTween.moveLocal(_quitBtn, new Vector3(0f, -350f, 0f), 1f).setDelay(0.3f).setEase(LeanTweenType.easeOutCubic);

        EventSystem.current.SetSelectedGameObject(_settingsBtn);

        SoundManager.instance.PlaySFX(selectSFX);
    }

    public void CreditsClicked()
    {
        NoSelections();

        LeanTween.alpha(_creditsBackground.GetComponent<RectTransform>(), 0.5f, 0.8f);

        LeanTween.moveLocal(_playBtn, new Vector3(-1750f, 250f, 0f), 0.7f).setDelay(0.2f).setEase(LeanTweenType.easeInCubic);
        LeanTween.moveLocal(_settingsBtn, new Vector3(-1750f, 50f, 0f), 0.8f).setDelay(0.1f).setEase(LeanTweenType.easeInCubic);
        LeanTween.moveLocal(_creditsBtn, new Vector3(-1750f, -150f, 0f), 0.75f).setEase(LeanTweenType.easeInCubic);
        LeanTween.moveLocal(_quitBtn, new Vector3(-1750f, -350f, 0f), 0.7f).setDelay(0.1f).setEase(LeanTweenType.easeInCubic);

        LeanTween.moveLocal(_creditsBackBtn, new Vector3(-1200f, -500f, 0f), 1f).setDelay(0.5f).setEase(LeanTweenType.easeInCubic);
        EventSystem.current.SetSelectedGameObject(_creditsBackBtn);

        SoundManager.instance.PlaySFX(selectSFX);
    }

    public void CreditsClosed()
    {
        NoSelections();

        LeanTween.alpha(_creditsBackground.GetComponent<RectTransform>(), 0f, 0.8f);

        LeanTween.moveLocal(_creditsBackBtn, new Vector3(-1700f, -500f, 0f), 0.3f).setEase(LeanTweenType.easeInCubic);

        LeanTween.moveLocal(_playBtn, new Vector3(0f, 250f, 0f), 1f).setDelay(0.3f).setEase(LeanTweenType.easeOutCubic);
        LeanTween.moveLocal(_settingsBtn, new Vector3(0f, 50f, 0f), 1f).setDelay(0.2f).setEase(LeanTweenType.easeOutCubic);
        LeanTween.moveLocal(_creditsBtn, new Vector3(0f, -150f, 0f), 1f).setDelay(0.1f).setEase(LeanTweenType.easeOutCubic);
        LeanTween.moveLocal(_quitBtn, new Vector3(0f, -350f, 0f), 1f).setDelay(0.2f).setEase(LeanTweenType.easeOutCubic);

        EventSystem.current.SetSelectedGameObject(_creditsBtn);

        SoundManager.instance.PlaySFX(selectSFX);
    }

    public void QuitGame() => Application.Quit();

}
