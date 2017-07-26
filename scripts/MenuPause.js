#pragma strict

private var isActive : boolean = false;
var menu_Button : GameObject;

function Update () {
    if(isActive == true)
    {
        menu_Button.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
        Time.timeScale = 0;
    }else {
        menu_Button.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1;
    }
    
    if(Input.GetKeyDown(KeyCode.Escape)){
        RESUME_BUTTON();
    }

}

function RESUME_BUTTON() {
    isActive = !isActive;
}

