#include <iostream>
#include <vector>

using namespace std;

int N, M, x, y, K;
vector<vector<int>> board;
vector<int> dice(7, 0); // 1~6번 인덱스 사용

// 동 서 북 남 이동 좌표
int dx[] = {0, 0, -1, 1};
int dy[] = {1, -1, 0, 0};

void roll_dice(int dir) {
    int temp = dice[1];
    if (dir == 1) { // 동쪽
        dice[1] = dice[4];
        dice[4] = dice[6];
        dice[6] = dice[3];
        dice[3] = temp;
    } else if (dir == 2) { // 서쪽
        dice[1] = dice[3];
        dice[3] = dice[6];
        dice[6] = dice[4];
        dice[4] = temp;
    } else if (dir == 3) { // 북쪽
        dice[1] = dice[5];
        dice[5] = dice[6];
        dice[6] = dice[2];
        dice[2] = temp;
    } else if (dir == 4) { // 남쪽
        dice[1] = dice[2];
        dice[2] = dice[6];
        dice[6] = dice[5];
        dice[5] = temp;
    }
}

int main() {
    cin >> N >> M >> x >> y >> K;
    board.assign(N, vector<int>(M));
    
    for (int i = 0; i < N; i++) {
        for (int j = 0; j < M; j++) {
            cin >> board[i][j];
        }
    }
    
    for (int i = 0; i < K; i++) {
        int dir;
        cin >> dir;
        
        int nx = x + dx[dir - 1];
        int ny = y + dy[dir - 1];
        
        if (nx < 0 || nx >= N || ny < 0 || ny >= M) continue;
        
        x = nx;
        y = ny;
        roll_dice(dir);
        
        if (board[x][y] == 0) {
            board[x][y] = dice[6];
        } else {
            dice[6] = board[x][y];
            board[x][y] = 0;
        }
        
        cout << dice[1] << '\n';
    }
    
    return 0;
}
