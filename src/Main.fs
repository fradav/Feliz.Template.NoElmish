module Main

open Fable.Core.JsInterop

importAll "normalize.css"
importAll "../styles/main.scss"

open Fable.React

mountById "feliz-app" (App.counter()) 

