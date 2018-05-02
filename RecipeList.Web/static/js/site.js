function addItemToListGroup(textBoxId, listId, propertyName) {
    let textBox = $(textBoxId);
    let itemList = $(listId);

    let textBoxValue = textBox.val();
    if (textBoxValue != "" ) {
        let item = document.createElement("li");
        item.className = "list-group-item";
        item.innerText = textBoxValue;
    
        let inputElement = document.createElement("input");
        inputElement.name = propertyName;
        inputElement.type = "hidden";
        inputElement.value = textBoxValue;

        let deleteButton = document.createElement("span");
        deleteButton.className = "float-right list-icon far fa-trash-alt";
        deleteButton.addEventListener("click", function () {
            removeItem(this);
        });
    
        item.appendChild(inputElement);
        item.appendChild(deleteButton);
    
        itemList.append(item);
    }
}

function addIngredient() {
    addItemToListGroup("#tbIngredient", "#lstIngredients", "ingredients");
}

function addMethodStep() {
    addItemToListGroup("#tbMethodStep", "#lstMethod", "method");
}

function removeItem(button, onItemRemoved) {
    button.parentNode.remove();
}