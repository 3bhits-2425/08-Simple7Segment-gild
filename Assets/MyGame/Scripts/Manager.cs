using Palmmedia.ReportGenerator.Core.Reporting.Builders;
using UnityEngine;

public class Manager : MonoBehaviour
{
    private GameObject cube;
    private GameObject cube1, cube2, cube3, cube4, cube5, cube6, cube7;
    private float rotationSpeed = 100f;
    private bool hasRotated = false;
    private bool isRotating = false;
    private float targetRotation = 0f;
    private int lastPressedNumber = -1;

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
        targetRotation = cube.transform.eulerAngles.y;
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

    private void SetNumberColor(int number)
    {
        ResetColor();
        switch (number)
        {
            case 1:
                cube3.GetComponent<Renderer>().material.color = Color.white;
                cube4.GetComponent<Renderer>().material.color = Color.white;
                Debug.Log($"Zahl {lastPressedNumber} gedrückt");
                break;
            case 2:
                cube2.GetComponent<Renderer>().material.color = Color.white;
                cube4.GetComponent<Renderer>().material.color = Color.white;
                cube5.GetComponent<Renderer>().material.color = Color.white;
                cube6.GetComponent<Renderer>().material.color = Color.white;
                cube7.GetComponent<Renderer>().material.color = Color.white;
                Debug.Log($"Zahl {lastPressedNumber} gedrückt");
                break;
            case 3:
                cube3.GetComponent<Renderer>().material.color = Color.white;
                cube4.GetComponent<Renderer>().material.color = Color.white;
                cube5.GetComponent<Renderer>().material.color = Color.white;
                cube6.GetComponent<Renderer>().material.color = Color.white;
                cube7.GetComponent<Renderer>().material.color = Color.white;
                Debug.Log($"Zahl {lastPressedNumber} gedrückt");
                break;
            case 4:
                cube1.GetComponent<Renderer>().material.color = Color.white;
                cube3.GetComponent<Renderer>().material.color = Color.white;
                cube4.GetComponent<Renderer>().material.color = Color.white;
                cube7.GetComponent<Renderer>().material.color = Color.white;
                Debug.Log($"Zahl {lastPressedNumber} gedrückt");
                break;
            case 5:
                cube1.GetComponent<Renderer>().material.color = Color.white;
                cube3.GetComponent<Renderer>().material.color = Color.white;
                cube5.GetComponent<Renderer>().material.color = Color.white;
                cube6.GetComponent<Renderer>().material.color = Color.white;
                cube7.GetComponent<Renderer>().material.color = Color.white;
                Debug.Log($"Zahl {lastPressedNumber} gedrückt");
                break;
            case 6:
                cube1.GetComponent<Renderer>().material.color = Color.white;
                cube2.GetComponent<Renderer>().material.color = Color.white;
                cube3.GetComponent<Renderer>().material.color = Color.white;
                cube5.GetComponent<Renderer>().material.color = Color.white;
                cube6.GetComponent<Renderer>().material.color = Color.white;
                cube7.GetComponent<Renderer>().material.color = Color.white;
                Debug.Log($"Zahl {lastPressedNumber} gedrückt");
                break;
            case 7:
                cube3.GetComponent<Renderer>().material.color = Color.white;
                cube4.GetComponent<Renderer>().material.color = Color.white;
                cube5.GetComponent<Renderer>().material.color = Color.white;
                Debug.Log($"Zahl {lastPressedNumber} gedrückt");
                break;
            case 8:
                cube1.GetComponent<Renderer>().material.color = Color.white;
                cube2.GetComponent<Renderer>().material.color = Color.white;
                cube3.GetComponent<Renderer>().material.color = Color.white;
                cube4.GetComponent<Renderer>().material.color = Color.white;
                cube5.GetComponent<Renderer>().material.color = Color.white;
                cube6.GetComponent<Renderer>().material.color = Color.white;
                cube7.GetComponent<Renderer>().material.color = Color.white;
                Debug.Log($"Zahl {lastPressedNumber} gedrückt");
                break;
            case 9:
                cube1.GetComponent<Renderer>().material.color = Color.white;
                cube3.GetComponent<Renderer>().material.color = Color.white;
                cube4.GetComponent<Renderer>().material.color = Color.white;
                cube5.GetComponent<Renderer>().material.color = Color.white;
                cube6.GetComponent<Renderer>().material.color = Color.white;
                cube7.GetComponent<Renderer>().material.color = Color.white;
                Debug.Log($"Zahl {lastPressedNumber} gedrückt");
                break;
            case 0:
                cube1.GetComponent<Renderer>().material.color = Color.white;
                cube2.GetComponent<Renderer>().material.color = Color.white;
                cube3.GetComponent<Renderer>().material.color = Color.white;
                cube4.GetComponent<Renderer>().material.color = Color.white;
                cube5.GetComponent<Renderer>().material.color = Color.white;
                cube6.GetComponent<Renderer>().material.color = Color.white;
                Debug.Log($"Zahl {lastPressedNumber} gedrückt");
                break;
        }
    }

    private void Update()
    {
        for (int i = 0; i <= 9; i++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha0 + i))
            {
                if (lastPressedNumber != i)
                {
                    lastPressedNumber = i;
                    SetNumberColor(i);
                }
                if (!hasRotated)
                {
                    targetRotation += 180f;
                    isRotating = true;
                    hasRotated = true;
                }
            }
        }

        if (isRotating)
        {
            float step = rotationSpeed * Time.deltaTime;
            cube.transform.rotation = Quaternion.RotateTowards(cube.transform.rotation, Quaternion.Euler(0, targetRotation, 0), step);
            if (Quaternion.Angle(cube.transform.rotation, Quaternion.Euler(0, targetRotation, 0)) < 0.1f)
            {
                cube.transform.rotation = Quaternion.Euler(0, targetRotation, 0);
                isRotating = false;
            }
        }
    }
}
