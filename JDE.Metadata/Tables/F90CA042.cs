using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA042 - .
/// </summary>
public class F90CA042 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EMAN8.
        /// </summary>
        public const string EMAN8 = "EMAN8";

        /// <summary>
        /// EMPA8.
        /// </summary>
        public const string EMPA8 = "EMPA8";

        /// <summary>
        /// EMEMH.
        /// </summary>
        public const string EMEMH = "EMEMH";

        /// <summary>
        /// EMEDATE.
        /// </summary>
        public const string EMEDATE = "EMEDATE";

        /// <summary>
        /// EMUSER.
        /// </summary>
        public const string EMUSER = "EMUSER";

        /// <summary>
        /// EMUDTTM.
        /// </summary>
        public const string EMUDTTM = "EMUDTTM";

        /// <summary>
        /// EMMKEY.
        /// </summary>
        public const string EMMKEY = "EMMKEY";

        /// <summary>
        /// EMENTDBY.
        /// </summary>
        public const string EMENTDBY = "EMENTDBY";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA042";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EMAN8", "EMAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("EMPA8", "EMPA8", JdeDataType.Numeric, null, true, true),
        new JdeField("EMEMH", "EMEMH", JdeDataType.Numeric),
        new JdeField("EMEDATE", "EMEDATE", JdeDataType.Date),
        new JdeField("EMUSER", "EMUSER", JdeDataType.String, 20),
        new JdeField("EMUDTTM", "EMUDTTM", JdeDataType.Date),
        new JdeField("EMMKEY", "EMMKEY", JdeDataType.String, 30),
        new JdeField("EMENTDBY", "EMENTDBY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA042_0", "Primary Key on EMAN8, EMPA8", new[] { "EMAN8", "EMPA8" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F90CA042_2", "Index on EMAN8", new[] { "EMAN8" }),
        new JdeIndex("F90CA042_3", "Index on EMPA8", new[] { "EMPA8" }),
        new JdeIndex("F90CA042_4", "Index on EMEMH", new[] { "EMEMH" })
    };
}
