using UnityEngine;

public class Character : MonoBehaviour
{
	public ActionMenu menu;
	public CharacterLine line;
	public int speed = 10;
	float ATB = 0.0f;

	void Start()
	{
		line.nameSlot.text = name;
	}

	void Update()
	{
		ATB += Time.deltaTime * speed;
		line.ATBSlot.value = ATB;
		if (ATB >= 100.0f && !menu.IsActive())
		{
			line.Highlight(true);
			menu.OpenMenu(this);
		}
	}

	public void DoAction(string action)
	{
		Debug.LogFormat("{0} -> {1}", name, action);
		ATB = 0.0f;
		line.Highlight(false);
	}
}
