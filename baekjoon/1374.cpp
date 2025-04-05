#include <iostream>
#include <vector>
#include <algorithm>
#include <queue>
using namespace std;


int main() {
	ios::sync_with_stdio(false);
	cin.tie(0);

	int n;
	cin >> n;

	vector<pair<int, int>> lectures;

	for (int i = 0; i < n; i++) {
		int id, start, end;
		cin >> id >> start >> end;
		lectures.push_back({ start, end });
	}
	sort(lectures.begin(), lectures.end());

	priority_queue<int, vector<int>, greater<int>> pq;
	for(auto& lecture : lectures) {
		int start = lecture.first;
		int end = lecture.second;

		if (!pq.empty() && pq.top() <= start) {
			pq.pop();
		}
		pq.push(end);
	}
	cout << pq.size() << "\n";
}