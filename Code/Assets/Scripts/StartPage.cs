using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StartPage : MonoBehaviour {
	public Canvas CreditDetail;
	public Canvas QuitMenu;
	public Canvas SettingDetail;
	public Canvas Level;
	public Button Play;
	public Button Exit;
	public Button Credit;
	public Button Setting;


	// Use this for initialization
	void Start () {

		//CreditDetail = CreditDetail.GetComponent<Canvas> ();
		QuitMenu = QuitMenu.GetComponent<Canvas> ();
		CreditDetail = GameObject.Find("CreditDetail").GetComponent<Canvas>();
		SettingDetail = GameObject.Find("SettingDetail").GetComponent<Canvas>();
		Level = GameObject.Find("Level").GetComponent<Canvas>();
		Play = Play.GetComponent<Button> ();
		Exit = Exit.GetComponent<Button> ();
		Credit = GameObject.Find("Credit").GetComponent<Button> ();
		Setting = GameObject.Find("Setting").GetComponent<Button> ();
		QuitMenu.enabled = false;
		CreditDetail.enabled = false;
		SettingDetail.enabled = false;
		Level.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ExitPress(){
		QuitMenu.enabled = true;
		Play.enabled = false;
		Exit.enabled = false;
		Credit.enabled = false;
		Setting.enabled = false;
	}
	
	public void NoPress(){
		QuitMenu.enabled = false;
		Play.enabled = true;
		Exit.enabled = true;
		Credit.enabled = true;
		Setting.enabled = true;
	}
	
	public void ExitGame(){
		Application.Quit ();
	}

	public void creditPress(){
		CreditDetail.enabled = true;
		Play.enabled = false;
		Exit.enabled = false;
		Credit.enabled = false;
		Setting.enabled = false;
	}

	public void settingPress(){
		SettingDetail.enabled = true;
		Play.enabled = false;
		Exit.enabled = false;
		Credit.enabled = false;
		Setting.enabled = false;
	}

	public void closePress(){
		CreditDetail.enabled = false;
		SettingDetail.enabled = false;
		Level.enabled = false;
		Level.enabled = false;
		Play.enabled = true;
		Exit.enabled = true;
		Credit.enabled = true;
		Setting.enabled = true;
	}

	public void playPress(){
		Level.enabled = true;
		Play.enabled = false;
		Exit.enabled = false;
		Credit.enabled = false;
		Setting.enabled = false;
	}

	public void LoadScene (string name){
		Application.LoadLevel (name);
	}
	
}
