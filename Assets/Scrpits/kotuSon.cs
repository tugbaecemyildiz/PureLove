using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kotuSon : MonoBehaviour
{
    [SerializeField] Animator anim;
    bool isWalk = false;
    private void Start()
    {
        
    }
    private void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime );
        isWalk = true;
        anim.SetBool("isWalk", isWalk);

    }
    /*private IEnumerator SonYurume()
    {
        
        yield return null; 
    }*/
    
}
