#include<iostream>
#include<vector>
#include<algorithm>
using namespace std;

int main() {
	int n;
	cin >> n;
	for (int i = 0; i < n; i++) {
		int p, index;
		cin >> p >> index;
		vector<int> score(p);
		for (int j = 0; j < p; j++) {
			int m, f, h;
			cin >> m >> f >> h;
			score[j] = m * 35 + f * 45 + h * 20;
		}
		int check = score[index-1];
		sort(score.begin(), score.end(),greater<int>());
		for (int j = 0; j < p; j++) {
			if (score[j] == check) {
				if (j >= 0 && j < p / 10) {
					cout << "#" << i + 1 << " " << "A+";
					break;
				}
				else if (j >= p / 10 && j < 2 * p / 10) {
					cout << "#" << i + 1 << " " << "A0";
					break;
				}
				else if (j >= 2* p / 10 && j < 3 * p / 10) {
					cout << "#" << i + 1 << " " << "A-";
					break;
				}
				else if (j >= 3 * p / 10 && j < 4 * p / 10) {
					cout << "#" << i + 1 << " " << "B+";
					break;
				}
				else if (j >= 4 * p / 10 && j < 5 * p / 10) {
					cout << "#" << i + 1 << " " << "B0";
					break;
				}
				else if (j >= 5 * p / 10 && j < 6 * p / 10) {
					cout << "#" << i + 1 << " " << "B-";
					break;
				}
				else if (j >= 6 * p / 10 && j < 7 * p / 10) {
					cout << "#" << i + 1 << " " << "C+";
					break;
				}
				else if (j >= 7 * p / 10 && j < 8 * p / 10) {
					cout << "#" << i + 1 << " " << "C0";
					break;
				}
				else if (j >= 8 * p / 10 && j < 9 * p / 10) {
					cout << "#" << i + 1 << " " << "C-";
					break;
				}
				else if (j >= 9 * p / 10 && j < 10 * p / 10) {
					cout << "#" << i + 1 << " " << "D0";
					break;
				}
			}
		}
		cout << "\n";
	}
	return 0;
}