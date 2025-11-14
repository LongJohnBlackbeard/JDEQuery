using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3112Z1T - .
/// </summary>
public class F3112Z1T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SZEDUS.
        /// </summary>
        public const string SZEDUS = "SZEDUS";

        /// <summary>
        /// SZEDBT.
        /// </summary>
        public const string SZEDBT = "SZEDBT";

        /// <summary>
        /// SZEDTN.
        /// </summary>
        public const string SZEDTN = "SZEDTN";

        /// <summary>
        /// SZEDLN.
        /// </summary>
        public const string SZEDLN = "SZEDLN";

        /// <summary>
        /// SZOPSQ.
        /// </summary>
        public const string SZOPSQ = "SZOPSQ";

        /// <summary>
        /// SZOPSC.
        /// </summary>
        public const string SZOPSC = "SZOPSC";

        /// <summary>
        /// SZMCU.
        /// </summary>
        public const string SZMCU = "SZMCU";

        /// <summary>
        /// SZSHFT.
        /// </summary>
        public const string SZSHFT = "SZSHFT";
    }

    /// <inheritdoc />
    public override string TableName => "F3112Z1T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SZEDUS", "SZEDUS", JdeDataType.String, 20, true, true),
        new JdeField("SZEDBT", "SZEDBT", JdeDataType.String, 30, true, true),
        new JdeField("SZEDTN", "SZEDTN", JdeDataType.String, 44, true, true),
        new JdeField("SZEDLN", "SZEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("SZOPSQ", "SZOPSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("SZOPSC", "SZOPSC", JdeDataType.String, 4, true, true),
        new JdeField("SZMCU", "SZMCU", JdeDataType.String, 24, true, true),
        new JdeField("SZSHFT", "SZSHFT", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3112Z1T_0", "Primary Key on SZEDUS, SZEDBT, SZEDTN, SZEDLN, SZOPSQ, SZOPSC, SZMCU", new[] { "SZEDUS", "SZEDBT", "SZEDTN", "SZEDLN", "SZOPSQ", "SZOPSC", "SZMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
