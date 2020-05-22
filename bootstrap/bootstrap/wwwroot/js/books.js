alert("Hi, I work, I'm part of books");

const bookList = document.getElementById("book-list");

for (const bookListItem of bookList.children) {

    const showBookBtn = bookListItem.getElementsByClassName('view-character-btn')[0];
    
    showBookBtn.addEventListener("click", (e) => {
        const cardDiv = e.target.parentElement;
        const showListElement = cardDiv.getElementsByClassName("hide-characters")[0];

        const displayStyle = showListElement.style.display;

        if (displayStyle === "" || displayStyle === "none") {
            showListElement.style.display = "block";

        } else {
            showListElement.style.display = "none";
        }
    })

    const characterList = bookListItem.getElementsByClassName('character-list')[0];

    for (const characterListItem of characterList.children) {
        
        characterListItem.addEventListener("click", async (e) => {
            const link = e.target.innerHTML;

            const data = await fetch(link)
                                .then(data => data.json());

            alert(JSON.stringify(data, undefined, 2));
        })
    }

}