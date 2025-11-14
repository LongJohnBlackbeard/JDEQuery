using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F06209 - .
/// </summary>
public class F06209 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Y_1VERT.
        /// </summary>
        public const string Y_1VERT = "Y_1VERT";

        /// <summary>
        /// Y_1PRID.
        /// </summary>
        public const string Y_1PRID = "Y_1PRID";

        /// <summary>
        /// Y_1VERF.
        /// </summary>
        public const string Y_1VERF = "Y_1VERF";

        /// <summary>
        /// Y_1VERR.
        /// </summary>
        public const string Y_1VERR = "Y_1VERR";

        /// <summary>
        /// Y_1PUI1.
        /// </summary>
        public const string Y_1PUI1 = "Y_1PUI1";

        /// <summary>
        /// Y_1PUI2.
        /// </summary>
        public const string Y_1PUI2 = "Y_1PUI2";

        /// <summary>
        /// Y_1PUI3.
        /// </summary>
        public const string Y_1PUI3 = "Y_1PUI3";

        /// <summary>
        /// Y_1PUI4.
        /// </summary>
        public const string Y_1PUI4 = "Y_1PUI4";

        /// <summary>
        /// Y_1PUI5.
        /// </summary>
        public const string Y_1PUI5 = "Y_1PUI5";

        /// <summary>
        /// Y_1CUI1.
        /// </summary>
        public const string Y_1CUI1 = "Y_1CUI1";

        /// <summary>
        /// Y_1CUI2.
        /// </summary>
        public const string Y_1CUI2 = "Y_1CUI2";

        /// <summary>
        /// Y_1CUI3.
        /// </summary>
        public const string Y_1CUI3 = "Y_1CUI3";

        /// <summary>
        /// Y_1CUI4.
        /// </summary>
        public const string Y_1CUI4 = "Y_1CUI4";

        /// <summary>
        /// Y_1CUI5.
        /// </summary>
        public const string Y_1CUI5 = "Y_1CUI5";

        /// <summary>
        /// Y_1JUI1.
        /// </summary>
        public const string Y_1JUI1 = "Y_1JUI1";

        /// <summary>
        /// Y_1JUI2.
        /// </summary>
        public const string Y_1JUI2 = "Y_1JUI2";

        /// <summary>
        /// Y_1JUI3.
        /// </summary>
        public const string Y_1JUI3 = "Y_1JUI3";

        /// <summary>
        /// Y_1JUI4.
        /// </summary>
        public const string Y_1JUI4 = "Y_1JUI4";

        /// <summary>
        /// Y_1JUI5.
        /// </summary>
        public const string Y_1JUI5 = "Y_1JUI5";

        /// <summary>
        /// Y_1RUI1.
        /// </summary>
        public const string Y_1RUI1 = "Y_1RUI1";

        /// <summary>
        /// Y_1RUI2.
        /// </summary>
        public const string Y_1RUI2 = "Y_1RUI2";

        /// <summary>
        /// Y_1RUI3.
        /// </summary>
        public const string Y_1RUI3 = "Y_1RUI3";

        /// <summary>
        /// Y_1RUI4.
        /// </summary>
        public const string Y_1RUI4 = "Y_1RUI4";

        /// <summary>
        /// Y_1RUI5.
        /// </summary>
        public const string Y_1RUI5 = "Y_1RUI5";

        /// <summary>
        /// Y_1UUI1.
        /// </summary>
        public const string Y_1UUI1 = "Y_1UUI1";

        /// <summary>
        /// Y_1UUI2.
        /// </summary>
        public const string Y_1UUI2 = "Y_1UUI2";

        /// <summary>
        /// Y_1UUI3.
        /// </summary>
        public const string Y_1UUI3 = "Y_1UUI3";

        /// <summary>
        /// Y_1UUI4.
        /// </summary>
        public const string Y_1UUI4 = "Y_1UUI4";

        /// <summary>
        /// Y_1UUI5.
        /// </summary>
        public const string Y_1UUI5 = "Y_1UUI5";

        /// <summary>
        /// Y_1VUI1.
        /// </summary>
        public const string Y_1VUI1 = "Y_1VUI1";

        /// <summary>
        /// Y_1VUI2.
        /// </summary>
        public const string Y_1VUI2 = "Y_1VUI2";

        /// <summary>
        /// Y_1VUI3.
        /// </summary>
        public const string Y_1VUI3 = "Y_1VUI3";

        /// <summary>
        /// Y_1VUI4.
        /// </summary>
        public const string Y_1VUI4 = "Y_1VUI4";

        /// <summary>
        /// Y_1VUI5.
        /// </summary>
        public const string Y_1VUI5 = "Y_1VUI5";

        /// <summary>
        /// Y_1EUI1.
        /// </summary>
        public const string Y_1EUI1 = "Y_1EUI1";

        /// <summary>
        /// Y_1EUI2.
        /// </summary>
        public const string Y_1EUI2 = "Y_1EUI2";

        /// <summary>
        /// Y_1EUI3.
        /// </summary>
        public const string Y_1EUI3 = "Y_1EUI3";

        /// <summary>
        /// Y_1EUI4.
        /// </summary>
        public const string Y_1EUI4 = "Y_1EUI4";

        /// <summary>
        /// Y_1EUI5.
        /// </summary>
        public const string Y_1EUI5 = "Y_1EUI5";

        /// <summary>
        /// Y_1NUI1.
        /// </summary>
        public const string Y_1NUI1 = "Y_1NUI1";

        /// <summary>
        /// Y_1NUI2.
        /// </summary>
        public const string Y_1NUI2 = "Y_1NUI2";

        /// <summary>
        /// Y_1NUI3.
        /// </summary>
        public const string Y_1NUI3 = "Y_1NUI3";

        /// <summary>
        /// Y_1NUI4.
        /// </summary>
        public const string Y_1NUI4 = "Y_1NUI4";

        /// <summary>
        /// Y_1NUI5.
        /// </summary>
        public const string Y_1NUI5 = "Y_1NUI5";

        /// <summary>
        /// Y_1DUI1.
        /// </summary>
        public const string Y_1DUI1 = "Y_1DUI1";

        /// <summary>
        /// Y_1DUI2.
        /// </summary>
        public const string Y_1DUI2 = "Y_1DUI2";

        /// <summary>
        /// Y_1DUI3.
        /// </summary>
        public const string Y_1DUI3 = "Y_1DUI3";

        /// <summary>
        /// Y_1DUI4.
        /// </summary>
        public const string Y_1DUI4 = "Y_1DUI4";

        /// <summary>
        /// Y_1DUI5.
        /// </summary>
        public const string Y_1DUI5 = "Y_1DUI5";

        /// <summary>
        /// Y_1IUI1.
        /// </summary>
        public const string Y_1IUI1 = "Y_1IUI1";

        /// <summary>
        /// Y_1IUI2.
        /// </summary>
        public const string Y_1IUI2 = "Y_1IUI2";

        /// <summary>
        /// Y_1IUI3.
        /// </summary>
        public const string Y_1IUI3 = "Y_1IUI3";

        /// <summary>
        /// Y_1IUI4.
        /// </summary>
        public const string Y_1IUI4 = "Y_1IUI4";

        /// <summary>
        /// Y_1IUI5.
        /// </summary>
        public const string Y_1IUI5 = "Y_1IUI5";

        /// <summary>
        /// Y_1KUI1.
        /// </summary>
        public const string Y_1KUI1 = "Y_1KUI1";

        /// <summary>
        /// Y_1KUI2.
        /// </summary>
        public const string Y_1KUI2 = "Y_1KUI2";

        /// <summary>
        /// Y_1KUI3.
        /// </summary>
        public const string Y_1KUI3 = "Y_1KUI3";

        /// <summary>
        /// Y_1KUI4.
        /// </summary>
        public const string Y_1KUI4 = "Y_1KUI4";

        /// <summary>
        /// Y_1KUI5.
        /// </summary>
        public const string Y_1KUI5 = "Y_1KUI5";

        /// <summary>
        /// Y_1TUI1.
        /// </summary>
        public const string Y_1TUI1 = "Y_1TUI1";

        /// <summary>
        /// Y_1TUI2.
        /// </summary>
        public const string Y_1TUI2 = "Y_1TUI2";

        /// <summary>
        /// Y_1TUI3.
        /// </summary>
        public const string Y_1TUI3 = "Y_1TUI3";

        /// <summary>
        /// Y_1TUI4.
        /// </summary>
        public const string Y_1TUI4 = "Y_1TUI4";

        /// <summary>
        /// Y_1TUI5.
        /// </summary>
        public const string Y_1TUI5 = "Y_1TUI5";
    }

    /// <inheritdoc />
    public override string TableName => "F06209";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Y_1VERT", "Y_1VERT", JdeDataType.String, 6),
        new JdeField("Y_1PRID", "Y_1PRID", JdeDataType.Numeric, null, true, true),
        new JdeField("Y_1VERF", "Y_1VERF", JdeDataType.String, 2),
        new JdeField("Y_1VERR", "Y_1VERR", JdeDataType.String, 2),
        new JdeField("Y_1PUI1", "Y_1PUI1", JdeDataType.String, 20),
        new JdeField("Y_1PUI2", "Y_1PUI2", JdeDataType.String, 20),
        new JdeField("Y_1PUI3", "Y_1PUI3", JdeDataType.String, 20),
        new JdeField("Y_1PUI4", "Y_1PUI4", JdeDataType.String, 20),
        new JdeField("Y_1PUI5", "Y_1PUI5", JdeDataType.String, 20),
        new JdeField("Y_1CUI1", "Y_1CUI1", JdeDataType.String, 20),
        new JdeField("Y_1CUI2", "Y_1CUI2", JdeDataType.String, 20),
        new JdeField("Y_1CUI3", "Y_1CUI3", JdeDataType.String, 20),
        new JdeField("Y_1CUI4", "Y_1CUI4", JdeDataType.String, 20),
        new JdeField("Y_1CUI5", "Y_1CUI5", JdeDataType.String, 20),
        new JdeField("Y_1JUI1", "Y_1JUI1", JdeDataType.String, 20),
        new JdeField("Y_1JUI2", "Y_1JUI2", JdeDataType.String, 20),
        new JdeField("Y_1JUI3", "Y_1JUI3", JdeDataType.String, 20),
        new JdeField("Y_1JUI4", "Y_1JUI4", JdeDataType.String, 20),
        new JdeField("Y_1JUI5", "Y_1JUI5", JdeDataType.String, 20),
        new JdeField("Y_1RUI1", "Y_1RUI1", JdeDataType.String, 20),
        new JdeField("Y_1RUI2", "Y_1RUI2", JdeDataType.String, 20),
        new JdeField("Y_1RUI3", "Y_1RUI3", JdeDataType.String, 20),
        new JdeField("Y_1RUI4", "Y_1RUI4", JdeDataType.String, 20),
        new JdeField("Y_1RUI5", "Y_1RUI5", JdeDataType.String, 20),
        new JdeField("Y_1UUI1", "Y_1UUI1", JdeDataType.String, 20),
        new JdeField("Y_1UUI2", "Y_1UUI2", JdeDataType.String, 20),
        new JdeField("Y_1UUI3", "Y_1UUI3", JdeDataType.String, 20),
        new JdeField("Y_1UUI4", "Y_1UUI4", JdeDataType.String, 20),
        new JdeField("Y_1UUI5", "Y_1UUI5", JdeDataType.String, 20),
        new JdeField("Y_1VUI1", "Y_1VUI1", JdeDataType.String, 20),
        new JdeField("Y_1VUI2", "Y_1VUI2", JdeDataType.String, 20),
        new JdeField("Y_1VUI3", "Y_1VUI3", JdeDataType.String, 20),
        new JdeField("Y_1VUI4", "Y_1VUI4", JdeDataType.String, 20),
        new JdeField("Y_1VUI5", "Y_1VUI5", JdeDataType.String, 20),
        new JdeField("Y_1EUI1", "Y_1EUI1", JdeDataType.String, 20),
        new JdeField("Y_1EUI2", "Y_1EUI2", JdeDataType.String, 20),
        new JdeField("Y_1EUI3", "Y_1EUI3", JdeDataType.String, 20),
        new JdeField("Y_1EUI4", "Y_1EUI4", JdeDataType.String, 20),
        new JdeField("Y_1EUI5", "Y_1EUI5", JdeDataType.String, 20),
        new JdeField("Y_1NUI1", "Y_1NUI1", JdeDataType.String, 20),
        new JdeField("Y_1NUI2", "Y_1NUI2", JdeDataType.String, 20),
        new JdeField("Y_1NUI3", "Y_1NUI3", JdeDataType.String, 20),
        new JdeField("Y_1NUI4", "Y_1NUI4", JdeDataType.String, 20),
        new JdeField("Y_1NUI5", "Y_1NUI5", JdeDataType.String, 20),
        new JdeField("Y_1DUI1", "Y_1DUI1", JdeDataType.String, 20),
        new JdeField("Y_1DUI2", "Y_1DUI2", JdeDataType.String, 20),
        new JdeField("Y_1DUI3", "Y_1DUI3", JdeDataType.String, 20),
        new JdeField("Y_1DUI4", "Y_1DUI4", JdeDataType.String, 20),
        new JdeField("Y_1DUI5", "Y_1DUI5", JdeDataType.String, 20),
        new JdeField("Y_1IUI1", "Y_1IUI1", JdeDataType.String, 20),
        new JdeField("Y_1IUI2", "Y_1IUI2", JdeDataType.String, 20),
        new JdeField("Y_1IUI3", "Y_1IUI3", JdeDataType.String, 20),
        new JdeField("Y_1IUI4", "Y_1IUI4", JdeDataType.String, 20),
        new JdeField("Y_1IUI5", "Y_1IUI5", JdeDataType.String, 20),
        new JdeField("Y_1KUI1", "Y_1KUI1", JdeDataType.String, 20),
        new JdeField("Y_1KUI2", "Y_1KUI2", JdeDataType.String, 20),
        new JdeField("Y_1KUI3", "Y_1KUI3", JdeDataType.String, 20),
        new JdeField("Y_1KUI4", "Y_1KUI4", JdeDataType.String, 20),
        new JdeField("Y_1KUI5", "Y_1KUI5", JdeDataType.String, 20),
        new JdeField("Y_1TUI1", "Y_1TUI1", JdeDataType.String, 20),
        new JdeField("Y_1TUI2", "Y_1TUI2", JdeDataType.String, 20),
        new JdeField("Y_1TUI3", "Y_1TUI3", JdeDataType.String, 20),
        new JdeField("Y_1TUI4", "Y_1TUI4", JdeDataType.String, 20),
        new JdeField("Y_1TUI5", "Y_1TUI5", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F06209_0", "Primary Key on Y_1PRID", new[] { "Y_1PRID" }, isUnique: true, isPrimaryKey: true)
    };
}
