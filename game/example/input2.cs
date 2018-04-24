    if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit = new RaycastHit();
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray.origin, ray.direction, out hit))
            {
                if (hit.collider != null)
                {
                    // BEAT
                    if (hit.collider.tag == "beat")
                        Jump();
                   
                    if (hit.collider.name == "SHOP")
                        SceneManager.LoadScene("shop");
                    }
                    
                }
            }
        }