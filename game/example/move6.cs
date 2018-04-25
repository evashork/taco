
    
    // player handling
    public float accSpeed = 8;
    public float acceleration = 30;//속도
     
    private float accCurrentHoriSpeed;
    private float accTargetHoriSpeed;
    private float accCurrentVerSpeed;
    private float accTargetVerSpeed;
      
    void FixedUpdate() 
    {
        float hori_raw = Input.GetAxisRaw(horizontal);
        float ver_raw = Input.GetAxisRaw(vertical);
     
        accTargetHoriSpeed = hori_raw * accSpeed;
        accCurrentHoriSpeed = IncrementTowards(accCurrentHoriSpeed, accTargetHoriSpeed, acceleration);   //가속도 적용
     
        accTargetVerSpeed = ver_raw * accSpeed;
        accCurrentVerSpeed = IncrementTowards(accCurrentVerSpeed, accTargetVerSpeed, acceleration);   //가속도 적용 
     
        transform.Translate(accCurrentHoriSpeed, accCurrentVerSpeed * -1f, 0);
    }
     
    private float IncrementTowards(float n, float target,  float a)
    {
        if(n == target) {
            return n;
        }
        else {
            float dir = Mathf.Sign(target - n); // must n be increased or decreased to get closer to target
            n += a * Time.deltaTime * dir;
            return (dir == Mathf.Sign(target-n))? n : target; // if n has now passed target then return target, otherwise return n
        }
    }

