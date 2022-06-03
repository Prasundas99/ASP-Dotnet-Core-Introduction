/**
 * Writing an application in JSON and discovering its different features
 */
const employee = []

employee.push({
    name: 'John',
    age: 30,
    salary: 1000,
    position: 'Manager',
    "id": 1
})

const ahmed = {
    "name": "Ahmed",
    "age": 30,
    "salary": 1001,
    "position": "Director",
    "id": 2
}

employee.push(ahmed)

employee.push({
    name: 'Jit',
    age: 20,
    salary: 2000,
    position: 'Developer',
    "id": 3
})

console.log(JSON.stringify(employee, null, 2));