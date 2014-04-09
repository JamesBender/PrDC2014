using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TicTacToe.Core;

namespace TicTacToe.Specs
{
    [Binding]
    public class TicTacToeSteps
    {
        private string[,] _board;
        private string _result;
        private GameEngine _gameEngine = new GameEngine();

        [Given(@"I have a tic tac toe board")]
        public void GivenIHaveATicTacToeBoard()
        {
            _board = new String[3, 3] { { " ", " ", " " }, { " ", " ", " " }, { " ", " ", " " } };
        }

        [Given(@"the board is empty")]
        public void GivenTheBoardIsEmpty()
        {
            return;
        }

        [When(@"I determine the winner")]
        public void WhenIDetermineTheWinner()
        {
            _result = _gameEngine.GetGameWinner(_board);
        }

        [Then(@"the result of ""(.*)""")]
        public void ThenTheResultOf(string expectedResult)
        {
            Assert.AreEqual(expectedResult, _result);
        }

        [Given(@"I have all ""(.*)"" in the top row")]
        public void GivenIHaveAllInTheTopRow(string currentToken)
        {
            _board[0, 0] = currentToken;
            _board[0, 1] = currentToken;
            _board[0, 2] = currentToken;
        }

        [Given(@"It looks like this")]
        public void GivenItLooksLikeThis(Table table)
        {
            _board[0,0] = table.Rows[0][0];
            _board[2,2] = table.Rows[2][2];

            Assert.AreEqual("X", _board[0, 0]);
            Assert.AreEqual("X", _board[2, 2]);
        }

    }
}
