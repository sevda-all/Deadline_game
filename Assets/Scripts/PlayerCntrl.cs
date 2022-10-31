using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCntrl : MonoBehaviour
{
    public AudioSource AudioSrc;
    [SerializeField]
    private Rigidbody2D _rigidbody;
    [SerializeField]
    private Animator _animator;
    private bool _faceRight = true;
    [SerializeField]
    private Vector3 localScale;
    private float moveX;
    public float speed = 5f;
     
    void Start()
    {
        _rigidbody = GetComponent <Rigidbody2D> ();
        _animator = GetComponent <Animator> ();
        localScale = transform.localScale;
        AudioSrc  = GetComponent<AudioSource> ();
    }
   
    void Update()
    {
        moveX = Input.GetAxisRaw ("Horizontal") * speed;
        
        if (Input.GetButtonDown ("Jump") && _rigidbody.velocity.y == 0)
        {
            _rigidbody.AddForce (Vector2.up * 800f);
        }


        if (Mathf.Abs(moveX) > 0 && _rigidbody.velocity.y == 0)
        {
            _animator.SetBool("isRunning", true);
        } else {
            _animator.SetBool("isRunning", false);
        }  

        if(_rigidbody.velocity.y == 0)
        {
            _animator.SetBool("isJumping", false);
            _animator.SetBool("isFalling", false);
        }

        if(_rigidbody.velocity.y > 0)
        {
            _animator.SetBool("isJumping", true);
        }
         if(_rigidbody.velocity.y < 0)
        {
            _animator.SetBool("isJumping", false);
            _animator.SetBool("isFalling", true);
        }
    }

    private void FixedUpdate()
    {
        _rigidbody.velocity = new Vector2 (moveX, _rigidbody.velocity.y);
    }

    private void LateUpdate()
    {
        if (moveX > 0){
            _faceRight = true;
        }
        else if ( moveX < 0) {
            _faceRight = false;
        }

        if ((_faceRight) && (localScale.x < 0) || (!_faceRight) && (localScale.x > 0)){

            localScale.x *= -1;
        }

        transform.localScale = localScale;
    }

    void OnTriggerEnter2D (Collider2D col)
    {
        if(col.gameObject.tag == "Paper")
           AudioSrc.Play();
        
    }
}

