#include<iostream>
using namespace std;

int n, m;
int r, c, d;
int number = 0;
int room[50][50];

void CleanRoom() {
	while (true) {
		if (room[r][c] == 0) {
			room[r][c]=2;
			number++;
		}
		bool moved = false;
		for (int i = 0; i < 4; i++) {
			d = (d + 3) % 4;

			int nr = r, nc = c;
			if (d == 0) nr--;
			else if (d == 1) nc++;
			else if (d == 2) nr++;
			else if (d == 3) nc--;

			if (room[nr][nc] == 0) {
				r = nr;
				c = nc;
				moved = true;
				break;
			}
		}
		if (!moved) {
			int br = r, bc = c;
			if (d == 0) br++;
			else if (d == 1) bc--;
			else if (d == 2)br--;
			else if (d == 3)bc++;

			if (room[br][bc] == 1) break;
			r = br;
			c = bc;
		}
	}
}

int main() {

	cin >> n >> m;
	cin >> r >> c >> d;

	for (int i = 0; i < n; i++) {
		for (int j = 0; j < m; j++) {
			cin >> room[i][j];
		}
	}
	CleanRoom();
	cout << number;
	return 0;
}