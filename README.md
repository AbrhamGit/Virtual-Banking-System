# Virtual Banking System (VBS)

This project is a C# desktop application designed to manage banking operations efficiently. It allows users to create accounts, request credit, and handle transactions through an intuitive interface. The system includes both admin and user functionality to facilitate a seamless banking experience.

### Note:
The full project, including all dependencies and resources, is not uploaded due to its large size. Instead, this repository contains:
- **Source Code**: The main application code.
- **Screenshots**: A folder with images showcasing the application's interface and functionality.
- **Demo Video**: A video demonstrating the application in action. Watch it on YouTube.

## User Roles and Features

### Admin
- **Manage Users**: Admin can add, search, and delete user records (clients).
- **Manage Transactions**: Admin can view and approve credit requests, as well as monitor all transactions.

### Client (User)
- **Account Creation**: Users can register by entering personal details like name, ID, phone number, and more.
- **Credit Requests**: Users can apply for credit, and admins can approve or deny requests.
- **Account Management**: Users can view their personal information and transaction history.

## Features

### **SignUp**
The **SignUp** form allows new clients to register for a banking account. It includes:
- **Data Validation**: Ensures that all fields are filled and match the provided ID details.
- **Profile Picture**: Clients can upload a profile picture during registration.
- **Unique Username Check**: Verifies that the username entered is not already taken.
- **Account Creation**: Upon successful registration, the system stores the user’s details in the database and initializes their account status as "Unblocked."
- **Transaction History**: Logs the account creation as a transaction.

### **CreditResponse**
The **CreditResponse** form processes credit requests:
- **Credit Approval**: Admins can approve credit requests, which updates the user’s balance and debt status.
- **Credit Denial**: If denied, the request is logged, and the record is removed from the database.
- **Transaction Logging**: Every credit decision (approval or denial) is logged in the system’s transaction history.

## Database Structure
The system utilizes **SQLite** to store and manage data. The database contains the following main tables:
- **VBSUsers**: Stores user details including first name, last name, username, bank account, phone number, and profile information.
- **AccountStatus**: Stores account status (e.g., "Unblocked").
- **TransactionHistory**: Logs all transactions made by users, including account creation, credit approvals, etc.
- **clients**: Stores basic client information such as clientID, clientFirstName, and bank-related details.

## Technologies Used
- **Programming Language**: C#
- **Database**: SQLite

## Installation

1. Clone the repository to your local machine.
2. Open the project in Visual Studio.
3. Build the solution and run the application.

###License

This project is licensed under the [License](LICENSE) - see the LICENSE file for details.

###Acknowledgments

Developed by **Abrham Ayana**. The project idea and most of the development work, including the Windows Forms interface and the subsequent console version, were initiated and implemented by **Abrham Ayana**.
Inspired by the need to digitize manual record-keeping processes in schools.

