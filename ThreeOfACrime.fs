//Problem 5 - Three-of-a-crime

open System
open System.Windows.Forms

//PlayGame function accepts a number of players
let playGame (players:int) =
    printfn "You will play the game with %A player(s)" players
    (*
          game logic goes here
    *)

//Configure game window
let gameGUI = new Form()
gameGUI.Visible <- true
gameGUI.Text <- "Three-Of-A-Crime"
gameGUI.BackColor <- System.Drawing.Color.WhiteSmoke
gameGUI.Size <- System.Drawing.Size(400,400)

//Add content to the form
let playerLabel = new Label()
playerLabel.Text <- "Choose players:"
playerLabel.Location <- System.Drawing.Point(150,150)
let players1 = new Button()
players1.Location <- System.Drawing.Point(50,200)
players1.Text <- "1"
players1.Click.Add(fun _ -> playGame(1))
let players2 = new Button()
players2.Location <- System.Drawing.Point(150,200)
players2.Text <- "2"
players2.Click.Add(fun _ -> playGame(2))
let players3 = new Button()
players3.Text <- "3"
players3.Click.Add(fun _ -> playGame(3))
players3.Location <- System.Drawing.Point(250,200)
gameGUI.Controls.Add(playerLabel)
gameGUI.Controls.Add(players1)
gameGUI.Controls.Add(players2)
gameGUI.Controls.Add(players3)


[<STAThread>]
Application.Run(gameGUI)