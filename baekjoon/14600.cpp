#include <iostream>
using namespace std;

int board[130][130];
int tileNum = 1;

void solve(int sx, int sy, int size, int hx, int hy) {
    if (size == 1) return;

    int t = tileNum++;
    int half = size / 2;

    int mx = sx + half;
    int my = sy + half;


    int quadrant;

    if (hx < mx && hy < my) quadrant = 0;       
    else if (hx >= mx && hy < my) quadrant = 1; 
    else if (hx < mx && hy >= my) quadrant = 2;
    else quadrant = 3;                          

    if (quadrant != 0) board[mx - 1][my - 1] = t;
    if (quadrant != 1) board[mx][my - 1] = t;
    if (quadrant != 2) board[mx - 1][my] = t;
    if (quadrant != 3) board[mx][my] = t;

    solve(sx, sy, half,
        quadrant == 0 ? hx : mx - 1,
        quadrant == 0 ? hy : my - 1);

    solve(mx, sy, half,
        quadrant == 1 ? hx : mx,
        quadrant == 1 ? hy : my - 1);

    solve(sx, my, half,
        quadrant == 2 ? hx : mx - 1,
        quadrant == 2 ? hy : my);

    solve(mx, my, half,
        quadrant == 3 ? hx : mx,
        quadrant == 3 ? hy : my);
}

int main() {
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int K;
    cin >> K;

    int n = 1 << K;

    int x, y;
    cin >> x >> y;

    int hx = x - 1;
    int hy = y - 1;

    board[hx][hy] = -1;

    solve(0, 0, n, hx, hy);

    for (int j = n - 1; j >= 0; j--) {
        for (int i = 0; i < n; i++) {
            cout << board[i][j] << " ";
        }
        cout << "\n";
    }

    return 0;
}