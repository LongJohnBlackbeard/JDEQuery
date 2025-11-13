---
name: Bug Report
about: Report a bug or unexpected behavior
title: '[BUG] '
labels: bug
assignees: ''
---

## Bug Description
A clear and concise description of the bug.

## Steps to Reproduce
1. Configure with '...'
2. Execute query '...'
3. See error

## Expected Behavior
What you expected to happen.

## Actual Behavior
What actually happened.

## Environment
- **JDE Query Library Version:** [e.g., 0.1.0-alpha.1]
- **.NET Version:** [e.g., .NET 8.0]
- **Database:** [e.g., Oracle 19c]
- **JDE Schema:** [e.g., DV920, PY920, PROD920]
- **OS:** [e.g., Windows 11, Ubuntu 22.04]

## Code Sample
```csharp
// Minimal code to reproduce the issue
var client = new JdeClient(...);
var result = await client.Query<F0101Model>("F0101")
    .Where("ABAN8", 1001)
    .FetchSingleAsync();
```

## Error Message/Stack Trace
```
Paste any error messages or stack traces here
```

## Additional Context
Add any other context, screenshots, or information about the problem.

## Checklist
- [ ] I have searched existing issues to ensure this isn't a duplicate
- [ ] I have provided a minimal code sample to reproduce the issue
- [ ] I have included the library version and environment details
