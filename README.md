# 🔐 Password Validation Kata

## 🎯 Learning Objectives

This kata teaches you how to:
- **Use GitHub Copilot with Test-Driven Development (TDD)** - Learn to instruct Copilot to follow the RED → GREEN → REFACTOR cycle
- **Build features incrementally** - Implement one requirement at a time with focused commits
- **Write effective prompts** - Guide Copilot to generate tests first, then minimal implementation

## 📋 Prerequisites

- .NET 10.0 SDK or later
- GitHub Copilot with access to Chat/Plan/Agent modes
- Your preferred IDE (JetBrains Rider, Visual Studio, or VS Code)


## 📝 Problem Statement

In order to prevent yet another "Password123" incident, the business owner has asked you to add a password validation endpoint to the API. The team will build it iteratively using GitHub Copilot, following a strict TDD workflow.

## ✅ Acceptance Criteria

A password is **valid** only if it meets **all** the rules below:

### 1. Minimum Length
- **Rule**: Password must be at least 8 characters long.
- **Message** (exact): `Password must be at least 8 characters long.`

### 2. Uppercase Letter
- **Rule**: Password must contain at least one uppercase letter (A-Z).
- **Message** (exact): `Password must contain at least one uppercase letter.`

### 3. Lowercase Letter
- **Rule**: Password must contain at least one lowercase letter (a-z).
- **Message** (exact): `Password must contain at least one lowercase letter.`

### 4. Digit
- **Rule**: Password must contain at least one digit (0-9).
- **Message** (exact): `Password must contain at least one digit.`

---  

## 🛠️ Implementation Guide

This kata is intended to be implemented iteratively, **one feature at a time**, using GitHub Copilot following the TDD cycle.

### Step 1: Create a Plan for the First Increment (RED → GREEN → REFACTOR)

Use Copilot in **Plan mode** or **Chat mode** and request a plan for the first TDD increment. Example prompt:

```  
Plan the first TDD increment (RED→GREEN→REFACTOR) to add POST /password/validate.  
Feature: Minimum Length  
Rule: Password must be at least 8 characters long.  
Message (exact): Password must be at least 8 characters long.  
```  

A reasonable plan for the first increment could be:

```  
RED: Write `PasswordValidationTests.cs` with failing tests for the minimum length rule  
     (passwords of 8+ chars should be valid; passwords shorter than 8 should be invalid and return the exact message).

GREEN: Implement the `POST /password/validate` endpoint in `Program.cs` with request/response  
       records and the minimal logic to enforce minimum length. Run the tests and make the  
       simplest change to make them pass.

REFACTOR: Extract validation into a separate class (e.g., `PasswordValidator.cs`) to keep  
          the endpoint clean and follow single responsibility principle.

VERIFY: Run all tests again to ensure they still pass after refactoring.  
```  

Tip: For planning, use a sufficiently capable model so the generated plan is thorough.

### Step 2: Clarify Implementation Details

If Copilot asks clarifying questions, you can proceed with reasonable defaults or answer explicitly. Suggested defaults:

- Test cases to include: password with exactly 8 characters (valid), 7 characters (invalid), empty string (invalid). Treat `null` as invalid unless you decide otherwise and add a test for it.
- Response structure: Create `PasswordValidationRequest` and `PasswordValidationResponse` records similar to the existing `HealthResponse` pattern.
- Validation approach: Start with inline validation in the endpoint for the first increment (minimal change). If complexity grows, extract a validator class.

### Step 3: Execute the Plan

Switch Copilot to **Agent mode** and ejecute:
```  
Implement this feature following the plan.
```

### Step 4: Commit Changes

Once implementation is complete and all tests pass, create a small, focused commit using Conventional Commits. An example commit message:

```  
Analyze the current repo state and propose a small, intentional commit plan using Conventional Commits.
```  


### Step 5: Repeat for Remaining Features

Examples of prompts for subsequent increments:

**Feature: Uppercase Letter**
```  
Plan the next TDD increment (RED→GREEN→REFACTOR) to add uppercase letter validation.  
Rule: Password must contain at least one uppercase letter (A-Z).  
Message (exact): Password must contain at least one uppercase letter.  
```  

**Feature: Lowercase Letter**
```  
Plan the next TDD increment (RED→GREEN→REFACTOR) to add lowercase letter validation.  
Rule: Password must contain at least one lowercase letter (a-z).  
Message (exact): Password must contain at least one lowercase letter.  
```  

**Feature: Digit**
```  
Plan the next TDD increment (RED→GREEN→REFACTOR) to add digit validation.  
Rule: Password must contain at least one digit (0-9).  
Message (exact): Password must contain at least one digit.  
```  
  
---