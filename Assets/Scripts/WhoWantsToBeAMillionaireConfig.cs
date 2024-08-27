using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = nameof(WhoWantsToBeAMillionaireConfig),
    menuName = "Configs/Game/WhoWantsToBeAMillionaire Config")]
public class WhoWantsToBeAMillionaireConfig : ScriptableObject
{
    #region Variables

    [SerializeField] private Sprite _sprite;
    
    [TextArea(3, 10)]
    [SerializeField] private string _question;

    [SerializeField] private int _trueAnswerIndex;
    [SerializeField] private string[] _answers;

    #endregion

    #region Properties

    public Sprite Sprite => _sprite;
    public int TrueAnswerIndex => _trueAnswerIndex;
    public string[] Answers => _answers;
    public string Question => _question;

    #endregion
}