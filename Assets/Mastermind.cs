using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mastermind : MonoBehaviour
{
  public Text triesTxt;
    private int tries = 8;
  public void PlayMastermind()
    {
        tries--;
        triesTxt.text = tries.ToString();

    }
}
