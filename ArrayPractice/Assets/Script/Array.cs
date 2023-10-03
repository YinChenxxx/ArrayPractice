using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    public GameObject[] gameObjects;
    
    public int index;


      
    private void Awake()
    {
        
    
        for(int i= 0; i < gameObjects.Length; i++)
        {
            gameObjects[i].SetActive(false);

        }
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
            OpenGameObject(index);
        if (Input.GetKey(KeyCode.S))
            ActiveGameObject(index, true);
    }

    //讚讚
    public void OpenGameObject(int index)
    {
        if (index >= gameObjects.Length)
            return;
        gameObjects[index].SetActive(true);
    }

    
    public void ActiveGameObject(int index,bool active=true)
    {
        if (index <gameObjects.Length)
            gameObjects[index].SetActive(active);
        
    }
}
