#include <iostream>
#include <vector>
#include <algorithm>
#include <queue>
using namespace std;

int main() {
	ios::sync_with_stdio(false);
	cin.tie(0);

	while (true) {
		string s;
		cin >> s;
		if (s == "end") break;

		bool isAcceptable = true;
		bool isVowel = false;
		vector<char> vowels;
		vector<char> consonants;
		char prev = ' ';
		for (int i = 0; i < s.size(); i++) {
			if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u') {
				isVowel = true;
				vowels.push_back(s[i]);
				consonants.clear();
				if (vowels.size() > 2) {
					isAcceptable = false;
					break;
				}
			}
			else {
				consonants.push_back(s[i]);
				vowels.clear();
				if (consonants.size() > 2) {
					isAcceptable = false;
					break;
				}
			}

			if (prev == s[i] && !(s[i] == 'e' || s[i] == 'o')) {
				isAcceptable = false;
				break;
			}
			prev = s[i];
		}
		if (isAcceptable && isVowel) {
			cout << "<" << s << ">" << " is acceptable." << '\n';
		}
		else {
			cout << "<" << s << ">" << " is not acceptable." << '\n';
		}
	}
}