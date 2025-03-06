# To-Do App (React)

## 📝 Features & User Stories

### ✅ 1. Task Management (CRUD)

- 🏷️ User Story: "As a user, I want to add, edit, delete, and mark tasks as completed so I can manage my to-do list effectively."
- Requirements:
  - Add a new task with a title and optional description
  - Edit an existing task
  - Delete a task
  - Mark a task as completed/incomplete

### ✅ 2. Task Organization

- 🏷️ User Story: "As a user, I want to filter and categorize tasks so I can focus on what matters."
- Requirements:
  - Filter by All / Completed / Pending
  - Optional: Add categories or priority levels

### ✅ 3. UI/UX & User Experience

- 🏷️ User Story: "As a user, I want a clean and simple UI that is easy to use."
- Requirements:
  - Responsive design (Mobile/Desktop)
  - User-friendly layout with minimal distractions
  - Nice animations (e.g., fading completed tasks, button hover effects)

### ✅ 4. API Integration

- 🏷️ User Story: "As a user, I want my tasks to be saved persistently so they don’t disappear when I refresh the page."
- Requirements:
  - Fetch tasks from the .NET API
  - Add, update, delete tasks via API requests
  - Store data in SQL Server

### ✅ 5. Local Storage (Optional for MVP)

- 🏷️ User Story: "As a user, I want my tasks to be temporarily stored even if I’m offline."
- Requirements:
  - Save tasks in local storage if API is unavailable

### ✅ 6. Authentication (Optional - Advanced)

- 🏷️ User Story: "As a user, I want to sign in and see my own tasks only."
- Requirements:
  - User authentication (JWT-based login)
  - Associate tasks with users

## 🚀 Development Phases

### 1️⃣ Planning & Setup

- Choose UI design
- Setup React project with Tailwind CSS
- Setup .NET API with SQL Server

### 2️⃣ Core Features (CRUD)

- Implement adding, editing, deleting, and marking tasks as completed

### 3️⃣ API Integration

- Connect frontend to backend
- Fetch tasks, add new tasks, update and delete tasks via API

### 4️⃣ Task Organization (Filters & UI Improvements)

- Implement filtering (All / Completed / Pending)
- Improve UI with animations

### 5️⃣ Polishing & Extras

- Optional: Local storage for offline use
- Optional: Authentication (if you want user-specific tasks)
