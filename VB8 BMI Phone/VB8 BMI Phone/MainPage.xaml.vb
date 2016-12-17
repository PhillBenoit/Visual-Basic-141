' The Blank Application template is documented at http://go.microsoft.com/fwlink/?LinkID=391641
Option Strict On
Option Explicit On

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page

    ''' <summary>
    ''' Invoked when this page is about to be displayed in a Frame.
    ''' </summary>
    ''' <param name="e">Event data that describes how this page was reached.
    ''' This parameter is typically used to configure the page.</param>
    Protected Overrides Sub OnNavigatedTo(e As Navigation.NavigationEventArgs)
        ' TODO: Prepare the page for display here.

        ' TODO: If your application contains multiple pages, ensure that you are
        ' handling the hardware Back button by registering for the
        ' Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
        ' If you are using the NavigationHelper provided by some templates,
        ' this event is handled for you.
    End Sub

    Private Sub Calculate_Click(sender As Object, e As RoutedEventArgs) Handles Calculate.Click
        If CType(txtHeight.Text, Integer) < 1 Then txtHeight.Text = "1"
        If CType(txtWeight.Text, Integer) < 1 Then txtWeight.Text = "1"
        If CType(txtHeight.Text, Integer) > 200 Then txtHeight.Text = "200"
        If CType(txtWeight.Text, Integer) > 500 Then txtWeight.Text = "500"
        Dim height As Integer = CInt(txtHeight.Text)
        Dim weight As Integer = CInt(txtWeight.Text)
        Dim dblBMI As Double = (weight * 703) / (height * height)
        BMI.Text = dblBMI.ToString
    End Sub

    Private Sub Clear_Click(sender As Object, e As RoutedEventArgs) Handles Clear.Click
        txtHeight.Text = "1"
        txtWeight.Text = "1"
    End Sub

End Class
