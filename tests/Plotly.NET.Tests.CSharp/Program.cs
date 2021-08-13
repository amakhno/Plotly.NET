using System;
using Plotly.NET;
using Microsoft.FSharp.Core;

namespace Plotly.NET.Tests.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Chart.Point<int, int, string>(
                new int[] { 1 },
                new int[] { 1 },
                Labels: new string[] {"soos"},
                TextPosition: StyleParam.TextPosition.BottomCenter
            ).Show();
        }
    }
}
