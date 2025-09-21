#include <iostream>
#include <stack>
#include <vector>
#include <string>
#include <iomanip>
using namespace std;

int R, C, N;
vector<string> board;

vector<string> explode(const vector<string>& board) {
    vector<string> res(R, string(C, 'O'));
    int dx[4] = { 1,-1,0,0 };
    int dy[4] = { 0,0,1,-1 };
    for (int i = 0; i < R; i++) {
        for (int j = 0; j < C; j++) {
            if (board[i][j] == 'O') {
                res[i][j] = '.';
                for (int d = 0; d < 4; d++) {
                    int nx = i + dx[d], ny = j + dy[d];
                    if (nx >= 0 && nx < R && ny >= 0 && ny < C) {
                        res[nx][ny] = '.';
                    }
                }
            }
        }
    }
    return res;
}

int main() {
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    cin >> R >> C >> N;
    board.resize(R);
    for (int i = 0; i < R; i++) {
        cin >> board[i];
    }

    if (N == 1) {
        for (auto& row : board) cout << row << "\n";
        return 0;
    }
    if (N % 2 == 0) {
        for (int i = 0; i < R; i++) {
            for (int j = 0; j < C; j++) {
                cout << "O";
            }
            cout << "\n";
        }
        return 0;
    }
    if (N % 4 == 3) {
        board = explode(board);
        for (auto& row : board) cout << row << "\n";
        return 0;
    }
    if (N % 4 == 1) {
        board = explode(explode(board));
        for (auto& row : board) cout << row << "\n";
    }
    return 0;
}