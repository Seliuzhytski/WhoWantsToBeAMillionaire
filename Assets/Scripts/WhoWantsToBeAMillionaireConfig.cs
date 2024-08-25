using UnityEngine;

[CreateAssetMenu(fileName = nameof(WhoWantsToBeAMillionaireConfig), menuName = "Configs/Game/WhoWantsToBeAMillionaire Config")]
public class WhoWantsToBeAMillionaireConfig : ScriptableObject
{
    [TextArea(3, 10)]
    [SerializeField] private string _question;

    [SerializeField] private string _trueAnswer;
    [SerializeField] private string[] _falseAnswers;
    
    
}