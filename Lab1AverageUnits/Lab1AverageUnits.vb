Option Strict On

'Imports System.ComponentModel
''' 
''' Name:           Lab1AverageUnits
''' Student Name:   Dhara Savaliya
''' Student ID:     100648840
''' Date:           04-Feb-2018
''' Description:    Average Shipped Units Calculator : User will need to enter units per week to find 
'''                 average per unit

Public Class frmLab1AverageUnits
    Dim userInput As String ' used to store the values entered by user as string
    Dim intUserInput(6) As Integer ' this is an array of 6 integers to store units for 7 days
    Dim totalUnits As Integer ' this will store the total of all units per week
    Dim daysCounter As Integer ' this counter is used to count days to receive values from user 
    Dim averageUnits As Double ' this will store the average units per day 
    Private Sub frmLab1AverageUnits_Load(sender As Object, e As EventArgs) Handles Me.Load
        InitializeAll() ' calling a funtion to itialize all default values
    End Sub
    Private Sub InitializeAll()
        'This function is used to initalizing all values to its default one to let user to reenter the units 
        'For that we require to clean their memory with old stored values
        'Moreover, it also focuses on labels and textboxs to take care
        userInput = String.Empty
        intUserInput = {0, 0, 0, 0, 0, 0, 0} 'initializing arrays values with 0
        totalUnits = 0
        daysCounter = 1
        averageUnits = 0.00
        txtUnits.Text = ""
        txtUnitsPerDay.Text = ""
        lblDays.Text = ""
        lblAverageDisplay.Text = ""
        txtUnits.Focus()
        txtUnits.ReadOnly() = False
        btnEnter.Enabled() = True
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        InitializeAll() ' calling the function to reset all variables, labelsand text boxes
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() ' this will close the form 
    End Sub
    Private Sub inputValidation()
        Dim userInputDouble As Double = 0.00 ' used for validate the user input for double data type
        userInput = Trim(txtUnits.Text) 'To remove white spaces 
        ' Validate user input for integer numbers
        If Integer.TryParse(userInput, intUserInput(daysCounter - 1)) Then ' here it will try to parse the integer input
            'Check the range which should be between 0 to 1000 including 0 and 1000
            If intUserInput(daysCounter - 1) >= 0 And intUserInput(daysCounter - 1) <= 1000 Then
                txtUnitsPerDay.Text &= intUserInput(daysCounter - 1) & vbCrLf ' This adds up a new line on the textbox
                txtUnits.Text = "" ' clears the thext box

                daysCounter += 1 'here is counter set to increment by 1 if user unput is valid
                lblAverageDisplay.Text = "" ' this makes sure it displays nothing at this time
            Else
                ' If user enters unit numbers ot of range he will prompt this message and follow this process
                txtUnits.SelectionStart = 0
                txtUnits.SelectionLength = txtUnits.Text.Length
                lblAverageDisplay.Text = "Enter Numbers Between 0 To 1000."
                lblDays.Text = "Days: " & daysCounter - 1 ' setting dayscounter back with its position number
            End If
        ElseIf Double.TryParse(userInput, userInputDouble) Then  'If user input is double it will give a message
            txtUnits.Text = ""
            lblAverageDisplay.Text = "Please Enter Whole Numbers Only."
            lblDays.Text = "Days: " & daysCounter - 1
        ElseIf userInput = "" Then  'If user input is space or an empty string, it will give a message
            txtUnits.Text = ""
            lblAverageDisplay.Text = "Please Enter Units Per Day."
            lblDays.Text = "Days: " & daysCounter - 1
        Else ' If user input is character, it will give a message
            txtUnits.Text = ""
            lblAverageDisplay.Text = "Please Enter Numbers Only."
            lblDays.Text = "Days: " & daysCounter - 1
        End If
    End Sub
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        inputValidation() ' Calling inputValidation function to reset variables, laels, text boxes
        If daysCounter > 7 Then ' if daysCounter is greater than 7 it will set the focus on reset button
            totalUnitCalculation() ' calling totalUnitCalculation function to add all days input
            averageUnits = totalUnits / 7 ' calculates average for units
            lblAverageDisplay.Text = "Average Per Day : " & Format(averageUnits, "#.##") ' displays average with 2 decimal points
            btnReset.Focus() ' setting focus on reset button
            txtUnits.ReadOnly = True ' makes txtUnits read only
        End If
    End Sub
    Private Sub totalUnitCalculation()
        Dim loopCounter As Integer ' assigning a varible to use it for loop counter
        For loopCounter = 0 To 6 ' this loop will starts from 0 and end on 6 to add 7 units
            totalUnits += intUserInput(loopCounter) 'Everytime When user gets valid input it will add up to total numbers
        Next loopCounter ' adding 1 to loopCounter
    End Sub
    Private Sub txtUnits_TextChanged(sender As Object, e As EventArgs) Handles txtUnits.TextChanged
        If daysCounter >= 8 Then 'if dayCounter is 8 or more than that then it will disable the Enter button to use it
            btnEnter.Enabled() = False
        Else
            lblDays.Text = "Days: " & daysCounter ' else it will shows the days in lblDays label displaying the days no. 
        End If
    End Sub
    Private Sub btnEnter_click(sender As Object, e As MouseEventArgs) Handles btnEnter.MouseClick
        txtUnits.Focus() ' if user clicks with moue te enter button it will give focus to the txtUnits text box
    End Sub
End Class
