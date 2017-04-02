package com.dp.nadra;

public class Person {
	
	private String name;
	private String Phases;
	
	public Person(String newName ,String newPhase){
		
		name=newName;
		Phases = newPhase;
		
	}
	
	public String getPersonName(){ return name; }
	public String getCalcWanted(){ return Phases; }
}
