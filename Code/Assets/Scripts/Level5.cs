using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using MyScore;

public class Level5 : MonoBehaviour {
	float timeLeft;
	float lastclick;
	float anA, anB, anC;
	int jumlah=0;
	int i;
	int nyawa= 4;
	int flag = 1;
	int flagjawab = 0;
	int sisaMusuh = 11;
	float x;
	float y;
	Vector2 v;
	private RaycastHit hit ;
	public Text angkaA;
	public Text angkaB;
	public Text text;
	private Text Click;
	private Button Enter;
	private Text SisaMusuh;
	private Text Heart;
	private Text Lose;
	private Text Pass;
	private Text Score;
	private Text Operasi;
	private GameObject T;
	public GameObject TurretPrefab;
	private SphereCollider m_collider;
	public Button musuh;
	
	Score nilai = new Score();
	
	// Use this for initialization
	void Start () {
		/*v = new Vector2(TurretPrefab.transform.position.x,TurretPrefab.transform.position.y);
		Debug.Log (v);
		GameObject T = Instantiate(TurretPrefab,v,Quaternion.identity) as GameObject;
		m_collider = T.gameObject.AddComponent<SphereCollider> ();
		m_collider.center = new Vector3(0, 0, 0);
		m_collider.radius = 1.0f;*/
		
		text = text.GetComponent<Text> ();
		SisaMusuh = GameObject.Find("SisaMusuh").GetComponent<Text> ();
		Heart = GameObject.Find("Heart").GetComponent<Text> ();
		Lose = GameObject.Find("Lose").GetComponent<Text> ();
		Pass = GameObject.Find("Pass").GetComponent<Text> ();
		Score = GameObject.Find("Score").GetComponent<Text> ();
		
		Score.text = "Score: 0" ;
		Lose.enabled = false;
		Pass.enabled = false;
		
	}
	
	void RandomNumber(){
		anA = Mathf.Floor(Random.Range(1,10));
		anB = Mathf.Floor(Random.Range(1,anA));
		anC = anA * anB;
	}
	public void Close(){
		Application.LoadLevel ("StartPage");
	}
	void RandomPos(){
		x = Mathf.Floor (Random.Range (-170, 100));
		y = Mathf.Floor (Random.Range(-20,70));
	}
	
	IEnumerator stop(){
		yield return new WaitForSeconds (1);
		Destroy (T);
		timeLeft = 0;
	}
	
	public void EnterClick(){
		Debug.Log (jumlah + " " + anC);
		if (jumlah == anC) {
			Click.text = "Jawaban Benar";
			nilai.setScore(nilai.getScore()+10);
			Score.text = "Score:" + nilai.getScore();
			StartCoroutine(stop ());
			
			flagjawab = 1;
		} else {
			Click.text = "Jawaban Salah";
			nyawa--;
			StartCoroutine(stop ());
			flagjawab = 1;
		} 
		if (nyawa == 0) {
			Lose.enabled = true;
			Destroy (T);
			flag = 0;
		}
	}
	
	public void ObjectClick(){
		jumlah++;
		Click.text = jumlah.ToString();
		
		//Debug.Log (jumlah);
		//print (jumlah);
	}
	// Update is called once per frame
	void Update () {
		
		CreatePrefab ();
	}	
	
	void CreatePrefab(){
		/*for (i=0; i<10; i++)
		{*/
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		
		if(Input.GetMouseButtonDown(0)){
			if(Physics.Raycast(ray, out hit, Mathf.Infinity)){
				//print ("hit");
				if (hit.collider.tag == "breakable"){
					jumlah++;
					lastclick = timeLeft;
					print(jumlah);
				}
			}
		}
		if(flag==1)
			timeLeft -= Time.deltaTime;
		
		text.text = "Time Left:" + Mathf.Round(timeLeft);
		SisaMusuh.text = "Sisa Musuh: " + sisaMusuh.ToString ();
		Heart.text = "Heart: " + nyawa.ToString ();
		
		if (sisaMusuh == 0) {
			Destroy(T);
			flag = 0;
			Pass.enabled = true;
		}
		if(timeLeft <= 0 && flag==1 && sisaMusuh>0)
		{
			text.text = "Waktu Habis";
			
			RandomNumber ();	
			
			jumlah = 0;
			RandomPos();
			v = new Vector2(TurretPrefab.transform.position.x,TurretPrefab.transform.position.y);
			v.x=x;
			v.y=y;
			
			Debug.Log (v);
			T = Instantiate(TurretPrefab,v,Quaternion.identity) as GameObject;
			Debug.Log(flagjawab);
			
			musuh = T.GetComponentInChildren<Button>();
			Enter = GameObject.Find("Enter").GetComponent<Button>();
			musuh.onClick.AddListener(ObjectClick);
			Enter.onClick.AddListener(EnterClick);
			angkaA = GameObject.Find("AngkaA").GetComponent<Text> ();
			angkaB = GameObject.Find("AngkaB").GetComponent<Text> ();
			Click = GameObject.Find("Click").GetComponent<Text> ();
			Operasi = GameObject.Find("Operasi").GetComponent<Text> ();
			Operasi.text = "x";
			angkaA.text = anA.ToString ();
			angkaB.text = anB.ToString ();
			Click.text = jumlah.ToString();
			
			Destroy (T, 9.9f);
			if (flagjawab==0)
			{
				Debug.Log("minus nyawa");
				nyawa--;
				if (nyawa == 0) {
					Lose.enabled = true;
					Destroy (T);
					flag = 0;
				}
			}
			sisaMusuh--;
			flagjawab = 0;
			timeLeft = 10.0f;
		}
		
		/*if (lastclick - timeLeft >= 2) {
				if (jumlah==anC){
					text.text = "Jawaban Benar";
				}
				else{
					text.text = "Jawaban Salah";
				}
			} */
		//}
	}
}

