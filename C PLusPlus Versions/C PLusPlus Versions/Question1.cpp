// C PLusPlus Versions.cpp : Defines the entry point for the console application.
//


/*

	Question 1 
	C++
	Adam Giaccaglia

*/
#include "stdafx.h"
#include <iostream>
#include <string>

using namespace std;


class Animal
{
private:
	int Leg;

public:
	Animal()
	{
		Leg = 4;
	}
	virtual void talk()
	{
		cout << ("Animals Can't Talk!");
	}
};

class Cow : public Animal
{
public:
	void talk()
	{
		cout << ("Moo!");
	}

};

class Pig : public Animal
{
public:
	void talk()
	{
		cout << ("Grunt!");
	}

};

//public to override default private inheritance
class Snake : public Animal
{
public:

};

int _tmain(int argc, _TCHAR* argv[])
{
	//pointer for dyanmic binding and allocation
	Animal* animals[4];

	animals[0] = new Animal();
	animals[1] = new Cow();
	animals[2] = new Pig();
	animals[3] = new Snake();


	for (int i = 0; i < 4; i++)
	{
		animals[i]->talk();
		cout << endl;
		delete animals[i];
	}
	
	cin.get();
}

