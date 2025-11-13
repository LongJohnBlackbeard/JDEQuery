# Security Policy

## Supported Versions

The following versions of JDE Query Library are currently supported with security updates:

| Version | Supported          |
| ------- | ------------------ |
| 0.1.x   | :white_check_mark: |

## Reporting a Vulnerability

We take security vulnerabilities seriously. If you discover a security vulnerability in the JDE Query Library, please follow these steps:

### How to Report

**Please DO NOT report security vulnerabilities through public GitHub issues.**

Instead, please report them via one of the following methods:

1. **GitHub Security Advisory** (Preferred)
   - Navigate to the [Security Advisories](https://github.com/LongJohnBlackbeard/JDEQuery/security/advisories) page
   - Click "Report a vulnerability"
   - Fill in the details

2. **Email**
   - Send an email to: [INSERT YOUR SECURITY EMAIL]
   - Use the subject line: "SECURITY: [Brief description]"

### What to Include

Please include the following information in your report:

- **Description** of the vulnerability
- **Steps to reproduce** the issue
- **Potential impact** of the vulnerability
- **Suggested fix** (if you have one)
- **Affected versions** of the library
- Your **contact information** for follow-up

### What to Expect

- **Acknowledgment**: Within 48 hours of your report
- **Initial Assessment**: Within 7 days
- **Status Updates**: Regular updates on the progress
- **Fix Timeline**: Critical vulnerabilities will be addressed immediately

### Disclosure Policy

- We will coordinate with you to understand the issue fully
- We will work on a fix and prepare a security advisory
- Once a fix is ready, we will:
  1. Release a patched version
  2. Publish a security advisory
  3. Credit you (unless you prefer to remain anonymous)

## Security Best Practices

When using the JDE Query Library, follow these best practices:

### 1. Connection String Security

```csharp
// ❌ DON'T: Hardcode credentials
services.AddJdeQueryOracle(
    "User Id=admin;Password=password123;Data Source=prod",
    "PROD920");

// ✅ DO: Use configuration and secrets management
services.AddJdeQuery(configuration, "JdeQuery");
```

### 2. User-Provided Input

```csharp
// ❌ DON'T: Build SQL strings from user input (not applicable - library uses parameterized queries)
// The library automatically parameterizes all queries

// ✅ DO: Use the query builder (automatically parameterized)
var result = await client.Query<F0101Model>("F0101")
    .Where("ABALPH", userInput)  // Automatically parameterized
    .FetchManyAsync();
```

### 3. Environment Configuration

```json
{
  "JdeQuery": {
    "ConnectionString": "${JDE_CONNECTION_STRING}",
    "Schema": "${JDE_SCHEMA}",
    "Provider": "Oracle"
  }
}
```

Use environment variables or Azure Key Vault for production credentials.

### 4. Principle of Least Privilege

- Use database accounts with minimal required permissions
- Grant only SELECT permissions if read-only access is needed
- Use separate accounts for different environments

### 5. Keep Dependencies Updated

- Regularly update to the latest version of JDE Query Library
- Monitor security advisories via GitHub
- Enable Dependabot alerts

## Known Security Considerations

### SQL Injection Protection

The JDE Query Library uses **parameterized queries** exclusively. All user-provided values are passed as parameters, not concatenated into SQL strings, providing protection against SQL injection attacks.

### Connection String Encryption

Connection strings may contain sensitive credentials. Always:
- Store them in secure configuration (Azure Key Vault, AWS Secrets Manager, etc.)
- Never commit them to version control
- Use encrypted configuration in production

### Data Exposure

JDE tables often contain sensitive business data. Ensure:
- Proper authentication and authorization in your application
- Logging doesn't expose sensitive query results
- Error messages don't reveal table structure or data

## Security Updates

Security updates will be published as:
- GitHub Security Advisories
- New releases with security patches
- Updates to this SECURITY.md file

Subscribe to repository notifications to stay informed.

## Acknowledgments

We appreciate the security research community's efforts in responsibly disclosing vulnerabilities. Contributors who report valid security issues will be acknowledged in:
- The security advisory
- Release notes
- This SECURITY.md file (unless they prefer anonymity)

---

**Last Updated:** 2025-11-13
