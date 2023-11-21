#include <iostream>
#include <string>
#include <stack>
using namespace std;

int main() {
	string s;
	while (getline(cin, s)) {
		stack<char> x;
		if (s == ".") {
			break;
		}
		for (char c : s) {
			if (c == ']'){
				if (x.empty()){
					x.push('.');
					break;
				}
				else if(x.top()=='[') {
					x.pop();
				}
				else {
					x.push(c);
				}
			}
			else if (c == '[') {
				x.push(c);
			}

			if (c == ')') {
				if (x.empty()) {
					x.push('.');
					break;
				}
				else if(x.top()=='(') {
					x.pop();
				}
				else {
					x.push(c);
				}
			}
			else if (c == '(') {
				x.push(c);
			}
		}
		if (x.empty()) {
			cout << "yes\n";
		}
		else {
			cout << "no\n";
		}
	}
	return 0;
}