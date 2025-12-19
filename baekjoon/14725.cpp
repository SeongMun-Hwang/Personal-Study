#include <iostream>
#include <vector>
#include <algorithm>
#include <map>
using namespace std;

struct Node {
	map<string, Node*> child;
};
Node* root = new Node();

void insert(vector<string>& graph) {
	Node* cur = root;
	for (auto& node : graph) {
		if (cur->child.count(node) == 0) {
			cur->child[node] = new Node();
		}
		cur = cur->child[node];
	}
}
void print(Node* node, int depth) {
	for (auto& a : node -> child) {
		for (int i = 0; i < depth; i++) {
			cout << "--";
		}
		cout << a.first << "\n";
		print(a.second, depth + 1);
	}
}

int main() {
	ios::sync_with_stdio(false);
	cin.tie(nullptr);

	int N;
	cin >> N;

	while (N--) {
		int K;
		cin >> K;
		
		vector<string> graph(K);
		for (int i = 0; i < K; i++) {
			cin >> graph[i];
		}
		insert(graph);
	}
	print(root, 0);

	return 0;
}