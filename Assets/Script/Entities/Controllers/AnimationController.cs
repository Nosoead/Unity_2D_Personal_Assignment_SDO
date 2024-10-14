using UnityEngine;

public interface IAnimationController
{   //private하면 왜 안되지? 없으면 기본 private인데 //공부
    void OnMoveAnimation(Vector2 obj);
}