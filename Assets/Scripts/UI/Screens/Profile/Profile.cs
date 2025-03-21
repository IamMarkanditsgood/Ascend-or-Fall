using System.Collections;
using UnityEngine;

public class Profile : MonoBehaviour
{
    [SerializeField] private ProfileButtonsManager _profileButtonsManager;
    [SerializeField] private PlayerManager _playerManager;
    [SerializeField] private PlayerAchievements _playerAchievements;

    [SerializeField] private Home _home;
    [SerializeField] private Info _infoScreen;
    [SerializeField] private BasePopup _profileEditor;

    [SerializeField] private GameObject _view;
    public void Start()
    {
        _profileButtonsManager.Init(this, _infoScreen,_home, _profileEditor);
        _profileButtonsManager.Subscribe();

    }
    private void OnDestroy()
    {
        _profileButtonsManager.Unsubscribe();
    }

    public void Show()
    {
        _playerManager.SetPlayer();
        _playerAchievements.SetAchievements();
        _view.SetActive(true);
    }
    public void Hide()
    {
        _view.SetActive(false);
    }
}
