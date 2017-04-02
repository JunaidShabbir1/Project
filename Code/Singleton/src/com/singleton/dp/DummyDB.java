package com.singleton.dp;

public class DummyDB {

	static DummyDB obj;
	public String name;
	static int counter = 0;
	static int pointer = 0;
	static String arr[] = new String[3];

	private DummyDB(String name) {
		this.name = name;
	}

	public static DummyDB getObj(String name) {
		if(counter < 3)
		{
			obj = new DummyDB(name);
			System.out.println(name);
			arr[pointer] = name;
			pointer++;
			counter++;
		}
		else{
			if(pointer ==3)
			{
				pointer =0;
			}
			System.out.println(arr[pointer]);
			counter++;
			pointer++;
		}
		return obj;
	}
}
