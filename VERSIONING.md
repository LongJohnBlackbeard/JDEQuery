# Versioning Strategy

This document outlines the versioning strategy for the JDE Query Library NuGet packages.

## Semantic Versioning 2.0.0

We follow [Semantic Versioning 2.0.0](https://semver.org/) for all NuGet packages:

```
MAJOR.MINOR.PATCH[-PRERELEASE][+BUILD]
```

### Version Components

- **MAJOR**: Incremented for breaking changes (incompatible API changes)
- **MINOR**: Incremented for new features (backward-compatible functionality)
- **PATCH**: Incremented for bug fixes (backward-compatible bug fixes)
- **PRERELEASE**: Optional label for pre-release versions
- **BUILD**: Optional build metadata

### Examples

- `1.0.0` - Stable release
- `1.1.0` - New features added
- `1.1.1` - Bug fixes
- `2.0.0` - Breaking changes
- `1.0.0-alpha.1` - Alpha pre-release
- `1.0.0-beta.2` - Beta pre-release
- `1.0.0-rc.1` - Release candidate

## Pre-Release Labels

We use the following pre-release labels:

| Label | Purpose | Stability | Example |
|-------|---------|-----------|---------|
| `alpha` | Early development, unstable API | Low | `1.0.0-alpha.1` |
| `beta` | Feature complete, API may change | Medium | `1.0.0-beta.1` |
| `rc` | Release candidate, API stable | High | `1.0.0-rc.1` |

### Pre-Release Progression

```
0.1.0-alpha.1 → 0.1.0-alpha.2 → ... → 0.1.0-beta.1 → 0.1.0-beta.2 → ... → 0.1.0-rc.1 → 1.0.0
```

## Synchronized Versioning

All 8 projects in the solution share the **same version number**:

- JDE.Abstractions
- JDE.Core
- JDE.Providers.Abstractions
- JDE.Providers.Oracle
- JDE.Metadata
- JDE.Models
- JDE.Client
- JDE.Tests (not published to NuGet)

### Benefits

- **Simple**: Users know which versions work together
- **Clear**: Version 1.2.0 of all packages are compatible
- **Easy**: One version bump updates all packages

### Implementation

Version is centrally managed in `Directory.Build.props` and automatically applied to all projects.

## Version Management

### Current Version

The current version is defined in `Directory.Build.props`:

```xml
<PropertyGroup>
  <VersionPrefix>0.1.0</VersionPrefix>
  <VersionSuffix>alpha.1</VersionSuffix>
</PropertyGroup>
```

### Updating Version

1. **For new features (minor version)**:
   ```bash
   # Update Directory.Build.props: 0.1.0 → 0.2.0
   git commit -m "chore: bump version to 0.2.0-alpha.1"
   git tag v0.2.0-alpha.1
   ```

2. **For bug fixes (patch version)**:
   ```bash
   # Update Directory.Build.props: 0.1.0 → 0.1.1
   git commit -m "chore: bump version to 0.1.1"
   git tag v0.1.1
   ```

3. **For breaking changes (major version)**:
   ```bash
   # Update Directory.Build.props: 0.1.0 → 1.0.0
   git commit -m "chore: bump version to 1.0.0"
   git tag v1.0.0
   ```

## Release Process

### Pre-Release (alpha/beta/rc)

1. Update version in `Directory.Build.props`
2. Commit changes
3. Create Git tag: `git tag v0.1.0-alpha.1`
4. Push tag: `git push origin v0.1.0-alpha.1`
5. CI/CD builds and publishes to NuGet with pre-release flag

### Stable Release

1. Remove `-PRERELEASE` suffix in `Directory.Build.props`
2. Update CHANGELOG.md
3. Commit changes
4. Create Git tag: `git tag v1.0.0`
5. Push tag: `git push origin v1.0.0`
6. CI/CD builds and publishes to NuGet as stable
7. Create GitHub Release with release notes

## Git Tagging Strategy

All version tags follow the format `vMAJOR.MINOR.PATCH[-PRERELEASE]`:

- `v0.1.0-alpha.1` - Alpha pre-release
- `v0.1.0-beta.1` - Beta pre-release
- `v0.1.0-rc.1` - Release candidate
- `v1.0.0` - Stable release

## Version History

| Version | Release Date | Type | Notes |
|---------|--------------|------|-------|
| 0.1.0-alpha.1 | TBD | Pre-release | Initial alpha release |

## Breaking Change Policy

### What Constitutes a Breaking Change?

- Removing public APIs
- Changing method signatures
- Changing existing behavior that users depend on
- Renaming public types or members
- Changing package dependencies that affect consumers

### Non-Breaking Changes

- Adding new APIs
- Adding optional parameters with defaults
- Internal refactoring
- Bug fixes (even if behavior changes, if the original behavior was a bug)
- Performance improvements

### Handling Breaking Changes

1. Deprecate the old API (mark with `[Obsolete]`)
2. Provide migration path in documentation
3. Include in CHANGELOG.md with **BREAKING CHANGE** label
4. Increment MAJOR version
5. Update migration guide in docs

## Version in Code

Version information is embedded in assemblies:

```csharp
// Accessing version at runtime
var version = typeof(JdeClient).Assembly.GetName().Version;
var informationalVersion = typeof(JdeClient).Assembly
    .GetCustomAttribute<AssemblyInformationalVersionAttribute>()
    ?.InformationalVersion;
```

## CI/CD Integration

### Automated Versioning

- Git tags trigger NuGet package builds
- `v*-alpha.*` → Publish to NuGet with `-alpha` label
- `v*-beta.*` → Publish to NuGet with `-beta` label
- `v*-rc.*` → Publish to NuGet with `-rc` label
- `v*` (no suffix) → Publish to NuGet as stable

### Package Publishing

- **Pre-release**: Published on every pre-release tag
- **Stable**: Published only on stable version tags
- **Main branch**: No automatic publishing (manual releases only)

## References

- [Semantic Versioning 2.0.0](https://semver.org/)
- [NuGet Package Versioning](https://docs.microsoft.com/en-us/nuget/concepts/package-versioning)
- [.NET Versioning Best Practices](https://docs.microsoft.com/en-us/dotnet/standard/library-guidance/versioning)

---

**Last Updated**: 2025-11-13
**Current Version**: 0.1.0-alpha.1
