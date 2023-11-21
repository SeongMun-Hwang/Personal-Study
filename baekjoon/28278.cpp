#include<iostream>
#include<stack>
using namespace std;

int main() {
	std::ios_base::sync_with_stdio(false);
	cin.tie(NULL);
	int n;
	cin >> n;
	stack<int> _stack;
	for (int i = 0; i < n; i++) {
		int input;
		cin >> input;
		switch (input) {
		case 1:
			int n;
			cin >> n;
			_stack.push(n);
			break;
		case 2:
			if (!_stack.empty()) {
				cout << _stack.top() << "\n";
				_stack.pop();
			}
			else {
				cout << -1 << "\n";
			}
			break;
		case 3:
			cout << _stack.size() << "\n";
			break;
		case 4:
			if (_stack.empty()) {
				cout << 1 << "\n";
			}
			else {
				cout << 0 << "\n";
			}
			break;
		case 5:
			if (!_stack.empty()) {
				cout << _stack.top() << "\n";
			}
			else {
				cout << -1 << "\n";
			}
			break;
		}
	}
}