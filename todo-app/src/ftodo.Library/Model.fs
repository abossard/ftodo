module ftodo.Client.Model

type TemporaryTodo = {
    name: string
}

type TodoName = TodoName of string

let createTodoName (s:string) = 
    if s.Length > 0 
        then Some (TodoName s)
        else None

type Todo = {
    name: string
}