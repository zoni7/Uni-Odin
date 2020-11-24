#include <stdio.h>
#include <sys/types.h>
#include <unistd.h>
#include <stdlib.h>

#define NPROCESSES 5

int main(void)
{
    pid_t pid;
    int i;

    for (i=0; i<NPROCESSES; i++) {
        pid=fork();
        if (pid==0){
            
            printf("child created in iteration = %d\n",i );
                  
            
            sleep(20);
            exit(i);
            break;
        }       

    }

    sleep(10);
    exit(0);
    return 0;
}