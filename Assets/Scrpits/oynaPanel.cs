using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class oynaPanel : MonoBehaviour
{
    [SerializeField] private TMP_InputField adiGir;
    [SerializeField] private TextMeshProUGUI warningText;

    public void AdiGonder()
    {
        if (adiGir.text.Trim() == "")
        {
            warningText.text = "�sim bo� b�rak�lamaz";
        }
        else 
        {
            PlayerPrefs.GetString(adiGir.text);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    
}//class
