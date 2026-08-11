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

echo "==> Fetching remote..."
git fetch origin

# Make sure we are on main
if git show-ref --verify --quiet refs/heads/main; then
    git checkout main
else
    git checkout -b main
fi

echo "==> Checking status..."
git status

echo "==> Adding files..."
git add .

echo "==> Creating commit..."
git commit -m "Update Contacts App" || echo "No new changes to commit."

echo "==> Pulling remote changes..."
git pull --rebase origin main

echo "==> Pushing to GitHub..."
git push -u origin main

echo "==> Done!"