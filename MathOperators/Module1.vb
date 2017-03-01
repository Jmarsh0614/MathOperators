Module Module1

    Sub Main()
        Dim x As Integer = 5
        Dim y As Integer = 6
        Dim a As Integer = 7
        Dim b As Integer = 9
        Dim myNum As Integer
        myNum = 5 + 5
        Console.WriteLine(myNum + 10)
        Console.ReadLine()
        Dim answer As Integer  'equivalent to Null


        myNum = 25 / 5 'Division
        myNum = 5 ^ 3 '5 to the power of 3
        myNum = 5 Mod 2 'Use Mod instead of %modulus for remainder

        '
        If x > y And a > b Then
            'Stuff Goes Here
        End If
        'Greather than or equal to operand
        If x >= y Or a <= b Then
            'Stuff Goes Here
        End If


        answer = myNum * myNum
            Console.WriteLine(answer)
            Console.ReadLine()

    End Sub

End Module
