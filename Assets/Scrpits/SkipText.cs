using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class SkipText : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI textMeshPro;

    public string[] stringArray;

    [SerializeField] float timeBtwnChars;
    [SerializeField] float timeBtwnWords;
    int i = 0;
    private void Start()
    {
        EndCheck();
    }
    public void EndCheck()
    {
        if (i<= stringArray.Length - 1 )
        {
            textMeshPro.text = stringArray[i];
            StartCoroutine(TextVisible());
        }
    }
    private IEnumerator TextVisible()
    {
        textMeshPro.ForceMeshUpdate();
        int totalVisibleCharacters = textMeshPro.textInfo.characterCount;
        int counter = 0;
        while (true) 
        {
            int visibleCount = counter % (totalVisibleCharacters + 1);
            textMeshPro.maxVisibleCharacters = visibleCount;

            if (visibleCount >= totalVisibleCharacters)
            {
                i += 1;
                //Invoke("EndCheck", timeBtwnWords);
                break;
            }

            counter++;
            yield return new WaitForSeconds(timeBtwnChars);
        }
    }

}//class
