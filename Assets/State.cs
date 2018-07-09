using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{

    [TextArea(10,14)][SerializeField] private string storyText;
    [SerializeField] private State[] nextStates;

    public string GetStoryText()
    {
        return storyText;
    }

    public State[] GetNextStates()
    {
        return nextStates;
    }
}
