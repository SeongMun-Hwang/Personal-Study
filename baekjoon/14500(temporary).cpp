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
    vector<vector<int>> square = { {1,1},{1,1} };
    vector<int> I = { 1,1,1,1 };
    vector<vector<int>> L = { {1,0},{1,0},{1,1} };
    vector<vector<int>> X = { {1,0},{1,1},{1,1} };
    vector<vector<int>> T = { {1,1,1},{0,1,0} };

    for (int i = 0; i < N; i++) {
        for (int j = 0; j < M; j++) {
            int x;
            cin >> x;
            tetris[i][j]=x;
        }
    }
    int i = 0;
    int j = 0;
    while (i + T.size() < N){
        while (j + T[0].size() < M) {
            int sum = 0;
            for (int k = 0; k < T.size(); k++) {
                for (int l = 0; l < T[0].size(); l++) {
                    sum += tetris[k+i][l+j] * T[k][l];
                    cout << tetris[k+i][l+j] << " " << T[k][l] << "\n";
                }
            }
            cout << "sum : " << sum << "\n";
            maxsum = max(maxsum, sum);
            j++;
        }
        j = 0;
        i++;
    }

    cout << maxsum;
    return 0;
}
