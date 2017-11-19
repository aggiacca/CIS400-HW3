// Question2.cpp : Defines the entry point for the console application.
//

/*
	Question 2
	C++
	Adam Giaccaglia
*/

#include "stdafx.h"
#include <iostream>
#include <string>

using namespace std;

class Pianist
{
//protected to allow pianist to inherit
protected:
	string name;
public:
	Pianist(string x)
	{
		name = x;
	}
 void pianoPlay(){
	 cout << ("Play a piano!") << endl;
	}
};

class Violinist
{
public:
	void violinPlay()
	{
		cout << ("Play a violin!") << endl;
	}
};

class Musician: public Pianist, public Violinist
{
public:
	Musician(string str) :Pianist(str), Violinist(){

	}
	void sing()
	{
		cout << ("Sing a song!") << endl;
	}
};

int _tmain(int argc, _TCHAR* argv[])
{
	
	Musician * guy = new Musician("Bob");
	guy->sing();
	guy->pianoPlay();
	guy->violinPlay();
	
	return 0;
}

