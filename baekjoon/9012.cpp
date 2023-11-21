#include<iostream>
#include<stack>
#include<string>
using namespace std;

int main() {
	std::ios_base::sync_with_stdio(false);
	cin.tie(NULL);
	int n;
	cin >> n;
	cin.get();
	for (int i = 0; i < n; i++) {
		bool balance = true;
		stack<char> s;
		string line;
		getline(cin, line);
		for (char c : line) {
			if (c == '(') {
				s.push(c);
			}
			else if (c == ')') {
				if (s.empty()) {
					balance = false;
					continue;
				}
				else {
					s.pop();
				}
			}
		}
		if (balance && s.empty()) {
			cout << "YES" << "\n";
		}
		else {
			cout << "NO" << "\n";
		}
	}
}