using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using WindowsFormsApp2;

namespace ConsoleApp19
{
    class Crypting
    {       
        private static char Q = 'Q';
        private static char q = 'q';
        private static char W = 'W';
        private static char w = 'w';
        private static char E = 'E';
        private static char e = 'e';
        private static char R = 'R';
        private static char r = 'r';
        private static char T = 'T';
        private static char t = 't';
        private static char Z = 'Z';
        private static char z = 'z';
        private static char U = 'U';
        private static char u = 'u';
        private static char I = 'I';
        private static char _i = 'i';
        private static char O = 'O';
        private static char o = 'o';
        private static char P = 'P';
        private static char p = 'p';
        private static char Ü = 'Ü';
        private static char ü = 'ü';
        private static char A = 'A';
        private static char a = 'a';
        private static char S = 'S';
        private static char s = 's';
        private static char D = 'D';
        private static char d = 'd';
        private static char F = 'F';
        private static char f = 'f';
        private static char G = 'G';
        private static char g = 'g';
        private static char H = 'H';
        private static char h = 'h';
        private static char J = 'J';
        private static char j = 'j';
        private static char K = 'K';
        private static char k = 'k';
        private static char L = 'L';
        private static char l = 'l';
        private static char Ö = 'Ö';
        private static char ö = 'ö';
        private static char Ä = 'Ä';
        private static char ä = 'ä';
        private static char Y = 'Y';
        private static char y = 'y';
        private static char X = 'X';
        private static char x = 'x';
        private static char C = 'C';
        private static char c = 'c';
        private static char V = 'V';
        private static char v = 'v';
        private static char B = 'B';
        private static char b = 'b';
        private static char N = 'N';
        private static char n = 'n';
        private static char M = 'M';
        private static char m = 'm';
        
        private static List<string> todos = Form1.TodosSave;
        private static List<string> todos2 = Form1.TodosLoad;
        private static string smt;
        private static string smt2;
        private static int cou;

