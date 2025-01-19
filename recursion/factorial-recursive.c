#include <stdio.h>
#include <stdlib.h>

int fat(int n) {
    if(n >0)
        return fat(n-1)*n;

    return 1;
}

int main() {
    int x;
    scanf("%d", &x);

    printf("%d",fat(x));
}