Public Class Main2

    Private readBuffer As String = String.Empty
    Private Bytenumber As Integer
    Private ByteToRead As Integer
    Private byteEnd(2) As Char
    Private comOpen As Boolean

    Private Const stepsMax = 500

    Private stepChange As Boolean = False

    Private grid3d(8, 8, 8) As Byte
    Private grid2d(8, 8) As Byte
    Private lines(stepsMax) As String

    Private TxComp As Boolean = True

    Private Sub C111_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C111.CheckedChanged
        If stepChange = False Then CheckChange(1, 1, 1, sender)
    End Sub
    Private Sub C112_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C112.CheckedChanged
        If stepChange = False Then CheckChange(1, 1, 2, sender)
    End Sub
    Private Sub C113_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C113.CheckedChanged
        If stepChange = False Then CheckChange(1, 1, 3, sender)
    End Sub
    Private Sub C114_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C114.CheckedChanged
        If stepChange = False Then CheckChange(1, 1, 4, sender)
    End Sub
    Private Sub C115_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C115.CheckedChanged
        If stepChange = False Then CheckChange(1, 1, 5, sender)
    End Sub
    Private Sub C116_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C116.CheckedChanged
        If stepChange = False Then CheckChange(1, 1, 6, sender)
    End Sub
    Private Sub C117_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C117.CheckedChanged
        If stepChange = False Then CheckChange(1, 1, 7, sender)
    End Sub
    Private Sub C118_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C118.CheckedChanged
        If stepChange = False Then CheckChange(1, 1, 8, sender)
    End Sub
    Private Sub C121_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C121.CheckedChanged
        If stepChange = False Then CheckChange(1, 2, 1, sender)
    End Sub
    Private Sub C122_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C122.CheckedChanged
        If stepChange = False Then CheckChange(1, 2, 2, sender)
    End Sub
    Private Sub C123_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C123.CheckedChanged
        If stepChange = False Then CheckChange(1, 2, 3, sender)
    End Sub
    Private Sub C124_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C124.CheckedChanged
        If stepChange = False Then CheckChange(1, 2, 4, sender)
    End Sub
    Private Sub C125_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C125.CheckedChanged
        If stepChange = False Then CheckChange(1, 2, 5, sender)
    End Sub
    Private Sub C126_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C126.CheckedChanged
        If stepChange = False Then CheckChange(1, 2, 6, sender)
    End Sub
    Private Sub C127_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C127.CheckedChanged
        If stepChange = False Then CheckChange(1, 2, 7, sender)
    End Sub
    Private Sub C128_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C128.CheckedChanged
        If stepChange = False Then CheckChange(1, 2, 8, sender)
    End Sub
    Private Sub C131_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C131.CheckedChanged
        If stepChange = False Then CheckChange(1, 3, 1, sender)
    End Sub
    Private Sub C132_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C132.CheckedChanged
        If stepChange = False Then CheckChange(1, 3, 2, sender)
    End Sub
    Private Sub C133_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C133.CheckedChanged
        If stepChange = False Then CheckChange(1, 3, 3, sender)
    End Sub
    Private Sub C134_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C134.CheckedChanged
        If stepChange = False Then CheckChange(1, 3, 4, sender)
    End Sub
    Private Sub C135_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C135.CheckedChanged
        If stepChange = False Then CheckChange(1, 3, 5, sender)
    End Sub
    Private Sub C136_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C136.CheckedChanged
        If stepChange = False Then CheckChange(1, 3, 6, sender)
    End Sub
    Private Sub C137_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C137.CheckedChanged
        If stepChange = False Then CheckChange(1, 3, 7, sender)
    End Sub
    Private Sub C138_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C138.CheckedChanged
        If stepChange = False Then CheckChange(1, 3, 8, sender)
    End Sub
    Private Sub C141_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C141.CheckedChanged
        If stepChange = False Then CheckChange(1, 4, 1, sender)
    End Sub
    Private Sub C142_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C142.CheckedChanged
        If stepChange = False Then CheckChange(1, 4, 2, sender)
    End Sub
    Private Sub C143_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C143.CheckedChanged
        If stepChange = False Then CheckChange(1, 4, 3, sender)
    End Sub
    Private Sub C144_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C144.CheckedChanged
        If stepChange = False Then CheckChange(1, 4, 4, sender)
    End Sub
    Private Sub C145_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C145.CheckedChanged
        If stepChange = False Then CheckChange(1, 4, 5, sender)
    End Sub
    Private Sub C146_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C146.CheckedChanged
        If stepChange = False Then CheckChange(1, 4, 6, sender)
    End Sub
    Private Sub C147_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C147.CheckedChanged
        If stepChange = False Then CheckChange(1, 4, 7, sender)
    End Sub
    Private Sub C148_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C148.CheckedChanged
        If stepChange = False Then CheckChange(1, 4, 8, sender)
    End Sub
    Private Sub C151_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C151.CheckedChanged
        If stepChange = False Then CheckChange(1, 5, 1, sender)
    End Sub
    Private Sub C152_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C152.CheckedChanged
        If stepChange = False Then CheckChange(1, 5, 2, sender)
    End Sub
    Private Sub C153_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C153.CheckedChanged
        If stepChange = False Then CheckChange(1, 5, 3, sender)
    End Sub
    Private Sub C154_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C154.CheckedChanged
        If stepChange = False Then CheckChange(1, 5, 4, sender)
    End Sub
    Private Sub C155_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C155.CheckedChanged
        If stepChange = False Then CheckChange(1, 5, 5, sender)
    End Sub
    Private Sub C156_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C156.CheckedChanged
        If stepChange = False Then CheckChange(1, 5, 6, sender)
    End Sub
    Private Sub C157_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C157.CheckedChanged
        If stepChange = False Then CheckChange(1, 5, 7, sender)
    End Sub
    Private Sub C158_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C158.CheckedChanged
        If stepChange = False Then CheckChange(1, 5, 8, sender)
    End Sub
    Private Sub C161_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C161.CheckedChanged
        If stepChange = False Then CheckChange(1, 6, 1, sender)
    End Sub
    Private Sub C162_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C162.CheckedChanged
        If stepChange = False Then CheckChange(1, 6, 2, sender)
    End Sub
    Private Sub C163_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C163.CheckedChanged
        If stepChange = False Then CheckChange(1, 6, 3, sender)
    End Sub
    Private Sub C164_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C164.CheckedChanged
        If stepChange = False Then CheckChange(1, 6, 4, sender)
    End Sub
    Private Sub C165_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C165.CheckedChanged
        If stepChange = False Then CheckChange(1, 6, 5, sender)
    End Sub
    Private Sub C166_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C166.CheckedChanged
        If stepChange = False Then CheckChange(1, 6, 6, sender)
    End Sub
    Private Sub C167_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C167.CheckedChanged
        If stepChange = False Then CheckChange(1, 6, 7, sender)
    End Sub
    Private Sub C168_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C168.CheckedChanged
        If stepChange = False Then CheckChange(1, 6, 8, sender)
    End Sub
    Private Sub C171_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C171.CheckedChanged
        If stepChange = False Then CheckChange(1, 7, 1, sender)
    End Sub
    Private Sub C172_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C172.CheckedChanged
        If stepChange = False Then CheckChange(1, 7, 2, sender)
    End Sub
    Private Sub C173_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C173.CheckedChanged
        If stepChange = False Then CheckChange(1, 7, 3, sender)
    End Sub
    Private Sub C174_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C174.CheckedChanged
        If stepChange = False Then CheckChange(1, 7, 4, sender)
    End Sub
    Private Sub C175_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C175.CheckedChanged
        If stepChange = False Then CheckChange(1, 7, 5, sender)
    End Sub
    Private Sub C176_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C176.CheckedChanged
        If stepChange = False Then CheckChange(1, 7, 6, sender)
    End Sub
    Private Sub C177_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C177.CheckedChanged
        If stepChange = False Then CheckChange(1, 7, 7, sender)
    End Sub
    Private Sub C178_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C178.CheckedChanged
        If stepChange = False Then CheckChange(1, 7, 8, sender)
    End Sub
    Private Sub C181_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C181.CheckedChanged
        If stepChange = False Then CheckChange(1, 8, 1, sender)
    End Sub
    Private Sub C182_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C182.CheckedChanged
        If stepChange = False Then CheckChange(1, 8, 2, sender)
    End Sub
    Private Sub C183_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C183.CheckedChanged
        If stepChange = False Then CheckChange(1, 8, 3, sender)
    End Sub
    Private Sub C184_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C184.CheckedChanged
        If stepChange = False Then CheckChange(1, 8, 4, sender)
    End Sub
    Private Sub C185_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C185.CheckedChanged
        If stepChange = False Then CheckChange(1, 8, 5, sender)
    End Sub
    Private Sub C186_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C186.CheckedChanged
        If stepChange = False Then CheckChange(1, 8, 6, sender)
    End Sub
    Private Sub C187_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C187.CheckedChanged
        If stepChange = False Then CheckChange(1, 8, 7, sender)
    End Sub
    Private Sub C188_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C188.CheckedChanged
        If stepChange = False Then CheckChange(1, 8, 8, sender)
    End Sub
    Private Sub C211_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C211.CheckedChanged
        If stepChange = False Then CheckChange(2, 1, 1, sender)
    End Sub
    Private Sub C212_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C212.CheckedChanged
        If stepChange = False Then CheckChange(2, 1, 2, sender)
    End Sub
    Private Sub C213_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C213.CheckedChanged
        If stepChange = False Then CheckChange(2, 1, 3, sender)
    End Sub
    Private Sub C214_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C214.CheckedChanged
        If stepChange = False Then CheckChange(2, 1, 4, sender)
    End Sub
    Private Sub C215_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C215.CheckedChanged
        If stepChange = False Then CheckChange(2, 1, 5, sender)
    End Sub
    Private Sub C216_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C216.CheckedChanged
        If stepChange = False Then CheckChange(2, 1, 6, sender)
    End Sub
    Private Sub C217_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C217.CheckedChanged
        If stepChange = False Then CheckChange(2, 1, 7, sender)
    End Sub
    Private Sub C218_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C218.CheckedChanged
        If stepChange = False Then CheckChange(2, 1, 8, sender)
    End Sub
    Private Sub C221_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C221.CheckedChanged
        If stepChange = False Then CheckChange(2, 2, 1, sender)
    End Sub
    Private Sub C222_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C222.CheckedChanged
        If stepChange = False Then CheckChange(2, 2, 2, sender)
    End Sub
    Private Sub C223_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C223.CheckedChanged
        If stepChange = False Then CheckChange(2, 2, 3, sender)
    End Sub
    Private Sub C224_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C224.CheckedChanged
        If stepChange = False Then CheckChange(2, 2, 4, sender)
    End Sub
    Private Sub C225_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C225.CheckedChanged
        If stepChange = False Then CheckChange(2, 2, 5, sender)
    End Sub
    Private Sub C226_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C226.CheckedChanged
        If stepChange = False Then CheckChange(2, 2, 6, sender)
    End Sub
    Private Sub C227_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C227.CheckedChanged
        If stepChange = False Then CheckChange(2, 2, 7, sender)
    End Sub
    Private Sub C228_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C228.CheckedChanged
        If stepChange = False Then CheckChange(2, 2, 8, sender)
    End Sub
    Private Sub C231_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C231.CheckedChanged
        If stepChange = False Then CheckChange(2, 3, 1, sender)
    End Sub
    Private Sub C232_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C232.CheckedChanged
        If stepChange = False Then CheckChange(2, 3, 2, sender)
    End Sub
    Private Sub C233_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C233.CheckedChanged
        If stepChange = False Then CheckChange(2, 3, 3, sender)
    End Sub
    Private Sub C234_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C234.CheckedChanged
        If stepChange = False Then CheckChange(2, 3, 4, sender)
    End Sub
    Private Sub C235_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C235.CheckedChanged
        If stepChange = False Then CheckChange(2, 3, 5, sender)
    End Sub
    Private Sub C236_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C236.CheckedChanged
        If stepChange = False Then CheckChange(2, 3, 6, sender)
    End Sub
    Private Sub C237_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C237.CheckedChanged
        If stepChange = False Then CheckChange(2, 3, 7, sender)
    End Sub
    Private Sub C238_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C238.CheckedChanged
        If stepChange = False Then CheckChange(2, 3, 8, sender)
    End Sub
    Private Sub C241_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C241.CheckedChanged
        If stepChange = False Then CheckChange(2, 4, 1, sender)
    End Sub
    Private Sub C242_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C242.CheckedChanged
        If stepChange = False Then CheckChange(2, 4, 2, sender)
    End Sub
    Private Sub C243_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C243.CheckedChanged
        If stepChange = False Then CheckChange(2, 4, 3, sender)
    End Sub
    Private Sub C244_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C244.CheckedChanged
        If stepChange = False Then CheckChange(2, 4, 4, sender)
    End Sub
    Private Sub C245_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C245.CheckedChanged
        If stepChange = False Then CheckChange(2, 4, 5, sender)
    End Sub
    Private Sub C246_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C246.CheckedChanged
        If stepChange = False Then CheckChange(2, 4, 6, sender)
    End Sub
    Private Sub C247_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C247.CheckedChanged
        If stepChange = False Then CheckChange(2, 4, 7, sender)
    End Sub
    Private Sub C248_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C248.CheckedChanged
        If stepChange = False Then CheckChange(2, 4, 8, sender)
    End Sub
    Private Sub C251_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C251.CheckedChanged
        If stepChange = False Then CheckChange(2, 5, 1, sender)
    End Sub
    Private Sub C252_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C252.CheckedChanged
        If stepChange = False Then CheckChange(2, 5, 2, sender)
    End Sub
    Private Sub C253_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C253.CheckedChanged
        If stepChange = False Then CheckChange(2, 5, 3, sender)
    End Sub
    Private Sub C254_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C254.CheckedChanged
        If stepChange = False Then CheckChange(2, 5, 4, sender)
    End Sub
    Private Sub C255_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C255.CheckedChanged
        If stepChange = False Then CheckChange(2, 5, 5, sender)
    End Sub
    Private Sub C256_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C256.CheckedChanged
        If stepChange = False Then CheckChange(2, 5, 6, sender)
    End Sub
    Private Sub C257_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C257.CheckedChanged
        If stepChange = False Then CheckChange(2, 5, 7, sender)
    End Sub
    Private Sub C258_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C258.CheckedChanged
        If stepChange = False Then CheckChange(2, 5, 8, sender)
    End Sub
    Private Sub C261_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C261.CheckedChanged
        If stepChange = False Then CheckChange(2, 6, 1, sender)
    End Sub
    Private Sub C262_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C262.CheckedChanged
        If stepChange = False Then CheckChange(2, 6, 2, sender)
    End Sub
    Private Sub C263_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C263.CheckedChanged
        If stepChange = False Then CheckChange(2, 6, 3, sender)
    End Sub
    Private Sub C264_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C264.CheckedChanged
        If stepChange = False Then CheckChange(2, 6, 4, sender)
    End Sub
    Private Sub C265_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C265.CheckedChanged
        If stepChange = False Then CheckChange(2, 6, 5, sender)
    End Sub
    Private Sub C266_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C266.CheckedChanged
        If stepChange = False Then CheckChange(2, 6, 6, sender)
    End Sub
    Private Sub C267_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C267.CheckedChanged
        If stepChange = False Then CheckChange(2, 6, 7, sender)
    End Sub
    Private Sub C268_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C268.CheckedChanged
        If stepChange = False Then CheckChange(2, 6, 8, sender)
    End Sub
    Private Sub C271_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C271.CheckedChanged
        If stepChange = False Then CheckChange(2, 7, 1, sender)
    End Sub
    Private Sub C272_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C272.CheckedChanged
        If stepChange = False Then CheckChange(2, 7, 2, sender)
    End Sub
    Private Sub C273_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C273.CheckedChanged
        If stepChange = False Then CheckChange(2, 7, 3, sender)
    End Sub
    Private Sub C274_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C274.CheckedChanged
        If stepChange = False Then CheckChange(2, 7, 4, sender)
    End Sub
    Private Sub C275_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C275.CheckedChanged
        If stepChange = False Then CheckChange(2, 7, 5, sender)
    End Sub
    Private Sub C276_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C276.CheckedChanged
        If stepChange = False Then CheckChange(2, 7, 6, sender)
    End Sub
    Private Sub C277_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C277.CheckedChanged
        If stepChange = False Then CheckChange(2, 7, 7, sender)
    End Sub
    Private Sub C278_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C278.CheckedChanged
        If stepChange = False Then CheckChange(2, 7, 8, sender)
    End Sub
    Private Sub C281_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C281.CheckedChanged
        If stepChange = False Then CheckChange(2, 8, 1, sender)
    End Sub
    Private Sub C282_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C282.CheckedChanged
        If stepChange = False Then CheckChange(2, 8, 2, sender)
    End Sub
    Private Sub C283_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C283.CheckedChanged
        If stepChange = False Then CheckChange(2, 8, 3, sender)
    End Sub
    Private Sub C284_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C284.CheckedChanged
        If stepChange = False Then CheckChange(2, 8, 4, sender)
    End Sub
    Private Sub C285_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C285.CheckedChanged
        If stepChange = False Then CheckChange(2, 8, 5, sender)
    End Sub
    Private Sub C286_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C286.CheckedChanged
        If stepChange = False Then CheckChange(2, 8, 6, sender)
    End Sub
    Private Sub C287_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C287.CheckedChanged
        If stepChange = False Then CheckChange(2, 8, 7, sender)
    End Sub
    Private Sub C288_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C288.CheckedChanged
        If stepChange = False Then CheckChange(2, 8, 8, sender)
    End Sub
    Private Sub C311_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C311.CheckedChanged
        If stepChange = False Then CheckChange(3, 1, 1, sender)
    End Sub
    Private Sub C312_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C312.CheckedChanged
        If stepChange = False Then CheckChange(3, 1, 2, sender)
    End Sub
    Private Sub C313_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C313.CheckedChanged
        If stepChange = False Then CheckChange(3, 1, 3, sender)
    End Sub
    Private Sub C314_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C314.CheckedChanged
        If stepChange = False Then CheckChange(3, 1, 4, sender)
    End Sub
    Private Sub C315_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C315.CheckedChanged
        If stepChange = False Then CheckChange(3, 1, 5, sender)
    End Sub
    Private Sub C316_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C316.CheckedChanged
        If stepChange = False Then CheckChange(3, 1, 6, sender)
    End Sub
    Private Sub C317_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C317.CheckedChanged
        If stepChange = False Then CheckChange(3, 1, 7, sender)
    End Sub
    Private Sub C318_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C318.CheckedChanged
        If stepChange = False Then CheckChange(3, 1, 8, sender)
    End Sub
    Private Sub C321_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C321.CheckedChanged
        If stepChange = False Then CheckChange(3, 2, 1, sender)
    End Sub
    Private Sub C322_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C322.CheckedChanged
        If stepChange = False Then CheckChange(3, 2, 2, sender)
    End Sub
    Private Sub C323_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C323.CheckedChanged
        If stepChange = False Then CheckChange(3, 2, 3, sender)
    End Sub
    Private Sub C324_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C324.CheckedChanged
        If stepChange = False Then CheckChange(3, 2, 4, sender)
    End Sub
    Private Sub C325_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C325.CheckedChanged
        If stepChange = False Then CheckChange(3, 2, 5, sender)
    End Sub
    Private Sub C326_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C326.CheckedChanged
        If stepChange = False Then CheckChange(3, 2, 6, sender)
    End Sub
    Private Sub C327_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C327.CheckedChanged
        If stepChange = False Then CheckChange(3, 2, 7, sender)
    End Sub
    Private Sub C328_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C328.CheckedChanged
        If stepChange = False Then CheckChange(3, 2, 8, sender)
    End Sub
    Private Sub C331_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C331.CheckedChanged
        If stepChange = False Then CheckChange(3, 3, 1, sender)
    End Sub
    Private Sub C332_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C332.CheckedChanged
        If stepChange = False Then CheckChange(3, 3, 2, sender)
    End Sub
    Private Sub C333_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C333.CheckedChanged
        If stepChange = False Then CheckChange(3, 3, 3, sender)
    End Sub
    Private Sub C334_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C334.CheckedChanged
        If stepChange = False Then CheckChange(3, 3, 4, sender)
    End Sub
    Private Sub C335_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C335.CheckedChanged
        If stepChange = False Then CheckChange(3, 3, 5, sender)
    End Sub
    Private Sub C336_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C336.CheckedChanged
        If stepChange = False Then CheckChange(3, 3, 6, sender)
    End Sub
    Private Sub C337_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C337.CheckedChanged
        If stepChange = False Then CheckChange(3, 3, 7, sender)
    End Sub
    Private Sub C338_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C338.CheckedChanged
        If stepChange = False Then CheckChange(3, 3, 8, sender)
    End Sub
    Private Sub C341_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C341.CheckedChanged
        If stepChange = False Then CheckChange(3, 4, 1, sender)
    End Sub
    Private Sub C342_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C342.CheckedChanged
        If stepChange = False Then CheckChange(3, 4, 2, sender)
    End Sub
    Private Sub C343_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C343.CheckedChanged
        If stepChange = False Then CheckChange(3, 4, 3, sender)
    End Sub
    Private Sub C344_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C344.CheckedChanged
        If stepChange = False Then CheckChange(3, 4, 4, sender)
    End Sub
    Private Sub C345_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C345.CheckedChanged
        If stepChange = False Then CheckChange(3, 4, 5, sender)
    End Sub
    Private Sub C346_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C346.CheckedChanged
        If stepChange = False Then CheckChange(3, 4, 6, sender)
    End Sub
    Private Sub C347_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C347.CheckedChanged
        If stepChange = False Then CheckChange(3, 4, 7, sender)
    End Sub
    Private Sub C348_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C348.CheckedChanged
        If stepChange = False Then CheckChange(3, 4, 8, sender)
    End Sub
    Private Sub C351_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C351.CheckedChanged
        If stepChange = False Then CheckChange(3, 5, 1, sender)
    End Sub
    Private Sub C352_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C352.CheckedChanged
        If stepChange = False Then CheckChange(3, 5, 2, sender)
    End Sub
    Private Sub C353_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C353.CheckedChanged
        If stepChange = False Then CheckChange(3, 5, 3, sender)
    End Sub
    Private Sub C354_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C354.CheckedChanged
        If stepChange = False Then CheckChange(3, 5, 4, sender)
    End Sub
    Private Sub C355_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C355.CheckedChanged
        If stepChange = False Then CheckChange(3, 5, 5, sender)
    End Sub
    Private Sub C356_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C356.CheckedChanged
        If stepChange = False Then CheckChange(3, 5, 6, sender)
    End Sub
    Private Sub C357_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C357.CheckedChanged
        If stepChange = False Then CheckChange(3, 5, 7, sender)
    End Sub
    Private Sub C358_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C358.CheckedChanged
        If stepChange = False Then CheckChange(3, 5, 8, sender)
    End Sub
    Private Sub C361_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C361.CheckedChanged
        If stepChange = False Then CheckChange(3, 6, 1, sender)
    End Sub
    Private Sub C362_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C362.CheckedChanged
        If stepChange = False Then CheckChange(3, 6, 2, sender)
    End Sub
    Private Sub C363_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C363.CheckedChanged
        If stepChange = False Then CheckChange(3, 6, 3, sender)
    End Sub
    Private Sub C364_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C364.CheckedChanged
        If stepChange = False Then CheckChange(3, 6, 4, sender)
    End Sub
    Private Sub C365_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C365.CheckedChanged
        If stepChange = False Then CheckChange(3, 6, 5, sender)
    End Sub
    Private Sub C366_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C366.CheckedChanged
        If stepChange = False Then CheckChange(3, 6, 6, sender)
    End Sub
    Private Sub C367_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C367.CheckedChanged
        If stepChange = False Then CheckChange(3, 6, 7, sender)
    End Sub
    Private Sub C368_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C368.CheckedChanged
        If stepChange = False Then CheckChange(3, 6, 8, sender)
    End Sub
    Private Sub C371_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C371.CheckedChanged
        If stepChange = False Then CheckChange(3, 7, 1, sender)
    End Sub
    Private Sub C372_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C372.CheckedChanged
        If stepChange = False Then CheckChange(3, 7, 2, sender)
    End Sub
    Private Sub C373_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C373.CheckedChanged
        If stepChange = False Then CheckChange(3, 7, 3, sender)
    End Sub
    Private Sub C374_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C374.CheckedChanged
        If stepChange = False Then CheckChange(3, 7, 4, sender)
    End Sub
    Private Sub C375_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C375.CheckedChanged
        If stepChange = False Then CheckChange(3, 7, 5, sender)
    End Sub
    Private Sub C376_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C376.CheckedChanged
        If stepChange = False Then CheckChange(3, 7, 6, sender)
    End Sub
    Private Sub C377_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C377.CheckedChanged
        If stepChange = False Then CheckChange(3, 7, 7, sender)
    End Sub
    Private Sub C378_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C378.CheckedChanged
        If stepChange = False Then CheckChange(3, 7, 8, sender)
    End Sub
    Private Sub C381_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C381.CheckedChanged
        If stepChange = False Then CheckChange(3, 8, 1, sender)
    End Sub
    Private Sub C382_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C382.CheckedChanged
        If stepChange = False Then CheckChange(3, 8, 2, sender)
    End Sub
    Private Sub C383_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C383.CheckedChanged
        If stepChange = False Then CheckChange(3, 8, 3, sender)
    End Sub
    Private Sub C384_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C384.CheckedChanged
        If stepChange = False Then CheckChange(3, 8, 4, sender)
    End Sub
    Private Sub C385_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C385.CheckedChanged
        If stepChange = False Then CheckChange(3, 8, 5, sender)
    End Sub
    Private Sub C386_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C386.CheckedChanged
        If stepChange = False Then CheckChange(3, 8, 6, sender)
    End Sub
    Private Sub C387_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C387.CheckedChanged
        If stepChange = False Then CheckChange(3, 8, 7, sender)
    End Sub
    Private Sub C388_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C388.CheckedChanged
        If stepChange = False Then CheckChange(3, 8, 8, sender)
    End Sub
    Private Sub C411_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C411.CheckedChanged
        If stepChange = False Then CheckChange(4, 1, 1, sender)
    End Sub
    Private Sub C412_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C412.CheckedChanged
        If stepChange = False Then CheckChange(4, 1, 2, sender)
    End Sub
    Private Sub C413_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C413.CheckedChanged
        If stepChange = False Then CheckChange(4, 1, 3, sender)
    End Sub
    Private Sub C414_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C414.CheckedChanged
        If stepChange = False Then CheckChange(4, 1, 4, sender)
    End Sub
    Private Sub C415_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C415.CheckedChanged
        If stepChange = False Then CheckChange(4, 1, 5, sender)
    End Sub
    Private Sub C416_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C416.CheckedChanged
        If stepChange = False Then CheckChange(4, 1, 6, sender)
    End Sub
    Private Sub C417_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C417.CheckedChanged
        If stepChange = False Then CheckChange(4, 1, 7, sender)
    End Sub
    Private Sub C418_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C418.CheckedChanged
        If stepChange = False Then CheckChange(4, 1, 8, sender)
    End Sub
    Private Sub C421_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C421.CheckedChanged
        If stepChange = False Then CheckChange(4, 2, 1, sender)
    End Sub
    Private Sub C422_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C422.CheckedChanged
        If stepChange = False Then CheckChange(4, 2, 2, sender)
    End Sub
    Private Sub C423_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C423.CheckedChanged
        If stepChange = False Then CheckChange(4, 2, 3, sender)
    End Sub
    Private Sub C424_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C424.CheckedChanged
        If stepChange = False Then CheckChange(4, 2, 4, sender)
    End Sub
    Private Sub C425_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C425.CheckedChanged
        If stepChange = False Then CheckChange(4, 2, 5, sender)
    End Sub
    Private Sub C426_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C426.CheckedChanged
        If stepChange = False Then CheckChange(4, 2, 6, sender)
    End Sub
    Private Sub C427_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C427.CheckedChanged
        If stepChange = False Then CheckChange(4, 2, 7, sender)
    End Sub
    Private Sub C428_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C428.CheckedChanged
        If stepChange = False Then CheckChange(4, 2, 8, sender)
    End Sub
    Private Sub C431_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C431.CheckedChanged
        If stepChange = False Then CheckChange(4, 3, 1, sender)
    End Sub
    Private Sub C432_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C432.CheckedChanged
        If stepChange = False Then CheckChange(4, 3, 2, sender)
    End Sub
    Private Sub C433_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C433.CheckedChanged
        If stepChange = False Then CheckChange(4, 3, 3, sender)
    End Sub
    Private Sub C434_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C434.CheckedChanged
        If stepChange = False Then CheckChange(4, 3, 4, sender)
    End Sub
    Private Sub C435_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C435.CheckedChanged
        If stepChange = False Then CheckChange(4, 3, 5, sender)
    End Sub
    Private Sub C436_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C436.CheckedChanged
        If stepChange = False Then CheckChange(4, 3, 6, sender)
    End Sub
    Private Sub C437_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C437.CheckedChanged
        If stepChange = False Then CheckChange(4, 3, 7, sender)
    End Sub
    Private Sub C438_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C438.CheckedChanged
        If stepChange = False Then CheckChange(4, 3, 8, sender)
    End Sub
    Private Sub C441_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C441.CheckedChanged
        If stepChange = False Then CheckChange(4, 4, 1, sender)
    End Sub
    Private Sub C442_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C442.CheckedChanged
        If stepChange = False Then CheckChange(4, 4, 2, sender)
    End Sub
    Private Sub C443_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C443.CheckedChanged
        If stepChange = False Then CheckChange(4, 4, 3, sender)
    End Sub
    Private Sub C444_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C444.CheckedChanged
        If stepChange = False Then CheckChange(4, 4, 4, sender)
    End Sub
    Private Sub C445_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C445.CheckedChanged
        If stepChange = False Then CheckChange(4, 4, 5, sender)
    End Sub
    Private Sub C446_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C446.CheckedChanged
        If stepChange = False Then CheckChange(4, 4, 6, sender)
    End Sub
    Private Sub C447_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C447.CheckedChanged
        If stepChange = False Then CheckChange(4, 4, 7, sender)
    End Sub
    Private Sub C448_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C448.CheckedChanged
        If stepChange = False Then CheckChange(4, 4, 8, sender)
    End Sub
    Private Sub C451_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C451.CheckedChanged
        If stepChange = False Then CheckChange(4, 5, 1, sender)
    End Sub
    Private Sub C452_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C452.CheckedChanged
        If stepChange = False Then CheckChange(4, 5, 2, sender)
    End Sub
    Private Sub C453_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C453.CheckedChanged
        If stepChange = False Then CheckChange(4, 5, 3, sender)
    End Sub
    Private Sub C454_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C454.CheckedChanged
        If stepChange = False Then CheckChange(4, 5, 4, sender)
    End Sub
    Private Sub C455_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C455.CheckedChanged
        If stepChange = False Then CheckChange(4, 5, 5, sender)
    End Sub
    Private Sub C456_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C456.CheckedChanged
        If stepChange = False Then CheckChange(4, 5, 6, sender)
    End Sub
    Private Sub C457_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C457.CheckedChanged
        If stepChange = False Then CheckChange(4, 5, 7, sender)
    End Sub
    Private Sub C458_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C458.CheckedChanged
        If stepChange = False Then CheckChange(4, 5, 8, sender)
    End Sub
    Private Sub C461_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C461.CheckedChanged
        If stepChange = False Then CheckChange(4, 6, 1, sender)
    End Sub
    Private Sub C462_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C462.CheckedChanged
        If stepChange = False Then CheckChange(4, 6, 2, sender)
    End Sub
    Private Sub C463_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C463.CheckedChanged
        If stepChange = False Then CheckChange(4, 6, 3, sender)
    End Sub
    Private Sub C464_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C464.CheckedChanged
        If stepChange = False Then CheckChange(4, 6, 4, sender)
    End Sub
    Private Sub C465_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C465.CheckedChanged
        If stepChange = False Then CheckChange(4, 6, 5, sender)
    End Sub
    Private Sub C466_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C466.CheckedChanged
        If stepChange = False Then CheckChange(4, 6, 6, sender)
    End Sub
    Private Sub C467_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C467.CheckedChanged
        If stepChange = False Then CheckChange(4, 6, 7, sender)
    End Sub
    Private Sub C468_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C468.CheckedChanged
        If stepChange = False Then CheckChange(4, 6, 8, sender)
    End Sub
    Private Sub C471_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C471.CheckedChanged
        If stepChange = False Then CheckChange(4, 7, 1, sender)
    End Sub
    Private Sub C472_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C472.CheckedChanged
        If stepChange = False Then CheckChange(4, 7, 2, sender)
    End Sub
    Private Sub C473_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C473.CheckedChanged
        If stepChange = False Then CheckChange(4, 7, 3, sender)
    End Sub
    Private Sub C474_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C474.CheckedChanged
        If stepChange = False Then CheckChange(4, 7, 4, sender)
    End Sub
    Private Sub C475_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C475.CheckedChanged
        If stepChange = False Then CheckChange(4, 7, 5, sender)
    End Sub
    Private Sub C476_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C476.CheckedChanged
        If stepChange = False Then CheckChange(4, 7, 6, sender)
    End Sub
    Private Sub C477_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C477.CheckedChanged
        If stepChange = False Then CheckChange(4, 7, 7, sender)
    End Sub
    Private Sub C478_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C478.CheckedChanged
        If stepChange = False Then CheckChange(4, 7, 8, sender)
    End Sub
    Private Sub C481_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C481.CheckedChanged
        If stepChange = False Then CheckChange(4, 8, 1, sender)
    End Sub
    Private Sub C482_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C482.CheckedChanged
        If stepChange = False Then CheckChange(4, 8, 2, sender)
    End Sub
    Private Sub C483_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C483.CheckedChanged
        If stepChange = False Then CheckChange(4, 8, 3, sender)
    End Sub
    Private Sub C484_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C484.CheckedChanged
        If stepChange = False Then CheckChange(4, 8, 4, sender)
    End Sub
    Private Sub C485_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C485.CheckedChanged
        If stepChange = False Then CheckChange(4, 8, 5, sender)
    End Sub
    Private Sub C486_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C486.CheckedChanged
        If stepChange = False Then CheckChange(4, 8, 6, sender)
    End Sub
    Private Sub C487_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C487.CheckedChanged
        If stepChange = False Then CheckChange(4, 8, 7, sender)
    End Sub
    Private Sub C488_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C488.CheckedChanged
        If stepChange = False Then CheckChange(4, 8, 8, sender)
    End Sub
    Private Sub C511_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C511.CheckedChanged
        If stepChange = False Then CheckChange(5, 1, 1, sender)
    End Sub
    Private Sub C512_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C512.CheckedChanged
        If stepChange = False Then CheckChange(5, 1, 2, sender)
    End Sub
    Private Sub C513_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C513.CheckedChanged
        If stepChange = False Then CheckChange(5, 1, 3, sender)
    End Sub
    Private Sub C514_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C514.CheckedChanged
        If stepChange = False Then CheckChange(5, 1, 4, sender)
    End Sub
    Private Sub C515_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C515.CheckedChanged
        If stepChange = False Then CheckChange(5, 1, 5, sender)
    End Sub
    Private Sub C516_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C516.CheckedChanged
        If stepChange = False Then CheckChange(5, 1, 6, sender)
    End Sub
    Private Sub C517_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C517.CheckedChanged
        If stepChange = False Then CheckChange(5, 1, 7, sender)
    End Sub
    Private Sub C518_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C518.CheckedChanged
        If stepChange = False Then CheckChange(5, 1, 8, sender)
    End Sub
    Private Sub C521_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C521.CheckedChanged
        If stepChange = False Then CheckChange(5, 2, 1, sender)
    End Sub
    Private Sub C522_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C522.CheckedChanged
        If stepChange = False Then CheckChange(5, 2, 2, sender)
    End Sub
    Private Sub C523_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C523.CheckedChanged
        If stepChange = False Then CheckChange(5, 2, 3, sender)
    End Sub
    Private Sub C524_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C524.CheckedChanged
        If stepChange = False Then CheckChange(5, 2, 4, sender)
    End Sub
    Private Sub C525_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C525.CheckedChanged
        If stepChange = False Then CheckChange(5, 2, 5, sender)
    End Sub
    Private Sub C526_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C526.CheckedChanged
        If stepChange = False Then CheckChange(5, 2, 6, sender)
    End Sub
    Private Sub C527_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C527.CheckedChanged
        If stepChange = False Then CheckChange(5, 2, 7, sender)
    End Sub
    Private Sub C528_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C528.CheckedChanged
        If stepChange = False Then CheckChange(5, 2, 8, sender)
    End Sub
    Private Sub C531_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C531.CheckedChanged
        If stepChange = False Then CheckChange(5, 3, 1, sender)
    End Sub
    Private Sub C532_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C532.CheckedChanged
        If stepChange = False Then CheckChange(5, 3, 2, sender)
    End Sub
    Private Sub C533_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C533.CheckedChanged
        If stepChange = False Then CheckChange(5, 3, 3, sender)
    End Sub
    Private Sub C534_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C534.CheckedChanged
        If stepChange = False Then CheckChange(5, 3, 4, sender)
    End Sub
    Private Sub C535_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C535.CheckedChanged
        If stepChange = False Then CheckChange(5, 3, 5, sender)
    End Sub
    Private Sub C536_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C536.CheckedChanged
        If stepChange = False Then CheckChange(5, 3, 6, sender)
    End Sub
    Private Sub C537_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C537.CheckedChanged
        If stepChange = False Then CheckChange(5, 3, 7, sender)
    End Sub
    Private Sub C538_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C538.CheckedChanged
        If stepChange = False Then CheckChange(5, 3, 8, sender)
    End Sub
    Private Sub C541_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C541.CheckedChanged
        If stepChange = False Then CheckChange(5, 4, 1, sender)
    End Sub
    Private Sub C542_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C542.CheckedChanged
        If stepChange = False Then CheckChange(5, 4, 2, sender)
    End Sub
    Private Sub C543_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C543.CheckedChanged
        If stepChange = False Then CheckChange(5, 4, 3, sender)
    End Sub
    Private Sub C544_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C544.CheckedChanged
        If stepChange = False Then CheckChange(5, 4, 4, sender)
    End Sub
    Private Sub C545_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C545.CheckedChanged
        If stepChange = False Then CheckChange(5, 4, 5, sender)
    End Sub
    Private Sub C546_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C546.CheckedChanged
        If stepChange = False Then CheckChange(5, 4, 6, sender)
    End Sub
    Private Sub C547_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C547.CheckedChanged
        If stepChange = False Then CheckChange(5, 4, 7, sender)
    End Sub
    Private Sub C548_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C548.CheckedChanged
        If stepChange = False Then CheckChange(5, 4, 8, sender)
    End Sub
    Private Sub C551_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C551.CheckedChanged
        If stepChange = False Then CheckChange(5, 5, 1, sender)
    End Sub
    Private Sub C552_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C552.CheckedChanged
        If stepChange = False Then CheckChange(5, 5, 2, sender)
    End Sub
    Private Sub C553_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C553.CheckedChanged
        If stepChange = False Then CheckChange(5, 5, 3, sender)
    End Sub
    Private Sub C554_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C554.CheckedChanged
        If stepChange = False Then CheckChange(5, 5, 4, sender)
    End Sub
    Private Sub C555_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C555.CheckedChanged
        If stepChange = False Then CheckChange(5, 5, 5, sender)
    End Sub
    Private Sub C556_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C556.CheckedChanged
        If stepChange = False Then CheckChange(5, 5, 6, sender)
    End Sub
    Private Sub C557_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C557.CheckedChanged
        If stepChange = False Then CheckChange(5, 5, 7, sender)
    End Sub
    Private Sub C558_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C558.CheckedChanged
        If stepChange = False Then CheckChange(5, 5, 8, sender)
    End Sub
    Private Sub C561_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C561.CheckedChanged
        If stepChange = False Then CheckChange(5, 6, 1, sender)
    End Sub
    Private Sub C562_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C562.CheckedChanged
        If stepChange = False Then CheckChange(5, 6, 2, sender)
    End Sub
    Private Sub C563_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C563.CheckedChanged
        If stepChange = False Then CheckChange(5, 6, 3, sender)
    End Sub
    Private Sub C564_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C564.CheckedChanged
        If stepChange = False Then CheckChange(5, 6, 4, sender)
    End Sub
    Private Sub C565_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C565.CheckedChanged
        If stepChange = False Then CheckChange(5, 6, 5, sender)
    End Sub
    Private Sub C566_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C566.CheckedChanged
        If stepChange = False Then CheckChange(5, 6, 6, sender)
    End Sub
    Private Sub C567_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C567.CheckedChanged
        If stepChange = False Then CheckChange(5, 6, 7, sender)
    End Sub
    Private Sub C568_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C568.CheckedChanged
        If stepChange = False Then CheckChange(5, 6, 8, sender)
    End Sub
    Private Sub C571_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C571.CheckedChanged
        If stepChange = False Then CheckChange(5, 7, 1, sender)
    End Sub
    Private Sub C572_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C572.CheckedChanged
        If stepChange = False Then CheckChange(5, 7, 2, sender)
    End Sub
    Private Sub C573_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C573.CheckedChanged
        If stepChange = False Then CheckChange(5, 7, 3, sender)
    End Sub
    Private Sub C574_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C574.CheckedChanged
        If stepChange = False Then CheckChange(5, 7, 4, sender)
    End Sub
    Private Sub C575_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C575.CheckedChanged
        If stepChange = False Then CheckChange(5, 7, 5, sender)
    End Sub
    Private Sub C576_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C576.CheckedChanged
        If stepChange = False Then CheckChange(5, 7, 6, sender)
    End Sub
    Private Sub C577_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C577.CheckedChanged
        If stepChange = False Then CheckChange(5, 7, 7, sender)
    End Sub
    Private Sub C578_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C578.CheckedChanged
        If stepChange = False Then CheckChange(5, 7, 8, sender)
    End Sub
    Private Sub C581_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C581.CheckedChanged
        If stepChange = False Then CheckChange(5, 8, 1, sender)
    End Sub
    Private Sub C582_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C582.CheckedChanged
        If stepChange = False Then CheckChange(5, 8, 2, sender)
    End Sub
    Private Sub C583_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C583.CheckedChanged
        If stepChange = False Then CheckChange(5, 8, 3, sender)
    End Sub
    Private Sub C584_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C584.CheckedChanged
        If stepChange = False Then CheckChange(5, 8, 4, sender)
    End Sub
    Private Sub C585_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C585.CheckedChanged
        If stepChange = False Then CheckChange(5, 8, 5, sender)
    End Sub
    Private Sub C586_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C586.CheckedChanged
        If stepChange = False Then CheckChange(5, 8, 6, sender)
    End Sub
    Private Sub C587_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C587.CheckedChanged
        If stepChange = False Then CheckChange(5, 8, 7, sender)
    End Sub
    Private Sub C588_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C588.CheckedChanged
        If stepChange = False Then CheckChange(5, 8, 8, sender)
    End Sub
    Private Sub C611_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C611.CheckedChanged
        If stepChange = False Then CheckChange(6, 1, 1, sender)
    End Sub
    Private Sub C612_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C612.CheckedChanged
        If stepChange = False Then CheckChange(6, 1, 2, sender)
    End Sub
    Private Sub C613_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C613.CheckedChanged
        If stepChange = False Then CheckChange(6, 1, 3, sender)
    End Sub
    Private Sub C614_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C614.CheckedChanged
        If stepChange = False Then CheckChange(6, 1, 4, sender)
    End Sub
    Private Sub C615_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C615.CheckedChanged
        If stepChange = False Then CheckChange(6, 1, 5, sender)
    End Sub
    Private Sub C616_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C616.CheckedChanged
        If stepChange = False Then CheckChange(6, 1, 6, sender)
    End Sub
    Private Sub C617_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C617.CheckedChanged
        If stepChange = False Then CheckChange(6, 1, 7, sender)
    End Sub
    Private Sub C618_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C618.CheckedChanged
        If stepChange = False Then CheckChange(6, 1, 8, sender)
    End Sub
    Private Sub C621_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C621.CheckedChanged
        If stepChange = False Then CheckChange(6, 2, 1, sender)
    End Sub
    Private Sub C622_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C622.CheckedChanged
        If stepChange = False Then CheckChange(6, 2, 2, sender)
    End Sub
    Private Sub C623_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C623.CheckedChanged
        If stepChange = False Then CheckChange(6, 2, 3, sender)
    End Sub
    Private Sub C624_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C624.CheckedChanged
        If stepChange = False Then CheckChange(6, 2, 4, sender)
    End Sub
    Private Sub C625_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C625.CheckedChanged
        If stepChange = False Then CheckChange(6, 2, 5, sender)
    End Sub
    Private Sub C626_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C626.CheckedChanged
        If stepChange = False Then CheckChange(6, 2, 6, sender)
    End Sub
    Private Sub C627_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C627.CheckedChanged
        If stepChange = False Then CheckChange(6, 2, 7, sender)
    End Sub
    Private Sub C628_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C628.CheckedChanged
        If stepChange = False Then CheckChange(6, 2, 8, sender)
    End Sub
    Private Sub C631_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C631.CheckedChanged
        If stepChange = False Then CheckChange(6, 3, 1, sender)
    End Sub
    Private Sub C632_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C632.CheckedChanged
        If stepChange = False Then CheckChange(6, 3, 2, sender)
    End Sub
    Private Sub C633_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C633.CheckedChanged
        If stepChange = False Then CheckChange(6, 3, 3, sender)
    End Sub
    Private Sub C634_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C634.CheckedChanged
        If stepChange = False Then CheckChange(6, 3, 4, sender)
    End Sub
    Private Sub C635_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C635.CheckedChanged
        If stepChange = False Then CheckChange(6, 3, 5, sender)
    End Sub
    Private Sub C636_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C636.CheckedChanged
        If stepChange = False Then CheckChange(6, 3, 6, sender)
    End Sub
    Private Sub C637_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C637.CheckedChanged
        If stepChange = False Then CheckChange(6, 3, 7, sender)
    End Sub
    Private Sub C638_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C638.CheckedChanged
        If stepChange = False Then CheckChange(6, 3, 8, sender)
    End Sub
    Private Sub C641_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C641.CheckedChanged
        If stepChange = False Then CheckChange(6, 4, 1, sender)
    End Sub
    Private Sub C642_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C642.CheckedChanged
        If stepChange = False Then CheckChange(6, 4, 2, sender)
    End Sub
    Private Sub C643_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C643.CheckedChanged
        If stepChange = False Then CheckChange(6, 4, 3, sender)
    End Sub
    Private Sub C644_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C644.CheckedChanged
        If stepChange = False Then CheckChange(6, 4, 4, sender)
    End Sub
    Private Sub C645_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C645.CheckedChanged
        If stepChange = False Then CheckChange(6, 4, 5, sender)
    End Sub
    Private Sub C646_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C646.CheckedChanged
        If stepChange = False Then CheckChange(6, 4, 6, sender)
    End Sub
    Private Sub C647_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C647.CheckedChanged
        If stepChange = False Then CheckChange(6, 4, 7, sender)
    End Sub
    Private Sub C648_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C648.CheckedChanged
        If stepChange = False Then CheckChange(6, 4, 8, sender)
    End Sub
    Private Sub C651_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C651.CheckedChanged
        If stepChange = False Then CheckChange(6, 5, 1, sender)
    End Sub
    Private Sub C652_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C652.CheckedChanged
        If stepChange = False Then CheckChange(6, 5, 2, sender)
    End Sub
    Private Sub C653_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C653.CheckedChanged
        If stepChange = False Then CheckChange(6, 5, 3, sender)
    End Sub
    Private Sub C654_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C654.CheckedChanged
        If stepChange = False Then CheckChange(6, 5, 4, sender)
    End Sub
    Private Sub C655_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C655.CheckedChanged
        If stepChange = False Then CheckChange(6, 5, 5, sender)
    End Sub
    Private Sub C656_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C656.CheckedChanged
        If stepChange = False Then CheckChange(6, 5, 6, sender)
    End Sub
    Private Sub C657_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C657.CheckedChanged
        If stepChange = False Then CheckChange(6, 5, 7, sender)
    End Sub
    Private Sub C658_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C658.CheckedChanged
        If stepChange = False Then CheckChange(6, 5, 8, sender)
    End Sub
    Private Sub C661_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C661.CheckedChanged
        If stepChange = False Then CheckChange(6, 6, 1, sender)
    End Sub
    Private Sub C662_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C662.CheckedChanged
        If stepChange = False Then CheckChange(6, 6, 2, sender)
    End Sub
    Private Sub C663_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C663.CheckedChanged
        If stepChange = False Then CheckChange(6, 6, 3, sender)
    End Sub
    Private Sub C664_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C664.CheckedChanged
        If stepChange = False Then CheckChange(6, 6, 4, sender)
    End Sub
    Private Sub C665_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C665.CheckedChanged
        If stepChange = False Then CheckChange(6, 6, 5, sender)
    End Sub
    Private Sub C666_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C666.CheckedChanged
        If stepChange = False Then CheckChange(6, 6, 6, sender)
    End Sub
    Private Sub C667_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C667.CheckedChanged
        If stepChange = False Then CheckChange(6, 6, 7, sender)
    End Sub
    Private Sub C668_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C668.CheckedChanged
        If stepChange = False Then CheckChange(6, 6, 8, sender)
    End Sub
    Private Sub C671_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C671.CheckedChanged
        If stepChange = False Then CheckChange(6, 7, 1, sender)
    End Sub
    Private Sub C672_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C672.CheckedChanged
        If stepChange = False Then CheckChange(6, 7, 2, sender)
    End Sub
    Private Sub C673_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C673.CheckedChanged
        If stepChange = False Then CheckChange(6, 7, 3, sender)
    End Sub
    Private Sub C674_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C674.CheckedChanged
        If stepChange = False Then CheckChange(6, 7, 4, sender)
    End Sub
    Private Sub C675_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C675.CheckedChanged
        If stepChange = False Then CheckChange(6, 7, 5, sender)
    End Sub
    Private Sub C676_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C676.CheckedChanged
        If stepChange = False Then CheckChange(6, 7, 6, sender)
    End Sub
    Private Sub C677_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C677.CheckedChanged
        If stepChange = False Then CheckChange(6, 7, 7, sender)
    End Sub
    Private Sub C678_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C678.CheckedChanged
        If stepChange = False Then CheckChange(6, 7, 8, sender)
    End Sub
    Private Sub C681_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C681.CheckedChanged
        If stepChange = False Then CheckChange(6, 8, 1, sender)
    End Sub
    Private Sub C682_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C682.CheckedChanged
        If stepChange = False Then CheckChange(6, 8, 2, sender)
    End Sub
    Private Sub C683_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C683.CheckedChanged
        If stepChange = False Then CheckChange(6, 8, 3, sender)
    End Sub
    Private Sub C684_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C684.CheckedChanged
        If stepChange = False Then CheckChange(6, 8, 4, sender)
    End Sub
    Private Sub C685_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C685.CheckedChanged
        If stepChange = False Then CheckChange(6, 8, 5, sender)
    End Sub
    Private Sub C686_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C686.CheckedChanged
        If stepChange = False Then CheckChange(6, 8, 6, sender)
    End Sub
    Private Sub C687_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C687.CheckedChanged
        If stepChange = False Then CheckChange(6, 8, 7, sender)
    End Sub
    Private Sub C688_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C688.CheckedChanged
        If stepChange = False Then CheckChange(6, 8, 8, sender)
    End Sub
    Private Sub C711_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C711.CheckedChanged
        If stepChange = False Then CheckChange(7, 1, 1, sender)
    End Sub
    Private Sub C712_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C712.CheckedChanged
        If stepChange = False Then CheckChange(7, 1, 2, sender)
    End Sub
    Private Sub C713_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C713.CheckedChanged
        If stepChange = False Then CheckChange(7, 1, 3, sender)
    End Sub
    Private Sub C714_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C714.CheckedChanged
        If stepChange = False Then CheckChange(7, 1, 4, sender)
    End Sub
    Private Sub C715_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C715.CheckedChanged
        If stepChange = False Then CheckChange(7, 1, 5, sender)
    End Sub
    Private Sub C716_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C716.CheckedChanged
        If stepChange = False Then CheckChange(7, 1, 6, sender)
    End Sub
    Private Sub C717_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C717.CheckedChanged
        If stepChange = False Then CheckChange(7, 1, 7, sender)
    End Sub
    Private Sub C718_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C718.CheckedChanged
        If stepChange = False Then CheckChange(7, 1, 8, sender)
    End Sub
    Private Sub C721_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C721.CheckedChanged
        If stepChange = False Then CheckChange(7, 2, 1, sender)
    End Sub
    Private Sub C722_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C722.CheckedChanged
        If stepChange = False Then CheckChange(7, 2, 2, sender)
    End Sub
    Private Sub C723_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C723.CheckedChanged
        If stepChange = False Then CheckChange(7, 2, 3, sender)
    End Sub
    Private Sub C724_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C724.CheckedChanged
        If stepChange = False Then CheckChange(7, 2, 4, sender)
    End Sub
    Private Sub C725_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C725.CheckedChanged
        If stepChange = False Then CheckChange(7, 2, 5, sender)
    End Sub
    Private Sub C726_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C726.CheckedChanged
        If stepChange = False Then CheckChange(7, 2, 6, sender)
    End Sub
    Private Sub C727_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C727.CheckedChanged
        If stepChange = False Then CheckChange(7, 2, 7, sender)
    End Sub
    Private Sub C728_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C728.CheckedChanged
        If stepChange = False Then CheckChange(7, 2, 8, sender)
    End Sub
    Private Sub C731_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C731.CheckedChanged
        If stepChange = False Then CheckChange(7, 3, 1, sender)
    End Sub
    Private Sub C732_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C732.CheckedChanged
        If stepChange = False Then CheckChange(7, 3, 2, sender)
    End Sub
    Private Sub C733_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C733.CheckedChanged
        If stepChange = False Then CheckChange(7, 3, 3, sender)
    End Sub
    Private Sub C734_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C734.CheckedChanged
        If stepChange = False Then CheckChange(7, 3, 4, sender)
    End Sub
    Private Sub C735_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C735.CheckedChanged
        If stepChange = False Then CheckChange(7, 3, 5, sender)
    End Sub
    Private Sub C736_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C736.CheckedChanged
        If stepChange = False Then CheckChange(7, 3, 6, sender)
    End Sub
    Private Sub C737_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C737.CheckedChanged
        If stepChange = False Then CheckChange(7, 3, 7, sender)
    End Sub
    Private Sub C738_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C738.CheckedChanged
        If stepChange = False Then CheckChange(7, 3, 8, sender)
    End Sub
    Private Sub C741_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C741.CheckedChanged
        If stepChange = False Then CheckChange(7, 4, 1, sender)
    End Sub
    Private Sub C742_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C742.CheckedChanged
        If stepChange = False Then CheckChange(7, 4, 2, sender)
    End Sub
    Private Sub C743_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C743.CheckedChanged
        If stepChange = False Then CheckChange(7, 4, 3, sender)
    End Sub
    Private Sub C744_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C744.CheckedChanged
        If stepChange = False Then CheckChange(7, 4, 4, sender)
    End Sub
    Private Sub C745_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C745.CheckedChanged
        If stepChange = False Then CheckChange(7, 4, 5, sender)
    End Sub
    Private Sub C746_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C746.CheckedChanged
        If stepChange = False Then CheckChange(7, 4, 6, sender)
    End Sub
    Private Sub C747_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C747.CheckedChanged
        If stepChange = False Then CheckChange(7, 4, 7, sender)
    End Sub
    Private Sub C748_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C748.CheckedChanged
        If stepChange = False Then CheckChange(7, 4, 8, sender)
    End Sub
    Private Sub C751_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C751.CheckedChanged
        If stepChange = False Then CheckChange(7, 5, 1, sender)
    End Sub
    Private Sub C752_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C752.CheckedChanged
        If stepChange = False Then CheckChange(7, 5, 2, sender)
    End Sub
    Private Sub C753_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C753.CheckedChanged
        If stepChange = False Then CheckChange(7, 5, 3, sender)
    End Sub
    Private Sub C754_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C754.CheckedChanged
        If stepChange = False Then CheckChange(7, 5, 4, sender)
    End Sub
    Private Sub C755_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C755.CheckedChanged
        If stepChange = False Then CheckChange(7, 5, 5, sender)
    End Sub
    Private Sub C756_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C756.CheckedChanged
        If stepChange = False Then CheckChange(7, 5, 6, sender)
    End Sub
    Private Sub C757_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C757.CheckedChanged
        If stepChange = False Then CheckChange(7, 5, 7, sender)
    End Sub
    Private Sub C758_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C758.CheckedChanged
        If stepChange = False Then CheckChange(7, 5, 8, sender)
    End Sub
    Private Sub C761_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C761.CheckedChanged
        If stepChange = False Then CheckChange(7, 6, 1, sender)
    End Sub
    Private Sub C762_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C762.CheckedChanged
        If stepChange = False Then CheckChange(7, 6, 2, sender)
    End Sub
    Private Sub C763_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C763.CheckedChanged
        If stepChange = False Then CheckChange(7, 6, 3, sender)
    End Sub
    Private Sub C764_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C764.CheckedChanged
        If stepChange = False Then CheckChange(7, 6, 4, sender)
    End Sub
    Private Sub C765_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C765.CheckedChanged
        If stepChange = False Then CheckChange(7, 6, 5, sender)
    End Sub
    Private Sub C766_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C766.CheckedChanged
        If stepChange = False Then CheckChange(7, 6, 6, sender)
    End Sub
    Private Sub C767_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C767.CheckedChanged
        If stepChange = False Then CheckChange(7, 6, 7, sender)
    End Sub
    Private Sub C768_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C768.CheckedChanged
        If stepChange = False Then CheckChange(7, 6, 8, sender)
    End Sub
    Private Sub C771_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C771.CheckedChanged
        If stepChange = False Then CheckChange(7, 7, 1, sender)
    End Sub
    Private Sub C772_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C772.CheckedChanged
        If stepChange = False Then CheckChange(7, 7, 2, sender)
    End Sub
    Private Sub C773_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C773.CheckedChanged
        If stepChange = False Then CheckChange(7, 7, 3, sender)
    End Sub
    Private Sub C774_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C774.CheckedChanged
        If stepChange = False Then CheckChange(7, 7, 4, sender)
    End Sub
    Private Sub C775_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C775.CheckedChanged
        If stepChange = False Then CheckChange(7, 7, 5, sender)
    End Sub
    Private Sub C776_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C776.CheckedChanged
        If stepChange = False Then CheckChange(7, 7, 6, sender)
    End Sub
    Private Sub C777_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C777.CheckedChanged
        If stepChange = False Then CheckChange(7, 7, 7, sender)
    End Sub
    Private Sub C778_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C778.CheckedChanged
        If stepChange = False Then CheckChange(7, 7, 8, sender)
    End Sub
    Private Sub C781_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C781.CheckedChanged
        If stepChange = False Then CheckChange(7, 8, 1, sender)
    End Sub
    Private Sub C782_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C782.CheckedChanged
        If stepChange = False Then CheckChange(7, 8, 2, sender)
    End Sub
    Private Sub C783_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C783.CheckedChanged
        If stepChange = False Then CheckChange(7, 8, 3, sender)
    End Sub
    Private Sub C784_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C784.CheckedChanged
        If stepChange = False Then CheckChange(7, 8, 4, sender)
    End Sub
    Private Sub C785_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C785.CheckedChanged
        If stepChange = False Then CheckChange(7, 8, 5, sender)
    End Sub
    Private Sub C786_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C786.CheckedChanged
        If stepChange = False Then CheckChange(7, 8, 6, sender)
    End Sub
    Private Sub C787_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C787.CheckedChanged
        If stepChange = False Then CheckChange(7, 8, 7, sender)
    End Sub
    Private Sub C788_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C788.CheckedChanged
        If stepChange = False Then CheckChange(7, 8, 8, sender)
    End Sub
    Private Sub C811_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C811.CheckedChanged
        If stepChange = False Then CheckChange(8, 1, 1, sender)
    End Sub
    Private Sub C812_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C812.CheckedChanged
        If stepChange = False Then CheckChange(8, 1, 2, sender)
    End Sub
    Private Sub C813_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C813.CheckedChanged
        If stepChange = False Then CheckChange(8, 1, 3, sender)
    End Sub
    Private Sub C814_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C814.CheckedChanged
        If stepChange = False Then CheckChange(8, 1, 4, sender)
    End Sub
    Private Sub C815_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C815.CheckedChanged
        If stepChange = False Then CheckChange(8, 1, 5, sender)
    End Sub
    Private Sub C816_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C816.CheckedChanged
        If stepChange = False Then CheckChange(8, 1, 6, sender)
    End Sub
    Private Sub C817_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C817.CheckedChanged
        If stepChange = False Then CheckChange(8, 1, 7, sender)
    End Sub
    Private Sub C818_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C818.CheckedChanged
        If stepChange = False Then CheckChange(8, 1, 8, sender)
    End Sub
    Private Sub C821_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C821.CheckedChanged
        If stepChange = False Then CheckChange(8, 2, 1, sender)
    End Sub
    Private Sub C822_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C822.CheckedChanged
        If stepChange = False Then CheckChange(8, 2, 2, sender)
    End Sub
    Private Sub C823_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C823.CheckedChanged
        If stepChange = False Then CheckChange(8, 2, 3, sender)
    End Sub
    Private Sub C824_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C824.CheckedChanged
        If stepChange = False Then CheckChange(8, 2, 4, sender)
    End Sub
    Private Sub C825_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C825.CheckedChanged
        If stepChange = False Then CheckChange(8, 2, 5, sender)
    End Sub
    Private Sub C826_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C826.CheckedChanged
        If stepChange = False Then CheckChange(8, 2, 6, sender)
    End Sub
    Private Sub C827_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C827.CheckedChanged
        If stepChange = False Then CheckChange(8, 2, 7, sender)
    End Sub
    Private Sub C828_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C828.CheckedChanged
        If stepChange = False Then CheckChange(8, 2, 8, sender)
    End Sub
    Private Sub C831_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C831.CheckedChanged
        If stepChange = False Then CheckChange(8, 3, 1, sender)
    End Sub
    Private Sub C832_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C832.CheckedChanged
        If stepChange = False Then CheckChange(8, 3, 2, sender)
    End Sub
    Private Sub C833_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C833.CheckedChanged
        If stepChange = False Then CheckChange(8, 3, 3, sender)
    End Sub
    Private Sub C834_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C834.CheckedChanged
        If stepChange = False Then CheckChange(8, 3, 4, sender)
    End Sub
    Private Sub C835_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C835.CheckedChanged
        If stepChange = False Then CheckChange(8, 3, 5, sender)
    End Sub
    Private Sub C836_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C836.CheckedChanged
        If stepChange = False Then CheckChange(8, 3, 6, sender)
    End Sub
    Private Sub C837_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C837.CheckedChanged
        If stepChange = False Then CheckChange(8, 3, 7, sender)
    End Sub
    Private Sub C838_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C838.CheckedChanged
        If stepChange = False Then CheckChange(8, 3, 8, sender)
    End Sub
    Private Sub C841_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C841.CheckedChanged
        If stepChange = False Then CheckChange(8, 4, 1, sender)
    End Sub
    Private Sub C842_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C842.CheckedChanged
        If stepChange = False Then CheckChange(8, 4, 2, sender)
    End Sub
    Private Sub C843_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C843.CheckedChanged
        If stepChange = False Then CheckChange(8, 4, 3, sender)
    End Sub
    Private Sub C844_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C844.CheckedChanged
        If stepChange = False Then CheckChange(8, 4, 4, sender)
    End Sub
    Private Sub C845_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C845.CheckedChanged
        If stepChange = False Then CheckChange(8, 4, 5, sender)
    End Sub
    Private Sub C846_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C846.CheckedChanged
        If stepChange = False Then CheckChange(8, 4, 6, sender)
    End Sub
    Private Sub C847_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C847.CheckedChanged
        If stepChange = False Then CheckChange(8, 4, 7, sender)
    End Sub
    Private Sub C848_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C848.CheckedChanged
        If stepChange = False Then CheckChange(8, 4, 8, sender)
    End Sub
    Private Sub C851_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C851.CheckedChanged
        If stepChange = False Then CheckChange(8, 5, 1, sender)
    End Sub
    Private Sub C852_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C852.CheckedChanged
        If stepChange = False Then CheckChange(8, 5, 2, sender)
    End Sub
    Private Sub C853_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C853.CheckedChanged
        If stepChange = False Then CheckChange(8, 5, 3, sender)
    End Sub
    Private Sub C854_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C854.CheckedChanged
        If stepChange = False Then CheckChange(8, 5, 4, sender)
    End Sub
    Private Sub C855_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C855.CheckedChanged
        If stepChange = False Then CheckChange(8, 5, 5, sender)
    End Sub
    Private Sub C856_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C856.CheckedChanged
        If stepChange = False Then CheckChange(8, 5, 6, sender)
    End Sub
    Private Sub C857_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C857.CheckedChanged
        If stepChange = False Then CheckChange(8, 5, 7, sender)
    End Sub
    Private Sub C858_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C858.CheckedChanged
        If stepChange = False Then CheckChange(8, 5, 8, sender)
    End Sub
    Private Sub C861_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C861.CheckedChanged
        If stepChange = False Then CheckChange(8, 6, 1, sender)
    End Sub
    Private Sub C862_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C862.CheckedChanged
        If stepChange = False Then CheckChange(8, 6, 2, sender)
    End Sub
    Private Sub C863_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C863.CheckedChanged
        If stepChange = False Then CheckChange(8, 6, 3, sender)
    End Sub
    Private Sub C864_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C864.CheckedChanged
        If stepChange = False Then CheckChange(8, 6, 4, sender)
    End Sub
    Private Sub C865_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C865.CheckedChanged
        If stepChange = False Then CheckChange(8, 6, 5, sender)
    End Sub
    Private Sub C866_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C866.CheckedChanged
        If stepChange = False Then CheckChange(8, 6, 6, sender)
    End Sub
    Private Sub C867_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C867.CheckedChanged
        If stepChange = False Then CheckChange(8, 6, 7, sender)
    End Sub
    Private Sub C868_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C868.CheckedChanged
        If stepChange = False Then CheckChange(8, 6, 8, sender)
    End Sub
    Private Sub C871_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C871.CheckedChanged
        If stepChange = False Then CheckChange(8, 7, 1, sender)
    End Sub
    Private Sub C872_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C872.CheckedChanged
        If stepChange = False Then CheckChange(8, 7, 2, sender)
    End Sub
    Private Sub C873_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C873.CheckedChanged
        If stepChange = False Then CheckChange(8, 7, 3, sender)
    End Sub
    Private Sub C874_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C874.CheckedChanged
        If stepChange = False Then CheckChange(8, 7, 4, sender)
    End Sub
    Private Sub C875_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C875.CheckedChanged
        If stepChange = False Then CheckChange(8, 7, 5, sender)
    End Sub
    Private Sub C876_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C876.CheckedChanged
        If stepChange = False Then CheckChange(8, 7, 6, sender)
    End Sub
    Private Sub C877_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C877.CheckedChanged
        If stepChange = False Then CheckChange(8, 7, 7, sender)
    End Sub
    Private Sub C878_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C878.CheckedChanged
        If stepChange = False Then CheckChange(8, 7, 8, sender)
    End Sub
    Private Sub C881_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C881.CheckedChanged
        If stepChange = False Then CheckChange(8, 8, 1, sender)
    End Sub
    Private Sub C882_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C882.CheckedChanged
        If stepChange = False Then CheckChange(8, 8, 2, sender)
    End Sub
    Private Sub C883_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C883.CheckedChanged
        If stepChange = False Then CheckChange(8, 8, 3, sender)
    End Sub
    Private Sub C884_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C884.CheckedChanged
        If stepChange = False Then CheckChange(8, 8, 4, sender)
    End Sub
    Private Sub C885_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C885.CheckedChanged
        If stepChange = False Then CheckChange(8, 8, 5, sender)
    End Sub
    Private Sub C886_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C886.CheckedChanged
        If stepChange = False Then CheckChange(8, 8, 6, sender)
    End Sub
    Private Sub C887_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C887.CheckedChanged
        If stepChange = False Then CheckChange(8, 8, 7, sender)
    End Sub
    Private Sub C888_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C888.CheckedChanged
        If stepChange = False Then CheckChange(8, 8, 8, sender)
    End Sub


    Private Sub setGrid()

        If C111.Checked Then grid3d(0, 0, 0) = 1 Else grid3d(0, 0, 0) = 0
        If C112.Checked Then grid3d(0, 0, 1) = 1 Else grid3d(0, 0, 1) = 0
        If C113.Checked Then grid3d(0, 0, 2) = 1 Else grid3d(0, 0, 2) = 0
        If C114.Checked Then grid3d(0, 0, 3) = 1 Else grid3d(0, 0, 3) = 0
        If C115.Checked Then grid3d(0, 0, 4) = 1 Else grid3d(0, 0, 4) = 0
        If C116.Checked Then grid3d(0, 0, 5) = 1 Else grid3d(0, 0, 5) = 0
        If C117.Checked Then grid3d(0, 0, 6) = 1 Else grid3d(0, 0, 6) = 0
        If C118.Checked Then grid3d(0, 0, 7) = 1 Else grid3d(0, 0, 7) = 0
        If C121.Checked Then grid3d(0, 1, 0) = 1 Else grid3d(0, 1, 0) = 0
        If C122.Checked Then grid3d(0, 1, 1) = 1 Else grid3d(0, 1, 1) = 0
        If C123.Checked Then grid3d(0, 1, 2) = 1 Else grid3d(0, 1, 2) = 0
        If C124.Checked Then grid3d(0, 1, 3) = 1 Else grid3d(0, 1, 3) = 0
        If C125.Checked Then grid3d(0, 1, 4) = 1 Else grid3d(0, 1, 4) = 0
        If C126.Checked Then grid3d(0, 1, 5) = 1 Else grid3d(0, 1, 5) = 0
        If C127.Checked Then grid3d(0, 1, 6) = 1 Else grid3d(0, 1, 6) = 0
        If C128.Checked Then grid3d(0, 1, 7) = 1 Else grid3d(0, 1, 7) = 0
        If C131.Checked Then grid3d(0, 2, 0) = 1 Else grid3d(0, 2, 0) = 0
        If C132.Checked Then grid3d(0, 2, 1) = 1 Else grid3d(0, 2, 1) = 0
        If C133.Checked Then grid3d(0, 2, 2) = 1 Else grid3d(0, 2, 2) = 0
        If C134.Checked Then grid3d(0, 2, 3) = 1 Else grid3d(0, 2, 3) = 0
        If C135.Checked Then grid3d(0, 2, 4) = 1 Else grid3d(0, 2, 4) = 0
        If C136.Checked Then grid3d(0, 2, 5) = 1 Else grid3d(0, 2, 5) = 0
        If C137.Checked Then grid3d(0, 2, 6) = 1 Else grid3d(0, 2, 6) = 0
        If C138.Checked Then grid3d(0, 2, 7) = 1 Else grid3d(0, 2, 7) = 0
        If C141.Checked Then grid3d(0, 3, 0) = 1 Else grid3d(0, 3, 0) = 0
        If C142.Checked Then grid3d(0, 3, 1) = 1 Else grid3d(0, 3, 1) = 0
        If C143.Checked Then grid3d(0, 3, 2) = 1 Else grid3d(0, 3, 2) = 0
        If C144.Checked Then grid3d(0, 3, 3) = 1 Else grid3d(0, 3, 3) = 0
        If C145.Checked Then grid3d(0, 3, 4) = 1 Else grid3d(0, 3, 4) = 0
        If C146.Checked Then grid3d(0, 3, 5) = 1 Else grid3d(0, 3, 5) = 0
        If C147.Checked Then grid3d(0, 3, 6) = 1 Else grid3d(0, 3, 6) = 0
        If C148.Checked Then grid3d(0, 3, 7) = 1 Else grid3d(0, 3, 7) = 0
        If C151.Checked Then grid3d(0, 4, 0) = 1 Else grid3d(0, 4, 0) = 0
        If C152.Checked Then grid3d(0, 4, 1) = 1 Else grid3d(0, 4, 1) = 0
        If C153.Checked Then grid3d(0, 4, 2) = 1 Else grid3d(0, 4, 2) = 0
        If C154.Checked Then grid3d(0, 4, 3) = 1 Else grid3d(0, 4, 3) = 0
        If C155.Checked Then grid3d(0, 4, 4) = 1 Else grid3d(0, 4, 4) = 0
        If C156.Checked Then grid3d(0, 4, 5) = 1 Else grid3d(0, 4, 5) = 0
        If C157.Checked Then grid3d(0, 4, 6) = 1 Else grid3d(0, 4, 6) = 0
        If C158.Checked Then grid3d(0, 4, 7) = 1 Else grid3d(0, 4, 7) = 0
        If C161.Checked Then grid3d(0, 5, 0) = 1 Else grid3d(0, 5, 0) = 0
        If C162.Checked Then grid3d(0, 5, 1) = 1 Else grid3d(0, 5, 1) = 0
        If C163.Checked Then grid3d(0, 5, 2) = 1 Else grid3d(0, 5, 2) = 0
        If C164.Checked Then grid3d(0, 5, 3) = 1 Else grid3d(0, 5, 3) = 0
        If C165.Checked Then grid3d(0, 5, 4) = 1 Else grid3d(0, 5, 4) = 0
        If C166.Checked Then grid3d(0, 5, 5) = 1 Else grid3d(0, 5, 5) = 0
        If C167.Checked Then grid3d(0, 5, 6) = 1 Else grid3d(0, 5, 6) = 0
        If C168.Checked Then grid3d(0, 5, 7) = 1 Else grid3d(0, 5, 7) = 0
        If C171.Checked Then grid3d(0, 6, 0) = 1 Else grid3d(0, 6, 0) = 0
        If C172.Checked Then grid3d(0, 6, 1) = 1 Else grid3d(0, 6, 1) = 0
        If C173.Checked Then grid3d(0, 6, 2) = 1 Else grid3d(0, 6, 2) = 0
        If C174.Checked Then grid3d(0, 6, 3) = 1 Else grid3d(0, 6, 3) = 0
        If C175.Checked Then grid3d(0, 6, 4) = 1 Else grid3d(0, 6, 4) = 0
        If C176.Checked Then grid3d(0, 6, 5) = 1 Else grid3d(0, 6, 5) = 0
        If C177.Checked Then grid3d(0, 6, 6) = 1 Else grid3d(0, 6, 6) = 0
        If C178.Checked Then grid3d(0, 6, 7) = 1 Else grid3d(0, 6, 7) = 0
        If C181.Checked Then grid3d(0, 7, 0) = 1 Else grid3d(0, 7, 0) = 0
        If C182.Checked Then grid3d(0, 7, 1) = 1 Else grid3d(0, 7, 1) = 0
        If C183.Checked Then grid3d(0, 7, 2) = 1 Else grid3d(0, 7, 2) = 0
        If C184.Checked Then grid3d(0, 7, 3) = 1 Else grid3d(0, 7, 3) = 0
        If C185.Checked Then grid3d(0, 7, 4) = 1 Else grid3d(0, 7, 4) = 0
        If C186.Checked Then grid3d(0, 7, 5) = 1 Else grid3d(0, 7, 5) = 0
        If C187.Checked Then grid3d(0, 7, 6) = 1 Else grid3d(0, 7, 6) = 0
        If C188.Checked Then grid3d(0, 7, 7) = 1 Else grid3d(0, 7, 7) = 0
        If C211.Checked Then grid3d(1, 0, 0) = 1 Else grid3d(1, 0, 0) = 0
        If C212.Checked Then grid3d(1, 0, 1) = 1 Else grid3d(1, 0, 1) = 0
        If C213.Checked Then grid3d(1, 0, 2) = 1 Else grid3d(1, 0, 2) = 0
        If C214.Checked Then grid3d(1, 0, 3) = 1 Else grid3d(1, 0, 3) = 0
        If C215.Checked Then grid3d(1, 0, 4) = 1 Else grid3d(1, 0, 4) = 0
        If C216.Checked Then grid3d(1, 0, 5) = 1 Else grid3d(1, 0, 5) = 0
        If C217.Checked Then grid3d(1, 0, 6) = 1 Else grid3d(1, 0, 6) = 0
        If C218.Checked Then grid3d(1, 0, 7) = 1 Else grid3d(1, 0, 7) = 0
        If C221.Checked Then grid3d(1, 1, 0) = 1 Else grid3d(1, 1, 0) = 0
        If C222.Checked Then grid3d(1, 1, 1) = 1 Else grid3d(1, 1, 1) = 0
        If C223.Checked Then grid3d(1, 1, 2) = 1 Else grid3d(1, 1, 2) = 0
        If C224.Checked Then grid3d(1, 1, 3) = 1 Else grid3d(1, 1, 3) = 0
        If C225.Checked Then grid3d(1, 1, 4) = 1 Else grid3d(1, 1, 4) = 0
        If C226.Checked Then grid3d(1, 1, 5) = 1 Else grid3d(1, 1, 5) = 0
        If C227.Checked Then grid3d(1, 1, 6) = 1 Else grid3d(1, 1, 6) = 0
        If C228.Checked Then grid3d(1, 1, 7) = 1 Else grid3d(1, 1, 7) = 0
        If C231.Checked Then grid3d(1, 2, 0) = 1 Else grid3d(1, 2, 0) = 0
        If C232.Checked Then grid3d(1, 2, 1) = 1 Else grid3d(1, 2, 1) = 0
        If C233.Checked Then grid3d(1, 2, 2) = 1 Else grid3d(1, 2, 2) = 0
        If C234.Checked Then grid3d(1, 2, 3) = 1 Else grid3d(1, 2, 3) = 0
        If C235.Checked Then grid3d(1, 2, 4) = 1 Else grid3d(1, 2, 4) = 0
        If C236.Checked Then grid3d(1, 2, 5) = 1 Else grid3d(1, 2, 5) = 0
        If C237.Checked Then grid3d(1, 2, 6) = 1 Else grid3d(1, 2, 6) = 0
        If C238.Checked Then grid3d(1, 2, 7) = 1 Else grid3d(1, 2, 7) = 0
        If C241.Checked Then grid3d(1, 3, 0) = 1 Else grid3d(1, 3, 0) = 0
        If C242.Checked Then grid3d(1, 3, 1) = 1 Else grid3d(1, 3, 1) = 0
        If C243.Checked Then grid3d(1, 3, 2) = 1 Else grid3d(1, 3, 2) = 0
        If C244.Checked Then grid3d(1, 3, 3) = 1 Else grid3d(1, 3, 3) = 0
        If C245.Checked Then grid3d(1, 3, 4) = 1 Else grid3d(1, 3, 4) = 0
        If C246.Checked Then grid3d(1, 3, 5) = 1 Else grid3d(1, 3, 5) = 0
        If C247.Checked Then grid3d(1, 3, 6) = 1 Else grid3d(1, 3, 6) = 0
        If C248.Checked Then grid3d(1, 3, 7) = 1 Else grid3d(1, 3, 7) = 0
        If C251.Checked Then grid3d(1, 4, 0) = 1 Else grid3d(1, 4, 0) = 0
        If C252.Checked Then grid3d(1, 4, 1) = 1 Else grid3d(1, 4, 1) = 0
        If C253.Checked Then grid3d(1, 4, 2) = 1 Else grid3d(1, 4, 2) = 0
        If C254.Checked Then grid3d(1, 4, 3) = 1 Else grid3d(1, 4, 3) = 0
        If C255.Checked Then grid3d(1, 4, 4) = 1 Else grid3d(1, 4, 4) = 0
        If C256.Checked Then grid3d(1, 4, 5) = 1 Else grid3d(1, 4, 5) = 0
        If C257.Checked Then grid3d(1, 4, 6) = 1 Else grid3d(1, 4, 6) = 0
        If C258.Checked Then grid3d(1, 4, 7) = 1 Else grid3d(1, 4, 7) = 0
        If C261.Checked Then grid3d(1, 5, 0) = 1 Else grid3d(1, 5, 0) = 0
        If C262.Checked Then grid3d(1, 5, 1) = 1 Else grid3d(1, 5, 1) = 0
        If C263.Checked Then grid3d(1, 5, 2) = 1 Else grid3d(1, 5, 2) = 0
        If C264.Checked Then grid3d(1, 5, 3) = 1 Else grid3d(1, 5, 3) = 0
        If C265.Checked Then grid3d(1, 5, 4) = 1 Else grid3d(1, 5, 4) = 0
        If C266.Checked Then grid3d(1, 5, 5) = 1 Else grid3d(1, 5, 5) = 0
        If C267.Checked Then grid3d(1, 5, 6) = 1 Else grid3d(1, 5, 6) = 0
        If C268.Checked Then grid3d(1, 5, 7) = 1 Else grid3d(1, 5, 7) = 0
        If C271.Checked Then grid3d(1, 6, 0) = 1 Else grid3d(1, 6, 0) = 0
        If C272.Checked Then grid3d(1, 6, 1) = 1 Else grid3d(1, 6, 1) = 0
        If C273.Checked Then grid3d(1, 6, 2) = 1 Else grid3d(1, 6, 2) = 0
        If C274.Checked Then grid3d(1, 6, 3) = 1 Else grid3d(1, 6, 3) = 0
        If C275.Checked Then grid3d(1, 6, 4) = 1 Else grid3d(1, 6, 4) = 0
        If C276.Checked Then grid3d(1, 6, 5) = 1 Else grid3d(1, 6, 5) = 0
        If C277.Checked Then grid3d(1, 6, 6) = 1 Else grid3d(1, 6, 6) = 0
        If C278.Checked Then grid3d(1, 6, 7) = 1 Else grid3d(1, 6, 7) = 0
        If C281.Checked Then grid3d(1, 7, 0) = 1 Else grid3d(1, 7, 0) = 0
        If C282.Checked Then grid3d(1, 7, 1) = 1 Else grid3d(1, 7, 1) = 0
        If C283.Checked Then grid3d(1, 7, 2) = 1 Else grid3d(1, 7, 2) = 0
        If C284.Checked Then grid3d(1, 7, 3) = 1 Else grid3d(1, 7, 3) = 0
        If C285.Checked Then grid3d(1, 7, 4) = 1 Else grid3d(1, 7, 4) = 0
        If C286.Checked Then grid3d(1, 7, 5) = 1 Else grid3d(1, 7, 5) = 0
        If C287.Checked Then grid3d(1, 7, 6) = 1 Else grid3d(1, 7, 6) = 0
        If C288.Checked Then grid3d(1, 7, 7) = 1 Else grid3d(1, 7, 7) = 0
        If C311.Checked Then grid3d(2, 0, 0) = 1 Else grid3d(2, 0, 0) = 0
        If C312.Checked Then grid3d(2, 0, 1) = 1 Else grid3d(2, 0, 1) = 0
        If C313.Checked Then grid3d(2, 0, 2) = 1 Else grid3d(2, 0, 2) = 0
        If C314.Checked Then grid3d(2, 0, 3) = 1 Else grid3d(2, 0, 3) = 0
        If C315.Checked Then grid3d(2, 0, 4) = 1 Else grid3d(2, 0, 4) = 0
        If C316.Checked Then grid3d(2, 0, 5) = 1 Else grid3d(2, 0, 5) = 0
        If C317.Checked Then grid3d(2, 0, 6) = 1 Else grid3d(2, 0, 6) = 0
        If C318.Checked Then grid3d(2, 0, 7) = 1 Else grid3d(2, 0, 7) = 0
        If C321.Checked Then grid3d(2, 1, 0) = 1 Else grid3d(2, 1, 0) = 0
        If C322.Checked Then grid3d(2, 1, 1) = 1 Else grid3d(2, 1, 1) = 0
        If C323.Checked Then grid3d(2, 1, 2) = 1 Else grid3d(2, 1, 2) = 0
        If C324.Checked Then grid3d(2, 1, 3) = 1 Else grid3d(2, 1, 3) = 0
        If C325.Checked Then grid3d(2, 1, 4) = 1 Else grid3d(2, 1, 4) = 0
        If C326.Checked Then grid3d(2, 1, 5) = 1 Else grid3d(2, 1, 5) = 0
        If C327.Checked Then grid3d(2, 1, 6) = 1 Else grid3d(2, 1, 6) = 0
        If C328.Checked Then grid3d(2, 1, 7) = 1 Else grid3d(2, 1, 7) = 0
        If C331.Checked Then grid3d(2, 2, 0) = 1 Else grid3d(2, 2, 0) = 0
        If C332.Checked Then grid3d(2, 2, 1) = 1 Else grid3d(2, 2, 1) = 0
        If C333.Checked Then grid3d(2, 2, 2) = 1 Else grid3d(2, 2, 2) = 0
        If C334.Checked Then grid3d(2, 2, 3) = 1 Else grid3d(2, 2, 3) = 0
        If C335.Checked Then grid3d(2, 2, 4) = 1 Else grid3d(2, 2, 4) = 0
        If C336.Checked Then grid3d(2, 2, 5) = 1 Else grid3d(2, 2, 5) = 0
        If C337.Checked Then grid3d(2, 2, 6) = 1 Else grid3d(2, 2, 6) = 0
        If C338.Checked Then grid3d(2, 2, 7) = 1 Else grid3d(2, 2, 7) = 0
        If C341.Checked Then grid3d(2, 3, 0) = 1 Else grid3d(2, 3, 0) = 0
        If C342.Checked Then grid3d(2, 3, 1) = 1 Else grid3d(2, 3, 1) = 0
        If C343.Checked Then grid3d(2, 3, 2) = 1 Else grid3d(2, 3, 2) = 0
        If C344.Checked Then grid3d(2, 3, 3) = 1 Else grid3d(2, 3, 3) = 0
        If C345.Checked Then grid3d(2, 3, 4) = 1 Else grid3d(2, 3, 4) = 0
        If C346.Checked Then grid3d(2, 3, 5) = 1 Else grid3d(2, 3, 5) = 0
        If C347.Checked Then grid3d(2, 3, 6) = 1 Else grid3d(2, 3, 6) = 0
        If C348.Checked Then grid3d(2, 3, 7) = 1 Else grid3d(2, 3, 7) = 0
        If C351.Checked Then grid3d(2, 4, 0) = 1 Else grid3d(2, 4, 0) = 0
        If C352.Checked Then grid3d(2, 4, 1) = 1 Else grid3d(2, 4, 1) = 0
        If C353.Checked Then grid3d(2, 4, 2) = 1 Else grid3d(2, 4, 2) = 0
        If C354.Checked Then grid3d(2, 4, 3) = 1 Else grid3d(2, 4, 3) = 0
        If C355.Checked Then grid3d(2, 4, 4) = 1 Else grid3d(2, 4, 4) = 0
        If C356.Checked Then grid3d(2, 4, 5) = 1 Else grid3d(2, 4, 5) = 0
        If C357.Checked Then grid3d(2, 4, 6) = 1 Else grid3d(2, 4, 6) = 0
        If C358.Checked Then grid3d(2, 4, 7) = 1 Else grid3d(2, 4, 7) = 0
        If C361.Checked Then grid3d(2, 5, 0) = 1 Else grid3d(2, 5, 0) = 0
        If C362.Checked Then grid3d(2, 5, 1) = 1 Else grid3d(2, 5, 1) = 0
        If C363.Checked Then grid3d(2, 5, 2) = 1 Else grid3d(2, 5, 2) = 0
        If C364.Checked Then grid3d(2, 5, 3) = 1 Else grid3d(2, 5, 3) = 0
        If C365.Checked Then grid3d(2, 5, 4) = 1 Else grid3d(2, 5, 4) = 0
        If C366.Checked Then grid3d(2, 5, 5) = 1 Else grid3d(2, 5, 5) = 0
        If C367.Checked Then grid3d(2, 5, 6) = 1 Else grid3d(2, 5, 6) = 0
        If C368.Checked Then grid3d(2, 5, 7) = 1 Else grid3d(2, 5, 7) = 0
        If C371.Checked Then grid3d(2, 6, 0) = 1 Else grid3d(2, 6, 0) = 0
        If C372.Checked Then grid3d(2, 6, 1) = 1 Else grid3d(2, 6, 1) = 0
        If C373.Checked Then grid3d(2, 6, 2) = 1 Else grid3d(2, 6, 2) = 0
        If C374.Checked Then grid3d(2, 6, 3) = 1 Else grid3d(2, 6, 3) = 0
        If C375.Checked Then grid3d(2, 6, 4) = 1 Else grid3d(2, 6, 4) = 0
        If C376.Checked Then grid3d(2, 6, 5) = 1 Else grid3d(2, 6, 5) = 0
        If C377.Checked Then grid3d(2, 6, 6) = 1 Else grid3d(2, 6, 6) = 0
        If C378.Checked Then grid3d(2, 6, 7) = 1 Else grid3d(2, 6, 7) = 0
        If C381.Checked Then grid3d(2, 7, 0) = 1 Else grid3d(2, 7, 0) = 0
        If C382.Checked Then grid3d(2, 7, 1) = 1 Else grid3d(2, 7, 1) = 0
        If C383.Checked Then grid3d(2, 7, 2) = 1 Else grid3d(2, 7, 2) = 0
        If C384.Checked Then grid3d(2, 7, 3) = 1 Else grid3d(2, 7, 3) = 0
        If C385.Checked Then grid3d(2, 7, 4) = 1 Else grid3d(2, 7, 4) = 0
        If C386.Checked Then grid3d(2, 7, 5) = 1 Else grid3d(2, 7, 5) = 0
        If C387.Checked Then grid3d(2, 7, 6) = 1 Else grid3d(2, 7, 6) = 0
        If C388.Checked Then grid3d(2, 7, 7) = 1 Else grid3d(2, 7, 7) = 0
        If C411.Checked Then grid3d(3, 0, 0) = 1 Else grid3d(3, 0, 0) = 0
        If C412.Checked Then grid3d(3, 0, 1) = 1 Else grid3d(3, 0, 1) = 0
        If C413.Checked Then grid3d(3, 0, 2) = 1 Else grid3d(3, 0, 2) = 0
        If C414.Checked Then grid3d(3, 0, 3) = 1 Else grid3d(3, 0, 3) = 0
        If C415.Checked Then grid3d(3, 0, 4) = 1 Else grid3d(3, 0, 4) = 0
        If C416.Checked Then grid3d(3, 0, 5) = 1 Else grid3d(3, 0, 5) = 0
        If C417.Checked Then grid3d(3, 0, 6) = 1 Else grid3d(3, 0, 6) = 0
        If C418.Checked Then grid3d(3, 0, 7) = 1 Else grid3d(3, 0, 7) = 0
        If C421.Checked Then grid3d(3, 1, 0) = 1 Else grid3d(3, 1, 0) = 0
        If C422.Checked Then grid3d(3, 1, 1) = 1 Else grid3d(3, 1, 1) = 0
        If C423.Checked Then grid3d(3, 1, 2) = 1 Else grid3d(3, 1, 2) = 0
        If C424.Checked Then grid3d(3, 1, 3) = 1 Else grid3d(3, 1, 3) = 0
        If C425.Checked Then grid3d(3, 1, 4) = 1 Else grid3d(3, 1, 4) = 0
        If C426.Checked Then grid3d(3, 1, 5) = 1 Else grid3d(3, 1, 5) = 0
        If C427.Checked Then grid3d(3, 1, 6) = 1 Else grid3d(3, 1, 6) = 0
        If C428.Checked Then grid3d(3, 1, 7) = 1 Else grid3d(3, 1, 7) = 0
        If C431.Checked Then grid3d(3, 2, 0) = 1 Else grid3d(3, 2, 0) = 0
        If C432.Checked Then grid3d(3, 2, 1) = 1 Else grid3d(3, 2, 1) = 0
        If C433.Checked Then grid3d(3, 2, 2) = 1 Else grid3d(3, 2, 2) = 0
        If C434.Checked Then grid3d(3, 2, 3) = 1 Else grid3d(3, 2, 3) = 0
        If C435.Checked Then grid3d(3, 2, 4) = 1 Else grid3d(3, 2, 4) = 0
        If C436.Checked Then grid3d(3, 2, 5) = 1 Else grid3d(3, 2, 5) = 0
        If C437.Checked Then grid3d(3, 2, 6) = 1 Else grid3d(3, 2, 6) = 0
        If C438.Checked Then grid3d(3, 2, 7) = 1 Else grid3d(3, 2, 7) = 0
        If C441.Checked Then grid3d(3, 3, 0) = 1 Else grid3d(3, 3, 0) = 0
        If C442.Checked Then grid3d(3, 3, 1) = 1 Else grid3d(3, 3, 1) = 0
        If C443.Checked Then grid3d(3, 3, 2) = 1 Else grid3d(3, 3, 2) = 0
        If C444.Checked Then grid3d(3, 3, 3) = 1 Else grid3d(3, 3, 3) = 0
        If C445.Checked Then grid3d(3, 3, 4) = 1 Else grid3d(3, 3, 4) = 0
        If C446.Checked Then grid3d(3, 3, 5) = 1 Else grid3d(3, 3, 5) = 0
        If C447.Checked Then grid3d(3, 3, 6) = 1 Else grid3d(3, 3, 6) = 0
        If C448.Checked Then grid3d(3, 3, 7) = 1 Else grid3d(3, 3, 7) = 0
        If C451.Checked Then grid3d(3, 4, 0) = 1 Else grid3d(3, 4, 0) = 0
        If C452.Checked Then grid3d(3, 4, 1) = 1 Else grid3d(3, 4, 1) = 0
        If C453.Checked Then grid3d(3, 4, 2) = 1 Else grid3d(3, 4, 2) = 0
        If C454.Checked Then grid3d(3, 4, 3) = 1 Else grid3d(3, 4, 3) = 0
        If C455.Checked Then grid3d(3, 4, 4) = 1 Else grid3d(3, 4, 4) = 0
        If C456.Checked Then grid3d(3, 4, 5) = 1 Else grid3d(3, 4, 5) = 0
        If C457.Checked Then grid3d(3, 4, 6) = 1 Else grid3d(3, 4, 6) = 0
        If C458.Checked Then grid3d(3, 4, 7) = 1 Else grid3d(3, 4, 7) = 0
        If C461.Checked Then grid3d(3, 5, 0) = 1 Else grid3d(3, 5, 0) = 0
        If C462.Checked Then grid3d(3, 5, 1) = 1 Else grid3d(3, 5, 1) = 0
        If C463.Checked Then grid3d(3, 5, 2) = 1 Else grid3d(3, 5, 2) = 0
        If C464.Checked Then grid3d(3, 5, 3) = 1 Else grid3d(3, 5, 3) = 0
        If C465.Checked Then grid3d(3, 5, 4) = 1 Else grid3d(3, 5, 4) = 0
        If C466.Checked Then grid3d(3, 5, 5) = 1 Else grid3d(3, 5, 5) = 0
        If C467.Checked Then grid3d(3, 5, 6) = 1 Else grid3d(3, 5, 6) = 0
        If C468.Checked Then grid3d(3, 5, 7) = 1 Else grid3d(3, 5, 7) = 0
        If C471.Checked Then grid3d(3, 6, 0) = 1 Else grid3d(3, 6, 0) = 0
        If C472.Checked Then grid3d(3, 6, 1) = 1 Else grid3d(3, 6, 1) = 0
        If C473.Checked Then grid3d(3, 6, 2) = 1 Else grid3d(3, 6, 2) = 0
        If C474.Checked Then grid3d(3, 6, 3) = 1 Else grid3d(3, 6, 3) = 0
        If C475.Checked Then grid3d(3, 6, 4) = 1 Else grid3d(3, 6, 4) = 0
        If C476.Checked Then grid3d(3, 6, 5) = 1 Else grid3d(3, 6, 5) = 0
        If C477.Checked Then grid3d(3, 6, 6) = 1 Else grid3d(3, 6, 6) = 0
        If C478.Checked Then grid3d(3, 6, 7) = 1 Else grid3d(3, 6, 7) = 0
        If C481.Checked Then grid3d(3, 7, 0) = 1 Else grid3d(3, 7, 0) = 0
        If C482.Checked Then grid3d(3, 7, 1) = 1 Else grid3d(3, 7, 1) = 0
        If C483.Checked Then grid3d(3, 7, 2) = 1 Else grid3d(3, 7, 2) = 0
        If C484.Checked Then grid3d(3, 7, 3) = 1 Else grid3d(3, 7, 3) = 0
        If C485.Checked Then grid3d(3, 7, 4) = 1 Else grid3d(3, 7, 4) = 0
        If C486.Checked Then grid3d(3, 7, 5) = 1 Else grid3d(3, 7, 5) = 0
        If C487.Checked Then grid3d(3, 7, 6) = 1 Else grid3d(3, 7, 6) = 0
        If C488.Checked Then grid3d(3, 7, 7) = 1 Else grid3d(3, 7, 7) = 0
        If C511.Checked Then grid3d(4, 0, 0) = 1 Else grid3d(4, 0, 0) = 0
        If C512.Checked Then grid3d(4, 0, 1) = 1 Else grid3d(4, 0, 1) = 0
        If C513.Checked Then grid3d(4, 0, 2) = 1 Else grid3d(4, 0, 2) = 0
        If C514.Checked Then grid3d(4, 0, 3) = 1 Else grid3d(4, 0, 3) = 0
        If C515.Checked Then grid3d(4, 0, 4) = 1 Else grid3d(4, 0, 4) = 0
        If C516.Checked Then grid3d(4, 0, 5) = 1 Else grid3d(4, 0, 5) = 0
        If C517.Checked Then grid3d(4, 0, 6) = 1 Else grid3d(4, 0, 6) = 0
        If C518.Checked Then grid3d(4, 0, 7) = 1 Else grid3d(4, 0, 7) = 0
        If C521.Checked Then grid3d(4, 1, 0) = 1 Else grid3d(4, 1, 0) = 0
        If C522.Checked Then grid3d(4, 1, 1) = 1 Else grid3d(4, 1, 1) = 0
        If C523.Checked Then grid3d(4, 1, 2) = 1 Else grid3d(4, 1, 2) = 0
        If C524.Checked Then grid3d(4, 1, 3) = 1 Else grid3d(4, 1, 3) = 0
        If C525.Checked Then grid3d(4, 1, 4) = 1 Else grid3d(4, 1, 4) = 0
        If C526.Checked Then grid3d(4, 1, 5) = 1 Else grid3d(4, 1, 5) = 0
        If C527.Checked Then grid3d(4, 1, 6) = 1 Else grid3d(4, 1, 6) = 0
        If C528.Checked Then grid3d(4, 1, 7) = 1 Else grid3d(4, 1, 7) = 0
        If C531.Checked Then grid3d(4, 2, 0) = 1 Else grid3d(4, 2, 0) = 0
        If C532.Checked Then grid3d(4, 2, 1) = 1 Else grid3d(4, 2, 1) = 0
        If C533.Checked Then grid3d(4, 2, 2) = 1 Else grid3d(4, 2, 2) = 0
        If C534.Checked Then grid3d(4, 2, 3) = 1 Else grid3d(4, 2, 3) = 0
        If C535.Checked Then grid3d(4, 2, 4) = 1 Else grid3d(4, 2, 4) = 0
        If C536.Checked Then grid3d(4, 2, 5) = 1 Else grid3d(4, 2, 5) = 0
        If C537.Checked Then grid3d(4, 2, 6) = 1 Else grid3d(4, 2, 6) = 0
        If C538.Checked Then grid3d(4, 2, 7) = 1 Else grid3d(4, 2, 7) = 0
        If C541.Checked Then grid3d(4, 3, 0) = 1 Else grid3d(4, 3, 0) = 0
        If C542.Checked Then grid3d(4, 3, 1) = 1 Else grid3d(4, 3, 1) = 0
        If C543.Checked Then grid3d(4, 3, 2) = 1 Else grid3d(4, 3, 2) = 0
        If C544.Checked Then grid3d(4, 3, 3) = 1 Else grid3d(4, 3, 3) = 0
        If C545.Checked Then grid3d(4, 3, 4) = 1 Else grid3d(4, 3, 4) = 0
        If C546.Checked Then grid3d(4, 3, 5) = 1 Else grid3d(4, 3, 5) = 0
        If C547.Checked Then grid3d(4, 3, 6) = 1 Else grid3d(4, 3, 6) = 0
        If C548.Checked Then grid3d(4, 3, 7) = 1 Else grid3d(4, 3, 7) = 0
        If C551.Checked Then grid3d(4, 4, 0) = 1 Else grid3d(4, 4, 0) = 0
        If C552.Checked Then grid3d(4, 4, 1) = 1 Else grid3d(4, 4, 1) = 0
        If C553.Checked Then grid3d(4, 4, 2) = 1 Else grid3d(4, 4, 2) = 0
        If C554.Checked Then grid3d(4, 4, 3) = 1 Else grid3d(4, 4, 3) = 0
        If C555.Checked Then grid3d(4, 4, 4) = 1 Else grid3d(4, 4, 4) = 0
        If C556.Checked Then grid3d(4, 4, 5) = 1 Else grid3d(4, 4, 5) = 0
        If C557.Checked Then grid3d(4, 4, 6) = 1 Else grid3d(4, 4, 6) = 0
        If C558.Checked Then grid3d(4, 4, 7) = 1 Else grid3d(4, 4, 7) = 0
        If C561.Checked Then grid3d(4, 5, 0) = 1 Else grid3d(4, 5, 0) = 0
        If C562.Checked Then grid3d(4, 5, 1) = 1 Else grid3d(4, 5, 1) = 0
        If C563.Checked Then grid3d(4, 5, 2) = 1 Else grid3d(4, 5, 2) = 0
        If C564.Checked Then grid3d(4, 5, 3) = 1 Else grid3d(4, 5, 3) = 0
        If C565.Checked Then grid3d(4, 5, 4) = 1 Else grid3d(4, 5, 4) = 0
        If C566.Checked Then grid3d(4, 5, 5) = 1 Else grid3d(4, 5, 5) = 0
        If C567.Checked Then grid3d(4, 5, 6) = 1 Else grid3d(4, 5, 6) = 0
        If C568.Checked Then grid3d(4, 5, 7) = 1 Else grid3d(4, 5, 7) = 0
        If C571.Checked Then grid3d(4, 6, 0) = 1 Else grid3d(4, 6, 0) = 0
        If C572.Checked Then grid3d(4, 6, 1) = 1 Else grid3d(4, 6, 1) = 0
        If C573.Checked Then grid3d(4, 6, 2) = 1 Else grid3d(4, 6, 2) = 0
        If C574.Checked Then grid3d(4, 6, 3) = 1 Else grid3d(4, 6, 3) = 0
        If C575.Checked Then grid3d(4, 6, 4) = 1 Else grid3d(4, 6, 4) = 0
        If C576.Checked Then grid3d(4, 6, 5) = 1 Else grid3d(4, 6, 5) = 0
        If C577.Checked Then grid3d(4, 6, 6) = 1 Else grid3d(4, 6, 6) = 0
        If C578.Checked Then grid3d(4, 6, 7) = 1 Else grid3d(4, 6, 7) = 0
        If C581.Checked Then grid3d(4, 7, 0) = 1 Else grid3d(4, 7, 0) = 0
        If C582.Checked Then grid3d(4, 7, 1) = 1 Else grid3d(4, 7, 1) = 0
        If C583.Checked Then grid3d(4, 7, 2) = 1 Else grid3d(4, 7, 2) = 0
        If C584.Checked Then grid3d(4, 7, 3) = 1 Else grid3d(4, 7, 3) = 0
        If C585.Checked Then grid3d(4, 7, 4) = 1 Else grid3d(4, 7, 4) = 0
        If C586.Checked Then grid3d(4, 7, 5) = 1 Else grid3d(4, 7, 5) = 0
        If C587.Checked Then grid3d(4, 7, 6) = 1 Else grid3d(4, 7, 6) = 0
        If C588.Checked Then grid3d(4, 7, 7) = 1 Else grid3d(4, 7, 7) = 0
        If C611.Checked Then grid3d(5, 0, 0) = 1 Else grid3d(5, 0, 0) = 0
        If C612.Checked Then grid3d(5, 0, 1) = 1 Else grid3d(5, 0, 1) = 0
        If C613.Checked Then grid3d(5, 0, 2) = 1 Else grid3d(5, 0, 2) = 0
        If C614.Checked Then grid3d(5, 0, 3) = 1 Else grid3d(5, 0, 3) = 0
        If C615.Checked Then grid3d(5, 0, 4) = 1 Else grid3d(5, 0, 4) = 0
        If C616.Checked Then grid3d(5, 0, 5) = 1 Else grid3d(5, 0, 5) = 0
        If C617.Checked Then grid3d(5, 0, 6) = 1 Else grid3d(5, 0, 6) = 0
        If C618.Checked Then grid3d(5, 0, 7) = 1 Else grid3d(5, 0, 7) = 0
        If C621.Checked Then grid3d(5, 1, 0) = 1 Else grid3d(5, 1, 0) = 0
        If C622.Checked Then grid3d(5, 1, 1) = 1 Else grid3d(5, 1, 1) = 0
        If C623.Checked Then grid3d(5, 1, 2) = 1 Else grid3d(5, 1, 2) = 0
        If C624.Checked Then grid3d(5, 1, 3) = 1 Else grid3d(5, 1, 3) = 0
        If C625.Checked Then grid3d(5, 1, 4) = 1 Else grid3d(5, 1, 4) = 0
        If C626.Checked Then grid3d(5, 1, 5) = 1 Else grid3d(5, 1, 5) = 0
        If C627.Checked Then grid3d(5, 1, 6) = 1 Else grid3d(5, 1, 6) = 0
        If C628.Checked Then grid3d(5, 1, 7) = 1 Else grid3d(5, 1, 7) = 0
        If C631.Checked Then grid3d(5, 2, 0) = 1 Else grid3d(5, 2, 0) = 0
        If C632.Checked Then grid3d(5, 2, 1) = 1 Else grid3d(5, 2, 1) = 0
        If C633.Checked Then grid3d(5, 2, 2) = 1 Else grid3d(5, 2, 2) = 0
        If C634.Checked Then grid3d(5, 2, 3) = 1 Else grid3d(5, 2, 3) = 0
        If C635.Checked Then grid3d(5, 2, 4) = 1 Else grid3d(5, 2, 4) = 0
        If C636.Checked Then grid3d(5, 2, 5) = 1 Else grid3d(5, 2, 5) = 0
        If C637.Checked Then grid3d(5, 2, 6) = 1 Else grid3d(5, 2, 6) = 0
        If C638.Checked Then grid3d(5, 2, 7) = 1 Else grid3d(5, 2, 7) = 0
        If C641.Checked Then grid3d(5, 3, 0) = 1 Else grid3d(5, 3, 0) = 0
        If C642.Checked Then grid3d(5, 3, 1) = 1 Else grid3d(5, 3, 1) = 0
        If C643.Checked Then grid3d(5, 3, 2) = 1 Else grid3d(5, 3, 2) = 0
        If C644.Checked Then grid3d(5, 3, 3) = 1 Else grid3d(5, 3, 3) = 0
        If C645.Checked Then grid3d(5, 3, 4) = 1 Else grid3d(5, 3, 4) = 0
        If C646.Checked Then grid3d(5, 3, 5) = 1 Else grid3d(5, 3, 5) = 0
        If C647.Checked Then grid3d(5, 3, 6) = 1 Else grid3d(5, 3, 6) = 0
        If C648.Checked Then grid3d(5, 3, 7) = 1 Else grid3d(5, 3, 7) = 0
        If C651.Checked Then grid3d(5, 4, 0) = 1 Else grid3d(5, 4, 0) = 0
        If C652.Checked Then grid3d(5, 4, 1) = 1 Else grid3d(5, 4, 1) = 0
        If C653.Checked Then grid3d(5, 4, 2) = 1 Else grid3d(5, 4, 2) = 0
        If C654.Checked Then grid3d(5, 4, 3) = 1 Else grid3d(5, 4, 3) = 0
        If C655.Checked Then grid3d(5, 4, 4) = 1 Else grid3d(5, 4, 4) = 0
        If C656.Checked Then grid3d(5, 4, 5) = 1 Else grid3d(5, 4, 5) = 0
        If C657.Checked Then grid3d(5, 4, 6) = 1 Else grid3d(5, 4, 6) = 0
        If C658.Checked Then grid3d(5, 4, 7) = 1 Else grid3d(5, 4, 7) = 0
        If C661.Checked Then grid3d(5, 5, 0) = 1 Else grid3d(5, 5, 0) = 0
        If C662.Checked Then grid3d(5, 5, 1) = 1 Else grid3d(5, 5, 1) = 0
        If C663.Checked Then grid3d(5, 5, 2) = 1 Else grid3d(5, 5, 2) = 0
        If C664.Checked Then grid3d(5, 5, 3) = 1 Else grid3d(5, 5, 3) = 0
        If C665.Checked Then grid3d(5, 5, 4) = 1 Else grid3d(5, 5, 4) = 0
        If C666.Checked Then grid3d(5, 5, 5) = 1 Else grid3d(5, 5, 5) = 0
        If C667.Checked Then grid3d(5, 5, 6) = 1 Else grid3d(5, 5, 6) = 0
        If C668.Checked Then grid3d(5, 5, 7) = 1 Else grid3d(5, 5, 7) = 0
        If C671.Checked Then grid3d(5, 6, 0) = 1 Else grid3d(5, 6, 0) = 0
        If C672.Checked Then grid3d(5, 6, 1) = 1 Else grid3d(5, 6, 1) = 0
        If C673.Checked Then grid3d(5, 6, 2) = 1 Else grid3d(5, 6, 2) = 0
        If C674.Checked Then grid3d(5, 6, 3) = 1 Else grid3d(5, 6, 3) = 0
        If C675.Checked Then grid3d(5, 6, 4) = 1 Else grid3d(5, 6, 4) = 0
        If C676.Checked Then grid3d(5, 6, 5) = 1 Else grid3d(5, 6, 5) = 0
        If C677.Checked Then grid3d(5, 6, 6) = 1 Else grid3d(5, 6, 6) = 0
        If C678.Checked Then grid3d(5, 6, 7) = 1 Else grid3d(5, 6, 7) = 0
        If C681.Checked Then grid3d(5, 7, 0) = 1 Else grid3d(5, 7, 0) = 0
        If C682.Checked Then grid3d(5, 7, 1) = 1 Else grid3d(5, 7, 1) = 0
        If C683.Checked Then grid3d(5, 7, 2) = 1 Else grid3d(5, 7, 2) = 0
        If C684.Checked Then grid3d(5, 7, 3) = 1 Else grid3d(5, 7, 3) = 0
        If C685.Checked Then grid3d(5, 7, 4) = 1 Else grid3d(5, 7, 4) = 0
        If C686.Checked Then grid3d(5, 7, 5) = 1 Else grid3d(5, 7, 5) = 0
        If C687.Checked Then grid3d(5, 7, 6) = 1 Else grid3d(5, 7, 6) = 0
        If C688.Checked Then grid3d(5, 7, 7) = 1 Else grid3d(5, 7, 7) = 0
        If C711.Checked Then grid3d(6, 0, 0) = 1 Else grid3d(6, 0, 0) = 0
        If C712.Checked Then grid3d(6, 0, 1) = 1 Else grid3d(6, 0, 1) = 0
        If C713.Checked Then grid3d(6, 0, 2) = 1 Else grid3d(6, 0, 2) = 0
        If C714.Checked Then grid3d(6, 0, 3) = 1 Else grid3d(6, 0, 3) = 0
        If C715.Checked Then grid3d(6, 0, 4) = 1 Else grid3d(6, 0, 4) = 0
        If C716.Checked Then grid3d(6, 0, 5) = 1 Else grid3d(6, 0, 5) = 0
        If C717.Checked Then grid3d(6, 0, 6) = 1 Else grid3d(6, 0, 6) = 0
        If C718.Checked Then grid3d(6, 0, 7) = 1 Else grid3d(6, 0, 7) = 0
        If C721.Checked Then grid3d(6, 1, 0) = 1 Else grid3d(6, 1, 0) = 0
        If C722.Checked Then grid3d(6, 1, 1) = 1 Else grid3d(6, 1, 1) = 0
        If C723.Checked Then grid3d(6, 1, 2) = 1 Else grid3d(6, 1, 2) = 0
        If C724.Checked Then grid3d(6, 1, 3) = 1 Else grid3d(6, 1, 3) = 0
        If C725.Checked Then grid3d(6, 1, 4) = 1 Else grid3d(6, 1, 4) = 0
        If C726.Checked Then grid3d(6, 1, 5) = 1 Else grid3d(6, 1, 5) = 0
        If C727.Checked Then grid3d(6, 1, 6) = 1 Else grid3d(6, 1, 6) = 0
        If C728.Checked Then grid3d(6, 1, 7) = 1 Else grid3d(6, 1, 7) = 0
        If C731.Checked Then grid3d(6, 2, 0) = 1 Else grid3d(6, 2, 0) = 0
        If C732.Checked Then grid3d(6, 2, 1) = 1 Else grid3d(6, 2, 1) = 0
        If C733.Checked Then grid3d(6, 2, 2) = 1 Else grid3d(6, 2, 2) = 0
        If C734.Checked Then grid3d(6, 2, 3) = 1 Else grid3d(6, 2, 3) = 0
        If C735.Checked Then grid3d(6, 2, 4) = 1 Else grid3d(6, 2, 4) = 0
        If C736.Checked Then grid3d(6, 2, 5) = 1 Else grid3d(6, 2, 5) = 0
        If C737.Checked Then grid3d(6, 2, 6) = 1 Else grid3d(6, 2, 6) = 0
        If C738.Checked Then grid3d(6, 2, 7) = 1 Else grid3d(6, 2, 7) = 0
        If C741.Checked Then grid3d(6, 3, 0) = 1 Else grid3d(6, 3, 0) = 0
        If C742.Checked Then grid3d(6, 3, 1) = 1 Else grid3d(6, 3, 1) = 0
        If C743.Checked Then grid3d(6, 3, 2) = 1 Else grid3d(6, 3, 2) = 0
        If C744.Checked Then grid3d(6, 3, 3) = 1 Else grid3d(6, 3, 3) = 0
        If C745.Checked Then grid3d(6, 3, 4) = 1 Else grid3d(6, 3, 4) = 0
        If C746.Checked Then grid3d(6, 3, 5) = 1 Else grid3d(6, 3, 5) = 0
        If C747.Checked Then grid3d(6, 3, 6) = 1 Else grid3d(6, 3, 6) = 0
        If C748.Checked Then grid3d(6, 3, 7) = 1 Else grid3d(6, 3, 7) = 0
        If C751.Checked Then grid3d(6, 4, 0) = 1 Else grid3d(6, 4, 0) = 0
        If C752.Checked Then grid3d(6, 4, 1) = 1 Else grid3d(6, 4, 1) = 0
        If C753.Checked Then grid3d(6, 4, 2) = 1 Else grid3d(6, 4, 2) = 0
        If C754.Checked Then grid3d(6, 4, 3) = 1 Else grid3d(6, 4, 3) = 0
        If C755.Checked Then grid3d(6, 4, 4) = 1 Else grid3d(6, 4, 4) = 0
        If C756.Checked Then grid3d(6, 4, 5) = 1 Else grid3d(6, 4, 5) = 0
        If C757.Checked Then grid3d(6, 4, 6) = 1 Else grid3d(6, 4, 6) = 0
        If C758.Checked Then grid3d(6, 4, 7) = 1 Else grid3d(6, 4, 7) = 0
        If C761.Checked Then grid3d(6, 5, 0) = 1 Else grid3d(6, 5, 0) = 0
        If C762.Checked Then grid3d(6, 5, 1) = 1 Else grid3d(6, 5, 1) = 0
        If C763.Checked Then grid3d(6, 5, 2) = 1 Else grid3d(6, 5, 2) = 0
        If C764.Checked Then grid3d(6, 5, 3) = 1 Else grid3d(6, 5, 3) = 0
        If C765.Checked Then grid3d(6, 5, 4) = 1 Else grid3d(6, 5, 4) = 0
        If C766.Checked Then grid3d(6, 5, 5) = 1 Else grid3d(6, 5, 5) = 0
        If C767.Checked Then grid3d(6, 5, 6) = 1 Else grid3d(6, 5, 6) = 0
        If C768.Checked Then grid3d(6, 5, 7) = 1 Else grid3d(6, 5, 7) = 0
        If C771.Checked Then grid3d(6, 6, 0) = 1 Else grid3d(6, 6, 0) = 0
        If C772.Checked Then grid3d(6, 6, 1) = 1 Else grid3d(6, 6, 1) = 0
        If C773.Checked Then grid3d(6, 6, 2) = 1 Else grid3d(6, 6, 2) = 0
        If C774.Checked Then grid3d(6, 6, 3) = 1 Else grid3d(6, 6, 3) = 0
        If C775.Checked Then grid3d(6, 6, 4) = 1 Else grid3d(6, 6, 4) = 0
        If C776.Checked Then grid3d(6, 6, 5) = 1 Else grid3d(6, 6, 5) = 0
        If C777.Checked Then grid3d(6, 6, 6) = 1 Else grid3d(6, 6, 6) = 0
        If C778.Checked Then grid3d(6, 6, 7) = 1 Else grid3d(6, 6, 7) = 0
        If C781.Checked Then grid3d(6, 7, 0) = 1 Else grid3d(6, 7, 0) = 0
        If C782.Checked Then grid3d(6, 7, 1) = 1 Else grid3d(6, 7, 1) = 0
        If C783.Checked Then grid3d(6, 7, 2) = 1 Else grid3d(6, 7, 2) = 0
        If C784.Checked Then grid3d(6, 7, 3) = 1 Else grid3d(6, 7, 3) = 0
        If C785.Checked Then grid3d(6, 7, 4) = 1 Else grid3d(6, 7, 4) = 0
        If C786.Checked Then grid3d(6, 7, 5) = 1 Else grid3d(6, 7, 5) = 0
        If C787.Checked Then grid3d(6, 7, 6) = 1 Else grid3d(6, 7, 6) = 0
        If C788.Checked Then grid3d(6, 7, 7) = 1 Else grid3d(6, 7, 7) = 0
        If C811.Checked Then grid3d(7, 0, 0) = 1 Else grid3d(7, 0, 0) = 0
        If C812.Checked Then grid3d(7, 0, 1) = 1 Else grid3d(7, 0, 1) = 0
        If C813.Checked Then grid3d(7, 0, 2) = 1 Else grid3d(7, 0, 2) = 0
        If C814.Checked Then grid3d(7, 0, 3) = 1 Else grid3d(7, 0, 3) = 0
        If C815.Checked Then grid3d(7, 0, 4) = 1 Else grid3d(7, 0, 4) = 0
        If C816.Checked Then grid3d(7, 0, 5) = 1 Else grid3d(7, 0, 5) = 0
        If C817.Checked Then grid3d(7, 0, 6) = 1 Else grid3d(7, 0, 6) = 0
        If C818.Checked Then grid3d(7, 0, 7) = 1 Else grid3d(7, 0, 7) = 0
        If C821.Checked Then grid3d(7, 1, 0) = 1 Else grid3d(7, 1, 0) = 0
        If C822.Checked Then grid3d(7, 1, 1) = 1 Else grid3d(7, 1, 1) = 0
        If C823.Checked Then grid3d(7, 1, 2) = 1 Else grid3d(7, 1, 2) = 0
        If C824.Checked Then grid3d(7, 1, 3) = 1 Else grid3d(7, 1, 3) = 0
        If C825.Checked Then grid3d(7, 1, 4) = 1 Else grid3d(7, 1, 4) = 0
        If C826.Checked Then grid3d(7, 1, 5) = 1 Else grid3d(7, 1, 5) = 0
        If C827.Checked Then grid3d(7, 1, 6) = 1 Else grid3d(7, 1, 6) = 0
        If C828.Checked Then grid3d(7, 1, 7) = 1 Else grid3d(7, 1, 7) = 0
        If C831.Checked Then grid3d(7, 2, 0) = 1 Else grid3d(7, 2, 0) = 0
        If C832.Checked Then grid3d(7, 2, 1) = 1 Else grid3d(7, 2, 1) = 0
        If C833.Checked Then grid3d(7, 2, 2) = 1 Else grid3d(7, 2, 2) = 0
        If C834.Checked Then grid3d(7, 2, 3) = 1 Else grid3d(7, 2, 3) = 0
        If C835.Checked Then grid3d(7, 2, 4) = 1 Else grid3d(7, 2, 4) = 0
        If C836.Checked Then grid3d(7, 2, 5) = 1 Else grid3d(7, 2, 5) = 0
        If C837.Checked Then grid3d(7, 2, 6) = 1 Else grid3d(7, 2, 6) = 0
        If C838.Checked Then grid3d(7, 2, 7) = 1 Else grid3d(7, 2, 7) = 0
        If C841.Checked Then grid3d(7, 3, 0) = 1 Else grid3d(7, 3, 0) = 0
        If C842.Checked Then grid3d(7, 3, 1) = 1 Else grid3d(7, 3, 1) = 0
        If C843.Checked Then grid3d(7, 3, 2) = 1 Else grid3d(7, 3, 2) = 0
        If C844.Checked Then grid3d(7, 3, 3) = 1 Else grid3d(7, 3, 3) = 0
        If C845.Checked Then grid3d(7, 3, 4) = 1 Else grid3d(7, 3, 4) = 0
        If C846.Checked Then grid3d(7, 3, 5) = 1 Else grid3d(7, 3, 5) = 0
        If C847.Checked Then grid3d(7, 3, 6) = 1 Else grid3d(7, 3, 6) = 0
        If C848.Checked Then grid3d(7, 3, 7) = 1 Else grid3d(7, 3, 7) = 0
        If C851.Checked Then grid3d(7, 4, 0) = 1 Else grid3d(7, 4, 0) = 0
        If C852.Checked Then grid3d(7, 4, 1) = 1 Else grid3d(7, 4, 1) = 0
        If C853.Checked Then grid3d(7, 4, 2) = 1 Else grid3d(7, 4, 2) = 0
        If C854.Checked Then grid3d(7, 4, 3) = 1 Else grid3d(7, 4, 3) = 0
        If C855.Checked Then grid3d(7, 4, 4) = 1 Else grid3d(7, 4, 4) = 0
        If C856.Checked Then grid3d(7, 4, 5) = 1 Else grid3d(7, 4, 5) = 0
        If C857.Checked Then grid3d(7, 4, 6) = 1 Else grid3d(7, 4, 6) = 0
        If C858.Checked Then grid3d(7, 4, 7) = 1 Else grid3d(7, 4, 7) = 0
        If C861.Checked Then grid3d(7, 5, 0) = 1 Else grid3d(7, 5, 0) = 0
        If C862.Checked Then grid3d(7, 5, 1) = 1 Else grid3d(7, 5, 1) = 0
        If C863.Checked Then grid3d(7, 5, 2) = 1 Else grid3d(7, 5, 2) = 0
        If C864.Checked Then grid3d(7, 5, 3) = 1 Else grid3d(7, 5, 3) = 0
        If C865.Checked Then grid3d(7, 5, 4) = 1 Else grid3d(7, 5, 4) = 0
        If C866.Checked Then grid3d(7, 5, 5) = 1 Else grid3d(7, 5, 5) = 0
        If C867.Checked Then grid3d(7, 5, 6) = 1 Else grid3d(7, 5, 6) = 0
        If C868.Checked Then grid3d(7, 5, 7) = 1 Else grid3d(7, 5, 7) = 0
        If C871.Checked Then grid3d(7, 6, 0) = 1 Else grid3d(7, 6, 0) = 0
        If C872.Checked Then grid3d(7, 6, 1) = 1 Else grid3d(7, 6, 1) = 0
        If C873.Checked Then grid3d(7, 6, 2) = 1 Else grid3d(7, 6, 2) = 0
        If C874.Checked Then grid3d(7, 6, 3) = 1 Else grid3d(7, 6, 3) = 0
        If C875.Checked Then grid3d(7, 6, 4) = 1 Else grid3d(7, 6, 4) = 0
        If C876.Checked Then grid3d(7, 6, 5) = 1 Else grid3d(7, 6, 5) = 0
        If C877.Checked Then grid3d(7, 6, 6) = 1 Else grid3d(7, 6, 6) = 0
        If C878.Checked Then grid3d(7, 6, 7) = 1 Else grid3d(7, 6, 7) = 0
        If C881.Checked Then grid3d(7, 7, 0) = 1 Else grid3d(7, 7, 0) = 0
        If C882.Checked Then grid3d(7, 7, 1) = 1 Else grid3d(7, 7, 1) = 0
        If C883.Checked Then grid3d(7, 7, 2) = 1 Else grid3d(7, 7, 2) = 0
        If C884.Checked Then grid3d(7, 7, 3) = 1 Else grid3d(7, 7, 3) = 0
        If C885.Checked Then grid3d(7, 7, 4) = 1 Else grid3d(7, 7, 4) = 0
        If C886.Checked Then grid3d(7, 7, 5) = 1 Else grid3d(7, 7, 5) = 0
        If C887.Checked Then grid3d(7, 7, 6) = 1 Else grid3d(7, 7, 6) = 0
        If C888.Checked Then grid3d(7, 7, 7) = 1 Else grid3d(7, 7, 7) = 0

        calGrid2D()
        setLines()
    End Sub

    Private Sub Main2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        setGrid()
        initLines()

        Dim Portnames As String() = System.IO.Ports.SerialPort.GetPortNames
        If Portnames Is Nothing Then
            MsgBox("There are no Com Ports detected!")
            Me.Close()
        End If
        cboComPort.Items.AddRange(Portnames)
        cboComPort.Text = Portnames(0)
        cboBaudRate.Text = "9600"



    End Sub

    ' Set the 3d grid and call 2d grid, set lines, and send MCU
    Private Sub CheckChange(ByVal face As Integer, ByVal row As Integer, ByVal col As Integer, sender As CheckBox)
        If sender.Checked Then
            grid3d(face - 1, row - 1, col - 1) = 1
        Else
            grid3d(face - 1, row - 1, col - 1) = 0
        End If




        calGrid2D()
        sendToMCU(True, False, Nothing)
        'setLines()

    End Sub

    ' Connect to the MCU
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        With SerialPort1
            .PortName = cboComPort.Text
            .BaudRate = CInt(cboBaudRate.Text)
            .Parity = IO.Ports.Parity.None
            .DataBits = 8
            .StopBits = IO.Ports.StopBits.Two
            ' .Handshake = IO.Ports.Handshake.None
            '  .RtsEnable = False
            '     .ReceivedBytesThreshold = 1
            '    .NewLine = vbCr
            '   .ReadTimeout = 10000
        End With

        Try
            SerialPort1.Open()
            comOpen = SerialPort1.IsOpen
        Catch ex As Exception
            comOpen = False
            MsgBox("Error Open:" & ex.Message)
        End Try

        If comOpen Then
            cboComPort.Enabled = False
            cboBaudRate.Enabled = False

            'SerialPort1.Write(New Byte() {&H44}, 0, 1)
        End If
    End Sub

    ' Terminate the connection
    Private Sub btnCloseCon_Click(sender As System.Object, e As System.EventArgs) Handles btnCloseCon.Click
        If comOpen Then
            SerialPort1.DiscardInBuffer()
            SerialPort1.Close()
        End If
    End Sub

    ' Send data to MCU
    Private Sub sendToMCU(ByVal display As Boolean, ByVal write As Boolean, ByVal location As Integer)

        If comOpen Then

            If write = True Then
                SerialPort1.Write("P")
                wait(10)

                If (location <= 255) Then
                    SerialPort1.Write(New Byte() {0}, 0, 1)
                    wait(10)
                    SerialPort1.Write(New Byte() {location}, 0, 1)
                    wait(10)
                Else
                    SerialPort1.Write(New Byte() {1}, 0, 1)
                    wait(10)
                    SerialPort1.Write(New Byte() {location - 256}, 0, 1)
                    wait(10)
                End If

                Timer1.Enabled = True
                Button6.Enabled = False
                'For i = 0 To 7
                'For j = 0 To 7
                'SerialPort1.Write(New Byte() {grid2d(i, j)}, 0, 1)

                'wait(10)
                'Next
                'Next
            End If

            'Dim k As Integer = 0
            If display = True And CheckBox1.Checked Then
                SerialPort1.Write("D")
                For i = 0 To 7
                    For j = 0 To 7
                        SerialPort1.Write(New Byte() {grid2d(i, j)}, 0, 1)
                        wait(10)
                    Next
                Next
            End If

        End If

    End Sub

    Private Sub wait(ByVal interval As Integer)
        Dim sw As New Stopwatch
        sw.Start()
        Do While sw.ElapsedMilliseconds < interval
            ' Allows UI to remain responsive
            Application.DoEvents()
        Loop
        sw.Stop()
    End Sub

    ' calculate and set values for 2D grid
    Private Sub calGrid2D()

        For i = 0 To 7
            For j = 0 To 7
                Dim temp As Byte = 0
                For k = 0 To 7
                    If grid3d(i, j, k) = 1 Then temp += 2 ^ k
                Next
                grid2d(j, i) = temp
            Next
        Next

        '//////////////////////
        setLines()
    End Sub

    ' Next step
    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        stepChange = True
        setLines()
        If NUpDown.Value < stepsMax - 1 Then
            NUpDown.Value += 1
        Else
            NUpDown.Value = 0
        End If
        getLines()
        setGrid()
        stepChange = False
        sendToMCU(True, False, 0)

    End Sub

    ' last step
    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        stepChange = True
        setLines()
        NUpDown.Value = stepsMax - 1
        getLines()
        setGrid()
        stepChange = False
    End Sub

    ' first step
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        stepChange = True
        setLines()
        NUpDown.Value = 0
        getLines()
        setGrid()
        stepChange = False
    End Sub

    ' Previous step
    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        stepChange = True
        setLines()
        If NUpDown.Value > 0 Then
            NUpDown.Value -= 1
        Else
            NUpDown.Value = stepsMax - 1
        End If
        getLines()
        setGrid()
        stepChange = False
        sendToMCU(True, False, 0)
    End Sub

    Private Sub setLines()      ' Set the line array according to the check boxes
        lines(NUpDown.Value) = ""
        For i = 0 To 7
            For j = 0 To 7
                lines(NUpDown.Value) &= grid2d(i, j).ToString & " "
            Next
        Next
        lines(NUpDown.Value) = lines(NUpDown.Value).Substring(0, lines(NUpDown.Value).Length - 1)
        TextBox1.Text = lines(NUpDown.Value)
    End Sub

    Private Sub NUpDown_ValueChanged(sender As System.Object, e As System.EventArgs) Handles NUpDown.ValueChanged
        ' getLines()  ' set the lines if the value is changed
        'setGrid()
    End Sub

    ' Initialize Line array
    Private Sub initLines()
        For i = 0 To 499
            For j = 0 To 63
                lines(i) &= "0 "
            Next
            lines(i) = lines(i).Substring(0, lines(i).Length - 1)
        Next
    End Sub

    ' Reset check boxes
    Private Sub focusCheckBoxes()

        C111.Checked = False
        C112.Checked = False
        C113.Checked = False
        C114.Checked = False
        C115.Checked = False
        C116.Checked = False
        C117.Checked = False
        C118.Checked = False
        C121.Checked = False
        C122.Checked = False
        C123.Checked = False
        C124.Checked = False
        C125.Checked = False
        C126.Checked = False
        C127.Checked = False
        C128.Checked = False
        C131.Checked = False
        C132.Checked = False
        C133.Checked = False
        C134.Checked = False
        C135.Checked = False
        C136.Checked = False
        C137.Checked = False
        C138.Checked = False
        C141.Checked = False
        C142.Checked = False
        C143.Checked = False
        C144.Checked = False
        C145.Checked = False
        C146.Checked = False
        C147.Checked = False
        C148.Checked = False
        C151.Checked = False
        C152.Checked = False
        C153.Checked = False
        C154.Checked = False
        C155.Checked = False
        C156.Checked = False
        C157.Checked = False
        C158.Checked = False
        C161.Checked = False
        C162.Checked = False
        C163.Checked = False
        C164.Checked = False
        C165.Checked = False
        C166.Checked = False
        C167.Checked = False
        C168.Checked = False
        C171.Checked = False
        C172.Checked = False
        C173.Checked = False
        C174.Checked = False
        C175.Checked = False
        C176.Checked = False
        C177.Checked = False
        C178.Checked = False
        C181.Checked = False
        C182.Checked = False
        C183.Checked = False
        C184.Checked = False
        C185.Checked = False
        C186.Checked = False
        C187.Checked = False
        C188.Checked = False
        C211.Checked = False
        C212.Checked = False
        C213.Checked = False
        C214.Checked = False
        C215.Checked = False
        C216.Checked = False
        C217.Checked = False
        C218.Checked = False
        C221.Checked = False
        C222.Checked = False
        C223.Checked = False
        C224.Checked = False
        C225.Checked = False
        C226.Checked = False
        C227.Checked = False
        C228.Checked = False
        C231.Checked = False
        C232.Checked = False
        C233.Checked = False
        C234.Checked = False
        C235.Checked = False
        C236.Checked = False
        C237.Checked = False
        C238.Checked = False
        C241.Checked = False
        C242.Checked = False
        C243.Checked = False
        C244.Checked = False
        C245.Checked = False
        C246.Checked = False
        C247.Checked = False
        C248.Checked = False
        C251.Checked = False
        C252.Checked = False
        C253.Checked = False
        C254.Checked = False
        C255.Checked = False
        C256.Checked = False
        C257.Checked = False
        C258.Checked = False
        C261.Checked = False
        C262.Checked = False
        C263.Checked = False
        C264.Checked = False
        C265.Checked = False
        C266.Checked = False
        C267.Checked = False
        C268.Checked = False
        C271.Checked = False
        C272.Checked = False
        C273.Checked = False
        C274.Checked = False
        C275.Checked = False
        C276.Checked = False
        C277.Checked = False
        C278.Checked = False
        C281.Checked = False
        C282.Checked = False
        C283.Checked = False
        C284.Checked = False
        C285.Checked = False
        C286.Checked = False
        C287.Checked = False
        C288.Checked = False
        C311.Checked = False
        C312.Checked = False
        C313.Checked = False
        C314.Checked = False
        C315.Checked = False
        C316.Checked = False
        C317.Checked = False
        C318.Checked = False
        C321.Checked = False
        C322.Checked = False
        C323.Checked = False
        C324.Checked = False
        C325.Checked = False
        C326.Checked = False
        C327.Checked = False
        C328.Checked = False
        C331.Checked = False
        C332.Checked = False
        C333.Checked = False
        C334.Checked = False
        C335.Checked = False
        C336.Checked = False
        C337.Checked = False
        C338.Checked = False
        C341.Checked = False
        C342.Checked = False
        C343.Checked = False
        C344.Checked = False
        C345.Checked = False
        C346.Checked = False
        C347.Checked = False
        C348.Checked = False
        C351.Checked = False
        C352.Checked = False
        C353.Checked = False
        C354.Checked = False
        C355.Checked = False
        C356.Checked = False
        C357.Checked = False
        C358.Checked = False
        C361.Checked = False
        C362.Checked = False
        C363.Checked = False
        C364.Checked = False
        C365.Checked = False
        C366.Checked = False
        C367.Checked = False
        C368.Checked = False
        C371.Checked = False
        C372.Checked = False
        C373.Checked = False
        C374.Checked = False
        C375.Checked = False
        C376.Checked = False
        C377.Checked = False
        C378.Checked = False
        C381.Checked = False
        C382.Checked = False
        C383.Checked = False
        C384.Checked = False
        C385.Checked = False
        C386.Checked = False
        C387.Checked = False
        C388.Checked = False
        C411.Checked = False
        C412.Checked = False
        C413.Checked = False
        C414.Checked = False
        C415.Checked = False
        C416.Checked = False
        C417.Checked = False
        C418.Checked = False
        C421.Checked = False
        C422.Checked = False
        C423.Checked = False
        C424.Checked = False
        C425.Checked = False
        C426.Checked = False
        C427.Checked = False
        C428.Checked = False
        C431.Checked = False
        C432.Checked = False
        C433.Checked = False
        C434.Checked = False
        C435.Checked = False
        C436.Checked = False
        C437.Checked = False
        C438.Checked = False
        C441.Checked = False
        C442.Checked = False
        C443.Checked = False
        C444.Checked = False
        C445.Checked = False
        C446.Checked = False
        C447.Checked = False
        C448.Checked = False
        C451.Checked = False
        C452.Checked = False
        C453.Checked = False
        C454.Checked = False
        C455.Checked = False
        C456.Checked = False
        C457.Checked = False
        C458.Checked = False
        C461.Checked = False
        C462.Checked = False
        C463.Checked = False
        C464.Checked = False
        C465.Checked = False
        C466.Checked = False
        C467.Checked = False
        C468.Checked = False
        C471.Checked = False
        C472.Checked = False
        C473.Checked = False
        C474.Checked = False
        C475.Checked = False
        C476.Checked = False
        C477.Checked = False
        C478.Checked = False
        C481.Checked = False
        C482.Checked = False
        C483.Checked = False
        C484.Checked = False
        C485.Checked = False
        C486.Checked = False
        C487.Checked = False
        C488.Checked = False
        C511.Checked = False
        C512.Checked = False
        C513.Checked = False
        C514.Checked = False
        C515.Checked = False
        C516.Checked = False
        C517.Checked = False
        C518.Checked = False
        C521.Checked = False
        C522.Checked = False
        C523.Checked = False
        C524.Checked = False
        C525.Checked = False
        C526.Checked = False
        C527.Checked = False
        C528.Checked = False
        C531.Checked = False
        C532.Checked = False
        C533.Checked = False
        C534.Checked = False
        C535.Checked = False
        C536.Checked = False
        C537.Checked = False
        C538.Checked = False
        C541.Checked = False
        C542.Checked = False
        C543.Checked = False
        C544.Checked = False
        C545.Checked = False
        C546.Checked = False
        C547.Checked = False
        C548.Checked = False
        C551.Checked = False
        C552.Checked = False
        C553.Checked = False
        C554.Checked = False
        C555.Checked = False
        C556.Checked = False
        C557.Checked = False
        C558.Checked = False
        C561.Checked = False
        C562.Checked = False
        C563.Checked = False
        C564.Checked = False
        C565.Checked = False
        C566.Checked = False
        C567.Checked = False
        C568.Checked = False
        C571.Checked = False
        C572.Checked = False
        C573.Checked = False
        C574.Checked = False
        C575.Checked = False
        C576.Checked = False
        C577.Checked = False
        C578.Checked = False
        C581.Checked = False
        C582.Checked = False
        C583.Checked = False
        C584.Checked = False
        C585.Checked = False
        C586.Checked = False
        C587.Checked = False
        C588.Checked = False
        C611.Checked = False
        C612.Checked = False
        C613.Checked = False
        C614.Checked = False
        C615.Checked = False
        C616.Checked = False
        C617.Checked = False
        C618.Checked = False
        C621.Checked = False
        C622.Checked = False
        C623.Checked = False
        C624.Checked = False
        C625.Checked = False
        C626.Checked = False
        C627.Checked = False
        C628.Checked = False
        C631.Checked = False
        C632.Checked = False
        C633.Checked = False
        C634.Checked = False
        C635.Checked = False
        C636.Checked = False
        C637.Checked = False
        C638.Checked = False
        C641.Checked = False
        C642.Checked = False
        C643.Checked = False
        C644.Checked = False
        C645.Checked = False
        C646.Checked = False
        C647.Checked = False
        C648.Checked = False
        C651.Checked = False
        C652.Checked = False
        C653.Checked = False
        C654.Checked = False
        C655.Checked = False
        C656.Checked = False
        C657.Checked = False
        C658.Checked = False
        C661.Checked = False
        C662.Checked = False
        C663.Checked = False
        C664.Checked = False
        C665.Checked = False
        C666.Checked = False
        C667.Checked = False
        C668.Checked = False
        C671.Checked = False
        C672.Checked = False
        C673.Checked = False
        C674.Checked = False
        C675.Checked = False
        C676.Checked = False
        C677.Checked = False
        C678.Checked = False
        C681.Checked = False
        C682.Checked = False
        C683.Checked = False
        C684.Checked = False
        C685.Checked = False
        C686.Checked = False
        C687.Checked = False
        C688.Checked = False
        C711.Checked = False
        C712.Checked = False
        C713.Checked = False
        C714.Checked = False
        C715.Checked = False
        C716.Checked = False
        C717.Checked = False
        C718.Checked = False
        C721.Checked = False
        C722.Checked = False
        C723.Checked = False
        C724.Checked = False
        C725.Checked = False
        C726.Checked = False
        C727.Checked = False
        C728.Checked = False
        C731.Checked = False
        C732.Checked = False
        C733.Checked = False
        C734.Checked = False
        C735.Checked = False
        C736.Checked = False
        C737.Checked = False
        C738.Checked = False
        C741.Checked = False
        C742.Checked = False
        C743.Checked = False
        C744.Checked = False
        C745.Checked = False
        C746.Checked = False
        C747.Checked = False
        C748.Checked = False
        C751.Checked = False
        C752.Checked = False
        C753.Checked = False
        C754.Checked = False
        C755.Checked = False
        C756.Checked = False
        C757.Checked = False
        C758.Checked = False
        C761.Checked = False
        C762.Checked = False
        C763.Checked = False
        C764.Checked = False
        C765.Checked = False
        C766.Checked = False
        C767.Checked = False
        C768.Checked = False
        C771.Checked = False
        C772.Checked = False
        C773.Checked = False
        C774.Checked = False
        C775.Checked = False
        C776.Checked = False
        C777.Checked = False
        C778.Checked = False
        C781.Checked = False
        C782.Checked = False
        C783.Checked = False
        C784.Checked = False
        C785.Checked = False
        C786.Checked = False
        C787.Checked = False
        C788.Checked = False
        C811.Checked = False
        C812.Checked = False
        C813.Checked = False
        C814.Checked = False
        C815.Checked = False
        C816.Checked = False
        C817.Checked = False
        C818.Checked = False
        C821.Checked = False
        C822.Checked = False
        C823.Checked = False
        C824.Checked = False
        C825.Checked = False
        C826.Checked = False
        C827.Checked = False
        C828.Checked = False
        C831.Checked = False
        C832.Checked = False
        C833.Checked = False
        C834.Checked = False
        C835.Checked = False
        C836.Checked = False
        C837.Checked = False
        C838.Checked = False
        C841.Checked = False
        C842.Checked = False
        C843.Checked = False
        C844.Checked = False
        C845.Checked = False
        C846.Checked = False
        C847.Checked = False
        C848.Checked = False
        C851.Checked = False
        C852.Checked = False
        C853.Checked = False
        C854.Checked = False
        C855.Checked = False
        C856.Checked = False
        C857.Checked = False
        C858.Checked = False
        C861.Checked = False
        C862.Checked = False
        C863.Checked = False
        C864.Checked = False
        C865.Checked = False
        C866.Checked = False
        C867.Checked = False
        C868.Checked = False
        C871.Checked = False
        C872.Checked = False
        C873.Checked = False
        C874.Checked = False
        C875.Checked = False
        C876.Checked = False
        C877.Checked = False
        C878.Checked = False
        C881.Checked = False
        C882.Checked = False
        C883.Checked = False
        C884.Checked = False
        C885.Checked = False
        C886.Checked = False
        C887.Checked = False
        C888.Checked = False
    End Sub

    Private Sub getLines()
        TextBox2.Text = ""
        Dim splStr(65) As String
        splStr = lines(NUpDown.Value).Split(" "c)
        For i = 0 To 63
            grid2d(i \ 8, i Mod 8) = splStr(i)
        Next

        For i = 0 To 7
            For j = 0 To 7
                TextBox2.Text &= grid2d(i, j).ToString & " "
            Next
        Next
        setChecks()
    End Sub

    Private Sub setChecks()
        ' For i = 0 To 7
        'For j = 0 To 7
        'For k = 0 To 7
        'Dim val As Integer = Integer.Parse(grid2d(i, j))
        'Dim st As String = "c" & j & i & k
        'Dim cb As CheckBox = New CheckBox
        'cb.Name = st
        'If val \ (2 ^ k) Mod 2 = 1 Then C111_CheckedChanged(cb, EventArgs.Empty) Else C111_CheckedChanged(cb, EventArgs.Empty)

        'Next
        'Next
        'Next
        If Integer.Parse(grid2d(0, 0)) \ 1 Mod 2 = 1 Then C111.Checked = True Else C111.Checked = False
        If Integer.Parse(grid2d(0, 0)) \ 2 Mod 2 = 1 Then C112.Checked = True Else C112.Checked = False
        If Integer.Parse(grid2d(0, 0)) \ 4 Mod 2 = 1 Then C113.Checked = True Else C113.Checked = False
        If Integer.Parse(grid2d(0, 0)) \ 8 Mod 2 = 1 Then C114.Checked = True Else C114.Checked = False
        If Integer.Parse(grid2d(0, 0)) \ 16 Mod 2 = 1 Then C115.Checked = True Else C115.Checked = False
        If Integer.Parse(grid2d(0, 0)) \ 32 Mod 2 = 1 Then C116.Checked = True Else C116.Checked = False
        If Integer.Parse(grid2d(0, 0)) \ 64 Mod 2 = 1 Then C117.Checked = True Else C117.Checked = False
        If Integer.Parse(grid2d(0, 0)) \ 128 Mod 2 = 1 Then C118.Checked = True Else C118.Checked = False
        If Integer.Parse(grid2d(0, 1)) \ 1 Mod 2 = 1 Then C211.Checked = True Else C211.Checked = False
        If Integer.Parse(grid2d(0, 1)) \ 2 Mod 2 = 1 Then C212.Checked = True Else C212.Checked = False
        If Integer.Parse(grid2d(0, 1)) \ 4 Mod 2 = 1 Then C213.Checked = True Else C213.Checked = False
        If Integer.Parse(grid2d(0, 1)) \ 8 Mod 2 = 1 Then C214.Checked = True Else C214.Checked = False
        If Integer.Parse(grid2d(0, 1)) \ 16 Mod 2 = 1 Then C215.Checked = True Else C215.Checked = False
        If Integer.Parse(grid2d(0, 1)) \ 32 Mod 2 = 1 Then C216.Checked = True Else C216.Checked = False
        If Integer.Parse(grid2d(0, 1)) \ 64 Mod 2 = 1 Then C217.Checked = True Else C217.Checked = False
        If Integer.Parse(grid2d(0, 1)) \ 128 Mod 2 = 1 Then C218.Checked = True Else C218.Checked = False
        If Integer.Parse(grid2d(0, 2)) \ 1 Mod 2 = 1 Then C311.Checked = True Else C311.Checked = False
        If Integer.Parse(grid2d(0, 2)) \ 2 Mod 2 = 1 Then C312.Checked = True Else C312.Checked = False
        If Integer.Parse(grid2d(0, 2)) \ 4 Mod 2 = 1 Then C313.Checked = True Else C313.Checked = False
        If Integer.Parse(grid2d(0, 2)) \ 8 Mod 2 = 1 Then C314.Checked = True Else C314.Checked = False
        If Integer.Parse(grid2d(0, 2)) \ 16 Mod 2 = 1 Then C315.Checked = True Else C315.Checked = False
        If Integer.Parse(grid2d(0, 2)) \ 32 Mod 2 = 1 Then C316.Checked = True Else C316.Checked = False
        If Integer.Parse(grid2d(0, 2)) \ 64 Mod 2 = 1 Then C317.Checked = True Else C317.Checked = False
        If Integer.Parse(grid2d(0, 2)) \ 128 Mod 2 = 1 Then C318.Checked = True Else C318.Checked = False
        If Integer.Parse(grid2d(0, 3)) \ 1 Mod 2 = 1 Then C411.Checked = True Else C411.Checked = False
        If Integer.Parse(grid2d(0, 3)) \ 2 Mod 2 = 1 Then C412.Checked = True Else C412.Checked = False
        If Integer.Parse(grid2d(0, 3)) \ 4 Mod 2 = 1 Then C413.Checked = True Else C413.Checked = False
        If Integer.Parse(grid2d(0, 3)) \ 8 Mod 2 = 1 Then C414.Checked = True Else C414.Checked = False
        If Integer.Parse(grid2d(0, 3)) \ 16 Mod 2 = 1 Then C415.Checked = True Else C415.Checked = False
        If Integer.Parse(grid2d(0, 3)) \ 32 Mod 2 = 1 Then C416.Checked = True Else C416.Checked = False
        If Integer.Parse(grid2d(0, 3)) \ 64 Mod 2 = 1 Then C417.Checked = True Else C417.Checked = False
        If Integer.Parse(grid2d(0, 3)) \ 128 Mod 2 = 1 Then C418.Checked = True Else C418.Checked = False
        If Integer.Parse(grid2d(0, 4)) \ 1 Mod 2 = 1 Then C511.Checked = True Else C511.Checked = False
        If Integer.Parse(grid2d(0, 4)) \ 2 Mod 2 = 1 Then C512.Checked = True Else C512.Checked = False
        If Integer.Parse(grid2d(0, 4)) \ 4 Mod 2 = 1 Then C513.Checked = True Else C513.Checked = False
        If Integer.Parse(grid2d(0, 4)) \ 8 Mod 2 = 1 Then C514.Checked = True Else C514.Checked = False
        If Integer.Parse(grid2d(0, 4)) \ 16 Mod 2 = 1 Then C515.Checked = True Else C515.Checked = False
        If Integer.Parse(grid2d(0, 4)) \ 32 Mod 2 = 1 Then C516.Checked = True Else C516.Checked = False
        If Integer.Parse(grid2d(0, 4)) \ 64 Mod 2 = 1 Then C517.Checked = True Else C517.Checked = False
        If Integer.Parse(grid2d(0, 4)) \ 128 Mod 2 = 1 Then C518.Checked = True Else C518.Checked = False
        If Integer.Parse(grid2d(0, 5)) \ 1 Mod 2 = 1 Then C611.Checked = True Else C611.Checked = False
        If Integer.Parse(grid2d(0, 5)) \ 2 Mod 2 = 1 Then C612.Checked = True Else C612.Checked = False
        If Integer.Parse(grid2d(0, 5)) \ 4 Mod 2 = 1 Then C613.Checked = True Else C613.Checked = False
        If Integer.Parse(grid2d(0, 5)) \ 8 Mod 2 = 1 Then C614.Checked = True Else C614.Checked = False
        If Integer.Parse(grid2d(0, 5)) \ 16 Mod 2 = 1 Then C615.Checked = True Else C615.Checked = False
        If Integer.Parse(grid2d(0, 5)) \ 32 Mod 2 = 1 Then C616.Checked = True Else C616.Checked = False
        If Integer.Parse(grid2d(0, 5)) \ 64 Mod 2 = 1 Then C617.Checked = True Else C617.Checked = False
        If Integer.Parse(grid2d(0, 5)) \ 128 Mod 2 = 1 Then C618.Checked = True Else C618.Checked = False
        If Integer.Parse(grid2d(0, 6)) \ 1 Mod 2 = 1 Then C711.Checked = True Else C711.Checked = False
        If Integer.Parse(grid2d(0, 6)) \ 2 Mod 2 = 1 Then C712.Checked = True Else C712.Checked = False
        If Integer.Parse(grid2d(0, 6)) \ 4 Mod 2 = 1 Then C713.Checked = True Else C713.Checked = False
        If Integer.Parse(grid2d(0, 6)) \ 8 Mod 2 = 1 Then C714.Checked = True Else C714.Checked = False
        If Integer.Parse(grid2d(0, 6)) \ 16 Mod 2 = 1 Then C715.Checked = True Else C715.Checked = False
        If Integer.Parse(grid2d(0, 6)) \ 32 Mod 2 = 1 Then C716.Checked = True Else C716.Checked = False
        If Integer.Parse(grid2d(0, 6)) \ 64 Mod 2 = 1 Then C717.Checked = True Else C717.Checked = False
        If Integer.Parse(grid2d(0, 6)) \ 128 Mod 2 = 1 Then C718.Checked = True Else C718.Checked = False
        If Integer.Parse(grid2d(0, 7)) \ 1 Mod 2 = 1 Then C811.Checked = True Else C811.Checked = False
        If Integer.Parse(grid2d(0, 7)) \ 2 Mod 2 = 1 Then C812.Checked = True Else C812.Checked = False
        If Integer.Parse(grid2d(0, 7)) \ 4 Mod 2 = 1 Then C813.Checked = True Else C813.Checked = False
        If Integer.Parse(grid2d(0, 7)) \ 8 Mod 2 = 1 Then C814.Checked = True Else C814.Checked = False
        If Integer.Parse(grid2d(0, 7)) \ 16 Mod 2 = 1 Then C815.Checked = True Else C815.Checked = False
        If Integer.Parse(grid2d(0, 7)) \ 32 Mod 2 = 1 Then C816.Checked = True Else C816.Checked = False
        If Integer.Parse(grid2d(0, 7)) \ 64 Mod 2 = 1 Then C817.Checked = True Else C817.Checked = False
        If Integer.Parse(grid2d(0, 7)) \ 128 Mod 2 = 1 Then C818.Checked = True Else C818.Checked = False
        If Integer.Parse(grid2d(1, 0)) \ 1 Mod 2 = 1 Then C121.Checked = True Else C121.Checked = False
        If Integer.Parse(grid2d(1, 0)) \ 2 Mod 2 = 1 Then C122.Checked = True Else C122.Checked = False
        If Integer.Parse(grid2d(1, 0)) \ 4 Mod 2 = 1 Then C123.Checked = True Else C123.Checked = False
        If Integer.Parse(grid2d(1, 0)) \ 8 Mod 2 = 1 Then C124.Checked = True Else C124.Checked = False
        If Integer.Parse(grid2d(1, 0)) \ 16 Mod 2 = 1 Then C125.Checked = True Else C125.Checked = False
        If Integer.Parse(grid2d(1, 0)) \ 32 Mod 2 = 1 Then C126.Checked = True Else C126.Checked = False
        If Integer.Parse(grid2d(1, 0)) \ 64 Mod 2 = 1 Then C127.Checked = True Else C127.Checked = False
        If Integer.Parse(grid2d(1, 0)) \ 128 Mod 2 = 1 Then C128.Checked = True Else C128.Checked = False
        If Integer.Parse(grid2d(1, 1)) \ 1 Mod 2 = 1 Then C221.Checked = True Else C221.Checked = False
        If Integer.Parse(grid2d(1, 1)) \ 2 Mod 2 = 1 Then C222.Checked = True Else C222.Checked = False
        If Integer.Parse(grid2d(1, 1)) \ 4 Mod 2 = 1 Then C223.Checked = True Else C223.Checked = False
        If Integer.Parse(grid2d(1, 1)) \ 8 Mod 2 = 1 Then C224.Checked = True Else C224.Checked = False
        If Integer.Parse(grid2d(1, 1)) \ 16 Mod 2 = 1 Then C225.Checked = True Else C225.Checked = False
        If Integer.Parse(grid2d(1, 1)) \ 32 Mod 2 = 1 Then C226.Checked = True Else C226.Checked = False
        If Integer.Parse(grid2d(1, 1)) \ 64 Mod 2 = 1 Then C227.Checked = True Else C227.Checked = False
        If Integer.Parse(grid2d(1, 1)) \ 128 Mod 2 = 1 Then C228.Checked = True Else C228.Checked = False
        If Integer.Parse(grid2d(1, 2)) \ 1 Mod 2 = 1 Then C321.Checked = True Else C321.Checked = False
        If Integer.Parse(grid2d(1, 2)) \ 2 Mod 2 = 1 Then C322.Checked = True Else C322.Checked = False
        If Integer.Parse(grid2d(1, 2)) \ 4 Mod 2 = 1 Then C323.Checked = True Else C323.Checked = False
        If Integer.Parse(grid2d(1, 2)) \ 8 Mod 2 = 1 Then C324.Checked = True Else C324.Checked = False
        If Integer.Parse(grid2d(1, 2)) \ 16 Mod 2 = 1 Then C325.Checked = True Else C325.Checked = False
        If Integer.Parse(grid2d(1, 2)) \ 32 Mod 2 = 1 Then C326.Checked = True Else C326.Checked = False
        If Integer.Parse(grid2d(1, 2)) \ 64 Mod 2 = 1 Then C327.Checked = True Else C327.Checked = False
        If Integer.Parse(grid2d(1, 2)) \ 128 Mod 2 = 1 Then C328.Checked = True Else C328.Checked = False
        If Integer.Parse(grid2d(1, 3)) \ 1 Mod 2 = 1 Then C421.Checked = True Else C421.Checked = False
        If Integer.Parse(grid2d(1, 3)) \ 2 Mod 2 = 1 Then C422.Checked = True Else C422.Checked = False
        If Integer.Parse(grid2d(1, 3)) \ 4 Mod 2 = 1 Then C423.Checked = True Else C423.Checked = False
        If Integer.Parse(grid2d(1, 3)) \ 8 Mod 2 = 1 Then C424.Checked = True Else C424.Checked = False
        If Integer.Parse(grid2d(1, 3)) \ 16 Mod 2 = 1 Then C425.Checked = True Else C425.Checked = False
        If Integer.Parse(grid2d(1, 3)) \ 32 Mod 2 = 1 Then C426.Checked = True Else C426.Checked = False
        If Integer.Parse(grid2d(1, 3)) \ 64 Mod 2 = 1 Then C427.Checked = True Else C427.Checked = False
        If Integer.Parse(grid2d(1, 3)) \ 128 Mod 2 = 1 Then C428.Checked = True Else C428.Checked = False
        If Integer.Parse(grid2d(1, 4)) \ 1 Mod 2 = 1 Then C521.Checked = True Else C521.Checked = False
        If Integer.Parse(grid2d(1, 4)) \ 2 Mod 2 = 1 Then C522.Checked = True Else C522.Checked = False
        If Integer.Parse(grid2d(1, 4)) \ 4 Mod 2 = 1 Then C523.Checked = True Else C523.Checked = False
        If Integer.Parse(grid2d(1, 4)) \ 8 Mod 2 = 1 Then C524.Checked = True Else C524.Checked = False
        If Integer.Parse(grid2d(1, 4)) \ 16 Mod 2 = 1 Then C525.Checked = True Else C525.Checked = False
        If Integer.Parse(grid2d(1, 4)) \ 32 Mod 2 = 1 Then C526.Checked = True Else C526.Checked = False
        If Integer.Parse(grid2d(1, 4)) \ 64 Mod 2 = 1 Then C527.Checked = True Else C527.Checked = False
        If Integer.Parse(grid2d(1, 4)) \ 128 Mod 2 = 1 Then C528.Checked = True Else C528.Checked = False
        If Integer.Parse(grid2d(1, 5)) \ 1 Mod 2 = 1 Then C621.Checked = True Else C621.Checked = False
        If Integer.Parse(grid2d(1, 5)) \ 2 Mod 2 = 1 Then C622.Checked = True Else C622.Checked = False
        If Integer.Parse(grid2d(1, 5)) \ 4 Mod 2 = 1 Then C623.Checked = True Else C623.Checked = False
        If Integer.Parse(grid2d(1, 5)) \ 8 Mod 2 = 1 Then C624.Checked = True Else C624.Checked = False
        If Integer.Parse(grid2d(1, 5)) \ 16 Mod 2 = 1 Then C625.Checked = True Else C625.Checked = False
        If Integer.Parse(grid2d(1, 5)) \ 32 Mod 2 = 1 Then C626.Checked = True Else C626.Checked = False
        If Integer.Parse(grid2d(1, 5)) \ 64 Mod 2 = 1 Then C627.Checked = True Else C627.Checked = False
        If Integer.Parse(grid2d(1, 5)) \ 128 Mod 2 = 1 Then C628.Checked = True Else C628.Checked = False
        If Integer.Parse(grid2d(1, 6)) \ 1 Mod 2 = 1 Then C721.Checked = True Else C721.Checked = False
        If Integer.Parse(grid2d(1, 6)) \ 2 Mod 2 = 1 Then C722.Checked = True Else C722.Checked = False
        If Integer.Parse(grid2d(1, 6)) \ 4 Mod 2 = 1 Then C723.Checked = True Else C723.Checked = False
        If Integer.Parse(grid2d(1, 6)) \ 8 Mod 2 = 1 Then C724.Checked = True Else C724.Checked = False
        If Integer.Parse(grid2d(1, 6)) \ 16 Mod 2 = 1 Then C725.Checked = True Else C725.Checked = False
        If Integer.Parse(grid2d(1, 6)) \ 32 Mod 2 = 1 Then C726.Checked = True Else C726.Checked = False
        If Integer.Parse(grid2d(1, 6)) \ 64 Mod 2 = 1 Then C727.Checked = True Else C727.Checked = False
        If Integer.Parse(grid2d(1, 6)) \ 128 Mod 2 = 1 Then C728.Checked = True Else C728.Checked = False
        If Integer.Parse(grid2d(1, 7)) \ 1 Mod 2 = 1 Then C821.Checked = True Else C821.Checked = False
        If Integer.Parse(grid2d(1, 7)) \ 2 Mod 2 = 1 Then C822.Checked = True Else C822.Checked = False
        If Integer.Parse(grid2d(1, 7)) \ 4 Mod 2 = 1 Then C823.Checked = True Else C823.Checked = False
        If Integer.Parse(grid2d(1, 7)) \ 8 Mod 2 = 1 Then C824.Checked = True Else C824.Checked = False
        If Integer.Parse(grid2d(1, 7)) \ 16 Mod 2 = 1 Then C825.Checked = True Else C825.Checked = False
        If Integer.Parse(grid2d(1, 7)) \ 32 Mod 2 = 1 Then C826.Checked = True Else C826.Checked = False
        If Integer.Parse(grid2d(1, 7)) \ 64 Mod 2 = 1 Then C827.Checked = True Else C827.Checked = False
        If Integer.Parse(grid2d(1, 7)) \ 128 Mod 2 = 1 Then C828.Checked = True Else C828.Checked = False
        If Integer.Parse(grid2d(2, 0)) \ 1 Mod 2 = 1 Then C131.Checked = True Else C131.Checked = False
        If Integer.Parse(grid2d(2, 0)) \ 2 Mod 2 = 1 Then C132.Checked = True Else C132.Checked = False
        If Integer.Parse(grid2d(2, 0)) \ 4 Mod 2 = 1 Then C133.Checked = True Else C133.Checked = False
        If Integer.Parse(grid2d(2, 0)) \ 8 Mod 2 = 1 Then C134.Checked = True Else C134.Checked = False
        If Integer.Parse(grid2d(2, 0)) \ 16 Mod 2 = 1 Then C135.Checked = True Else C135.Checked = False
        If Integer.Parse(grid2d(2, 0)) \ 32 Mod 2 = 1 Then C136.Checked = True Else C136.Checked = False
        If Integer.Parse(grid2d(2, 0)) \ 64 Mod 2 = 1 Then C137.Checked = True Else C137.Checked = False
        If Integer.Parse(grid2d(2, 0)) \ 128 Mod 2 = 1 Then C138.Checked = True Else C138.Checked = False
        If Integer.Parse(grid2d(2, 1)) \ 1 Mod 2 = 1 Then C231.Checked = True Else C231.Checked = False
        If Integer.Parse(grid2d(2, 1)) \ 2 Mod 2 = 1 Then C232.Checked = True Else C232.Checked = False
        If Integer.Parse(grid2d(2, 1)) \ 4 Mod 2 = 1 Then C233.Checked = True Else C233.Checked = False
        If Integer.Parse(grid2d(2, 1)) \ 8 Mod 2 = 1 Then C234.Checked = True Else C234.Checked = False
        If Integer.Parse(grid2d(2, 1)) \ 16 Mod 2 = 1 Then C235.Checked = True Else C235.Checked = False
        If Integer.Parse(grid2d(2, 1)) \ 32 Mod 2 = 1 Then C236.Checked = True Else C236.Checked = False
        If Integer.Parse(grid2d(2, 1)) \ 64 Mod 2 = 1 Then C237.Checked = True Else C237.Checked = False
        If Integer.Parse(grid2d(2, 1)) \ 128 Mod 2 = 1 Then C238.Checked = True Else C238.Checked = False
        If Integer.Parse(grid2d(2, 2)) \ 1 Mod 2 = 1 Then C331.Checked = True Else C331.Checked = False
        If Integer.Parse(grid2d(2, 2)) \ 2 Mod 2 = 1 Then C332.Checked = True Else C332.Checked = False
        If Integer.Parse(grid2d(2, 2)) \ 4 Mod 2 = 1 Then C333.Checked = True Else C333.Checked = False
        If Integer.Parse(grid2d(2, 2)) \ 8 Mod 2 = 1 Then C334.Checked = True Else C334.Checked = False
        If Integer.Parse(grid2d(2, 2)) \ 16 Mod 2 = 1 Then C335.Checked = True Else C335.Checked = False
        If Integer.Parse(grid2d(2, 2)) \ 32 Mod 2 = 1 Then C336.Checked = True Else C336.Checked = False
        If Integer.Parse(grid2d(2, 2)) \ 64 Mod 2 = 1 Then C337.Checked = True Else C337.Checked = False
        If Integer.Parse(grid2d(2, 2)) \ 128 Mod 2 = 1 Then C338.Checked = True Else C338.Checked = False
        If Integer.Parse(grid2d(2, 3)) \ 1 Mod 2 = 1 Then C431.Checked = True Else C431.Checked = False
        If Integer.Parse(grid2d(2, 3)) \ 2 Mod 2 = 1 Then C432.Checked = True Else C432.Checked = False
        If Integer.Parse(grid2d(2, 3)) \ 4 Mod 2 = 1 Then C433.Checked = True Else C433.Checked = False
        If Integer.Parse(grid2d(2, 3)) \ 8 Mod 2 = 1 Then C434.Checked = True Else C434.Checked = False
        If Integer.Parse(grid2d(2, 3)) \ 16 Mod 2 = 1 Then C435.Checked = True Else C435.Checked = False
        If Integer.Parse(grid2d(2, 3)) \ 32 Mod 2 = 1 Then C436.Checked = True Else C436.Checked = False
        If Integer.Parse(grid2d(2, 3)) \ 64 Mod 2 = 1 Then C437.Checked = True Else C437.Checked = False
        If Integer.Parse(grid2d(2, 3)) \ 128 Mod 2 = 1 Then C438.Checked = True Else C438.Checked = False
        If Integer.Parse(grid2d(2, 4)) \ 1 Mod 2 = 1 Then C531.Checked = True Else C531.Checked = False
        If Integer.Parse(grid2d(2, 4)) \ 2 Mod 2 = 1 Then C532.Checked = True Else C532.Checked = False
        If Integer.Parse(grid2d(2, 4)) \ 4 Mod 2 = 1 Then C533.Checked = True Else C533.Checked = False
        If Integer.Parse(grid2d(2, 4)) \ 8 Mod 2 = 1 Then C534.Checked = True Else C534.Checked = False
        If Integer.Parse(grid2d(2, 4)) \ 16 Mod 2 = 1 Then C535.Checked = True Else C535.Checked = False
        If Integer.Parse(grid2d(2, 4)) \ 32 Mod 2 = 1 Then C536.Checked = True Else C536.Checked = False
        If Integer.Parse(grid2d(2, 4)) \ 64 Mod 2 = 1 Then C537.Checked = True Else C537.Checked = False
        If Integer.Parse(grid2d(2, 4)) \ 128 Mod 2 = 1 Then C538.Checked = True Else C538.Checked = False
        If Integer.Parse(grid2d(2, 5)) \ 1 Mod 2 = 1 Then C631.Checked = True Else C631.Checked = False
        If Integer.Parse(grid2d(2, 5)) \ 2 Mod 2 = 1 Then C632.Checked = True Else C632.Checked = False
        If Integer.Parse(grid2d(2, 5)) \ 4 Mod 2 = 1 Then C633.Checked = True Else C633.Checked = False
        If Integer.Parse(grid2d(2, 5)) \ 8 Mod 2 = 1 Then C634.Checked = True Else C634.Checked = False
        If Integer.Parse(grid2d(2, 5)) \ 16 Mod 2 = 1 Then C635.Checked = True Else C635.Checked = False
        If Integer.Parse(grid2d(2, 5)) \ 32 Mod 2 = 1 Then C636.Checked = True Else C636.Checked = False
        If Integer.Parse(grid2d(2, 5)) \ 64 Mod 2 = 1 Then C637.Checked = True Else C637.Checked = False
        If Integer.Parse(grid2d(2, 5)) \ 128 Mod 2 = 1 Then C638.Checked = True Else C638.Checked = False
        If Integer.Parse(grid2d(2, 6)) \ 1 Mod 2 = 1 Then C731.Checked = True Else C731.Checked = False
        If Integer.Parse(grid2d(2, 6)) \ 2 Mod 2 = 1 Then C732.Checked = True Else C732.Checked = False
        If Integer.Parse(grid2d(2, 6)) \ 4 Mod 2 = 1 Then C733.Checked = True Else C733.Checked = False
        If Integer.Parse(grid2d(2, 6)) \ 8 Mod 2 = 1 Then C734.Checked = True Else C734.Checked = False
        If Integer.Parse(grid2d(2, 6)) \ 16 Mod 2 = 1 Then C735.Checked = True Else C735.Checked = False
        If Integer.Parse(grid2d(2, 6)) \ 32 Mod 2 = 1 Then C736.Checked = True Else C736.Checked = False
        If Integer.Parse(grid2d(2, 6)) \ 64 Mod 2 = 1 Then C737.Checked = True Else C737.Checked = False
        If Integer.Parse(grid2d(2, 6)) \ 128 Mod 2 = 1 Then C738.Checked = True Else C738.Checked = False
        If Integer.Parse(grid2d(2, 7)) \ 1 Mod 2 = 1 Then C831.Checked = True Else C831.Checked = False
        If Integer.Parse(grid2d(2, 7)) \ 2 Mod 2 = 1 Then C832.Checked = True Else C832.Checked = False
        If Integer.Parse(grid2d(2, 7)) \ 4 Mod 2 = 1 Then C833.Checked = True Else C833.Checked = False
        If Integer.Parse(grid2d(2, 7)) \ 8 Mod 2 = 1 Then C834.Checked = True Else C834.Checked = False
        If Integer.Parse(grid2d(2, 7)) \ 16 Mod 2 = 1 Then C835.Checked = True Else C835.Checked = False
        If Integer.Parse(grid2d(2, 7)) \ 32 Mod 2 = 1 Then C836.Checked = True Else C836.Checked = False
        If Integer.Parse(grid2d(2, 7)) \ 64 Mod 2 = 1 Then C837.Checked = True Else C837.Checked = False
        If Integer.Parse(grid2d(2, 7)) \ 128 Mod 2 = 1 Then C838.Checked = True Else C838.Checked = False
        If Integer.Parse(grid2d(3, 0)) \ 1 Mod 2 = 1 Then C141.Checked = True Else C141.Checked = False
        If Integer.Parse(grid2d(3, 0)) \ 2 Mod 2 = 1 Then C142.Checked = True Else C142.Checked = False
        If Integer.Parse(grid2d(3, 0)) \ 4 Mod 2 = 1 Then C143.Checked = True Else C143.Checked = False
        If Integer.Parse(grid2d(3, 0)) \ 8 Mod 2 = 1 Then C144.Checked = True Else C144.Checked = False
        If Integer.Parse(grid2d(3, 0)) \ 16 Mod 2 = 1 Then C145.Checked = True Else C145.Checked = False
        If Integer.Parse(grid2d(3, 0)) \ 32 Mod 2 = 1 Then C146.Checked = True Else C146.Checked = False
        If Integer.Parse(grid2d(3, 0)) \ 64 Mod 2 = 1 Then C147.Checked = True Else C147.Checked = False
        If Integer.Parse(grid2d(3, 0)) \ 128 Mod 2 = 1 Then C148.Checked = True Else C148.Checked = False
        If Integer.Parse(grid2d(3, 1)) \ 1 Mod 2 = 1 Then C241.Checked = True Else C241.Checked = False
        If Integer.Parse(grid2d(3, 1)) \ 2 Mod 2 = 1 Then C242.Checked = True Else C242.Checked = False
        If Integer.Parse(grid2d(3, 1)) \ 4 Mod 2 = 1 Then C243.Checked = True Else C243.Checked = False
        If Integer.Parse(grid2d(3, 1)) \ 8 Mod 2 = 1 Then C244.Checked = True Else C244.Checked = False
        If Integer.Parse(grid2d(3, 1)) \ 16 Mod 2 = 1 Then C245.Checked = True Else C245.Checked = False
        If Integer.Parse(grid2d(3, 1)) \ 32 Mod 2 = 1 Then C246.Checked = True Else C246.Checked = False
        If Integer.Parse(grid2d(3, 1)) \ 64 Mod 2 = 1 Then C247.Checked = True Else C247.Checked = False
        If Integer.Parse(grid2d(3, 1)) \ 128 Mod 2 = 1 Then C248.Checked = True Else C248.Checked = False
        If Integer.Parse(grid2d(3, 2)) \ 1 Mod 2 = 1 Then C341.Checked = True Else C341.Checked = False
        If Integer.Parse(grid2d(3, 2)) \ 2 Mod 2 = 1 Then C342.Checked = True Else C342.Checked = False
        If Integer.Parse(grid2d(3, 2)) \ 4 Mod 2 = 1 Then C343.Checked = True Else C343.Checked = False
        If Integer.Parse(grid2d(3, 2)) \ 8 Mod 2 = 1 Then C344.Checked = True Else C344.Checked = False
        If Integer.Parse(grid2d(3, 2)) \ 16 Mod 2 = 1 Then C345.Checked = True Else C345.Checked = False
        If Integer.Parse(grid2d(3, 2)) \ 32 Mod 2 = 1 Then C346.Checked = True Else C346.Checked = False
        If Integer.Parse(grid2d(3, 2)) \ 64 Mod 2 = 1 Then C347.Checked = True Else C347.Checked = False
        If Integer.Parse(grid2d(3, 2)) \ 128 Mod 2 = 1 Then C348.Checked = True Else C348.Checked = False
        If Integer.Parse(grid2d(3, 3)) \ 1 Mod 2 = 1 Then C441.Checked = True Else C441.Checked = False
        If Integer.Parse(grid2d(3, 3)) \ 2 Mod 2 = 1 Then C442.Checked = True Else C442.Checked = False
        If Integer.Parse(grid2d(3, 3)) \ 4 Mod 2 = 1 Then C443.Checked = True Else C443.Checked = False
        If Integer.Parse(grid2d(3, 3)) \ 8 Mod 2 = 1 Then C444.Checked = True Else C444.Checked = False
        If Integer.Parse(grid2d(3, 3)) \ 16 Mod 2 = 1 Then C445.Checked = True Else C445.Checked = False
        If Integer.Parse(grid2d(3, 3)) \ 32 Mod 2 = 1 Then C446.Checked = True Else C446.Checked = False
        If Integer.Parse(grid2d(3, 3)) \ 64 Mod 2 = 1 Then C447.Checked = True Else C447.Checked = False
        If Integer.Parse(grid2d(3, 3)) \ 128 Mod 2 = 1 Then C448.Checked = True Else C448.Checked = False
        If Integer.Parse(grid2d(3, 4)) \ 1 Mod 2 = 1 Then C541.Checked = True Else C541.Checked = False
        If Integer.Parse(grid2d(3, 4)) \ 2 Mod 2 = 1 Then C542.Checked = True Else C542.Checked = False
        If Integer.Parse(grid2d(3, 4)) \ 4 Mod 2 = 1 Then C543.Checked = True Else C543.Checked = False
        If Integer.Parse(grid2d(3, 4)) \ 8 Mod 2 = 1 Then C544.Checked = True Else C544.Checked = False
        If Integer.Parse(grid2d(3, 4)) \ 16 Mod 2 = 1 Then C545.Checked = True Else C545.Checked = False
        If Integer.Parse(grid2d(3, 4)) \ 32 Mod 2 = 1 Then C546.Checked = True Else C546.Checked = False
        If Integer.Parse(grid2d(3, 4)) \ 64 Mod 2 = 1 Then C547.Checked = True Else C547.Checked = False
        If Integer.Parse(grid2d(3, 4)) \ 128 Mod 2 = 1 Then C548.Checked = True Else C548.Checked = False
        If Integer.Parse(grid2d(3, 5)) \ 1 Mod 2 = 1 Then C641.Checked = True Else C641.Checked = False
        If Integer.Parse(grid2d(3, 5)) \ 2 Mod 2 = 1 Then C642.Checked = True Else C642.Checked = False
        If Integer.Parse(grid2d(3, 5)) \ 4 Mod 2 = 1 Then C643.Checked = True Else C643.Checked = False
        If Integer.Parse(grid2d(3, 5)) \ 8 Mod 2 = 1 Then C644.Checked = True Else C644.Checked = False
        If Integer.Parse(grid2d(3, 5)) \ 16 Mod 2 = 1 Then C645.Checked = True Else C645.Checked = False
        If Integer.Parse(grid2d(3, 5)) \ 32 Mod 2 = 1 Then C646.Checked = True Else C646.Checked = False
        If Integer.Parse(grid2d(3, 5)) \ 64 Mod 2 = 1 Then C647.Checked = True Else C647.Checked = False
        If Integer.Parse(grid2d(3, 5)) \ 128 Mod 2 = 1 Then C648.Checked = True Else C648.Checked = False
        If Integer.Parse(grid2d(3, 6)) \ 1 Mod 2 = 1 Then C741.Checked = True Else C741.Checked = False
        If Integer.Parse(grid2d(3, 6)) \ 2 Mod 2 = 1 Then C742.Checked = True Else C742.Checked = False
        If Integer.Parse(grid2d(3, 6)) \ 4 Mod 2 = 1 Then C743.Checked = True Else C743.Checked = False
        If Integer.Parse(grid2d(3, 6)) \ 8 Mod 2 = 1 Then C744.Checked = True Else C744.Checked = False
        If Integer.Parse(grid2d(3, 6)) \ 16 Mod 2 = 1 Then C745.Checked = True Else C745.Checked = False
        If Integer.Parse(grid2d(3, 6)) \ 32 Mod 2 = 1 Then C746.Checked = True Else C746.Checked = False
        If Integer.Parse(grid2d(3, 6)) \ 64 Mod 2 = 1 Then C747.Checked = True Else C747.Checked = False
        If Integer.Parse(grid2d(3, 6)) \ 128 Mod 2 = 1 Then C748.Checked = True Else C748.Checked = False
        If Integer.Parse(grid2d(3, 7)) \ 1 Mod 2 = 1 Then C841.Checked = True Else C841.Checked = False
        If Integer.Parse(grid2d(3, 7)) \ 2 Mod 2 = 1 Then C842.Checked = True Else C842.Checked = False
        If Integer.Parse(grid2d(3, 7)) \ 4 Mod 2 = 1 Then C843.Checked = True Else C843.Checked = False
        If Integer.Parse(grid2d(3, 7)) \ 8 Mod 2 = 1 Then C844.Checked = True Else C844.Checked = False
        If Integer.Parse(grid2d(3, 7)) \ 16 Mod 2 = 1 Then C845.Checked = True Else C845.Checked = False
        If Integer.Parse(grid2d(3, 7)) \ 32 Mod 2 = 1 Then C846.Checked = True Else C846.Checked = False
        If Integer.Parse(grid2d(3, 7)) \ 64 Mod 2 = 1 Then C847.Checked = True Else C847.Checked = False
        If Integer.Parse(grid2d(3, 7)) \ 128 Mod 2 = 1 Then C848.Checked = True Else C848.Checked = False
        If Integer.Parse(grid2d(4, 0)) \ 1 Mod 2 = 1 Then C151.Checked = True Else C151.Checked = False
        If Integer.Parse(grid2d(4, 0)) \ 2 Mod 2 = 1 Then C152.Checked = True Else C152.Checked = False
        If Integer.Parse(grid2d(4, 0)) \ 4 Mod 2 = 1 Then C153.Checked = True Else C153.Checked = False
        If Integer.Parse(grid2d(4, 0)) \ 8 Mod 2 = 1 Then C154.Checked = True Else C154.Checked = False
        If Integer.Parse(grid2d(4, 0)) \ 16 Mod 2 = 1 Then C155.Checked = True Else C155.Checked = False
        If Integer.Parse(grid2d(4, 0)) \ 32 Mod 2 = 1 Then C156.Checked = True Else C156.Checked = False
        If Integer.Parse(grid2d(4, 0)) \ 64 Mod 2 = 1 Then C157.Checked = True Else C157.Checked = False
        If Integer.Parse(grid2d(4, 0)) \ 128 Mod 2 = 1 Then C158.Checked = True Else C158.Checked = False
        If Integer.Parse(grid2d(4, 1)) \ 1 Mod 2 = 1 Then C251.Checked = True Else C251.Checked = False
        If Integer.Parse(grid2d(4, 1)) \ 2 Mod 2 = 1 Then C252.Checked = True Else C252.Checked = False
        If Integer.Parse(grid2d(4, 1)) \ 4 Mod 2 = 1 Then C253.Checked = True Else C253.Checked = False
        If Integer.Parse(grid2d(4, 1)) \ 8 Mod 2 = 1 Then C254.Checked = True Else C254.Checked = False
        If Integer.Parse(grid2d(4, 1)) \ 16 Mod 2 = 1 Then C255.Checked = True Else C255.Checked = False
        If Integer.Parse(grid2d(4, 1)) \ 32 Mod 2 = 1 Then C256.Checked = True Else C256.Checked = False
        If Integer.Parse(grid2d(4, 1)) \ 64 Mod 2 = 1 Then C257.Checked = True Else C257.Checked = False
        If Integer.Parse(grid2d(4, 1)) \ 128 Mod 2 = 1 Then C258.Checked = True Else C258.Checked = False
        If Integer.Parse(grid2d(4, 2)) \ 1 Mod 2 = 1 Then C351.Checked = True Else C351.Checked = False
        If Integer.Parse(grid2d(4, 2)) \ 2 Mod 2 = 1 Then C352.Checked = True Else C352.Checked = False
        If Integer.Parse(grid2d(4, 2)) \ 4 Mod 2 = 1 Then C353.Checked = True Else C353.Checked = False
        If Integer.Parse(grid2d(4, 2)) \ 8 Mod 2 = 1 Then C354.Checked = True Else C354.Checked = False
        If Integer.Parse(grid2d(4, 2)) \ 16 Mod 2 = 1 Then C355.Checked = True Else C355.Checked = False
        If Integer.Parse(grid2d(4, 2)) \ 32 Mod 2 = 1 Then C356.Checked = True Else C356.Checked = False
        If Integer.Parse(grid2d(4, 2)) \ 64 Mod 2 = 1 Then C357.Checked = True Else C357.Checked = False
        If Integer.Parse(grid2d(4, 2)) \ 128 Mod 2 = 1 Then C358.Checked = True Else C358.Checked = False
        If Integer.Parse(grid2d(4, 3)) \ 1 Mod 2 = 1 Then C451.Checked = True Else C451.Checked = False
        If Integer.Parse(grid2d(4, 3)) \ 2 Mod 2 = 1 Then C452.Checked = True Else C452.Checked = False
        If Integer.Parse(grid2d(4, 3)) \ 4 Mod 2 = 1 Then C453.Checked = True Else C453.Checked = False
        If Integer.Parse(grid2d(4, 3)) \ 8 Mod 2 = 1 Then C454.Checked = True Else C454.Checked = False
        If Integer.Parse(grid2d(4, 3)) \ 16 Mod 2 = 1 Then C455.Checked = True Else C455.Checked = False
        If Integer.Parse(grid2d(4, 3)) \ 32 Mod 2 = 1 Then C456.Checked = True Else C456.Checked = False
        If Integer.Parse(grid2d(4, 3)) \ 64 Mod 2 = 1 Then C457.Checked = True Else C457.Checked = False
        If Integer.Parse(grid2d(4, 3)) \ 128 Mod 2 = 1 Then C458.Checked = True Else C458.Checked = False
        If Integer.Parse(grid2d(4, 4)) \ 1 Mod 2 = 1 Then C551.Checked = True Else C551.Checked = False
        If Integer.Parse(grid2d(4, 4)) \ 2 Mod 2 = 1 Then C552.Checked = True Else C552.Checked = False
        If Integer.Parse(grid2d(4, 4)) \ 4 Mod 2 = 1 Then C553.Checked = True Else C553.Checked = False
        If Integer.Parse(grid2d(4, 4)) \ 8 Mod 2 = 1 Then C554.Checked = True Else C554.Checked = False
        If Integer.Parse(grid2d(4, 4)) \ 16 Mod 2 = 1 Then C555.Checked = True Else C555.Checked = False
        If Integer.Parse(grid2d(4, 4)) \ 32 Mod 2 = 1 Then C556.Checked = True Else C556.Checked = False
        If Integer.Parse(grid2d(4, 4)) \ 64 Mod 2 = 1 Then C557.Checked = True Else C557.Checked = False
        If Integer.Parse(grid2d(4, 4)) \ 128 Mod 2 = 1 Then C558.Checked = True Else C558.Checked = False
        If Integer.Parse(grid2d(4, 5)) \ 1 Mod 2 = 1 Then C651.Checked = True Else C651.Checked = False
        If Integer.Parse(grid2d(4, 5)) \ 2 Mod 2 = 1 Then C652.Checked = True Else C652.Checked = False
        If Integer.Parse(grid2d(4, 5)) \ 4 Mod 2 = 1 Then C653.Checked = True Else C653.Checked = False
        If Integer.Parse(grid2d(4, 5)) \ 8 Mod 2 = 1 Then C654.Checked = True Else C654.Checked = False
        If Integer.Parse(grid2d(4, 5)) \ 16 Mod 2 = 1 Then C655.Checked = True Else C655.Checked = False
        If Integer.Parse(grid2d(4, 5)) \ 32 Mod 2 = 1 Then C656.Checked = True Else C656.Checked = False
        If Integer.Parse(grid2d(4, 5)) \ 64 Mod 2 = 1 Then C657.Checked = True Else C657.Checked = False
        If Integer.Parse(grid2d(4, 5)) \ 128 Mod 2 = 1 Then C658.Checked = True Else C658.Checked = False
        If Integer.Parse(grid2d(4, 6)) \ 1 Mod 2 = 1 Then C751.Checked = True Else C751.Checked = False
        If Integer.Parse(grid2d(4, 6)) \ 2 Mod 2 = 1 Then C752.Checked = True Else C752.Checked = False
        If Integer.Parse(grid2d(4, 6)) \ 4 Mod 2 = 1 Then C753.Checked = True Else C753.Checked = False
        If Integer.Parse(grid2d(4, 6)) \ 8 Mod 2 = 1 Then C754.Checked = True Else C754.Checked = False
        If Integer.Parse(grid2d(4, 6)) \ 16 Mod 2 = 1 Then C755.Checked = True Else C755.Checked = False
        If Integer.Parse(grid2d(4, 6)) \ 32 Mod 2 = 1 Then C756.Checked = True Else C756.Checked = False
        If Integer.Parse(grid2d(4, 6)) \ 64 Mod 2 = 1 Then C757.Checked = True Else C757.Checked = False
        If Integer.Parse(grid2d(4, 6)) \ 128 Mod 2 = 1 Then C758.Checked = True Else C758.Checked = False
        If Integer.Parse(grid2d(4, 7)) \ 1 Mod 2 = 1 Then C851.Checked = True Else C851.Checked = False
        If Integer.Parse(grid2d(4, 7)) \ 2 Mod 2 = 1 Then C852.Checked = True Else C852.Checked = False
        If Integer.Parse(grid2d(4, 7)) \ 4 Mod 2 = 1 Then C853.Checked = True Else C853.Checked = False
        If Integer.Parse(grid2d(4, 7)) \ 8 Mod 2 = 1 Then C854.Checked = True Else C854.Checked = False
        If Integer.Parse(grid2d(4, 7)) \ 16 Mod 2 = 1 Then C855.Checked = True Else C855.Checked = False
        If Integer.Parse(grid2d(4, 7)) \ 32 Mod 2 = 1 Then C856.Checked = True Else C856.Checked = False
        If Integer.Parse(grid2d(4, 7)) \ 64 Mod 2 = 1 Then C857.Checked = True Else C857.Checked = False
        If Integer.Parse(grid2d(4, 7)) \ 128 Mod 2 = 1 Then C858.Checked = True Else C858.Checked = False
        If Integer.Parse(grid2d(5, 0)) \ 1 Mod 2 = 1 Then C161.Checked = True Else C161.Checked = False
        If Integer.Parse(grid2d(5, 0)) \ 2 Mod 2 = 1 Then C162.Checked = True Else C162.Checked = False
        If Integer.Parse(grid2d(5, 0)) \ 4 Mod 2 = 1 Then C163.Checked = True Else C163.Checked = False
        If Integer.Parse(grid2d(5, 0)) \ 8 Mod 2 = 1 Then C164.Checked = True Else C164.Checked = False
        If Integer.Parse(grid2d(5, 0)) \ 16 Mod 2 = 1 Then C165.Checked = True Else C165.Checked = False
        If Integer.Parse(grid2d(5, 0)) \ 32 Mod 2 = 1 Then C166.Checked = True Else C166.Checked = False
        If Integer.Parse(grid2d(5, 0)) \ 64 Mod 2 = 1 Then C167.Checked = True Else C167.Checked = False
        If Integer.Parse(grid2d(5, 0)) \ 128 Mod 2 = 1 Then C168.Checked = True Else C168.Checked = False
        If Integer.Parse(grid2d(5, 1)) \ 1 Mod 2 = 1 Then C261.Checked = True Else C261.Checked = False
        If Integer.Parse(grid2d(5, 1)) \ 2 Mod 2 = 1 Then C262.Checked = True Else C262.Checked = False
        If Integer.Parse(grid2d(5, 1)) \ 4 Mod 2 = 1 Then C263.Checked = True Else C263.Checked = False
        If Integer.Parse(grid2d(5, 1)) \ 8 Mod 2 = 1 Then C264.Checked = True Else C264.Checked = False
        If Integer.Parse(grid2d(5, 1)) \ 16 Mod 2 = 1 Then C265.Checked = True Else C265.Checked = False
        If Integer.Parse(grid2d(5, 1)) \ 32 Mod 2 = 1 Then C266.Checked = True Else C266.Checked = False
        If Integer.Parse(grid2d(5, 1)) \ 64 Mod 2 = 1 Then C267.Checked = True Else C267.Checked = False
        If Integer.Parse(grid2d(5, 1)) \ 128 Mod 2 = 1 Then C268.Checked = True Else C268.Checked = False
        If Integer.Parse(grid2d(5, 2)) \ 1 Mod 2 = 1 Then C361.Checked = True Else C361.Checked = False
        If Integer.Parse(grid2d(5, 2)) \ 2 Mod 2 = 1 Then C362.Checked = True Else C362.Checked = False
        If Integer.Parse(grid2d(5, 2)) \ 4 Mod 2 = 1 Then C363.Checked = True Else C363.Checked = False
        If Integer.Parse(grid2d(5, 2)) \ 8 Mod 2 = 1 Then C364.Checked = True Else C364.Checked = False
        If Integer.Parse(grid2d(5, 2)) \ 16 Mod 2 = 1 Then C365.Checked = True Else C365.Checked = False
        If Integer.Parse(grid2d(5, 2)) \ 32 Mod 2 = 1 Then C366.Checked = True Else C366.Checked = False
        If Integer.Parse(grid2d(5, 2)) \ 64 Mod 2 = 1 Then C367.Checked = True Else C367.Checked = False
        If Integer.Parse(grid2d(5, 2)) \ 128 Mod 2 = 1 Then C368.Checked = True Else C368.Checked = False
        If Integer.Parse(grid2d(5, 3)) \ 1 Mod 2 = 1 Then C461.Checked = True Else C461.Checked = False
        If Integer.Parse(grid2d(5, 3)) \ 2 Mod 2 = 1 Then C462.Checked = True Else C462.Checked = False
        If Integer.Parse(grid2d(5, 3)) \ 4 Mod 2 = 1 Then C463.Checked = True Else C463.Checked = False
        If Integer.Parse(grid2d(5, 3)) \ 8 Mod 2 = 1 Then C464.Checked = True Else C464.Checked = False
        If Integer.Parse(grid2d(5, 3)) \ 16 Mod 2 = 1 Then C465.Checked = True Else C465.Checked = False
        If Integer.Parse(grid2d(5, 3)) \ 32 Mod 2 = 1 Then C466.Checked = True Else C466.Checked = False
        If Integer.Parse(grid2d(5, 3)) \ 64 Mod 2 = 1 Then C467.Checked = True Else C467.Checked = False
        If Integer.Parse(grid2d(5, 3)) \ 128 Mod 2 = 1 Then C468.Checked = True Else C468.Checked = False
        If Integer.Parse(grid2d(5, 4)) \ 1 Mod 2 = 1 Then C561.Checked = True Else C561.Checked = False
        If Integer.Parse(grid2d(5, 4)) \ 2 Mod 2 = 1 Then C562.Checked = True Else C562.Checked = False
        If Integer.Parse(grid2d(5, 4)) \ 4 Mod 2 = 1 Then C563.Checked = True Else C563.Checked = False
        If Integer.Parse(grid2d(5, 4)) \ 8 Mod 2 = 1 Then C564.Checked = True Else C564.Checked = False
        If Integer.Parse(grid2d(5, 4)) \ 16 Mod 2 = 1 Then C565.Checked = True Else C565.Checked = False
        If Integer.Parse(grid2d(5, 4)) \ 32 Mod 2 = 1 Then C566.Checked = True Else C566.Checked = False
        If Integer.Parse(grid2d(5, 4)) \ 64 Mod 2 = 1 Then C567.Checked = True Else C567.Checked = False
        If Integer.Parse(grid2d(5, 4)) \ 128 Mod 2 = 1 Then C568.Checked = True Else C568.Checked = False
        If Integer.Parse(grid2d(5, 5)) \ 1 Mod 2 = 1 Then C661.Checked = True Else C661.Checked = False
        If Integer.Parse(grid2d(5, 5)) \ 2 Mod 2 = 1 Then C662.Checked = True Else C662.Checked = False
        If Integer.Parse(grid2d(5, 5)) \ 4 Mod 2 = 1 Then C663.Checked = True Else C663.Checked = False
        If Integer.Parse(grid2d(5, 5)) \ 8 Mod 2 = 1 Then C664.Checked = True Else C664.Checked = False
        If Integer.Parse(grid2d(5, 5)) \ 16 Mod 2 = 1 Then C665.Checked = True Else C665.Checked = False
        If Integer.Parse(grid2d(5, 5)) \ 32 Mod 2 = 1 Then C666.Checked = True Else C666.Checked = False
        If Integer.Parse(grid2d(5, 5)) \ 64 Mod 2 = 1 Then C667.Checked = True Else C667.Checked = False
        If Integer.Parse(grid2d(5, 5)) \ 128 Mod 2 = 1 Then C668.Checked = True Else C668.Checked = False
        If Integer.Parse(grid2d(5, 6)) \ 1 Mod 2 = 1 Then C761.Checked = True Else C761.Checked = False
        If Integer.Parse(grid2d(5, 6)) \ 2 Mod 2 = 1 Then C762.Checked = True Else C762.Checked = False
        If Integer.Parse(grid2d(5, 6)) \ 4 Mod 2 = 1 Then C763.Checked = True Else C763.Checked = False
        If Integer.Parse(grid2d(5, 6)) \ 8 Mod 2 = 1 Then C764.Checked = True Else C764.Checked = False
        If Integer.Parse(grid2d(5, 6)) \ 16 Mod 2 = 1 Then C765.Checked = True Else C765.Checked = False
        If Integer.Parse(grid2d(5, 6)) \ 32 Mod 2 = 1 Then C766.Checked = True Else C766.Checked = False
        If Integer.Parse(grid2d(5, 6)) \ 64 Mod 2 = 1 Then C767.Checked = True Else C767.Checked = False
        If Integer.Parse(grid2d(5, 6)) \ 128 Mod 2 = 1 Then C768.Checked = True Else C768.Checked = False
        If Integer.Parse(grid2d(5, 7)) \ 1 Mod 2 = 1 Then C861.Checked = True Else C861.Checked = False
        If Integer.Parse(grid2d(5, 7)) \ 2 Mod 2 = 1 Then C862.Checked = True Else C862.Checked = False
        If Integer.Parse(grid2d(5, 7)) \ 4 Mod 2 = 1 Then C863.Checked = True Else C863.Checked = False
        If Integer.Parse(grid2d(5, 7)) \ 8 Mod 2 = 1 Then C864.Checked = True Else C864.Checked = False
        If Integer.Parse(grid2d(5, 7)) \ 16 Mod 2 = 1 Then C865.Checked = True Else C865.Checked = False
        If Integer.Parse(grid2d(5, 7)) \ 32 Mod 2 = 1 Then C866.Checked = True Else C866.Checked = False
        If Integer.Parse(grid2d(5, 7)) \ 64 Mod 2 = 1 Then C867.Checked = True Else C867.Checked = False
        If Integer.Parse(grid2d(5, 7)) \ 128 Mod 2 = 1 Then C868.Checked = True Else C868.Checked = False
        If Integer.Parse(grid2d(6, 0)) \ 1 Mod 2 = 1 Then C171.Checked = True Else C171.Checked = False
        If Integer.Parse(grid2d(6, 0)) \ 2 Mod 2 = 1 Then C172.Checked = True Else C172.Checked = False
        If Integer.Parse(grid2d(6, 0)) \ 4 Mod 2 = 1 Then C173.Checked = True Else C173.Checked = False
        If Integer.Parse(grid2d(6, 0)) \ 8 Mod 2 = 1 Then C174.Checked = True Else C174.Checked = False
        If Integer.Parse(grid2d(6, 0)) \ 16 Mod 2 = 1 Then C175.Checked = True Else C175.Checked = False
        If Integer.Parse(grid2d(6, 0)) \ 32 Mod 2 = 1 Then C176.Checked = True Else C176.Checked = False
        If Integer.Parse(grid2d(6, 0)) \ 64 Mod 2 = 1 Then C177.Checked = True Else C177.Checked = False
        If Integer.Parse(grid2d(6, 0)) \ 128 Mod 2 = 1 Then C178.Checked = True Else C178.Checked = False
        If Integer.Parse(grid2d(6, 1)) \ 1 Mod 2 = 1 Then C271.Checked = True Else C271.Checked = False
        If Integer.Parse(grid2d(6, 1)) \ 2 Mod 2 = 1 Then C272.Checked = True Else C272.Checked = False
        If Integer.Parse(grid2d(6, 1)) \ 4 Mod 2 = 1 Then C273.Checked = True Else C273.Checked = False
        If Integer.Parse(grid2d(6, 1)) \ 8 Mod 2 = 1 Then C274.Checked = True Else C274.Checked = False
        If Integer.Parse(grid2d(6, 1)) \ 16 Mod 2 = 1 Then C275.Checked = True Else C275.Checked = False
        If Integer.Parse(grid2d(6, 1)) \ 32 Mod 2 = 1 Then C276.Checked = True Else C276.Checked = False
        If Integer.Parse(grid2d(6, 1)) \ 64 Mod 2 = 1 Then C277.Checked = True Else C277.Checked = False
        If Integer.Parse(grid2d(6, 1)) \ 128 Mod 2 = 1 Then C278.Checked = True Else C278.Checked = False
        If Integer.Parse(grid2d(6, 2)) \ 1 Mod 2 = 1 Then C371.Checked = True Else C371.Checked = False
        If Integer.Parse(grid2d(6, 2)) \ 2 Mod 2 = 1 Then C372.Checked = True Else C372.Checked = False
        If Integer.Parse(grid2d(6, 2)) \ 4 Mod 2 = 1 Then C373.Checked = True Else C373.Checked = False
        If Integer.Parse(grid2d(6, 2)) \ 8 Mod 2 = 1 Then C374.Checked = True Else C374.Checked = False
        If Integer.Parse(grid2d(6, 2)) \ 16 Mod 2 = 1 Then C375.Checked = True Else C375.Checked = False
        If Integer.Parse(grid2d(6, 2)) \ 32 Mod 2 = 1 Then C376.Checked = True Else C376.Checked = False
        If Integer.Parse(grid2d(6, 2)) \ 64 Mod 2 = 1 Then C377.Checked = True Else C377.Checked = False
        If Integer.Parse(grid2d(6, 2)) \ 128 Mod 2 = 1 Then C378.Checked = True Else C378.Checked = False
        If Integer.Parse(grid2d(6, 3)) \ 1 Mod 2 = 1 Then C471.Checked = True Else C471.Checked = False
        If Integer.Parse(grid2d(6, 3)) \ 2 Mod 2 = 1 Then C472.Checked = True Else C472.Checked = False
        If Integer.Parse(grid2d(6, 3)) \ 4 Mod 2 = 1 Then C473.Checked = True Else C473.Checked = False
        If Integer.Parse(grid2d(6, 3)) \ 8 Mod 2 = 1 Then C474.Checked = True Else C474.Checked = False
        If Integer.Parse(grid2d(6, 3)) \ 16 Mod 2 = 1 Then C475.Checked = True Else C475.Checked = False
        If Integer.Parse(grid2d(6, 3)) \ 32 Mod 2 = 1 Then C476.Checked = True Else C476.Checked = False
        If Integer.Parse(grid2d(6, 3)) \ 64 Mod 2 = 1 Then C477.Checked = True Else C477.Checked = False
        If Integer.Parse(grid2d(6, 3)) \ 128 Mod 2 = 1 Then C478.Checked = True Else C478.Checked = False
        If Integer.Parse(grid2d(6, 4)) \ 1 Mod 2 = 1 Then C571.Checked = True Else C571.Checked = False
        If Integer.Parse(grid2d(6, 4)) \ 2 Mod 2 = 1 Then C572.Checked = True Else C572.Checked = False
        If Integer.Parse(grid2d(6, 4)) \ 4 Mod 2 = 1 Then C573.Checked = True Else C573.Checked = False
        If Integer.Parse(grid2d(6, 4)) \ 8 Mod 2 = 1 Then C574.Checked = True Else C574.Checked = False
        If Integer.Parse(grid2d(6, 4)) \ 16 Mod 2 = 1 Then C575.Checked = True Else C575.Checked = False
        If Integer.Parse(grid2d(6, 4)) \ 32 Mod 2 = 1 Then C576.Checked = True Else C576.Checked = False
        If Integer.Parse(grid2d(6, 4)) \ 64 Mod 2 = 1 Then C577.Checked = True Else C577.Checked = False
        If Integer.Parse(grid2d(6, 4)) \ 128 Mod 2 = 1 Then C578.Checked = True Else C578.Checked = False
        If Integer.Parse(grid2d(6, 5)) \ 1 Mod 2 = 1 Then C671.Checked = True Else C671.Checked = False
        If Integer.Parse(grid2d(6, 5)) \ 2 Mod 2 = 1 Then C672.Checked = True Else C672.Checked = False
        If Integer.Parse(grid2d(6, 5)) \ 4 Mod 2 = 1 Then C673.Checked = True Else C673.Checked = False
        If Integer.Parse(grid2d(6, 5)) \ 8 Mod 2 = 1 Then C674.Checked = True Else C674.Checked = False
        If Integer.Parse(grid2d(6, 5)) \ 16 Mod 2 = 1 Then C675.Checked = True Else C675.Checked = False
        If Integer.Parse(grid2d(6, 5)) \ 32 Mod 2 = 1 Then C676.Checked = True Else C676.Checked = False
        If Integer.Parse(grid2d(6, 5)) \ 64 Mod 2 = 1 Then C677.Checked = True Else C677.Checked = False
        If Integer.Parse(grid2d(6, 5)) \ 128 Mod 2 = 1 Then C678.Checked = True Else C678.Checked = False
        If Integer.Parse(grid2d(6, 6)) \ 1 Mod 2 = 1 Then C771.Checked = True Else C771.Checked = False
        If Integer.Parse(grid2d(6, 6)) \ 2 Mod 2 = 1 Then C772.Checked = True Else C772.Checked = False
        If Integer.Parse(grid2d(6, 6)) \ 4 Mod 2 = 1 Then C773.Checked = True Else C773.Checked = False
        If Integer.Parse(grid2d(6, 6)) \ 8 Mod 2 = 1 Then C774.Checked = True Else C774.Checked = False
        If Integer.Parse(grid2d(6, 6)) \ 16 Mod 2 = 1 Then C775.Checked = True Else C775.Checked = False
        If Integer.Parse(grid2d(6, 6)) \ 32 Mod 2 = 1 Then C776.Checked = True Else C776.Checked = False
        If Integer.Parse(grid2d(6, 6)) \ 64 Mod 2 = 1 Then C777.Checked = True Else C777.Checked = False
        If Integer.Parse(grid2d(6, 6)) \ 128 Mod 2 = 1 Then C778.Checked = True Else C778.Checked = False
        If Integer.Parse(grid2d(6, 7)) \ 1 Mod 2 = 1 Then C871.Checked = True Else C871.Checked = False
        If Integer.Parse(grid2d(6, 7)) \ 2 Mod 2 = 1 Then C872.Checked = True Else C872.Checked = False
        If Integer.Parse(grid2d(6, 7)) \ 4 Mod 2 = 1 Then C873.Checked = True Else C873.Checked = False
        If Integer.Parse(grid2d(6, 7)) \ 8 Mod 2 = 1 Then C874.Checked = True Else C874.Checked = False
        If Integer.Parse(grid2d(6, 7)) \ 16 Mod 2 = 1 Then C875.Checked = True Else C875.Checked = False
        If Integer.Parse(grid2d(6, 7)) \ 32 Mod 2 = 1 Then C876.Checked = True Else C876.Checked = False
        If Integer.Parse(grid2d(6, 7)) \ 64 Mod 2 = 1 Then C877.Checked = True Else C877.Checked = False
        If Integer.Parse(grid2d(6, 7)) \ 128 Mod 2 = 1 Then C878.Checked = True Else C878.Checked = False
        If Integer.Parse(grid2d(7, 0)) \ 1 Mod 2 = 1 Then C181.Checked = True Else C181.Checked = False
        If Integer.Parse(grid2d(7, 0)) \ 2 Mod 2 = 1 Then C182.Checked = True Else C182.Checked = False
        If Integer.Parse(grid2d(7, 0)) \ 4 Mod 2 = 1 Then C183.Checked = True Else C183.Checked = False
        If Integer.Parse(grid2d(7, 0)) \ 8 Mod 2 = 1 Then C184.Checked = True Else C184.Checked = False
        If Integer.Parse(grid2d(7, 0)) \ 16 Mod 2 = 1 Then C185.Checked = True Else C185.Checked = False
        If Integer.Parse(grid2d(7, 0)) \ 32 Mod 2 = 1 Then C186.Checked = True Else C186.Checked = False
        If Integer.Parse(grid2d(7, 0)) \ 64 Mod 2 = 1 Then C187.Checked = True Else C187.Checked = False
        If Integer.Parse(grid2d(7, 0)) \ 128 Mod 2 = 1 Then C188.Checked = True Else C188.Checked = False
        If Integer.Parse(grid2d(7, 1)) \ 1 Mod 2 = 1 Then C281.Checked = True Else C281.Checked = False
        If Integer.Parse(grid2d(7, 1)) \ 2 Mod 2 = 1 Then C282.Checked = True Else C282.Checked = False
        If Integer.Parse(grid2d(7, 1)) \ 4 Mod 2 = 1 Then C283.Checked = True Else C283.Checked = False
        If Integer.Parse(grid2d(7, 1)) \ 8 Mod 2 = 1 Then C284.Checked = True Else C284.Checked = False
        If Integer.Parse(grid2d(7, 1)) \ 16 Mod 2 = 1 Then C285.Checked = True Else C285.Checked = False
        If Integer.Parse(grid2d(7, 1)) \ 32 Mod 2 = 1 Then C286.Checked = True Else C286.Checked = False
        If Integer.Parse(grid2d(7, 1)) \ 64 Mod 2 = 1 Then C287.Checked = True Else C287.Checked = False
        If Integer.Parse(grid2d(7, 1)) \ 128 Mod 2 = 1 Then C288.Checked = True Else C288.Checked = False
        If Integer.Parse(grid2d(7, 2)) \ 1 Mod 2 = 1 Then C381.Checked = True Else C381.Checked = False
        If Integer.Parse(grid2d(7, 2)) \ 2 Mod 2 = 1 Then C382.Checked = True Else C382.Checked = False
        If Integer.Parse(grid2d(7, 2)) \ 4 Mod 2 = 1 Then C383.Checked = True Else C383.Checked = False
        If Integer.Parse(grid2d(7, 2)) \ 8 Mod 2 = 1 Then C384.Checked = True Else C384.Checked = False
        If Integer.Parse(grid2d(7, 2)) \ 16 Mod 2 = 1 Then C385.Checked = True Else C385.Checked = False
        If Integer.Parse(grid2d(7, 2)) \ 32 Mod 2 = 1 Then C386.Checked = True Else C386.Checked = False
        If Integer.Parse(grid2d(7, 2)) \ 64 Mod 2 = 1 Then C387.Checked = True Else C387.Checked = False
        If Integer.Parse(grid2d(7, 2)) \ 128 Mod 2 = 1 Then C388.Checked = True Else C388.Checked = False
        If Integer.Parse(grid2d(7, 3)) \ 1 Mod 2 = 1 Then C481.Checked = True Else C481.Checked = False
        If Integer.Parse(grid2d(7, 3)) \ 2 Mod 2 = 1 Then C482.Checked = True Else C482.Checked = False
        If Integer.Parse(grid2d(7, 3)) \ 4 Mod 2 = 1 Then C483.Checked = True Else C483.Checked = False
        If Integer.Parse(grid2d(7, 3)) \ 8 Mod 2 = 1 Then C484.Checked = True Else C484.Checked = False
        If Integer.Parse(grid2d(7, 3)) \ 16 Mod 2 = 1 Then C485.Checked = True Else C485.Checked = False
        If Integer.Parse(grid2d(7, 3)) \ 32 Mod 2 = 1 Then C486.Checked = True Else C486.Checked = False
        If Integer.Parse(grid2d(7, 3)) \ 64 Mod 2 = 1 Then C487.Checked = True Else C487.Checked = False
        If Integer.Parse(grid2d(7, 3)) \ 128 Mod 2 = 1 Then C488.Checked = True Else C488.Checked = False
        If Integer.Parse(grid2d(7, 4)) \ 1 Mod 2 = 1 Then C581.Checked = True Else C581.Checked = False
        If Integer.Parse(grid2d(7, 4)) \ 2 Mod 2 = 1 Then C582.Checked = True Else C582.Checked = False
        If Integer.Parse(grid2d(7, 4)) \ 4 Mod 2 = 1 Then C583.Checked = True Else C583.Checked = False
        If Integer.Parse(grid2d(7, 4)) \ 8 Mod 2 = 1 Then C584.Checked = True Else C584.Checked = False
        If Integer.Parse(grid2d(7, 4)) \ 16 Mod 2 = 1 Then C585.Checked = True Else C585.Checked = False
        If Integer.Parse(grid2d(7, 4)) \ 32 Mod 2 = 1 Then C586.Checked = True Else C586.Checked = False
        If Integer.Parse(grid2d(7, 4)) \ 64 Mod 2 = 1 Then C587.Checked = True Else C587.Checked = False
        If Integer.Parse(grid2d(7, 4)) \ 128 Mod 2 = 1 Then C588.Checked = True Else C588.Checked = False
        If Integer.Parse(grid2d(7, 5)) \ 1 Mod 2 = 1 Then C681.Checked = True Else C681.Checked = False
        If Integer.Parse(grid2d(7, 5)) \ 2 Mod 2 = 1 Then C682.Checked = True Else C682.Checked = False
        If Integer.Parse(grid2d(7, 5)) \ 4 Mod 2 = 1 Then C683.Checked = True Else C683.Checked = False
        If Integer.Parse(grid2d(7, 5)) \ 8 Mod 2 = 1 Then C684.Checked = True Else C684.Checked = False
        If Integer.Parse(grid2d(7, 5)) \ 16 Mod 2 = 1 Then C685.Checked = True Else C685.Checked = False
        If Integer.Parse(grid2d(7, 5)) \ 32 Mod 2 = 1 Then C686.Checked = True Else C686.Checked = False
        If Integer.Parse(grid2d(7, 5)) \ 64 Mod 2 = 1 Then C687.Checked = True Else C687.Checked = False
        If Integer.Parse(grid2d(7, 5)) \ 128 Mod 2 = 1 Then C688.Checked = True Else C688.Checked = False
        If Integer.Parse(grid2d(7, 6)) \ 1 Mod 2 = 1 Then C781.Checked = True Else C781.Checked = False
        If Integer.Parse(grid2d(7, 6)) \ 2 Mod 2 = 1 Then C782.Checked = True Else C782.Checked = False
        If Integer.Parse(grid2d(7, 6)) \ 4 Mod 2 = 1 Then C783.Checked = True Else C783.Checked = False
        If Integer.Parse(grid2d(7, 6)) \ 8 Mod 2 = 1 Then C784.Checked = True Else C784.Checked = False
        If Integer.Parse(grid2d(7, 6)) \ 16 Mod 2 = 1 Then C785.Checked = True Else C785.Checked = False
        If Integer.Parse(grid2d(7, 6)) \ 32 Mod 2 = 1 Then C786.Checked = True Else C786.Checked = False
        If Integer.Parse(grid2d(7, 6)) \ 64 Mod 2 = 1 Then C787.Checked = True Else C787.Checked = False
        If Integer.Parse(grid2d(7, 6)) \ 128 Mod 2 = 1 Then C788.Checked = True Else C788.Checked = False
        If Integer.Parse(grid2d(7, 7)) \ 1 Mod 2 = 1 Then C881.Checked = True Else C881.Checked = False
        If Integer.Parse(grid2d(7, 7)) \ 2 Mod 2 = 1 Then C882.Checked = True Else C882.Checked = False
        If Integer.Parse(grid2d(7, 7)) \ 4 Mod 2 = 1 Then C883.Checked = True Else C883.Checked = False
        If Integer.Parse(grid2d(7, 7)) \ 8 Mod 2 = 1 Then C884.Checked = True Else C884.Checked = False
        If Integer.Parse(grid2d(7, 7)) \ 16 Mod 2 = 1 Then C885.Checked = True Else C885.Checked = False
        If Integer.Parse(grid2d(7, 7)) \ 32 Mod 2 = 1 Then C886.Checked = True Else C886.Checked = False
        If Integer.Parse(grid2d(7, 7)) \ 64 Mod 2 = 1 Then C887.Checked = True Else C887.Checked = False
        If Integer.Parse(grid2d(7, 7)) \ 128 Mod 2 = 1 Then C888.Checked = True Else C888.Checked = False
    End Sub

    Private Sub SavePatternToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SavePatternToolStripMenuItem.Click

        Dim saveline As String = Nothing

        For i = 0 To 499
            saveline &= lines(i)
            If i <> 499 Then saveline &= Environment.NewLine
        Next

        SaveFileDialog1.Filter = "TXT Files (*.txt*)|*.txt"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, saveline, False)
        End If

        saveline = Nothing
    End Sub

    Private Sub OpenPatternFileToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OpenPatternFileToolStripMenuItem.Click


        stepChange = True

        Dim openline As String = Nothing

        OpenFileDialog1.Filter = "TXT Files (*.txt*)|*.txt"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            openline = System.IO.File.ReadAllText(OpenFileDialog1.FileName)
        End If

        NUpDown.Value = 0

        lines = openline.Split(Environment.NewLine)

        getLines()
        setGrid()
        stepChange = False

    End Sub


    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        gllstep = lstep.Value
        glcstep = fstep.Value
        '   For i = fstep.Value To lstep.Value
        sendToMCU(False, True, fstep.Value)
        '  Next

    End Sub
    Dim glcstep As Integer = 0
    Dim gllstep As Integer = 0
    Dim gli As Integer = 0
    Dim glj As Integer = 0

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick

        SerialPort1.Write(New Byte() {grid2d(gli, glj)}, 0, 1)
        glj += 1
        If glj = 8 Then
            glj = 0
            gli += 1
        End If

        If gli = 8 Then
            gli = 0
            If glcstep < gllstep Then
                glcstep += 1
                sendToMCU(False, True, glcstep)
            Else
                Button6.Enabled = True
                Timer1.Enabled = False
            End If
            
        End If


        'ProgressBar1.Value = gli * 8 + glj
    End Sub
End Class


