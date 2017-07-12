Imports System.Net
Imports System.IO
Imports System.Linq
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class idBox5
    Private Property cActiveTab As String = "1"

    Private Property cRegion As String = ""

    Public Function requestByName()

        Dim request As HttpWebRequest
        Dim response As HttpWebResponse = Nothing
        Dim reader As StreamReader

        Dim cRequestName As String = nameBox.Text

        If nameBox.Text = "" Then
            cRequestName = InputBox("Insert Summoner Name", "summonerByName")
            cRequestName = cRequestName.Replace(" ", "")
        Else
            cRequestName = cRequestName.Replace(" ", "")
        End If

        Dim cDevKey As String = devKeyBox.Text
        cDevKey = "?api_key=" & cDevKey.Trim

        Try
            request = DirectCast(WebRequest.Create("http://prod.api.pvp.net/api/lol/" & cRegion & "/v1.4/summoner/by-name/" & cRequestName & cDevKey), HttpWebRequest)
            response = DirectCast(request.GetResponse(), HttpWebResponse)
            reader = New StreamReader(response.GetResponseStream())

            Dim rawresp As String
            rawresp = reader.ReadToEnd()

            Dim jResults As JObject = JObject.Parse(rawresp)
            Dim lResults As List(Of JToken) = jResults.Children().ToList()

            rawJSON.Text = jResults.ToString

            For Each item As JProperty In lResults
                item.CreateReader()
                Select Case item.Name
                    Case "revisionDateStr"
                        Dim dRevisionStr = item.Value.ToString
                        revisionStrBox.Text = dRevisionStr

                    Case "id"
                        Dim iID = item.Value.ToString
                        idBox.Text = iID

                    Case "name"
                        Dim cName = item.Value.ToString
                        nameBox.Text = cName

                    Case "profileIconId"
                        Dim iIconId = item.Value.ToString
                        iconIdBox.Text = iIconId

                    Case "revisionDate"
                        Dim lRevisionDate = item.Value.ToString
                        revisionBox.Text = lRevisionDate

                    Case "summonerLevel"
                        Dim lSummonerLevel = item.Value.ToString
                        summonerLevelBox.Text = lSummonerLevel

                End Select
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            If Not response Is Nothing Then response.Close()
        End Try
    End Function

    Private Sub executeButton_Click(sender As Object, e As EventArgs) Handles executeButton.Click

        If cActiveTab = "1" Then
            If runesRButton.Checked = True Or masteriesRButton.Checked = True Or masteriesRButton.Checked = True Or summonerIDRButton.Checked = True Or summonerNameRButton.Checked = True Or nameListRButton.Checked = True Then
                If summonerNameRButton.Checked = True Then
                    requestByName()
                ElseIf summonerIDRButton.Checked = True Then
                    requestByID()
                ElseIf nameListRButton.Checked = True Then
                    requestNameList()
                ElseIf masteriesRButton.Checked = True Then
                    requestMasteries()
                ElseIf runesRButton.Checked = True Then
                    requestRunes()
                End If
            Else
                MsgBox("You must select a Type of Request first.")
            End If
        End If

        If cActiveTab = "2" Then
            If rankedRButton.Checked = True Or playerStatsRButton.Checked = True Then
                If rankedRButton.Checked = True Then
                    requestRanked()
                ElseIf playerStatsRButton.Checked = True Then
                    requestPlayerStatsSummary()
                End If
            Else
                MsgBox("You must select a Type of Request first.")
            End If
        End If

        If cActiveTab = "3" Then
            If championListRButton.Checked = True Then
                requestChampionList()
            End If
        End If

        If cActiveTab = "4" Then
            If recentGamesRButton.Checked = True Then
                requestRecentGames()
            End If
        End If

        If cActiveTab = "5" Then
            If leagueRButton.Checked = True Then
                requestLeague()
            End If
        End If

        If cActiveTab = "6" Then
            If teamRButton.Checked = True Then
                requestTeam()
            End If
        End If
    End Sub
End Class
