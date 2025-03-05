using UnityEngine;

public class Manager : MonoBehaviour
{
    private GameObject cube;
    private GameObject cube1; //Block links oben
    private GameObject cube2; //Block links unten
    private GameObject cube3; //Block rechts unten
    private GameObject cube4; //Block rechts oben
    private GameObject cube5; //Block mitte oben
    private GameObject cube6; //Block mitte unten
    private GameObject cube7; //Block mitte mitte

    private float rotationSpeed = 100f;
    private bool hasRotated = false;
    private bool isRotating = false;
    private float targetRotation = 0f;

    void Start()
    {
        cube = GameObject.FindWithTag("Par1");
        cube1 = GameObject.FindWithTag("Num1");
        cube2 = GameObject.FindWithTag("Num2");
        cube3 = GameObject.FindWithTag("Num3");
        cube4 = GameObject.FindWithTag("Num4");
        cube5 = GameObject.FindWithTag("Num5");
        cube6 = GameObject.FindWithTag("Num6");
        cube7 = GameObject.FindWithTag("Num7");

        targetRotation = cube.transform.eulerAngles.y; // Setzt Target Roatation auf die aktuelle Y Richtung

        if (cube && cube1 && cube2 && cube3 && cube4 && cube5 && cube6 && cube7 != null)
        {
            Debug.Log("Alle cubes gefunden.");
        }
        else
        {
            Debug.Log("Nicht alle Cubes gefunden.");
        }
    }

    private void ResetColor()
    {
        cube1.GetComponent<Renderer>().material.color = Color.black;
        cube2.GetComponent<Renderer>().material.color = Color.black;
        cube3.GetComponent<Renderer>().material.color = Color.black;
        cube4.GetComponent<Renderer>().material.color = Color.black;
        cube5.GetComponent<Renderer>().material.color = Color.black;
        cube6.GetComponent<Renderer>().material.color = Color.black;
        cube7.GetComponent<Renderer>().material.color = Color.black;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            cube3.GetComponent<Renderer>().material.color = Color.white;
            cube4.GetComponent<Renderer>().material.color = Color.white;
        }

        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            ResetColor();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            cube2.GetComponent<Renderer>().material.color = Color.white;
            cube4.GetComponent<Renderer>().material.color = Color.white;
            cube5.GetComponent<Renderer>().material.color = Color.white;
            cube6.GetComponent<Renderer>().material.color = Color.white;
            cube7.GetComponent<Renderer>().material.color = Color.white;
        }

        if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            ResetColor();
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            cube3.GetComponent<Renderer>().material.color = Color.white;
            cube4.GetComponent<Renderer>().material.color = Color.white;
            cube5.GetComponent<Renderer>().material.color = Color.white;
            cube6.GetComponent<Renderer>().material.color = Color.white;
            cube7.GetComponent<Renderer>().material.color = Color.white;
        }

        if (Input.GetKeyUp(KeyCode.Alpha3))
        {
            ResetColor();
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            cube1.GetComponent<Renderer>().material.color = Color.white;
            cube3.GetComponent<Renderer>().material.color = Color.white;
            cube4.GetComponent<Renderer>().material.color = Color.white;
            cube7.GetComponent<Renderer>().material.color = Color.white;
        }

        if (Input.GetKeyUp(KeyCode.Alpha4))
        {
            ResetColor();
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            cube1.GetComponent<Renderer>().material.color = Color.white;
            cube3.GetComponent<Renderer>().material.color = Color.white;
            cube5.GetComponent<Renderer>().material.color = Color.white;
            cube6.GetComponent<Renderer>().material.color = Color.white;
            cube7.GetComponent<Renderer>().material.color = Color.white;
        }

        if (Input.GetKeyUp(KeyCode.Alpha5))
        {
            ResetColor();
        }

        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            cube1.GetComponent<Renderer>().material.color = Color.white;
            cube2.GetComponent<Renderer>().material.color = Color.white;
            cube3.GetComponent<Renderer>().material.color = Color.white;
            cube5.GetComponent<Renderer>().material.color = Color.white;
            cube6.GetComponent<Renderer>().material.color = Color.white;
            cube7.GetComponent<Renderer>().material.color = Color.white;
        }

        if (Input.GetKeyUp(KeyCode.Alpha6))
        {
            ResetColor();
        }

        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            cube3.GetComponent<Renderer>().material.color = Color.white;
            cube4.GetComponent<Renderer>().material.color = Color.white;
            cube5.GetComponent<Renderer>().material.color = Color.white;
        }

        if (Input.GetKeyUp(KeyCode.Alpha7))
        {
            ResetColor();
        }

        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            cube1.GetComponent<Renderer>().material.color = Color.white;
            cube2.GetComponent<Renderer>().material.color = Color.white;
            cube3.GetComponent<Renderer>().material.color = Color.white;
            cube4.GetComponent<Renderer>().material.color = Color.white;
            cube5.GetComponent<Renderer>().material.color = Color.white;
            cube6.GetComponent<Renderer>().material.color = Color.white;
            cube7.GetComponent<Renderer>().material.color = Color.white;
        }

        if (Input.GetKeyUp(KeyCode.Alpha8))
        {
            ResetColor();
        }

        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            cube1.GetComponent<Renderer>().material.color = Color.white;
            cube3.GetComponent<Renderer>().material.color = Color.white;
            cube4.GetComponent<Renderer>().material.color = Color.white;
            cube5.GetComponent<Renderer>().material.color = Color.white;
            cube6.GetComponent<Renderer>().material.color = Color.white;
            cube7.GetComponent<Renderer>().material.color = Color.white;
        }

        if (Input.GetKeyUp(KeyCode.Alpha9))
        {
            ResetColor();
        }

        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            cube1.GetComponent<Renderer>().material.color = Color.white;
            cube2.GetComponent<Renderer>().material.color = Color.white;
            cube3.GetComponent<Renderer>().material.color = Color.white;
            cube4.GetComponent<Renderer>().material.color = Color.white;
            cube5.GetComponent<Renderer>().material.color = Color.white;
            cube6.GetComponent<Renderer>().material.color = Color.white;
        }

        if (Input.GetKeyUp(KeyCode.Alpha0))
        {
            ResetColor();
        }

        {
            if (!hasRotated && !isRotating && (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha2) ||
                Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Alpha4) ||
                Input.GetKeyDown(KeyCode.Alpha5) || Input.GetKeyDown(KeyCode.Alpha6) ||
                Input.GetKeyDown(KeyCode.Alpha7) || Input.GetKeyDown(KeyCode.Alpha8) ||
                Input.GetKeyDown(KeyCode.Alpha9) || Input.GetKeyDown(KeyCode.Alpha0)))
            {
                targetRotation += 180f;
                isRotating = true;
            }

            if (isRotating)
            {
                float step = rotationSpeed * Time.deltaTime;
                cube.transform.rotation = Quaternion.RotateTowards(cube.transform.rotation, Quaternion.Euler(0, targetRotation, 0), step);

                if (Quaternion.Angle(cube.transform.rotation, Quaternion.Euler(0, targetRotation, 0)) < 0.1f)
                {
                    cube.transform.rotation = Quaternion.Euler(0, targetRotation, 0);
                    isRotating = false;
                    hasRotated = true;
                }
            }
        }
    }   
}