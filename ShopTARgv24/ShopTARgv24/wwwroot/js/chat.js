// create connection
var connectionChat = new signalR.HubConnectionBuilder().withUrl("/hubs/chat").build();

// connect to methods that hub invokes aka receive notifications from hub
connectionChat.on("ReceiveMessage", (user, message) => {
    var messagesList = document.getElementById("messagesList");
    var li = document.createElement("li");
    li.textContent = `${user} says: ${message}`;
    messagesList.appendChild(li);
});

// invoke hub methods aka send notifications to hub
function sendMessageFromClient() {
    var user = document.getElementById("userInput").value;
    var message = document.getElementById("messageInput").value;
    if (user && message) {
        connectionChat.invoke("SendMessage", user, message);
        document.getElementById("messageInput").value = "";
    }
}

// start connection
function fulfilledChat() {
    // do something on start
    console.log("Connection to Chat Hub Successful");
    document.getElementById("sendButton").addEventListener("click", sendMessageFromClient);
}

function rejectedChat() {
    // rejected logs
    console.error("Connection to Chat Hub Failed");
}

connectionChat.start().then(fulfilledChat, rejectedChat);