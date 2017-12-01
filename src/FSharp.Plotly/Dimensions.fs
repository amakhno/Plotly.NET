namespace FSharp.Plotly

open System


/// Dimensions type inherits from dynamic object
type Dimensions () =
    inherit DynamicObj ()

    /// Initialized Dimensions object
    static member init
        (
            values,
            ?Range,
            ?Constraintrange,
            ?Visible,
            ?Label,
            ?Tickvals,
            ?TickText,
            ?TickFormat
        ) =
            Dimensions () 
            |> Dimensions.style
                (
                    values           = values    ,
                    ?Range           = Range     ,
                    ?Constraintrange = Constraintrange,
                    ?Visible         = Visible,
                    ?Label           = Label,
                    ?Tickvals        = Tickvals,
                    ?TickText        = TickText,
                    ?TickFormat      = TickFormat
                )


    // Applies the styles to Dimensions()
    static member style
        (
            values  : seq<#IConvertible>,
            ?Range  : StyleParam.Range,
            ?Constraintrange : StyleParam.Range,
            ?Visible,
            ?Label,
            ?Tickvals,
            ?TickText,
            ?TickFormat
        ) =
            (fun (dims:Dimensions) -> 
                values           |> DynObj.setValue      dims "values"
                Range            |> DynObj.setValueOptBy dims "range" StyleParam.Range.convert                
                Constraintrange  |> DynObj.setValueOptBy dims "constraintrange" StyleParam.Range.convert                 
                Visible          |> DynObj.setValueOpt   dims "Visible"
                Label            |> DynObj.setValueOpt   dims "label"
                Tickvals         |> DynObj.setValueOpt   dims "tickvals"
                TickText         |> DynObj.setValueOpt   dims "ticktext"   
                TickFormat       |> DynObj.setValueOpt   dims "tickformat"
                
                // out -> 
                dims
            )



               