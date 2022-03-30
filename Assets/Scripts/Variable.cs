using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Himmelsrichtungen
{
    Nord,
    Sued,
    West,
    Ost
}


public class Variable : MonoBehaviour

    Color farbe;
    int anztueren
    bool fahren;
    string name;
    int brot;
    int butter;
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Himmelsrichtungen.Nord + "" + Himmelsrichtungen.Sued + "" + Himmelsrichtungen.West + "" + Himmelsrichtungen.Ost);

        farbe = Color.red;
        Debug.Log("red" + farbe.ToString());

        farbe = Color.yellow;
        Debug.Log("yellow" + farbe.ToString());

        farbe = Color.white;
        Debug.Log("white" + farbe.ToString());

        Debug.Log(x.ToString());
        Debug.Log(anzTuerenInstanz.ToString());
        Debug.Log(fahren.ToString());

        int anzTueren = int.Parse("4");
        float anzTueren = float.Parse("4");

        Debug.Log(anzTueren + "" + anzTueren + "" + anzTuerenInstanz);

        //Beispiel1
        name = "brot";
        Debug.Log("Hello" + name);


        //Beispiel2
        anzTueren = 6;
        brot = 4;
        butter = 1;
        Debug.Log(anzTueren + brot + butter);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
