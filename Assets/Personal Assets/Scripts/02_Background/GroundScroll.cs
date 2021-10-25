using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScroll : MonoBehaviour
{
	public float scrollcalcu = 1.0f;
	private float scrollSpeed = 0.0f;
	private SpriteRenderer spritescript;

	private bool uiscroll;

	void Awake()
	{

	}

	// Update is called once per frame

	void LateUpdate()
	{
		scrollSpeed += Time.deltaTime * (scrollcalcu * 0.1f);

		if (scrollSpeed >= 0.6f)
		{
			scrollSpeed -= 0.63f;
		}

		GetComponent<SpriteRenderer>().material.mainTextureOffset = new Vector2(scrollSpeed, 0.0f);
	}
}
