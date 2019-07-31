using UnityEngine;
using UnityEngine.UI;

public class ActionButton : MonoBehaviour
{
	public ActionMenu menu;
	Button button;

	void Start()
	{
		button = GetComponent<Button>();
		button.onClick.AddListener(() => Select());
	}

	void Select()
	{
		menu.DoAction(name);
	}
}
