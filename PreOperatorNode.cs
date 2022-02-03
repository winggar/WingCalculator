﻿namespace WingCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class PreOperatorNode : INode
{
	public static readonly int MaxTier = 12;

	public string Text { get; private set; }

	public PreOperatorNode(string s) => Text = s;

	public double Solve() => throw new NotImplementedException();

	public int Tier => Text switch
	{
		"**" => 0,

		"*" => 1,
		"/" => 1,
		"%" => 1,
		"//" => 1,

		"+" => 2,
		"-" => 2,

		"<<" => 3,
		">>" => 3,

		"<" => 4,
		">" => 4,
		"<=" => 4,
		">=" => 4,

		"==" => 5,
		"!=" => 5,

		"&" => 6,

		"^" => 7,

		"|" => 8,

		"&&" => 9,

		"||" => 10,

		"*=" => 11,
		"/=" => 11,
		"%=" => 11,
		"//=" => 11,
		"+=" => 11,
		"-=" => 11,
		"<<=" => 11,
		">>=" => 11,
		"&=" => 11,
		"^=" => 11,
		"|=" => 11,
		"=" => 11,

		";" => 12,

		_ => throw new NotImplementedException()
	};
}
