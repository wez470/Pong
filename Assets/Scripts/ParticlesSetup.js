#pragma strict

function Start () {
	particleSystem.renderer.sortingLayerName = "Particles";
	particleSystem.renderer.sortingOrder = -1;
	particleSystem.Play();
}