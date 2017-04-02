package com.dp.nadra;

public class Picture implements Chain{
	private Chain nextInChain;
	public void setNextChain(Chain nextChain) {
		
		nextInChain = nextChain;

	}

	public void Check(Person request) {
		if (request.getCalcWanted() == "Pic") {

			System.out.print("Hello, " + request.getPersonName().toString() + "\n" + "Kindly move to Other Area.");

		} else {

			nextInChain.Check(request);

		}
	}
}
