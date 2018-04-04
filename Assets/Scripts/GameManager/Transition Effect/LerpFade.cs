using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LerpFade : MonoBehaviour 
{
	float duration = 2; // This will be your time in seconds.
	float smoothness = 0.02f; // This will determine the smoothness of the lerp. Smaller values are smoother. Really it's the time between updates.

	public Color white;
	public Color black;
	public Color alpha;

	Color fromColor;
	Color toColor;

	Color currentColor;

	public void Dark(float dur)
	{
		duration = dur;
		fromColor = alpha;
		toColor = black;
		StartCoroutine ("LerpColor");
	}

	public void White(float dur)
	{
		duration = dur;
		fromColor = alpha;
		toColor = white;
		StartCoroutine ("LerpColor");
	}

	public void Light(float dur)
	{
		duration = dur;
		fromColor = black;
		toColor = alpha;

		StartCoroutine ("LerpColor");
	}

	public void Light_white(float dur)
	{
		duration = dur;
		fromColor = white;
		toColor = alpha;

		StartCoroutine ("LerpColor");
	}

	IEnumerator LerpColor()
	{
		this.GetComponent<Image> ().color = fromColor;
		float progress = 0; //This float will serve as the 3rd parameter of the lerp function.
		float increment = smoothness/duration; //The amount of change to apply.
		while(progress < 1)
		{
			currentColor = Color.Lerp(fromColor, toColor, progress);
			progress += increment;
			this.GetComponent<Image> ().color = currentColor;
			yield return new WaitForSeconds(smoothness);
		}
		yield return true;
	}
}