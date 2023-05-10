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
    [SerializeField] Button nextButton;
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
        else
        {
            //Sonraki sahneye animasyonla ge�ilecek
            /*di�er sahnenin kopyas�n� olu�tur bu sefer sa�da paneller gelsin;
             * b�yle hisseden ba�kalar� oldu�unu da g�rmek (yaln�zl�k?)
             * sand���ndan daha de�erli veya i�levli oldu�unu hissetmek?
             * 
             * hayat� tekrar sevmek (onu hayata ba�layan �eylerin tekrar fark�na varmak)
            */

        }
    }
    private IEnumerator TextVisible()
    {
        textMeshPro.ForceMeshUpdate();
        int totalVisibleCharacters = textMeshPro.textInfo.characterCount;
        int counter = 0;
        nextButton.interactable = false;
        while (true) 
        {
            int visibleCount = counter % (totalVisibleCharacters + 1);
            textMeshPro.maxVisibleCharacters = visibleCount;

            if (visibleCount >= totalVisibleCharacters)
            {
                i += 1;
                //Invoke("EndCheck", timeBtwnWords);
                nextButton.interactable = true;
                break;
            }


            counter++;
            yield return new WaitForSeconds(timeBtwnChars);
        }
    }

}//class
