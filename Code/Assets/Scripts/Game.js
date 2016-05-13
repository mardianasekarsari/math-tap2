#pragma strict

private var hit: RaycastHit;
private var jumlah: int;
private var timer: float=10.0f;
private var lastclick: float;
var textStyle: GUIStyle;
private var angkaA: float;
private var angkaB: float;
private var angkaC: float;
private var roundUpSeconds: int;
private var timerText: String;
private var flag:int;
//public var SoalA: UnityEngine.UI.Text=null;
//public var SoalB: UnityEngine.UI.Text=null;
var styleA : GUIStyle;
var styleB : GUIStyle;
var styleJum : GUIStyle;
var styleC : GUIStyle;
function Start () {
	jumlah = 0;
	//MainGame();
}

function Update () {
	//Touch input control
	var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
	timer = timer - Time.deltaTime;
	if(Input.GetMouseButtonDown(0)){
		print("hit");
		if(Physics.Raycast (ray, hit, Mathf.Infinity)){
			if (hit.collider.tag == "breakable"){
				jumlah++;
				lastclick = timer;
				print(jumlah);
								
			}
		}
	}
	/*if (timer <=0)
	{
		timer=0.0f;
		Destroy(GameObject.Find("Column"));
		Destroy(GameObject.Find("Board"));
		Destroy(GameObject.Find("Operasi"));
	}*/
	/*if (timer>0 && flag==1)
	{
		print ("Musuh Baru");
	}*/
}

/*function MainGame(){
	//random soal
	angkaA = Mathf.Floor(Random.Range(1,10));
	angkaB = Mathf.Floor(Random.Range(1,10-angkaA));
	angkaC = angkaA + angkaB;	
	//set jawaban
}*/

/*function OnGUI(){
	//timer control
	roundUpSeconds = Mathf.CeilToInt(timer);
	timerText = roundUpSeconds.ToString();
	GUI.Label(Rect(10,10,256,64),String.Format("{0}", timerText), textStyle);
	//SoalA.text = angkaA.ToString();
	//SoalB.text = angkaB.ToString();
	
	
	
		if (lastclick-timer<2){
			var jum = jumlah.ToString();
			GUI.Label(Rect(Screen.width/2+8,Screen.height/2+26,100,20),jum, styleJum);	
			var angkaAA = angkaA.ToString();
			GUI.Label(Rect(Screen.width/2-32,Screen.height/3+26,100,20),angkaAA, styleA);
			var angkaBB = angkaB.ToString();
			GUI.Label(Rect(Screen.width/2+18,Screen.height/3+26,100,20),"+"+angkaBB, styleB);		
		}
		else {
			flag = 1;
			Destroy(GameObject.Find("Column"));
			Destroy(GameObject.Find("Board"));
			Destroy(GameObject.Find("Operasi"));
			if (jumlah==angkaC)
			{	
				GUI.Label(Rect(30,10,100,20),"jawaban benar", styleC);
			}
			else{
				GUI.Label(Rect(30,10,100,20),"jawaban salah", styleC);
			}
		}
	
}*/