using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCursor : MonoBehaviour
{
	public bool menu = false;

	void OnMouseEnter()
	{
		if (GameObject.Find("Rouge").transform.parent == GameObject.Find("Actif").transform)
		{
			CursorController.instance.ActivateRedCursor();
			menu = true;
		}

		if (GameObject.Find("Bleu").transform.parent == GameObject.Find("Actif").transform)
		{
			CursorController.instance.ActivateBlueCursor();
			menu = true;
		}
	}
}
