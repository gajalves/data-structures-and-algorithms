#include <stdio.h>

void hanoi(int n, char source, char aux, char destination) {
    if(n==0)
        return;

    hanoi(n-1, source, destination, aux);
    printf("move disc %d from %c to %c.\n", n, source, destination);
    hanoi(n-1, aux, source, destination);
}
int main() {
    hanoi(4, 'A','B','C');
}