using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FinishWhoWantsToBeAMillionaire : MonoBehaviour
{
    #region Variables

    [SerializeField] private TMP_Text _score;
    [SerializeField] private Button _restartButton;

    #endregion

    #region Unity lifecycle

    private void Start()
    {
        _score.text = $"Ваш результат: \n {GameWhoWantsToBeAMillionaire.counter}";
        _restartButton.onClick.AddListener(RestartGame);
    }

    #endregion

    #region Private methods

    private static void RestartGame()
    {
        SceneManager.LoadScene("1_GameScene");
    }

    #endregion
}