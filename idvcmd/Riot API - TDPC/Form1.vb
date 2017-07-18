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

    Public Function requestByID()

        Dim request As HttpWebRequest
        Dim response As HttpWebResponse = Nothing
        Dim reader As StreamReader

        Dim cDevKey As String = devKeyBox.Text
        cDevKey = "?api_key=" & cDevKey.Trim

        Dim cRequestID As String = idBox.Text

        If idBox.Text = "" Then
            cRequestID = InputBox("Insert Summoner ID", "summonerByID")
            cRequestID = cRequestID.Trim
        Else
            cRequestID = cRequestID.Trim
        End If

        Try
            request = DirectCast(WebRequest.Create("http://prod.api.pvp.net/api/lol/" & cRegion & "/v1.1/summoner/" & cRequestID & cDevKey), HttpWebRequest)
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

    Public Function requestNameList()

        Dim request As HttpWebRequest
        Dim response As HttpWebResponse = Nothing
        Dim reader As StreamReader

        Dim cDevKey As String = devKeyBox.Text
        cDevKey = "?api_key=" & cDevKey.Trim

        Dim cRequestListID As String = ""

        cRequestListID = InputBox("Comma-separated list of summoner IDs associated with summoner names to retrieve. Maximum allowed at once is 40.", "nameListByIDList")
        cRequestListID = cRequestListID.Trim

        Try
            request = DirectCast(WebRequest.Create("http://prod.api.pvp.net/api/lol/" & cRegion & "/v1.1/summoner/" & cRequestListID & "/name" & cDevKey), HttpWebRequest)
            response = DirectCast(request.GetResponse(), HttpWebResponse)
            reader = New StreamReader(response.GetResponseStream())

            Dim rawresp As String
            rawresp = reader.ReadToEnd()

            Dim jResults As JObject = JObject.Parse(rawresp)
            Dim lResults As List(Of JToken) = jResults.Children().ToList()

            rawJSON.Text = jResults.ToString

            Dim ctrl As Control
            For Each ctrl In TabPage1.Controls
                If TypeOf ctrl Is TextBox Then
                    ctrl.Text = ""
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            If Not response Is Nothing Then response.Close()
        End Try

    End Function

    Public Function requestMasteries()

        Dim request As HttpWebRequest
        Dim response As HttpWebResponse = Nothing
        Dim reader As StreamReader

        Dim cDevKey As String = devKeyBox.Text
        cDevKey = "?api_key=" & cDevKey.Trim

        Dim cRequestID As String = idBox.Text

        If idBox.Text = "" Then
            cRequestID = InputBox("Insert Summoner ID", "masteriesById")
            cRequestID = cRequestID.Trim
        Else
            cRequestID = cRequestID.Trim
        End If

        Try
            request = DirectCast(WebRequest.Create("http://prod.api.pvp.net/api/lol/" & cRegion & "/v1.1/summoner/" & cRequestID & "/masteries" & cDevKey), HttpWebRequest)
            response = DirectCast(request.GetResponse(), HttpWebResponse)
            reader = New StreamReader(response.GetResponseStream())

            Dim rawresp As String
            rawresp = reader.ReadToEnd()

            Dim jResults As JObject = JObject.Parse(rawresp)
            Dim lResults As List(Of JToken) = jResults.Children().ToList()

            rawJSON.Text = jResults.ToString

            Dim ctrl As Control
            For Each ctrl In TabPage1.Controls
                If TypeOf ctrl Is TextBox Then
                    ctrl.Text = ""
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            If Not response Is Nothing Then response.Close()
        End Try

    End Function

    Public Function requestRunes()

        Dim request As HttpWebRequest
        Dim response As HttpWebResponse = Nothing
        Dim reader As StreamReader

        Dim cDevKey As String = devKeyBox.Text
        cDevKey = "?api_key=" & cDevKey.Trim

        Dim cRequestID As String = idBox.Text

        If idBox.Text = "" Then
            cRequestID = InputBox("Insert Summoner ID", "runesById")
            cRequestID = cRequestID.Trim
        Else
            cRequestID = cRequestID.Trim
        End If

        Try
            request = DirectCast(WebRequest.Create("http://prod.api.pvp.net/api/lol/" & cRegion & "/v1.1/summoner/" & cRequestID & "/runes" & cDevKey), HttpWebRequest)
            response = DirectCast(request.GetResponse(), HttpWebResponse)
            reader = New StreamReader(response.GetResponseStream())

            Dim rawresp As String
            rawresp = reader.ReadToEnd()

            Dim jResults As JObject = JObject.Parse(rawresp)
            Dim lResults As List(Of JToken) = jResults.Children().ToList()

            rawJSON.Text = jResults.ToString

            Dim ctrl As Control
            For Each ctrl In TabPage1.Controls
                If TypeOf ctrl Is TextBox Then
                    ctrl.Text = ""
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            If Not response Is Nothing Then response.Close()
        End Try

    End Function

    Public Function requestRanked()

        Dim request As HttpWebRequest
        Dim response As HttpWebResponse = Nothing
        Dim reader As StreamReader

        Dim cDevKey As String = devKeyBox.Text
        cDevKey = "?api_key=" & cDevKey.Trim

        Dim cRequestID As String = idBox.Text

        If idBox2.Text = "" Then
            cRequestID = InputBox("Insert Summoner ID", "rankedStatsById")
            cRequestID = cRequestID.Trim
        Else
            cRequestID = cRequestID.Trim
        End If

        Try
            'Request URL "http://prod.api.pvp.net/api/lol/na/v1.1/stats/by-summoner/20556597/ranked?season=SEASON3&api_key=3eb5b1fc-d4c7-45c8-bc14-2da329241047"
            If seasonBox.Text = "" Then
                request = DirectCast(WebRequest.Create("http://prod.api.pvp.net/api/lol/" & cRegion & "/v1.1/stats/by-summoner/" & cRequestID & "/ranked" & cDevKey), HttpWebRequest)
            Else
                Dim seasonID As String = seasonBox.Text
                seasonID = seasonID.ToUpper
                seasonID = "?season=" & seasonID
                seasonID = seasonID.Replace(" ", "")
                cDevKey = cDevKey.Remove(0, 1)
                cDevKey = "&" & cDevKey
                request = DirectCast(WebRequest.Create("http://prod.api.pvp.net/api/lol/" & cRegion & "/v1.1/stats/by-summoner/" & cRequestID & "/ranked" & seasonID & cDevKey), HttpWebRequest)
            End If
            response = DirectCast(request.GetResponse(), HttpWebResponse)
            reader = New StreamReader(response.GetResponseStream())

            Dim rawresp As String
            rawresp = reader.ReadToEnd()

            Dim jResults As JObject = JObject.Parse(rawresp)
            Dim lResults As List(Of JToken) = jResults.Children().ToList()

            rawJSON2.Text = jResults.ToString
            idBox2.Text = cRequestID

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            If Not response Is Nothing Then response.Close()
        End Try

    End Function

    Public Function requestPlayerStatsSummary()

        Dim request As HttpWebRequest
        Dim response As HttpWebResponse = Nothing
        Dim reader As StreamReader

        Dim cDevKey As String = devKeyBox.Text
        cDevKey = "?api_key=" & cDevKey.Trim

        Dim cRequestID As String = idBox.Text

        If idBox2.Text = "" Then
            cRequestID = InputBox("Insert Summoner ID", "playerStatusSummaryById")
            cRequestID = cRequestID.Trim
        Else
            cRequestID = cRequestID.Trim
        End If

        Try
            'Request URL "https://prod.api.pvp.net/api/lol/na/v1.1/stats/by-summoner/20556597/summary?season=SEASON3&api_key=3eb5b1fc-d4c7-45c8-bc14-2da329241047"
            If seasonBox.Text = "" Then
                request = DirectCast(WebRequest.Create("http://prod.api.pvp.net/api/lol/" & cRegion & "/v1.1/stats/by-summoner/" & cRequestID & "/summary" & cDevKey), HttpWebRequest)
            Else
                Dim seasonID As String = seasonBox.Text
                seasonID = seasonID.ToUpper
                seasonID = "?season=" & seasonID
                seasonID = seasonID.Replace(" ", "")
                cDevKey = cDevKey.Remove(0, 1)
                cDevKey = "&" & cDevKey
                request = DirectCast(WebRequest.Create("http://prod.api.pvp.net/api/lol/" & cRegion & "/v1.1/stats/by-summoner/" & cRequestID & "/summary" & seasonID & cDevKey), HttpWebRequest)
            End If
            response = DirectCast(request.GetResponse(), HttpWebResponse)
            reader = New StreamReader(response.GetResponseStream())

            Dim rawresp As String
            rawresp = reader.ReadToEnd()

            Dim jResults As JObject = JObject.Parse(rawresp)
            Dim lResults As List(Of JToken) = jResults.Children().ToList()

            rawJSON2.Text = jResults.ToString
            idBox2.Text = cRequestID

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            If Not response Is Nothing Then response.Close()
        End Try
    End Function

    Public Function requestChampionList()

        Dim request As HttpWebRequest
        Dim response As HttpWebResponse = Nothing
        Dim reader As StreamReader

        Dim cDevKey As String = devKeyBox.Text
        cDevKey = "?api_key=" & cDevKey.Trim

        Try
            'Request URL "https://prod.api.pvp.net/api/lol/na/v1.1/champion?api_key=3eb5b1fc-d4c7-45c8-bc14-2da329241047"
            request = DirectCast(WebRequest.Create("https://prod.api.pvp.net/api/lol/na/v1.1/champion" & cDevKey), HttpWebRequest)
            response = DirectCast(request.GetResponse(), HttpWebResponse)
            reader = New StreamReader(response.GetResponseStream())

            Dim rawresp As String
            rawresp = reader.ReadToEnd()

            Dim jResults As JObject = JObject.Parse(rawresp)
            Dim lResults As List(Of JToken) = jResults.Children().ToList()

            rawJSON3.Text = jResults.ToString

            Dim ctrl As Control
            For Each ctrl In TabPage1.Controls
                If TypeOf ctrl Is TextBox Then
                    ctrl.Text = ""
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            If Not response Is Nothing Then response.Close()
        End Try

    End Function

    Public Function requestRecentGames()

        Dim request As HttpWebRequest
        Dim response As HttpWebResponse = Nothing
        Dim reader As StreamReader

        Dim cDevKey As String = devKeyBox.Text
        cDevKey = "?api_key=" & cDevKey.Trim

        Dim cRequestID As String = idBox.Text

        If idBox3.Text = "" Then
            cRequestID = InputBox("Insert Summoner ID", "recentGamesById")
            cRequestID = cRequestID.Trim
        Else
            cRequestID = cRequestID.Trim
        End If

        Try
            'Request URL "https://prod.api.pvp.net/api/lol/na/v1.1/game/by-summoner/20556597/recent?api_key=3eb5b1fc-d4c7-45c8-bc14-2da329241047"
            request = DirectCast(WebRequest.Create("http://prod.api.pvp.net/api/lol/" & cRegion & "/v1.1/game/by-summoner/" & cRequestID & "/recent" & cDevKey), HttpWebRequest)
            response = DirectCast(request.GetResponse(), HttpWebResponse)
            reader = New StreamReader(response.GetResponseStream())

            Dim rawresp As String
            rawresp = reader.ReadToEnd()

            Dim jResults As JObject = JObject.Parse(rawresp)
            Dim lResults As List(Of JToken) = jResults.Children().ToList()

            rawJSON4.Text = jResults.ToString
            idBox3.Text = cRequestID

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            If Not response Is Nothing Then response.Close()
        End Try
    End Function

    Public Function requestLeague()

        Dim request As HttpWebRequest
        Dim response As HttpWebResponse = Nothing
        Dim reader As StreamReader

        Dim cDevKey As String = devKeyBox.Text
        cDevKey = "?api_key=" & cDevKey.Trim

        Dim cRequestID As String = idBox.Text

        If idBox4.Text = "" Then
            cRequestID = InputBox("Insert Summoner ID", "leagueById")
            cRequestID = cRequestID.Trim
        Else
            cRequestID = cRequestID.Trim
        End If

        Try
            'Request URL "https://prod.api.pvp.net/api/na/v2.1/league/by-summoner/20556597?api_key=3eb5b1fc-d4c7-45c8-bc14-2da329241047"
            request = DirectCast(WebRequest.Create("http://prod.api.pvp.net/api/" & cRegion & "/v2.1/league/by-summoner/" & cRequestID & cDevKey), HttpWebRequest)
            response = DirectCast(request.GetResponse(), HttpWebResponse)
            reader = New StreamReader(response.GetResponseStream())

            Dim rawresp As String
            rawresp = reader.ReadToEnd()

            Dim jResults As JObject = JObject.Parse(rawresp)
            Dim lResults As List(Of JToken) = jResults.Children().ToList()

            rawJSON5.Text = jResults.ToString
            idBox4.Text = cRequestID

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            If Not response Is Nothing Then response.Close()
        End Try
    End Function

    Public Function requestTeam()

        Dim request As HttpWebRequest
        Dim response As HttpWebResponse = Nothing
        Dim reader As StreamReader

        Dim cDevKey As String = devKeyBox.Text
        cDevKey = "?api_key=" & cDevKey.Trim

        Dim cRequestID As String = idBox.Text

        If idBox6.Text = "" Then
            cRequestID = InputBox("Insert Summoner ID", "teamById")
            cRequestID = cRequestID.Trim
        Else
            cRequestID = cRequestID.Trim
        End If

        Try
            'Request URL "http://prod.api.pvp.net/api/na/v2.1/team/by-summoner/20556597?api_key=3eb5b1fc-d4c7-45c8-bc14-2da329241047"
            request = DirectCast(WebRequest.Create("http://prod.api.pvp.net/api/" & cRegion & "/v2.1/team/by-summoner/" & cRequestID & cDevKey), HttpWebRequest)
            response = DirectCast(request.GetResponse(), HttpWebResponse)
            reader = New StreamReader(response.GetResponseStream())

            Dim rawresp As String
            rawresp = reader.ReadToEnd()

            Dim jResults As JObject = JObject.Parse(rawresp)
            Dim lResults As List(Of JToken) = jResults.Children().ToList()

            rawJSON6.Text = jResults.ToString
            idBox6.Text = cRequestID

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
