using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class anaMenu : MonoBehaviour
{
    [SerializeField] private GameObject anaPanel, oynaPanel, ayarlarPanel;
    public void PlayButton()
    {
        anaPanel.SetActive(false);
        oynaPanel.SetActive(true);
    }
    public void OptionsButton()
    {
        anaPanel.SetActive(false);
        ayarlarPanel.SetActive(true);
    }
    public void BackButton()
    {
        anaPanel.SetActive(true);
        ayarlarPanel.SetActive(false);
    }
    public void QuitButton()
    {
        Application.Quit();
    }




}
