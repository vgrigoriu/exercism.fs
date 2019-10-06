module GradeSchool

type School = Map<int, string list>

let rec private addSorted (student: string) (students: string list): string list =
    match students with
    | [] -> [student]
    | head::tail when student < head -> student :: students
    | head::tail -> head :: (addSorted student tail)

let empty: School = Map.empty

let add (student: string) (grade: int) (school: School): School =
    let students = school.TryFind(grade) |> Option.defaultValue []
    let newStudents = addSorted student students
    Map.add grade newStudents school

let roster (school: School): string list =
    school |> Seq.collect (fun kv -> kv.Value) |> List.ofSeq

let grade (number: int) (school: School): string list = failwith "You need to implement this function."