        public static void encrypt()
        {
            smt = string.Join("\n", todos.ToArray());
            cou = smt.Length;
            if (smt.Contains(Q))
            {
                for (int i = 1; i < cou; i++)
                {
                    smt = smt.Replace(Q, '1');
                }
            }
            if (smt.Contains(q))
            {
                for (int i = 1; i < cou; i++)
                {
                    smt = smt.Replace(q, '1');
                }
            }
            if (smt.Contains(W))
            {
                for (int i = 1; i < cou; i++)
                {
                    smt = smt.Replace(W, '2');
                }
            }
            if (smt.Contains(w))
            {
                for (int i = 1; i < cou; i++)
                {
                    smt = smt.Replace(w, '2');
                }
            }
            if (smt.Contains(E))
            {
                for (int i = 1; i < cou; i++)
                {
                    smt = smt.Replace(E, '3');
                }
            }
            if (smt.Contains(e))
            {
                for (int i = 1; i < cou; i++)
                {
                    smt = smt.Replace(e, '3');
                }
            }
            if (smt.Contains(R))
            {
                for (int i = 1; i < cou; i++)
                {
                    smt = smt.Replace(R, '4');
                }
            }
            if (smt.Contains(r))
            {
                for (int i = 1; i < cou; i++)
                {
                    smt = smt.Replace(r, '4');
                }
            }
            if (smt.Contains(T))
            {
                for (int i = 1; i < cou; i++)
                {
                    smt = smt.Replace(T, '5');
                }
            }
            if (smt.Contains(t))
            {
                for (int i = 1; i < cou; i++)
                {
                    smt = smt.Replace(t, '5');
                }
            }
            if (smt.Contains(Z))
            {
                for (int i = 1; i < cou; i++)
                {
                    smt = smt.Replace(Z, '6');
                }
            }
            if (smt.Contains(z))
            {
                for (int i = 1; i < cou; i++)
                {
                    smt = smt.Replace(z, '6');
                }
            }
            if (smt.Contains(U))
            {
                for (int i = 1; i < cou; i++)
                {
                    smt = smt.Replace(U, '7');
                }
            }
            if (smt.Contains(u))
            {
                for (int i = 1; i < cou; i++)
                {
                    smt = smt.Replace(u, '7');
                }
            }
            if (smt.Contains(I))
            {
                for (int i = 1; i < cou; i++)
                {
                    smt = smt.Replace(I, '8');
                }
            }
            if (smt.Contains(_i))
            {
                for (int i = 1; i < cou; i++)
                {
                    smt = smt.Replace(_i, '8');
                }
            }
            if (smt.Contains(O))
            {
                for (int i = 1; i < cou; i++)
                {
                    smt = smt.Replace(O, '9');
                }
            }
            if (smt.Contains(o))
            {
                for (int i = 1; i < cou; i++)
                {
                    smt = smt.Replace(o, '9');
                }
            }
            if (smt.Contains(P))
            {
                for (int i = 1; i < cou; i++)
                {
                    smt = smt.Replace(P, '0');
                }
            }
            if (smt.Contains(p))
            {
                for (int i = 1; i < cou; i++)
                {
                    smt = smt.Replace(p, '0');
                }
            }
            if (smt.Contains(Ü))
            {
                for (int i = 1; i < cou; i++)
                {
                    smt = smt.Replace(Ü, '°');
                }
            }
            if (smt.Contains(ü))
            {
                for (int i = 1; i < cou; i++)
                {
                    smt = smt.Replace(ü, '°');
                }
            }
            if (smt.Contains(A))
            {
                for (int i = 1; i < cou; i++)
                {
                    smt = smt.Replace(A, '!');
                }
            }
            if (smt.Contains(a))
            {
                for (int i = 1; i < cou; i++)
                {
                    smt = smt.Replace(a, '!');
                }
            }
            if (smt.Contains(S))
            {
                for (int i = 1; i < cou; i++)
                {
                    smt = smt.Replace(S, '"');
                }
            }
            if (smt.Contains(s))
            {
                for (int i = 1; i < cou; i++)
                {
                    smt = smt.Replace(s, '"');
                }
            }
            if (smt.Contains(D))
            {
                for (int i = 1; i < cou; i++)
                {
                    smt = smt.Replace(D, '§');
                }
            }
            if (smt.Contains(d))
            {
                for (int i = 1; i < cou; i++)
                {
                    smt = smt.Replace(d, '§');
                }
            }
            if (smt.Contains(F))
            {
                for (int i = 1; i < cou; i++)
                {
                    smt = smt.Replace(F, '$');
                }
            }
            if (smt.Contains(f))
            {
                for (int i = 1; i < cou; i++)
                {
                    smt = smt.Replace(f, '$');
                }
            }
            if (smt.Contains(G))
            {
                for (int i = 1; i < cou; i++)
                {
                    smt = smt.Replace(G, '%');
                }
            }
            if (smt.Contains(g))
            {
                for (int i = 1; i < cou; i++)
                {
                    smt = smt.Replace(g, '%');
                }
            }
            if (smt.Contains(H))
            {
                for (int i = 1; i < cou; i++)
                {
                    smt = smt.Replace(H, '&');
                }
            }
            if (smt.Contains(h))
            {
                for (int i = 1; i < cou; i++)
                {
                    smt = smt.Replace(h, '&');
                }
            }
            if (smt.Contains(J))
            {
                for (int i = 1; i < cou; i++)
                {
                    smt = smt.Replace(J, '/');
                }
            }
            if (smt.Contains(j))
            {
                for (int i = 1; i < cou; i++)
                {
                    smt = smt.Replace(j, '/');
                }
            }
            if (smt.Contains(K))
            {
                for (int i = 1; i < cou; i++)
                {
                    smt = smt.Replace(K, '(');
                }
            }
            if (smt.Contains(k))
            {
                for (int i = 1; i < cou; i++)
                {
                    smt = smt.Replace(k, '(');
                }
            }
            if (smt.Contains(L))
            {
                for (int i = 1; i < cou; i++)
                {
                    smt = smt.Replace(L, ')');
                }
            }
            if (smt.Contains(l))
            {
                for (int i = 1; i < cou; i++)
                {
                    smt = smt.Replace(l, ')');
                }
            }
            if (smt.Contains(Ö))
            {
                for (int i = 1; i < cou; i++)
                {
                    smt = smt.Replace(Ö, '=');
                }
            }
            if (smt.Contains(ö))
            {
                for (int i = 1; i < cou; i++)
                {
                    smt = smt.Replace(ö, '=');
                }
            }
            if (smt.Contains(Ä))
            {
                for (int i = 1; i < cou; i++)
                {
                    smt = smt.Replace(Ä, '?');
                }
            }
            if (smt.Contains(ä))
            {
                for (int i = 1; i < cou; i++)
                {
                    smt = smt.Replace(ä, '?');
                }
            }
            if (smt.Contains(Y))
            {
                for (int i = 1; i < cou; i++)
                {
                    smt = smt.Replace(Y, '`');
                }
            }
            if (smt.Contains(y))
            {
                for (int i = 1; i < cou; i++)
                {
                    smt = smt.Replace(y, '`');
                }
            }
            if (smt.Contains(X))
            {
                for (int i = 1; i < cou; i++)
                {
                    smt = smt.Replace(X, '*');
                }
            }
            if (smt.Contains(x))
            {
                for (int i = 1; i < cou; i++)
                {
                    smt = smt.Replace(x, '*');
                }
            }
            if (smt.Contains(C))
            {
                for (int i = 1; i < cou; i++)
                {
                    smt = smt.Replace(C, '#');
                }
            }
            if (smt.Contains(c))
            {
                for (int i = 1; i < cou; i++)
                {
                    smt = smt.Replace(c, '#');
                }
            }
            if (smt.Contains(V))
            {
                for (int i = 1; i < cou; i++)
                {
                    smt = smt.Replace(V, '<');
                }
            }
            if (smt.Contains(v))
            {
                for (int i = 1; i < cou; i++)
                {
                    smt = smt.Replace(v, '<');
                }
            }
            if (smt.Contains(B))
            {
                for (int i = 1; i < cou; i++)
                {
                    smt = smt.Replace(B, '>');
                }
            }
            if (smt.Contains(b))
            {
                for (int i = 1; i < cou; i++)
                {
                    smt = smt.Replace(b, '>');
                }
            }
            if (smt.Contains(N))
            {
                for (int i = 1; i < cou; i++)
                {
                    smt = smt.Replace(N, '_');
                }
            }
            if (smt.Contains(n))
            {
                for (int i = 1; i < cou; i++)
                {
                    smt = smt.Replace(n, '_');
                }
            }
            if (smt.Contains(M))
            {
                for (int i = 1; i < cou; i++)
                {
                    smt = smt.Replace(M, '-');
                }
            }
            if (smt.Contains(m))
            {
                for (int i = 1; i < cou; i++)
                {
                    smt = smt.Replace(m, '-');
                }
            }
            File.WriteAllText("todos.tds", string.Empty);
            File.WriteAllText("todos.tds", smt);
        }

