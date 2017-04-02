package com.dp.nadra;

import java.util.Random;

public class Token implements Chain {

	Random randomGenerator = new Random();
	int randomInt = randomGenerator.nextInt(100);

	private Chain nextInChain;
	public void setNextChain(Chain nextChain) {
		
		nextInChain = nextChain;

	}

	public void Check(Person request) {
		if (request.getCalcWanted() == "Token") {

			System.out.print("Hello, " + request.getPersonName().toString() + "Your Token Number is : " + randomInt
					+ "\n" + "Kindly move to Photoshot Area.");

		} else {

			nextInChain.Check(request);

		}
	}

}
