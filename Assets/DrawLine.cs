using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour
{
    private LineRenderer lineRenderer;
    private float dist;

    private float counter;
    public float LaunchForce = 100;
    public bool canShoot = false;

    public Transform origin;
    public Transform destination;

    public float lineDrawSpeed = 6f;

    public Color JauneOrange;
    public Color Orange;
    public Color OrangeRouge;
    public Color RougeFonce;

    // Player
    public GameObject activePlayer;

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.SetPosition(0, origin.position);

        dist = Vector3.Distance(origin.position, destination.position);
    }

    void Update()
    {

        if (Input.GetKey(KeyCode.Space))
        {
            lineRenderer.enabled = true;
            GameObject.Find("Rouge").GetComponent<PlayerMovement>().speedForce = 0;

            if (GetComponentInParent<PlayerMovement>().transform.localScale.x == -0.8f)
            {
                Vector3 lTemp = GetComponentInParent<PowerBar>().transform.localScale;
                lTemp.x = -1;
                lTemp.y = -1;
                GetComponentInParent<PowerBar>().transform.localScale = lTemp;

                if (Input.GetKey(KeyCode.Q))
                {
                    transform.eulerAngles = new Vector3(0, 0, 180);
                }

                if (transform.eulerAngles.z <= 89) { transform.eulerAngles = new Vector3(0, 0, 90); } // HAUT
                if (transform.eulerAngles.z >= 270 && transform.eulerAngles.z <= 360) { transform.eulerAngles = new Vector3(0, 0, -90); } // BAS

            }

            if (GetComponentInParent<PlayerMovement>().transform.localScale.x == 0.8f)
            {
                Vector3 lTemp = GetComponentInParent<PowerBar>().transform.localScale;
                lTemp.x = 1;
                lTemp.y = 1;
                GetComponentInParent<PowerBar>().transform.localScale = lTemp;

                if (Input.GetKey(KeyCode.D))
                {
                    transform.eulerAngles = new Vector3(0, 0, 0);
                }

                if (transform.eulerAngles.z >= 90 && transform.eulerAngles.z <= 180) { transform.eulerAngles = new Vector3(0, 0, 90); } // HAUT
                if (transform.eulerAngles.z <= 270 && transform.eulerAngles.z >= 180) { transform.eulerAngles = new Vector3(0, 0, -90); } // BAS
            }


            counter += 0.1f / lineDrawSpeed;

            float x = Mathf.Lerp(0, dist, counter);

            Vector3 pointA = origin.position;
            Vector3 pointB = destination.position;

            Vector3 pointAlongLine = x * Vector3.Normalize(pointB - pointA) + pointA;

            lineRenderer.SetPosition(1, pointAlongLine);
            //lineRenderer.widthCurve = ac;
            lineRenderer.numCapVertices = 10;

            if (counter < 0.25f) { lineRenderer.SetColors(Color.yellow, JauneOrange); }
            else if (0.25f < counter && counter < 0.5f) { lineRenderer.SetColors(Color.yellow, Orange); }
            else if (0.5f < counter && counter < 0.75f) { lineRenderer.SetColors(Color.yellow, OrangeRouge); }
            else if (0.75 < counter && counter < 0.9f) { lineRenderer.SetColors(Color.yellow, Color.red); }
            else if (0.9f < counter && counter < 1.0f) { lineRenderer.SetColors(Color.yellow, RougeFonce); }

            if (counter < 0.025f) { lineRenderer.SetWidth(0, 0.05f); LaunchForce = 50; }
            else if (0.025f < counter && counter < 0.05f) { lineRenderer.SetWidth(0, 0.1f); LaunchForce = 50; }
            else if (0.05f < counter && counter < 0.075f) { lineRenderer.SetWidth(0, 0.15f); LaunchForce = 100; }
            else if (0.075f < counter && counter < 0.1f) { lineRenderer.SetWidth(0, 0.2f); LaunchForce = 150; }
            else if (0.1f < counter && counter < 0.125f) { lineRenderer.SetWidth(0, 0.25f); LaunchForce = 200; }
            else if (0.125f < counter && counter < 0.15f) { lineRenderer.SetWidth(0, 0.3f); LaunchForce = 250; }
            else if (0.15f < counter && counter < 0.175f) { lineRenderer.SetWidth(0, 0.35f); LaunchForce = 300; }
            else if (0.175f < counter && counter < 0.2f) { lineRenderer.SetWidth(0, 0.4f); LaunchForce = 350; }
            else if (0.2f < counter && counter < 0.225f) { lineRenderer.SetWidth(0, 0.45f); LaunchForce = 400; }
            else if (0.225f < counter && counter < 0.25f) { lineRenderer.SetWidth(0, 0.5f); LaunchForce = 450; }
            else if (0.25f < counter && counter < 0.275f) { lineRenderer.SetWidth(0, 0.55f); LaunchForce = 500; }
            else if (0.275f < counter && counter < 0.3f) { lineRenderer.SetWidth(0, 0.6f); LaunchForce = 550; }
            else if (0.3f < counter && counter < 0.325f) { lineRenderer.SetWidth(0, 0.65f); LaunchForce = 600; }
            else if (0.325f < counter && counter < 0.350f) { lineRenderer.SetWidth(0, 0.7f); LaunchForce = 650; }
            else if (0.375f < counter && counter < 0.4f) { lineRenderer.SetWidth(0, 0.75f); LaunchForce = 700; }
            else if (0.4f < counter && counter < 0.425f) { lineRenderer.SetWidth(0, 0.8f); LaunchForce = 850; }
            else if (0.425f < counter && counter < 0.45f) { lineRenderer.SetWidth(0, 0.85f); LaunchForce = 900; }
            else if (0.45f < counter && counter < 0.475f) { lineRenderer.SetWidth(0, 0.9f); LaunchForce = 950; }
            else if (0.475f < counter && counter < 0.5f) { lineRenderer.SetWidth(0, 0.95f); LaunchForce = 1000; }
            else if (0.5f < counter && counter < 0.525f) { lineRenderer.SetWidth(0, 1.0f); LaunchForce = 1050; }
            else if (0.525f < counter && counter < 0.55f) { lineRenderer.SetWidth(0, 1.05f); LaunchForce = 1100; }
            else if (0.55f < counter && counter < 0.575f) { lineRenderer.SetWidth(0, 1.1f); LaunchForce = 1150; }
            else if (0.575f < counter && counter < 0.6f) { lineRenderer.SetWidth(0, 1.15f); LaunchForce = 1200; }
            else if (0.6f < counter && counter < 0.625f) { lineRenderer.SetWidth(0, 1.20f); LaunchForce = 1250; }
            else if (0.625f < counter && counter < 0.65f) { lineRenderer.SetWidth(0, 1.25f); LaunchForce = 1300; }
            else if (0.65f < counter && counter < 0.675f) { lineRenderer.SetWidth(0, 1.3f); LaunchForce = 1350; }
            else if (0.675f < counter && counter < 0.7f) { lineRenderer.SetWidth(0, 1.35f); LaunchForce = 1400; }
            else if (0.7f < counter && counter < 0.725f) { lineRenderer.SetWidth(0, 1.4f); LaunchForce = 1450; }
            else if (0.75f < counter && counter < 0.775f) { lineRenderer.SetWidth(0, 1.45f); LaunchForce = 1500; }
            else if (0.775f < counter && counter < 0.8f) { lineRenderer.SetWidth(0, 1.5f); LaunchForce = 1550; }
            else if (0.8f < counter && counter < 0.825f) { lineRenderer.SetWidth(0, 1.55f); LaunchForce = 1600; }
            else if (0.825f < counter && counter < 0.85f) { lineRenderer.SetWidth(0, 1.6f); LaunchForce = 1650; }
            else if (0.8f < counter && counter < 0.85f) { lineRenderer.SetWidth(0, 1.65f); LaunchForce = 1700; }
            else if (0.85f < counter && counter < 0.875f) { lineRenderer.SetWidth(0, 1.7f); LaunchForce = 1750; }
            else if (0.875f < counter && counter < 0.9f) { lineRenderer.SetWidth(0, 1.75f); LaunchForce = 1800; }
            else if (0.9f < counter && counter < 0.925f) { lineRenderer.SetWidth(0, 1.8f); LaunchForce = 1850; }
            else if (0.925f < counter && counter < 0.95f) { lineRenderer.SetWidth(0, 1.85f); LaunchForce = 1900; }
            else if (counter > 0.95) { lineRenderer.SetWidth(0, 1.9f); LaunchForce = 1950; }
        }

        else if (Input.GetKeyUp(KeyCode.Space))
        {
            canShoot = true;
        }

        else
        {
            canShoot = false;
            counter = 0.0f;
            LaunchForce = 0.0f;
            lineRenderer.SetPosition(0, origin.position);
            lineRenderer.enabled = false;
            GameObject.Find("Rouge").GetComponent<PlayerMovement>().speedForce = 4;
        }
    }
}