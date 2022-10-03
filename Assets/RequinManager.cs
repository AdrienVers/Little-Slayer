using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RequinManager : MonoBehaviour
{

    public bool available = false;
    public bool veille = false;

    //Vector3 newPosition = Vector3.zero;
    //Ray ray;
    //RaycastHit hit;

    public GameObject Requin;

    //public GameObject Menu;

    public void Start()
    {
        available = true;
    }

    public void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.Space))
        {
            available = true;

            if (GameObject.Find("Rouge").transform.parent == GameObject.Find("Actif").transform)
            {
                CursorController.instance.ActivateRedCursorAir();
            }

            if (GameObject.Find("Bleu").transform.parent == GameObject.Find("Actif").transform)
            {
                CursorController.instance.ActivateBlueCursorAir();
            }
        }
        */

        if (GameObject.Find("Menu") != null)
        {
            if (GameObject.Find("Menu").GetComponent<MenuCursor>().menu == true)
            {
                veille = true;
                available = false;
            }
        }

        else if (GameObject.Find("Menu") == null)
        {
            //veille = false;
            //available = true;

            if (Input.GetMouseButtonDown(0))
            {
                if (available == true)
                {
                    Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    Instantiate(Requin, new Vector3(cursorPos.x, cursorPos.y - 90, 0), Quaternion.identity);
                    available = false;
                }

                veille = true;
            }

        }

        if (veille == false)
        {
            if (GameObject.Find("Rouge").transform.parent == GameObject.Find("Actif").transform)
            {
                CursorController.instance.ActivateRedCursorCible();
            }

            if (GameObject.Find("Bleu").transform.parent == GameObject.Find("Actif").transform)
            {
                CursorController.instance.ActivateBlueCursorCible();
            }
        }

        if (available == false)
        {
            if (GameObject.Find("Rouge").transform.parent == GameObject.Find("Actif").transform)
            {
                CursorController.instance.ActivateRedCursor();
            }

            if (GameObject.Find("Bleu").transform.parent == GameObject.Find("Actif").transform)
            {
                CursorController.instance.ActivateBlueCursor();
            }
        }


        /*
        if (Input.GetMouseButtonDown(0))
        {
            if (available == true)
            {
                 
                ray = Camera.main.ScreenPointToRay(Input.mousePosition); 
                
                if (Physics.Raycast(ray, out hit)) // Rajouter LayerMask
                {
                    //Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    Instantiate(Pot, hit.point, Quaternion.identity);
                    available = false;
                }
            }
        }
        */

    }
}