using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBoxManager : MonoBehaviour
{
    public GameObject textBox;

    public Text theText;

    public TextAsset textfile;
    public string[] textLines;

    public int currentLine;
    public int endAtLine;

    public CharacterController player;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<CharacterController>();
        if (textfile != null)
        {
            print(textfile);
            textLines = textfile.text.Split('\n');
        }
        if(endAtLine == 0)
        {
            endAtLine = textLines.Length -1;
        }
    }

    private void Update()
    {
        theText.text = textLines[currentLine];

        if (Input.GetKeyDown(KeyCode.Return))
        {
            currentLine += 1;
        }
        if(currentLine > endAtLine)
        {
            textBox.SetActive(false);
        }
    }
}
