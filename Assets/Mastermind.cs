using System;
using System.Diagnostics;
using UnityEngine.UI;
using UnityEngine;



public class Mastermind : MonoBehaviour
{
    //Variáveis
    private string secretCode;
    private int num1;
    private int num2;
    private int num3;
    private int num4;
    private int tries = 8;
    private char cr1;
    private char cr2;
    private char cr3;
    private char cr4;
    public Text triesTxt;
    public GameObject Losing;
    public GameObject Win;
    public InputField playerGuess;
    public Text gutTxt;
    private int gutVal = 0;
    String[] CheckChar;
    private string winningcon;
   

    public void Start()
    {
        num1 = UnityEngine.Random.Range(1, 6);
        num2 = UnityEngine.Random.Range(1, 6);
        num3 = UnityEngine.Random.Range(1, 6);
        num4 = UnityEngine.Random.Range(1, 6);
        secretCode = num1.ToString() + num2.ToString() + num3.ToString() + num4.ToString();
        UnityEngine.Debug.Log(secretCode);
        triesTxt.text = tries.ToString();
        
    }
    

    public void playMastermind()
    {
        gutVal = 0;
        CheckChar = playerGuess.text.Split('-');
        UnityEngine.Debug.Log(playerGuess.text);
        UnityEngine.Debug.Log(CheckChar[1]);
        winningcon = CheckChar[0] + CheckChar[1] + CheckChar[2] + CheckChar[3];
        if (tries > 1) { 
          tries--;
          triesTxt.text = tries.ToString();
        }
        else
        {
            Losing.SetActive(true);
        }
        if (secretCode == winningcon)
        {
            Win.SetActive(true);
        }
       
       
            if (CheckChar[0] == num1.ToString())
            {
                gutVal++;
                gutTxt.text = gutVal.ToString();
            }
         if (CheckChar[1] == num2.ToString()) {
                gutVal++;
                gutTxt.text = gutVal.ToString();
            }
          if (CheckChar[2] == num3.ToString()) {
                gutVal++;
                gutTxt.text = gutVal.ToString();
            }
           if (CheckChar[3] == num4.ToString()) {
                gutVal++;
                gutTxt.text = gutVal.ToString();
            }
        
    }
}
