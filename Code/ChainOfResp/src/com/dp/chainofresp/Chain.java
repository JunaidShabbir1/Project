package com.dp.chainofresp;

public interface Chain {
	
	public void setNextChain(Chain nextChain);
	public void calculate(Numbers request);
	
}
