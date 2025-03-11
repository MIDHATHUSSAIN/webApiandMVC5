// import axios from "./node_modules/axios/";




async function printtt() {
    let name = document.getElementById('name').value;
    let email = document.getElementById('email').value;
    let department = document.getElementById('department').value;

    try {
     
        console.log("JO");
        const response = await axios.post("http://localhost:44353/api/Employee2", {name,email,department});
        console.log(response);
        console.log("Success:", data);

    } catch (error) {
        console.error('Error:', error.message);
    }
}

async function getData(){

    try{

        const response = await axios.get("http://localhost:44353/api/Employee2",)
        let data = response.data
        var main = document.getElementById('main')
        data.forEach(d => {
            var name = document.createElement('p')
            name.textContent = d.name

            var email = document.createElement('p')
            email.textContent = d.email

            var department = document.createElement('p')
            department.textContent = d.department
              
            var Deletebutton = document.createElement('input')
            Deletebutton.value = "delete"
            Deletebutton.id = d.id
            Deletebutton.type = 'button'
            Deletebutton.onclick = () => deletee(d.id); 
           
            var Editbutton = document.createElement('input')
            Editbutton.value = "Edit"
            Editbutton.id = d.id
            Editbutton.type = 'button'
            Editbutton.onclick = () => Edit(d.id); 



            main.appendChild(name)
            main.appendChild(email)
            main.appendChild(department)
            main.appendChild(Deletebutton)
            main.appendChild(Editbutton)
        });
       
    }catch(error){
        console.error('Error:', error.message);
    }
}

async function deletee(id){
    try{
        console.log("i am delete")
       axios.delete(`http://localhost:44353/api/Employee2/${id}`)

    }catch(error){

        console.log(error.message)
    }
} 

function Edit(id) {

    var name = document.createElement('input')
    name.type = 'text'
    name.id = id+"a"

    var email = document.createElement('input')
    email.type = 'email'
    email.id = id+"b"

    var department = document.createElement('input')
    department.type = 'text'
    department.id = id+"c"

    var updateButton = document.createElement('input')
    updateButton.value = "update"
    updateButton.id = id
    updateButton.type = 'button'
    updateButton.onclick = () => updatee(id); 
    main.appendChild(name)
    main.appendChild(email)
    main.appendChild(department)
    main.appendChild(updateButton)

}

async function updatee (id){

    let name = document.getElementById(id+"a").value;
    let email = document.getElementById(id+"b").value;
    let department = document.getElementById(id+"c").value;
  console.log("hello i am from update"+name)
    try {
        
        axios.put(`http://localhost:44353/api/Employee2/${id}`,{name,email,department})

    } catch (error) {

        console.log(error.message)
    }

}



