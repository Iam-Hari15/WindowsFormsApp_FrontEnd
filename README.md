Sure! Here is the detailed README for the Visual Basic frontend application:

---

# SlidelyFormsApp

## Overview

SlidelyFormsApp is a Windows Forms application built using Visual Basic. It provides a user interface for submitting and viewing form submissions. The app integrates with a Node.js backend server to handle form submissions and retrieve stored data.

## Prerequisites

Before you begin, ensure you have the following software installed on your system:

- Visual Studio (with Visual Basic support)
- Node.js and npm (Node Package Manager)
- A running Node.js backend server (set up separately)

## Getting Started

### Step 1: Set Up the Visual Basic Project

1. **Create a New Project:**
   - Open Visual Studio.
   - Go to `File > New > Project`.
   - Select `Windows Forms App (.NET Framework)` under Visual Basic.
   - Name it `SlidelyFormsApp` and click `Create`.

### Step 2: Create the `CreateSubmissionForm`

1. **Add a New Form:**
   - Right-click on the project in Solution Explorer.
   - Select `Add > Windows Form...`.
   - Name it `CreateSubmissionForm.vb` and click `Add`.

2. **Design the Form:**
   - Add the following controls from the Toolbox:
     - TextBox for Name (`txtName`)
     - TextBox for Email (`txtEmail`)
     - TextBox for Phone Number (`txtPhone`)
     - TextBox for GitHub Link (`txtGithubLink`)
     - Label for Stopwatch Time (`lblStopwatchTime`)
     - Button for Submitting Form (`btnSubmit`)



### Step 3: Create the `ViewSubmissionsForm`

1. **Add a New Form:**
   - Right-click on the project in Solution Explorer.
   - Select `Add > Windows Form...`.
   - Name it `ViewSubmissionsForm.vb` and click `Add`.

2. **Design the Form:**
   - Add the following controls from the Toolbox:
     - TextBox for Name (`txtName`)
     - TextBox for Email (`txtEmail`)
     - TextBox for Phone Number (`txtPhone`)
     - TextBox for GitHub Link (`txtGithubLink`)
     - TextBox for Stopwatch Time (`txtStopwatchTime`)
     - Button for Previous Submission (`btnPrevious`)
     - Button for Next Submission (`btnNext`)

3. **Add the Code:**
   - Double-click `ViewSubmissionsForm` to open the code editor.
   - Add the code to retrieve and display form submissions:
     
### Step 4: Run the Application

1. **Start the Node.js Backend Server:**
   - Ensure your Node.js backend server is running. Navigate to the backend directory in Command Prompt and start the server:
     ```sh
     npx ts-node src/index.ts
     ```

2. **Run the Visual Basic Application:**
   - In Visual Studio, set the startup form to `CreateSubmissionForm` or `ViewSubmissionsForm` as needed.
   - Press `F5` to run the application.

3. **Test the Application:**
   - Use `CreateSubmissionForm` to submit new entries.
   - Use `ViewSubmissionsForm` to navigate through the submissions.

---
