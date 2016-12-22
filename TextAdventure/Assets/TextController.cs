using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

    public Text text;
    State myState;

    private enum State {
        menu,
        cell,
        mirror,
        sheets_0,
        lock_0,
        mirror_cell,
        sheets_1,
        lock_1,
        freedom
    }

	// Use this for initialization
	void Start () {
        myState = State.menu;
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(myState);
		switch(myState)
        {
            case State.menu:
                state_menu();
                break;
            case State.cell:
                state_cell();
                break;
            case State.lock_0:
                state_lock0();
                break;
            case State.sheets_0:
                state_sheets_0();
                break;
            case State.mirror:
                state_mirror();
                break;
            case State.mirror_cell:
                state_mirror_cell();
                break;
            case State.lock_1:
                state_lock_1();
                break;
            case State.sheets_1:
                state_sheets_1();
                break;
            case State.freedom:
                state_freedom();
                break;
        }
	}

    void state_menu()
    {
        text.text = "Press space to start the game.";

        if (Input.GetKeyDown(KeyCode.Space))
            myState = State.cell;
    }

    void state_cell()
    {
        text.text = "Press S to view Sheets, M to view Mirror, and L to view Lock.";

        if (Input.GetKeyDown(KeyCode.S))
            myState = State.sheets_0;

        if (Input.GetKeyDown(KeyCode.M))
            myState = State.mirror;

        if (Input.GetKeyDown(KeyCode.L))
            myState = State.lock_0;
    }

    void state_mirror()
    {
        text.text = "Press R to Return to cell or T to Take mirror";

        if (Input.GetKeyDown(KeyCode.R))
            myState = State.cell;
        if (Input.GetKeyDown(KeyCode.T))
            myState = State.mirror_cell;
    }

    void state_sheets_0()
    {
        text.text = "Press R to Return to cell";

        if (Input.GetKeyDown(KeyCode.R))
            myState = State.cell;
    }

    void state_lock0()
    {
        text.text = "Press R to Return to cell";

        if (Input.GetKeyDown(KeyCode.R))
            myState = State.cell;
    }

    void state_mirror_cell()
    {
        text.text = "Press S to view Sheets, or L to view Lock.";

        if (Input.GetKeyDown(KeyCode.S))
            myState = State.sheets_1;

        if (Input.GetKeyDown(KeyCode.L))
            myState = State.lock_1;
    }

    void state_sheets_1()
    {
        text.text = "Press R to Return to cell";

        if (Input.GetKeyDown(KeyCode.R))
            myState = State.mirror_cell;
    }

    void state_lock_1()
    {
        text.text = "Press R to Return to cell or O to Open lock";

        if (Input.GetKeyDown(KeyCode.R))
            myState = State.mirror_cell;
        if (Input.GetKeyDown(KeyCode.O))
            myState = State.freedom;
    }

    void state_freedom()
    {
        text.text = "You're free, I guess. Press space to continue.";
    }

}
