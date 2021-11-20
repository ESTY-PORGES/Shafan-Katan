using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NikudButtons : MonoBehaviour
{
    public Button[] nikud;
    public GameObject[] nikudArrays;
    Dictionary<Button, GameObject> dict = new Dictionary<Button, GameObject>();
    void Start()
    {
        for (int i = 0; i < nikud.Length; i++)
        {
            dict.Add(nikud[i], nikudArrays[i]);
          
            int back = i;
            nikud[i].onClick.AddListener(() => buttonCallBack(nikud[back], nikudArrays[back]));

        }
    }

  
    public void buttonCallBack(Button nikud, GameObject nikudArray) 
    {

        for (int i = 0; i < nikudArrays.Length; i++)
        {
           
            nikudArrays[i].SetActive(false);

            
        }
            nikudArray.SetActive(true);
      
    }
}
