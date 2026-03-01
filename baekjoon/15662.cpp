#include <iostream>
#include <vector>
#include <algorithm>
#include <queue>
using namespace std;

int main() {
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int T;
    cin >> T;

    vector<vector<int>> gear(T, vector<int>(8));

    // ⭐ 문자열로 입력 받기
    for (int i = 0; i < T; i++) {
        string s;
        cin >> s;
        for (int j = 0; j < 8; j++)
            gear[i][j] = s[j] - '0';
    }

    int K;
    cin >> K;

    while (K--) {
        int num, dir;
        cin >> num >> dir;
        num--;

        vector<int> rotateDir(T, 0);
        rotateDir[num] = dir;

        for (int i = num; i > 0; i--) {
            if (gear[i][6] != gear[i - 1][2])
                rotateDir[i - 1] = -rotateDir[i];
            else break;
        }

        for (int i = num; i < T - 1; i++) {
            if (gear[i][2] != gear[i + 1][6])
                rotateDir[i + 1] = -rotateDir[i];
            else break;
        }

        for (int i = 0; i < T; i++) {
            if (rotateDir[i] == 0) continue;

            if (rotateDir[i] == 1) {
                int last = gear[i][7];
                for (int j = 7; j > 0; j--)
                    gear[i][j] = gear[i][j - 1];
                gear[i][0] = last;
            }
            else { 
                int first = gear[i][0];
                for (int j = 0; j < 7; j++)
                    gear[i][j] = gear[i][j + 1];
                gear[i][7] = first;
            }
        }
    }

    int answer = 0;
    for (int i = 0; i < T; i++)
        if (gear[i][0] == 1)
            answer++;

    cout << answer << "\n";
}