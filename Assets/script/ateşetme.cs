using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ateşetme : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Sol mouse tuşuna tıklama kontrolü
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                GameObject clickedObject = hit.collider.gameObject;

                // Tıklanan nesnenin "Enemy" tag'ine sahip olup olmadığını kontrol ediyoruz
                if (clickedObject.CompareTag("enemy"))
                {
                    Destroy(clickedObject);
                }
            }
        }   
    }
}

