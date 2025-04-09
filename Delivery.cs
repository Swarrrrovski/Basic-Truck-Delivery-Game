using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32 (1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32 (1, 1, 1, 1);
    
    [SerializeField] float destroyDelay = 0.5f;
    bool hasPackage;
    

    SpriteRenderer spriteRenderer;

    void Start() 
    {
        spriteRenderer = GetComponent<SpriteRenderer>();    
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Ouch!");
    }

    void  OnTriggerEnter2D(Collider2D other) {
      int m=0;
      if (other.tag =="Start" && m == 0)  
        {
            Debug.Log("YOUR GAME STARTS NOW!! GOODLUCK :)");
        }
     if (other.tag == "Package" && hasPackage == false)  
     {       m++;
            Debug.Log("$Package{m} picked up");
            hasPackage = true;  
            spriteRenderer.color = hasPackageColor;  
            Destroy(other.gameObject, destroyDelay); 
        }

        
        if (other.tag =="Customer" && hasPackage == true)  
        {
            Debug.Log("Package Delivered");
            hasPackage = false;  
            spriteRenderer.color = noPackageColor;  
        }

        if (m == 5)
        {
          Debug.Log("WINNER WINNER CHICKEN DINNER!!!");
        }
    }
}
