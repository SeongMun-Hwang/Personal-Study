#include <iostream>
#include <string>
#include <queue>
#include<cmath>
#include<algorithm>
using namespace std;

int main() {
    ios::sync_with_stdio(false);
	cin.tie(nullptr);
	int n;
	cin >> n;
	queue<int> q;
	while(n--) {
		string s;
		cin >> s;
		if (s == "push") {
			int n;
			cin >> n;
			q.push(n);
		}
		else if (s == "pop") {
			if (!q.empty()) {
				cout << q.front() << "\n";
				q.pop();
			}
			else {
				cout << "-1\n";
			}
		}
		else if (s == "front") {
			if (!q.empty()) {
				cout << q.front() << "\n";
			}
			else {
				cout << "-1\n";
			}
		}
		else if (s == "back") {
			if (!q.empty()) {
				cout << q.back() << "\n";
			}
			else {
				cout << "-1\n";
			}
		}
		else if (s == "size") {
			cout << q.size() << "\n";
		}
		else if (s == "empty") {
			if (q.empty()) {
				cout << "1\n";
			}
			else {
				cout << "0\n";
			}
		}
	}
	return 0;
}