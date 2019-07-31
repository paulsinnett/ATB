using UnityEngine;
using UnityEngine.UI;

public class CharacterLine : MonoBehaviour
{
	public Image image;
	public Text nameSlot;
	public Slider ATBSlot;

	internal void Highlight(bool highlight)
	{
		Color color = image.color;
		color.a = highlight? 0.5f : 0.0f;
		image.color = color;
	}
}
