# TraderDiaryWebApp

This is a C# fullstack blazor project for trading diary and stock information requests. <br />
Contains the following: <br />
TraderApp.Api: <br />
  A Restful api for the backend, the repository is just moking databases with listes for the purpose of easier tests for anyone who is interested. <br />
  Modell, just a POCO <br />
  and the Web, which makes the rest functions useable. <br />
  
  You can add items to your portfolio, (name, ticker, price you bought.) <br />
  You can sell those items for profit, the balance is calculated as per item and as the full portfolio <br />
  You can remove items from the portolio <br />
  And you can use the searchbar for real informations about the questioned stock. I've only implemented the last day's closing price. This is possible with the help of the polygon api <br />
 
