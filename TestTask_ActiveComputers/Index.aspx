<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="TestTask_ActiveComputers.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="Styles.css" />
	<style type="text/css">
		#massiv {
			width: 629px;
		}
		#result {
			width: 189px;
		}
	</style>
</head>
<body>
    <form id="rsvpform" runat="server">
        <div>
            <div>
                <asp:Label ID="LabelFirstTask" runat="server" Text="1. Реализовать приложение C#, которое предоставит функционал сложения каждого второго нечетного числа из массива чисел тела запроса и вернёт их сумму по модулю." Font-Bold="True" Font-Size="Medium"></asp:Label>         
            </div>
            <div>
                <asp:Label ID="LabelFirstTaskInputMassive" runat="server" Text="Массив чисел через пробел: "></asp:Label>
			    <asp:TextBox ID="TextBoxFirstTaskInputMassive" runat="server" Height="16px" Width="1037px"></asp:TextBox>
		    </div>        
            <div>
                <asp:Button ID="ButtonFirstTaskSend" runat="server" Height="25px" OnClick="ButtonSend_Click" Text="Отправить" Width="92px" />
            </div>
            <div>
                <asp:Label ID="LabelFirstTaskResult" runat="server" Text="Результат: "></asp:Label>
                <asp:TextBox ID="TextBoxFirstTaskOutputResult" runat="server" Width="268px"></asp:TextBox>
            </div> 
        </div>         
        <div>
            <div>
                <asp:Label ID="LabelSecondTask" runat="server" Text="2. Реализовать приложение C#, которое предоставит функционал сложения двух непустых связанных списков, представляющих два положительных целых числа. Цифры хранятся в обратном порядке, каждый из их узлов
содержит одну цифру. Реализуйте алгоритм сложения связанных списков, не переводя хранящиеся в них данные в числовой тип (по-узловое сложение), возвращающий результат в виде связанного списка." Font-Bold="True" Font-Size="Medium"></asp:Label>         
            </div>
            <div>
                <asp:Label ID="LabelSecondTaskInputMassive" runat="server" Text="Два числа через пробел: "></asp:Label>
			    <asp:TextBox ID="TextBoxSecondTaskInputMassive" runat="server" Height="16px" Width="1037px"></asp:TextBox>
		    </div>        
            <div>
                <asp:Button ID="ButtonSecondTaskSend" runat="server" Height="25px" OnClick="ButtonSecondTask1_Click" Text="Отправить" Width="92px" />
            </div>
            <div>
                <asp:Label ID="LabelSecondTaskResult" runat="server" Text="Результат: "></asp:Label>
                <asp:TextBox ID="TextBoxSecondTaskOutputResult" runat="server" Width="268px"></asp:TextBox>
            </div> 
        </div>     
        <div>
            <div>
                <asp:Label ID="LabelThirdTask" runat="server" Text="3. Реализовать приложение C#, которое предоставит функционал определения входящий строки является ли она палиндромом." Font-Bold="True" Font-Size="Medium"></asp:Label>         
            </div>
            <div>
                <asp:Label ID="LabelThirdTaskInputMassive" runat="server" Text="Входящая строка: "></asp:Label>
			    <asp:TextBox ID="TextBoxThirdTaskInputMassive" runat="server" Height="16px" Width="1037px"></asp:TextBox>
		    </div>        
            <div>
                <asp:Button ID="ButtonThirdTaskSend" runat="server" Height="25px" Text="Отправить" Width="92px" OnClick="ButtonThirdTaskSend_Click" />
            </div>
            <div>
                <asp:Label ID="LabelThirdTaskResult" runat="server" Text="Результат: "></asp:Label>
                <asp:TextBox ID="TextBoxThirdTaskOutputResult" runat="server" Width="268px"></asp:TextBox>
            </div> 
        </div> 
    </form>
</body>
</html>
