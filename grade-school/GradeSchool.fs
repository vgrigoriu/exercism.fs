module GradeSchool

type School = Map<int, string list>

let empty: School = Map.empty

let add (student: string) (grade: int) (school: School): School =
    let students = school.TryFind(grade) |> Option.defaultValue []
    let newStudents = student :: students
    Map.add grade newStudents school

let roster (school: School): string list =
    school |> Seq.collect (fun kv -> kv.Value) |> List.ofSeq

let grade (number: int) (school: School): string list = failwith "You need to implement this function."
