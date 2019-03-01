using UnityEngine;
using UnityEngine.UI;

public class DropShadowText : MonoBehaviour
{
    public Text textToCopy;

    Text ourText;

	// Use this for initialization
	void Start ()
    {
        ourText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (textToCopy)
        {
            ourText.text = textToCopy.text;
        }
	}
}
