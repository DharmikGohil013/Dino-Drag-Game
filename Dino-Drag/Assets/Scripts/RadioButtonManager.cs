using UnityEngine;
using UnityEngine.UI;

public class RadioButtonManager : MonoBehaviour
{
    public Toggle option1;  // First radio button
    public Toggle option2;  // Second radio button

    void Start()
    {
      
    }

    public void CheckSelectedOption()
    {
        if (option1.isOn)
        {
            Debug.Log("Option 1 is selected.");
        }
        else if (option2.isOn)
        {
         
            Debug.Log("Option 2 is selected.");
        }
    }
}
