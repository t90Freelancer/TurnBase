using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour
{
    [SerializeField] private Animator animator;
    public AnimationClip IdleClip;
    public AnimationClip AttackClip;
    public AnimationClip AlertClip;

    public void ApplyAnimationClips(ClipsSO clipSo)
    {
        IdleClip = clipSo.IdleClip;
        AttackClip = clipSo.AttackClip;
        AlertClip = clipSo.AlertClip;

        ChangeStateAnimation("Idle", IdleClip);
        ChangeStateAnimation("Attack", AttackClip);
        ChangeStateAnimation("Alert", AlertClip);
    }

    void ChangeStateAnimation(string stateName, AnimationClip newClip)
    {
        if (animator == null)
        {
            Debug.LogError("Animator is not assigned!");
            return;
        }

        // Lấy ID của trạng thái trong Animator Controller dựa trên tên của trạng thái
        int stateID = Animator.StringToHash(stateName);

        // Lấy thông tin trạng thái từ Animator Controller
        AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);

        // Kiểm tra xem trạng thái hiện tại có trùng với tên trạng thái mà bạn muốn thay đổi không
        if (stateInfo.fullPathHash == stateID)
        {
            // Thực hiện việc thay đổi Animation Clip cho trạng thái hiện tại
            animator.Play(newClip.name, 0, 0); // Play newClip from the beginning
        }
    }

    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.Q)) 
        {
            animator.SetBool("isAttack", true);
        }

        
    }
}
