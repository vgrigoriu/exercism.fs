module GradeSchool

type School = Map<int, string list>

let rec private addSorted (student: string) (students: string list): string list =
    match students with
    | [] -> [student]
    | head::tail when student < head -> student :: students
    | head::tail -> head :: (addSorted student tail)

let empty: School = Map.empty

let grade (number: int) (school: School): string list =
    school.TryFind(number) |> Option.defaultValue []

let add (student: string) (grade1: int) (school: School): School =
    let students = grade grade1 school
    let newStudents = addSorted student students
    Map.add grade1 newStudents school

let roster (school: School): string list =
    school
    |> Seq.collect (fun kv -> kv.Value)
    |> List.ofSeq
