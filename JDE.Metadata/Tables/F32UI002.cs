using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F32UI002 - .
/// </summary>
public class F32UI002 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WYCTID.
        /// </summary>
        public const string WYCTID = "WYCTID";

        /// <summary>
        /// WYJOBS.
        /// </summary>
        public const string WYJOBS = "WYJOBS";

        /// <summary>
        /// WYLNID.
        /// </summary>
        public const string WYLNID = "WYLNID";

        /// <summary>
        /// WYDTAI.
        /// </summary>
        public const string WYDTAI = "WYDTAI";

        /// <summary>
        /// WYDL01.
        /// </summary>
        public const string WYDL01 = "WYDL01";
    }

    /// <inheritdoc />
    public override string TableName => "F32UI002";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WYCTID", "WYCTID", JdeDataType.String, 30, true, true),
        new JdeField("WYJOBS", "WYJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("WYLNID", "WYLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("WYDTAI", "WYDTAI", JdeDataType.String, 20),
        new JdeField("WYDL01", "WYDL01", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F32UI002_0", "Primary Key on WYCTID, WYJOBS, WYLNID", new[] { "WYCTID", "WYJOBS", "WYLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
