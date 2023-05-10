using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="Yeni Soru",menuName ="Sorular/Soru")]
public class Soru : ScriptableObject
{

    public new string soruNumarasi;
    public string soru;

    public string cevap1;
    public string cevap2;
    public string olumluCevap;



}//class
