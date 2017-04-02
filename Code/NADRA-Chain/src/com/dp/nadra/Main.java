package com.dp.nadra;

public class Main {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Chain chainCalc1 = new Token();
		Chain chainCalc2 = new Token();

		chainCalc1.setNextChain(chainCalc2);

		Person request = new Person("Junaid","Pic");

		chainCalc1.Check(request);
	}

}
