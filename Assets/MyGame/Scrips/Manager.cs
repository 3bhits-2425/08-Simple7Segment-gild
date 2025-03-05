using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Manager : MonoBehaviour
{
    private GameObject cube1; //Block links oben
    private GameObject cube2; //Block links unten
    private GameObject cube3; //Block rechts unten
    private GameObject cube4; //Block rechts oben
    private GameObject cube5; //Block mitte oben
    private GameObject cube6; //Block mitte unten
    private GameObject cube7; //Block mitte mittig

    void Start()
    {
        cube1 = GameObject.FindWithTag("Num1");
        cube2 = GameObject.FindWithTag("Num2");
        cube3 = GameObject.FindWithTag("Num3");
        cube4 = GameObject.FindWithTag("Num4");
        cube5 = GameObject.FindWithTag("Num5");
        cube6 = GameObject.FindWithTag("Num6");
        cube7 = GameObject.FindWithTag("Num7");
    }

    private void ResetRotation(string cube, float x, float y, float z)
    {
        GameObject item = GameObject.FindWithTag(cube);
        if (item)
        {
            item.transform.rotation = Quaternion.Euler(x, y, z);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            cube1.transform.rotation = Quaternion.Euler(0.0f, -90.0f, -90.0f);
            cube2.transform.rotation = Quaternion.Euler(0.0f, -90.0f, -90.0f);
            cube5.transform.rotation = Quaternion.Euler(0.0f, 90.0f, -90.0f);
            cube6.transform.rotation = Quaternion.Euler(0.0f, 90.0f, -90.0f);
            cube7.transform.rotation = Quaternion.Euler(0.0f, 90.0f, -90.0f);
        }

        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            ResetRotation("Num1", 0.0f, 0.0f, 0.0f);
            ResetRotation("Num2", 0.0f, 0.0f, 0.0f);
            ResetRotation("Num5", 90.0f, 0.0f, 0.0f);
            ResetRotation("Num6", 90.0f, 0.0f, 0.0f);
            ResetRotation("Num7", 90.0f, 0.0f, 0.0f);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            cube1.transform.rotation = Quaternion.Euler(0.0f, -90.0f, -90.0f);
            cube3.transform.rotation = Quaternion.Euler(0.0f, -90.0f, -90.0f);
        }

        if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            ResetRotation("Num1", 0.0f, 0.0f, 0.0f);
            ResetRotation("Num3", 0.0f, 0.0f, 0.0f);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            cube1.transform.rotation = Quaternion.Euler(0.0f, -90.0f, -90.0f);
            cube2.transform.rotation = Quaternion.Euler(0.0f, -90.0f, -90.0f);
        }

        if (Input.GetKeyUp(KeyCode.Alpha3))
        {
            ResetRotation("Num1", 0.0f, 0.0f, 0.0f);
            ResetRotation("Num2", 0.0f, 0.0f, 0.0f);
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            cube2.transform.rotation = Quaternion.Euler(0.0f, -90.0f, -90.0f);
            cube4.transform.rotation = Quaternion.Euler(0.0f, -90.0f, -90.0f);
            cube5.transform.rotation = Quaternion.Euler(0.0f, -90.0f, -90.0f);
            cube6.transform.rotation = Quaternion.Euler(0.0f, -90.0f, -90.0f);
        }

        if (Input.GetKeyUp(KeyCode.Alpha4))
        {
            ResetRotation("Num2", 0.0f, 0.0f, 0.0f);
            ResetRotation("Num4", 0.0f, 0.0f, 0.0f);
            ResetRotation("Num5", 90.0f, 0.0f, 0.0f);
            ResetRotation("Num6", 90.0f, 0.0f, 0.0f);
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            cube2.transform.rotation = Quaternion.Euler(0.0f, -90.0f, -90.0f);
            cube4.transform.rotation = Quaternion.Euler(0.0f, -90.0f, -90.0f);
        }

        if (Input.GetKeyUp(KeyCode.Alpha5))
        {
            ResetRotation("Num2", 0.0f, 0.0f, 0.0f);
            ResetRotation("Num4", 0.0f, 0.0f, 0.0f);
        }

        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            cube4.transform.rotation = Quaternion.Euler(0.0f, -90.0f, -90.0f);
        }

        if (Input.GetKeyUp(KeyCode.Alpha6))
        {
            ResetRotation("Num4", 0.0f, 0.0f, 0.0f);
        }

        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            cube1.transform.rotation = Quaternion.Euler(0.0f, -90.0f, -90.0f);
            cube2.transform.rotation = Quaternion.Euler(0.0f, -90.0f, -90.0f);
            cube6.transform.rotation = Quaternion.Euler(0.0f, -90.0f, -90.0f);
            cube7.transform.rotation = Quaternion.Euler(0.0f, -90.0f, -90.0f);
        }

        if (Input.GetKeyUp(KeyCode.Alpha7))
        {
            ResetRotation("Num1", 0.0f, 0.0f, 0.0f);
            ResetRotation("Num2", 0.0f, 0.0f, 0.0f);
            ResetRotation("Num6", 90.0f, 0.0f, 0.0f);
            ResetRotation("Num7", 90.0f, 0.0f, 0.0f);
        }

        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            cube2.transform.rotation = Quaternion.Euler(0.0f, -90.0f, -90.0f);
            cube6.transform.rotation = Quaternion.Euler(0.0f, -90.0f, -90.0f);
        }

        if (Input.GetKeyUp(KeyCode.Alpha9))
        {
            ResetRotation("Num2", 0.0f, 0.0f, 0.0f);
            ResetRotation("Num6", 90.0f, 0.0f, 0.0f);
        }

        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            cube7.transform.rotation = Quaternion.Euler(0.0f, -90.0f, -90.0f);
        }

        if (Input.GetKeyUp(KeyCode.Alpha0))
        {
            ResetRotation("Num7", 90.0f, 0.0f, 0.0f);
        }
    }
}