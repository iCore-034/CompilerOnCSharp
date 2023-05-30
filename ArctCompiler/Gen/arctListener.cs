//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.12.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:/Users/Redmi/Documents/Programming/C#/CourseCompiler/ArctCompiler\arct.g4 by ANTLR 4.12.0

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="arctParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.12.0")]
[System.CLSCompliant(false)]
public interface IarctListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="arctParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProgram([NotNull] arctParser.ProgramContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="arctParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProgram([NotNull] arctParser.ProgramContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="arctParser.function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunction([NotNull] arctParser.FunctionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="arctParser.function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunction([NotNull] arctParser.FunctionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="arctParser.functionHead"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionHead([NotNull] arctParser.FunctionHeadContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="arctParser.functionHead"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionHead([NotNull] arctParser.FunctionHeadContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="arctParser.arg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArg([NotNull] arctParser.ArgContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="arctParser.arg"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArg([NotNull] arctParser.ArgContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="arctParser.arguments"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArguments([NotNull] arctParser.ArgumentsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="arctParser.arguments"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArguments([NotNull] arctParser.ArgumentsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="arctParser.functionBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionBody([NotNull] arctParser.FunctionBodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="arctParser.functionBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionBody([NotNull] arctParser.FunctionBodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="arctParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatement([NotNull] arctParser.StatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="arctParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatement([NotNull] arctParser.StatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="arctParser.assignmentStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignmentStatement([NotNull] arctParser.AssignmentStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="arctParser.assignmentStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignmentStatement([NotNull] arctParser.AssignmentStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="arctParser.returnStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReturnStatement([NotNull] arctParser.ReturnStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="arctParser.returnStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReturnStatement([NotNull] arctParser.ReturnStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="arctParser.whileStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhileStatement([NotNull] arctParser.WhileStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="arctParser.whileStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhileStatement([NotNull] arctParser.WhileStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="arctParser.convert_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConvert_type([NotNull] arctParser.Convert_typeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="arctParser.convert_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConvert_type([NotNull] arctParser.Convert_typeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="arctParser.moveValueVariable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMoveValueVariable([NotNull] arctParser.MoveValueVariableContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="arctParser.moveValueVariable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMoveValueVariable([NotNull] arctParser.MoveValueVariableContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="arctParser.printStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrintStatement([NotNull] arctParser.PrintStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="arctParser.printStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrintStatement([NotNull] arctParser.PrintStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="arctParser.ifStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIfStatement([NotNull] arctParser.IfStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="arctParser.ifStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIfStatement([NotNull] arctParser.IfStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>expressionAdd</c>
	/// labeled alternative in <see cref="arctParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpressionAdd([NotNull] arctParser.ExpressionAddContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>expressionAdd</c>
	/// labeled alternative in <see cref="arctParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpressionAdd([NotNull] arctParser.ExpressionAddContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>expressionMul</c>
	/// labeled alternative in <see cref="arctParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpressionMul([NotNull] arctParser.ExpressionMulContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>expressionMul</c>
	/// labeled alternative in <see cref="arctParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpressionMul([NotNull] arctParser.ExpressionMulContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>expressionNumber</c>
	/// labeled alternative in <see cref="arctParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpressionNumber([NotNull] arctParser.ExpressionNumberContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>expressionNumber</c>
	/// labeled alternative in <see cref="arctParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpressionNumber([NotNull] arctParser.ExpressionNumberContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>expressionFunctionCall</c>
	/// labeled alternative in <see cref="arctParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpressionFunctionCall([NotNull] arctParser.ExpressionFunctionCallContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>expressionFunctionCall</c>
	/// labeled alternative in <see cref="arctParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpressionFunctionCall([NotNull] arctParser.ExpressionFunctionCallContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>expressionNested</c>
	/// labeled alternative in <see cref="arctParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpressionNested([NotNull] arctParser.ExpressionNestedContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>expressionNested</c>
	/// labeled alternative in <see cref="arctParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpressionNested([NotNull] arctParser.ExpressionNestedContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>expressionToType</c>
	/// labeled alternative in <see cref="arctParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpressionToType([NotNull] arctParser.ExpressionToTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>expressionToType</c>
	/// labeled alternative in <see cref="arctParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpressionToType([NotNull] arctParser.ExpressionToTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>expressionPow</c>
	/// labeled alternative in <see cref="arctParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpressionPow([NotNull] arctParser.ExpressionPowContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>expressionPow</c>
	/// labeled alternative in <see cref="arctParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpressionPow([NotNull] arctParser.ExpressionPowContext context);
	/// <summary>
	/// Enter a parse tree produced by the <c>expressionString</c>
	/// labeled alternative in <see cref="arctParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpressionString([NotNull] arctParser.ExpressionStringContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>expressionString</c>
	/// labeled alternative in <see cref="arctParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpressionString([NotNull] arctParser.ExpressionStringContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="arctParser.equation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEquation([NotNull] arctParser.EquationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="arctParser.equation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEquation([NotNull] arctParser.EquationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="arctParser.relop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRelop([NotNull] arctParser.RelopContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="arctParser.relop"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRelop([NotNull] arctParser.RelopContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="arctParser.param"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParam([NotNull] arctParser.ParamContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="arctParser.param"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParam([NotNull] arctParser.ParamContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="arctParser.params"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParams([NotNull] arctParser.ParamsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="arctParser.params"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParams([NotNull] arctParser.ParamsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="arctParser.functionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionCall([NotNull] arctParser.FunctionCallContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="arctParser.functionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionCall([NotNull] arctParser.FunctionCallContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="arctParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAtom([NotNull] arctParser.AtomContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="arctParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAtom([NotNull] arctParser.AtomContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="arctParser.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterType([NotNull] arctParser.TypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="arctParser.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitType([NotNull] arctParser.TypeContext context);
}
