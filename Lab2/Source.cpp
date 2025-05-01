#include <iostream>
#include <vector>
#include <Windows.h>

using namespace std;

class LIST 
{
private:
    vector<int> Elements;  

public:

    void Append(int element) 
    {
        Elements.push_back(element);
    }

    int DeleteLast() 
    {
        if (!Elements.empty()) {
            int Last = Elements.back();
            Elements.pop_back();
            return Last;
        }
        
        
    }

    bool IsEmpty()  
    {
        return Elements.empty();
    }

    void Output() const 
    {
        for (int element : Elements) {
            cout << element << " ";
        }
        cout << "\n";
    }
};


class STACK 
{
private:
    LIST list;  

public:
    void AppendToStack(int element) 
    {
        list.Append(element);
    }

    int DeleteFromStack() 
    {
        return list.DeleteLast();
    }

    void IsEmtpy()
    {
        if (list.IsEmpty()) cout << "Стек пустий\n";
        else cout << "Стек наповнений\n";
    }

    void Output() const 
    {
        list.Output();
    }
};

int main() 
{
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);

    STACK Stack;

    Stack.AppendToStack(10);
    Stack.AppendToStack(-3);
    Stack.AppendToStack(77);

    Stack.Output();


    return 0;
}