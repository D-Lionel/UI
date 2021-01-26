using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showHide : MonoBehaviour
{
    public GameObject cube;

    public void Enable()
    {
        cube.SetActive(true);
    }

    public void Disable()
    {
        cube.SetActive(false);
    }
}
