#include <iostream>
#include <stack>
#include <vector>
#include <string>
#include <limits.h>
#include <algorithm>
#include <list>
using namespace std;

int main() {
	ios::sync_with_stdio(false);
	cin.tie(nullptr);

	list<char> list;
	string str;
	int N;

	cin >> str >> N;
	for (char c : str) {
		list.push_back(c);
	}
	auto cursor = list.end();

	while (N--) {
		char c;
		cin >> c;
		switch (c) {
		case 'L':
			if (cursor != list.begin()){
				cursor--;
			}
			break;
		case 'D':
			if (cursor != list.end()){
				cursor++;
			}
			break;
		case 'B':
			if (cursor != list.begin()) {
				cursor = list.erase(--cursor);
			}
			break;
		case 'P':
			char word;
			cin >> word;
			list.insert(cursor, word);
		}
	}
	for (char c : list) {
		cout << c;
	}

	return 0;
}