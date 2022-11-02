using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TrackSelectManager : MonoBehaviour
{
    public GameObject _trackoneBtn, _tracktwoBtn, _trackthreeBtn;

    public AudioClip selectSFX;
    public AudioClip bgMusic;

    public void NoSelections() => EventSystem.current.SetSelectedGameObject(null);

    void Start()
    {
        SoundManager.instance.PlayMusic(bgMusic);
        NoSelections();
        EventSystem.current.SetSelectedGameObject(_trackoneBtn);
    }

    public void TrackOneClicked()
    {
        NoSelections();
        SoundManager.instance.PlaySFX(selectSFX);
        SceneManager.LoadScene("Track1");
    }

    public void TrackTwoClicked()
    {
        NoSelections();
        SoundManager.instance.PlaySFX(selectSFX);
        SceneManager.LoadScene("Track2");
    }

    public void TrackThreeClicked()
    {
        NoSelections();
        SoundManager.instance.PlaySFX(selectSFX);
        SceneManager.LoadScene("Track3");
    }

    public void QuitGame() => Application.Quit();

}
