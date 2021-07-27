//Prime Numbers As Simple As Possible
// by Amrk000
#include<iostream>
#include<cmath>
#include<string>
using namespace std;

class Prime {

public:
	bool isPrime(long number) {

		if (number <= 1) return false; // if number equals 0 or 1 or negative it's not prime

		//prefix: ++i is faster than postfix: i++ in C/C++
		for (long i=2 ; i<=sqrt(number) ; ++i) if (number%i == 0) return false;
		
		//in bound: number square root user instead of number can reduce loop runtime by 50%

		return true;
	}

	string printUntil(long bound) {
		string outPut;

		for (long i = 2; i <bound; ++i) if (isPrime(i)) outPut+=to_string(i)+"\n"; //if number is prime add to output string
		
		return outPut;
	}

};

int main() {
	//make program loop for multiple operations
	while (true) {
		Prime myPrimeClass;
		int choice;
		long number;

		cout << "Prime Numbers Program:" << endl;
		cout << "Enter 1 to check number" << endl;
		cout << "Enter 2 to print numbers" << endl;

		cin >> choice;

		switch (choice) {
		case 1:

			cout << "Enter Number: ";
			cin >> number;
			cout << (myPrimeClass.isPrime(number) ? "it's prime" : "not prime") << endl; //check number and print output using inline if
			break;

		case 2:
			cout << "Enter bound (execluded): ";
			cin >> number;
			cout << myPrimeClass.printUntil(number) << endl; //print numbers
			break;

		default:
			cout << "unExpected choice !" << endl;
		}
	}
}