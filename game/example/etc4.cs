	

	int money;
	int first;
	string name;
	string item;

	void Awake()
	{
		 if (PlayerPrefs.HasKey("first"))
	        {
	            Load();
	        }
	        else
	        {
	            Save();
	        }

	        SelectItem();
	        BuyItem();
	}

	void Save()
	{
		PlayerPrefs.SetInt("money", 0);
		PlayerPrefs.SetInt("first", 0);
		PlayerPrefs.SetString("name", "0");
		PlayerPrefs.SetString("item", "0");
		PlayerPrefs.Save();
		
		Load();
	}

	void Load(){
		money = PlayerPrefs.GetInt("money");
		name = PlayerPrefs.GetString("name");
		item = PlayerPrefs.GetString("item");
	}
	
	void SelectItem()
	{
		// 장착 확인
		string[] item;
		item = PlayerPrefs.GetString("item").Split(',');

		for (int i = 0; i < item.Length; i++)
		{
		    for (int j = 0; j < Acc.childCount; j++)
		        if (item[i] == Acc.transform.GetChild(j).name)
		        {
		            Acc.transform.GetChild(j).gameObject.SetActive(true);
		        }
		}
	}

	void BuyItem()
	{
		string item = PlayerPrefs.GetString("item");
	        string itemName = accName;
	        item += "," + itemName;
	       
	        PlayerPrefs.SetString("item", acc_string);
	        PlayerPrefs.Save();
	}
