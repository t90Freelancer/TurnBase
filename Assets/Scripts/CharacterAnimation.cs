using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour
{
    [SerializeField] private Animator animator;

    public void ApplyAnimationClips(AnimatorOverrideController newAnimator)
    {
        animator.runtimeAnimatorController = newAnimator;
    }
}
