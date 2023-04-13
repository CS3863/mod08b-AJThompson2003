using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UseData : MonoBehaviour
{/**
  * Tutorial link
  * https://github.com/tikonen/blog/tree/master/csvreader
  * */

    List<Dictionary<string, object>> data; 
    public GameObject myCube;//prefab
    int cubeCount; //variable 

    void Awake()
    {

        data = CSVReader.Read("xch4");//xch4 is the name of the csv file 

        for (var i = 0; i < data.Count; i++)
        {
            //name, age, speed, description, is the headers of the database
            print("xch4 " + data[i]["xch4"]  );
        }


    }//end Awake()

    // Use this for initialization
    void Start()
    {
        for (var i = 0; i < data.Count; i++)
        {
            object xch = data[i]["xch4"];//get age data
            gameObject.transform.localScale = new Vector3((float)xch, (float)xch, (float)xch);
            //cubeCount += (int)xch;//convert age data to int and add to cubeCount
            //Debug.Log("cubeCount" +cubeCount);
        }
    }//end Start()

    // Update is called once per frame
    void Update()
    {
        //As long as cube count is not zero, instantiate prefab
        //while (cubeCount > 0)
        {
            //Instantiate(myCube);
            //cubeCount--;
        }
        

    }//end Update()
}