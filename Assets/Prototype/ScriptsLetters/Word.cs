using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Word : MonoBehaviour
{
    //public int[] letter;

    public int level;

    public List<int> numLetter = new List<int>();

    public virtual void SayHello()
    {
        Debug.Log("Hi, i'm word - HI");
    }
}


public class word1 : Word
{
    public word1()
    {
        Debug.Log("Hi, i'm word1 - HI");

        numLetter.Add(0);
        numLetter.Add(1);
        numLetter.Add(2);
        Debug.Log(numLetter);
    }

    public override void SayHello()
    {
        Debug.Log("Hi, word1 - HI");
    }

    public void SayLion()
    {
        Debug.Log("111111");
    }


}

public class Word2 : Word
{

}

//public class Words : Word
//{
//    private Word Word1 = new Word();
//    private Word Word2 = new Word();


//    private void Start()
//    {
//        Word1.level = 1;
//        //Word1.letter = { 2, 0, 3}
//        //Word1.letter = new int [2, 0, 1];
//        //Word1.letter.Add(1, 2);

//        Word1.numLetter.Add(0);
//        Word1.numLetter.Add(1);
//        Word1.numLetter.Add(2);
        
//        //ChangeNums(nums);
//        Debug.Log(Word1.numLetter);

//        Word2.numLetter.Add(1);
//        Word2.numLetter.Add(2);
//        Word2.numLetter.Add(3);

//        Debug.Log(Word2.numLetter);


//    }

//    private void Update()
//    {
//        Debug.Log(Word1.numLetter);
//    }



//}
