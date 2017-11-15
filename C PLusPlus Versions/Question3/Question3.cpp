// Question3.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>

using namespace std;

class Bank
{
	private:
		string name;
	protected:
		string securityInfo;
	public: 
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
	friend void Bank::securityAccess(Bank x){
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

