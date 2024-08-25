using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartWhoWantsToBeAMillionaire : MonoBehaviour
{
    #region Variables

    [SerializeField] private Button _startButton;

    #endregion

    #region Unity lifecycle

    private void Start()
    {
        _startButton.onClick.AddListener(StartGame);
    }

    #endregion

    #region Private methods

    private void StartGame()
    {
        SceneManager.LoadScene("1_GameScene");
    }

    #endregion
}