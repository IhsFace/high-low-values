Imports System.IO

Public Class Form1
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim strMemberName As String
        Dim intAgeInYears As Integer
        Dim dblDonation As Double
        Dim intGreatestAge As Integer
        Dim dblHighestDonation As Double
        Dim dblLowestDonation As Double
        Dim memberData As StreamReader = File.OpenText("MemberData.txt")

        lstDisplay.Items.Clear()

        If memberData.Peek <> -1 Then
            memberData.ReadLine()
            intGreatestAge = memberData.ReadLine()
            dblDonation = memberData.ReadLine()
            dblHighestDonation = dblDonation
            dblLowestDonation = dblDonation

            Do While memberData.Peek <> -1
                strMemberName = memberData.ReadLine()
                intAgeInYears = memberData.ReadLine()
                dblDonation = memberData.ReadLine()

                If intAgeInYears > intGreatestAge Then
                    intGreatestAge = intAgeInYears
                End If

                If dblDonation > dblHighestDonation Then
                    dblHighestDonation = dblDonation
                ElseIf dblDonation < dblLowestDonation Then
                    dblLowestDonation = dblDonation
                End If
            Loop
        End If

        lstDisplay.Items.Add("The greatest age is " & intGreatestAge)
        lstDisplay.Items.Add("The highest donation is " & dblHighestDonation)
        lstDisplay.Items.Add("The lowest donation is " & dblLowestDonation)

        memberData.Close()
    End Sub

    Private Sub btnAppend_Click(sender As Object, e As EventArgs) Handles btnAppend.Click
        Dim strMemberName As String
        Dim intAgeInYears As Integer
        Dim dblDonation As Double
        Dim memberData As StreamWriter = File.AppendText("MemberData.txt")

        strMemberName = InputBox("Enter Name", "Member Name")
        memberData.WriteLine(strMemberName)

        intAgeInYears = InputBox("Enter Age In Years", "Member Years")
        memberData.WriteLine(intAgeInYears)

        dblDonation = InputBox("Enter Donation", "Member Donation")
        memberData.WriteLine(dblDonation)

        memberData.Close()
    End Sub
End Class
