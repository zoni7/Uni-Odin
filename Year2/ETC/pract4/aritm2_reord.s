; Varias operaciones aritmeticas
; R5 = R4 � R3 + R2
; R6 = R4 + R1 � R3

	.text

start:
	add  r3, r0, #30  ; r3 = 30
	add  r4, r0, #40  ; r4 = 40
	add  r1, r0, #10	; r1 = 10
	add  r2, r0, #20  ; r2 = 20
	sub r5, r4, r3    ; r5 = r5 � r3
	nop
	add r6, r4, r1    ; r6 = r4 + r1
	add r5, r5, r2    ; r5 = r5 + r2
	nop
	sub r6, r6, r3    ; r6 = r6 � r3
	trap #0       ; Fin del programa