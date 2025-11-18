function Reservation(guestName, roomNumber, checkInDate, nights) {
    this.guestName = guestName;
    this.roomNumber = roomNumber;
    this.checkInDate = checkInDate;
    this.nights = nights;
    this.totalCost = nights * 300;
    this.status = "confirmed";

    this.displayReservation = function() {
        console.log("Rezerwacja dla: " + this.guestName);
        console.log("Pokój: " + this.roomNumber);
        console.log("Data przyjazdu: " + this.checkInDate);
        console.log("Liczba nocy: " + this.nights);
        console.log("Koszt całkowity: " + this.totalCost + " zł");
        console.log("Status: " + this.status);
        console.log(" ");
    };

    this.cancel = function() {
        this.status = "cancelled";
        console.log("Rezerwacja dla " + this.guestName + " została anulowana.");
    };

    this.extend = function(additionalNights) {
        this.nights += additionalNights;
        this.totalCost = this.nights * 300;
        console.log("Przedłużono pobyt dla " + this.guestName + " o " + additionalNights + " nocy.");
    };
}

const reservation1 = new Reservation("Jan Kowalski", 101, "2025-11-20", 3);
const reservation2 = new Reservation("Anna Nowak", 202, "2025-11-22", 2);
const reservation3 = new Reservation("Piotr Wiśniewski", 303, "2025-11-25", 5);

reservation1.displayReservation();
reservation2.displayReservation();
reservation3.displayReservation();

reservation2.cancel();
reservation1.extend(2);
reservation1.displayReservation();

const wrongReservation = Reservation("Test User", 404, "2025-12-01", 1);
console.log("Wartość wrongReservation:", wrongReservation);
