module App

open Feliz

let counter = React.functionComponent(fun () ->
    let (count, setCount) = React.useState(0)
    Html.div [
        Html.h1 count
        Html.button [
            prop.text "Increment"
            prop.onClick (fun _ -> setCount(count + 1))
        ]
        Html.button [
            prop.text "Decrement"
            prop.onClick (fun _ -> setCount(count - 1))
        ]

    ])