function Book(title, author, year) {
    this.title = title;
    this.author = author;
    this.year = year;

    this.getSummary = function() {
        return this.title + " napisana przez "+this.author+" w "+this.year;
    };
}

const book1 = new Book("Pan Tadeusz", "Adam Mickiewicz", 1834);
const book2 = new Book("Lalka", "Bolesław Prus", 1890);

console.log(book1.getSummary());
console.log(book2.getSummary());
