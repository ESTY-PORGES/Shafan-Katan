using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ImgSucsess : MonoBehaviour
{
    
    public int[] letters;
    public int[] nikud;

    //private Dictionary<int, int> dict = new Dictionary<int, int>();

    private int letterPress;

    [SerializeField] private TypeNikudButton typeNikudButton;
    [SerializeField] private NikudButtons nikudButtons;

    private void Start()
    {
        //for (int i = 0; i < letters.Length; i++)
        //{
        //    dict.Add(letters[i], nikud[i]);

        //}

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
            }
        }

        else
        {
            Debug.Log("Error");
        }
    }





}
