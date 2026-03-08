# Contributing to ERA_CreatureEditor

Thank you for your interest in contributing. This document describes the contribution workflow, coding standards, and expectations for this project.

## Table of Contents
- [Getting Started](#getting-started)
- [Guidelines](#guidelines)
- [Branching and Pull Requests](#branching-and-pull-requests)
- [Coding Standards](#coding-standards)
- [Testing](#testing)
- [Commit Messages](#commit-messages)
- [Code Review](#code-review)
- [Reporting Issues](#reporting-issues)

## Getting Started
1. Fork the repository and clone your fork.
2. Create a feature branch for your work: `feature/short-description`.
3. Make small, atomic commits that are easy to review.
4. Open a pull request (PR) from your feature branch to `master`.

## Guidelines
- Keep changes focused and well-documented.
- Update or add unit tests for new logic where appropriate.
- Run the solution and verify no regressions in behavior.

## Branching and Pull Requests
- Branch names should use the format: `feature/`, `bugfix/`, or `hotfix/` followed by a short description. Example: `feature/load-json-robust`.
- Each PR should have a clear title and description explaining why the change is necessary.
- PRs should target the `master` branch.

## Coding Standards
This repository enforces a basic style using `.editorconfig` (root of repository). Key preferences:
- 4-space indentation
- UTF-8 files with CRLF line endings
- Trim trailing whitespace and ensure a final newline
- Prefer explicit types (avoid `var` for built-in types)
- Expression-bodied members are discouraged in this codebase for readability

Follow the rules in the `.editorconfig` file and keep changes consistent with the existing code style.


## Commit Messages
- Use present-tense, short subject lines (50 characters or less when possible).
- Include a brief body if the change needs extra context.
- Example:

  Fix: handle missing JSON resources gracefully

  - Return empty lists when JSON resources are not found
  - Show a non-blocking warning to the user


## Reporting Issues
- Please open issues for bugs or feature requests.
- Provide steps to reproduce the problem, expected vs actual behavior, and any relevant logs or screenshots.

## License and Attribution
This project includes content with licenses noted in the repository (see `LICENSE`). Respect third-party license requirements and attribution.

---
These guidelines are intentionally lightweight to enable fast iteration while keeping a consistent codebase. Thank you for contributing!
