Namespace digioz

    Public Class Temperature
        Public Err As String = ""
        Public Const FahrenheitToCelsiusEquation As String = "C = 5/9 * (F - 32)"
        Public Const CelsiusToFahrenheitEquation As String = "F = (C * 1.8) + 32"
        Public Const FahrenheitToKelvinEquation As String = "K = ((F-32) * 0.5555) + 273.15"
        Public Const KelvinToFahrenheitEquation As String = "F = ((K-273.15) * 1.8) + 32"
        Public Const CelsiusToKelvinEquation As String = "K = C + 273.15"
        Public Const KelvinToCelsiusEquation As String = "C = K - 273.15"

        Public Sub New()
            ' Constructor
        End Sub

        Public Enum Unit
            FAHRENHEIT
            CELCIUS
            KELVIN
        End Enum

        ''' <summary>Main Function to perform Temperature Conversion</summary>
        ''' <param name="Value">Temperature Value to convert from</param>
        ''' <param name="FromUnit">Unit name to convert from</param>
        ''' <param name="ToUnit">Unit name to convert to</param>
        ''' <param name="Decimals">Number of decimal places to round to.</param>
        ''' <devdoc>Not the only function call option!</devdoc>

        Public Function Convert(ByVal Value As Double, ByVal FromUnit As Unit, ByVal ToUnit As Unit, ByVal Decimals As Integer)
            Dim CValue As Double = 0

            If FromUnit = Unit.FAHRENHEIT And ToUnit = Unit.CELCIUS Then
                ' F to C
                CValue = FahrenheitToCelsius(Value, Decimals)
            ElseIf FromUnit = Unit.CELCIUS And ToUnit = Unit.FAHRENHEIT Then
                ' C to F
                CValue = CelsiusToFahrenheit(Value, Decimals)
            ElseIf FromUnit = Unit.FAHRENHEIT And ToUnit = Unit.KELVIN Then
                ' F to K
                CValue = FahrenheitToKelvin(Value, Decimals)
            ElseIf FromUnit = Unit.KELVIN And ToUnit = Unit.FAHRENHEIT Then
                ' K to F
                CValue = KelvinToFahrenheit(Value, Decimals)
            ElseIf FromUnit = Unit.CELCIUS And ToUnit = Unit.KELVIN Then
                ' C to K
                CValue = CelsiusToKelvin(Value, Decimals)
            ElseIf FromUnit = Unit.KELVIN And ToUnit = Unit.CELCIUS Then
                ' K to C
                CValue = KelvinToCelsius(Value, Decimals)
            Else
                Err = "INVALID UNIT CONVERSION"
            End If

            Return CValue
        End Function

        Public Function FahrenheitToCelsius(ByVal F As Double, ByVal DecimalPlaces As Integer) As Double
            Dim C As Double = 0
            C = 5 / 9 * (F - 32)
            Return C
        End Function

        Public Function CelsiusToFahrenheit(ByVal C As Double, ByVal DecimalPlaces As Integer) As Double
            Dim F As Double = 0
            F = (C * 1.8) + 32
            Return FormatNumber(F, DecimalPlaces)
        End Function

        Public Function FahrenheitToKelvin(ByVal F As Double, ByVal DecimalPlaces As Integer) As Double
            Dim K As Double = 0
            K = ((F - 32) * 0.5555) + 273.15
            Return K
        End Function

        Public Function KelvinToFahrenheit(ByVal K As Double, ByVal DecimalPlaces As Integer) As Double
            Dim F As Double = 0
            F = ((K - 273.15) * 1.8) + 32
            Return F
        End Function

        Public Function CelsiusToKelvin(ByVal C As Double, ByVal DecimalPlaces As Integer) As Double
            Dim K As Double = 0
            K = C + 273.15
            Return K
        End Function

        Public Function KelvinToCelsius(ByVal K As Double, ByVal DecimalPlaces As Integer) As Double
            Dim C As Double = 0
            C = K - 273.15
            Return C
        End Function

    End Class

End Namespace

