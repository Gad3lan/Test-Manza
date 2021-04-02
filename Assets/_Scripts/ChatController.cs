using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChatController : MonoBehaviour
{
    public Button sendButton;
    public InputField inputField;
    public TMP_Text chat;
    
    // Start is called before the first frame update
    void Start()
    {
        sendButton.onClick.AddListener(SendMessage);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SendMessage()
    {
        if (inputField.text != "")
        {
            if (Random.value < 0.5)
            {
                chat.text += "<color=green><b>John</b>: ";
                chat.text += inputField.text + "</color>\n\n";
            }
            else
            {
                chat.text += "<color=purple><b>You</b>: ";
                chat.text += inputField.text + "</color>\n\n";
            }

            inputField.text = "";
        }
    }
}
