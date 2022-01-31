Public Class Form1
    'Turned on Option Strict 
    'ENUM for quarters, dimes, nickels and pennies as Intger
    Enum coinTypes As Integer
        quarters = 25
        dimes = 10
        nickels = 5
        pennies = 1
    End Enum
    Dim intIndex As Integer
    Dim dbItemPrice As Double
    Dim intQuanity As Integer
    Dim dbTotal As Double = 0
    Dim dallorFormat As String = "$ ###,##0.00"
    Dim intChangeOwed As Integer = 0

    Private Sub bntAddToCart_Click(sender As Object, e As EventArgs) Handles bntAddToCart.Click
        If (lbProductList.SelectedIndex >= 0) Then
            intIndex = lbProductList.SelectedIndex
            dbItemPrice = lbPrices.Items(intIndex)

            If IsNumeric(txtQuantity.Text) And txtQuantity.Text > 0 Then

                Dim dbPrice As Double = dbItemPrice * txtQuantity.Text


                Dim row() As String = {lbProductList.SelectedItem, txtQuantity.Text, Format(dbItemPrice, dallorFormat), Format(dbPrice, dallorFormat)}
                Dim ListViewItem = New ListViewItem(row)
                lvProductInformation.Items.Add(ListViewItem)
                dbTotal = 0

                For Each item As ListViewItem In lvProductInformation.Items
                    'used += to calulate the current total

                    dbTotal += item.SubItems(3).Text

                Next
                TxtTotal.Text = Format(dbTotal, dallorFormat)
                'Once at least one item is added to the cart the check out button and the cash text box are enabled.  
                BntCheckOut.Enabled = True
                txtCash.Enabled = True

            Else
                MessageBox.Show("Please Enter a number of products In the Quanity field and the Quanity has to be Greater then 0")
            End If


        Else
            MessageBox.Show("Please select and item")
        End If



    End Sub

    ' Function to get change for cusotmer
    Function getChange() As Boolean
        If IsNumeric(txtCash.Text) And CDbl(txtCash.Text.Trim) >= dbTotal Then

            If CDbl(txtCash.Text.Trim) >= dbTotal Then
                intChangeOwed = CInt(Math.Round((CDbl(txtCash.Text.Trim) - dbTotal), 2) * 100)

                Dim intTemp As Integer
                If intChangeOwed >= coinTypes.quarters Then
                    'using interger division to caluclate how many quarters are owed
                    intTemp = intChangeOwed \ coinTypes.quarters
                    txtQuarters.Text = intTemp
                    'Used to subtract the number ofr dimes from the change that is owed
                    intChangeOwed -= (intTemp * coinTypes.quarters)


                End If
                If intChangeOwed >= coinTypes.dimes Then
                    'using interger division to caluclate how many dimes are owed
                    intTemp = intChangeOwed \ coinTypes.dimes
                    txtDimes.Text = intTemp
                    'Used to subtract the number ofr dimes from the change that is owed
                    intChangeOwed -= intTemp * coinTypes.dimes



                End If
                If intChangeOwed >= coinTypes.nickels Then
                    'using interger division to caluclate how many nickels are owed

                    intTemp = intChangeOwed \ coinTypes.nickels
                    txtNickels.Text = intTemp
                    'Used to subtract the number ofr dimes from the change that is owed
                    intChangeOwed -= intTemp * coinTypes.nickels
                End If
                If intChangeOwed >= coinTypes.pennies Then
                    'using interger division to caluclate how many pennies are owed
                    intTemp = intChangeOwed \ coinTypes.pennies
                    txtPennis.Text = intTemp
                    'Used to subtract the number ofr dimes from the change that is owed
                    intChangeOwed -= intTemp * coinTypes.pennies
                End If

            End If
            Return True
        Else
            Return False
        End If


    End Function

    Private Sub BntCheckOut_Click(sender As Object, e As EventArgs) Handles BntCheckOut.Click


        If getChange() = False Then
            MessageBox.Show("Please enter a number and the value most be grather or equal to the total")
        End If


    End Sub
End Class
