#!/bin/bash

# Project path
cd "/d/Self-Study/C#/Ado.Net" || exit 1

# Repository
REMOTE="https://github.com/osama-dev2206/ContactsApp-ConsoleAppVer.git"

echo "==> Checking Git repository..."

# Initialize Git if needed
if [ ! -d ".git" ]; then
    echo "==> Initializing Git..."
    git init
fi

# Set remote
if git remote get-url origin >/dev/null 2>&1; then
    git remote set-url origin "$REMOTE"
else
    git remote add origin "$REMOTE"
fi

# Ask for commit message
echo
read -p "Enter your commit message: " COMMIT_MESSAGE

if [ -z "$COMMIT_MESSAGE" ]; then
    echo "Error: Commit message cannot be empty."
    exit 1
fi

echo
echo "==> Fetching remote..."
git fetch origin

# Make sure we are on main
if git show-ref --verify --quiet refs/heads/main; then
    git checkout main
else
    git checkout -b main
fi

echo "==> Adding files..."
git add .

echo "==> Creating commit..."
git commit -m "$COMMIT_MESSAGE"

if [ $? -ne 0 ]; then
    echo "No changes to commit or commit failed."
    exit 1
fi

echo "==> Pulling remote changes..."
git pull --rebase origin main

if [ $? -ne 0 ]; then
    echo "Pull failed. Resolve the conflict manually."
    exit 1
fi

echo "==> Pushing to GitHub..."
git push -u origin main

if [ $? -ne 0 ]; then
    echo "Push failed."
    exit 1
fi

echo
echo "==> Successfully pushed to GitHub!"