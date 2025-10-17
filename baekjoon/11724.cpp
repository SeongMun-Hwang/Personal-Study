#include <iostream>
#include <stack>
#include <vector>
#include <string>
#include <limits.h>
#include <algorithm>
#include <list>
using namespace std;


void DFS(int node, vector<vector<int>>& graph, vector<bool>& visited) {
	visited[node] = true;
	for (int next : graph[node]) {
		if (!visited[next]) {
			DFS(next, graph, visited);
		}
	}
}

int main() {
	ios::sync_with_stdio(false);
	cin.tie(nullptr);

	int N;
	cin >> N;
	vector<vector<int>> graph(N + 1);
	vector<bool> visited(N + 1, false);

	int M;
	cin >> M;
	while(M--) {
		int begin, end;
		cin >> begin >> end;
		graph[begin].push_back(end);
		graph[end].push_back(begin);
	}

	int cnt = 0;
	for (int i = 1; i <= N; i++) {
		if (!visited[i]) {
			DFS(i, graph, visited);
			cnt++;
		}
	}
	cout << cnt;

	return 0;
}