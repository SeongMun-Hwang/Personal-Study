#include <iostream>
using namespace std;

int N;
int paper[128][128];
int white = 0, blue = 0;

bool CheckSquare(int x, int y, int size) {
    int color = paper[x][y];
    for (int i = x; i < x + size; ++i) {
        for (int j = y; j < y + size; ++j) {
            if (paper[i][j] != color) return false;
        }
    }
    return true;
}
void Divide(int x, int y, int size) {
    if (CheckSquare(x, y, size)) {
        if (paper[x][y] == 0) white++;
        else blue++;
        return;
    }

    int newSize = size / 2;
    Divide(x, y, newSize); 
    Divide(x, y + newSize, newSize); 
    Divide(x + newSize, y, newSize);
    Divide(x + newSize, y + newSize, newSize); 
}
int main() {
    cin >> N;

    for (int i = 0; i < N; ++i) {
        for (int j = 0; j < N; ++j) {
            cin >> paper[i][j];
        }
    }
    Divide(0, 0, N);
    cout << white << '\n' << blue << '\n';
    return 0;
}