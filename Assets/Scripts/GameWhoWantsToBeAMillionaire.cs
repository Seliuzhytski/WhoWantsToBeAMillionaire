using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using Button = UnityEngine.UI.Button;
using Image = UnityEngine.UI.Image;

public class GameWhoWantsToBeAMillionaire : MonoBehaviour
{
    #region Variables

    public static int counter;

    [Header("Картинка:")]
    [SerializeField] private Image _image;

    [Header("Вопрос:")]
    [SerializeField] private TMP_Text _question;

    [Header("Ответы:")]
    [SerializeField] private Button[] _answer;

    [Header("Settings:")]
    [SerializeField] private WhoWantsToBeAMillionaireConfig[] _configDate;

    private int _currentLevel;

    #endregion

    #region Unity lifecycle

    private void Start()
    {
        UpdateUi();

        for (int i = 0; i < _answer.Length; i++)
        {
            int index = i;
            _answer[i].onClick.AddListener(() => ShowNextQuestion(index));
        }

        _currentLevel++;
    }

    #endregion

    #region Private methods

    private void ShowNextQuestion(int indexPressButton)
    {
        if (indexPressButton == _configDate[_currentLevel - 1].TrueAnswerIndex)
        {
            counter++;
        }

        if (_currentLevel >= _configDate.Length)
        {
            SceneManager.LoadScene("2_FinishScene");
            return;
        }

        UpdateUi();

        _currentLevel++;
    }

    private void UpdateUi()
    {
        _image.sprite = _configDate[_currentLevel].Sprite;
        _question.text = _configDate[_currentLevel].Question;

        for (int i = 0; i < _answer.Length; i++)
        {
            _answer[i].GetComponentInChildren<TMP_Text>().text = _configDate[_currentLevel].Answers[i];
        }
    }

    #endregion
}