#!/bin/bash
tput setab 7
tput setaf 0
op=0
while [ $op -ne 3 ]
do
	clear
	tput cup 1 3 ; echo "I. S." ; tput cup 1 8; tput setaf 4 ; echo " U. insumos y soporte al usuario"; tput setaf 0
	tput cup 3 3 ; echo "Numero: "
	tput cup 3 11 ; read num
	sed '/$num/ d' BaseAnimal.txt > fichero2.txt
done
