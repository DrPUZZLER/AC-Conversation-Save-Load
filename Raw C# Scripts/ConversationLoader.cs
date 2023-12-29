/*
A script made by Dr. Puzzler
NOTE THAT THIS ONLY WORKS IF YOU HAVE ADVENTURE CREATOR INSTALLED
AC Conversation Save/Load
A zzzimple script that allows for you to save your current Adventure Creator conversation, and then start the conversation back up when loading the game.
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AC;
public class ConversationLoader : MonoBehaviour {

    [SerializeField] List<Conversation> conversations;
    [SerializeField] int varID = 0;
    AC.Conversation convo;

    void LoadConv() {
        foreach (Conversation e in conversations) {
            if (LocalVariables.GetPopupValue(varID) == e.gameObject.name) {
                e.TurnOn();
            }
        }
        
    }

    void SaveConv() {
        foreach (Conversation e in conversations) {
            if (e.IsActive(false)) {
                LocalVariables.SetPopupValue(varID, conversations.IndexOf(e));
            }
        }
    }

}
