﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

    public Text text;
    private enum States {cell, sheets_0, mirror, lock_0, cell_mirror, sheets_1, lock_1, freedom};
    private States myState;

	// Use this for initialization
	void Start () {
        myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {
        print(myState);
        if (myState == States.cell) {
            state_cell();
        } else if (myState == States.sheets_0) {
            state_sheets_0();
        } else if (myState == States.lock_0) {
            state_lock_0();
        }
    }

    void state_cell() {
        text.text = "You are in a prison cell, and you want to escape. There are " +
                    "some dirty sheets on the bed, a mirror on the wall, and the door " +
                    "is locked from the outside.\n\n" +
                    "Press S to view Sheets, M to view Mirror, L to view Lock";
        if (Input.GetKeyDown(KeyCode.S)) {
            myState = States.sheets_0;
        }
    }

    void state_sheets_0() {
        text.text = "You can't believe you sleep in these things. Surely it's " +
                    "time somebody changed them. The pleasures of prison life " +
                    "I guess!\n\n" +
                    "Press R to Return to roaming your cell";
        if (Input.GetKeyDown(KeyCode.R)) {
            myState = States.cell;
        }
    }

    void state_sheets_1() {
        text.text = "Holding a mirror in your hand doesn't make the sheets look " +
                    "any better.\n\n" +
                    "Press R to Return to roaming your cell";
        if (Input.GetKeyDown(KeyCode.R)) {
            myState = States.cell;
        }
    }

    void state_lock_0() {
        text.text = "This is one of those button locks. You have no idea what the " +
                    "combination is. You wish you could somehow see where the dirty " +
                    "fingerprints were, maybe that would help.\n\n" +
                    "Press R to Return to roaming your cell";
        if (Input.GetKeyDown(KeyCode.R)) {
            myState = States.cell;
        }
    }
}
