using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public Text  NameText;
    public Text Counter;
    public Button PrintName;
    public Button Count;
    public InputField Name;

    public int CountNumber = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetName() {
        NameText.text = Name.text;
    }

    public void CountUP() {
        CountNumber ++;
        Counter.text = CountNumber.ToString();
    }
}
