using UnityEngine;

public class ActionMenu : MonoBehaviour
{
	Character character;

	public void OpenMenu(Character character)
	{
		gameObject.SetActive(true);
		this.character = character;
	}

	public void DoAction(string action)
	{
		character.DoAction(action);
		gameObject.SetActive(false);
		character = null;
	}

	public bool IsActive()
	{
		return character != null;
	}
}
