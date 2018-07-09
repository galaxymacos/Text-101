using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{

	[SerializeField] public Text textComponent;

	[SerializeField] public State startingState;

	private State state;
	// Use this for initialization
	void Start ()
	{
		state = startingState;
		textComponent.text = state.GetStoryText();
	}
	
	// Update is called once per frame
	void Update ()
	{
		ManageState();
	}

	private void ManageState()
	{
		var nextStates = state.GetNextStates();
		if (Input.GetKeyDown(KeyCode.A))
		{
			state = nextStates[0];
			textComponent.text = state.GetStoryText();

		}
		else if (Input.GetKeyDown(KeyCode.B))
		{
			state = nextStates[1];
			textComponent.text = state.GetStoryText();
		}
	}
}
