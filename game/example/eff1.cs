	

	float fades = 0;
	public TextMesh fadeFont;

	StartCoroutine("FadeOut");

	IEnumerator FadeOut()
	{
		fades = 1.0f;

		yield return new WaitForSeconds(1.0f);

		while (fades >= 0.0f)
		{
			fades -= 0.1f;
			fadeFont.color = new Color(255.0f, 255.0f, 255.0f, fades);
			yield return new WaitForSeconds(0.05f);
		}
	}

	IEnumerator FadeIn()
	{
		fades = 0.5f;

		while (fades <= 1.0f)
		{
			fades += 0.08f;
			fadeFont.color = new Color(255.0f, 255.0f, 255.0f, fades);
			yield return new WaitForSeconds(0.05f);
		}

		StartCoroutine("FadeOut");
	}

