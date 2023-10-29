using UnityEngine;
using UnityEngine.UI;

public class ButtonSample : MonoBehaviour
{
    public Text age;
    public InputField inputField;
    private int _a = 0;

    private void Start()
    {
        age.text = "Your age?";
    }

    public void onPress()
    {
        
    }

    public void reatdText()
    {
        if (inputField.text == "")
        {
            age.text = "Enter you age";
        }
        else
        {
            age.text = "Your age: " + inputField.text;
        }
    }
}