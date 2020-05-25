using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToPlay : MonoBehaviour
{
    public void toPlay()
    {

        SceneManager.LoadScene("Play");
    }
}
