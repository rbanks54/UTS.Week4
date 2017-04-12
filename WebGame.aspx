<%@ Page Language="C#" mas AutoEventWireup="true" CodeBehind="WebGame.aspx.cs" Inherits="UTS.WebGuessGame.WebGame" %>
<!DOCTYPE html><html>
<head runat="server">
    <title>Number Guessing Game</title>
</head>
<body>
  <form id="Form" runat="server">
    <p>Please enter your guess:</p>
    <p>
      <asp:TextBox ID="GuessTextBox" runat="server"/>
    </p>
    <p>
      <asp:Button ID="GuessButton" runat="server" Text="Guess" OnClick="GuessButton_Click" />
      <asp:Button ID="NewGameButton" runat="server" Text="New Game" OnClick="NewGameButton_Click"/>
    </p>
    <p>
      <asp:Label ID="ResultLabel" runat="server" Text="New game started"/>
    </p>
  </form>
</body>
</html>