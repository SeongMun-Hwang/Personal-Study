#include <iostream>
#include <vector>
#include <cmath>
#include <climits>
#include<algorithm>
#include<numeric>
#include<map>
using namespace std;

bool isPalindrome(const string& s, int l, int r) {
	while (l < r) {
		if (s[l] != s[r]) return false;
		l++;
		r--;
	}
	return true;
}

int check(const string& s) {
	int l = 0, r = s.size() - 1;

	while (l < r) {
		if (s[l] == s[r]) {
			l++; 
			r--;
		}
		else {
			bool skipLeft = isPalindrome(s, l + 1, r);
			bool skipRight = isPalindrome(s, l, r - 1);

			if (skipLeft || skipRight) return 1;
			else return 2;
		}
	}
	return 0;
}


int main() {
	ios::sync_with_stdio(false);
	cin.tie(nullptr);

	int T;
	cin >> T;

	while (T--) {
		string s;
		cin >> s;
		cout << check(s) << "\n";
	}

	return 0;
}
