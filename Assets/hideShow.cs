using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hideShow : MonoBehaviour
{
    public void show(GameObject img)
    {
        img.SetActive(true);
    }
    public void hide(GameObject img)
    {
        img.SetActive(false);
    }

}
