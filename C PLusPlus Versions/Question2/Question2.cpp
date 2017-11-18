// Question2.cpp : Defines the entry point for the console application.
//

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
		cout << ("Play a piano!");
	}
};

class Violinist
{
public:
	void violinPlay()
	{
		cout << ("Play a violin!");
	}
};

class Musician: public Pianist, public Violinist
{
public:
	void sing()
	{
		cout << ("Sing a song!");
	}
};

int _tmain(int argc, _TCHAR* argv[])
{
	return 0;
}

