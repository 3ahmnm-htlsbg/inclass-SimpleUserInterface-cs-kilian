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
 
    public void SetName() {
        NameText.text = Name.text;
    }

    public void CountUP() {
        CountNumber ++;
        Counter.text = CountNumber.ToString();
    }
}
