# TraderDiaryWebApp

This is a C# fullstack blazor project for trading diary and stock information requests.
Contains the following:
TraderApp.Api:
  -A Restful api for the backend, the repository is just moking databases with listes for the purpose of easier tests for anyone who is interested.
  -Modell, just a POCO
  -and the Web, which makes the rest functions useable.
  
  You can add items to your portfolio, (name, ticker, price you bought.)
  You can sell those items for profit, the balance is calculated as per item and as the full portfolio
  You can remove items from the portolio
  And you can use the searchbar for real informations about the questioned stock. I've only implemented the last day's closing price. This is possible with the help of the polygon api
 
