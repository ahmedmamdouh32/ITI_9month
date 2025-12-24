#include <iostream>
#include <map>
using namespace std;


int main() {

	map<string, string> station;

	int n, m;
	cin >> n >> m;
	string serverName = "";
	string serverIP = "";
	for (int i = 0; i < n;i++) {
		cin >> serverName;
		cin >> serverIP;
		station[serverIP] = serverName;
	}

	string command = "";

	for (int i = 0; i < m;i++) {
		cin >> command;
		cin >> serverIP;
		serverIP.pop_back(); //to remove the comma
		cout << command << " " << serverIP << "; #" << station[serverIP] << endl;
	}

	return 0;
}