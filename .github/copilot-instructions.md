# GitHub Copilot Instructions for Kolra's Coolant Beads (Continued)

## Mod Overview and Purpose

Kolra's Coolant Beads (Continued) is a RimWorld mod that introduces a unique species of slimeball creatures known as coolant beads. These creatures consume heat to survive and were originally created by archotechs to keep their engines cool. Over time, they became adopted by many desert-dwelling colonies across the known universe.

The mod aims to provide a new and interesting creature to the RimWorld world without causing any conflicts or dependencies with other mods. The sprite for the coolant beads is currently a placeholder, and plans are in place to replace it with a more suitable image.

## Key Features and Systems

### Coolant Beads
- **Heat Consumption**: Coolant beads consume heat to survive, making them useful in environments with high temperatures.
- **Mitosis Ability**: The coolant beads have the ability to split into smaller individuals, providing a unique reproductive mechanism.

### Buildings
- **Cold Hive**: A building that generates cold air, which can be beneficial for the coolant beads and other temperature-sensitive creatures.

### Items
- **Animal Products**: Items derived from the coolant beads, which can be used for various purposes in the game.

## Coding Patterns and Conventions

### C# Files
- **CompProperties_Mitosis.cs**: Contains properties for the mitosis component of the coolant beads.
- **Comp_Mitosis.cs**: Implements the mitosis functionality, including methods for splitting, temperature adjustment, and data exposure.

### XML Integration
- **Bodies_Animal_Coolant_Bead.xml**: Defines the body properties of the coolant beads.
- **BodyParts_Animal.xml**: Defines the body parts of the coolant beads.
- **ColdHive.xml**: Defines the properties of the cold hive building.
- **Items_Resource_AnimalProduct.xml**: Defines items derived from the coolant beads.
- **Items_Resource_Stuff_Leather.xml**: Defines leather items derived from the coolant beads.

## Harmony Patching

The mod uses Harmony patching to integrate its custom components and behaviors into the RimWorld game engine. This ensures that the coolant beads and other elements of the mod function seamlessly within the game world.

## Suggestions for Copilot

### General Suggestions
- **Use Descriptive Naming**: Use clear and descriptive names for types, methods, and variables to enhance code readability.
- **Follow Coding Conventions**: Adhere to established coding conventions to maintain consistency within the mod.
- **Document Code**: Include comments and documentation to explain complex logic and functionality.

### XML Files
- **Structure and Formatting**: Ensure that XML files are well-structured and properly formatted to avoid parsing errors.
- **Def References**: Use correct references for Defs to ensure proper integration with the RimWorld game engine.

### C# Files
- **Component Design**: Design components in a modular and reusable way to enhance maintainability.
- **Error Handling**: Implement robust error handling to manage unexpected situations gracefully.

## Contributing to the Mod

If you are interested in contributing to the mod, please follow these guidelines:
- **Fork the Repository**: Fork the main repository to your GitHub account.
- **Create a Branch**: Create a new branch for your changes.
- **Implement Changes**: Make the necessary changes to the mod.
- **Test Changes**: Thoroughly test your changes to ensure they work as expected.
- **Submit a Pull Request**: Submit a pull request to the main repository with your changes.

By following these guidelines, you can help improve Kolra's Coolant Beads (Continued) and contribute to the RimWorld modding community.



This detailed `.github/copilot-instructions.md` file provides a comprehensive overview of the Kolra's Coolant Beads (Continued) mod, including its purpose, key features, coding patterns, XML integration, harmony patching, and suggestions for using GitHub Copilot effectively.

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.

