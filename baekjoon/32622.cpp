#include <iostream>
#include <vector>
#include <cmath>
#include <climits>
#include<algorithm>
#include<string>
using namespace std;

int main() {
	ios::sync_with_stdio(false);
	cin.tie(nullptr);

	int N;
	cin >> N;

	vector<int> cards(N);
	for (int i = 0; i < N; i++) cin >> cards[i];

	vector<int> lengths;
	vector<int> wb;

	int count = 1;
	for (int i = 0; i < N-1; i++) {
		if (cards[i] == cards[i+1]) count++;
		else {
			lengths.push_back(count);
			wb.push_back(cards[i]);
			count = 1;
		}
	}
	lengths.push_back(count);
	wb.push_back(cards[N - 1]);
	
	int max_num = 0;
	for (int length : lengths) max_num = max(length, max_num);

	for (int i = 0; i < lengths.size()-1; i++) {
		if (wb[i] != wb[i + 1]) {
			int length = lengths[i] + lengths[i + 1];
			max_num = max(length, max_num);
		}
	}
	cout << max_num;

	return 0;
}
