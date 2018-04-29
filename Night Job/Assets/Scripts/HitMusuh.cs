using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitMusuh : MonoBehaviour {

	public int tambahSkor;
	private Animator anim;

	private MusuhMove mm;
	private float speed;

    public float delay;
    private float delayCounter;

    private int health = 2;

	private void Awake(){
		anim = GetComponent<Animator>();
		mm = GetComponent<MusuhMove>();
		speed = mm.speed;
	}

	void FixedUpdate(){
		// if (mm.speed == 0) 
		// {
			delayCounter -= Time.deltaTime;
            if (delayCounter <= 0) 
            {
                delayCounter = delay;
                if (mm.speed == 0) 
	                mm.speed = speed;
            }
		// }
	}
	
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Senjata"))
        {
            Destroy(other.gameObject);
        	if (gameObject.name == "musuh-kuat" || gameObject.name == "musuh-kuat(Clone)") 
        	{
    			anim.SetTrigger("hit");
        		mm.speed = 0;
        		health--;
        		if (health == 0) 
        		{
		            SkorManager.tambahSkor(tambahSkor);
        			Destroy(gameObject);
        		}
        	} else {
	            SkorManager.tambahSkor(tambahSkor);
		        Destroy(gameObject);
        	}
        }
    }
}
