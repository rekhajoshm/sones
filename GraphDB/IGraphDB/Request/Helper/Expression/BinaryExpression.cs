﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using sones.GraphDB.Request.Helper.Operator;

namespace sones.GraphDB.Request.Helper.Expression
{
    /// <summary>
    /// A binary expression consists of two Expressions and a binary operator
    /// </summary>
    public sealed class BinaryExpression : IExpression
    {
        #region data

        /// <summary>
        /// The left side of the BinaryExpression
        /// </summary>
        public readonly IExpression Left;

        /// <summary>
        /// The binary operator
        /// </summary>
        public readonly IBinaryOperator Operator;

        /// <summary>
        /// The right side of the BinaryExpression
        /// </summary>
        public readonly IExpression Right;

        #endregion

        #region Constructor

        /// <summary>
        /// Creates a new binary expression
        /// </summary>
        /// <param name="myLeftExpression">The left side of the BinaryExpression</param>
        /// <param name="myBinaryOperator">The binary operator</param>
        /// <param name="myRightExpression">The right side of the BinaryExpression</param>
        public BinaryExpression (IExpression myLeftExpression, IBinaryOperator myBinaryOperator, IExpression myRightExpression)
        {
            Left = myLeftExpression;
            Right = myRightExpression;
            Operator = myBinaryOperator;
        }

        #endregion
    }
}