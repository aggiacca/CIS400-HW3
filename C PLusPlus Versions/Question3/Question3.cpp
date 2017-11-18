// Question3.cpp : Defines the entry point for the console application.
//
/*

	Question3
	C++
	Adam Giaccaglia

*/
#include "stdafx.h"
#include <iostream>
#include <string>

using namespace std;

class Bank
{
	friend class Manager;
	private:
		string name;
	protected:
		string securityInfo;
	public: 
		Bank(){
			securityInfo = "High";
		}
		void display(){
			cout <<("This is a bank!");
		}

};

class Manager
{
	
private:
	int id;
public:
	void display()
	{
		cout <<("I am a manager!");
	}
	void securityAccess(Bank x){
		cout <<("Security Information is: " + x.securityInfo);
	}
};

int _tmain(int argc, _TCHAR* argv[])
{
	Bank bank1;
	Manager boss;
	boss.securityAccess(bank1);

	return 0;
}

