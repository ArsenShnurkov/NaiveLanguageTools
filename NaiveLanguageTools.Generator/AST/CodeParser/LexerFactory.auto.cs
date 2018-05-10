/* --------------------------------------------------------------------------
THIS FILE WAS AUTOMATICALLY GENERATED BY NLT SUITE FROM "NaiveLanguageTools.Generator/AST/CodeParser/Syntax.nlg" FILE
-------------------------------------------------------------------------- */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NaiveLanguageTools.Common;
using NaiveLanguageTools.Parser;
using NaiveLanguageTools.Parser.Automaton;
using NaiveLanguageTools.Parser.Symbols;
using NaiveLanguageTools.Lexer;
using NaiveLanguageTools.MultiRegex.Dfa;

namespace NaiveLanguageTools.Generator.AST.CodeParser
{
public enum StateEnum
{
INIT
}
public partial class LexerFactory
{

public NaiveLanguageTools.Lexer.Lexer<SymbolEnum,StateEnum> CreateLexer()
{
var symbols_rep = StringRep.Create(Tuple.Create(SymbolEnum.Error,"Error"),
Tuple.Create(SymbolEnum.EOF,"EOF"),
Tuple.Create(SymbolEnum.LANGLE,"LANGLE"),
Tuple.Create(SymbolEnum.RANGLE,"RANGLE"),
Tuple.Create(SymbolEnum.LBRACKET,"LBRACKET"),
Tuple.Create(SymbolEnum.RBRACKET,"RBRACKET"),
Tuple.Create(SymbolEnum.DOT,"DOT"),
Tuple.Create(SymbolEnum.COMMA,"COMMA"),
Tuple.Create(SymbolEnum.NEW,"NEW"),
Tuple.Create(SymbolEnum.IDENTIFIER,"IDENTIFIER"),
Tuple.Create(SymbolEnum.WHATEVER,"WHATEVER"),
Tuple.Create(SymbolEnum.s,"s"),
Tuple.Create(SymbolEnum.array,"array"),
Tuple.Create(SymbolEnum.jagged_array,"jagged_array"),
Tuple.Create(SymbolEnum.dot_identifier,"dot_identifier"),
Tuple.Create(SymbolEnum.typename_list,"typename_list"),
Tuple.Create(SymbolEnum.typename,"typename"),
Tuple.Create(SymbolEnum.whatever,"whatever"),
Tuple.Create(SymbolEnum.__list___merged_array_c____,"__list___merged_array_c____"),
Tuple.Create(SymbolEnum.__optList___merged_array_c____,"__optList___merged_array_c____"),
Tuple.Create(SymbolEnum.__list___merged_jagged_array_a____,"__list___merged_jagged_array_a____"),
Tuple.Create(SymbolEnum.__list___merged_dot_identifier_id____,"__list___merged_dot_identifier_id____"),
Tuple.Create(SymbolEnum.__list___merged_typename_list_t____,"__list___merged_typename_list_t____"),
Tuple.Create(SymbolEnum.__list_s__,"__list_s__"),
Tuple.Create(SymbolEnum.__optList_s__,"__optList_s__"));
var states_rep = StringRep.Create(Tuple.Create(StateEnum.INIT,"INIT"));
var mre = new DfaTable(ConnectionTable.Create(0,new int []{4,4,4,4,4,4,4,4,4,5,13,4,4,5,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,5,4,4,4,4,4,4,4,4,4,4,4,6,4,7,4,4,4,4,4,4,4,4,4,4,4,4,4,1,4,8,4,4,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,9,10,4,11,4,9,4,9,9,9,9,9,9,9,9,9,9,9,9,9,12,9,9,9,9,9,9,9,9,9,9,9,9,4,4,4,4,4,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2}), //0
ConnectionTable.Create(-1,new int []{},Tuple.Create(0,false),Tuple.Create(9,false)), //1
ConnectionTable.Create(160,new int []{3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3}), //2
ConnectionTable.Create(128,new int []{4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4,4}), //3
ConnectionTable.Create(-1,new int []{},Tuple.Create(9,false)), //4
ConnectionTable.Create(9,new int []{13,13,-1,-1,13,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,13},Tuple.Create(7,false),Tuple.Create(9,false)), //5
ConnectionTable.Create(-1,new int []{},Tuple.Create(5,false),Tuple.Create(9,false)), //6
ConnectionTable.Create(-1,new int []{},Tuple.Create(4,false),Tuple.Create(9,false)), //7
ConnectionTable.Create(-1,new int []{},Tuple.Create(1,false),Tuple.Create(9,false)), //8
ConnectionTable.Create(48,new int []{14,14,14,14,14,14,14,14,14,14,-1,-1,-1,-1,-1,-1,-1,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,-1,-1,-1,-1,14,-1,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14},Tuple.Create(8,false),Tuple.Create(9,false)), //9
ConnectionTable.Create(-1,new int []{},Tuple.Create(2,false),Tuple.Create(9,false)), //10
ConnectionTable.Create(-1,new int []{},Tuple.Create(3,false),Tuple.Create(9,false)), //11
ConnectionTable.Create(48,new int []{14,14,14,14,14,14,14,14,14,14,-1,-1,-1,-1,-1,-1,-1,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,-1,-1,-1,-1,14,-1,14,14,14,14,15,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14},Tuple.Create(8,false),Tuple.Create(9,false)), //12
ConnectionTable.Create(9,new int []{13,13,-1,-1,13,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,13},Tuple.Create(7,false)), //13
ConnectionTable.Create(48,new int []{14,14,14,14,14,14,14,14,14,14,-1,-1,-1,-1,-1,-1,-1,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,-1,-1,-1,-1,14,-1,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14},Tuple.Create(8,false)), //14
ConnectionTable.Create(48,new int []{14,14,14,14,14,14,14,14,14,14,-1,-1,-1,-1,-1,-1,-1,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,-1,-1,-1,-1,14,-1,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,16,14,14,14},Tuple.Create(8,false)), //15
ConnectionTable.Create(48,new int []{14,14,14,14,14,14,14,14,14,14,-1,-1,-1,-1,-1,-1,-1,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,-1,-1,-1,-1,14,-1,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14,14},Tuple.Create(6,false),Tuple.Create(8,false))); //16
var lexer = new NaiveLanguageTools.Lexer.Lexer<SymbolEnum,StateEnum>(symbols_rep,states_rep,StateEnum.INIT,SymbolEnum.EOF,SymbolEnum.Error,mre);
lexer.AddIdRule(0,"\""+"<"+"\"",StringCaseComparison.Sensitive,SymbolEnum.LANGLE,StateEnum.INIT);
lexer.AddIdRule(1,"\""+">"+"\"",StringCaseComparison.Sensitive,SymbolEnum.RANGLE,StateEnum.INIT);
lexer.AddIdRule(2,"\""+"["+"\"",StringCaseComparison.Sensitive,SymbolEnum.LBRACKET,StateEnum.INIT);
lexer.AddIdRule(3,"\""+"]"+"\"",StringCaseComparison.Sensitive,SymbolEnum.RBRACKET,StateEnum.INIT);
lexer.AddIdRule(4,"\""+"."+"\"",StringCaseComparison.Sensitive,SymbolEnum.DOT,StateEnum.INIT);
lexer.AddIdRule(5,"\""+","+"\"",StringCaseComparison.Sensitive,SymbolEnum.COMMA,StateEnum.INIT);
lexer.AddIdRule(6,"\""+"new"+"\"",StringCaseComparison.Sensitive,SymbolEnum.NEW,StateEnum.INIT);
lexer.AddIdAction(7,"/"+@"[ \r\n\t]+"+"/",StringCaseComparison.Sensitive,match => {},StateEnum.INIT);
lexer.AddIdRule(8,"/"+@"[A-Za-z_][A-Za-z_0-9]*"+"/",StringCaseComparison.Sensitive,SymbolEnum.IDENTIFIER,StateEnum.INIT);
lexer.AddIdRule(9,"/"+@"."+"/",StringCaseComparison.Sensitive,SymbolEnum.WHATEVER,StateEnum.INIT);
return lexer;
}
}
}
