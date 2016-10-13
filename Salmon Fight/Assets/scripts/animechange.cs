using UnityEngine;
using System.Collections;

public class animechange : MonoBehaviour {
    public Animator anim;
    public AudioClip bearroar;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("d"))
        {
            anim.Play("bear walk", -1, 0f);
        }

       
        if(Input.GetMouseButtonDown(0))
        {
            anim.Play("bear attack", -1, 0f);
            GetComponent<AudioClip>();
            
        }
       
    }
}
