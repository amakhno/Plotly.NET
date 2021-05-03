(**
// can't yet format YamlFrontmatter (["title: Scatterplot matrix"; "category: Distribution Charts"; "categoryindex: 5"; "index: 5"], Some { StartLine = 2 StartColumn = 0 EndLine = 6 EndColumn = 8 }) to pynb markdown

# Scatterplot matrix 

[![Binder](https://plotly.github.io/Plotly.NET/img/badge-binder.svg)](https://mybinder.org/v2/gh/plotly/Plotly.NET/gh-pages?filepath=4_5_splom.ipynb)&emsp;
[![Script](https://plotly.github.io/Plotly.NET/img/badge-script.svg)](https://plotly.github.io/Plotly.NET/4_5_splom.fsx)&emsp;
[![Notebook](https://plotly.github.io/Plotly.NET/img/badge-notebook.svg)](https://plotly.github.io/Plotly.NET/4_5_splom.ipynb)

*Summary:* This example shows how to plot a scatterplot matrix (splom) in F#.

let's first create some data for the purpose of creating example charts:

*)
open Plotly.NET 

let data = 
    [
        "A",[|1.;4.;3.4;0.7;|]
        "B",[|3.;1.5;1.7;2.3;|]
        "C",[|2.;4.;3.1;5.|]
        "D",[|4.;2.;2.;4.;|]
    ]
(**
Using a scatterplot matrix of several different variables can help to determine whether there are any
relationships among the variables in the dataset.

**Attention**: this function is not very well tested and does not use the `Chart.Grid` functionality. 
Until that is fixed, consider creating splom plot programatically using `Chart.Grid` for more control.
*)
let splom1 =
    Chart.Splom(data,Color="blue")(* output: 
<div id="9c69964e-4c78-4812-8a3d-ece00b88db34" style="width: 600px; height: 600px;"><!-- Plotly chart will be drawn inside this DIV --></div>
<script type="text/javascript">

            var renderPlotly_9c69964e4c7848128a3dece00b88db34 = function() {
            var fsharpPlotlyRequire = requirejs.config({context:'fsharp-plotly',paths:{plotly:'https://cdn.plot.ly/plotly-latest.min'}}) || require;
            fsharpPlotlyRequire(['plotly'], function(Plotly) {

            var data = [{"type":"splom","dimensions":[{"values":[1.0,4.0,3.4,0.7],"label":"A"},{"values":[3.0,1.5,1.7,2.3],"label":"B"},{"values":[2.0,4.0,3.1,5.0],"label":"C"},{"values":[4.0,2.0,2.0,4.0],"label":"D"}],"line":{"color":"blue"}}];
            var layout = {};
            var config = {};
            Plotly.newPlot('9c69964e-4c78-4812-8a3d-ece00b88db34', data, layout, config);
});
            };
            if ((typeof(requirejs) !==  typeof(Function)) || (typeof(requirejs.config) !== typeof(Function))) {
                var script = document.createElement("script");
                script.setAttribute("src", "https://cdnjs.cloudflare.com/ajax/libs/require.js/2.3.6/require.min.js");
                script.onload = function(){
                    renderPlotly_9c69964e4c7848128a3dece00b88db34();
                };
                document.getElementsByTagName("head")[0].appendChild(script);
            }
            else {
                renderPlotly_9c69964e4c7848128a3dece00b88db34();
            }
</script>
*)