        //.................................................................................................................................
        public static string decrypt()
        {
            smt2 = string.Join("\n", todos2);
            cou = smt2.Length;
            if (smt2.Contains('1'))//Q
            {
                for (int i = 1; i < cou; i++)
                {
                    smt2 = smt2.Replace('1', Q);
                }
            }
            if (smt2.Contains('2'))//W
            {
                for (int i = 1; i < cou; i++)
                {
                    smt2 = smt2.Replace('2', W);
                }
            }
            if (smt2.Contains('3'))//E
            {
                for (int i = 1; i < cou; i++)
                {
                    smt2 = smt2.Replace('3', E);
                }
            }
            if (smt2.Contains('4'))//R
            {
                for (int i = 1; i < cou; i++)
                {
                    smt2 = smt2.Replace('4', R);
                }
            }
            if (smt2.Contains('5'))//T
            {
                for (int i = 1; i < cou; i++)
                {
                    smt2 = smt2.Replace('5', T);
                }
            }
            if (smt2.Contains('6'))//Z
            {
                for (int i = 1; i < cou; i++)
                {
                    smt2 = smt2.Replace('6', Z);
                }
            }
            if (smt2.Contains('7'))//U
            {
                for (int i = 1; i < cou; i++)
                {
                    smt2 = smt2.Replace('7', U);
                }
            }
            if (smt2.Contains('8'))//I
            {
                for (int i = 1; i < cou; i++)
                {
                    smt2 = smt2.Replace('8', I);
                }
            }
            if (smt2.Contains('9'))//O
            {
                for (int i = 1; i < cou; i++)
                {
                    smt2 = smt2.Replace('9', O);
                }
            }
            if (smt2.Contains('0'))//P
            {
                for (int i = 1; i < cou; i++)
                {
                    smt2 = smt2.Replace('0', P);
                }
            }
            if (smt2.Contains('°'))//Ü
            {
                for (int i = 1; i < cou; i++)
                {
                    smt2 = smt2.Replace('°', Ü);
                }
            }
            if (smt2.Contains('!'))//A
            {
                for (int i = 1; i < cou; i++)
                {
                    smt2 = smt2.Replace('!', A);
                }
            }
            if (smt2.Contains('"'))//S
            {
                for (int i = 1; i < cou; i++)
                {
                    smt2 = smt2.Replace('"', S);
                }
            }
            if (smt2.Contains('§'))//D
            {
                for (int i = 1; i < cou; i++)
                {
                    smt2 = smt2.Replace('§', D);
                }
            }
            if (smt2.Contains('$'))//F
            {
                for (int i = 1; i < cou; i++)
                {
                    smt2 = smt2.Replace('$', F);
                }
            }
            if (smt2.Contains('%'))//G
            {
                for (int i = 1; i < cou; i++)
                {
                    smt2 = smt2.Replace('%', G);
                }
            }
            if (smt2.Contains('&'))//H
            {
                for (int i = 1; i < cou; i++)
                {
                    smt2 = smt2.Replace('&', H);
                }
            }
            if (smt2.Contains('/'))//J
            {
                for (int i = 1; i < cou; i++)
                {
                    smt2 = smt2.Replace('/', J);
                }
            }
            if (smt2.Contains('('))//K
            {
                for (int i = 1; i < cou; i++)
                {
                    smt2 = smt2.Replace('(', K);
                }
            }
            if (smt2.Contains(')'))//L
            {
                for (int i = 1; i < cou; i++)
                {
                    smt2 = smt2.Replace(')', L);
                }
            }
            if (smt2.Contains('='))//Ö
            {
                for (int i = 1; i < cou; i++)
                {
                    smt2 = smt2.Replace('=', Ö);
                }
            }
            if (smt2.Contains('?'))//Ä
            {
                for (int i = 1; i < cou; i++)
                {
                    smt2 = smt2.Replace('?', Ä);
                }
            }
            if (smt2.Contains('`'))//Y
            {
                for (int i = 1; i < cou; i++)
                {
                    smt2 = smt2.Replace('`', Y);
                }
            }
            if (smt2.Contains('*'))//X
            {
                for (int i = 1; i < cou; i++)
                {
                    smt2 = smt2.Replace('*', X);
                }
            }
            if (smt2.Contains('#'))//C
            {
                for (int i = 1; i < cou; i++)
                {
                    smt2 = smt2.Replace('#', C);
                }
            }
            if (smt2.Contains('<'))//V
            {
                for (int i = 1; i < cou; i++)
                {
                    smt2 = smt2.Replace('<', V);
                }
            }
            if (smt2.Contains('>'))//B
            {
                for (int i = 1; i < cou; i++)
                {
                    smt2 = smt2.Replace('>', B);
                }
            }
            if (smt2.Contains('_'))//N
            {
                for (int i = 1; i < cou; i++)
                {
                    smt2 = smt2.Replace('_', N);
                }
            }
            if (smt2.Contains('-'))//M
            {
                for (int i = 1; i < cou; i++)
                {
                    smt2 = smt2.Replace('-', M);
                }
            }
            Form1.TodosLoad.Clear();
            return smt2;
        }
    }
}
