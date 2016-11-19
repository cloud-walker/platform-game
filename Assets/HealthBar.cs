using UnityEngine;
using System.Collections;

public class HealthBar : MonoBehaviour {
	Rect rect;
	Texture2D texture;
	float barWidth;
	float barHeight = 10f;
	float barX;
	float barY = Screen.height / 12;
	float maxHealth = 100f;

	[Range(0, 100)]
	public float currentHealth;

	void Start() {
		currentHealth = maxHealth;
		barWidth = maxHealth;
		barX = Screen.width - barWidth - (barWidth / 3);
		barY = barHeight + (barWidth / 5);
		rect = new Rect(barX, barY, barWidth, barHeight);
		texture = new Texture2D(1, 1);
		texture.SetPixel(0, 0, Color.red);
		texture.Apply();
	}

	void OnGUI() {
		float ratio = currentHealth / maxHealth;
		rect.width = ratio * barWidth;
		GUI.DrawTexture(rect, texture);
	}
}
