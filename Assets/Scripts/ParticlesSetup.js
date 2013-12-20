#pragma strict

function Start () {
	particleSystem.renderer.sortingLayerName = "Default";
	particleSystem.renderer.sortingOrder = -1;
	particleSystem.Play();
}