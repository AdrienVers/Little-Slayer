using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorController : MonoBehaviour
{
    public static CursorController instance;
    public Texture2D redCursor, blueCursor, greenCursor;
    public Texture2D redCursorAir, blueCursorAir;
    public Texture2D redCursorCible, blueCursorCible;

    public bool redCur = false;
    public bool blueCur = false;
    public bool greenCur = false;

    public bool redCurAir = false; 
    public bool blueCurAir = false;

    public bool redCurCible = false;
    public bool blueCurCible = false;


    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void ActivateRedCursor()
    {
        Cursor.SetCursor(redCursor, Vector2.zero, CursorMode.Auto);
        redCur = true;
        blueCur = false;
        greenCur = false;

        redCurAir = false;
        blueCurAir = false;

        redCurCible = false;
        blueCurCible = false;
    }

    public void ActivateBlueCursor()
    {
        Cursor.SetCursor(blueCursor, Vector2.zero, CursorMode.Auto);
        redCur = false;
        blueCur = true;
        greenCur = false;

        redCurAir = false;
        blueCurAir = false;

        redCurCible = false;
        blueCurCible = false;
    }

    public void ActivateGreenCursor()
    {
        Cursor.SetCursor(greenCursor, Vector2.zero, CursorMode.Auto);
        redCur = false;
        blueCur = false;
        greenCur = true;

        redCurAir = false;
        blueCurAir = false;

        redCurCible = false;
        blueCurCible = false;
    }

    public void ActivateRedCursorCible()
    {
        Cursor.SetCursor(redCursorCible, new Vector2(70, 70), CursorMode.Auto);
        redCur = false;
        blueCur = false;
        greenCur = false;

        redCurAir = false;
        blueCurAir = false;

        redCurCible = true;
        blueCurCible = false;
    }

    public void ActivateBlueCursorCible()
    {
        Cursor.SetCursor(blueCursorCible, new Vector2(70, 70), CursorMode.Auto);
        redCur = false;
        blueCur = false;
        greenCur = false;

        redCurAir = false;
        blueCurAir = false;

        redCurCible = false;
        blueCurCible = true;
    }

    public void ActivateRedCursorAir()
    {
        Cursor.SetCursor(redCursorAir, new Vector2(100, 0), CursorMode.Auto);
        redCur = false;
        blueCur = false;
        greenCur = false;

        redCurAir = true;
        blueCurAir = false;

        redCurCible = false;
        blueCurCible = false;
    }


    public void ActivateBlueCursorAir()
    {
        Cursor.SetCursor(blueCursorAir, new Vector2(100,0), CursorMode.Auto);
        redCur = false;
        blueCur = false;
        greenCur = false;

        redCurAir = false;
        blueCurAir = true;

        redCurCible = false;
        blueCurCible = false;
    }
}


