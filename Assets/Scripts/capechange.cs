using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capechange : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "cape")
        {
            anim.SetTrigger("cape");
        }
    }
}
