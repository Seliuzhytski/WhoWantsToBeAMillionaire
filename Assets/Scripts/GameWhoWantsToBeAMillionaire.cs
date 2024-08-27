using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using Button = UnityEngine.UI.Button;
using Image = UnityEngine.UI.Image;

public class GameWhoWantsToBeAMillionaire : MonoBehaviour
{
    #region Variables

    [Header("Картинка:")]
    [SerializeField] private Image _image;

    [Header("Вопрос:")]
    [SerializeField] private TMP_Text _question;

    [FormerlySerializedAs("_answerButton")]
    [Header("Ответы:")]
    [SerializeField] private Button[] _answer;

    [Header("Settings:")]
    [SerializeField] private WhoWantsToBeAMillionaireConfig[] _configDate;
    
    public static int Counter;
    private int _currentLevel;

    #endregion

    #region Unity lifecycle

    private void Start()
    {
        UpdateUi(0);

        for (int i = 0; i < _answer.Length; i++)
        {
            _answer[i].onClick.AddListener(() => UpdateUi(_currentLevel));
        }
    }

    #endregion

    #region Private methods

    private void UpdateUi(int questionNumber)
    {
        _currentLevel = questionNumber;

        if (_currentLevel >= _configDate.Length)
        {
            SceneManager.LoadScene("2_FinishScene");
            return;
        }

        _image.sprite = _configDate[_currentLevel].Sprite;
        _question.text = _configDate[_currentLevel].Question;

        for (int i = 0; i < _answer.Length; i++)
        {
            _answer[i].GetComponentInChildren<TMP_Text>().text = _configDate[_currentLevel].Answers[i];
        }

        _currentLevel++;
    }

    #endregion
}