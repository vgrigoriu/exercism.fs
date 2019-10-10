module GradeSchool

type School = Map<int, string list>

let empty: School = Map.empty

let grade (number: int) (school: School): string list =
    school.TryFind(number) |> Option.defaultValue []

let add (student: string) (grade1: int) (school: School): School =
    let students = grade grade1 school
    let newStudents = student :: students
    Map.add grade1 newStudents school

let roster (school: School): string list =
    school
    |> Seq.collect (fun kv -> kv.Value |> List.sort)
    |> List.ofSeq
