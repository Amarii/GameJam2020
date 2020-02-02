using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextImporter : MonoBehaviour
{

    public TextAsset textfile;
    public string[] textLines;

    // Start is called before the first frame update
    void Start()
    {
        if(textfile != null)
        {
            print(textfile);
            textLines = textfile.text.Split('\n');
        }
    }

}
