using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ImgSucsess : MonoBehaviour
{
    
    public int[] letters;
    public int[] nikud;

    private int letterPress;

    [SerializeField] private TypeNikudButton typeNikudButton;

    [SerializeField] private NikudButtons nikudButtons;

    [SerializeField] private GameManager gameManager;


    //private ListsInList listsInList;

    private void Start()
    {
        //listsInList = GetComponent<ListsInList>();

        letterPress = 0;
    }
    private void Update()
    {
       if (typeNikudButton.IsClicked == true)
       {
            AfterClick();
            typeNikudButton.IsClicked = false;
            
       }
    }
   

    public void AfterClick()
    {
        if (letters[letterPress] == typeNikudButton.IndexButtonCliced && nikud[letterPress] == nikudButtons.IndexNikudCliced)
        {
            Debug.Log("sucsess");
            
            if (letterPress + 2 <= letters.Length)
            {
                letterPress++;
               
            }

            else
            {
                letterPress = 0;
                Debug.Log("sucsess word");
                gameManager.Score += 1;

            }
        }

        else
        {
            Debug.Log("Error");
            gameManager.Health--;
        }

        //listsInList.dictWords.dictWord1.letters 
        //if (letters[letterPress] == typeNikudButton.IndexButtonCliced && nikud[letterPress] == nikudButtons.IndexNikudCliced)
        //{
        //    Debug.Log("sucsess");

        //    if (letterPress + 2 <= letters.Length)
        //    {
        //        letterPress++;

        //    }

        //    else
        //    {
        //        letterPress = 0;
        //        Debug.Log("sucsess word");
        //    }
        //}

        //else
        //{
        //    Debug.Log("Error");
        //}




    }

}





