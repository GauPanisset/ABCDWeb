#pragma strict

private var speed = 5;
private var rotateSpeed=0.35;
private var degreeState = 0.0;
private var mustTurnLeft = false;
private var mustTurnRight = false;
private var mustStop = false;
private var goThrough = false;
// 3 first are position, 1 next is size, 4 next are turn authorisation
private var crossRoad :int[,] = new int[10,8];

function Start () {
	initCrossRoads();
}

function Update () {
	if(!mustStop){
		transform.Translate(-Vector3.forward * Time.deltaTime * speed);
	}
	turnLeft();
	turnRight();
}

function getGoThrough(){
	return goThrough;
}

function FixedUpdate(){
	canGoThrough();
	
	var center = gameObject.GetComponent(MeshFilter).sharedMesh.bounds.center;
	var size = gameObject.GetComponent(MeshFilter).sharedMesh.bounds.extents;
	
	var colliders=Physics.OverlapBox(gameObject.transform.position+center, size);
	if(colliders.length >= 1) {
		for each(var collider in colliders){
			if(collider.gameObject.name.Substring(0,4)!='road' && collider.gameObject.name!=gameObject.name){
				//Debug.Log(gameObject.name+'->'+collider.gameObject.name+' -> '+collider.transform.position);
				mustStop = true;
			}
		}
	}
}

function canGoThrough(){
	var center = new Vector3(crossRoad[0,0],crossRoad[0,1],crossRoad[0,2]);
	var size = new Vector3(crossRoad[0,3],crossRoad[0,3],crossRoad[0,3]);
	var colliders : Collider[]=Physics.OverlapBox(center, size);
	var colliders_nbr = 0;
	var in_square = false;
	var someone_go_through=false;
	
	// count other colliders (exlude roads)
	if(colliders.length >= 1) {
		for each(var collider in colliders){
			if(collider.gameObject.name.Substring(0,4)!='road' && collider.gameObject.name!=gameObject.name){
				colliders_nbr++;
				 var cc : car_movement; 
				 cc = collider.GetComponent("car_movement");
				 if(cc.getGoThrough() && !someone_go_through){
					 someone_go_through = true;
				 }
			}
			if(collider.gameObject.name==gameObject.name){
				in_square = true;
			}
		}
	}
	
	if(in_square && !someone_go_through){
		if(!goThrough){ // we did it only the first time we can go through
			var t = Random.Range(4, 8); // max value is excluded
			while(!crossRoad[0,t]){
				t = Random.Range(4, 8); // max value is excluded
			}
			degreeState = 0.0;
			Debug.Log(t);
			if(t==4){
				mustTurnLeft=true;
			}
			if(t==6){
				mustTurnRight=true;
			}
		}
		
		goThrough = true;
		mustStop = false;
	}else if(in_square && someone_go_through){
		mustStop = true;
	}
}

function turnRight(){
	if(degreeState<90 && mustTurnRight && goThrough && !mustStop){
		transform.Rotate(Vector3.up * Time.deltaTime,rotateSpeed*2);
		degreeState+=rotateSpeed*2;
	}
	if(degreeState>=90){
		degreeState = 0.0;
		mustTurnRight=false;
		mustTurnLeft=false;
		Debug.Log(transform.rotation.eulerAngles);
		roundTo45();
	}
}

function turnLeft(){
	if(degreeState<90 && mustTurnLeft && goThrough && !mustStop){
		transform.Rotate(-Vector3.up * Time.deltaTime,rotateSpeed);
		degreeState+=rotateSpeed;
	}
	if(degreeState>=90){
		degreeState = 0.0;
		mustTurnRight=false;
		mustTurnLeft=false;
		Debug.Log(transform.rotation.eulerAngles);
		roundTo45();
	}
}
 
function roundTo45(){
	var n=transform.rotation.eulerAngles.y;
	var r=n%90;
	var t = 0;
	if(r>=23){
		Debug.Log("///"+n+"///" +((n-r)+90));
		t=(n-r)+90;
		transform.Rotate(-Vector3.up * Time.deltaTime,rotateSpeed);
	}else{
		t=n-r;
		Debug.Log("///"+n+"///" +(n-r));
	}
	transform.Rotate(Vector3.up * (n-t));
	Debug.Log("--------"+transform.rotation.eulerAngles.y);
//	if(t!=n){
//		roundTo45();
//	}
}

function initCrossRoads(){
	crossRoad[0,0]=-39;
	crossRoad[0,1]=1;
	crossRoad[0,2]=-5;
	crossRoad[0,3]=8;
	crossRoad[0,4]=1;
	crossRoad[0,5]=1;
	crossRoad[0,6]=1;
	crossRoad[0,7]=1;
}

