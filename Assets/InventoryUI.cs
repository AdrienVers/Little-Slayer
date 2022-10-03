using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
	public GameObject Menu;

	void Start()
	{ }

	void Update()
	{
		if (Input.GetButtonDown("Inventory"))
		{
			Menu.SetActive(!Menu.activeSelf);
		}
	}

	void UpdateUI()
	{
		/*
				for (int i = 0; i < slots.Length; i++)
				{
					if (i < inventory.items.Count)
					{
						slots[i].AddItem(inventory.items[i]);
					} 
					else
					{
						slots[i].ClearSlot();
					}
				}
		*/
	}
}


