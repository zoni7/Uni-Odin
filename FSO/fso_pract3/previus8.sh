#!/bin/bash 
# content
Num_process=$(ls –d /proc/[1-9]*|wc –l)
echo Number of System process is: $Num_process