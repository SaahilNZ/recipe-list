$(document).ready(function () {
    $('.sortable').sortable({
        placeholderClass: 'list-group-item',
        handle: '.handle'
    });
});

function addItemToListGroup(textBoxId, listId, propertyName) {
    let textBox = $(textBoxId);
    let itemList = $(listId);

    let textBoxValue = textBox.val();
    if (textBoxValue != "" ) {
        let item = document.createElement("li");
        item.className = "list-group-item container";
        item.draggable = true;
        
        let row = document.createElement("div");
        row.className = "row";

        let handleContainer = document.createElement("div");
        handleContainer.className = "col-sm-auto handle-container";
        
        let handle = document.createElement("div");
        handle.className = "fas fa-bars handle";
        handleContainer.appendChild(handle);

        let textContainer = document.createElement("div");
        textContainer.className = "col-sm-auto text-container";
        
        let text = document.createElement("span");
        text.className = "list-text";
        text.innerText = textBoxValue;
        textContainer.appendChild(text);

        let inputElement = document.createElement("input");
        inputElement.name = propertyName;
        inputElement.type = "hidden";
        inputElement.value = textBoxValue;

        let deleteContainer = document.createElement("div");
        deleteContainer.className = "col-sm-auto delete-container";

        let deleteButton = document.createElement("div");
        deleteButton.className = "float-right list-icon far fa-trash-alt";
        deleteButton.addEventListener("click", function () {
            removeItem(this);
        });
        deleteContainer.appendChild(deleteButton);

        row.appendChild(handleContainer);
        row.appendChild(textContainer);
        row.appendChild(deleteContainer);
        item.appendChild(row);
        item.appendChild(inputElement);
    
        itemList.append(item);

        $('.sortable').sortable({
            placeholderClass: 'list-group-item',
            handle: '.handle'
        });
    }
}

function addIngredient() {
    addItemToListGroup("#tbIngredient", "#lstIngredients", "ingredients");
}

function addMethodStep() {
    addItemToListGroup("#tbMethodStep", "#lstMethod", "method");
}

function removeItem(button, onItemRemoved) {
    button.parentNode.parentNode.parentNode.remove();
}