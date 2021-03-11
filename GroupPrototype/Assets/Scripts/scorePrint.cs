using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scorePrint : MonoBehaviour
{

   public Text textObj;



    // Start is called before the first frame update
    void Start()
    {

        textObj = GetComponent<Text>();

        textObj.text= PlayerPrefs.GetInt("Score").ToString();
    }

}
