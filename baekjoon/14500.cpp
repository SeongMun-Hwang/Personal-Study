#include <iostream>
#include <vector>
#include <algorithm>
#include <cmath>
#include <string>

using namespace std;

int main() {
	int N, M;
	cin >> N >> M;
	int maxsum = 0;
	vector<vector<int>> tetris(N, vector<int>(M));
	vector<vector<vector<vector<int>>>> tetromino = {
		//네모
		{
			{{1,1},{1,1}}
		},
		//I자
		{
			{ { 1,1,1,1}},{{1},{1},{1},{1}}
		},
		//L자
		{
			{ { {1,0},{1,0},{1,1} },{{0,0,1},{1,1,1}},
	{{1,1},{0,1},{0,1}},{{1,1,1},{1,0,0}},
		{{0,1},{0,1},{1,1}},{{1,0,0},{1,1,1}},
	{{1,1},{1,0},{1,0}},{{1,1,1},{0,0,1}} }
},
//Z자
		{
			{ { {1,0},{1,1},{0,1} },
		{{0,1,1},{1,1,0}},
		{{0,1},{1,1},{1,0}},
		{{1,1,0},{0,1,1}} }
},
//T자
		{
			{ { {1,1,1},{0,1,0} },{{0,1,0},{1,1,1}},
		{{1,0},{1,1},{1,0}},{{0,1},{1,1},{0,1}} }
}
	};
	for (int i = 0; i < N; i++) {
		for (int j = 0; j < M; j++) {
			int x;
			cin >> x;
			tetris[i][j] = x;
		}
	}
	for (int i = 0; i < N; i++) {
		for (int j = 0; j < M; j++) {
			for (int n = 0; n < tetromino.size(); n++) {
				for (int m = 0; m < tetromino[n].size(); m++) {
					if (i + tetromino[n][m].size() > N || j + tetromino[n][m][0].size() > M) {
						continue;
					}
					int sum = 0;
					for (int o = 0; o < tetromino[n][m].size(); o++) {
						for (int p = 0; p < tetromino[n][m][o].size(); p++) {
							sum += tetris[i + o][j + p] * tetromino[n][m][o][p];
						}
					}
					maxsum = max(maxsum, sum);
				}
			}
		}
	}

	cout << maxsum;
	return 0;
}